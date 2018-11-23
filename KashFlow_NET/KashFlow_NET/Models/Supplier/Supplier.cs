using KashFlow_NET.Interfaces.Models.Shared;
using KashFlow_NET.Models.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow_NET.Models.Supplier
{
	/// <summary>
	/// Represents a supplier
	/// </summary>
	public class Supplier : KashFlowBase<KashFlow.Supplier>, IToData<KashFlow.Supplier>
	{
		/// <summary>
		/// The system-wide, unique ID number for this supplier
		/// </summary>
		public int SupplierID { get; private set; }

		public string Code { get; set; }

		public string Name { get; set; }

		public string Contact { get; set; }

		public string Telephone { get; set; }

		public string Mobile { get; set; }

		public string Fax { get; set; }

		public string Email { get; set; }

		public string Address1 { get; set; }

		public string Address2 { get; set; }

		public string Address3 { get; set; }

		public string Address4 { get; set; }

		public string Postcode { get; set; }

		public string Website { get; set; }

		/// <summary>
		/// Is true if the supplier is based in another EC country
		/// </summary>
		public bool IsInEuropeanCommunity { get; set; }

		/// <summary>
		/// The suppliers VAT number
		/// </summary>
		public string VATNumber { get; set; }

		public string Notes { get; set; }

		/// <summary>
		/// The date this supplier record was created
		/// </summary>
		public DateTime Created { get; set; }

		/// <summary>
		/// The date the supplier record was last updated.
		/// </summary>
		public DateTime Updated { get; set; }

		/// <summary>
		/// The default currency id
		/// </summary>
		public int CurrencyID { get; set; }

		/// <summary>
		/// The payment terms for the supplier
		/// </summary>
		public int PaymentTermsID { get; set; }

		public string ContactTitle { get; set; }

		public string ContactFirstName { get; set; }

		public string ContactLastName { get; set; }

		public Supplier() { }

		public Supplier(KashFlow.Supplier supplier)
		{
			SupplierID = supplier.SupplierID;
			Code = supplier.Code;
			Name = supplier.Name;
			Contact = supplier.Contact;
			ContactTitle = supplier.ContactTitle;
			ContactFirstName = supplier.ContactFirstName;
			ContactLastName = supplier.ContactLastName;
			Telephone = supplier.Telephone;
			Mobile = supplier.Mobile;
			Fax = supplier.Fax;
			Email = supplier.Email;
			Address1 = supplier.Address1;
			Address2 = supplier.Address2;
			Address3 = supplier.Address3;
			Address4 = supplier.Address4;
			Postcode = supplier.PostCode;
			Website = supplier.Website;
			IsInEuropeanCommunity = supplier.EC == 1;
			VATNumber = supplier.VATNumber;
			Notes = supplier.Notes;
			Created = supplier.Created;
			Updated = supplier.Updated;
			CurrencyID = supplier.CurrencyID;
			PaymentTermsID = supplier.PaymentTerms;
		}

		public KashFlow.Supplier ToData()
		{
			return new KashFlow.Supplier() 
			{
				SupplierID = SupplierID,
				Code = Code,
				Name = Name,
				Contact = Contact,
				ContactTitle = ContactTitle,
				ContactFirstName = ContactFirstName,
				ContactLastName = ContactLastName,
				Telephone = Telephone,
				Mobile = Mobile,
				Fax = Fax,
				Email = Email,
				Address1 = Address1,
				Address2 = Address2,
				Address3 = Address3,
				Address4 = Address4,
				PostCode = Postcode,
				Website = Website,
				EC = IsInEuropeanCommunity ? 1 : 0,
				VATNumber = VATNumber,
				Notes = Notes,
				Created = Created,
				Updated = Updated,
				CurrencyID = CurrencyID,
				PaymentTerms = PaymentTermsID
			};
		}
	}
}
