using KashFlow_NET.Interfaces.Models.Shared;
using KashFlow_NET.Models.Shared;

namespace KashFlow_NET.Models.Product
{
	/// <summary>
	/// The SubProduct class is used to represent what is referred to within the application as “Products” or “Sub-Outgoing Types”.
	/// </summary>
	public class SubProduct : KashFlowBase<KashFlow.SubProduct>, IToData<KashFlow.SubProduct>
	{
		/// <summary>
		/// A flag indicating whether a sub-products’ stock is managed. Set to true if you want the SubProduct managed
		/// </summary>
		public bool AreStockLevelsManaged { get; set; }

		/// <summary>
		/// The code for this SubProduct. Unlike a Nominal Code, this does not need to be numeric.
		/// </summary>
		public string Code { get; set; }

		/// <summary>
		/// A description for this SubProduct
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// A flag indicating whether or not Line Items raised with this SubProduct auto-populate with the Description, Price/WholesalePrice and VatRate values
		/// </summary>
		public bool IsLineItemAutofilled { get; set; }

		/// <summary>
		/// The name for this SubProduct
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The ID of the parent NominalCode to which this SubProduct belongs
		/// </summary>
		public int ParentID { get; set; }

		/// <summary>
		/// The default price of the SubProduct
		/// </summary>
		public decimal Price { get; set; }

		/// <summary>
		/// The current stock quantity of the sub-product
		/// </summary>
		public int QuantityInStock { get; set; }

		/// <summary>
		/// The system-wide, unique ID number for this SubProduct
		/// </summary>
		public int SubProductID { get; private set; }

		/// <summary>
		/// The default VAT Rate of the SubProduct
		/// </summary>
		public decimal VatRate { get; set; }

		/// <summary>
		/// The current configured stock warning quantity of the sub-product
		/// </summary>
		public int WarningQuantity { get; set; }

		/// <summary>
		/// The wholesale price of the sub-product
		/// </summary>
		public decimal WholesalePrice { get; set; }

		public SubProduct()
		{
		}

		public SubProduct(KashFlow.SubProduct subProduct)
		{
			SubProductID = subProduct.id;
			ParentID = subProduct.ParentID;
			Name = subProduct.Name;
			Code = subProduct.Code;
			Description = subProduct.Description;
			Price = subProduct.Price;
			VatRate = subProduct.VatRate;
			WholesalePrice = subProduct.WholesalePrice;
			AreStockLevelsManaged = subProduct.Managed > 0;
			QuantityInStock = subProduct.QtyInStock;
			WarningQuantity = subProduct.StockWarnQty;
			IsLineItemAutofilled = subProduct.AutoFill > 0;
		}

		public KashFlow.SubProduct ToData()
		{
			return new KashFlow.SubProduct() 
			{
				id = SubProductID,
				ParentID = ParentID,
				Name = Name,
				Code = Code,
				Description = Description,
				Price = Price,
				VatRate = VatRate,
				WholesalePrice = WholesalePrice,
				Managed = AreStockLevelsManaged ? 1 : 0,
				QtyInStock = QuantityInStock,
				StockWarnQty = WarningQuantity,
				AutoFill = IsLineItemAutofilled ? 1 : 0
			};
		}
	}
}