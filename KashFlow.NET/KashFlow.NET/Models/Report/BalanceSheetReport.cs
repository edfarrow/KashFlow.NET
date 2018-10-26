using KashFlow.NET.Models.Shared;

namespace KashFlow.NET.Models.Report
{
	/// <summary>
	/// The Balance Sheet is made of Fixed Assets, Current Assets, Current Liabilities and Capital & Reserves
	/// </summary>
	public class BalanceSheetReport : KashFlowBase<KashFlow.BalanceSheet>
	{
		/// <summary>
		/// The end date to run the Balance Sheet up to
		/// </summary>
		public System.DateTime Date { get; set; }

		/// <summary>
		/// An array of type <see cref="NominalCode"/> containing all Nominal Codes with values contributing to the FixedAssetsTotal for the defined period
		/// </summary>
		public NominalCode[] FixedAssets { get; set; }

		/// <summary>
		/// Sum of the balances for the Nominal Codes in FixedAssets
		/// </summary>
		public decimal FixedAssetsTotal { get; set; }

		/// <summary>
		/// An array of type <see cref="NominalCode"/> containing all Nominal Codes with values contributing to the CurrentAssetsTotal for the defined period
		/// </summary>
		public NominalCode[] CurrentAssets { get; set; }

		/// <summary>
		/// Sum of the balances for the Nominal Codes in CurrentAssets
		/// </summary>
		public decimal CurrentAssetsTotal { get; set; }
		
		public NominalCode[] CurrentLiabilities { get; set; }

		public decimal CurrentLiabilitiesTotal { get; set; }
		
		public NominalCode[] CapitalReserves { get; set; }
		
		public decimal CapitalReservesTotal { get; set; }

		public BalanceSheetReport(): base() { }

	}
}
