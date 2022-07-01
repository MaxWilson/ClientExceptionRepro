// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CRMOrderConstant.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Microsoft.MSE.D365.Library.CRMOrder
{
    /// <summary>
    /// The CRM order constants class.
    /// </summary>
    public class CRMOrderConstant
    {
        /// <summary>
        /// The CRM logging area.
        /// </summary>
        public const string LOGGINGAREACRM = @"CRMORDER";

        /// <summary>
        /// The is CRM order constant.
        /// </summary>
        public const string ISCRMORDERRECALLED = @"ISCRMORDERRECALLED";

        /// <summary>
        /// The CRM order register attribute.
        /// </summary>
        public const string CRMORDERREGISTERATTRIBUTE = @"CRMORDERREGISTERATTRIBUTE";

        /// <summary>
        /// The CRM identifier terminal.
        /// </summary>
        public const string ISCRMTERMINAL = @"ISCRMTERMINAL";

        /// <summary>
        /// The CRM origin identifier constant.
        /// </summary>
        public const string ORIGINIDENTIFIER = "ORIGINIDENTIFIER";

        /// <summary>
        /// The CRM origin identifier constant.
        /// </summary>
        public const string ORIGINIDENTIFIERCRM = "ORIGINIDENTIFIER_CRM";

        /// <summary>
        /// The POS origin identifier constant.
        /// </summary>
        public const string ORIGINIDENTIFIERPOS = "ORIGINIDENTIFIER_POS";

        /// <summary>
        /// The Online origin identifier constant.
        /// </summary>
        public const string ORIGINIDENTIFIERONLINE = "ORIGINIDENTIFIER_ONLINE";

        /// <summary>
        /// The POS Customer Order origin identifier constant.
        /// </summary>
        public const string ORIGINIDENTIFIERPOSCO = "ORIGINIDENTIFIER_POS_CO";

        /// <summary>
        /// The CRM customer group constant.
        /// </summary>
        public const string CRMCUSTOMERGROUP = @"CRMCUSTOMERGROUP";

        /// <summary>
        /// The CRM ship from warehouse delivery mode.
        /// </summary>
        public const string CRMSHIPFROMWAREHOUSEDELIVERYMODE = @"CRMSHIPFROMWAREHOUSEDELIVERYMODE";

        /// <summary>
        /// The CRM ship from store original delivery mode.
        /// </summary>
        public const string OriginalDeliveryMode = @"OriginalDeliveryMode";

        /// <summary>
        /// The error code.
        /// </summary>
        public const string ERRORCODE = @"Microsoft_Dynamics_Commerce_30104";

        /// <summary>
        /// The erro rmessage.
        /// </summary>
        public const string ERRORMESSAGE = @"Custom error";

        /// <summary>
        /// The CRM property to ignore retail discounts.
        /// </summary>
        public const string CRMIGNORERETAILDISCOUNTS = @"CRMIGNORERETAILDISCOUNTS";

        /// <summary>
        /// The CRM retail discount code.
        /// </summary>
        public const string CRMRETAILDISCOUNTCODE = @"CRMRETAILDISCOUNTCODE";

        /// <summary>
        /// Xml namespace regular expression pattern for RTS response.
        /// </summary>
        public const string XMLNSREGEXEXP = @"(xmlns:?[^=]*=[""][^""]*[""])";

        /// <summary>
        /// Is request from CRM.
        /// </summary>
        public const string ISREQUESTFROMCRM = @"ISREQUESTFROMCRM";

        /// <summary>
        /// The transaction id column.
        /// </summary>
        public const string TransactionIdColumn = "TRANSACTIONID";

        /// <summary>
        /// The delivery mode column.
        /// </summary>
        public const string DeliveryModeColumn = "DELIVERYMODE";

        /// <summary>
        /// The customer order mode.
        /// </summary>
        public const string CustomerOrderModeColumn = "CUSTOMERORDERMODE";

        /// <summary>
        /// The customer order type.
        /// </summary>
        public const string CustomerOrderTypeColumn = "CUSTOMERORDERTYPE";
    }
}
