module BrokenProject

let dividesBy (n: int, m: int): bool = n % m = 0

let leapYear (year: int): bool =
    dividesBy(year, 4) && (not(dividesBy(year, 100)) || dividesBy(year, 400))
    
open FsUnit.Xunit
open Xunit

[<Fact>]
let ``Year not divisible by 4: common year`` () =
    leapYear 2015 |> should equal false

let [<EntryPoint>] main _ = 0
