module Tests

open Xunit

open Piktical.Api.Core.Domain

module ``SeatLocation Equality`` =
    let Room = SeatCoordinate "Room"
    let Floor = SeatCoordinate "Floor"

    [<Fact>]
    let ``Room and Seat Equality`` () =
        let lhs: SeatLocation = [(Room, "A"); (SeatNumber, "1")] |> Map.ofSeq
        let rhs: SeatLocation = [(SeatNumber, "1"); (Room, "A")] |> Map.ofSeq
        Assert.Equal<SeatLocation>(lhs, rhs)

    [<Fact>]
    let ``Room and Seat Inequality`` () =
        let lhs: SeatLocation = [(Room, "A"); (SeatNumber, "1")] |> Map.ofSeq
        let rhs: SeatLocation = [(Room, "A"); (SeatNumber, "2")] |> Map.ofSeq
        Assert.NotEqual<SeatLocation>(lhs, rhs)

