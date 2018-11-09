using KashFlow.NET.Interfaces.Models.Shared;

namespace KashFlow.NET.Models.Shared
{
	/// <summary>
	/// Nominal codes are the unique reference numbers given to each nominal account for a business
	/// </summary>
	public class NominalCode : KashFlowBase<KashFlow.NominalCode>, IToData<KashFlow.NominalCode>
	{
		/// <summary>
		/// The system-wide, unique ID number for the nominal code (immutable)
		/// </summary>
		public int ID { get; set; }

		/// <summary>
		/// The Nominal Code code
		/// </summary>
		public int Code { get; set; }

		/// <summary>
		/// The Nominal Code name
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The sum of all debits to the Nominal Code (for the defined period)
		/// </summary>
		public decimal Debit { get; set; }

		/// <summary>
		/// The sum of all credits to the Nominal Code (for the defined period)
		/// </summary>
		public decimal Credit { get; set; }

		/// <summary>
		/// The value of the credit minus the debit (for the defined period)
		/// </summary>
		public decimal Balance { get; set; }

		public NominalCode() : base() { }

		public NominalCode(KashFlow.NominalCode nominalCode): base(nominalCode)
		{
			ID = nominalCode.id;
			Code = nominalCode.Code;
			Name = nominalCode.Name;
			Debit = nominalCode.debit;
			Credit = nominalCode.credit;
			Balance = nominalCode.balance;
		}
		
		public KashFlow.NominalCode ToData()
		{
			throw new System.NotImplementedException();
		}
	}
}
