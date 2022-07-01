// <copyright file="OnlineSalesLineUpdateRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace Microsoft.MSE.D365.Library
{
	using Microsoft.Dynamics.Commerce.Runtime.Messages;
	using System.Collections.Generic;
	using System.Runtime.Serialization;

	/// <summary>
	/// Online payment transaction tracking request.
	/// </summary>
	public class GetOnlinePaymentTrackingResponse : Response
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetOnlinePaymentTrackingResponse"/> class.
		/// </summary>
		/// <param name="trackings"> trackings.</param>
		/// <param name="message"> error message.</param>
		public GetOnlinePaymentTrackingResponse(List<OnlinePaymentTracking> trackings, string message, bool successful)
		{
			this.OnlinePaymentTransactionTrackings = trackings;
			this.Message = message;
			this.Successful = successful;
		}

		/// <summary>
		/// Gets or Sets nlinePaymentTransactionTrackings.
		/// </summary>
		[DataMember]
		public List<OnlinePaymentTracking> OnlinePaymentTransactionTrackings { get; set; }

		/// <summary>
		/// Gets status message for the request with any execution details.
		/// </summary>
		[DataMember(Name = "message")]
		public string Message { get; set; }

		/// <summary>
		/// Gets or Sets nlinePaymentTransactionTrackings.
		/// </summary>
		[DataMember]
		public bool Successful { get; set; }
	}
}
