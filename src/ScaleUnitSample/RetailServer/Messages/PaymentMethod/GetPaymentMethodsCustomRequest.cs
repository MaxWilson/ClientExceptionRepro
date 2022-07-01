namespace MSE.D365.Library.PaymentMethod
{
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.DataServices.Messages;

    /// <summary>
    /// The data request that retrieves custom properties for payment methods from database.
    /// </summary>
    [DataContract]
    public sealed class GetPaymentMethodsCustomRequest : DataRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPaymentMethodsCustomRequest"/> class.
        /// </summary>
        public GetPaymentMethodsCustomRequest()
        {
        }
    }
}
