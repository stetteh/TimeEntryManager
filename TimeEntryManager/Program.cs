using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeEntryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Developer())
            {
                Developer dev1 = new Developer() { FName = "Seth", LName = "Quaye", Title = "Developer",
                                                StartDate = new DateTime(2016, 01, 01), Email = "squaye@gmail.com"};

                
                newdev.SaveChanges();
            }
        }
    }
}
