using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Colony {
	class Colony {
		private List<Ant.Ant> ants;
		private bool alive;

		public bool Alive { get { return alive; } }
		public List<Ant.Ant> Ants { get { return ants; } }


		//Colony Constructor
		public Colony( ) {
			ants = new List<Ant.Ant>( );
			for ( int i = 0; i < 10; i++ ) {
				ants.Add( new Ant.Ant( this ) );
			}
		}


		private void GenerateAnts( ) {
			//Generate a random number of ants to populate this colony.
			//For now, not so random, we're just going to generate 1 ant.
			ants.Add( new Ant.Ant( this ) );
		}



		public void OnTick( ) {
			//Check to make sure the colony still has ants.  
			//If not, set the colony as dead.
			if ( ants.Count == 0 ) {
				alive = false;
			}
			else {
				//List of ants to remove from the queue.
				List<Ant.Ant> removeUs = new List<Ant.Ant>();
				//do Each ant level update first.
				//this means that an ant that is moving will escape any untoward
				//consequences from higher level updates.  
				foreach ( Ant.Ant a in ants ) {
					//First check to see if the ant is alive
					if ( a.Alive ) {
						a.OnTick( );

					}
					//If not move it to removeUs
					else {

						removeUs.Add( a );
					}
				}
				//And finally, remove the dead ants from ants.
				foreach ( Ant.Ant a in removeUs ) {
					Console.WriteLine( "Removing ant from ants" );
					ants.Remove( a );
				}
			}
		}
	}

}
