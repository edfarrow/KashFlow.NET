using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow_NET.Models.Shared
{
	/// <summary>
	/// Base class for KashFlow_NET models
	/// </summary>
	/// <typeparam name="T">Data type to accept in constructor</typeparam>
	public abstract class KashFlowBase<T>
	{
		public KashFlowBase() { }
		public KashFlowBase(T data) { }
	}
}
