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
			//start delta time at 0
			long delta = 0;
			//get the current timestamp, pre-gameloop
			long lastTime = Stopwatch.GetTimestamp();
			//Start the sim loop.  
			while ( running ) {
				//get a new timestamp for when we re/start the loop
				long now = Stopwatch.GetTimestamp();
				//delta time equals now minus last time
				delta = ( now - lastTime );
				//pass a reference to delta into Tick();
				Tick( ref delta );
				passes++;
				Console.WriteLine( delta );
				if ( Console.KeyAvailable ) {
					HandleInput( Console.ReadKey( ) );	
					
				}
				lastTime = now;
			}

			return 0;
		}

		/// <summary>
		/// Where all the updates happen.  
		/// Updates happen in order of:
		/// -Ants
		/// --Colonies
		/// ---World
		/// </summary>
		/// <param name="delta">delta time between frames in millis</param>
		private void Tick( ref long delta ) {
			if ( !paused ) {
				world.OnTick( delta );

			}
			else {
				Console.WriteLine( "Sim Paused, press a key to continue" );
				Console.ReadLine( );
				paused = false;
			}
		}
		/// <summary>
		/// Handles user input.
		/// </summary>
		/// <param name="input">ConsoleKeyInfo corresponding to user key press</param>
		private void HandleInput(ConsoleKeyInfo input ) {
			switch ( input.Key ) {
				case ConsoleKey.Escape:
					running = false;
					break;
			}
		}
	}
}
