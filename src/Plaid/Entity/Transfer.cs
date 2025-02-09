namespace Going.Plaid.Entity;

/// <summary>
/// <para>Represents a transfer within the Transfers API.</para>
/// </summary>
public record Transfer
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a transfer.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>Specifies the use case of the transfer.  Required for transfers on an ACH network.</para>
	/// </summary>
	[JsonPropertyName("ach_class")]
	public Entity.AchClass AchClass { get; init; } = default!;

	/// <summary>
	/// <para>The account ID that should be credited/debited for this transfer.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The type of transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.TransferType Type { get; init; } = default!;

	/// <summary>
	/// <para>The legal name and other information for the account holder.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.TransferUserInResponse User { get; init; } = default!;

	/// <summary>
	/// <para>The amount of the transfer (decimal string with two digits of precision e.g. “10.00”).</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; init; } = default!;

	/// <summary>
	/// <para>The description of the transfer.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; init; } = default!;

	/// <summary>
	/// <para>The datetime when this transfer was created. This will be of the form <c>2006-01-02T15:04:05Z</c></para>
	/// </summary>
	[JsonPropertyName("created")]
	public DateTimeOffset Created { get; init; } = default!;

	/// <summary>
	/// <para>The status of the transfer.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.TransferStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>The network or rails used for the transfer. Valid options are <c>ach</c> or <c>same-day-ach</c>.</para>
	/// </summary>
	[JsonPropertyName("network")]
	public Entity.TransferNetwork Network { get; init; } = default!;

	/// <summary>
	/// <para>When <c>true</c>, you can still cancel this transfer.</para>
	/// </summary>
	[JsonPropertyName("cancellable")]
	public bool Cancellable { get; init; } = default!;

	/// <summary>
	/// <para>The failure reason if the type of this transfer is <c>"failed"</c> or <c>"reversed"</c>. Null value otherwise.</para>
	/// </summary>
	[JsonPropertyName("failure_reason")]
	public Entity.TransferFailure? FailureReason { get; init; } = default!;

	/// <summary>
	/// <para>The Metadata object is a mapping of client-provided string fields to any string value. The following limitations apply:</para>
	/// <para>- The JSON values must be Strings (no nested JSON objects allowed)</para>
	/// <para>- Only ASCII characters may be used</para>
	/// <para>- Maximum of 50 key/value pairs</para>
	/// <para>- Maximum key length of 40 characters</para>
	/// <para>- Maximum value length of 500 characters</para>
	/// </summary>
	[JsonPropertyName("metadata")]
	public Entity.TransferMetadata? Metadata { get; init; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for the origination account that was used for this transfer.</para>
	/// </summary>
	[JsonPropertyName("origination_account_id")]
	public string OriginationAccountId { get; init; } = default!;
}