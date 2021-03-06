﻿using KashFlow_NET.Interfaces.Models.Shared;

namespace KashFlow_NET.Models.Shared
{
	/// <summary>
	/// This class is used by a number of functions to return sets of id numbers, names, descriptions and values
	/// </summary>
	public class BasicDataSet : KashFlowBase<KashFlow.BasicDataset>, IToData<KashFlow.BasicDataset>
	{
		public int ID { get; set; }
		
		public string Name { get; set; }

		public string Description { get; set; }

		public decimal Value { get; set; }

		public BasicDataSet() : base(){ }

		public BasicDataSet(KashFlow.BasicDataset basicDataset) : base(basicDataset)
		{
			ID = basicDataset.ID;
			Name = basicDataset.Name;
			Description = basicDataset.Description;
			Value = basicDataset.Value;
		}

		public KashFlow.BasicDataset ToData()
		{
			return new KashFlow.BasicDataset()
			{
				ID = ID,
				Value = Value,
				Description = Description,
				Name = Name
			};
		}
	}
}
