using KashFlow_NET.Models.Shared;

namespace KashFlow_NET.Models.Customer
{
	/// <summary>
	/// Represents the balance for a customer
	/// </summary>
	public class CustomerBalance : KashFlowBase<KashFlow.CustomerBalance>
	{
		/// <summary>
		/// The system-wide, unique ID number for the customer (immutable)
		/// </summary>
		public int CustomerID { get; set; }

		/// <summary>
		/// An alphanumeric ID for the customer, unique for the KashFlow account customers list
		/// </summary>
		public string CustomerCode { get; set; }

		/// <summary>
		/// The sum of all payments made by the customer– excludes anything dated for the future
		/// </summary>
		public decimal Value { get; set; }

		/// <summary>
		/// The unpaid amount of all invoices issued to the customer– excludes anything dated for the future
		/// </summary>
		public decimal Balance { get; set; }

		public CustomerBalance() : base() { }

		public CustomerBalance(KashFlow.CustomerBalance customerBalance) : base(customerBalance)
		{
			CustomerID = customerBalance.CustomerId;
			CustomerCode = customerBalance.CustomerCode;
			Value = customerBalance.Value;
			Balance = customerBalance.Balance;
		}
	}
}
