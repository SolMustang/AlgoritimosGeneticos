using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimosGeneticos.Class
{
    public abstract class Constants 
    {
        static public int sizeComossomo = 9; 
        static public int sizePopulacao = 500;
        static public int functionXSize = (int) Math.Pow(2, sizeComossomo);
        public static Random random = new Random((int)DateTime.Now.Ticks);

        public static Double Function1(double x) {
            return (double)(100 + Math.Abs(x * Math.Sin(Math.Sqrt(Math.Abs(x)))));
        }
    }
}
