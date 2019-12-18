using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.EFMultipleJoins
{
    public class Tomato
    {
        public int TomatoId { get; set; }
        public string Name { get; set; }
        public IEnumerable<TaskTomato> TaskTomato {get;set;}
    }
}
