using KashFlow.NET.Interfaces.Models.Shared;
using KashFlow.NET.Models.Shared;
using System;

namespace KashFlow.NET.Models.Customer
{
	/// <summary>
	/// Represents a Customer
	/// </summary>
	public class Customer : KashFlowBase<KashFlow.Customer>, IToData<KashFlow.Customer>
	{
		/// <summary>
		/// The customer billing address line 1
		/// </summary>
		public string Address1 { get; set; }

		/// <summary>
		/// The customer billing address line 2
		/// </summary>
		public string Address2 { get; set; }

		/// <summary>
		/// The customer billing address line 3
		/// </summary>
		public string Address3 { get; set; }

		/// <summary>
		/// The customer billing address line 4
		/// </summary>
		public string Address4 { get; set; }

		public bool CheckBox1 { get; set; }

		public bool CheckBox10 { get; set; }

		public bool CheckBox11 { get; set; }

		public bool CheckBox12 { get; set; }

		public bool CheckBox13 { get; set; }

		public bool CheckBox14 { get; set; }

		public bool CheckBox15 { get; set; }

		public bool CheckBox16 { get; set; }

		public bool CheckBox17 { get; set; }

		public bool CheckBox18 { get; set; }

		public bool CheckBox19 { get; set; }

		public bool CheckBox2 { get; set; }

		public bool CheckBox20 { get; set; }

		public bool CheckBox3 { get; set; }

		public bool CheckBox4 { get; set; }

		public bool CheckBox5 { get; set; }

		public bool CheckBox6 { get; set; }

		public bool CheckBox7 { get; set; }

		public bool CheckBox8 { get; set; }

		public bool CheckBox9 { get; set; }

		/// <summary>
		/// An alphanumeric ID for the customer, unique for the KashFlow account customers list
		/// </summary>
		public string Code { get; set; }

		/// <summary>
		/// The full contact name for the customer
		/// </summary>
		public string Contact { get; set; }

		/// <summary>
		/// The customer contacts title
		/// </summary>
		public string ContactFirstName { get; set; }

		/// <summary>
		/// The customer contacts last name
		/// </summary>
		public string ContactLastName { get; set; }

		/// <summary>
		/// The customer contacts title
		/// </summary>
		public string ContactTitle { get; set; }

		/// <summary>
		/// The customer billing address country code in the ISO 3166-1 alpha-2 standard (except for Greece which is recorded as ‘EL’)
		/// </summary>
		public string CountryCode { get; set; }

		/// <summary>
		/// The customer billing address country name
		/// </summary>
		public string CountryName { get; set; }

		/// <summary>
		/// The date this customer record was inserted (immutable)
		/// </summary>
		public DateTime Created { get; private set; }

		/// <summary>
		/// The ID for the customers default currency
		/// </summary>
		public int CurrencyID { get; set; }

		/// <summary>
		/// The system-wide, unique ID number for the customer (immutable)
		/// </summary>
		public int CustomerID { get; private set; }

		/// <summary>
		/// The customer delivery address line 1
		/// </summary>
		public string DeliveryAddress1 { get; set; }

		/// <summary>
		/// The customer delivery address line 2
		/// </summary>
		public string DeliveryAddress2 { get; set; }

		/// <summary>
		/// The customer delivery address line 3
		/// </summary>
		public string DeliveryAddress3 { get; set; }

		/// <summary>
		/// The customer delivery address line 4
		/// </summary>
		public string DeliveryAddress4 { get; set; }

		/// <summary>
		/// The customer delivery address country code in the ISO 3166-1 alpha-2 standard (except for Greece which is recorded as ‘EL’)
		/// </summary>
		public string DeliveryCountryCode { get; set; }

		/// <summary>
		/// The customer delivery address country name
		/// </summary>
		public string DeliveryCountryName { get; set; }

		/// <summary>
		/// The customer delivery address post code
		/// </summary>
		public string DeliveryPostcode { get; set; }

		/// <summary>
		/// The discount percentage for this customer
		/// </summary>
		public decimal Discount { get; set; }

		/// <summary>
		/// The customer email address(es)
		/// </summary>
		public string Email { get; set; }

		public string ExtraText1 { get; set; }

		public string ExtraText10 { get; set; }

		public string ExtraText11 { get; set; }

		public string ExtraText12 { get; set; }

		public string ExtraText13 { get; set; }

		public string ExtraText14 { get; set; }

		public string ExtraText15 { get; set; }

		public string ExtraText16 { get; set; }

		public string ExtraText17 { get; set; }

		public string ExtraText18 { get; set; }

		public string ExtraText19 { get; set; }

		public string ExtraText2 { get; set; }

		public string ExtraText20 { get; set; }

		public string ExtraText3 { get; set; }

		public string ExtraText4 { get; set; }

		public string ExtraText5 { get; set; }

		public string ExtraText6 { get; set; }

