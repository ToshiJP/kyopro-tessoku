let [|N; X|] = stdin.ReadLine().Split() |> Array.map int
let A = stdin.ReadLine().Split() |> Array.map int

// let rec binsearch x l r =
//     if l <= r then
//         let m = (l + r) / 2
//         if x < A.[m] then binsearch x l (m - 1)
//         elif x > A.[m] then binsearch x (m + 1) r
//         else m
//     else -1

let binsearch x =
    let mutable ng = -1
    let mutable ok = N
    while ok - ng > 1 do
        let mid = (ng + ok) / 2
        if A.[mid] >= x then ok <- mid else ng <- mid
    if ok < N && A.[ok] = x then ok else -1

// binsearch X 0 (N - 1) + 1
binsearch X + 1
|> printfn "%d"
