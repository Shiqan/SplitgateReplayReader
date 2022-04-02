using Microsoft.Extensions.Logging;
using SplitgateReplayReader.Models;
using Unreal.Core;
using Unreal.Core.Contracts;
using Unreal.Core.Exceptions;
using Unreal.Core.Models;
using Unreal.Core.Models.Enums;

namespace SplitgateReplayReader;

public class ReplayReader : Unreal.Core.ReplayReader<SplitgateReplay>
{
    public ReplayReader(ILogger logger, ParseMode mode) : base(logger, mode)
    {
    }

    public SplitgateReplay ReadReplay(string fileName)
    {
        using var stream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        return ReadReplay(stream);
    }

    public SplitgateReplay ReadReplay(Stream stream)
    {
        using var archive = new Unreal.Core.BinaryReader(stream);
        ReadReplay(archive);

        return Replay;
    }

    public override void ReadEvent(FArchive archive)
    {
        var info = new EventInfo
        {
            Id = archive.ReadFString(),
            Group = archive.ReadFString(),
            Metadata = archive.ReadFString(),
            StartTime = archive.ReadUInt32(),
            EndTime = archive.ReadUInt32(),
            SizeInBytes = archive.ReadInt32()
        };

        _logger?.LogDebug("Encountered event {group} ({metadata}) at {startTime} of size {sizeInBytes}", info.Group, info.Metadata, info.StartTime, info.SizeInBytes);

        if (info.Metadata == ReplayEventTypes.MAP)
        {
            Replay.Map = archive.ReadFString();
        }
        else if (info.Metadata == ReplayEventTypes.MODE)
        {
            Replay.Mode = archive.ReadFString();
        }
        else if (info.Metadata == ReplayEventTypes.SCORE)
        {
            Replay.Score = archive.ReadFString();
        }
        else if (info.Metadata == ReplayEventTypes.KILLS)
        {
            if (int.TryParse(archive.ReadFString(), out var kills))
            {
                Replay.Kills = kills;
            }
        }
        else if (info.Metadata == ReplayEventTypes.DEATHS)
        {
            if (int.TryParse(archive.ReadFString(), out var deaths))
            {
                Replay.Deaths = deaths;
            }
        }
        else
        {
            _logger?.LogWarning("Unknown event {group} ({metadata}) of size {sizeInBytes}", info.Group, info.Metadata, info.SizeInBytes);
            if (IsDebugMode)
            {
                throw new UnknownEventException($"Unknown event {info.Group} ({info.Metadata}) of size {info.SizeInBytes}");
            }
        }
    }

    protected override void OnExportRead(uint channelIndex, INetFieldExportGroup? exportGroup) => throw new NotImplementedException();
    protected override void OnExternalDataRead(uint channelIndex, IExternalData? exportGroup) => throw new NotImplementedException();
    protected override void OnNetDeltaRead(uint channelIndex, NetDeltaUpdate update) => throw new NotImplementedException();
}
