﻿Option Strict On
Enum EnumOfSByte As SByte
    NegFlag6 = -&B1000000
    NegFlag5 = -&B100000
    NegFlag4 = -&B10000
    NegFlag3 = -&B1000
    NegFlag2 = -&B100
    NegFlag1 = -&B10
    NegFlag0 = -&B1
    ZeroFlag = 0
    PosFlag0 = &B1
    PosFlag1 = &B10
    PosFlag2 = &B100
    PosFlag3 = &B1000
    PosFlag4 = &B10000
    PosFlag5 = &B100000
    PosFlag6 = &B1000000
End Enum
Enum EnumOfByte As Byte
    ZeroFlag = 0
    PosFlag0 = &B1
    PosFlag1 = &B10
    PosFlag2 = &B100
    PosFlag3 = &B1000
    PosFlag4 = &B10000
    PosFlag5 = &B100000
    PosFlag6 = &B1000000
    PosFlag7 = &B10000000
End Enum
Enum EnumOfInt16 As Int16
    NegFlag14 = -&B100000000000000S
    NegFlag13 = -&B10000000000000S
    NegFlag12 = -&B1000000000000S
    NegFlag11 = -&B100000000000S
    NegFlag10 = -&B10000000000S
    NegFlag9 = -&B1000000000S
    NegFlag8 = -&B100000000S
    NegFlag7 = -&B10000000S
    NegFlag6 = -&B1000000S
    NegFlag5 = -&B100000S
    NegFlag4 = -&B10000S
    NegFlag3 = -&B1000S
    NegFlag2 = -&B100S
    NegFlag1 = -&B10S
    NegFlag0 = -&B1S
    ZeroFlag = 0
    PosFlag0 = &B1S
    PosFlag1 = &B10S
    PosFlag2 = &B100S
    PosFlag3 = &B1000S
    PosFlag4 = &B10000S
    PosFlag5 = &B100000S
    PosFlag6 = &B1000000S
    PosFlag7 = &B10000000S
    PosFlag8 = &B100000000S
    PosFlag9 = &B1000000000S
    PosFlag10 = &B10000000000S
    PosFlag11 = &B100000000000S
    PosFlag12 = &B1000000000000S
    PosFlag13 = &B10000000000000S
    PosFlag14 = &B100000000000000S
End Enum
Enum EnumOfUInt16 As UInt16
    ZeroFlag = 0
    PosFlag0 = &B1US
    PosFlag1 = &B10US
    PosFlag2 = &B100US
    PosFlag3 = &B1000US
    PosFlag4 = &B10000US
    PosFlag5 = &B100000US
    PosFlag6 = &B1000000US
    PosFlag7 = &B10000000US
    PosFlag8 = &B100000000US
    PosFlag9 = &B1000000000US
    PosFlag10 = &B10000000000US
    PosFlag11 = &B100000000000US
    PosFlag12 = &B1000000000000US
    PosFlag13 = &B10000000000000US
    PosFlag14 = &B100000000000000US
    PosFlag15 = &B1000000000000000US
