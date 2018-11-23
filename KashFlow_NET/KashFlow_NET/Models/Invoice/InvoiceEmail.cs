using KashFlow_NET.Interfaces.Models.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow_NET.Models.Invoice
{
	public class InvoiceEmail : IToData<KashFlow.EmailInvoiceRequest>
	{
		public int InvoiceNumber;
		
		public string FromEmail;

		public string FromName;


		public string SubjectLine;
		
		public string Body;
		
		public string RecipientEmail;

		public InvoiceEmail() { }

		public KashFlow.EmailInvoiceRequest ToData()
		{
			return new KashFlow.EmailInvoiceRequest()
			{
				InvoiceNumber = InvoiceNumber,
				FromEmail = FromEmail,
				FromName = FromName,
				SubjectLine = SubjectLine,
				Body = Body,
				RecipientEmail = RecipientEmail
			};
		}
	}
}
