using KashFlow.NET.Interfaces.Models.Shared;
using KashFlow.NET.Models.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow.NET.Models.Account
{
	/// <summary>
	/// Used to illustrate an overview of the accounts as returned by GetAccountOverview
	/// </summary>
	public class AccountOverview : KashFlowBase<KashFlow.AccountOverview>, IToData<KashFlow.AccountOverview>
	{
		/// <summary>
		/// Total outstanding amount (Total – Amount Paid) for all Invoices
		/// </summary>
		public decimal TotalDue { get; set; }

		/// <summary>
		/// Total outstanding amount (Total – Amount Paid) for all Purchases (receipts)
		/// </summary>
		public decimal TotalOwed { get; set; }

		/// <summary>
		/// Total outstanding amount (Total – Amount Paid) for all Overdue Purchases (receipts)
		/// </summary>
		public decimal ReceiptsOverdue { get; set; }

		/// <summary>
		/// Total outstanding amount (Total – Amount Paid) for all Overdue Invoices
		/// </summary>
		public decimal SalesOverdue { get; set; }

		/// <summary>
		/// Total outstanding amount (Total – Amount Paid) for all Overdue Invoices
		/// </summary>
		public decimal ReceiptPartPayments { get; set; }

		/// <summary>
		/// Total for all Part Payments assigned to Overdue Purchases (receipts)
		/// </summary>
		public decimal ReceiptPartPaymentsOverdue { get; set; }

		/// <summary>
		/// Total for all Part Payments assigned to all Invoices
		/// </summary>
		public decimal InvoicePartPayments { get; set; }

		/// <summary>
		/// Total for all Part Payments assigned to all Invoices
		/// </summary>
		public decimal InvoicePartPaymentsOverdue { get; set; }

		/// <summary>
		/// Creates a new instance of the AccountOverview Class
		/// </summary>
		public AccountOverview() : base() { }

		/// <summary>
		/// Creates a new instance of the AccountOverview Class
		/// </summary>
		/// <param name="accountOverview">A <see cref="KashFlow.AccountOverview">KashFlow.AccountOverview</see> class</param>
		/// <seealso cref="https://www.kashflow.com/developers/soap-api/accountoverview/"/>
		public AccountOverview(KashFlow.AccountOverview accountOverview) : base(accountOverview)
		{
			TotalDue = accountOverview.TotalDue;
			TotalOwed = accountOverview.TotalOwed;
			ReceiptsOverdue = accountOverview.ReceiptsOverdue;
			SalesOverdue = accountOverview.SalesOverdue;
			ReceiptPartPayments = accountOverview.ReceiptPartPayments;
			ReceiptPartPaymentsOverdue = accountOverview.ReceiptPartPaymentsOverdue;
			InvoicePartPayments = accountOverview.InvoicePartPayments;
			InvoicePartPaymentsOverdue = accountOverview.InvoicePartPaymentsOverdue;
		}

		/// <summary>
		/// Transforms to a concrete <see cref="KashFlow.AccountOverview">AccountOverview</see>
		/// </summary>
		/// <returns><see cref="KashFlow.AccountOverview"/></returns>
		public KashFlow.AccountOverview ToData()
		{
			return new KashFlow.AccountOverview()
			{
				TotalDue = this.TotalDue,
				TotalOwed = this.TotalOwed,
				ReceiptPartPayments = this.ReceiptPartPayments,
				InvoicePartPayments = this.InvoicePartPayments,
				InvoicePartPaymentsOverdue = this.InvoicePartPaymentsOverdue,
				ReceiptPartPaymentsOverdue = this.ReceiptPartPaymentsOverdue,
				ReceiptsOverdue = this.ReceiptsOverdue,
				SalesOverdue = this.SalesOverdue
			};
		}
	}
}
