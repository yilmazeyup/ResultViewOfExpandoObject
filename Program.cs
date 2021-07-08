using System;
using System.Collections.Generic;

namespace ResultViewOfExpandoObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var jobList = new object(); /*write here your sql command*/
            IDictionary<string, object> key;
            var number = 0;
            while (number < jobList.Count)
            {
                key = jobList[number];
                var chunk = 0;
                while (chunk < key.Count)
                {
                    Console.WriteLine(key.Values.ToList()[chunk].ToString());
                    chunk++;
                }
                number++;
            }

        }
    }
}
