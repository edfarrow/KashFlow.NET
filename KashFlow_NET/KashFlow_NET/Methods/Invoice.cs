using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KashFlow_NET
{
	public partial class KashFlowNet
	{
		public async Task<int> InvoiceCreate(Models.Invoice.Invoice invoice)
		{
			var rawInvoice = invoice.ToData();
			var insertRequest = new KashFlow.InsertInvoiceRequest()
			{
				UserName = _username,
				Password = _password,
				Inv = rawInvoice
			};
			
			var result = await _kashflowClient.InsertInvoiceAsync(insertRequest);

			return result.InsertInvoiceResult;
		}

		public async Task<int> InvoiceLineCreate(int invoiceID, Models.Invoice.InvoiceLine invoiceLine)
		{
			var rawInvoice = invoiceLine.ToData();
			var insertRequest = new KashFlow.InsertInvoiceLineRequest()
			{
				UserName = _username,
				Password = _password,
				InvLine = rawInvoice,
				InvoiceID = invoiceID
			};

			var result = await _kashflowClient.InsertInvoiceLineAsync(insertRequest);
			return result.InsertInvoiceLineResult;
		}

		public async Task InvoiceEmailSend(Models.Invoice.InvoiceEmail invoiceEmail)
		{
			var rawEmail = invoiceEmail.ToData();
			rawEmail.UserName = _username;
			rawEmail.Password = _password;

			var result = await _kashflowClient.EmailInvoiceAsync(rawEmail);
			return;
		}
	}
}
