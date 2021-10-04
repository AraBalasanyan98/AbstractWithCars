using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWithCars
{
    class Nissan : Cars
    {
        public Nissan(bool isDamaged) : base(isDamaged)
        {

        }

        public override int Hp => 120;

        public override string GetColor()
        {
            return "Blue";
        }

        public override double GetPrice()
        {
            return 500000.00;
        }

        public override int GetTotalSeat()
        {
            return 6;
        }

        public override int GetYear()
        {
            return 2010;
        }
    }
}
