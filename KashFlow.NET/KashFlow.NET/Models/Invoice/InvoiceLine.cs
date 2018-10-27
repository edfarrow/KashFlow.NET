using KashFlow.NET.Interfaces.Models.Shared;
using KashFlow.NET.Models.Shared;

namespace KashFlow.NET.Models.Invoice
{
	/// <summary>
	/// Represents an invoice line
	/// </summary>
	public class InvoiceLine : KashFlowBase<KashFlow.InvoiceLine>, IToData<KashFlow.InvoiceLine>
	{
		/// <summary>
		/// The system-wide, unique ID number for the nominal code (immutable)
		/// </summary>
		public int LineID { get; private set; }

		/// <summary>
		/// The number representing how many of the item has been issued
		/// </summary>
		public decimal Quantity { get; set; }

		/// <summary>
		/// A string of free text for the line item
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// The net value of a single item (ie the value of Quantity 1)
		/// </summary>
		public decimal Rate { get; set; }

		/// <summary>
		/// The ID of the nominal code assigned to the line item
		/// </summary>
		public int ChargeType { get; set; }

		/// <summary>
		/// If a Project is associated with the line item then the Project ID, else 0
		/// </summary>
		public int? ProjectID { get; set; }

		/// <summary>
		/// The gross VAT amount for the line item
		/// </summary>
		public decimal VATAmount { get; set; }

		/// <summary>
		/// The VAT rate for the line item. Null for "N/A"
		/// </summary>
		public decimal? VATRate { get; set; }

		/// <summary>
		/// The index of the line item for the document, starting from 1
		/// </summary>
		public int Sort { get; set; }

		/// <summary>
		/// If a Product of the ChargeType is declared then the Product ID
		/// </summary>
		public int? ProductID { get; set; }

		/// <summary>
		/// Valid for insert only. If the document is in a foreign currency and you are passing the Rate and VatAmount values in that currency then true.
		/// </summary>
		public bool IsRateAndVatInForeignCurrency { get; set; }

		public InvoiceLine() : base() { }

		public InvoiceLine(KashFlow.InvoiceLine invoiceLine) : base(invoiceLine)
		{
			LineID = invoiceLine.LineID;
			Quantity = invoiceLine.Quantity;
			Description = invoiceLine.Description;
			Rate = invoiceLine.Rate;
			ChargeType = invoiceLine.ChargeType;
			ProjectID = invoiceLine.ProjID > 0 ? (int?)invoiceLine.ProjID : null;
			VATAmount = invoiceLine.VatAmount;
			VATRate = invoiceLine.VatRate;
			Sort = invoiceLine.Sort;
			ProductID = invoiceLine.ProductID > 0 ? (int?)invoiceLine.ProductID : null;
			IsRateAndVatInForeignCurrency = invoiceLine.ValuesInCurrency == "1";
		}

		public KashFlow.InvoiceLine ToData()
		{
			return new KashFlow.InvoiceLine()
			{
				LineID = LineID,
				Quantity = Quantity,
				Description = Description,
				Rate = Rate,
				ChargeType = ChargeType,
				ProjID = ProjectID ?? 0,
				VatAmount = VATAmount,
				VatRate = VATRate ?? -1,
				Sort = Sort,
				ProductID = ProductID ?? 0,
				ValuesInCurrency = IsRateAndVatInForeignCurrency ? "1" : "0"
			};
		}
	}
}