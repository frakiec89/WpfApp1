using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Capcha
    {
        public string Name { get; private set; }

        string[] vs = new string[] { "A", "b", "C", "D", "e", "F", "Q", "L", "i", "Q", "W", "Д", "Ж", "Э" };


        public  Capcha ()
        {
            Random random = new Random();

            Name = "";

            for  ( int  i = 0; i< 4; i++ )
            {
                Name += vs[random.Next(0, vs.Length)];
            }

        }
    }
}
