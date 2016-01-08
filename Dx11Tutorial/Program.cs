using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator {
	class Program {
		private static Simulator sim;
		static void Main( string[ ] args ) {
			//Start the Simulator.
			sim = new Simulator( );
			sim.Run();

			

			//Everything is done running.  Pause until the user hits a key.  
			//This will go away with graphics.
			Console.WriteLine( "Press Any Key To Exit" );
			Console.ReadLine( );
		}
	}
}
