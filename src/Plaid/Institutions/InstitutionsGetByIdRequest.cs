namespace Going.Plaid.Institutions;

/// <summary>
/// <para>InstitutionsGetByIdRequest defines the request schema for <c>/institutions/get_by_id</c></para>
/// </summary>
public partial class InstitutionsGetByIdRequest : RequestBase
{
	/// <summary>
	/// <para>The ID of the institution to get details about</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string InstitutionId { get; set; } = default!;

	/// <summary>
	/// <para>Specify an array of Plaid-supported country codes this institution supports, using the ISO-3166-1 alpha-2 country code standard.</para>
	/// </summary>
	[JsonPropertyName("country_codes")]
	public IReadOnlyList<Entity.CountryCode> CountryCodes { get; set; } = default!;

	/// <summary>
	/// <para>Specifies optional parameters for <c>/institutions/get_by_id</c>. If provided, must not be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.InstitutionsGetByIdRequestOptions Options { get; set; } = default!;
}