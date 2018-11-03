using assign_team.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_team
{
    class Program
    {
        string[,] POSITION = new string[10,3];

        static void Main(string[] args)
        {
            var project = new Project() {
                Name = "myFirstProject",
                StartDate = new DateTime(),
                EndDate = new DateTime().AddYears(1)
            };


            Console.WriteLine(project.Name);
            Console.ReadLine();
        }
    }
}
