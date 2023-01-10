let N = stdin.ReadLine() |> float

let mutable l = 0.0
let mutable r = 100.0

let mutable continue = true

while continue do
    let m = (l + r) / 2.0
    let y = m * m * m + m
    if abs (y - N) <= 0.0001 then
        printfn "%f" m
        continue <- false
    else
        if y < N then l <- m
        else r <- m
