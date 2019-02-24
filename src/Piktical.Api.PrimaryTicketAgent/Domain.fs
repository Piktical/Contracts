namespace Piktical.Api.PrimaryTicketAgent

module Domain =
    open System
    open Piktical.Api.Core.Domain

    type Order = {
        OrderId: Guid
        OrderNumber: string
        OwnerEnrolmentId: Guid
        Tickets: OrderedTicket[]
        ConfirmedUtc: DateTimeOffset
        Owner: PikticalUser
    }
