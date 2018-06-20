Imports System.Runtime.CompilerServices

Public Class EnumHelperImpl(Of T As Class)

    <MethodImpl(MethodImplOptions.ForwardRef)>
    Public Shared Function HasFlag(Of TEnum As {Structure, T})(enumValue As TEnum, flagValue As TEnum) As Boolean
        Return Nothing
    End Function
End Class
