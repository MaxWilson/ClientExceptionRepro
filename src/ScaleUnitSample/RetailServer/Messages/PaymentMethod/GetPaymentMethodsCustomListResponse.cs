using MSE.D365.Library.PaymentMethod;
using System.Collections.Generic;

namespace MSE.D365.Library.PaymentMethods
{
    /// <summary>
    /// The GetPaymentMethodsCustomListResponse response.
    /// </summary>
    public class GetPaymentMethodsCustomListResponse
    {
        /// <summary>
        /// Gets or sets the Request ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the list of payment methods.
        /// </summary>
        public IEnumerable<GetPaymentMethodsCustomResponse> GetPaymentMethodsCustomPropertiesListResponse { get; set; }
    }
}
