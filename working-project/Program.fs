open FsUnit.Xunit
open Xunit

[<Fact>]
let ``name that has spaces but no punctuation`` () =
    true |> should equal true

