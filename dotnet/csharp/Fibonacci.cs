using System;

namespace csharp {
    delegate Func<int, int> Y(Y y);

    static class Fibonacci {
        public static int ForIndex(int n) {
            return Y(Y)(n);
        }

        static Func<int, int> MakeF(Func<int, int> f) {
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

        static Func<int, int> Y(Y y) {
            return x => MakeF(y(y))(x);
        }
    }
}
