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
		public Cell[ ,,] Cells { get { return cells; } }

		internal World( Cell[ ,,] cells ) {
			this.cells = cells;
			colonies = new List<Colony>( );
			colonies.Add( new Colony( ) );
		}

		public void OnTick( long delta ) {
			//Check to see if we still have colonies.
			//If not, world dies.
			alive = colonies.Count > 0;


			//List for Colonies that have died, and need to be removed.
			List<Colony> removeUs = new List<Colony>();

			//Check to see if each colony is alive,
			//if so, tell it to Tick;
			foreach ( Colony c in colonies ) {
				if ( c.Alive ) {
					c.OnTick( delta );
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






}