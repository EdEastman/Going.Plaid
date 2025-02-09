namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/transfer/get</c> fetches information about the transfer corresponding to the given <c>transfer_id</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/transfer/reference#transferget" /></remarks>
	public Task<Transfer.TransferGetResponse> TransferGetAsync(Transfer.TransferGetRequest request) =>
		PostAsync("/transfer/get", request)
			.ParseResponseAsync<Transfer.TransferGetResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/authorization/create</c> endpoint to determine transfer failure risk.</para>
	/// <para>In Plaid's sandbox environment the decisions will be returned as follows:</para>
	/// <para>  - To approve a transfer, make an authorization request with an <c>amount</c> less than the available balance in the account.</para>
	/// <para>  - To decline a transfer with the rationale code <c>NSF</c>, the available balance on the account must be less than the authorization <c>amount</c>. See <a href="https://plaid.com/docs/sandbox/user-custom/">Create Sandbox test data</a> for details on how to customize data in Sandbox.</para>
	/// <para>  - To decline a transfer with the rationale code <c>RISK</c>, the available balance on the account must be exactly $0. See <a href="https://plaid.com/docs/sandbox/user-custom/">Create Sandbox test data</a> for details on how to customize data in Sandbox.</para>
	/// <para>  - To permit a transfer with the rationale code <c>MANUALLY_VERIFIED_ITEM</c>, create an Item in Link through the <a href="https://plaid.com/docs/auth/coverage/testing/#testing-same-day-micro-deposits">Same Day Micro-deposits flow</a>.</para>
	/// <para>  - To permit a transfer with the rationale code <c>LOGIN_REQUIRED</c>, <a href="https://plaid.com/docs/sandbox/#item_login_required">reset the login for an Item</a>.</para>
	/// <para>All username/password combinations other than the ones listed above will result in a decision of permitted and rationale code <c>ERROR</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/transfer/reference#transferauthorizationcreate" /></remarks>
	public Task<Transfer.TransferAuthorizationCreateResponse> TransferAuthorizationCreateAsync(Transfer.TransferAuthorizationCreateRequest request) =>
		PostAsync("/transfer/authorization/create", request)
			.ParseResponseAsync<Transfer.TransferAuthorizationCreateResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/create</c> endpoint to initiate a new transfer.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/transfer/reference#transfercreate" /></remarks>
	public Task<Transfer.TransferCreateResponse> TransferCreateAsync(Transfer.TransferCreateRequest request) =>
		PostAsync("/transfer/create", request)
			.ParseResponseAsync<Transfer.TransferCreateResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/list</c> endpoint to see a list of all your transfers and their statuses. Results are paginated; use the <c>count</c> and <c>offset</c> query parameters to retrieve the desired transfers.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/transfer/reference#transferlist" /></remarks>
	public Task<Transfer.TransferListResponse> TransferListAsync(Transfer.TransferListRequest request) =>
		PostAsync("/transfer/list", request)
			.ParseResponseAsync<Transfer.TransferListResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/cancel</c> endpoint to cancel a transfer.  A transfer is eligible for cancelation if the <c>cancellable</c> property returned by <c>/transfer/get</c> is <c>true</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/transfer/reference#transfercancel" /></remarks>
	public Task<Transfer.TransferCancelResponse> TransferCancelAsync(Transfer.TransferCancelRequest request) =>
		PostAsync("/transfer/cancel", request)
			.ParseResponseAsync<Transfer.TransferCancelResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/event/list</c> endpoint to get a list of transfer events based on specified filter criteria.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/transfer/reference#transfereventlist" /></remarks>
	public Task<Transfer.TransferEventListResponse> TransferEventListAsync(Transfer.TransferEventListRequest request) =>
		PostAsync("/transfer/event/list", request)
			.ParseResponseAsync<Transfer.TransferEventListResponse>();

	/// <summary>
	/// <para><c>/transfer/event/sync</c> allows you to request up to the next 25 transfer events that happened after a specific <c>event_id</c>. Use the <c>/transfer/event/sync</c> endpoint to guarantee you have seen all transfer events.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/transfer/reference#transfereventsync" /></remarks>
	public Task<Transfer.TransferEventSyncResponse> TransferEventSyncAsync(Transfer.TransferEventSyncRequest request) =>
		PostAsync("/transfer/event/sync", request)
			.ParseResponseAsync<Transfer.TransferEventSyncResponse>();
}