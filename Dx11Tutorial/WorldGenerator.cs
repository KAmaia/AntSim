using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator {
	class WorldGenerator {
		private World world;
		private int passes = 1;

		private Cell[, ,] cells;

		public WorldGenerator( ) {

		}

		//TODO: This function is going to need some help.  Right now it's just going to make a world with dirt.
		public World GenerateWorld( ) {
			cells = generateCells( 10, 10, 10 );
			World w = new World(cells);
			return w;

		}

		//Size X: Width
		//Size Y: Depth
		//Size Z: Height
		private Cell[ ,,] generateCells( int sizeX, int sizeY, int sizeZ ) {
			cells = new Cell[sizeZ, sizeX, sizeY];
			//First fill in the Z layers
			for ( int z = 0; z < sizeZ; z++ ) {
				//Then Start at the furthest back corner
				for ( int y = 0; y < sizeY; y++ ) {
					//and fill in the row.
					for ( int x = 0; x < sizeX; x++ ) {
						Cell c = new Cell();
						c.CellType = CellType.NormalDirt;
					}
				}
			}
			return cells;
		}

	}
}
