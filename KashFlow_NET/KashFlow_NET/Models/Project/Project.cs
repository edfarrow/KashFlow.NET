using KashFlow_NET.Interfaces.Models.Shared;
using KashFlow_NET.Models.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow_NET.Models.Project
{
	public class Project : KashFlowBase<KashFlow.Project>, IToData<KashFlow.Project>
	{
		/// <summary>
		/// System-wide unique number for this Project
		/// </summary>
		public int ProjectID { get; private set; }

		/// <summary>
		/// The Project number
		/// </summary>
		public int Number { get; set; }

		/// <summary>
		/// The Project name
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The reference for this project
		/// </summary>
		public string Reference { get; set; }

		/// <summary>
		/// The long description for this project
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Project start date
		/// </summary>
		public DateTime StartDate { get; set; }

		/// <summary>
		/// Project end date
		/// </summary>
		public DateTime EndDate { get; set; }

		/// <summary>
		/// The customer to which this Project is assigned
		/// </summary>
		public int? CustomerID { get; set; }

		/// <summary>
		/// The status of the project
		/// </summary>
		public ProjectStatus Status { get; set; }


		public Project() { }

		public Project(KashFlow.Project project)
		{
			ProjectID = project.ID;
			Number = project.Number;
			Name = project.Name;
			Reference = project.Reference;
			Description = project.Description;
			StartDate = project.Date1;
			EndDate = project.Date2;
			CustomerID = project.CustomerID > 1 ? (int?)project.CustomerID : null;
			Status = (ProjectStatus)project.Status;
		}

		public KashFlow.Project ToData()
		{
			return new KashFlow.Project() 
			{
				ID = ProjectID,
				Number = Number,
				Name = Name,
				Reference = Reference,
				Description = Description,
				Date1 = StartDate,
				Date2 = EndDate,
				CustomerID = CustomerID ?? 0,
				Status = (int)Status
			};
		}
	}
}
