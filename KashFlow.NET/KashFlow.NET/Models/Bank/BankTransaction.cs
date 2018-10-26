using KashFlow.NET.Models.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow.NET.Models.Bank
{
	/// <summary>
	/// Used to represent stand-alone Bank Transactions– this does not include Payments.
	/// </summary>
	public class BankTransaction : KashFlowBase<KashFlow.BankTransaction>
	{
		/// <summary>
		/// The system-wide, unique ID number for the Transaction (immutable)
		/// </summary>
		public int ID { get; private set; }

		/// <summary>
		/// Accid: The parent Bank Account Nominal Code code
		/// </summary>
		/// <
		public int BankAccountNominalCode { get; set; }

		/// <summary>
		/// The date of this Transaction
		/// </summary>
		public DateTime TransactionDate { get; set; }

		/// <summary>
		/// If a money in Transaction, the value of the Transaction
		/// </summary>
		public decimal MoneyIn { get; set; }

		/// <summary>
		/// If a money out Transaction, the value of the Transaction
		/// </summary>
		public decimal MoneyOut { get; set; }

		/// <summary>
		/// True if the transaction will be considered in VAT Reporting
		/// </summary>
		public bool IsVatable { get; set; }

		/// <summary>
		/// The VAT rate for the Transaction
		/// </summary>
		public decimal VatRate { get; set; }

		/// <summary>
		/// The VAT amount for the Transaction
		/// </summary>
		public decimal VatAmount { get; set; }

		/// <summary>
		/// The Nominal Code code the Transaction is raised against
		/// </summary>
		public decimal TransactionType { get; set; }

		/// <summary>
		/// The comment on the Transaction
		/// </summary>
		public string Comment { get; set; }

		/// <summary>
		/// If a Project is associated with the Transaction then the ProjectID, else 0
		/// </summary>
		public decimal ProjectID { get; set; }

		/// <summary>
		/// If the Transaction TransactionType is the Nominal Code code for the Debtors Control Account then the CustomerID for the associated Customer, else 0
		/// </summary>
		public decimal CustomerID { get; set; }

		/// <summary>
		/// If the Transaction TransactionType is the Nominal Code code for the Creditors Control Account then the SupplierID for the associated Supplier, else 0
		/// </summary>
		public decimal SupplierID { get; set; }

		public BankTransaction() : base() { }

		public BankTransaction(KashFlow.BankTransaction transaction) : base(transaction)
		{
			ID = transaction.ID;
			BankAccountNominalCode = transaction.accid;
			TransactionDate = transaction.TransactionDate;
			MoneyIn = transaction.moneyin;
			MoneyOut = transaction.moneyout;
			IsVatable = transaction.Vatable == 1 ? true : false;
			VatRate = transaction.VatRate;
			VatAmount = transaction.VatAmount;
			TransactionType = transaction.TransactionType;
			Comment = transaction.Comment;
			ProjectID = transaction.ProjectID;
			CustomerID = transaction.CustomerId;
			SupplierID = transaction.SupplierId;
		}
	}
}
