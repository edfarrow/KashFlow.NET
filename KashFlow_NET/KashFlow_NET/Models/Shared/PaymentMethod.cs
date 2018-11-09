using KashFlow_NET.Interfaces.Models.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow_NET.Models.Shared
{
	/// <summary>
	/// Represents a payment method
	/// </summary>
	public class PaymentMethod : KashFlowBase<KashFlow.PaymentMethod>, IToData<KashFlow.PaymentMethod>
	{
		/// <summary>
		/// The ID number for the Payment Method
		/// </summary>
		public int MethodID { get; private set; }

		/// <summary>
		/// The name of the payment method
		/// </summary>
		public string Name { get; set; }

		public PaymentMethod() { }

		public PaymentMethod(KashFlow.PaymentMethod paymentMethod) : base(paymentMethod)
		{
			MethodID = paymentMethod.MethodID;
			Name = paymentMethod.MethodName;
		}

		public KashFlow.PaymentMethod ToData()
		{
			return new KashFlow.PaymentMethod()
			{
				MethodID = MethodID,
				MethodName = Name
			};
		}
	}
}
