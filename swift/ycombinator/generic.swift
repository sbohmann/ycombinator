func generic<T, R>(makeF: @escaping (@escaping (T) -> R) -> (T) -> R) -> (T) -> R {
    func y(y: AutoFunction<T, R>) -> (T) -> R {
        makeF { x in y.call(y)(x) }
    }

    return y(y: AutoFunction<T, R>(call: y))
}
