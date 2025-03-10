using EnumFastToStringGenerated;

namespace AFLTeams.Tests;

public class Tests
{
    [Test]
    [MethodDataSource(nameof(DataSource))]
    public async Task AFLTeamIsPresent(string team)
    {
        await Assert.That(AFLTeamEnumExtensions.DisplayNamesDictionary.Values).Contains(team);
    }


    public static IEnumerable<string> DataSource()
    {
        return AFLTeamEnumExtensions.DisplayNamesDictionary.Values;
    }
}