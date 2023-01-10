let [|N; K|] = stdin.ReadLine().Split() |> Array.map int64
let A = stdin.ReadLine().Split() |> Array.map int64

let mutable l = 1L
let mutable r = 1000_000_000L

while l < r do
    let m = (l + r) / 2L
    let sum = Array.sumBy (fun a -> m / a) A
    if sum >= K then r <- m
    else l <- m + 1L

printfn "%d" l
