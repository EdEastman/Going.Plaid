namespace Going.Plaid.Entity;

/// <summary>
/// <para>The <c>refresh_interval</c> may be <c>DELAYED</c> or <c>STOPPED</c> even when the success rate is high. This value is only returned for Transactions status breakdowns.</para>
/// </summary>
public enum StatusBreakdownRefreshIntervalEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NORMAL")]
	Normal,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DELAYED")]
	Delayed,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "STOPPED")]
	Stopped,
}