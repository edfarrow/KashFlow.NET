using KashFlow.NET.Interfaces.Models.Shared;
using KashFlow.NET.Models.Shared;

namespace KashFlow.NET.Models.Company
{
	/// <summary>
	/// Represents a company
	/// </summary>
	public class CompanyDetails : KashFlowBase<KashFlow.CompanyDetails>, IToData<KashFlow.CompanyDetails>
	{
		/// <summary>
		/// The company name
		/// </summary>
		public string CompanyName { get; set; }

		/// <summary>
		/// The company address line 1
		/// </summary>
		public string Address1 { get; set; }

		/// <summary>
		/// The company address line 2
		/// </summary>
		public string Address2 { get; set; }

		/// <summary>
		/// The company address line 2
		/// </summary>
		public string Address3 { get; set; }

		/// <summary>
		/// The company address line 4
		/// </summary>
		public string Address4 { get; set; }

		/// <summary>
		/// The company post code
		/// </summary>
		public string Postcode { get; set; }

		/// <summary>
		/// The contact email address
		/// </summary>
		public string PrimaryEmail { get; set; }

		/// <summary>
		/// The contact name
		/// </summary>
		public string PrimaryContact { get; set; }

		/// <summary>
		/// The contact telephone number
		/// </summary>
		public string Telephone { get; set; }

		/// <summary>
		/// The contact mobile number
		/// </summary>
		public string Mobile { get; set; }

		/// <summary>
		/// If the company is specified as VAT registered. NB this is converted to "Yes" or "No"
		/// </summary>
		public bool IsVATRegistered { get; set; }

		/// <summary>
		/// The company VAT registration number
		/// </summary>
		public string VATRegistrationNumber { get; set; }

		/// <summary>
		/// The KashFlow account default payment terms
		/// </summary>
		public int PaymentTerms { get; set; }

		/// <summary>
		/// The home currency symbol
		/// </summary>
		public string CurrencySymbol { get; set; }

		/// <summary>
		/// If the account is specified to operate with the US standard date format of mm/dd/yyyy
		/// </summary>
		public bool IsUsingAmericanDate { get; set; }

		/// <summary>
		/// The ID of the currency specified as the home currency
		/// </summary>
		public int CurrencyID { get; set; }

		/// <summary>
		/// The home currency name
		/// </summary>
		public string CurrencyName { get; set; }

		/// <summary>
		/// Where the currency symbol should appear relative to the amount
		/// </summary>
		public CurrencyPositionType CurrencyPosition { get; set; }

		/// <summary>
		/// The ID of for the primary level industry sector value
		/// </summary>
		public int BusinessType1 { get; set; }

		/// <summary>
		/// The ID of for the secondary level industry sector value
		/// </summary>
		public int BusinessType2 { get; set; }

		/// <summary>
		///	The ID of for the tertiary level industry sector value
		/// </summary>
		public int BusinessType3 { get; set; }

		/// <summary>
		/// The payment terms type for the company
		/// </summary>
		public PaymentTermsType PaymentTermsType { get; set; }

		/// <summary>
		/// The name of the primary level industry sector value
		/// </summary>
		public string BusinessName1 { get; set; }

		/// <summary>
		/// The name of the secondary level industry sector value
		/// </summary>
		public string BusinessName2 { get; set; }

		/// <summary>
		/// The name of the tertiary level industry sector value
		/// </summary>
		public string BusinessName3 { get; set; }

		/// <summary>
		/// The ID for the business type
		/// </summary>
		public int BusinessType { get; set; }

		public CompanyDetails() : base() { }

		public CompanyDetails(KashFlow.CompanyDetails companyDetails) : base(companyDetails)
		{
			CompanyName = companyDetails.CompanyName;
			Address1 = companyDetails.Address1;
			Address2 = companyDetails.Address2;
			Address3 = companyDetails.Address3;
			Address4 = companyDetails.Address4;
			Postcode = companyDetails.Postcode;
			PrimaryEmail = companyDetails.PrimaryEmail;
			PrimaryContact = companyDetails.PrimaryContact;
			Telephone = companyDetails.Telephone;
			Mobile = companyDetails.Mobile;
			IsVATRegistered = companyDetails.VatRegistered == "Yes" ? true : false;
			VATRegistrationNumber = companyDetails.VatRegistrationNumber;
			PaymentTerms = companyDetails.PaymentTerms;
			CurrencySymbol = companyDetails.CurrencySymbol;
			CurrencyPosition = companyDetails.CurrencyPosition == "Left" ? CurrencyPositionType.Left : CurrencyPositionType.Right;
			IsUsingAmericanDate = companyDetails.UsDate == "Yes" ? true : false;
			CurrencyID = companyDetails.CurrencyId;
			CurrencyName = companyDetails.CurrencyName;
			BusinessName1 = companyDetails.BusinessType1Name;
			BusinessName2 = companyDetails.BusinessType2Name;
			BusinessName3 = companyDetails.BusinessType3Name;
			BusinessType1 = companyDetails.BusinessType1;
			BusinessType2 = companyDetails.BusinessType2;
			BusinessType3 = companyDetails.BusinessType3;
			BusinessType = companyDetails.BusinessType;
		}

		public KashFlow.CompanyDetails ToData()
		{
			return new KashFlow.CompanyDetails()
			{
				Address1 = Address1,
				Address2 = Address2,
				Address3 = Address3,
				Address4 = Address4,
				BusinessType = BusinessType,
				BusinessType1 = BusinessType1,
				BusinessType1Name = BusinessName1,
				BusinessType2 = BusinessType2,
				BusinessType2Name = BusinessName2,
				BusinessType3 = BusinessType3,
				BusinessType3Name = BusinessName3,
				CompanyName = CompanyName,
				CurrencyId = CurrencyID,
				CurrencyName = CurrencyName,
				CurrencyPosition = CurrencyPosition.ToString(),
				CurrencySymbol = CurrencySymbol,
				Mobile = Mobile,
				PaymentTerms = PaymentTerms,
				PaymentTermsType = PaymentTermsType.ToString(),
				Postcode = Postcode,
				PrimaryContact = PrimaryContact,
				PrimaryEmail = PrimaryEmail,
				Telephone = Telephone,
				UsDate = IsUsingAmericanDate ? "Yes" : "No",
				VatRegistered = IsVATRegistered ? "Yes" : "No",
				VatRegistrationNumber = VATRegistrationNumber
			};
		}
	}
}
