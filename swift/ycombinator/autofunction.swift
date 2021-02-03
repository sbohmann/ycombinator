struct AutoFunction<T, R> {
    let call: (AutoFunction) -> (T) -> R
}
