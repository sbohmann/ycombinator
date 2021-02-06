using System;

namespace csharp {
    static class Program {
        static Func<int, int> MakeFibonacci(Func<int, int> f) {
            return x => {
                switch (x) {
                    case 0:
                        return 0;
                    case 1:
                        return 1;
                    default:
                        return f(x - 1) + f(x - 2);
                }
            };
        }
        
        public static void Main(string[] args) {
            for (var n = 0; n < 10; ++n) {
                Console.WriteLine($"{n} {Fibonacci.ForIndex(n)} {Generic.Combine(MakeFibonacci)(n)}");
            }
        }
    }
}
