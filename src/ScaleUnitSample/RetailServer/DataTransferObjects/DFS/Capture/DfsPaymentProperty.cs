// <copyright file="DfsPaymentProperty.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace MSE.D365.Library.DellFinanceService.DFS.DataModel.Capture
{
    /// <summary>
    /// DPA extension properties.
    /// </summary>
    public class DfsPaymentProperty
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DfsPaymentProperty"/> class.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="stringValue">The string value.</param>
        public DfsPaymentProperty(string key, string stringValue)
        {
            this.Key = key;
            this.StringValue = stringValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DfsPaymentProperty"/> class.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The decimal value.</param>
        public DfsPaymentProperty(string key, decimal value)
        {
            this.Key = key;
            this.DecimalValue = value;
        }

        /// <summary>
        /// Gets or sets key in extension properties.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets string value of the key.
        /// </summary>
        public string StringValue { get; set; }

        /// <summary>
        /// Gets or sets decimal value of the key.
        /// </summary>
        public decimal DecimalValue { get; set; }
    }
}
