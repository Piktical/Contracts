namespace Piktical.Api.EventOrganiser

module Commands =
    open System
    open Piktical.Api.Core.Domain
    open GeographicLib

    type CreateVenue = {
        ParentId: Guid option
        GooglePlaceId: string option
        IanaTimeZoneId: string
        Name: string
        Subheading: string option
        MapUrl: string option
        PhotoUrl: string option
        Website: string option
        Address: CivicAddress
        Location: GeodesicLocation
    }

    type CreateEvent = {
        Name: string
        OneLineSummary: string
        ImageUrl: string option
    }

    type CreateEventOccurrence = {
        Profile: EventOccurrenceProfile
        VenueId: Guid
        EventId: Guid
        AccessControl: AccessControl
        StartTime: DateTimeOffset
        DoorsOpen: DateTimeOffset
        Duration: TimeSpan
    }

    type CreateTicket = {
        TicketIdentifier: string
        TicketDescription: string option
        Seat: Seat
    }

    type CreateTicketBand = {
        VerificationEnabled: EnableVerification
        TransferRule: TransferRule option
        TransferRevocationRule: TransferRevocationRule option
        Price: TicketPrice
        Tickets: CreateTicket[]
        TermsAndConditions: Uri
    }

    type ReleaseTickets = {
        EventOccurrenceId: Guid
        TicketBands: CreateTicketBand[]
    }