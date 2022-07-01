namespace MSE.D365.Library.HealthCheck
{
    /// <summary>
    /// IP info for a specific terminal or hardware station.
    /// </summary>
    public class HardwarePeripheralIP
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HardwarePeripheralIP"/> class.
        /// </summary>
        /// <param name="name">Device terminal ID (10921005) or hardware station name.</param>
        /// <param name="isTerminal">True if it's a terminal, false if hardware station.</param>
        /// <param name="cashDrawerIP">Cash drawer IP address.</param>
        /// <param name="cashDrawerPort">Cash drawer port</param>
        /// <param name="printerIP">Printer IP address.</param>
        /// <param name="printerPort">Printer port.</param>
        /// <param name="paymentTerminalIP">Payment terminal IP address.</param>
        /// <param name="paymentTerminalPort">Payment terminal port.</param>
        /// <returns>HardwareStationIP.</returns>
        public HardwarePeripheralIP(string name, bool isTerminal, string cashDrawerIP, int? cashDrawerPort, string printerIP, int? printerPort, string paymentTerminalIP, int? paymentTerminalPort)
        {
            this.Name = name;
            this.IsTerminal = true;
            this.CashDrawerIP = cashDrawerIP;
            this.CashDrawerPort = cashDrawerPort;
            this.PrinterIP = printerIP;
            this.PrinterPort = printerPort;
            this.PaymentTerminalIP = paymentTerminalIP;
            this.PaymentTerminalPort = paymentTerminalPort;
        }

        /// <summary>
        /// Gets or sets the name to display in the UI, either device ID or hardware station ID.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether it's a terminal. True if it's a terminal, false if hardware station.
        /// </summary>
        public bool IsTerminal { get; set; }

        /// <summary>
        /// Gets or sets IP address of the cash drawer.
        /// </summary>
        public string CashDrawerIP { get; set; }

        /// <summary>
        /// Gets or sets port of the cash drawer.
        /// </summary>
        public int? CashDrawerPort { get; set; }

        /// <summary>
        /// Gets or sets IP address of the printer.
        /// </summary>
        public string PrinterIP { get; set; }

        /// <summary>
        /// Gets or sets port of the printer.
        /// </summary>
        public int? PrinterPort { get; set; }

        /// <summary>
        /// Gets or sets IP address of payment terminal.
        /// </summary>
        public string PaymentTerminalIP { get; set; }

        /// <summary>
        /// Gets or sets port of payment terminal.
        /// </summary>
        public int? PaymentTerminalPort { get; set; }
    }
}
