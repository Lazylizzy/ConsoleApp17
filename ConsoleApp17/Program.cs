using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{

    class Bank<T>
    {
        T n;
        public Bank(T o)
        {
            n = o;
        }
        public T GetN()
        {
            return n;
        }
        public void ShowType()
        {
            Console.WriteLine();
        }
    }
        class GenericDemo
        {

            static void Main(string[] args)
            {
            double ball = 34.85;
            string name = "Liza Liza";
            Bank<int> iN;
                iN = new Bank<int>(102);
                iN.ShowType();
                int i = iN.GetN();
                Console.WriteLine("Номер счета:{0}, баланс:{1}, ФИО:{2}", i,ball, name);
                Console.WriteLine();
            Bank<string> strN = new Bank<string>("132");
                strN.ShowType();
                string str = strN.GetN();
                Console.WriteLine("Номер счета:{0}, баланс:{1}, ФИО:{2}", str , ball, name);
            Console.ReadKey();
            }
        }
    
}
