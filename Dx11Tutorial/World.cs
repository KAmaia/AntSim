using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator {

	class World {
		private Cell[,,] cells;
		private List<Colony> colonies;
		private bool alive;

		public bool Alive { get { return alive; } }
		public List<Colony> Colonies { get { return colonies; } }
		public Cell[,,] Cells { get { return cells; } }

		internal World(Cell[,,]cells ) {
			this.cells = cells;
			colonies = new List<Colony>( );
			colonies.Add( new Colony( ) );
		}

		public void OnTick( long delta) {
			//Check to see if we still have colonies.
			//If not, world dies.
			alive = colonies.Count > 0;


			//List for Colonies that have died, and need to be removed.
			List<Colony> removeUs = new List<Colony>();

			//Check to see if each colony is alive,
			//if so, tell it to Tick;
			foreach ( Colony c in colonies ) {
				if ( c.Alive ) {
					c.OnTick( delta);
				}
				//if the colony isn't alive, add it to Remove Us
				else {
					removeUs.Add( c );
				}
			}
			//finally remove each dead colony from colonies.
			foreach ( Colony c in removeUs ) {
				colonies.Remove( c );
			}
		}
	}

	class WorldGenerator {
		private World world;
		private int maxColonies = 1;
		private int passes = 1;

		private Cell[, ,] cells;

		public WorldGenerator( ) {

		}

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
						c.CellType = CellType.Dirt;
					}
				}
			}
			return cells;
		}

	}

	class Cell {
		private CellType cellType;
		public CellType CellType { get { return cellType; } set { cellType = value; } }

	}

	class CellType {
		//static cell types.  Gonna have to play with this.


		public static CellType Air { get; } = new CellType( true, false, 1.0f, "Air" );
		public static CellType Dirt { get; } = new CellType( false, true, 0.0f, "Dirt" );
		public static CellType Tunnel { get; } = new CellType( true, false, 0.0f, "Tunnel" );

		private bool passable;
		private bool diggable;
		private float speedmod;
		private string cellTypeString;
		private Tuple<int, int, int> address;

		public bool Diggable { get { return diggable; } }
		public bool Passable { get { return passable; } }
		public float SpeedMod { get { return speedmod; } }
		public string CellTypeString { get { return cellTypeString; } }
		public Tuple<int, int, int> Address {
			get { return address; }
			set { address = value; }
		}

		private CellType( bool passable, bool diggable, float speedmod, string cellTypeString ) {
			this.passable = passable;
			this.diggable = diggable;
			this.speedmod = speedmod;
			this.cellTypeString = cellTypeString;

		}
	}
}