using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AntSimulator.Utilities;

namespace AntSimulator {
	class Cell {
		private CellType cellType;		//So, all the pertinent information is stored in the CellType class.  Makes dealing with Cells easier.
		private CellAddress cellAddress;	//This Cell's Address.  Just in Case.

		public CellType CellType { get { return cellType; } set { cellType = value; } }
		public CellAddress CellAddress { get { return cellAddress; } }

		public Cell(CellType t, CellAddress a) {
			cellAddress = a;
			cellType = t;
		}
	}
}
