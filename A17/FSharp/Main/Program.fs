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

let restore pos =
    let rec restoreSub pos acc =
        if pos = 0 then 0 :: acc
        else
            if dp.[pos] = dp.[pos-1] + A.[pos] then
                restoreSub (pos - 1) (pos :: acc)
            else
                restoreSub (pos - 2) (pos :: acc)
    restoreSub pos []

let list =
    restore (N - 1)
    |> List.map (fun x -> x + 1 |> string)

List.length list
|> printfn "%d"

String.concat " " list
|> printfn "%s"
