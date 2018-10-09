namespace Piktical.Api.PrimaryTicketAgent

module Commands =
    open System
    open Piktical.Api.Core.Domain

    type ApproveReseller = {
        ResellerId: Guid[]
        TicketIds: Guid[]
    }

    type CreateOrder = {
        OrderNumber: string
        Tickets: Ticket[]
        OwnerId: Guid
    }

    type UpdateOrder = {
        OrderNumber: string
        Ticket: Ticket[]
        OwnerId: Guid
    }

    type CancelBookings = {
        BookingIds: Guid[]
    }

    type TransferTicket = {
        TicketId: Guid
        RecipientId: Guid
    }

    type RescindTransfer = {
        TransferId: Guid
    }

    type SellTicket = {
        ResellerId: Guid
    }

