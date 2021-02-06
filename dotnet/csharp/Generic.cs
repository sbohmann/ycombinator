using System;

namespace csharp {
    static class Generic {
        public delegate Func<int, int> MakeF(Func<int, int> f);
        
        delegate Func<int, int> Auto(Auto self);
        
        public static Func<int,int> Combine(MakeF makeF) {
            Func<int, int> Y(Auto y) {
                return x => makeF(y(y))(x);
            }
            
            return Y(Y);
        }
    }
}
