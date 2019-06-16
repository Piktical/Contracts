namespace Piktical.Api.EventOrganiser

module Events =
    open System

    open Piktical.Api.Core.Domain

    type VenueCreated = {
        TimestampUtc: DateTime
        Venue: Venue
    }

    type EventCreated = {
        TimestampUtc: DateTime
        Event: Event
    }

    type EventOccurrenceCreated = {
        TimestampUtc: DateTime
        EventOccurrence: EventOccurrence
    }
