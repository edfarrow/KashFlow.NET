using System;
using System.Collections.Generic;
using System.Text;

namespace KashFlow_NET.Models.Shared
{
	/// <summary>
	/// If the currency symbol is specified to appear before monetary values then “Left”, else if specified to appear after monetary values then “Right”
	/// </summary>
	public enum CurrencyPositionType
	{
		/// <summary>
		/// Currency symbol shown before monetary value
		/// </summary>
		Left,

		/// <summary>
		/// Currency symbol shown after monetary value
		/// </summary>
		Right
	}
}
