namespace Piktical.Api.Core

module Iso3166 =
    type [<StructuralEquality; NoComparison>] ActiveCountry = { Iso31661Alpha3Code: string; Iso31661Alpha2Code: string }
    type [<StructuralEquality; NoComparison>] FormerCountry = { Iso31661Alpha3Code: string; Iso31661Alpha2Code: string; Iso31663Code: string }
    type Country = 
        | Active of ActiveCountry | Former of FormerCountry
        member this.Alpha3Code() = match this with | Active c -> c.Iso31661Alpha3Code | Former c -> c.Iso31661Alpha3Code
        member this.Alpha2Code() = match this with | Active c -> c.Iso31661Alpha2Code | Former c -> c.Iso31661Alpha2Code
    let AllCountries =
        [|
            Active { Iso31661Alpha3Code = "ABW"; Iso31661Alpha2Code = "AW" }
            Active { Iso31661Alpha3Code = "AFG"; Iso31661Alpha2Code = "AF" }
            Active { Iso31661Alpha3Code = "AGO"; Iso31661Alpha2Code = "AO" }
            Active { Iso31661Alpha3Code = "AIA"; Iso31661Alpha2Code = "AI" }
            Active { Iso31661Alpha3Code = "ALA"; Iso31661Alpha2Code = "AX" }
            Active { Iso31661Alpha3Code = "ALB"; Iso31661Alpha2Code = "AL" }
            Active { Iso31661Alpha3Code = "AND"; Iso31661Alpha2Code = "AD" }
            Active { Iso31661Alpha3Code = "ARE"; Iso31661Alpha2Code = "AE" }
            Active { Iso31661Alpha3Code = "ARG"; Iso31661Alpha2Code = "AR" }
            Active { Iso31661Alpha3Code = "ARM"; Iso31661Alpha2Code = "AM" }
            Active { Iso31661Alpha3Code = "ASM"; Iso31661Alpha2Code = "AS" }
            Active { Iso31661Alpha3Code = "ATA"; Iso31661Alpha2Code = "AQ" }
            Active { Iso31661Alpha3Code = "ATF"; Iso31661Alpha2Code = "TF" }
            Active { Iso31661Alpha3Code = "ATG"; Iso31661Alpha2Code = "AG" }
            Active { Iso31661Alpha3Code = "AUS"; Iso31661Alpha2Code = "AU" }
            Active { Iso31661Alpha3Code = "AUT"; Iso31661Alpha2Code = "AT" }
            Active { Iso31661Alpha3Code = "AZE"; Iso31661Alpha2Code = "AZ" }
            Active { Iso31661Alpha3Code = "BDI"; Iso31661Alpha2Code = "BI" }
            Active { Iso31661Alpha3Code = "BEL"; Iso31661Alpha2Code = "BE" }
            Active { Iso31661Alpha3Code = "BEN"; Iso31661Alpha2Code = "BJ" }
            Active { Iso31661Alpha3Code = "BES"; Iso31661Alpha2Code = "BQ" }
            Active { Iso31661Alpha3Code = "BFA"; Iso31661Alpha2Code = "BF" }
            Active { Iso31661Alpha3Code = "BGD"; Iso31661Alpha2Code = "BD" }
            Active { Iso31661Alpha3Code = "BGR"; Iso31661Alpha2Code = "BG" }
            Active { Iso31661Alpha3Code = "BHR"; Iso31661Alpha2Code = "BH" }
            Active { Iso31661Alpha3Code = "BHS"; Iso31661Alpha2Code = "BS" }
            Active { Iso31661Alpha3Code = "BIH"; Iso31661Alpha2Code = "BA" }
            Active { Iso31661Alpha3Code = "BLM"; Iso31661Alpha2Code = "BL" }
            Active { Iso31661Alpha3Code = "BLR"; Iso31661Alpha2Code = "BY" }
            Active { Iso31661Alpha3Code = "BLZ"; Iso31661Alpha2Code = "BZ" }
            Active { Iso31661Alpha3Code = "BMU"; Iso31661Alpha2Code = "BM" }
            Active { Iso31661Alpha3Code = "BOL"; Iso31661Alpha2Code = "BO" }
            Active { Iso31661Alpha3Code = "BRA"; Iso31661Alpha2Code = "BR" }
            Active { Iso31661Alpha3Code = "BRB"; Iso31661Alpha2Code = "BB" }
            Active { Iso31661Alpha3Code = "BRN"; Iso31661Alpha2Code = "BN" }
            Active { Iso31661Alpha3Code = "BTN"; Iso31661Alpha2Code = "BT" }
            Active { Iso31661Alpha3Code = "BVT"; Iso31661Alpha2Code = "BV" }
            Active { Iso31661Alpha3Code = "BWA"; Iso31661Alpha2Code = "BW" }
            Active { Iso31661Alpha3Code = "CAF"; Iso31661Alpha2Code = "CF" }
            Active { Iso31661Alpha3Code = "CAN"; Iso31661Alpha2Code = "CA" }
            Active { Iso31661Alpha3Code = "CCK"; Iso31661Alpha2Code = "CC" }
            Active { Iso31661Alpha3Code = "CHE"; Iso31661Alpha2Code = "CH" }
            Active { Iso31661Alpha3Code = "CHL"; Iso31661Alpha2Code = "CL" }
            Active { Iso31661Alpha3Code = "CHN"; Iso31661Alpha2Code = "CN" }
            Active { Iso31661Alpha3Code = "CIV"; Iso31661Alpha2Code = "CI" }
            Active { Iso31661Alpha3Code = "CMR"; Iso31661Alpha2Code = "CM" }
            Active { Iso31661Alpha3Code = "COD"; Iso31661Alpha2Code = "CD" }
            Active { Iso31661Alpha3Code = "COG"; Iso31661Alpha2Code = "CG" }
            Active { Iso31661Alpha3Code = "COK"; Iso31661Alpha2Code = "CK" }
            Active { Iso31661Alpha3Code = "COL"; Iso31661Alpha2Code = "CO" }
            Active { Iso31661Alpha3Code = "COM"; Iso31661Alpha2Code = "KM" }
            Active { Iso31661Alpha3Code = "CPV"; Iso31661Alpha2Code = "CV" }
            Active { Iso31661Alpha3Code = "CRI"; Iso31661Alpha2Code = "CR" }
            Active { Iso31661Alpha3Code = "CUB"; Iso31661Alpha2Code = "CU" }
            Active { Iso31661Alpha3Code = "CUW"; Iso31661Alpha2Code = "CW" }
            Active { Iso31661Alpha3Code = "CXR"; Iso31661Alpha2Code = "CX" }
            Active { Iso31661Alpha3Code = "CYM"; Iso31661Alpha2Code = "KY" }
            Active { Iso31661Alpha3Code = "CYP"; Iso31661Alpha2Code = "CY" }
            Active { Iso31661Alpha3Code = "CZE"; Iso31661Alpha2Code = "CZ" }
            Active { Iso31661Alpha3Code = "DEU"; Iso31661Alpha2Code = "DE" }
            Active { Iso31661Alpha3Code = "DJI"; Iso31661Alpha2Code = "DJ" }
            Active { Iso31661Alpha3Code = "DMA"; Iso31661Alpha2Code = "DM" }
            Active { Iso31661Alpha3Code = "DNK"; Iso31661Alpha2Code = "DK" }
            Active { Iso31661Alpha3Code = "DOM"; Iso31661Alpha2Code = "DO" }
            Active { Iso31661Alpha3Code = "DZA"; Iso31661Alpha2Code = "DZ" }
            Active { Iso31661Alpha3Code = "ECU"; Iso31661Alpha2Code = "EC" }
            Active { Iso31661Alpha3Code = "EGY"; Iso31661Alpha2Code = "EG" }
            Active { Iso31661Alpha3Code = "ERI"; Iso31661Alpha2Code = "ER" }
            Active { Iso31661Alpha3Code = "ESH"; Iso31661Alpha2Code = "EH" }
            Active { Iso31661Alpha3Code = "ESP"; Iso31661Alpha2Code = "ES" }
            Active { Iso31661Alpha3Code = "EST"; Iso31661Alpha2Code = "EE" }
            Active { Iso31661Alpha3Code = "ETH"; Iso31661Alpha2Code = "ET" }
            Active { Iso31661Alpha3Code = "FIN"; Iso31661Alpha2Code = "FI" }
            Active { Iso31661Alpha3Code = "FJI"; Iso31661Alpha2Code = "FJ" }
            Active { Iso31661Alpha3Code = "FLK"; Iso31661Alpha2Code = "FK" }
            Active { Iso31661Alpha3Code = "FRA"; Iso31661Alpha2Code = "FR" }
            Active { Iso31661Alpha3Code = "FRO"; Iso31661Alpha2Code = "FO" }
            Active { Iso31661Alpha3Code = "FSM"; Iso31661Alpha2Code = "FM" }
            Active { Iso31661Alpha3Code = "GAB"; Iso31661Alpha2Code = "GA" }
            Active { Iso31661Alpha3Code = "GBR"; Iso31661Alpha2Code = "GB" }
            Active { Iso31661Alpha3Code = "GEO"; Iso31661Alpha2Code = "GE" }
            Active { Iso31661Alpha3Code = "GGY"; Iso31661Alpha2Code = "GG" }
            Active { Iso31661Alpha3Code = "GHA"; Iso31661Alpha2Code = "GH" }
            Active { Iso31661Alpha3Code = "GIB"; Iso31661Alpha2Code = "GI" }
            Active { Iso31661Alpha3Code = "GIN"; Iso31661Alpha2Code = "GN" }
            Active { Iso31661Alpha3Code = "GLP"; Iso31661Alpha2Code = "GP" }
            Active { Iso31661Alpha3Code = "GMB"; Iso31661Alpha2Code = "GM" }
            Active { Iso31661Alpha3Code = "GNB"; Iso31661Alpha2Code = "GW" }
            Active { Iso31661Alpha3Code = "GNQ"; Iso31661Alpha2Code = "GQ" }
            Active { Iso31661Alpha3Code = "GRC"; Iso31661Alpha2Code = "GR" }
            Active { Iso31661Alpha3Code = "GRD"; Iso31661Alpha2Code = "GD" }
            Active { Iso31661Alpha3Code = "GRL"; Iso31661Alpha2Code = "GL" }
            Active { Iso31661Alpha3Code = "GTM"; Iso31661Alpha2Code = "GT" }
            Active { Iso31661Alpha3Code = "GUF"; Iso31661Alpha2Code = "GF" }
            Active { Iso31661Alpha3Code = "GUM"; Iso31661Alpha2Code = "GU" }
            Active { Iso31661Alpha3Code = "GUY"; Iso31661Alpha2Code = "GY" }
            Active { Iso31661Alpha3Code = "HKG"; Iso31661Alpha2Code = "HK" }
            Active { Iso31661Alpha3Code = "HMD"; Iso31661Alpha2Code = "HM" }
            Active { Iso31661Alpha3Code = "HND"; Iso31661Alpha2Code = "HN" }
            Active { Iso31661Alpha3Code = "HRV"; Iso31661Alpha2Code = "HR" }
            Active { Iso31661Alpha3Code = "HTI"; Iso31661Alpha2Code = "HT" }
            Active { Iso31661Alpha3Code = "HUN"; Iso31661Alpha2Code = "HU" }
            Active { Iso31661Alpha3Code = "IDN"; Iso31661Alpha2Code = "ID" }
            Active { Iso31661Alpha3Code = "IMN"; Iso31661Alpha2Code = "IM" }
            Active { Iso31661Alpha3Code = "IND"; Iso31661Alpha2Code = "IN" }
            Active { Iso31661Alpha3Code = "IOT"; Iso31661Alpha2Code = "IO" }
            Active { Iso31661Alpha3Code = "IRL"; Iso31661Alpha2Code = "IE" }
            Active { Iso31661Alpha3Code = "IRN"; Iso31661Alpha2Code = "IR" }
            Active { Iso31661Alpha3Code = "IRQ"; Iso31661Alpha2Code = "IQ" }
            Active { Iso31661Alpha3Code = "ISL"; Iso31661Alpha2Code = "IS" }
            Active { Iso31661Alpha3Code = "ISR"; Iso31661Alpha2Code = "IL" }
            Active { Iso31661Alpha3Code = "ITA"; Iso31661Alpha2Code = "IT" }
            Active { Iso31661Alpha3Code = "JAM"; Iso31661Alpha2Code = "JM" }
            Active { Iso31661Alpha3Code = "JEY"; Iso31661Alpha2Code = "JE" }
            Active { Iso31661Alpha3Code = "JOR"; Iso31661Alpha2Code = "JO" }
            Active { Iso31661Alpha3Code = "JPN"; Iso31661Alpha2Code = "JP" }
            Active { Iso31661Alpha3Code = "KAZ"; Iso31661Alpha2Code = "KZ" }
            Active { Iso31661Alpha3Code = "KEN"; Iso31661Alpha2Code = "KE" }
            Active { Iso31661Alpha3Code = "KGZ"; Iso31661Alpha2Code = "KG" }
            Active { Iso31661Alpha3Code = "KHM"; Iso31661Alpha2Code = "KH" }
            Active { Iso31661Alpha3Code = "KIR"; Iso31661Alpha2Code = "KI" }
            Active { Iso31661Alpha3Code = "KNA"; Iso31661Alpha2Code = "KN" }
            Active { Iso31661Alpha3Code = "KOR"; Iso31661Alpha2Code = "KR" }
            Active { Iso31661Alpha3Code = "KWT"; Iso31661Alpha2Code = "KW" }
            Active { Iso31661Alpha3Code = "LAO"; Iso31661Alpha2Code = "LA" }
            Active { Iso31661Alpha3Code = "LBN"; Iso31661Alpha2Code = "LB" }
            Active { Iso31661Alpha3Code = "LBR"; Iso31661Alpha2Code = "LR" }
            Active { Iso31661Alpha3Code = "LBY"; Iso31661Alpha2Code = "LY" }
            Active { Iso31661Alpha3Code = "LCA"; Iso31661Alpha2Code = "LC" }
            Active { Iso31661Alpha3Code = "LIE"; Iso31661Alpha2Code = "LI" }
            Active { Iso31661Alpha3Code = "LKA"; Iso31661Alpha2Code = "LK" }
            Active { Iso31661Alpha3Code = "LSO"; Iso31661Alpha2Code = "LS" }
            Active { Iso31661Alpha3Code = "LTU"; Iso31661Alpha2Code = "LT" }
            Active { Iso31661Alpha3Code = "LUX"; Iso31661Alpha2Code = "LU" }
            Active { Iso31661Alpha3Code = "LVA"; Iso31661Alpha2Code = "LV" }
            Active { Iso31661Alpha3Code = "MAC"; Iso31661Alpha2Code = "MO" }
            Active { Iso31661Alpha3Code = "MAF"; Iso31661Alpha2Code = "MF" }
            Active { Iso31661Alpha3Code = "MAR"; Iso31661Alpha2Code = "MA" }
            Active { Iso31661Alpha3Code = "MCO"; Iso31661Alpha2Code = "MC" }
            Active { Iso31661Alpha3Code = "MDA"; Iso31661Alpha2Code = "MD" }
            Active { Iso31661Alpha3Code = "MDG"; Iso31661Alpha2Code = "MG" }
            Active { Iso31661Alpha3Code = "MDV"; Iso31661Alpha2Code = "MV" }
            Active { Iso31661Alpha3Code = "MEX"; Iso31661Alpha2Code = "MX" }
            Active { Iso31661Alpha3Code = "MHL"; Iso31661Alpha2Code = "MH" }
            Active { Iso31661Alpha3Code = "MKD"; Iso31661Alpha2Code = "MK" }
            Active { Iso31661Alpha3Code = "MLI"; Iso31661Alpha2Code = "ML" }
            Active { Iso31661Alpha3Code = "MLT"; Iso31661Alpha2Code = "MT" }
            Active { Iso31661Alpha3Code = "MMR"; Iso31661Alpha2Code = "MM" }
            Active { Iso31661Alpha3Code = "MNE"; Iso31661Alpha2Code = "ME" }
            Active { Iso31661Alpha3Code = "MNG"; Iso31661Alpha2Code = "MN" }
            Active { Iso31661Alpha3Code = "MNP"; Iso31661Alpha2Code = "MP" }
            Active { Iso31661Alpha3Code = "MOZ"; Iso31661Alpha2Code = "MZ" }
            Active { Iso31661Alpha3Code = "MRT"; Iso31661Alpha2Code = "MR" }
            Active { Iso31661Alpha3Code = "MSR"; Iso31661Alpha2Code = "MS" }
            Active { Iso31661Alpha3Code = "MTQ"; Iso31661Alpha2Code = "MQ" }
            Active { Iso31661Alpha3Code = "MUS"; Iso31661Alpha2Code = "MU" }
            Active { Iso31661Alpha3Code = "MWI"; Iso31661Alpha2Code = "MW" }
            Active { Iso31661Alpha3Code = "MYS"; Iso31661Alpha2Code = "MY" }
            Active { Iso31661Alpha3Code = "MYT"; Iso31661Alpha2Code = "YT" }
            Active { Iso31661Alpha3Code = "NAM"; Iso31661Alpha2Code = "NA" }
            Active { Iso31661Alpha3Code = "NCL"; Iso31661Alpha2Code = "NC" }
            Active { Iso31661Alpha3Code = "NER"; Iso31661Alpha2Code = "NE" }
            Active { Iso31661Alpha3Code = "NFK"; Iso31661Alpha2Code = "NF" }
            Active { Iso31661Alpha3Code = "NGA"; Iso31661Alpha2Code = "NG" }
            Active { Iso31661Alpha3Code = "NIC"; Iso31661Alpha2Code = "NI" }
            Active { Iso31661Alpha3Code = "NIU"; Iso31661Alpha2Code = "NU" }
            Active { Iso31661Alpha3Code = "NLD"; Iso31661Alpha2Code = "NL" }
            Active { Iso31661Alpha3Code = "NOR"; Iso31661Alpha2Code = "NO" }
            Active { Iso31661Alpha3Code = "NPL"; Iso31661Alpha2Code = "NP" }
            Active { Iso31661Alpha3Code = "NRU"; Iso31661Alpha2Code = "NR" }
            Active { Iso31661Alpha3Code = "NZL"; Iso31661Alpha2Code = "NZ" }
            Active { Iso31661Alpha3Code = "OMN"; Iso31661Alpha2Code = "OM" }
            Active { Iso31661Alpha3Code = "PAK"; Iso31661Alpha2Code = "PK" }
            Active { Iso31661Alpha3Code = "PAN"; Iso31661Alpha2Code = "PA" }
            Active { Iso31661Alpha3Code = "PCN"; Iso31661Alpha2Code = "PN" }
            Active { Iso31661Alpha3Code = "PER"; Iso31661Alpha2Code = "PE" }
            Active { Iso31661Alpha3Code = "PHL"; Iso31661Alpha2Code = "PL" }
            Active { Iso31661Alpha3Code = "PLW"; Iso31661Alpha2Code = "PW" }
            Active { Iso31661Alpha3Code = "PNG"; Iso31661Alpha2Code = "PG" }
            Active { Iso31661Alpha3Code = "POL"; Iso31661Alpha2Code = "PL" }
            Active { Iso31661Alpha3Code = "PRI"; Iso31661Alpha2Code = "PR" }
            Active { Iso31661Alpha3Code = "PRK"; Iso31661Alpha2Code = "KP" }
            Active { Iso31661Alpha3Code = "PRT"; Iso31661Alpha2Code = "PT" }
            Active { Iso31661Alpha3Code = "PRY"; Iso31661Alpha2Code = "PY" }
            Active { Iso31661Alpha3Code = "PSE"; Iso31661Alpha2Code = "PS" }
            Active { Iso31661Alpha3Code = "PYF"; Iso31661Alpha2Code = "PF" }
            Active { Iso31661Alpha3Code = "QAT"; Iso31661Alpha2Code = "QA" }
            Active { Iso31661Alpha3Code = "REU"; Iso31661Alpha2Code = "RE" }
            Active { Iso31661Alpha3Code = "ROU"; Iso31661Alpha2Code = "RO" }
            Active { Iso31661Alpha3Code = "RUS"; Iso31661Alpha2Code = "RU" }
            Active { Iso31661Alpha3Code = "RWA"; Iso31661Alpha2Code = "RW" }
            Active { Iso31661Alpha3Code = "SAU"; Iso31661Alpha2Code = "SA" }
            Active { Iso31661Alpha3Code = "SDN"; Iso31661Alpha2Code = "SD" }
            Active { Iso31661Alpha3Code = "SEN"; Iso31661Alpha2Code = "SN" }
            Active { Iso31661Alpha3Code = "SGP"; Iso31661Alpha2Code = "SG" }
            Active { Iso31661Alpha3Code = "SGS"; Iso31661Alpha2Code = "GS" }
            Active { Iso31661Alpha3Code = "SHN"; Iso31661Alpha2Code = "SH" }
            Active { Iso31661Alpha3Code = "SJM"; Iso31661Alpha2Code = "SJ" }
            Active { Iso31661Alpha3Code = "SLB"; Iso31661Alpha2Code = "SB" }
            Active { Iso31661Alpha3Code = "SLE"; Iso31661Alpha2Code = "SL" }
            Active { Iso31661Alpha3Code = "SLV"; Iso31661Alpha2Code = "SV" }
            Active { Iso31661Alpha3Code = "SMR"; Iso31661Alpha2Code = "SM" }
            Active { Iso31661Alpha3Code = "SOM"; Iso31661Alpha2Code = "SO" }
            Active { Iso31661Alpha3Code = "SPM"; Iso31661Alpha2Code = "PM" }
            Active { Iso31661Alpha3Code = "SRB"; Iso31661Alpha2Code = "RS" }
            Active { Iso31661Alpha3Code = "SSD"; Iso31661Alpha2Code = "SS" }
            Active { Iso31661Alpha3Code = "STP"; Iso31661Alpha2Code = "ST" }
            Active { Iso31661Alpha3Code = "SUR"; Iso31661Alpha2Code = "SR" }
            Active { Iso31661Alpha3Code = "SVK"; Iso31661Alpha2Code = "SK" }
            Active { Iso31661Alpha3Code = "SVN"; Iso31661Alpha2Code = "SI" }
            Active { Iso31661Alpha3Code = "SWE"; Iso31661Alpha2Code = "SE" }
            Active { Iso31661Alpha3Code = "SWZ"; Iso31661Alpha2Code = "SZ" }
            Active { Iso31661Alpha3Code = "SXM"; Iso31661Alpha2Code = "SX" }
            Active { Iso31661Alpha3Code = "SYC"; Iso31661Alpha2Code = "SC" }
            Active { Iso31661Alpha3Code = "SYR"; Iso31661Alpha2Code = "SY" }
            Active { Iso31661Alpha3Code = "TCA"; Iso31661Alpha2Code = "TC" }
            Active { Iso31661Alpha3Code = "TCD"; Iso31661Alpha2Code = "TD" }
            Active { Iso31661Alpha3Code = "TGO"; Iso31661Alpha2Code = "TG" }
            Active { Iso31661Alpha3Code = "THA"; Iso31661Alpha2Code = "TH" }
            Active { Iso31661Alpha3Code = "TJK"; Iso31661Alpha2Code = "TJ" }
            Active { Iso31661Alpha3Code = "TKL"; Iso31661Alpha2Code = "TK" }
            Active { Iso31661Alpha3Code = "TKM"; Iso31661Alpha2Code = "TM" }
            Active { Iso31661Alpha3Code = "TLS"; Iso31661Alpha2Code = "TL" }
            Active { Iso31661Alpha3Code = "TON"; Iso31661Alpha2Code = "TO" }
            Active { Iso31661Alpha3Code = "TTO"; Iso31661Alpha2Code = "TT" }
            Active { Iso31661Alpha3Code = "TUN"; Iso31661Alpha2Code = "TN" }
            Active { Iso31661Alpha3Code = "TUR"; Iso31661Alpha2Code = "TR" }
            Active { Iso31661Alpha3Code = "TUV"; Iso31661Alpha2Code = "TV" }
            Active { Iso31661Alpha3Code = "TWN"; Iso31661Alpha2Code = "TW" }
            Active { Iso31661Alpha3Code = "TZA"; Iso31661Alpha2Code = "TZ" }
            Active { Iso31661Alpha3Code = "UGA"; Iso31661Alpha2Code = "UG" }
            Active { Iso31661Alpha3Code = "UKR"; Iso31661Alpha2Code = "UA" }
            Active { Iso31661Alpha3Code = "UMI"; Iso31661Alpha2Code = "UM" }
            Active { Iso31661Alpha3Code = "URY"; Iso31661Alpha2Code = "UY" }
            Active { Iso31661Alpha3Code = "USA"; Iso31661Alpha2Code = "US" }
            Active { Iso31661Alpha3Code = "UZB"; Iso31661Alpha2Code = "UZ" }
            Active { Iso31661Alpha3Code = "VAT"; Iso31661Alpha2Code = "VA" }
            Active { Iso31661Alpha3Code = "VCT"; Iso31661Alpha2Code = "VC" }
            Active { Iso31661Alpha3Code = "VEN"; Iso31661Alpha2Code = "VE" }
            Active { Iso31661Alpha3Code = "VGB"; Iso31661Alpha2Code = "VG" }
            Active { Iso31661Alpha3Code = "VIR"; Iso31661Alpha2Code = "VI" }
            Active { Iso31661Alpha3Code = "VNM"; Iso31661Alpha2Code = "VN" }
            Active { Iso31661Alpha3Code = "VUT"; Iso31661Alpha2Code = "VU" }
            Active { Iso31661Alpha3Code = "WLF"; Iso31661Alpha2Code = "WF" }
            Active { Iso31661Alpha3Code = "WSM"; Iso31661Alpha2Code = "WS" }
            Active { Iso31661Alpha3Code = "YEM"; Iso31661Alpha2Code = "YE" }
            Active { Iso31661Alpha3Code = "ZAF"; Iso31661Alpha2Code = "ZA" }
            Active { Iso31661Alpha3Code = "ZMB"; Iso31661Alpha2Code = "ZM" }
            Active { Iso31661Alpha3Code = "ZWE"; Iso31661Alpha2Code = "ZW" }
            Former { Iso31661Alpha3Code = "ATB"; Iso31661Alpha2Code = "BQ"; Iso31663Code = "BQAQ" }
            Former { Iso31661Alpha3Code = "BUR"; Iso31661Alpha2Code = "BU"; Iso31663Code = "BUMM" }
            Former { Iso31661Alpha3Code = "BYE"; Iso31661Alpha2Code = "BY"; Iso31663Code = "BYAA" }
            Former { Iso31661Alpha3Code = "CTE"; Iso31661Alpha2Code = "CT"; Iso31663Code = "CTKI" }
            Former { Iso31661Alpha3Code = "CSK"; Iso31661Alpha2Code = "CS"; Iso31663Code = "CSHH" }
            Former { Iso31661Alpha3Code = "DHY"; Iso31661Alpha2Code = "DY"; Iso31663Code = "DYBJ" }
            Former { Iso31661Alpha3Code = "ATN"; Iso31661Alpha2Code = "NQ"; Iso31663Code = "NQAQ" }
            Former { Iso31661Alpha3Code = "TMP"; Iso31661Alpha2Code = "TP"; Iso31663Code = "TPTL" }
            Former { Iso31661Alpha3Code = "FXX"; Iso31661Alpha2Code = "FX"; Iso31663Code = "FXFR" }
            Former { Iso31661Alpha3Code = "AFI"; Iso31661Alpha2Code = "AI"; Iso31663Code = "AIDJ" }
            Former { Iso31661Alpha3Code = "ATF"; Iso31661Alpha2Code = "FQ"; Iso31663Code = "FQHH" }
            Former { Iso31661Alpha3Code = "DDR"; Iso31661Alpha2Code = "DD"; Iso31663Code = "DDDE" }
            Former { Iso31661Alpha3Code = "GEL"; Iso31661Alpha2Code = "GE"; Iso31663Code = "GEHH" }
            Former { Iso31661Alpha3Code = "JTN"; Iso31661Alpha2Code = "JT"; Iso31663Code = "JTUM" }
            Former { Iso31661Alpha3Code = "MID"; Iso31661Alpha2Code = "MI"; Iso31663Code = "MIUM" }
            Former { Iso31661Alpha3Code = "ANT"; Iso31661Alpha2Code = "AN"; Iso31663Code = "ANHH" }
            Former { Iso31661Alpha3Code = "NTS"; Iso31661Alpha2Code = "NT"; Iso31663Code = "NTHH" }
            Former { Iso31661Alpha3Code = "NHB"; Iso31661Alpha2Code = "NH"; Iso31663Code = "NHVU" }
            Former { Iso31661Alpha3Code = "PCI"; Iso31661Alpha2Code = "PC"; Iso31663Code = "PCHH" }
            Former { Iso31661Alpha3Code = "PCZ"; Iso31661Alpha2Code = "PZ"; Iso31663Code = "PZPA" }
            Former { Iso31661Alpha3Code = "SCG"; Iso31661Alpha2Code = "CS"; Iso31663Code = "CSXX" }
            Former { Iso31661Alpha3Code = "SEM"; Iso31661Alpha2Code = "SK"; Iso31663Code = "SKIN" }
            Former { Iso31661Alpha3Code = "RHO"; Iso31661Alpha2Code = "RH"; Iso31663Code = "RHZW" }
            Former { Iso31661Alpha3Code = "HVO"; Iso31661Alpha2Code = "HV"; Iso31663Code = "HVBF" }
            Former { Iso31661Alpha3Code = "PUS"; Iso31661Alpha2Code = "PU"; Iso31663Code = "PUUM" }
            Former { Iso31661Alpha3Code = "SUN"; Iso31661Alpha2Code = "SU"; Iso31663Code = "SUHH" }
            Former { Iso31661Alpha3Code = "VDR"; Iso31661Alpha2Code = "VD"; Iso31663Code = "VDVN" }
            Former { Iso31661Alpha3Code = "WAK"; Iso31661Alpha2Code = "WK"; Iso31663Code = "WKUM" }
            Former { Iso31661Alpha3Code = "YMD"; Iso31661Alpha2Code = "YD"; Iso31663Code = "YDYE" }
            Former { Iso31661Alpha3Code = "YUG"; Iso31661Alpha2Code = "YU"; Iso31663Code = "YUCS" }
            Former { Iso31661Alpha3Code = "ZAR"; Iso31661Alpha2Code = "ZR"; Iso31663Code = "ZRCD" }
        |] 
    let CountriesByIso31661Alpha3Code = AllCountries |> Array.map (fun c -> (c.Alpha3Code(), c)) |> dict
    let CountriesByIso31661Alpha2Code = AllCountries |> Array.map (fun c -> (c.Alpha2Code(), c)) |> dict

