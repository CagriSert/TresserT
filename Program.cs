using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c,discriminant,kok1,kok2,k=150;
            Console.WriteLine("Diskriminant Formülü: ax2 + bx + c = 0");
            Console.Write("a değerini girin=");a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b değerini girin=");b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c değerini girin=");c = Convert.ToInt32(Console.ReadLine());
            discriminant = (b * b) - (4 * a * c);
            int sonuc;
            if (discriminant < 0)
                sonuc = -1;
            else if (discriminant > 1)
                sonuc = 1;
            else sonuc = 0;
            switch (sonuc)
            {
                case 0:
                    Console.WriteLine("Denklemin Diskriminantı: " + discriminant);
                    kok1 = -b / (2 * a);
                    Console.Write("Denklemin Kökü:" + kok1);
                    break;
                case 1:
                    Console.WriteLine("Denklemin Diskriminantı: " + discriminant);
                    kok1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    kok2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    Console.Write("Denklemin 1.Kökü: {0}\nDenklemin 2.Kökü: {1}", kok1, kok2);
                    break;
               default:
                    Console.WriteLine("Denklemin Diskriminantı: " + discriminant);
                    Console.WriteLine("Denklem 0 dan Küçük Olduğundan Denklemin Gerçek Kökü Yoktur");
                    break;
            }
            Console.ReadLine();
        }
    }
}
