namespace Piktical.Api.EventSecurity

module Domain =
    open System
    open Piktical.Api.Core.Domain

    type ManualRegistration = {
        RegistrationId: Guid
        EntranceId: Guid
        ImageUrl: string
    }

    type Entrance = {
        EntranceId: Guid
        TicketHolderId: Guid
        TicketOrderId: Guid
        ApprovedUtc: DateTime
        ApprovedById: Guid
    }
