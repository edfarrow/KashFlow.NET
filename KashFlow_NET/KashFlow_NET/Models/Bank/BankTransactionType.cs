using KashFlow_NET.Models.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow_NET.Models.Bank
{
	/// <summary>
	/// Used to represent a Nominal Code of type <see cref="BankTransaction">Bank Transaction</see>	
	/// </summary>
	public class BankTransactionType : KashFlowBase<KashFlow.BankTXType>
	{
		/// <summary>
		/// The system-wide, unique ID number for the Nominal Code (immutable)
		/// </summary>
		public int TypeID { get; private set; }

		/// <summary>
		/// The Nominal Code name
		/// </summary>
		public string TypeName { get; set; }

		/// <summary>
		/// The Nominal Code name
		/// </summary>
		public int TypeCode { get; set; }

		public BankTransactionType() : base() { }

		public BankTransactionType(KashFlow.BankTXType bankTXType) : base(bankTXType)
		{
			TypeID = bankTXType.TypeID;
			TypeName = bankTXType.TypeName;
			TypeCode = bankTXType.TypeCode;
		}
	}
}
