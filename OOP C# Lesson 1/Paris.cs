using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace France
{
    public class Paris
    {
        public int Population { get; }

        public Paris(int Population)
        {
            this.Population = Population;
        }

        public class Lion
        {
            public int Population { get; }

            public Lion(int Population)
            {
                this.Population = Population;
            }
        }
    }
}
