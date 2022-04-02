using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SplitgateReplayReader;
using Unreal.Core.Models.Enums;
using static System.Environment;

var serviceCollection = new ServiceCollection()
    .AddLogging(loggingBuilder => loggingBuilder
        .AddConsole()
        .SetMinimumLevel(LogLevel.Debug));
var provider = serviceCollection.BuildServiceProvider();
var logger = provider.GetRequiredService<ILogger<Program>>();

var localAppDataFolder = GetFolderPath(SpecialFolder.LocalApplicationData);
var replayFilesFolder = Path.Combine(localAppDataFolder, @"PortalWars\Saved\Demos");
var replayFiles = Directory.EnumerateFiles(replayFilesFolder, "*.replay");

var reader = new ReplayReader(logger, ParseMode.Minimal | ParseMode.Debug);
var replay = reader.ReadReplay(replayFiles.First());

Console.WriteLine(replay.Map);
Console.WriteLine(replay.Mode);
Console.WriteLine(replay.Score);
Console.WriteLine(replay.Kills);
Console.WriteLine(replay.Deaths);
Console.ReadLine();