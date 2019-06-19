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
        TransferRule: TransferRule
        TransferRevocationRule: TransferRevocationRule
        AccessControl: AccessControl
        StartTime: DateTimeOffset
        DoorsOpen: DateTimeOffset
        Duration: TimeSpan
    }

    type CreateEventOccurrences = {
        EventId: Guid
        Occurrences: CreateEventOccurrence[]
    }
