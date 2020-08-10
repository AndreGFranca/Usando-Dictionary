using System;
using System.IO;
using System.Collections.Generic;

namespace Usando_Dictionary {
    class Program {
        static void Main(string[] args) {

            Dictionary<string, int> records = new Dictionary<string, int>();
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(',');
                        string key = line[0];
                        int value = (records.ContainsKey(key)) ? records[key] + int.Parse(line[1]) : int.Parse(line[1]);
                        records[key] = value;                        
                    }
                    foreach (var item in records) {
                        Console.WriteLine($"Name: {item.Key}, Total points: {item.Value}");

                    }
                }

            }
            catch(IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