		public string ExtraText7 { get; set; }

		public string ExtraText8 { get; set; }

		public string ExtraText9 { get; set; }

		/// <summary>
		/// The customer fax number
		/// </summary>
		public string Fax { get; set; }

		/// <summary>
		/// If the customer is specified as having a delivery address separate to their billing address
		/// </summary>
		public bool HasDeliveryAddress { get; set; }

		/// <summary>
		/// If the customer is VAT Registered in another EC Member State
		/// </summary>
		public bool IsEuropeanCommunityVATRegistered { get; set; }

		/// <summary>
		/// If the customer is VAT Registered outside of the EC
		/// </summary>
		public bool IsVATRegisteredOutsideEuropeanCommunity { get; set; }

		/// <summary>
		/// The customer mobile number
		/// </summary>
		public string Mobile { get; set; }

		/// <summary>
		/// The name of the customer
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Free text
		/// </summary>
		public string Notes { get; set; }

		/// <summary>
		/// The number of days used to define the Due Date on Invoices from the Issue Date
		/// </summary>
		public int PaymentTerms { get; set; }

		/// <summary>
		/// The customer billing address postcode
		/// </summary>
		public string Postcode { get; set; }

		/// <summary>
		/// If the customer is specified to receive a discount then true, else false
		/// </summary>
		public bool ShowDiscount { get; set; }

		/// <summary>
		/// The ID for the source assigned to the customer
		/// </summary>
		public int SourceID { get; set; }

		/// <summary>
		/// The customer telephone number
		/// </summary>
		public string Telephone { get; set; }

		/// <summary>
		/// The date this customer record was last updated (read-only)
		/// </summary>
		public DateTime Updated { get; private set; }

		/// <summary>
		/// The customer VAT number
		/// </summary>
		public string VATNumber { get; set; }

		/// <summary>
		/// The customer website URI
		/// </summary>
		public string Website { get; set; }

		public Customer() : base() { }

		public Customer(KashFlow.Customer customer) : base(customer)
		{
			Address1 = customer.Address1;
			Address2 = customer.Address2;
			Address3 = customer.Address3;
			Address4 = customer.Address4;
			CheckBox1 = customer.CheckBox1 == 1;
			CheckBox2 = customer.CheckBox2 == 1;
			CheckBox3 = customer.CheckBox3 == 1;
			CheckBox4 = customer.CheckBox4 == 1;
			CheckBox5 = customer.CheckBox5 == 1;
			CheckBox6 = customer.CheckBox6 == 1;
			CheckBox7 = customer.CheckBox7 == 1;
			CheckBox8 = customer.CheckBox8 == 1;
			CheckBox9 = customer.CheckBox9 == 1;
			CheckBox10 = customer.CheckBox10 == 1;
			CheckBox11 = customer.CheckBox11 == 1;
			CheckBox12 = customer.CheckBox12 == 1;
			CheckBox13 = customer.CheckBox13 == 1;
			CheckBox14 = customer.CheckBox14 == 1;
			CheckBox15 = customer.CheckBox15 == 1;
			CheckBox16 = customer.CheckBox16 == 1;
			CheckBox17 = customer.CheckBox17 == 1;
			CheckBox18 = customer.CheckBox18 == 1;
			CheckBox19 = customer.CheckBox19 == 1;
			CheckBox20 = customer.CheckBox20 == 1;
			ExtraText1 = customer.ExtraText1;
			ExtraText2 = customer.ExtraText2;
			ExtraText3 = customer.ExtraText3;
			ExtraText4 = customer.ExtraText4;
			ExtraText5 = customer.ExtraText5;
			ExtraText6 = customer.ExtraText6;
			ExtraText7 = customer.ExtraText7;
			ExtraText8 = customer.ExtraText8;
			ExtraText9 = customer.ExtraText9;
			ExtraText10 = customer.ExtraText10;
			ExtraText11 = customer.ExtraText11;
			ExtraText12 = customer.ExtraText12;
			ExtraText13 = customer.ExtraText13;
			ExtraText14 = customer.ExtraText14;
			ExtraText15 = customer.ExtraText15;
			ExtraText16 = customer.ExtraText16;
			ExtraText17 = customer.ExtraText17;
			ExtraText18 = customer.ExtraText18;
			ExtraText19 = customer.ExtraText19;
			ExtraText20 = customer.ExtraText20;
			Code = customer.Code;
			Contact = customer.Contact;
			ContactFirstName = customer.ContactFirstName;
			ContactLastName = customer.ContactLastName;
			CountryCode = customer.CountryCode;
			CountryName = customer.CountryName;
			Created = customer.Created;
			CurrencyID = customer.CurrencyID;
			CustomerID = customer.CustomerID;
			DeliveryAddress1 = customer.DeliveryAddress1;
			DeliveryAddress2 = customer.DeliveryAddress2;
			DeliveryAddress3 = customer.DeliveryAddress3;
			DeliveryAddress4 = customer.DeliveryAddress4;
			DeliveryCountryCode = customer.DeliveryCountryCode;
			DeliveryCountryName = customer.DeliveryCountryName;
			DeliveryPostcode = customer.DeliveryPostcode;
			Discount = customer.Discount;
			Email = customer.Email;
			Fax = customer.Fax;
			HasDeliveryAddress = customer.CustHasDeliveryAddress == "1";
			IsEuropeanCommunityVATRegistered = customer.EC == 1;
			IsVATRegisteredOutsideEuropeanCommunity = customer.OutsideEC == 1;
			Mobile = customer.Mobile;
			Name = customer.Name;
			Notes = customer.Notes;
			PaymentTerms = customer.PaymentTerms;
			Postcode = customer.Postcode;
			ShowDiscount = customer.ShowDiscount;
			SourceID = customer.Source;
			Telephone = customer.Telephone;
			Updated = customer.Updated;
			VATNumber = customer.VATNumber;
			Website = customer.Website;
		}

