let [|N; K|] = stdin.ReadLine().Split() |> Array.map int
let A = stdin.ReadLine().Split() |> Array.map int
let R = Array.create N 0

let mutable answer = 0L
for i = 0 to N - 2 do
    if i = 0 then R.[i] <- 0
    else R.[i] <- R.[i-1]

    while R.[i] < N-1 && A.[R.[i]+1] - A.[i] <= K do
        R.[i] <- R.[i] + 1

    answer <- answer + int64 (R.[i] - i)

printfn "%d" answer
