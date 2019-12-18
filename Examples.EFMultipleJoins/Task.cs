using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.EFMultipleJoins
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public IEnumerable<TaskTomato> TaskTomato { get; set; }
    }
}
