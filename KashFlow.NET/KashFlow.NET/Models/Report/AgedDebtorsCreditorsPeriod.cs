namespace KashFlow.NET.Models.Report
{
	/// <summary>
	/// Represents a period for the <see cref="AgedDebtorsCreditorsReport"/> report
	/// </summary>
	public class AgedDebtorsCreditorsPeriod
	{
		/// <summary>
		/// The name of the month
		/// </summary>
		public string Name { get; private set; }

		/// <summary>
		/// The value of Debits – Credits for the Customer / Supplier  within the month 
		/// </summary>
		public decimal Value { get; private set; }

		public AgedDebtorsCreditorsPeriod()
		{
		}

		public AgedDebtorsCreditorsPeriod(string name, decimal value)
		{
			Name = name;
			Value = value;
		}
	}
}