using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsUnlimited.Models
// un cambio cualquiera
{
	public interface ILineItem
	{
		int Count { get; }

		Product Product { get; }
		//  este es OTRO cambio para GitHub desde start stages
		// este es un cambio mas
		// Y otro cmabio mas asi que deben ser ya 3 hasta aqui.
		// y ahora el cuarto y ultimo cambio..
	}
}
