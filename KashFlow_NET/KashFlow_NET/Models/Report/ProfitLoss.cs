using KashFlow_NET.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KashFlow_NET.Models.Report
{
	public class ProfitLoss : KashFlowBase<KashFlow.ProfitAndLoss>
	{
		/// <summary>
		/// The total turnover for this period
		/// </summary>
		public decimal TurnoverTotal { get; set; }

		/// <summary>
		/// The total cost of sales for this period
		/// </summary>
		public decimal CostOfSalesTotal { get; set; }

		/// <summary>
		/// The total expenses for this period
		/// </summary>
		public decimal ExpensesTotal { get; set; }

		/// <summary>
		/// The net profit for this period
		/// </summary>
		public decimal ProfitNet { get; set; }

		/// <summary>
		/// The gross profit for this period
		/// </summary>
		public decimal ProfitGross { get; set; }

		/// <summary>
		/// Each code that makes up the TurnoverTotal figure
		/// </summary>
		public List<NominalCode> Turnover { get; set; }

		/// <summary>
		/// Each code that makes up the CostofSalesTotal figure
		/// </summary>
		public List<NominalCode> CostOfSales { get; set; }

		/// <summary>
		/// Each code that makes up the ExpensesTotal figure
		/// </summary>
		public List<NominalCode> Expenses { get; set; }

		
		public ProfitLoss() { }

		public ProfitLoss(KashFlow.ProfitAndLoss profitAndLoss)
		{
			TurnoverTotal = profitAndLoss.TurnoverTotal;
			CostOfSalesTotal = profitAndLoss.CostOfSalesTotal;
			ExpensesTotal = profitAndLoss.ExpensesTotal;
			ProfitNet = profitAndLoss.NetProfit;
			ProfitGross = profitAndLoss.GrossProfit;
			Turnover = profitAndLoss.Turnover.Select(x => new NominalCode((KashFlow.NominalCode)x)).ToList();
			CostOfSales = profitAndLoss.CostOfSales.Select(x => new NominalCode((KashFlow.NominalCode)x)).ToList();
			Expenses = profitAndLoss.Expenses.Select(x => new NominalCode((KashFlow.NominalCode)x)).ToList();
		}
	}
}
