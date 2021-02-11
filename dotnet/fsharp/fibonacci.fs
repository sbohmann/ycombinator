module fibonacci

type Y = { call: Y -> (int -> int) }

let fibonacci n =
    let makeF f: int -> int =
        fun x ->
            if x = 0 then 0 else if x = 1 then 1 else f(x - 1) + f(x - 2)
    let y = { call = fun y -> fun x -> makeF(y.call(y)) x }
    (y.call y) n
