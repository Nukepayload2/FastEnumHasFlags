// Class EnumHelperImpl(Of T As Class)
.class private auto ansi FastEnumHasFlags.EnumHelperImpl`1<class T>
	extends [mscorlib]System.Object
{
    // Public Shared Function HasFlag(Of TEnum As {Structure, T})(
	//     enumValue As TEnum,
	//     flagValue As TEnum
	// ) As Boolean
	.method public static 
		bool HasFlag<valuetype .ctor (!T, [mscorlib]System.ValueType) TEnum> (
			!!TEnum enumValue,
			!!TEnum flagValue
		) cil managed 
	{
		.maxstack 3
		ldarg.0 // Get enumValue as argument
		conv.u8 // CULng(enumValue)
		dup     // Copy CULng(enumValue) as new argument
		ldarg.1 // Get flagValue as argument
		conv.u8 // CULng(flagValue)
		or      // CULng(enumValue) Or CULng(flagValue)
		ceq     // CULng(enumValue) = CULng(enumValue) Or CULng(flagValue)
		ret     // Return CULng(enumValue) = CULng(enumValue) Or CULng(flagValue)
	} // End Function

} // End Class