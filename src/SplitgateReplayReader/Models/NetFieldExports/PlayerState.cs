using Unreal.Core.Attributes;
using Unreal.Core.Contracts;
using Unreal.Core.Models;
using Unreal.Core.Models.Enums;

namespace SplitgateReplayReader.Models.NetFieldExports;

[NetFieldExportGroup("/Script/PortalWars.PortalWarsPlayerState", minimalParseMode: ParseMode.Minimal)]
public class FortPlayerState : INetFieldExportGroup
{
    [NetFieldExportHandle(4, RepLayoutCmdType.Ignore)]
    public uint? RemoteRole { get; set; }

    [NetFieldExportHandle(12, RepLayoutCmdType.Ignore)]
    public uint? Owner { get; set; }

    [NetFieldExportHandle(13, RepLayoutCmdType.Ignore)]
    public uint? Role { get; set; }

    [NetFieldExportHandle(16, RepLayoutCmdType.PropertyInt)]
    public int? PlayerId { get; set; }

    [NetFieldExportHandle(17, RepLayoutCmdType.PropertyInt)]
    public int? Ping { get; set; }

    [NetFieldExportHandle(19, RepLayoutCmdType.PropertyBool)]
    public bool? bOnlySpectator { get; set; }

    [NetFieldExportHandle(20, RepLayoutCmdType.PropertyBool)]
    public bool? bIsABot { get; set; }

    [NetFieldExportHandle(23, RepLayoutCmdType.PropertyInt)]
    public int? StartTime { get; set; }

    [NetFieldExportHandle(24, RepLayoutCmdType.PropertyNetId)]
    public string? UniqueId { get; set; }

    [NetFieldExportHandle(25, RepLayoutCmdType.PropertyString)]
    public string? PlayerNamePrivate { get; set; }

    [NetFieldExportHandle(26, RepLayoutCmdType.PropertyInt)]
    public int? TeamIndex { get; set; }

    [NetFieldExportHandle(51, RepLayoutCmdType.Ignore)]
    public int? Weapons { get; set; }

    [NetFieldExportHandle(52, RepLayoutCmdType.PropertyString)]
    public string? Name { get; set; }

    [NetFieldExportHandle(53, RepLayoutCmdType.PropertyInt)]
    public int? ShotsFired { get; set; }

    [NetFieldExportHandle(54, RepLayoutCmdType.PropertyInt)]
    public int? ShotsLanded { get; set; }

    [NetFieldExportHandle(55, RepLayoutCmdType.PropertyInt)]
    public int? DoubleKills { get; set; }

    [NetFieldExportHandle(56, RepLayoutCmdType.PropertyInt)]
    public int? TripleKills { get; set; }

    [NetFieldExportHandle(57, RepLayoutCmdType.PropertyInt)]
    public int? QuadKills { get; set; }

    [NetFieldExportHandle(58, RepLayoutCmdType.PropertyInt)]
    public int? QuintKills { get; set; }

    [NetFieldExportHandle(59, RepLayoutCmdType.PropertyInt)]
    public int? SexKills { get; set; }

    [NetFieldExportHandle(60, RepLayoutCmdType.PropertyInt)]
    public int? MaxKillsWithSinglePickup { get; set; }

    [NetFieldExportHandle(86, RepLayoutCmdType.PropertyInt)]
    public int? EncodedCompositeUserId { get; set; }

    [NetFieldExportHandle(87, RepLayoutCmdType.PropertyInt)]
    public int? Team { get; set; }

    [NetFieldExportHandle(88, RepLayoutCmdType.Ignore)]
    public DebuggingObject? Customizations { get; set; }

    [NetFieldExportHandle(89, RepLayoutCmdType.Ignore)]
    public DebuggingObject? CustomizationType { get; set; }

    [NetFieldExportHandle(90, RepLayoutCmdType.Ignore)]
    public DebuggingObject? CustomizationValue { get; set; }

    [NetFieldExportHandle(115, RepLayoutCmdType.Ignore)]
    public int? Name2 { get; set; }

