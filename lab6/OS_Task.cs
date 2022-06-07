using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class OS_Task
    {
        public int Identificator { get; set; }
        public int Size { get; set; }

        public OS_Task(int identificator, int size)
        {
            Identificator = identificator;
            Size = size;
        }
    }
}
