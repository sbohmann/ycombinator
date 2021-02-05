using System;

namespace csharp {
    static class Program {
        public static void Main(string[] args) {
            for (var n = 0; n < 10; ++n) {
                Console.WriteLine(n + " " + Fibonacci.ForIndex(n));
            }
        }
    }
}
