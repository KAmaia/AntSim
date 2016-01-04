using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator {
	class Cell {
		private CellAddress address;
		private CellType cellType; //So, all the pertinent information is stored in the CellType class.  Makes dealing with Cells easier.

		public CellAddress Address { get { return address; } }
		public CellType CellType { get { return cellType; } set { cellType = value; } }


		public Cell(CellType t, CellAddress a ) {
			address = a;
			cellType = t;
		}
	}
}
