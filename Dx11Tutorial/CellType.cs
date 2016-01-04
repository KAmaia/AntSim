using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator {
	class CellType {
		//static cell types.  Gonna have to play with this.


		public static CellType Air { get; } = new CellType( true, false, 0.0f, "Air" );
		public static CellType LightDirt { get; } = new CellType( false, true, 25.0f, "Loose Dirt" );
		public static CellType NormalDirt { get; } = new CellType( false, true, 50.0f, "Normal Dirt" );
		public static CellType HeavyDirt { get; } = new CellType( false, true, 100.0f, "Thick Dirt" );
		public static CellType Tunnel { get; } = new CellType( true, false, 0.0f, "Tunnel" );

		private bool passable;                  //Can we pass through this cell?
		private bool diggable;                  //Can we dig this cell?
		private float density;                  //Number of particles in the cell.  (Used for digging).
		private string cellTypeString;          //Used for debugging purposes.  We can remove this later.

		private const float volume = 1.0f;      //1.0 cm^3 This never changes, and may actually never be used.




		public bool Diggable { get { return diggable; } }
		public bool Passable { get { return passable; } }
		public float Density { get { return density; } }

		public string CellTypeString { get { return cellTypeString; } }



		private CellType( bool passable, bool diggable, float density, string cellTypeString ) {
			this.passable = passable;
			this.diggable = diggable;
			this.density = density;
			this.cellTypeString = cellTypeString;

		}
	}
}
