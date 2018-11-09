using KashFlow_NET.Interfaces.Models.Shared;
using KashFlow_NET.Models.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow_NET.Models.Invoice
{
	/// <summary>
	/// This class is used as part of Invoice class to specify delivery address of the invoice.
	/// </summary>
	public class DeliveryAddress : KashFlowBase<KashFlow.DeliveryAddress>, IToData<KashFlow.DeliveryAddress>
	{
		/// <summary>
		/// Delivery address name
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Delivery address line 1
		/// </summary>
		public string Line1 { get; set; }

		/// <summary>
		/// Delivery address line 2
		/// </summary>
		public string Line2 { get; set; }

		/// <summary>
		/// Delivery address line 3
		/// </summary>
		public string Line3 { get; set; }

		/// <summary>
		/// Delivery address line 4
		/// </summary>
		public string Line4 { get; set; }

		/// <summary>
		/// Delivery address line 4
		/// </summary>
		public string Postcode { get; set; }

		/// <summary>
		/// Delivery address country name
		/// </summary>
		public string CountryName { get; set; }

		/// <summary>
		/// The delivery address country code in the ISO 3166-1 alpha-2 standard (except for Greece which is recorded as ‘EL’)
		/// </summary>
		public string CountryCode { get; set; }

		public DeliveryAddress() : base() { }

		public DeliveryAddress(KashFlow.DeliveryAddress deliveryAddress) : base(deliveryAddress)
		{
			CountryCode = deliveryAddress.CountryCode;
			Name = deliveryAddress.Name;
			Line1 = deliveryAddress.Line1;
			Line2 = deliveryAddress.Line2;
			Line3 = deliveryAddress.Line3;
			Line4 = deliveryAddress.Line4;
			Postcode = deliveryAddress.PostCode;
			CountryName = deliveryAddress.CountryName;
		}

		public KashFlow.DeliveryAddress ToData()
		{
			return new KashFlow.DeliveryAddress()
			{
				CountryName = CountryName,
				CountryCode = CountryCode,
				PostCode = Postcode,
				Line1 = Line1,
				Line2 = Line2,
				Line3 = Line3,
				Line4 = Line4,
				Name = Name
			};
		}
	}
}
