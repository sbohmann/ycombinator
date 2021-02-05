using System;

namespace csharp {
    interface IAutoFunction<T> {
        Func<IAutoFunction<T>, T> Apply { get; }
    }
}
