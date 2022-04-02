using Unreal.Core.Models;

namespace SplitgateReplayReader.Models;

public class SplitgateReplay : Replay
{
    public string Map { get; set; }
    public string Mode { get; set; }
    public string Score { get; set; }
    public int Kills { get; set; }
    public int Deaths { get; set; }
}
