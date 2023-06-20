namespace Medium._1396.DesignUndergroundSystem;

public class UndergroundSystem
{
    private Dictionary<int, (string, int)> checkIn;
    private Dictionary<string, List<int>> stationTime;

    public UndergroundSystem()
    {
        checkIn = new Dictionary<int, (string, int)>();
        stationTime = new Dictionary<string, List<int>>();
    }

    public void CheckIn(int id, string stationName, int t)
    {
        checkIn[id] = (stationName, t);
    }

    public void CheckOut(int id, string stationName, int t)
    {
        if (checkIn.TryGetValue(id, out var checkInDate))
        {
            string startStation = checkInDate.Item1;
            int startTime = checkInDate.Item2;
            string route = $"{startStation}->{stationName}";

            if (!stationTime.ContainsKey(route))
            {
                stationTime[route] = new List<int>();
            }
            stationTime[route].Add(t - startTime);
            checkIn.Remove(id);
        }
    }

    public double GetAverageTime(string startStation, string endStation)
    {
        string route = $"{startStation}->{endStation}";

        if (stationTime.ContainsKey(route))
        {
            List<int> times = stationTime[route];

            return times.Average();
        }
        return 0.0;
    }
}

