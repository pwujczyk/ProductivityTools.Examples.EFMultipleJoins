using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examples.EFMultipleJoins
{
    class Commands
    {
        public static void WipeCreateSeed()
        {
            using (var db = new JoinDbContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                var task = new Task() { Name = "task1" };
                var tomato = new Tomato() { Name = "xxx" };
                var taskTomato = new TaskTomato() { Tomato = tomato, Task = task };
                db.Add(task);
                db.Add(tomato);
                db.Add(taskTomato);
                db.SaveChanges();
            }
        }
    }
}
