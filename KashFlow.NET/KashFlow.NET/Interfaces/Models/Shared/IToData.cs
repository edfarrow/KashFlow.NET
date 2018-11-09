using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow.NET.Interfaces.Models.Shared
{
	/// <summary>
	/// Provides a conversion interface to a data class of type T
	/// </summary>
	/// <typeparam name="T">The type of data to produce</typeparam>
	public interface IToData<T>
	{
		/// <summary>
		/// Transforms to a concrete <see cref="T">KashFlow class</see>
		/// </summary>
		/// <returns><see cref="T"/></returns>
		T ToData();
	}
}
