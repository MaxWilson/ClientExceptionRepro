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
	public class VoidOnlinePaymentTrackingRequest : Request
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="VoidOnlinePaymentTrackingRequest"/> class.
		/// </summary>
		/// <param name="trackingId">Tracking id</param>
		public VoidOnlinePaymentTrackingRequest(string trackingId)
		{
			this.TrackingId = trackingId;
		}

		/// <summary>
		/// Gets or sets the tracking Id.
		/// </summary>
		[JsonProperty("trackingId", Required = Required.Always)]
		public string TrackingId { get; set; }
	}
}