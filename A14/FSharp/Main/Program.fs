let [|N; K|] = stdin.ReadLine().Split() |> Array.map int
let A = stdin.ReadLine().Split() |> Array.map int
let B = stdin.ReadLine().Split() |> Array.map int
let C = stdin.ReadLine().Split() |> Array.map int
let D = stdin.ReadLine().Split() |> Array.map int

let P = Array.init (N*N) (fun i -> A.[i/N] + B.[i%N])
let Q = Array.init (N*N) (fun i -> C.[i/N] + D.[i%N])
let Q' = Array.sort Q

// printfn "%A" P
// printfn "%A" Q
// printfn "%A" Q'

let binarySearch x =
    let mutable ng = -1
    let mutable ok = N*N
    while ok - ng > 1 do
        let mid = (ng + ok) / 2
        if Q'.[mid] >= x then
            ok <- mid
        else
            ng <- mid
    if ok < N*N && Q'.[ok] = x then
        // printfn $"ok: {ok}, x: {x}"
        true
    else
        false

if Array.exists (fun p -> binarySearch (K - p)) P then
    printfn "Yes"
else
    printfn "No"
