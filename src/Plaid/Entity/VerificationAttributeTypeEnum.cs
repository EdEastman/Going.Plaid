namespace Going.Plaid.Entity;

/// <summary>
/// <para>Message indicating the reason as to why the verification failed</para>
/// </summary>
public enum VerificationAttributeTypeEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VERIFICATION_ATTRIBUTE_TYPE_UNKNOWN")]
	VerificationAttributeTypeUnknown,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VERIFICATION_ATTRIBUTE_TYPE_AMOUNT_MATCH")]
	VerificationAttributeTypeAmountMatch,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VERIFICATION_ATTRIBUTE_TYPE_DATE_MATCH")]
	VerificationAttributeTypeDateMatch,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VERIFICATION_ATTRIBUTE_TYPE_DATE_MISMATCH")]
	VerificationAttributeTypeDateMismatch,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VERIFICATION_ATTRIBUTE_TYPE_FILE_TAMPERING")]
	VerificationAttributeTypeFileTampering,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}