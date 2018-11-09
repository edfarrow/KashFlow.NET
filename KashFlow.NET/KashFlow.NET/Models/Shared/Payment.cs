using KashFlow.NET.Interfaces.Models.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow.NET.Models.Shared
{
	/// <summary>
	/// Represents a payment
	/// </summary>
	public class Payment : KashFlowBase<KashFlow.Payment>, IToData<KashFlow.Payment>
	{
		/// <summary>
		/// System-wide unique number for this payment
		/// </summary>
		public int PaymentID { get; private set; }

		/// <summary>
		/// Invoice number
		/// </summary>
		public int InvoiceID { get; set; }

		/// <summary>
		/// Date of payment
		/// </summary>
		public DateTime Date { get; set; }

		/// <summary>
		/// Comments about this payment
		/// </summary>
		public string Note { get; set; }

		/// <summary>
		/// Method of payment from GetInvPayMethods for invoices or GetRecPayMethods for Receipts
		/// </summary>
		public int PaymentMethodID { get; set; }

		/// <summary>
		/// The Bank Account to which the payment is assgined (from GetBankAccounts)
		/// </summary>
		public int AccountID { get; set; }

		/// <summary>
		/// The amount paid
		/// </summary>
		public decimal Amount { get; set; }

		public Payment() { }

		public Payment(KashFlow.Payment payment) : base(payment)
		{
			PaymentID = payment.PayID;
			InvoiceID = payment.PayInvoice;
			Date = payment.PayDate;
			Note = payment.PayNote;
			PaymentMethodID = payment.PayMethod;
			AccountID = payment.PayAccount;
			Amount = payment.PayAmount;
		}

		public KashFlow.Payment ToData()
		{
			return new KashFlow.Payment() 
			{
				PayID = PaymentID,
				PayInvoice = InvoiceID,
				PayDate = Date,
				PayNote = Note,
				PayMethod = PaymentMethodID,
				PayAccount = AccountID,
				PayAmount = Amount
			};
		}
	}
}
