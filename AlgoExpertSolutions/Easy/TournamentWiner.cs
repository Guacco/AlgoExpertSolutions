namespace AlgoExpertSolutions;

public class TournamentWiner
{
    public static string tournamentWinner(List<List<string>> competitions, List<int> results) {
        var map = new Dictionary<string, int>();
        var maxPoints = 0;
        var mostPointsTeam = string.Empty;
        for(var i = 0; i < results.Count; i++)
        {
            var homeTeam = competitions[i][0];
            var awayTeam = competitions[i][1];

            if (!map.ContainsKey(homeTeam)) map.Add(homeTeam, 0);
            if(!map.ContainsKey(awayTeam)) map.Add(awayTeam, 0);
            if (results[i] == 1) map[homeTeam] += 1;
            if (results[i] == 0) map[awayTeam] += 1;

            if (map[homeTeam] > maxPoints)
            {
                maxPoints = map[homeTeam];
                mostPointsTeam = homeTeam;
            }

            if (map[awayTeam] > maxPoints)
            {
                maxPoints = map[awayTeam];
                mostPointsTeam = awayTeam;
            }
        }

        return mostPointsTeam;
    }
}