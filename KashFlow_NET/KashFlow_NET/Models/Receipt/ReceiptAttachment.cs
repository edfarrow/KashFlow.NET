using KashFlow_NET.Interfaces.Models.Shared;
using KashFlow_NET.Models.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow_NET.Models.Receipt
{
	/// <summary>
	/// Represents a receipt attachment
	/// </summary>
	public class ReceiptAttachment : KashFlowBase<KashFlow.ReceiptAttachment>, IToData<KashFlow.ReceiptAttachment>
	{
		/// <summary>
		/// System-wide unique number for the receipt attachment.
		/// </summary>
		public int AttachmentID { get; private set; }

		/// <summary>
		/// System-wide unique number for the receipt.
		/// </summary>
		public int ReceiptID { get; private set; }

		/// <summary>
		/// The filename specified by the user
		/// </summary>
		public string Filename { get; set; }

		/// <summary>
		/// The unique filename.
		/// </summary>
		public string FilenameUnique { get; set; }

		/// <summary>
		/// The date the file was attached
		/// </summary>
		public DateTime UploadDate { get; set; }

		/// <summary>
		/// The file type
		/// </summary>
		public string ContentType { get; set; }

		/// <summary>
		/// The Metadata name for the file.
		/// </summary>
		public string MetadataName { get; set; }

		/// <summary>
		/// The metadata value for the file.
		/// </summary>
		public string MetadataValue { get; set; }

		/// <summary>
		/// The size of the file in KB
		/// </summary>
		public ulong FileSize { get; set; }

		/// <summary>
		/// The extension of the file
		/// </summary>
		public string FileExtension { get; set; }

		/// <summary>
		/// The public URL of the file.
		/// </summary>
		public string PublicURL { get; set; }

		public ReceiptAttachment() { }

		public ReceiptAttachment(KashFlow.ReceiptAttachment receiptAttachment)
		{
			AttachmentID = receiptAttachment.AttachmentID;
			ReceiptID = receiptAttachment.ReceiptID;
			Filename = receiptAttachment.ActualFilename;
			FilenameUnique = receiptAttachment.AmazonFilename;
			UploadDate = receiptAttachment.UploadDate;
			ContentType = receiptAttachment.ContentType;
			MetadataName = receiptAttachment.MetaName;
			MetadataValue = receiptAttachment.MetaValue;
			FileSize = ulong.Parse(receiptAttachment.FileSize);
			FileExtension = receiptAttachment.FileExtension;
			PublicURL = receiptAttachment.FileURL;
		}

		public KashFlow.ReceiptAttachment ToData()
		{
			return new KashFlow.ReceiptAttachment() {
				AttachmentID = AttachmentID,
				ReceiptID = ReceiptID,
				ActualFilename = Filename,
				AmazonFilename = FilenameUnique,
				UploadDate = UploadDate,
				ContentType = ContentType,
				MetaName = MetadataName,
				MetaValue = MetadataValue,
				FileSize = FileSize.ToString(),
				FileExtension = FileExtension,
				FileURL = PublicURL
			};
		}
	}
}
