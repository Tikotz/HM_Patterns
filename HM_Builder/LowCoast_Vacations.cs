using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Builder
{
     class LowCoast_Vacations : VacationBuilder
    {
        public override void BuildFlight()
        {
            vacation.SetFlight("flight with connection in horrible time");
            
        }

        public override void BuildHotel()
        {
            vacation.SetHotel("you got a shitty hotel and no spa");
        }

        public override void BuildTransfers()
        {
            vacation.SetTransfers("the buss need first to stop in all the hotels before you go on so wait for the buss");
        }
    }
}