End Enum
Enum EnumOfInt32 As Int32
    NegFlag30 = -&B1000000000000000000000000000000
    NegFlag29 = -&B100000000000000000000000000000
    NegFlag28 = -&B10000000000000000000000000000
    NegFlag27 = -&B1000000000000000000000000000
    NegFlag26 = -&B100000000000000000000000000
    NegFlag25 = -&B10000000000000000000000000
    NegFlag24 = -&B1000000000000000000000000
    NegFlag23 = -&B100000000000000000000000
    NegFlag22 = -&B10000000000000000000000
    NegFlag21 = -&B1000000000000000000000
    NegFlag20 = -&B100000000000000000000
    NegFlag19 = -&B10000000000000000000
    NegFlag18 = -&B1000000000000000000
    NegFlag17 = -&B100000000000000000
    NegFlag16 = -&B10000000000000000
    NegFlag15 = -&B1000000000000000
    NegFlag14 = -&B100000000000000
    NegFlag13 = -&B10000000000000
    NegFlag12 = -&B1000000000000
    NegFlag11 = -&B100000000000
    NegFlag10 = -&B10000000000
    NegFlag9 = -&B1000000000
    NegFlag8 = -&B100000000
    NegFlag7 = -&B10000000
    NegFlag6 = -&B1000000
    NegFlag5 = -&B100000
    NegFlag4 = -&B10000
    NegFlag3 = -&B1000
    NegFlag2 = -&B100
    NegFlag1 = -&B10
    NegFlag0 = -&B1
    ZeroFlag = 0
    PosFlag0 = &B1
    PosFlag1 = &B10
    PosFlag2 = &B100
    PosFlag3 = &B1000
    PosFlag4 = &B10000
    PosFlag5 = &B100000
    PosFlag6 = &B1000000
    PosFlag7 = &B10000000
    PosFlag8 = &B100000000
    PosFlag9 = &B1000000000
    PosFlag10 = &B10000000000
    PosFlag11 = &B100000000000
    PosFlag12 = &B1000000000000
    PosFlag13 = &B10000000000000
    PosFlag14 = &B100000000000000
    PosFlag15 = &B1000000000000000
    PosFlag16 = &B10000000000000000
    PosFlag17 = &B100000000000000000
    PosFlag18 = &B1000000000000000000
    PosFlag19 = &B10000000000000000000
    PosFlag20 = &B100000000000000000000
    PosFlag21 = &B1000000000000000000000
    PosFlag22 = &B10000000000000000000000
    PosFlag23 = &B100000000000000000000000
    PosFlag24 = &B1000000000000000000000000
    PosFlag25 = &B10000000000000000000000000
    PosFlag26 = &B100000000000000000000000000
    PosFlag27 = &B1000000000000000000000000000
    PosFlag28 = &B10000000000000000000000000000
    PosFlag29 = &B100000000000000000000000000000
    PosFlag30 = &B1000000000000000000000000000000
End Enum
Enum EnumOfUInt32 As UInt32
    ZeroFlag = 0
    PosFlag0 = &B1UI
    PosFlag1 = &B10UI
    PosFlag2 = &B100UI
    PosFlag3 = &B1000UI
    PosFlag4 = &B10000UI
    PosFlag5 = &B100000UI
    PosFlag6 = &B1000000UI
    PosFlag7 = &B10000000UI
    PosFlag8 = &B100000000UI
    PosFlag9 = &B1000000000UI
    PosFlag10 = &B10000000000UI
    PosFlag11 = &B100000000000UI
    PosFlag12 = &B1000000000000UI
    PosFlag13 = &B10000000000000UI
    PosFlag14 = &B100000000000000UI
    PosFlag15 = &B1000000000000000UI
    PosFlag16 = &B10000000000000000UI
    PosFlag17 = &B100000000000000000UI
    PosFlag18 = &B1000000000000000000UI
    PosFlag19 = &B10000000000000000000UI
    PosFlag20 = &B100000000000000000000UI
    PosFlag21 = &B1000000000000000000000UI
    PosFlag22 = &B10000000000000000000000UI
    PosFlag23 = &B100000000000000000000000UI
    PosFlag24 = &B1000000000000000000000000UI
    PosFlag25 = &B10000000000000000000000000UI
    PosFlag26 = &B100000000000000000000000000UI
    PosFlag27 = &B1000000000000000000000000000UI
    PosFlag28 = &B10000000000000000000000000000UI
    PosFlag29 = &B100000000000000000000000000000UI
    PosFlag30 = &B1000000000000000000000000000000UI
    PosFlag31 = &B10000000000000000000000000000000UI
