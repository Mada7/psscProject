using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics.Contracts;

namespace Students_Management
{
    public class Coeficient
    {
        private int _numarator;
        private int _numitor;

        public decimal Fractie { get { return (decimal)_numarator / (decimal)_numitor; } }

        internal Coeficient(int numarator, int numitor)
        {
            Contract.Requires<ArgumentException>(numarator > 0);
            Contract.Requires<ArgumentException>(numitor > 0);
            Contract.Requires<ArgumentException>(numitor > numarator);

            _numitor = numitor;
            _numarator = numarator;
        }
    }
}
