open FsUnit.Xunit
open Xunit

[<Fact>]
let ``name that has a colon : in it`` () =
    true |> should equal true

