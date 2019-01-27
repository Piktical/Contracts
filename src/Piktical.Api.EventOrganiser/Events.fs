namespace Piktical.Api.EventOrganiser

module Events =
    open System

    open Piktical.Api.Core.Domain

    type VenueCreated = {
        TimestampUtc: DateTime
        UploadedById: Guid
        Venue: Venue
    }

    type EventCreated = {
        TimestampUtc: DateTime
        UploadedById: Guid
        Event: Event
    }

    type EventOccurrenceCreated = {
        TimestampUtc: DateTime
        UploadedById: Guid
        EventOccurrence: EventOccurrence
    }
