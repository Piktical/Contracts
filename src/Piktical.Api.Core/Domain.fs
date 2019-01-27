namespace Piktical.Api.Core

module Domain =
    open System
    open GeographicLib
    open ISO3166
    open NodaMoney

    [<StructuralEquality; NoComparison>]
    type CivicAddress = {
        AddressId: Guid
        FloorLevel: string option
        Building: string option
        Line1: string
        Line2: string option
        City: string
        StateProvince: string option
        PostalCode: string
        Country: Country
    }

    [<StructuralEquality; NoComparison>]
    type Venue = {
        VenueId: Guid
        Parent: Venue option
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

    [<StructuralEquality; NoComparison>]
    type Event = {
        EventId: Guid
        Name: string
        OneLineSummary: string
        ImageUrl: string option
    }

    [<StructuralEquality; NoComparison>]
    type EventOccurrenceName =
        | Inherited
        | CustomName of string

    type BarcodeDisplayType = 
        | QrCode
        | Code128
        | Code3Of9
        | Interleave205

    type ThirdPartyBarcode = {
        Provider: string
        Data: string
        DisplayType: BarcodeDisplayType
    }

    type AccessControl =
        | ProvidedByPikticalApp
        | BarCode of ThirdPartyBarcode

    [<StructuralEquality; NoComparison>]
    type EventOccurrence = {
        OccurrenceId: Guid
        VenueId: Guid
        AccessControl: AccessControl
        PublicKey: string
        StartTime: DateTimeOffset
        DoorsOpen: DateTimeOffset
        Duration: TimeSpan
        Event: Event
        Name: EventOccurrenceName
    }

    type SeatLocation = 
        | SeatNumber of string
        | RowSeat of string * string
        | BlockRowSeat of string * string * string
        | SectionBlockRowSeat of string * string * string * string

    type ReservedSeat = {
        Description: string option
        Location: SeatLocation
    }

    type Reseller = {
        ResellerId: Guid
        ResellerName: string
    }

    type Seat = 
        | Unreserved
        | Reserved of ReservedSeat

    type EnableVerification =
        | DoorsOpen
        | BeforeDoorsOpen of TimeSpan
        | AtTime of DateTimeOffset

    type PriceType = {
        PriceTypeIdentifier: Guid
        PriceTypeDescription: string
    }

    type PriceBand = {
        PriceBandIdentifier: string
        PriceBandDescription: string
    }

    type Ticket = {
        TicketId: Guid
        VerificationEnabled: EnableVerification
        Type: PriceType
        Band: PriceBand
        FaceValue: Money
        TicketIdentifier: string
        TicketDescription: string option
        Seat: Seat
        TermsAndConditions: Uri
    }

    type PikticalUser = | PikticalId of string
