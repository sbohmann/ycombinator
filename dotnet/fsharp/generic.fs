module generic

type Y = { call: Y -> (int -> int) }

let combine makeF =
    let y = { call = fun y -> fun x -> makeF(y.call(y)) x }
    (y.call y)
