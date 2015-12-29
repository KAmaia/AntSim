using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator {
	class Program {
		private static Simulator sim;
		static void Main( string[ ] args ) {
			sim = new Simulator( );
			sim.run( );
			Console.ReadLine();
			}
		}
	}
