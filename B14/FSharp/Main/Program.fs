let [|N; K|] = stdin.ReadLine().Split() |> Array.map int
let A = stdin.ReadLine().Split() |> Array.map int

let numP = pown 2 (N / 2)
let numQ = pown 2 (N - N / 2)

let P = Array.create numP 0
let Q = Array.create numQ 0

for i = 0 to numP - 1 do
    for j = 0 to N / 2 - 1 do
        if (i >>> j) &&& 1 = 1 then
            P.[i] <- P.[i] + A.[j]

for i = 0 to numQ - 1 do
    for j = 0 to N - N / 2 - 1 do
        if (i >>> j) &&& 1 = 1 then
            Q.[i] <- Q.[i] + A.[j+N/2]

// printfn "%A" P
// printfn "%A" Q

let Q' = Array.sort Q

let binarySearch x =
    let mutable ng = -1
    let mutable ok = numQ
    while ok - ng > 1 do
        let mid = (ng + ok) / 2
        if Q'.[mid] >= x then
            ok <- mid
        else
            ng <- mid
    ok < numQ && Q'.[ok] = x

if Array.exists (fun p -> binarySearch (K - p)) P then "Yes" else "No"
|> printfn "%s"
