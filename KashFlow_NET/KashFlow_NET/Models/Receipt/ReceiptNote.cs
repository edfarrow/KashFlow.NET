using KashFlow_NET.Interfaces.Models.Shared;
using KashFlow_NET.Models.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow_NET.Models.Receipt
{
	/// <summary>
	/// Represents a note on the receipt
	/// </summary>
	public class ReceiptNote : KashFlowBase<KashFlow.ReceiptNotes>, IToData<KashFlow.ReceiptNotes>
	{
		/// <summary>
		/// The system-wide, unique ID number for the receipt
		/// </summary>
		public int ReceiptID { get; private set; }

		/// <summary>
		/// The system-wide, unique ID number for the ReceiptNote
		/// </summary>
		public int NoteID { get; private set; }

		/// <summary>
		/// The date of the ReceiptNote
		/// </summary>
		public DateTime Date { get; set; }

		/// <summary>
		/// The actual note on the receipt
		/// </summary>
		public string Note { get; set; }

		public ReceiptNote() { }

		public ReceiptNote(KashFlow.ReceiptNotes receiptNote)
		{
			ReceiptID = receiptNote.ReceiptId;
			NoteID = receiptNote.NoteId;
			Date = receiptNote.NoteDate;
			Note = receiptNote.Notes;
		}

		public KashFlow.ReceiptNotes ToData()
		{
			return new KashFlow.ReceiptNotes() 
			{
				ReceiptId = ReceiptID,
				NoteId = NoteID,
				NoteDate = Date,
				Notes = Note
			};
		}
	}
}
