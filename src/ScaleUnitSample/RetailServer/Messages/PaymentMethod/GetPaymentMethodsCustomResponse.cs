namespace MSE.D365.Library.PaymentMethod
{
    using System;
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.ComponentModel.DataAnnotations;
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;

    /// <summary>
    /// The GetPaymentMethodsCustomResponse entity represents a mapping between payment methods and whether they should be displayed on pos checkout page.
    /// </summary>
    public sealed class GetPaymentMethodsCustomResponse : CommerceEntity
    {
        private const string HideOnPosCheckoutCustomColumn = "HIDEONPOSCHECKOUT_CUSTOM";
        private const string TenderTypeIdColumn = "TENDERTYPEID";

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPaymentMethodsCustomResponse"/> class.
        /// </summary>
        public GetPaymentMethodsCustomResponse()
                : base("GetPaymentMethodsCustomResponse")
        {
        }

        /// <summary>Gets or sets the Hide On Pos Checkout Custom Column identifier.</summary>
        [DataMember]
        [Column(HideOnPosCheckoutCustomColumn)]
        public string HideOnPosCheckoutCustom
        {
            get { return Convert.ToString(this[HideOnPosCheckoutCustomColumn]); }
            set { this[HideOnPosCheckoutCustomColumn] = value; }
        }

        /// <summary>Gets or sets the Tender Type ID identifier.</summary>
        [DataMember]
        [Column(TenderTypeIdColumn)]
        public string TenderTypeId
        {
            get { return Convert.ToString(this[TenderTypeIdColumn]); }
            set { this[TenderTypeIdColumn] = value; }
        }
    }
}
