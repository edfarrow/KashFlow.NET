using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow_NET.Models.Transaction
{
	public enum TransactionType
	{
		SalesInvoice = 1,
		PurchaseInvoice = 2,
		BankTransaction = 3,
		JournalEntry = 4
	}
}
