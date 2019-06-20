namespace Piktical.Api.PrimaryTicketAgent

module Commands =
    open System
    open Piktical.Api.Core.Domain

    type ApproveReseller = {
        ResellerId: Guid[]
        TicketIds: Guid[]
    }

    type OrderedTicket = {
        TicketIdentifier: string
        TicketDescription: string option
        Seat: Seat
    }

    type OrderBatch = {
        EventOccurrenceId: Guid
        PriceId: Guid
        VerificationEnabled: EnableVerification
        TransferRule: TransferRule option
        TransferRevocationRule: TransferRevocationRule option
        Tickets: OrderedTicket[]
        TermsAndConditions: Uri
    }

    type CreateOrder = {
        OrderNumber: string
        TicketBatches: OrderBatch[]
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
