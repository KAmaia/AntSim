using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator {

	class World {
		private Dictionary<CellAddress, Cell> cells;							//Our Cells.  The things that make up the world.
		private List<Colony> colonies;					//A list to hold our colonies.
		private bool alive;								//Is the World Alive?  (If no colonies, then NO!)

		public bool Alive { get { return alive; } }
		public List<Colony> Colonies { get { return colonies; } }
		public Dictionary<CellAddress,Cell> Cells { get { return cells; } }

		/// <summary>
		/// World Constructor.
		/// </summary>
		/// <param name="cells">The Dictionary Created By Our World Generator</param>
		public World( Dictionary<CellAddress, Cell> cells ) {
			this.cells = cells;
			colonies = new List<Colony>( );
			colonies.Add( new Colony( ) );
		}

		/// <summary>
		/// Update the world.  
		/// </summary>
		/// <param name="delta">Time that has passed since the last tick</param>
		public void OnTick( long delta ) {
			
			alive = colonies.Count > 0;					//Check to see if we still have colonies.
			List<Colony> removeUs = new List<Colony>();       //List for Colonies that have died, and need to be removed.

			foreach ( Colony c in colonies ) {                //Check to see if each colony is alive, if so, tell it to Tick;

				if ( c.Alive ) {
					c.OnTick( delta );
				}
				else {
					removeUs.Add( c );                      //if the colony isn't alive, add it to Remove Us

				}
			}
			foreach ( Colony c in removeUs ) {
				colonies.Remove( c );                        //finally remove each dead colony from the world.

			}
		}
	}






}