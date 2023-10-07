using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph_business_trip
{
    public class BusinessTrip
    {
      public  static int? BusinesTrip(Dictionary<string, Dictionary<string, int>> graph, string[] cityNames)
        {
            if (cityNames.Length < 2)
                return null;

            int tripCost = 0;

            for (int i = 0; i < cityNames.Length - 1; i++)
            {
                string currentCity = cityNames[i];
                string nextCity = cityNames[i + 1];

                if (!graph.ContainsKey(currentCity) || !graph[currentCity].ContainsKey(nextCity))
                {
                    return null;
                }

                tripCost += graph[currentCity][nextCity];
            }

            return tripCost;
        }
    }
    }

