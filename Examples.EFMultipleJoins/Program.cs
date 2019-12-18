using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Examples.EFMultipleJoins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Commands.WipeCreateSeed();

            using (var db = new JoinDbContext())
            {
                var r = db.Task.Include(x => x.TaskTomato).ThenInclude(x => x.Tomato).ToList();
            }
        }
    }
}
