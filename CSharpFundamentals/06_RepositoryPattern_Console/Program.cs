using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Console
{
    class Program
    {   
        // UI is to interact w/ user and make sure their input gets to the right spot. Entry to application/ First thing to fire off.
        // Run all of our Program UI Methods
        static void Main(string[] args)
        {
            CandProgramUI program = new CandProgramUI();
            program.Running();
        }
    }
}
