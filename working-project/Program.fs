module WorkingProject

let valid triangle =
    let sorted = triangle |> List.sort |> List.rev
    sorted.[0] < sorted.[1] + sorted.[2] && sorted.[2] <> 0.0
    
let distinctLengths = List.distinct >> List.length

let validTriangleWithDistinctLengths lenFn triangle =
    valid triangle && (triangle |> distinctLengths |> lenFn )
    
let equilateral = validTriangleWithDistinctLengths (fun n -> n = 1)

let isosceles = validTriangleWithDistinctLengths (fun n -> n < 3)

let scalene = validTriangleWithDistinctLengths (fun n -> n = 3)


open FsUnit.Xunit
open Xunit

[<Fact>]
let ``Equilateral returns true if all sides are equal`` () =
    equilateral [2.0; 2.0; 2.0] |> should equal true

let [<EntryPoint>] main _ = 0