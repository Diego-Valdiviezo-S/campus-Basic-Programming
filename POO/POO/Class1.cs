using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal abstract class Class1
    {
        protected int N1;
        protected int N2;

        protected void Msg()
        {
            Console.WriteLine("Hola");
        }

        protected void Msg2()
        {
            Console.WriteLine("hola2");
        }
    }

  internal sealed class Hija : Class1
    {
        private int _N1H;
        private int _N2H;

        internal Hija(int n1H, int n2H)
        {
            _N1H = n1H;
            _N2H = n2H;
        }

        Hija hija = new Hija(1,2);

            public void MsgH()
        {
            Console.WriteLine("HolaH");
        }
        public void Msg2H()
        {
            Console.WriteLine("Hola2H");
        }

    }
}