End Enum
Enum EnumOfInt64 As Int64
    NegFlag62 = -&B100000000000000000000000000000000000000000000000000000000000000L
    NegFlag61 = -&B10000000000000000000000000000000000000000000000000000000000000L
    NegFlag60 = -&B1000000000000000000000000000000000000000000000000000000000000L
    NegFlag59 = -&B100000000000000000000000000000000000000000000000000000000000L
    NegFlag58 = -&B10000000000000000000000000000000000000000000000000000000000L
    NegFlag57 = -&B1000000000000000000000000000000000000000000000000000000000L
    NegFlag56 = -&B100000000000000000000000000000000000000000000000000000000L
    NegFlag55 = -&B10000000000000000000000000000000000000000000000000000000L
    NegFlag54 = -&B1000000000000000000000000000000000000000000000000000000L
    NegFlag53 = -&B100000000000000000000000000000000000000000000000000000L
    NegFlag52 = -&B10000000000000000000000000000000000000000000000000000L
    NegFlag51 = -&B1000000000000000000000000000000000000000000000000000L
    NegFlag50 = -&B100000000000000000000000000000000000000000000000000L
    NegFlag49 = -&B10000000000000000000000000000000000000000000000000L
    NegFlag48 = -&B1000000000000000000000000000000000000000000000000L
    NegFlag47 = -&B100000000000000000000000000000000000000000000000L
    NegFlag46 = -&B10000000000000000000000000000000000000000000000L
    NegFlag45 = -&B1000000000000000000000000000000000000000000000L
    NegFlag44 = -&B100000000000000000000000000000000000000000000L
    NegFlag43 = -&B10000000000000000000000000000000000000000000L
    NegFlag42 = -&B1000000000000000000000000000000000000000000L
    NegFlag41 = -&B100000000000000000000000000000000000000000L
    NegFlag40 = -&B10000000000000000000000000000000000000000L
    NegFlag39 = -&B1000000000000000000000000000000000000000L
    NegFlag38 = -&B100000000000000000000000000000000000000L
    NegFlag37 = -&B10000000000000000000000000000000000000L
    NegFlag36 = -&B1000000000000000000000000000000000000L
    NegFlag35 = -&B100000000000000000000000000000000000L
    NegFlag34 = -&B10000000000000000000000000000000000L
    NegFlag33 = -&B1000000000000000000000000000000000L
    NegFlag32 = -&B100000000000000000000000000000000L
    NegFlag31 = -&B10000000000000000000000000000000L
    NegFlag30 = -&B1000000000000000000000000000000L
    NegFlag29 = -&B100000000000000000000000000000L
    NegFlag28 = -&B10000000000000000000000000000L
    NegFlag27 = -&B1000000000000000000000000000L
    NegFlag26 = -&B100000000000000000000000000L
    NegFlag25 = -&B10000000000000000000000000L
    NegFlag24 = -&B1000000000000000000000000L
    NegFlag23 = -&B100000000000000000000000L
    NegFlag22 = -&B10000000000000000000000L
    NegFlag21 = -&B1000000000000000000000L
    NegFlag20 = -&B100000000000000000000L
    NegFlag19 = -&B10000000000000000000L
    NegFlag18 = -&B1000000000000000000L
    NegFlag17 = -&B100000000000000000L
    NegFlag16 = -&B10000000000000000L
    NegFlag15 = -&B1000000000000000L
    NegFlag14 = -&B100000000000000L
    NegFlag13 = -&B10000000000000L
    NegFlag12 = -&B1000000000000L
    NegFlag11 = -&B100000000000L
    NegFlag10 = -&B10000000000L
    NegFlag9 = -&B1000000000L
    NegFlag8 = -&B100000000L
    NegFlag7 = -&B10000000L
    NegFlag6 = -&B1000000L
    NegFlag5 = -&B100000L
    NegFlag4 = -&B10000L
    NegFlag3 = -&B1000L
    NegFlag2 = -&B100L
    NegFlag1 = -&B10L
    NegFlag0 = -&B1L
    ZeroFlag = 0
    PosFlag0 = &B1L
    PosFlag1 = &B10L
    PosFlag2 = &B100L
    PosFlag3 = &B1000L
    PosFlag4 = &B10000L
    PosFlag5 = &B100000L
    PosFlag6 = &B1000000L
    PosFlag7 = &B10000000L
    PosFlag8 = &B100000000L
    PosFlag9 = &B1000000000L
    PosFlag10 = &B10000000000L
    PosFlag11 = &B100000000000L
    PosFlag12 = &B1000000000000L
    PosFlag13 = &B10000000000000L
    PosFlag14 = &B100000000000000L
    PosFlag15 = &B1000000000000000L
    PosFlag16 = &B10000000000000000L
    PosFlag17 = &B100000000000000000L
    PosFlag18 = &B1000000000000000000L
    PosFlag19 = &B10000000000000000000L
    PosFlag20 = &B100000000000000000000L
    PosFlag21 = &B1000000000000000000000L
    PosFlag22 = &B10000000000000000000000L
    PosFlag23 = &B100000000000000000000000L
    PosFlag24 = &B1000000000000000000000000L
    PosFlag25 = &B10000000000000000000000000L
    PosFlag26 = &B100000000000000000000000000L
    PosFlag27 = &B1000000000000000000000000000L
    PosFlag28 = &B10000000000000000000000000000L
    PosFlag29 = &B100000000000000000000000000000L
    PosFlag30 = &B1000000000000000000000000000000L
    PosFlag31 = &B10000000000000000000000000000000L
    PosFlag32 = &B100000000000000000000000000000000L
    PosFlag33 = &B1000000000000000000000000000000000L
    PosFlag34 = &B10000000000000000000000000000000000L
    PosFlag35 = &B100000000000000000000000000000000000L
    PosFlag36 = &B1000000000000000000000000000000000000L
    PosFlag37 = &B10000000000000000000000000000000000000L
    PosFlag38 = &B100000000000000000000000000000000000000L
    PosFlag39 = &B1000000000000000000000000000000000000000L
    PosFlag40 = &B10000000000000000000000000000000000000000L
    PosFlag41 = &B100000000000000000000000000000000000000000L
    PosFlag42 = &B1000000000000000000000000000000000000000000L
    PosFlag43 = &B10000000000000000000000000000000000000000000L
    PosFlag44 = &B100000000000000000000000000000000000000000000L
    PosFlag45 = &B1000000000000000000000000000000000000000000000L
    PosFlag46 = &B10000000000000000000000000000000000000000000000L
    PosFlag47 = &B100000000000000000000000000000000000000000000000L
    PosFlag48 = &B1000000000000000000000000000000000000000000000000L
    PosFlag49 = &B10000000000000000000000000000000000000000000000000L
    PosFlag50 = &B100000000000000000000000000000000000000000000000000L
    PosFlag51 = &B1000000000000000000000000000000000000000000000000000L
    PosFlag52 = &B10000000000000000000000000000000000000000000000000000L
    PosFlag53 = &B100000000000000000000000000000000000000000000000000000L
    PosFlag54 = &B1000000000000000000000000000000000000000000000000000000L
    PosFlag55 = &B10000000000000000000000000000000000000000000000000000000L
    PosFlag56 = &B100000000000000000000000000000000000000000000000000000000L
    PosFlag57 = &B1000000000000000000000000000000000000000000000000000000000L
    PosFlag58 = &B10000000000000000000000000000000000000000000000000000000000L
    PosFlag59 = &B100000000000000000000000000000000000000000000000000000000000L
    PosFlag60 = &B1000000000000000000000000000000000000000000000000000000000000L
    PosFlag61 = &B10000000000000000000000000000000000000000000000000000000000000L
    PosFlag62 = &B100000000000000000000000000000000000000000000000000000000000000L
