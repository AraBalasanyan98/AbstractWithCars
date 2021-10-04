using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWithCars
{
    abstract class Cars
    {
        public Cars(bool isDamaged)
        {
            Damaged = isDamaged;
        }
        public bool Damaged { get; set; }
        public abstract int Hp { get;  }

        public abstract double GetPrice();
        public abstract int GetTotalSeat();
        public abstract int GetYear();
        public abstract string GetColor();

    }
}
