let [|N; X|] = stdin.ReadLine().Split() |> Array.map int
let A = stdin.ReadLine().Split() |> Array.map int

// let mutable answer = false
// for i = 0 to N - 1 do
//     if A[i] = X then answer <- true

let answer = Array.exists (fun a -> a = X) A

if answer then "Yes" else "No"
|> printfn "%s"
