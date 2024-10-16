namespace TupleToDictionary
{
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a list of tuples
            List<Tuple<string, int>> tuples = new List<Tuple<string, int>>();
            tuples.Add(Tuple.Create("apple", 3));
            tuples.Add(Tuple.Create("banana", 5));
            tuples.Add(Tuple.Create("orange", 2));

            // Convert the list of tuples to a dictionary
            Dictionary<string, int> dictionary = tuples.ToDictionary(tuple => tuple.Item1, tuple => tuple.Item2);

            // Access elements in the dictionary
            foreach (KeyValuePair<string, int> kvp in dictionary)
            {
                Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
            }
        }
    }
}
