using System;

namespace csharp {
    static class Fibonacci {
        delegate Func<int, int> Auto(Auto self);
        
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

        static Func<int, int> Y(Auto y) {
            return x => MakeF(y(y))(x);
        }
    }
}
