using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ant;

namespace AntSimulator {
	//The Parent class of the ant simulation.  
	//Handles stuff(tm).
	class Simulator {

		private bool running;
		private bool paused;

		private Colony.Colony colony;

		public int Run( ) {
			int passes = 0;
			colony = new Colony.Colony( );
			running = true;
			paused = false;
			//Start the sim loop.  
			while ( running ) {
				//for right now, loop over all ants in ants and display their health.
				Tick( );
				passes++;
				Console.WriteLine( passes );
				if ( passes >= 1000 ) {
					passes = 0;
					paused = true;
				}
			}

			return 0;
		}

		private void Tick( ) {
			if ( !paused ) {
				colony.OnTick( );
			}
			else {
				Console.ReadLine( );
				paused = false;
			}
		}
	}
}
