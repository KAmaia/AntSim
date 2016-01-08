using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AntSimulator.Ants;

namespace AntSimulator {

	class World {                             
		private List<Colony> colonies;                         //A list to hold our colonies.
		private bool alive;                                    //Is the World Alive?  (If no colonies, then NO!)
		private Cell[ ,,] cells;                               //Our Cells.  The things that make up the world.

		private int xSize;				//Size from Front to Back
		private int ySize;				//Size from Left to Right
		private int zSize;				//Size from Top to Bottom

		public bool Alive { get { return alive; } }
		public List<Colony> Colonies { get { return colonies; } }
		public Cell[ ,,] Cells { get { return cells; }set { cells = value; } }

		public int ZSize { get { return zSize; } set { zSize = value; } }
		public int XSize { get { return xSize; } set { xSize = value; } }
		public int YSize { get { return ySize; } set { ySize = value; } }


		/// <summary>
		/// World Constructor
		/// </summary>
		/// 
		public World( ) {
			colonies = new List<Colony>( );
		}

		/// <summary>
		/// Update the world.  
		/// </summary>
		/// <param name="delta">Time that has passed since the last tick</param>
		public void OnTick( ) {

			alive = colonies.Count > 0;                       //Check to see if we still have colonies.
			List<Colony> removeUs = new List<Colony>();       //List for Colonies that have died, and need to be removed.

			foreach ( Colony c in colonies ) {                //Check to see if each colony is alive, if so, tell it to Tick;

				if ( c.Alive ) {
					c.OnTick();
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






