using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaChallenge {
    class Program {
        public delegate int SomeMath(int i);

        public delegate bool Compare(int i, Number n);

        static void Main(string[] args) {
            DoSomething();
            Console.ReadKey();
        }

        public static void DoSomething() {
            SomeMath math = new SomeMath(x => x * x * x);
            Console.WriteLine(math(5));

            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            List<int> evenNumber = list.FindAll(delegate (int i) {
                return (i % 2 == 0);
            });
            foreach (int even in evenNumber) {
                Console.WriteLine(even);
            }

            List<int> oddNumber = list.FindAll(i => i % 2 == 1);
            oddNumber.ForEach(i => Console.WriteLine(i));


            Compare comp = (a, number) => a == number.n;
            Console.WriteLine(comp(5, new Number { n = 5 }));
        }
        
        public class Number {
            public int n { get; set; }
        }
    }
}
