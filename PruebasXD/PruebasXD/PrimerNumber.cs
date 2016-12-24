using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasXD {
    class Program {
        static void Main(string[] args) {
            Console.Write("Write a number...");
            int number = Convert.ToInt32(Console.ReadLine());

            if (IsPrimerNumber(number)) {
                Console.WriteLine("The number {0} is prime",number.ToString());
            } else {
                Console.WriteLine("The number {0} is not prime", number.ToString());
            }

            Console.ReadKey();
        }

        static bool IsPrimerNumber(int num) {
            if (num <= 1) {
                return false;
            }
            if (num == 2) {
                return true;
            }
            if (num % 2 == 0) {
                return false;
            }
            for (int divide = 3; divide < Math.Sqrt(num); divide += 2) {
                if (num % divide == 0) {
                    return false;
                }
            }
            return true;
        }
    }
}
