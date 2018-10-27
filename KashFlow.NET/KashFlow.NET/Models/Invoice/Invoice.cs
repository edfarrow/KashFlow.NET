using KashFlow.NET.Interfaces.Models.Shared;
using KashFlow.NET.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KashFlow.NET.Models.Invoice
{
	/// <summary>
	/// For representing Invoices, Receipts (Purchases) and Quotes.
	/// </summary>
	public class Invoice : KashFlowBase<KashFlow.Invoice>, IToData<KashFlow.Invoice>
	{
		/// <summary>
		/// The system-wide, unique ID number for this document (immutable)
		/// </summary>
		public int InvoiceID { get; private set; }

		/// <summary>
		/// The document number, must be unique for the KashFlow account for this document-type
		/// </summary>
		public int Number { get; set; }

		/// <summary>
		/// The issue date for the document 
		/// </summary>
		public DateTime IssueDate { get; set; }

		/// <summary>
		/// The due date for the document
		/// </summary>
		public DateTime DueDate { get; set; }

		/// <summary>
		/// If the document is a Quote and the total is to be hidden
		/// </summary>
		public bool IsTotalSuppressed { get; set; }

		/// <summary>
		/// The project ID if a project is associated, else null
		/// </summary>
		public int? ProjectID { get; set; }

		/// <summary>
		/// The currency code in the ISO 4217 standard
		/// </summary>
		public string CurrencyCode { get; set; }

		/// <summary>
		/// The exchange rate for the defined currency
		/// </summary>
		public decimal ExchangeRate { get; set; }

		/// <summary>
		/// If the document is an Invoice or Receipt and is completely paid
		/// </summary>
		public bool IsPaid { get; set; }

		/// <summary>
		/// If an Invoice or Quote then the CustomerID, else the SupplierID
		/// </summary>
		public int CustomerOrSupplierID { get; set; }

		/// <summary>
		/// A string of free-text
		/// </summary>
		public string Reference { get; set; }

		/// <summary>
		/// If a Quote then it’s category (read-only)
		/// </summary>
		public string EstimateCategory { get; private set; }

		/// <summary>
		/// The sum of the net value for all documents lines (read-only)
		/// </summary>
		public decimal NetAmount { get; private set; }

		/// <summary>
		/// The sum of the VAT value for all documents lines (read-only)
		/// </summary>
		public decimal VATAmount { get; private set; }

		/// <summary>
		/// If the document is an Invoice or Purchase then the sum of all the payments made to it (read-only)
		/// </summary>
		public decimal PaidAmount { get; private set; }

		/// <summary>
		/// A permanent link to access a PDF of the document (read-only)
		/// </summary>
		public string Url { get; private set; }

		/// <summary>
		/// If the document is a Quote or Invoice and a Delivery Address is defined to be used then true, else false
		/// </summary>
		public bool IsUsingCustomDeliveryAddress { get; set; }

		/// <summary>
		/// The invoice delivery address <see cref="DeliveryAddress"/>
		/// </summary>
		public DeliveryAddress DeliveryAddress { get; set; }

		/// <summary>
		/// Invoice Lines <see cref="InvoiceLine"/>
		/// </summary>
		public List<InvoiceLine> Lines { get; set; }


		public Invoice() : base() { }

		public Invoice(KashFlow.Invoice invoice) : base(invoice)
		{
			Lines = invoice.Lines.Select(x => new InvoiceLine((KashFlow.InvoiceLine)x)).ToList();
			DeliveryAddress = new DeliveryAddress(invoice.DeliveryAddress);
			InvoiceID = invoice.InvoiceDBID;
			Number = invoice.InvoiceNumber;
			IssueDate = invoice.InvoiceDate;
			DueDate = invoice.DueDate;
			IsTotalSuppressed = invoice.SuppressTotal == 1;
			ProjectID = invoice.ProjectID > 0 ? (int?)invoice.ProjectID : null;
			CurrencyCode = invoice.CurrencyCode;
			ExchangeRate = invoice.ExchangeRate;
			IsPaid = invoice.Paid == 1;
			CustomerOrSupplierID = invoice.CustomerID;
			Reference = invoice.CustomerReference;
			EstimateCategory = invoice.EstimateCategory;
			NetAmount = invoice.NetAmount;
			VATAmount = invoice.VATAmount;
			PaidAmount = invoice.AmountPaid;
			Url = invoice.PermaLink;
			IsUsingCustomDeliveryAddress = invoice.UseCustomDeliveryAddress;
		}

		public KashFlow.Invoice ToData()
		{
			return new KashFlow.Invoice()
			{
				Lines = Lines.Select(x => x.ToData()).ToArray(),
				DeliveryAddress = DeliveryAddress.ToData(),
				InvoiceDBID = InvoiceID,
				InvoiceNumber = Number,
				InvoiceDate = IssueDate,
				DueDate = DueDate,
				SuppressTotal = IsTotalSuppressed ? 1 : 0,
				ProjectID = ProjectID ?? 0,
				CurrencyCode = CurrencyCode,
				ExchangeRate = ExchangeRate,
				Paid = IsPaid ? 1 : 0,
				CustomerID = CustomerOrSupplierID,
				CustomerReference = Reference,
				EstimateCategory = EstimateCategory,
				NetAmount = NetAmount,
				VATAmount = VATAmount,
				AmountPaid = PaidAmount,
				PermaLink = Url,
				UseCustomDeliveryAddress = IsUsingCustomDeliveryAddress
			};
		}
	}
}