Option Strict On

<TestClass>
Public Class EnumHasFlagTests
    <TestMethod>
    Public Sub TestEnumOfSByte()
        Dim enumValues = [Enum].GetValues(GetType(EnumOfSByte)).Cast(Of EnumOfSByte).ToArray
        For i = 1 To enumValues.Length - 1
            For j = 0 To enumValues.Length - 1
                Dim enumValue = enumValues(i)
                Dim flag = enumValues(j)
                Dim expected = enumValue.HasFlag(flag)
                Dim actual = EnumHelper.HasFlag(enumValue, flag)
                Assert.AreEqual(expected, actual)
            Next
        Next
    End Sub
    <TestMethod>
    Public Sub TestEnumOfByte()
        Dim enumValues = [Enum].GetValues(GetType(EnumOfByte)).Cast(Of EnumOfByte).ToArray
        For i = 1 To enumValues.Length - 1
            For j = 0 To enumValues.Length - 1
                Dim enumValue = enumValues(i)
                Dim flag = enumValues(j)
                Dim expected = enumValue.HasFlag(flag)
                Dim actual = EnumHelper.HasFlag(enumValue, flag)
                Assert.AreEqual(expected, actual)
            Next
        Next
    End Sub
    <TestMethod>
    Public Sub TestEnumOfInt16()
        Dim enumValues = [Enum].GetValues(GetType(EnumOfInt16)).Cast(Of EnumOfInt16).ToArray
        For i = 1 To enumValues.Length - 1
            For j = 0 To enumValues.Length - 1
                Dim enumValue = enumValues(i)
                Dim flag = enumValues(j)
                Dim expected = enumValue.HasFlag(flag)
                Dim actual = EnumHelper.HasFlag(enumValue, flag)
                Assert.AreEqual(expected, actual)
            Next
        Next
    End Sub
    <TestMethod>
    Public Sub TestEnumOfUInt16()
        Dim enumValues = [Enum].GetValues(GetType(EnumOfUInt16)).Cast(Of EnumOfUInt16).ToArray
        For i = 1 To enumValues.Length - 1
            For j = 0 To enumValues.Length - 1
                Dim enumValue = enumValues(i)
                Dim flag = enumValues(j)
                Dim expected = enumValue.HasFlag(flag)
                Dim actual = EnumHelper.HasFlag(enumValue, flag)
                Assert.AreEqual(expected, actual)
            Next
        Next
    End Sub
    <TestMethod>
    Public Sub TestEnumOfInt32()
        Dim enumValues = [Enum].GetValues(GetType(EnumOfInt32)).Cast(Of EnumOfInt32).ToArray
        For i = 1 To enumValues.Length - 1
            For j = 0 To enumValues.Length - 1
                Dim enumValue = enumValues(i)
                Dim flag = enumValues(j)
                Dim expected = enumValue.HasFlag(flag)
                Dim actual = EnumHelper.HasFlag(enumValue, flag)
                Assert.AreEqual(expected, actual)
            Next
        Next
    End Sub
    <TestMethod>
    Public Sub TestEnumOfUInt32()
        Dim enumValues = [Enum].GetValues(GetType(EnumOfUInt32)).Cast(Of EnumOfUInt32).ToArray
        For i = 1 To enumValues.Length - 1
            For j = 0 To enumValues.Length - 1
                Dim enumValue = enumValues(i)
                Dim flag = enumValues(j)
                Dim expected = enumValue.HasFlag(flag)
                Dim actual = EnumHelper.HasFlag(enumValue, flag)
                Assert.AreEqual(expected, actual)
            Next
        Next
    End Sub
    <TestMethod>
    Public Sub TestEnumOfInt64()
        Dim enumValues = [Enum].GetValues(GetType(EnumOfInt64)).Cast(Of EnumOfInt64).ToArray
        For i = 1 To enumValues.Length - 1
            For j = 0 To enumValues.Length - 1
                Dim enumValue = enumValues(i)
                Dim flag = enumValues(j)
                Dim expected = enumValue.HasFlag(flag)
                Dim actual = EnumHelper.HasFlag(enumValue, flag)
                Assert.AreEqual(expected, actual)
            Next
        Next
    End Sub
    <TestMethod>
    Public Sub TestEnumOfUInt64()
        Dim enumValues = [Enum].GetValues(GetType(EnumOfUInt64)).Cast(Of EnumOfUInt64).ToArray
        For i = 1 To enumValues.Length - 1
            For j = 0 To enumValues.Length - 1
                Dim enumValue = enumValues(i)
                Dim flag = enumValues(j)
                Dim expected = enumValue.HasFlag(flag)
                Dim actual = EnumHelper.HasFlag(enumValue, flag)
                Assert.AreEqual(expected, actual)
            Next
        Next
    End Sub
End Class
