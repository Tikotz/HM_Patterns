using System;

namespace HM_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VacationBuilder Highcost = new HighCost_Vacation();
            Highcost.ConstructVacation();
            Vacation vacation = Highcost.GetVacation();
            Console.WriteLine("your vacation is ready: "+ vacation);

            VacationBuilder Lowcost = new LowCoast_Vacations();
            Lowcost.ConstructVacation();
            Vacation vacation2 = Lowcost.GetVacation();
            Console.WriteLine("your vacation is ready: " + vacation2);
        }
    }
}
