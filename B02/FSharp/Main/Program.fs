let [|A; B|] = stdin.ReadLine().Split() |> Array.map int

let mutable count = 0
for i in A..B do
    if 100 % i = 0 then count <- count + 1

if count > 0 then "Yes" else "No"
|> printfn "%s"
