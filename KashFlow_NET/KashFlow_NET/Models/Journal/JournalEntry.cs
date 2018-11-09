using KashFlow_NET.Interfaces.Models.Shared;
using KashFlow_NET.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KashFlow_NET.Models.Journal
{
	/// <summary>
	/// Represents an entry in a Journal
	/// </summary>
	public class JournalEntry : KashFlowBase<KashFlow.JournalEntry>, IToData<KashFlow.JournalEntry>
	{
		/// <summary>
		/// The system-wide, unique ID number for the journal (immutable)
		/// </summary>
		public int ID { get; private set; }

		/// <summary>
		/// The journal number, must be unique for the KashFlow account journal list
		/// </summary>
		public int Number { get; set; }

		/// <summary>
		/// The date the journal was recorded for
		/// </summary>
		public DateTime Date { get; set; }

		/// <summary>
		/// A string of free text used to add a comment to the journal head
		/// </summary>
		public string Comment { get; set; }

		/// <summary>
		/// List of lines for the entry in <see cref="JournalLine">JournalLine</see> format
		/// </summary>
		public List<JournalLine> Lines { get; set; }

		public JournalEntry() { }

		public JournalEntry(KashFlow.JournalEntry journalEntry) : base(journalEntry)
		{
			ID = journalEntry.DBID;
			Number = journalEntry.JournalNumber;
			Date = journalEntry.JournalDate;
			Comment = journalEntry.Comment;
			Lines = journalEntry.Lines.Select(x => new JournalLine((KashFlow.JournalLine)x)).ToList();
		}

		public KashFlow.JournalEntry ToData()
		{
			return new KashFlow.JournalEntry()
			{
				DBID = ID,
				JournalNumber = Number,
				JournalDate = Date,
				Comment = Comment,
				Lines = Lines.Select(x => x.ToData()).ToArray()
			};
		}
	}
}
