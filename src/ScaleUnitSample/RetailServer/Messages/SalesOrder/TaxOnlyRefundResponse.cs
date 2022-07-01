namespace MSE.D365.Library.OnlineRefunds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <summary>
    /// Tax only refund response.
    /// </summary>
    public class TaxOnlyRefundResponse : Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxOnlyRefundResponse"/> class.
        /// </summary>
        /// <param name="taxRefundSalesOrderId">The id of sales order to return tax.</param>
        public TaxOnlyRefundResponse(string taxRefundSalesOrderId)
        {
            this.TaxRefundSalesOrderId = taxRefundSalesOrderId;
        }

        /// <summary>
        /// Gets or Sets the sales order id to be returned.
        /// </summary>
        public string TaxRefundSalesOrderId { get; set; }
    }
}
