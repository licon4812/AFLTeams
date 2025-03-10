# AFLTeams

This project has a source generated enum extensions for all teams in the AFL competition.

Example usage:
```c#
// Get a collection of team names
var teams = AFLTeamEnumExtensions.DisplayNamesDictionary.Values;

// Using a specific team
var geelong = AFLTeamEnum.Geelong;

// get the display name of a team
var geelongDisplayName = AFLTeamEnum.Geelong.ToDisplayFast();
```
To see how to use the source generators go [here](https://github.com/EngRajabi/Enum.Source.Generator)
