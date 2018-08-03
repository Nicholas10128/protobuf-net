﻿namespace ProtoBuf
{
    /// <summary>
    /// Registry of known errors / warnings
    /// </summary>
    internal enum ErrorCode
    {
        Undefined = 0,
        ProtocError = 1,
        TypeNotFound = 2,
        ProtoSyntaxRequireProto2 = 3,
        ImportNotFound = 4,
        InvalidMapKeyType = 5,
        EnumValueNotFound = 6,
        MissingCustomOption = 7,
        InvalidFloatingPoint = 8,
        FieldDuplicatedNumber = 9,
        ImportDuplicated = 10,
        OptionsNotImplemented = 11,
        InvalidBoolean = 12,
        ImportNotPermitted = 13,
        PackedFieldInvalidType = 14,
        ProtoSyntaxInvalid = 15,
        InvalidInteger = 16,
        ProtoSyntaxPreceedTypes = 17,
        ProtoSyntaxNotSpecified = 18,
        FieldDuplicatedName = 19,
        ImportNotUsed = 20,
        OneOfRepeated = 21,
        OneOfRequired = 22,
        OneOfOptional = 23,
        MapUseMapEntry = 24,
        DefaultValueNotHandled = 25,
        FieldNumberInvalid = 26,
        FieldNumberReserved = 27,
        FieldNameReserved = 28,
        InvalidEscapeSequence = 29,
        GroupNamesStartUpperCase = 30,
        UnknownParseError = 31,
    }
}