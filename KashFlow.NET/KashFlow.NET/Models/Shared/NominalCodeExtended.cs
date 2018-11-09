using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow.NET.Models.Shared
{
	/// <summary>
	/// An extended version of <see cref="NominalCode"/>
	/// </summary>
	public class NominalCodeExtended : NominalCode
	{
		/// <summary>
		/// Provides an ID number to tell you where on the P&L on Balance sheet this code belongs
		/// </summary>
		public int TypeID { get; private set; }

		/// <summary>
		/// A human-friendly version of TypeID
		/// </summary>
		public string TypeName { get; private set; }

		/// <summary>
		/// This property tells you where in the application the code is listed (ie as a “Sales Type”)
		/// </summary>
		public int ClassificationID { get; private set; }

		/// <summary>
		/// A human-friendly version of ClassificationID
		/// </summary>
		public string ClassificationName { get; private set; }

		/// <summary>
		/// If the nominal is set to autofill
		/// </summary>
		public bool IsAutofilled { get; private set; }

		/// <summary>
		/// The configured price for the nominal
		/// </summary>
		public decimal Price { get; set; }

		/// <summary>
		/// The configure VAT rate for the nominal
		/// </summary>
		public decimal VATRate { get; set; }

		/// <summary>
		/// The configured description for the nominal.
		/// </summary>
		public string Description { get; set; }

		public NominalCodeExtended(): base() { }

		public NominalCodeExtended(KashFlow.NominalCodeExtended nominalCode)
		{
			ID = nominalCode.id;
			Code = nominalCode.Code;
			Name = nominalCode.Name;
			Debit = nominalCode.debit;
			Credit = nominalCode.credit;
			Balance = nominalCode.balance;
			TypeID = nominalCode.TypeID;
			TypeName = nominalCode.TypeName;
			ClassificationID = nominalCode.ClassificationID;
			ClassificationName = nominalCode.ClassificationName;
			IsAutofilled = nominalCode.AutoFill == 1;
			Price = nominalCode.Price;
			VATRate = nominalCode.VATRate;
			Description = nominalCode.Description;
		}
	}
}
