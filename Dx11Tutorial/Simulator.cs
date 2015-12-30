using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator {
	//The Parent class of the ant simulation.  
	//Handles stuff(tm).
	class Simulator {

		private bool running;
		private bool paused;

		private World world;

		public int Run( ) {			
			int passes = 0;
			world = new World();
			running = true;
			paused = false;
			//Start the sim loop.  
			while ( running ) {
				Tick( );
				passes++;
				Console.WriteLine( passes );
				if ( passes >= 100 ) {
					passes = 0;
					paused = true;
				}
			}

			return 0;
		}

		private void Tick( ) {
			if ( !paused ) {
				world.OnTick( );
			}
			else {
				Console.WriteLine( "Sim Paused, press a key to continue" );
				Console.ReadLine( );
				paused = false;
			}
		}
	}
}
