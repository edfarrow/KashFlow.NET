using KashFlow_NET.Interfaces.Models.Shared;
using KashFlow_NET.Models.Shared;

namespace KashFlow_NET.Models.Report
{
	/// <summary>
	/// Represents an Aged Debtors or Aged Creditors report
	/// </summary>
	public class AgedDebtorsCreditorsReport : KashFlowBase<KashFlow.AgedDebtorsCreditors>
	{
		/// <summary>
		/// The sum of (Older + Period3_val + Period2_val + Period1_val + Current) for the Customer / Supplier
		/// </summary>
		public decimal Balance { get; private set; }

		/// <summary>
		/// The Customer / Supplier code
		/// </summary>
		public string Code { get; private set; }

		/// <summary>
		/// The value of Debits – Credits within the month specified in the End Date of the report, for the Customer / Supplier
		/// </summary>
		public decimal Current { get; private set; }

		/// <summary>
		/// The Customer / Supplier system-wide unique ID
		/// </summary>
		public int ID { get; private set; }

		/// <summary>
		/// The Customer / Supplier name
		/// </summary>
		public string Name { get; private set; }

		/// <summary>
		/// The value of Debits – Credits older than ‘Period3’ for the Customer / Supplier
		/// </summary>
		public decimal Older { get; private set; }

		/// <summary>
		/// The month before that of the specified End Date (‘Current’ month)
		/// </summary>
		public AgedDebtorsCreditorsPeriod Period1 { get; private set; }

		/// <summary>
		/// The month previous to ‘Period1’
		/// </summary>
		public AgedDebtorsCreditorsPeriod Period2 { get; private set; }

		/// <summary>
		/// The month previous to ‘Period2’
		/// </summary>
		public AgedDebtorsCreditorsPeriod Period3 { get; private set; }

		public AgedDebtorsCreditorsReport() : base()
		{
		}

		public AgedDebtorsCreditorsReport(KashFlow.AgedDebtorsCreditors agedDebtorsCreditors) : base(agedDebtorsCreditors)
		{
			ID = agedDebtorsCreditors.id;
			Name = agedDebtorsCreditors.Name;
			Code = agedDebtorsCreditors.Code;
			Balance = agedDebtorsCreditors.Balance;
			Current = agedDebtorsCreditors.Current;
			Older = agedDebtorsCreditors.Older;
			Period1 = new AgedDebtorsCreditorsPeriod(agedDebtorsCreditors.Period1_name, agedDebtorsCreditors.Period1_val);
			Period2 = new AgedDebtorsCreditorsPeriod(agedDebtorsCreditors.Period2_name, agedDebtorsCreditors.Period2_val);
			Period3 = new AgedDebtorsCreditorsPeriod(agedDebtorsCreditors.Period3_name, agedDebtorsCreditors.Period3_val);
		}
	}
}