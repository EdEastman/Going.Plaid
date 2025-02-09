namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorIdentityGetResponse defines the response schema for <c>/processor/identity/get</c></para>
/// </summary>
public record ProcessorIdentityGetResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("account")]
	public Entity.AccountIdentity Account { get; init; } = default!;
}