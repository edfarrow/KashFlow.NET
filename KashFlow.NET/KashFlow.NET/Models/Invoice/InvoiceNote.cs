using System;
using System.Collections.Generic;
using System.Text;
using KashFlow.NET.Interfaces.Models.Shared;
using KashFlow.NET.Models.Shared;

namespace KashFlow.NET.Models.Invoice
{
	/// <summary>
	/// Represents an Invoice Note
	/// </summary>
	public class InvoiceNote : KashFlowBase<KashFlow.InvoiceNotes>, IToData<KashFlow.InvoiceNotes>
	{
		/// <summary>
		/// The system-wide, unique ID number for the invoice
		/// </summary>
		public int InvoiceID { get; set; }

		/// <summary>
		/// The system-wide, unique ID number for the invoice note (immutable)
		/// </summary>
		public int NoteID { get; private set; }

		/// <summary>
		/// The date the note was added
		/// </summary>
		public DateTime NoteDate { get; set; }

		/// <summary>
		/// A string of free-text that makes up the note body
		/// </summary>
		public string Notes { get; set; }

		public InvoiceNote() : base() { }

		public InvoiceNote(KashFlow.InvoiceNotes invoiceNote) : base(invoiceNote)
		{
			InvoiceID = invoiceNote.InvoiceId;
			NoteID = invoiceNote.NoteId;
			NoteDate = invoiceNote.NoteDate;
			Notes = invoiceNote.Notes;
		}

		public KashFlow.InvoiceNotes ToData()
		{
			return new InvoiceNotes()
			{
				InvoiceId = InvoiceID,
				Notes = Notes,
				NoteDate = NoteDate,
				NoteId = NoteID
			};
		}
	}
}
