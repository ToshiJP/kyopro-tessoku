let N = stdin.ReadLine() |> int
let h = stdin.ReadLine().Split() |> Array.map int

let dp = Array.create N 0

dp.[0] <- 0
dp.[1] <- abs (h.[0] - h.[1])
for i = 2 to N - 1 do
    dp.[i] <- min
                (dp.[i-1] + abs (h.[i-1] - h.[i]))
                (dp.[i-2] + abs (h.[i-2] - h.[i]))

printfn "%d" dp.[N-1]
