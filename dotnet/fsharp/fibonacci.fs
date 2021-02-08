module fibonacci

let fibonacci n =
    let makeF f =
        fun x ->
            3 * x
    let y y = makeF(fun x -> (y y) x)
    (y y) n
