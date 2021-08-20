namespace Going.Plaid.Entity;

/// <summary>
/// <para>The channel used to make a payment.</para>
/// </summary>
public enum TransactionPaymentChannelEnum
{
	/// <summary>
	/// <para>transactions that took place online.</para>
	/// </summary>
	[EnumMember(Value = "online")]
	Online,

	/// <summary>
	/// <para>transactions that were made at a physical location.</para>
	/// </summary>
	[EnumMember(Value = "in store")]
	InStore,

	/// <summary>
	/// <para>transactions that relate to banks, e.g. fees or deposits.</para>
	/// </summary>
	[EnumMember(Value = "other")]
	Other,
}