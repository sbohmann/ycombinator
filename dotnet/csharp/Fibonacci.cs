using System;

namespace csharp {
    struct Y : IAutoFunction<Func<int, int>> {
        public Func<IAutoFunction<Func<int, int>>, Func<int, int>> Apply { get; set; }
    }

    static class Fibonacci {
        public static int ForIndex(int n) {
            return Y(new Y {Apply = Y})(n);
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

        static Func<int, int> Y(IAutoFunction<Func<int, int>> y) {
            return x => MakeF(y.Apply(y))(x);
        }
    }
}
