using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AntSimulator.Ants {
	class Colony {
		private List<Ant> ants;
		private bool alive;
		private World world;
		private  ColonyMind colonyMind;

		public bool Alive { get { return alive; } }
		public List<Ant> Ants { get { return ants; } }

		public World World { get { return world; } }

		public static float Food { get; internal set; }
		public static float Space { get; internal set; }
		public static float Eggs { get; internal set; }


		//Colony Constructor
		public Colony(ref World w ) {
			world = w;
			colonyMind = new ColonyMind( this );
			alive = true;
			ants = new List<Ant>( );
			GenerateAnts( );

		}


		private void GenerateAnts( ) {
			Console.WriteLine( "Generating Ants!" );
			//Generate a random number of ants to populate this colony.
			//For now, not so random, we're just going to generate 10 ants.
			for ( int i = 0; i < 10; i++ ) {
				Console.WriteLine( "Adding Ant {0} of 10", i );
				ants.Add( new Ant( this ) );
			}
		}



		public void OnTick( ) {
			alive = ants.Count > 0;
			//List of ants to remove from the queue.
			List<Ant> removeUs = new List<Ant>();
			//do Each ant level update first.
			//this means that an ant that is moving will escape any untoward
			//consequences from higher level updates.  
			foreach ( Ant a in ants ) {
				//First check to see if the ant is alive
				if ( a.Alive ) {
					a.OnTick(  );

				}
				//If not move it to removeUs
				else {

					removeUs.Add( a );
				}
			}
			//And finally, remove the dead ants from ants.
			foreach ( Ant a in removeUs ) {
				Console.WriteLine( "Removing ant from ants" );
				ants.Remove( a );
			}
		}
	}
}


