using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning
{
    class Program
    {
        public partial class CoOrds
        {
            private int x;
            private int y;

            public CoOrds(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        class TestCoOrds
        {
            static void Main()
            {
               CoOrds myCoOrds = new CoOrds(10, 15);
                myCoOrds.PrintCoOrds();
            }
        }
    }
}
