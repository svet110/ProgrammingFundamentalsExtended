using System;
using System.Collections.Generic;
using System.Linq;

namespace TravelCompany
{
    class TravelCompany
    {
        static void Main()
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();
		    string[] input = Console.ReadLine().Split(':');
				
		    while (input[0] != "ready")
		    {
			    string city = input[0];
			    string[] vehicles = input[1].Split(new char[] { ',', '-' }
                    , StringSplitOptions.RemoveEmptyEntries);
			
			    if (!dict.ContainsKey(city))
			    {
				    dict.Add(city, new Dictionary<string, int>());
			    }
			
		    	for (int i = 0; i < vehicles.Length-1; i+=2)
			    {
				    string vehicle = vehicles[i];
				    int capacity = int.Parse(vehicles[i+1]);
				
				    if (!dict[city].ContainsKey(vehicle))
				    {
					    dict[city].Add(vehicle, capacity);
				    }
				    else
				    {
					    dict[city][vehicle] = capacity;
				    }
			    }			
			
			    input = Console.ReadLine().Split(':');
		    }
		
		    string[] secInput = Console.ReadLine().Split(' ');
		
		    while (secInput[0] != "travel")
		    {
			    string destination = secInput[0];
			    int numOfPassengers = int.Parse(secInput[1]);
			
			    foreach (var item in dict)
			    {
				    string town = item.Key;
				    Dictionary<string, int> vehiclesAndCapacity = item.Value;
				    int totalCapacity = 0;
				
				    if (destination == town)
				    {
					    foreach (var pair in vehiclesAndCapacity)
					    {
						    totalCapacity += pair.Value;
					    }
					
					    if (totalCapacity >= numOfPassengers)
					    {
						    Console.WriteLine("{0} -> all {1} accommodated"
                                          , destination, numOfPassengers);
					    }
					    else
					    {
						    Console.WriteLine("{0} -> all except {1} accommodated"
                                    , destination, Math.Abs(totalCapacity - numOfPassengers));
					    }
				    }
			    }
			
			    secInput = Console.ReadLine().Split(' ');
		    }
	    }
    }
}
