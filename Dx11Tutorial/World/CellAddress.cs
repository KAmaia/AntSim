using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator {
	class CellAddress {
		private int x;
		private int y;
		private int z;

		public int X { get {return x;} }
		public int Y { get { return y; } }
		public int Z { get { return z; } }

		public CellAddress(int x, int y, int z ) {
			this.x = x;
			this.y = y;
			this.z = z;
		}
	}
}
