using KashFlow_NET.Models.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow_NET.Models.Report
{
	/// <summary>
	/// Represents a monthly profit and loss report
	/// </summary>
	public class ProfitLossMonthly : KashFlowBase<KashFlow.MonthlyPL>
	{
		/// <summary>
		/// The start date for this period
		/// </summary>
		public DateTime Start { get; private set; }

		/// <summary>
		/// The end date for this period
		/// </summary>
		public DateTime End { get; private set; }

		/// <summary>
		/// The Turnover figure for this period
		/// </summary>
		public decimal Turnover { get; private set; }

		/// <summary>
		/// The Gross profit for this period
		/// </summary>
		public decimal GrossProfit { get; private set; }

		/// <summary>
		/// The Net Profit for this period
		/// </summary>
		public decimal NetProfit { get; private set; }

		public ProfitLossMonthly(): base() { }

		public ProfitLossMonthly(KashFlow.MonthlyPL monthlyPL) : base(monthlyPL)
		{
			Start = monthlyPL.PeriodStart;
			End = monthlyPL.PeriodEnd;
			Turnover = monthlyPL.Turnover;
			GrossProfit = monthlyPL.GrossProfit;
			NetProfit = monthlyPL.NetProfit;
		}
	}
}
