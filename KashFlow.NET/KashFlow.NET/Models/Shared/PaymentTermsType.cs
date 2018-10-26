using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow.NET.Models.Shared
{
	/// <summary>
	/// Provides fixed values for payment terms
	/// </summary>
	public enum PaymentTermsType
	{
		/// <summary>
		/// Days after issue month end
		/// </summary>
		MonthEnd,

		/// <summary>
		/// Days after issue date
		/// </summary>
		InvoiceDate
	}
}
