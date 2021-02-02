package ycombinator;

import java.util.function.Function;
import java.util.function.UnaryOperator;

public class Generic<T, R> {
    private final UnaryOperator<Function<T, R>> makeF;
    
    public Generic(UnaryOperator<Function<T, R>> makeF) {
        this.makeF = makeF;
    }
    
    private Function<T, R> y(AutoFunction<T, R> y) {
        return makeF.apply(x -> y.apply(y).apply(x));
    }
    
    public R call(T n) {
        return y(this::y).apply(n);
    }
}
