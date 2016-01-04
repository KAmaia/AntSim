using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator {
	class WorldGenerator {
		private World world;
		private int passes = 1;

		//private Dictionary<CellAddress, Cell> cells;

		public WorldGenerator( ) {

		}

		//TODO: This function is going to need some help.  Right now it's just going to make a world with dirt.
		public World GenerateWorld( int upDownSize, int frontBackSize, int leftRightSize ) {
			World w = new World();
			w.ZSize = upDownSize;
			w.XSize = frontBackSize;
			w.YSize = leftRightSize;
			Cell[, , ] cells = new Cell[upDownSize,frontBackSize ,leftRightSize];
			for ( int z = 0; z < upDownSize; z++ ) {
				for ( int x = 0; x < frontBackSize; x++ ) {
					for ( int y = 0; y < leftRightSize; y++ ) {
						cells[z, x, y] = new Cell( CellType.NormalDirt, new CellAddress( x, y, z ) );
					}
				}
			}
			w.Cells = cells ;
			return w;
		}

	}
}

