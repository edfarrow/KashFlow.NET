using KashFlow_NET.Interfaces.Models.Shared;
using KashFlow_NET.Models.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow_NET.Models.Transaction
{
	/// <summary>
	/// Represents a transaction
	/// </summary>
	public class TransactionInformation : KashFlowBase<KashFlow.TransactionInformation>, IToData<KashFlow.TransactionInformation>
	{
		/// <summary>
		/// The date of the transaction
		/// </summary>
		public DateTime Date { get; set; }

		/// <summary>
		/// The unique id number for the nominal code involved in this transaction
		/// </summary>
		public int NominalCodeID { get; set; }

		/// <summary>
		/// The value of this transaction
		/// </summary>
		public decimal Value { get; set; }

		/// <summary>
		/// The transaction type
		/// </summary>
		public TransactionType Type { get; set; }

		/// <summary>
		/// The id number (Could be for an invoice, purchase, etc, dependent on the ‘type’ above.
		/// </summary>
		public int TransactionID { get; set; }

		/// <summary>
		/// For future use
		/// </summary>
		public int TransactionID2 { get; set; }

		/// <summary>
		/// For future use
		/// </summary>
		public int TransactionID3 { get; set; }

		/// <summary>
		/// The Invoice or Purchase number, or the name of the bank account
		/// </summary>
		public string Reference1 { get; set; }

		/// <summary>
		/// The customer or supplier name, or the comment entered if ‘type’ is 3 or 4.
		/// </summary>
		public string Reference2 { get; set; }

		/// <summary>
		/// For future use
		/// </summary>
		public string Reference3 { get; set; }

		/// <summary>
		/// The description of the transaction
		/// </summary>
		public string Narrative { get; set; }

		/// <summary>
		/// The project associated with the transaction
		/// </summary>
		public int ProjectID { get; set; }

		public TransactionInformation() { }

		public TransactionInformation(KashFlow.TransactionInformation transactionInformation)
		{
			Date = transactionInformation.Date;
			NominalCodeID = transactionInformation.nomid;
			Value = transactionInformation.Value;
			Type = (TransactionType)transactionInformation.Type;
			TransactionID = transactionInformation.id;
			TransactionID2 = transactionInformation.id2;
			TransactionID3 = transactionInformation.id3;
			Reference1 = transactionInformation.Ref1;
			Reference2 = transactionInformation.Ref2;
			Reference3 = transactionInformation.Ref3;
			Narrative = transactionInformation.Narrative;
			ProjectID = transactionInformation.ProjId;
		}

		public KashFlow.TransactionInformation ToData()
		{
			return new KashFlow.TransactionInformation() 
			{
				Date = Date,
				nomid = NominalCodeID,
				Value = Value,
				Type = (int)Type,
				id = TransactionID,
				id2 = TransactionID2,
				id3 = TransactionID3,
				Ref1 = Reference1,
				Ref2 = Reference2,
				Ref3 = Reference3,
				Narrative = Narrative,
				ProjId = ProjectID
			};
		}
	}
}
