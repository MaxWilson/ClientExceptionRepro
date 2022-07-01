// <copyright file="OnlineSalesLineUpdateRequest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace Microsoft.MSE.D365.Library
{
	using System;
	using Microsoft.Dynamics.Commerce.Runtime.Messages;
	using Newtonsoft.Json;

	/// <summary>
	/// Online payment transaction tracking request.
	/// </summary>
	public class GetOnlinePaymentTrackingRequest : Request
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetOnlinePaymentTrackingRequest"/> class.
		/// </summary>
		/// <param name="paymentStatus">Payment Status of the tracking request</param>
		public GetOnlinePaymentTrackingRequest(int paymentStatus)
		{
			this.PaymentStatus = paymentStatus;
		}

		/// <summary>
		/// Gets or sets the paymentStatus
		/// </summary>
		[JsonProperty("paymentStatus")]
		public int PaymentStatus { get; set; }
	}
}
