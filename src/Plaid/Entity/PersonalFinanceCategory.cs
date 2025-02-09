namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information describing the intent of the transaction. Most relevant for personal finance use cases, but not limited to such use cases. The field is currently in beta.</para>
/// <para>The complete category can be generated by concatenating primary and detailed categories.</para>
/// <para>This feature is currently in beta – to request access, contact transactions-feedback@plaid.com.</para>
/// </summary>
public record PersonalFinanceCategory
{
	/// <summary>
	/// <para>A high level category that communicates the broad category of the transaction.</para>
	/// </summary>
	[JsonPropertyName("primary")]
	public string Primary { get; init; } = default!;

	/// <summary>
	/// <para>Provides additional granularity to the primary categorization.</para>
	/// </summary>
	[JsonPropertyName("detailed")]
	public string Detailed { get; init; } = default!;
}