		public KashFlow.Customer ToData()
		{
			return new KashFlow.Customer()
			{
				Address1 = Address1,
				Address2 = Address2,
				Address3 = Address3,
				Address4 = Address4,
				CheckBox1 = CheckBox1 ? 1 : 0,
				CheckBox2 = CheckBox2 ? 1 : 0,
				CheckBox3 = CheckBox3 ? 1 : 0,
				CheckBox4 = CheckBox4 ? 1 : 0,
				CheckBox5 = CheckBox5 ? 1 : 0,
				CheckBox6 = CheckBox6 ? 1 : 0,
				CheckBox7 = CheckBox7 ? 1 : 0,
				CheckBox8 = CheckBox8 ? 1 : 0,
				CheckBox9 = CheckBox9 ? 1 : 0,
				CheckBox10 = CheckBox10 ? 1 : 0,
				CheckBox11 = CheckBox11 ? 1 : 0,
				CheckBox12 = CheckBox12 ? 1 : 0,
				CheckBox13 = CheckBox13 ? 1 : 0,
				CheckBox14 = CheckBox14 ? 1 : 0,
				CheckBox15 = CheckBox15 ? 1 : 0,
				CheckBox16 = CheckBox16 ? 1 : 0,
				CheckBox17 = CheckBox17 ? 1 : 0,
				CheckBox18 = CheckBox18 ? 1 : 0,
				CheckBox19 = CheckBox19 ? 1 : 0,
				CheckBox20 = CheckBox20 ? 1 : 0,
				ExtraText1 = ExtraText1,
				ExtraText2 = ExtraText2,
				ExtraText3 = ExtraText3,
				ExtraText4 = ExtraText4,
				ExtraText5 = ExtraText5,
				ExtraText6 = ExtraText6,
				ExtraText7 = ExtraText7,
				ExtraText8 = ExtraText8,
				ExtraText9 = ExtraText9,
				ExtraText10 = ExtraText10,
				ExtraText11 = ExtraText11,
				ExtraText12 = ExtraText12,
				ExtraText13 = ExtraText13,
				ExtraText14 = ExtraText14,
				ExtraText15 = ExtraText15,
				ExtraText16 = ExtraText16,
				ExtraText17 = ExtraText17,
				ExtraText18 = ExtraText18,
				ExtraText19 = ExtraText19,
				ExtraText20 = ExtraText20,
				Code = Code,
				Contact = Contact,
				ContactFirstName = ContactFirstName,
				ContactLastName = ContactLastName,
				CountryCode = CountryCode,
				CountryName = CountryName,
				Created = Created,
				CurrencyID = CurrencyID,
				CustomerID = CustomerID,
				DeliveryAddress1 = DeliveryAddress1,
				DeliveryAddress2 = DeliveryAddress2,
				DeliveryAddress3 = DeliveryAddress3,
				DeliveryAddress4 = DeliveryAddress4,
				DeliveryCountryCode = DeliveryCountryCode,
				DeliveryCountryName = DeliveryCountryName,
				DeliveryPostcode = DeliveryPostcode,
				Discount = Discount,
				Email = Email,
				Fax = Fax,
				CustHasDeliveryAddress = HasDeliveryAddress ? "1" : "0",
				EC = IsEuropeanCommunityVATRegistered ? 1 : 0,
				OutsideEC = IsVATRegisteredOutsideEuropeanCommunity ? 1 : 0,
				Mobile = Mobile,
				Name = Name,
				Notes = Notes,
				PaymentTerms = PaymentTerms,
				Postcode = Postcode,
				ShowDiscount = ShowDiscount,
				Source = SourceID,
				Telephone = Telephone,
				Updated = Updated,
				VATNumber = VATNumber,
				Website = Website
			};
		}
	}
}