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
		conv.u8 // CLng(enumValue)
		dup     // Copy CLng(enumValue) as new argument
		ldarg.1 // Get flagValue as argument
		conv.u8 // CLng(flagValue)
		or      // CLng(enumValue) Or CLng(flagValue)
		ceq     // CLng(enumValue) = CLng(enumValue) Or CLng(flagValue)
		ret     // Return CLng(enumValue) = CLng(enumValue) Or CLng(flagValue)
	} // End Function

} // End Class