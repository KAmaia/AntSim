using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator.Utilities {
	class CellAddress {
		private int x;
		private int y;
		private int z;

		public int X { get { return x; } }
		public int Y { get { return y; } }
		public int Z { get { return z; } }
		
		/// <summary>
		/// Cell address expressed as Z address, X address, Y address.
		/// </summary>
		/// <param name="z"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public CellAddress( int z, int x, int y ) {
			this.x = x;
			this.y = y;
			this.z = z;
		}

		
	}
}
