using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Builder
{
    class HighCost_Vacation : VacationBuilder
    {
        public override void BuildFlight()
        {
            vacation.SetFlight("Direct flight and FIRST class seats");
        }

        public override void BuildHotel()
        {
            vacation.SetHotel("5 stars Hotel with all inclusive Enjoy your stay");
        }

        public override void BuildTransfers()
        {
            vacation.SetTransfers("your dreammy Hammer Limozine will wait for you outside the airport");
        }
    }
}
