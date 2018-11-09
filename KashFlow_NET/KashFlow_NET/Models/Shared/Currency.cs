namespace KashFlow_NET.Models.Shared
{
	/// <summary>
	/// Represents a currency
	/// </summary>
	public class Currency : KashFlowBase<KashFlow.Currencies>
	{
		/// <summary>
		/// The system-wide, unique ID number for the currency code (immutable)
		/// </summary>
		public int CurrencyID { get; private set; }

		/// <summary>
		/// The currency code in the ISO 4217 standard
		/// </summary>
		public string CurrencyCode { get; set; }

		/// <summary>
		/// The exchange rate
		/// </summary>
		public decimal ExchangeRate { get; set; }

		public Currency() { }

		public Currency(KashFlow.Currencies currencies)
		{
			CurrencyID = currencies.CurrencyId;
			CurrencyCode = currencies.CurrencyCode;
			ExchangeRate = currencies.ExchangeRate;
		}
	}
}
