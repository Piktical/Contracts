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
        BarcodeEnabled: EnableBarcode
        VerificationRule: VerificationRule option
        TransferRule: TransferRule option
        TransferRevocationRule: TransferRevocationRule option
        Tickets: GroupedTicket[]
        TermsAndConditions: Uri
    }

    type CreateOrder = {
        OrderNumber: string
        TicketGroupings: OrderGrouping[]
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
