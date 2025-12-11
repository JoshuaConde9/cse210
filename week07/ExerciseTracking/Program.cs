using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("03 Dic 2025", 30, 5));

        activities.Add(new Cycling("04 Dic 2025", 10, 30));

        activities.Add(new Swimming("05 Dic 2025", 20, 25));

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}
