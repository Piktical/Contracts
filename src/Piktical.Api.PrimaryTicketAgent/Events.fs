namespace Piktical.Api.PrimaryTicketAgent

module Events =
    open System
    open Domain

    type OrderCreated = {
        TimestampUtc: DateTime
        UploadedById: Guid
        Order: Order
    }

