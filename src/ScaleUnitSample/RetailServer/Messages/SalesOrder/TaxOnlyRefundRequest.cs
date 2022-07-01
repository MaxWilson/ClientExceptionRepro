namespace MSE.D365.Library.OnlineRefunds
{
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <summary>
    /// Online tax only refund request.
    /// </summary>
    public class TaxOnlyRefundRequest : Request
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TaxOnlyRefundRequest"/> class.
        /// </summary>
        /// <param name="salesOrderId">sales order id.s</param>
        public TaxOnlyRefundRequest(string salesOrderId)
        {
            this.SalesOrderId = salesOrderId;
        }

        /// <summary>
        /// Gets the sales order id to refund.
        /// </summary>
        public string SalesOrderId { get; private set; }
    }
}
