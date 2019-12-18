using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.EFMultipleJoins
{
    public class TaskTomato
    {
        public int TaskId { get; set; }
        public int TomatoId { get; set; }

        public Task Task { get; set; }
        public Tomato Tomato { get; set; }
    }
}
