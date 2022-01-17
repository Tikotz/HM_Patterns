using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Builder
{
    abstract class VacationBuilder
    {
        protected Vacation vacation;

        public VacationBuilder()
        {
            vacation = new Vacation();
        }
        public abstract void BuildFlight();
        public abstract void BuildHotel();

        public abstract void BuildTransfers();

        public void ConstructVacation()
        {
            BuildFlight();
            BuildHotel();
            BuildTransfers();
        }

        public Vacation GetVacation()
        {
            return vacation;
        }
    }
}
