namespace Medium._1396.DesignUndergroundSystem;

public class UndergroundSystemWithTouple
{
    List<(int, string, int)> checkIn;
    List<(string, string, int)> checkOut;
    public UndergroundSystemWithTouple()
    {
        checkIn = new List<(int, string, int)>();
        checkOut = new List<(string, string, int)>();
    }

    public void CheckIn(int id, string stationName, int t)
    {
        checkIn.Add((id, stationName, t));
    }

    public void CheckOut(int id, string stationName, int t)
    {
        List<int> ints = checkIn.Select(x => x.Item1).ToList();
        int i = 0;
        foreach (var item in ints)
        {
            if (id == item)
            {
                checkOut.Add((checkIn[i].Item2, stationName, t - checkIn[i].Item3));
            }
            i++;
        }

    }

    public double GetAverageTime(string startStation, string endStation)
    {
        double count = 0;
        double sum = 0;
        for (int i = 0; i < checkOut.Count; i++)
        {
            if (checkOut[i].Item1 == startStation && checkOut[i].Item2 == endStation)
            {
                count++;
                sum += checkOut[i].Item3;
            }
        }
        return sum / count;
    }
}
