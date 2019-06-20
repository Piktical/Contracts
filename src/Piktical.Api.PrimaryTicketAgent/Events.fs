namespace Piktical.Api.PrimaryTicketAgent

module Events =
    open System
    open Domain

    type OrderCreated = {
        TimestampUtc: DateTime
        Order: Order
    }
