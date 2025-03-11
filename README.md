# AFLTeams

[![NuGet](https://img.shields.io/nuget/v/AFLTeams.svg)](https://www.nuget.org/packages/AFLTeams/)

This project has source-generated enum extensions for all teams in the AFL competition.

Example usage:
```c#
// Get a collection of team names
var teams = AFLTeamEnumExtensions.DisplayNamesDictionary.Values;

// Using a specific team
var geelong = AFLTeam.Geelong;

//Get the display name of a team
var geelongDisplayName = AFLTeam.Geelong.ToDisplayFast();
```
To see how to use the source generators go [here](https://github.com/EngRajabi/Enum.Source.Generator)
