using System;
using System.Linq;
using efcorescaffold01.Models;

namespace efcorescaffold01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var context = new NoPrimaryKeyDbContext();

            var results =
                context
                .ClientServices
                .Where(i => i.ClientCode.StartsWith("A"))
                .ToList();

            foreach (var result in results)
            {
                Console.WriteLine(result.ClientCode);
            }
        }
    }
}