    [NetFieldExportHandle(116, RepLayoutCmdType.PropertyInt)]
    public int? ShotsFired2 { get; set; }

    [NetFieldExportHandle(117, RepLayoutCmdType.PropertyInt)]
    public int? ShotsLanded2 { get; set; }

    [NetFieldExportHandle(118, RepLayoutCmdType.PropertyInt)]
    public int? DoubleKills2 { get; set; }

    [NetFieldExportHandle(119, RepLayoutCmdType.PropertyInt)]
    public int? TripleKills2 { get; set; }

    [NetFieldExportHandle(120, RepLayoutCmdType.PropertyInt)]
    public int? QuadKills2 { get; set; }

    [NetFieldExportHandle(121, RepLayoutCmdType.PropertyInt)]
    public int? QuintKills2 { get; set; }

    [NetFieldExportHandle(122, RepLayoutCmdType.PropertyInt)]
    public int? SexKills2 { get; set; }

    [NetFieldExportHandle(123, RepLayoutCmdType.PropertyInt)]
    public int? MaxKillsWithSinglePickup2 { get; set; }

    [NetFieldExportHandle(153, RepLayoutCmdType.PropertyString)]
    public string? PlayerName { get; set; }

    [NetFieldExportHandle(154, RepLayoutCmdType.PropertyInt)]
    public int? RankType { get; set; }

    [NetFieldExportHandle(155, RepLayoutCmdType.PropertyInt)]
    public int? RankLevel { get; set; }

    [NetFieldExportHandle(156, RepLayoutCmdType.PropertyInt)]
    public int? RankXP { get; set; }

    [NetFieldExportHandle(157, RepLayoutCmdType.PropertyInt)]
    public int? PlacementGamesPlayedCount { get; set; }

    [NetFieldExportHandle(158, RepLayoutCmdType.PropertyInt)]
    public int? PlacementGamesPlayedTotal { get; set; }

    [NetFieldExportHandle(159, RepLayoutCmdType.PropertyInt)]
    public int? Xp { get; set; }

    [NetFieldExportHandle(160, RepLayoutCmdType.PropertyInt)]
    public int? Level { get; set; }

    [NetFieldExportHandle(161, RepLayoutCmdType.PropertyBool)]
    public bool? HasPlayedToday { get; set; }

    [NetFieldExportHandle(162, RepLayoutCmdType.PropertyBool)]
    public bool? Value { get; set; }

    [NetFieldExportHandle(166, RepLayoutCmdType.PropertyBool)]
    public bool? HasBeenReceived { get; set; }

    [NetFieldExportHandle(167, RepLayoutCmdType.PropertyBool)]
    public bool? bIsABot2 { get; set; }

    [NetFieldExportHandle(168, RepLayoutCmdType.PropertyInt)]
    public int? ID { get; set; }

    [NetFieldExportHandle(172, RepLayoutCmdType.PropertyString)]
    public string? Name3 { get; set; }

    [NetFieldExportHandle(173, RepLayoutCmdType.PropertyString)]
    public string? Avatar { get; set; }

    [NetFieldExportHandle(174, RepLayoutCmdType.PropertyString)]
    public string? AvatarPath { get; set; }

    //PlayerCustomizations (handle: 176)
    //CustomizationType (handle: 177)
    //CustomizationValue (handle: 178)
    //PlayerRanks (handle: 180)
    //RankType (handle: 181)
    //RankLevel (handle: 182)
    //RankXP (handle: 183)
    //PlacementGamesPlayedCount (handle: 184)
    //PlacementGamesPlayedTotal (handle: 185)
    //Xp (handle: 187)
    //Level (handle: 188)
    //HasPlayedToday (handle: 189)
    //Value (handle: 190)
    //HasBeenReceived (handle: 194)
    //ID (handle: 202)
    //Name (handle: 206)
    //avatar (handle: 207)
    //AvatarPath (handle: 208)
    //SimulatedFOV (handle: 209)
}