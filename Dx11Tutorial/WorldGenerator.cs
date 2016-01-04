using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator {
	class WorldGenerator {
		private World world;
		private int passes = 1;

		private Dictionary<CellAddress, Cell> cells;

		public WorldGenerator( ) {

		}

		//TODO: This function is going to need some help.  Right now it's just going to make a world with dirt.
		public World GenerateWorld( ) {
			cells = new Dictionary<CellAddress, Cell>( );
			World w = new World(cells);
			return w;

		}

		//Size X: Width
		//Size Y: Depth
		//Size Z: Height
		private void generateCells( int sizeX, int sizeY, int sizeZ ) {
			//First fill in the Z layers
			for ( int z = 0; z < sizeZ; z++ ) {
				for ( int y = 0; y < sizeY; y++ ) {
					for ( int x = 0; x < sizeX; x++ ) {
						CellAddress address = new CellAddress(x,y,z);
						cells.Add( address, new Cell( CellType.NormalDirt, address ) );
					}
				}
			}
		}
	}

}

