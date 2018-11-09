using KashFlow.NET.Interfaces.Models.Shared;
using KashFlow.NET.Models.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow.NET.Models.Bank
{
	/// <summary>
	/// Used to represent a Bank Account and include the balance.
	/// </summary>
	public class BankOverview : KashFlowBase<KashFlow.BankOverview>, IToData<KashFlow.BankOverview>
	{
		/// <summary>
		/// The system-wide, unique ID number for this Bank Account (immutable)
		/// </summary>
		public int AccountID { get; set; }

		/// <summary>
		/// The Bank Account name
		/// </summary>
		public string AccountName { get; set; }

		/// <summary>
		/// The sum of the “Start Balance” of the Bank Account and all of its Transactions dated on or before the present day
		/// </summary>
		public decimal Balance { get; set; }

		public BankOverview() : base() { }

		public BankOverview(KashFlow.BankOverview bankOverview) : base(bankOverview)
		{
			AccountID = bankOverview.AccountID;
			AccountName = bankOverview.AccountName;
			Balance = bankOverview.Balance;
		}

		/// <summary>
		/// Converts to base KashFlow type
		/// </summary>
		/// <returns><see cref="KashFlow.BankOverview"/></returns>
		public KashFlow.BankOverview ToData()
		{
			return new KashFlow.BankOverview()
			{
				AccountID = AccountID,
				Balance = Balance,
				AccountName = AccountName
			};
		}
	}
}
