using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsUnlimited.Models
{
	public interface ILineItem
	{
		int Count { get; }

		Product Product { get; }
		//  este es OTRO cambio para GitHub desde start stages
	}
}
