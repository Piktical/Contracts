namespace Piktical.Api.PrimaryTicketAgent

module Domain =
    open System
    open Piktical.Api.Core.Domain

    type Order = {
        OrderId: Guid
        OrderNumber: string
        OwnerEnrolmentId: Guid option
        Tickets: Ticket[]
        ConfirmedUtc: DateTimeOffset
        Owner: PikticalUser
    }
