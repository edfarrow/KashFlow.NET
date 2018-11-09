using KashFlow_NET.Interfaces.Models.Shared;
using KashFlow_NET.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KashFlow_NET.Models.Product
{
	/// <summary>
	/// Represents a set of subproducts with the parent product
	/// </summary>
	public class ProductsFull : Product, IToData<KashFlow.ProductsFull>
	{
		/// <summary>
		/// SubProducts list within the Products
		/// </summary>
		public List<SubProduct> SubProducts { get; set; }

		public ProductsFull() { }

		public ProductsFull(KashFlow.ProductsFull productsFull) : base(productsFull)
		{
			SubProducts = productsFull.subProducts.Select(x => new SubProduct(x)).ToList();
		}

		public new KashFlow.ProductsFull ToData()
		{
			return new KashFlow.ProductsFull() 
			{
				ProductPrice = Price,
				ProductCode = Code,
				ProductDescription = Description,
				ManageStockLevels = AreStockLevelsManaged ? 1 : 0,
				QtyInStock = QuantityInStock,
				ProductID = ProductID,
				ProductName = Name,
				subProducts = SubProducts.Select(x => x.ToData()).ToArray()
			};
		}
	}
}
