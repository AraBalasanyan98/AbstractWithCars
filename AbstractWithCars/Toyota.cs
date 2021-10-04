using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWithCars
{
    class Toyota : Cars
    {
        public override int Hp
        {
            get => 150;
        }

        public Toyota(bool isDamaged) : base(isDamaged)
        {

        }



        public override double GetPrice()
        {
            return 1500000.00;
        }

        public override int GetTotalSeat()
        {
            return 4;
        }

        public override int GetYear()
        {
            return 2015;
        }
        public override string GetColor()
        {
            return "Black";
        }



    }
}
