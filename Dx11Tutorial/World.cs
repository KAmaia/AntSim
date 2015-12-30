using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator {

	class World {
		private List<Colony> colonies;
		private bool alive;

		public bool Alive { get { return alive; } }
		public List<Colony> Colonies { get { return colonies; } }

		public World( ) {
			colonies = new List<Colony>( );
			colonies.Add( new Colony( ) );
		}

		public void OnTick( ) {
			//Check to see if we still have colonies.
			//If not, world dies.
			alive = colonies.Count > 0;


			//List for Colonies that have died, and need to be removed.
			List<Colony> removeUs = new List<Colony>();

			//Check to see if each colony is alive, if not add it to remove us.
			foreach ( Colony c in colonies ) {
				if ( !c.Alive ) {
					removeUs.Add( c );
				}
				//if the colony is still alive, tell it to Tick.
				else {
					c.OnTick( );
				}
			}
			//finally remove each dead colony from colonies.
			foreach ( Colony c in removeUs ) {
				colonies.Remove( c );
			}
		}
	}
}

