namespace Piktical.Api.PrimaryTicketAgent

module Commands =
    open System
    open Piktical.Api.Core.Domain

    type ApproveReseller = {
        ResellerId: Guid[]
        TicketIds: Guid[]
    }

    type GroupedTicket = {
        TicketIdentifier: string
        TicketDescription: string option
        Seat: Seat
    }

    type OrderGrouping = {
        EventOccurrenceId: Guid
        PriceId: Guid
        VerificationEnabled: EnableVerification
        TransferRule: TransferRule option
        TransferRevocationRule: TransferRevocationRule option
        Tickets: GroupedTicket[]
        TermsAndConditions: Uri
    }

    type CreateOrder = {
        OrderNumber: string
        TicketGroupings: OrderGrouping[]
        Owner: PikticalUser
    }

    type UpdateOrder = {
        OrderNumber: string
        Ticket: Ticket[]
        Owner: PikticalUser
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
