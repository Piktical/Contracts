namespace Piktical.Api.EventSecurity

module Events =
    open System
    open Piktical.Api.Core.Domain

    type TicketScanned = {
        TimestampUtc: DateTime
        ScannedById: Guid
        Ticket: Ticket
        HolderId: Guid
    }