End Enum
Enum EnumOfUInt64 As UInt64
    ZeroFlag = 0
    PosFlag0 = &B1UL
    PosFlag1 = &B10UL
    PosFlag2 = &B100UL
    PosFlag3 = &B1000UL
    PosFlag4 = &B10000UL
    PosFlag5 = &B100000UL
    PosFlag6 = &B1000000UL
    PosFlag7 = &B10000000UL
    PosFlag8 = &B100000000UL
    PosFlag9 = &B1000000000UL
    PosFlag10 = &B10000000000UL
    PosFlag11 = &B100000000000UL
    PosFlag12 = &B1000000000000UL
    PosFlag13 = &B10000000000000UL
    PosFlag14 = &B100000000000000UL
    PosFlag15 = &B1000000000000000UL
    PosFlag16 = &B10000000000000000UL
    PosFlag17 = &B100000000000000000UL
    PosFlag18 = &B1000000000000000000UL
    PosFlag19 = &B10000000000000000000UL
    PosFlag20 = &B100000000000000000000UL
    PosFlag21 = &B1000000000000000000000UL
    PosFlag22 = &B10000000000000000000000UL
    PosFlag23 = &B100000000000000000000000UL
    PosFlag24 = &B1000000000000000000000000UL
    PosFlag25 = &B10000000000000000000000000UL
    PosFlag26 = &B100000000000000000000000000UL
    PosFlag27 = &B1000000000000000000000000000UL
    PosFlag28 = &B10000000000000000000000000000UL
    PosFlag29 = &B100000000000000000000000000000UL
    PosFlag30 = &B1000000000000000000000000000000UL
    PosFlag31 = &B10000000000000000000000000000000UL
    PosFlag32 = &B100000000000000000000000000000000UL
    PosFlag33 = &B1000000000000000000000000000000000UL
    PosFlag34 = &B10000000000000000000000000000000000UL
    PosFlag35 = &B100000000000000000000000000000000000UL
    PosFlag36 = &B1000000000000000000000000000000000000UL
    PosFlag37 = &B10000000000000000000000000000000000000UL
    PosFlag38 = &B100000000000000000000000000000000000000UL
    PosFlag39 = &B1000000000000000000000000000000000000000UL
    PosFlag40 = &B10000000000000000000000000000000000000000UL
    PosFlag41 = &B100000000000000000000000000000000000000000UL
    PosFlag42 = &B1000000000000000000000000000000000000000000UL
    PosFlag43 = &B10000000000000000000000000000000000000000000UL
    PosFlag44 = &B100000000000000000000000000000000000000000000UL
    PosFlag45 = &B1000000000000000000000000000000000000000000000UL
    PosFlag46 = &B10000000000000000000000000000000000000000000000UL
    PosFlag47 = &B100000000000000000000000000000000000000000000000UL
    PosFlag48 = &B1000000000000000000000000000000000000000000000000UL
    PosFlag49 = &B10000000000000000000000000000000000000000000000000UL
    PosFlag50 = &B100000000000000000000000000000000000000000000000000UL
    PosFlag51 = &B1000000000000000000000000000000000000000000000000000UL
    PosFlag52 = &B10000000000000000000000000000000000000000000000000000UL
    PosFlag53 = &B100000000000000000000000000000000000000000000000000000UL
    PosFlag54 = &B1000000000000000000000000000000000000000000000000000000UL
    PosFlag55 = &B10000000000000000000000000000000000000000000000000000000UL
    PosFlag56 = &B100000000000000000000000000000000000000000000000000000000UL
    PosFlag57 = &B1000000000000000000000000000000000000000000000000000000000UL
    PosFlag58 = &B10000000000000000000000000000000000000000000000000000000000UL
    PosFlag59 = &B100000000000000000000000000000000000000000000000000000000000UL
    PosFlag60 = &B1000000000000000000000000000000000000000000000000000000000000UL
    PosFlag61 = &B10000000000000000000000000000000000000000000000000000000000000UL
    PosFlag62 = &B100000000000000000000000000000000000000000000000000000000000000UL
    PosFlag63 = &B1000000000000000000000000000000000000000000000000000000000000000UL
End Enum