module Domain =
    open System
    open GeographicLib
    open Iso3166
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
    type EventProfile = {
        Name: string
        OneLineSummary: string option
        ImageUrl: string option
    }

    [<StructuralEquality; NoComparison>]
    type Event = {
        EventId: Guid
        Profile: EventProfile
    }

    [<StructuralEquality; NoComparison>]
    type EventOccurrenceProfile =
        | InheritedProfile
        | CustomProfile of EventProfile

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

    type TransferRule =
        | TransferToAnyone
        | TransferToFriendsAndFamilyOnly
        | TransferToInnerCircleOnly
        | NotTransferable

    type TransferRevocationRule =
        | CanRevokeBeforeStartTime of TimeSpan
        | CannotRevoke

    type PriceType = {
        PriceTypeId: Guid
        PriceTypeIdentifier: string
        PriceTypeDescription: string
    }

    type PriceBand = {
        PriceBandId: Guid
        PriceBandIdentifier: string
        PriceBandDescription: string
    }

    type TicketPrice = {
        PriceId: Guid
        Type: PriceType
        Band: PriceBand
        FaceValue: Money
    }

    [<StructuralEquality; NoComparison>]
    type EventOccurrence = 
        {
            OccurrenceId: Guid
            VenueId: Guid
            TransferRule: TransferRule
            TransferRevocationRule: TransferRevocationRule
            AccessControl: AccessControl
            PublicKey: string
            StartTime: DateTimeOffset
            DoorsOpen: DateTimeOffset
            Duration: TimeSpan
            Event: Event
            Profile: EventOccurrenceProfile
        }
        member this.GetProfile() =
            match this.Profile with
            | InheritedProfile -> this.Event.Profile
            | CustomProfile profile -> profile

    type SeatLocation = 
        | SeatNumber of string
        | RowSeat of string * string
        | BlockRowSeat of string * string * string
        | SectionBlockRowSeat of string * string * string * string
        member this.Number() =
            match this with
            | SeatNumber number -> number
            | RowSeat (_, number) -> number
            | BlockRowSeat (_, _, number) -> number
            | SectionBlockRowSeat (_, _, _, number) -> number
        member this.GetRow() =
            match this with
            | RowSeat (row, _) -> Some row
            | BlockRowSeat (_, row, _) -> Some row
            | SectionBlockRowSeat (_, _, row, _) -> Some row
            | _ -> None
        member this.GetBlock() =
            match this with
            | BlockRowSeat (block, _, _) -> Some block
            | SectionBlockRowSeat (_, block, _, _) -> Some block
            | _ -> None
        member this.GetSection() =
            match this with
            | SectionBlockRowSeat (section, _, _, _) -> Some section
            | _ -> None

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
        | Never
        | DoorsOpen
        | BeforeDoorsOpen of TimeSpan
        | AtTime of DateTimeOffset

    type Ticket = {
        TicketId: Guid
        EventOccurrenceId: Guid
        VerificationEnabled: EnableVerification
        TransferRule: TransferRule option
        TransferRevocationRule: TransferRevocationRule option
        Price: TicketPrice
        TicketIdentifier: string
        TicketDescription: string option
        Seat: Seat
        TermsAndConditions: Uri
    }

    type TicketResale = {
        ResaleId: Guid
        ResellerId: Guid
        ResoldUtc: DateTime
    }

    type TicketReturn = {
        ReturnId: Guid
        ReturnedUtc: DateTime
    }

    type TicketTransfer = {
        TransferId: Guid
        TicketOrderId: Guid
        SenderId: Guid
        RecipientId: Guid
        RecipientEnrolmentId: Guid
        TransferredUtc: DateTime
        RevokedUtc: DateTime option
    }

    type OrderedTicketStatus = 
        | Purchased
        | Resold of TicketResale
        | Returned of TicketReturn
        | Transferred of TicketTransfer

    type OrderedTicket = {
        TicketOrderId: Guid
        Ticket: Ticket
        Status: OrderedTicketStatus
    }

    type PikticalUser = | PikticalId of string
