package ycombinator;

import java.util.function.Function;

interface AutoFunction<T, R> {
    Function<T, R> apply(AutoFunction<T, R> self);
}
