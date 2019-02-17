namespace Piktical.Api.EventSecurity

module Commands =
    open Piktical.Api.Core.Domain
    open System

    type ScanTicket = {
        HolderId: Guid
        TicketId: Guid
    }
