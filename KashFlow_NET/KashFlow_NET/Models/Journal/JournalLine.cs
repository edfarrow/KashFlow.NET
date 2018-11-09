using KashFlow_NET.Interfaces.Models.Shared;
using KashFlow_NET.Models.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow_NET.Models.Journal
{
	/// <summary>
	/// Line item for a journal
	/// </summary>
	public class JournalLine : KashFlowBase<KashFlow.JournalLine>, IToData<KashFlow.JournalLine>
	{
		/// <summary>
		/// The system-wide, unique ID number for the nominal code used for the journal line
		/// </summary>
		public int NominalID { get; set; }

		/// <summary>
		/// The credit/debit value for the journal line.
		/// NB:A negative amount will be treated as Credit and a positive amount will be treated as Debit
		/// </summary>
		public decimal Amount { get; set; }

		/// <summary>
		/// The comment added to the journal line
		/// </summary>
		public string Comment { get; set; }

		/// <summary>
		/// The project associated with the journal line
		/// </summary>
		public int ProjectID { get; set; }

		public JournalLine(KashFlow.JournalLine journalLine) : base(journalLine)
		{
			NominalID = journalLine.NominalID;
			Amount = journalLine.Amount;
			Comment = journalLine.Comment;
			ProjectID = journalLine.ProjId;
		}

		public KashFlow.JournalLine ToData()
		{
			return new KashFlow.JournalLine()
			{
				NominalID = NominalID,
				Amount = Amount,
				Comment = Comment,
				ProjId = ProjectID
			};
		}
	}
}
