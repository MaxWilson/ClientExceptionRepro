using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSE.D365.Library.StoreOpenClose
{
    public class ExpectedCashTotalBalance
    {
        public int ToleranceInCents { get; set; }

        public decimal ExpectedAmount { get; set; }
    }
}
