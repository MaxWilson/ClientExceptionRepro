using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSE.D365.Library.CartExport
{
    public class AbandonedCartResult
    {
        /// <summary>
        /// Gets or sets a value indicating the Cart Id.
        /// </summary>
        public string CartId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the LastModifiedTimeFrom.
        /// </summary>
        public DateTimeOffset? LastModifiedTimeFrom { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the Data Area Id.
        /// </summary>
        public string DataAreaId { get; set; }
    }
}
