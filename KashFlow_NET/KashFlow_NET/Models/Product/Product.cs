using KashFlow_NET.Interfaces.Models.Shared;
using KashFlow_NET.Models.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow_NET.Models.Product
{
	/// <summary>
	/// Represents a product
	/// </summary>
	public class Product : KashFlowBase<KashFlow.Product>, IToData<KashFlow.Product>
	{
		/// <summary>
		/// System-wide unique number for this product
		/// </summary>
		public int ProductID { get; private set; }

		/// <summary>
		/// The name of the product
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The code for this product
		/// </summary>
		public int Code { get; set; }

		/// <summary>
		/// Description of the product
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Indicate whether or not the stock levels for this product are to be tracked or not.
		/// </summary>
		public bool AreStockLevelsManaged { get; set; }

		/// <summary>
		/// The quantity of this item that is in stock
		/// </summary>
		public int QuantityInStock { get; set; }

		/// <summary>
		/// The price of the product
		/// </summary>
		public decimal Price { get; set; }


		public Product() { }

		public Product(KashFlow.Product product) : base(product)
		{
			ProductID = product.ProductID;
			Name = product.ProductName;
			Code = product.ProductCode;
			Description = product.ProductDescription;
			AreStockLevelsManaged = product.ManageStockLevels == 1;
			QuantityInStock = product.QtyInStock;
			Price = product.ProductPrice;
		}

		public KashFlow.Product ToData()
		{
			return new KashFlow.Product() 
			{
				ProductPrice = Price,
				ProductCode = Code,
				ProductDescription = Description,
				ManageStockLevels = AreStockLevelsManaged ? 1 : 0,
				QtyInStock = QuantityInStock,
				ProductID = ProductID,
				ProductName = Name
			};
		}
	}
}
