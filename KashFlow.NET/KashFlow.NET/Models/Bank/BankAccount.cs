using KashFlow.NET.Models.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow.NET.Models.Bank
{
	/// <summary>
	/// Used to represent a Bank Account.
	/// </summary>
	public class BankAccount : KashFlowBase<KashFlow.BankAccount>
	{
		/// <summary>
		/// The system-wide, unique ID number for this Bank Account (immutable)
		/// </summary>
		public int AccountID { get; private set; }

		/// <summary>
		/// The Bank Account name
		/// </summary>
		public string AccountName { get; set; }

		/// <summary>
		/// The Bank Account Nominal Code code
		/// </summary>
		public int AccountCode { get; set; }

		public BankAccount() : base() { }

		public BankAccount(KashFlow.BankAccount account) : base(account)
		{
			this.AccountID = account.AccountID;
			this.AccountName = account.AccountName;
			this.AccountCode = account.AccountCode;
		}
	}
}
