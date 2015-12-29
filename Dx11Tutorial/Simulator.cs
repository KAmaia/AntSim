using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ant;

namespace AntSimulator {
	class Simulator {

		private bool running;
		private List<Ant.Ant> ants;
		public int run( ) {
			ants = new List<Ant.Ant>();
			running = true;
			while ( running ) {

				generateAnts( );
				foreach (Ant.Ant ant in ants ) {
					Console.WriteLine( ant.Health );

					}
				running = false;
				}

			return 0;
			}

		private void generateAnts( ) {
			ants.Add( new Ant.Ant( ) );
			}
		}
	}
