using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Builder
{
    internal class Vacation
    {
        private string Flight;
        private string Hotel;
        private string Transfers;

        public void SetFlight(string flightD)
        {
            this.Flight = flightD;
        }
        public void SetHotel(string hotelD)
        {
            this.Hotel = hotelD;
        }
        public void SetTransfers(string transfersD)
        {
            this.Transfers = transfersD;
        }
    }
}
