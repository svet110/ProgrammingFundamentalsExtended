using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class RandomizeWords
    {
        static void Main()
        {
            
		    var words = Console.ReadLine().Split(' ').ToArray();
		    var random = new Random();

		    for (int i = 0; i < words.Length; i++)
		    {
			    var currentWord = words[i];
			    var randomPos = random.Next(0, words.Length);
			
			    var temp = words[randomPos];
			    words[randomPos] = currentWord;
			    words[i] = temp;			
		    }
		
		    foreach (var word in words)
		    {
			    Console.WriteLine(word);
		    }
	    }
    }
} 
