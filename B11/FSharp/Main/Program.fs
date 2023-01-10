let N = stdin.ReadLine() |> int
let A = stdin.ReadLine().Split() |> Array.map int
let Q = stdin.ReadLine() |> int
let X = [for i = 0 to Q-1 do stdin.ReadLine() |> int]

let B = Array.sort A

let rec binsearch x l r =
    if l <= r then
        let m = (l + r) / 2
        if B.[m] >= x then binsearch x l (m - 1)
        else binsearch x (m + 1) r
    else l

for x in X do
    binsearch x 0 (N-1)
    |> printfn "%d"
