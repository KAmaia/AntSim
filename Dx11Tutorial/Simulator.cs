using System;
using System.Diagnostics;
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
			world = new WorldGenerator( ).GenerateWorld( );
			running = true;
			paused = false;
		
			long delta = 0;
			long lastTime = Stopwatch.GetTimestamp();
			//Start the sim loop.  
			while ( running ) {
				long now = Stopwatch.GetTimestamp();
				delta += ( now - lastTime );
				Tick(delta );
				passes++;
				Console.WriteLine( passes );
				if ( passes >= 100 ) {
					passes = 0;
					paused = true;
				}
				lastTime = now;
			}

			return 0;
		}

		private void Tick(long delta) {
			if ( !paused ) {
				world.OnTick(delta );
			}
			else {
				Console.WriteLine( "Sim Paused, press a key to continue" );
				Console.ReadLine( );
				paused = false;
			}
		}
	}
}
