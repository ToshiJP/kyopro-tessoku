let N = stdin.ReadLine() |> int
let A = Array.create N 0
let B = Array.create N 0

let tempA = stdin.ReadLine().Split() |> Array.map int
for i = 1 to N - 1 do
    A.[i] <- tempA.[i-1]

let tempB = stdin.ReadLine().Split() |> Array.map int
for i = 2 to N - 1 do
    B.[i] <- tempB.[i-2]

let dp = Array.create N 0

dp.[0] <- 0
dp.[1] <- A.[1]
for i = 2 to N - 1 do
    dp.[i] <- min (dp.[i-1] + A.[i]) (dp.[i-2] + B.[i])

printfn "%d" dp.[N-1]
