Analysis
========
## What does it do?
Analysis is a [LiveSplit](http://livesplit.org/) component. It's supposed to indicate to you what segments in a speedrun you can improve on to get better. The basic thought behind it is to take the time of your Average Segments in your Segment History of LiveSplit and subtract the Best Segment from that. The result of this calculation will tell you how much time on average you lose on a split. For the "%" column of the grid I divide said timeloss by the Best Segment. This is important because it eliminates the factor of split length. If a split is very long, you are generally more likely to lose more time on it.
## How do I install it?
###Without compiling
1. Go to the [releases page](https://github.com/fuerchter/Analysis/releases) of the repository.
2. Download the most recent release *.dll file and copy it to your "Components" folder of LiveSplit.
3. Open LiveSplit.
4. Right click and choose "Edit Layout...".
5. Click on the + icon on the left hand side, the list of components will show up.
6. Choose "Analysis". If you now double-click on it in the Layout Editor it will display.

###With compiling
1. Clone the repository.
2. Copy your "LiveSplit.Core.dll" and "UpdateManager.dll" from your LiveSplit to the "LiveSplit.Analysis" folder (the one with "LiveSplit.Analysis.csproj").
3. Open "LiveSplit.Analysis.sln" in Visual Studio.
4. Build the solution.
