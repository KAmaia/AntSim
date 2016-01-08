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

		public Simulator(  ) {
		
		}

		public int Run( ) {

			Stopwatch sw = new Stopwatch();
		

			//How many passes did the simulation make.  (Should rename to Ticks(), however, as it's just a variable I haven't.
			int passes = 0;

			//Skip instantiating a new world and GenerateWorld() instead.
			world = new WorldGenerator( ).GenerateWorld( 10, 10, 10 );

			//Is the system running, why yes, yes it is.  No, it's not paused either.
			running = true;
			paused = false;

			//start delta time at 0
			long delta = 0;
			//get the current timestamp, pre-gameloop
			long lastTime = sw.ElapsedMilliseconds;
			double desiredTPS = 1 / 60; 
			sw.Start( );
			//Start the sim loop.  
			while ( running ) {
				//get a new timestamp for when we re/start the loop
				long now = sw.ElapsedMilliseconds;
				//delta time equals now minus last time
				delta = ( now - lastTime ) / 1000;
				//we've made a pass, increment passes.
				passes++;
				//debug only.  Writing delta time to console.
				
				Console.WriteLine( delta );

				//Ahh C# made something easy!  
				//Check if the user has hit a key if so, pass that to HandleInput()
				if ( Console.KeyAvailable ) {
					HandleInput( Console.ReadKey( ) );

				}

				//Lock tick rate to 60 tps.
				if(delta >= 1 / desiredTPS ) { }
				//pass a reference to delta into Tick();
				Tick(  );

				//TODO: Add a renderer of some kind and render here.

				//update last time to the time we're exiting the loop.
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
		///		->foreach(colony c in colonies){c.onTick();}
		/// </summary>
		/// <param name="delta">delta time between frames in millis</param>
		private void Tick(  ) {
			if ( !paused ) {
				world.OnTick(  );

			}
			else {
				//TODO: Display Menu here
			}
		}

		/// <summary>
		/// Handles user input.
		/// </summary>
		/// <param name="input">ConsoleKeyInfo corresponding to user key press</param>
		private void HandleInput( ConsoleKeyInfo input ) {

			switch ( input.Key ) {
				case ConsoleKey.Spacebar:
					TogglePaused( );
					break;
				case ConsoleKey.Escape:
					running = false;
					break;
			}

		}

		private void TogglePaused( ) {
			paused = !paused;
		}
	}
}
