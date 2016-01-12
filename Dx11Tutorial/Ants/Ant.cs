using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AntSimulator.Utilities;
using AntSimulator.Pheromones;

namespace AntSimulator.Ants {
	class Ant {
		private float hunger;              //Huger grows from 0 to 1.0.  When it hits 1.0f ant starts taking damage.
		private float health;              //Health starts at 1.0f and is reduced to 0.0f, ant dies.
		private bool alive;                //Pretty self commenting.  Is the ant Alive?
		private Colony colony;             //The colony that owns the Ant
		private World world;               //Reference to the world.
		private CellAddress currAddress;   //The address this ant is currently at.
		private AntMind am;                //Yay, the ant has a mind!

		public float Hunger { get { return hunger; } }
		public float Health { get { return health; } }
		public bool Alive { get { return alive; } }

		public Colony Colony { get { return colony; } }

		/// <summary>
		/// Ant Constructor.
		/// </summary>
		/// <param name="colony"> The Colony that owns this ant</param>
		public Ant( Colony colony ) {
			this.colony = colony;
			world = colony.World;
			alive = true;
			health = 1.0f; //Set health to 100%
			hunger = 0.0f; //Set hunger to 0%
			am = new AntMind( this );
		}
		/// <summary>
		/// Handles Sim Ticks
		/// </summary>
		/// <param name="delta">The amount of time that has passed since the last update.</param>
		public void OnTick( ) {
			AddHunger( );
			alive = health > 0;
			/*
			//Debug text message to print.
			String tickMessage = this.ToString() + " is Ticking\nHunger=" + hunger + "\nHealth=" + health +"\n";

			Console.Write( tickMessage );
			*/
			am.OnTick( );
		}
		/// <summary>
		/// Add's .001 to ant's hunger level.
		/// </summary>
		private void AddHunger( ) {
			hunger += 0.001f;
			//if hunger is 100% or greater, leave it 100%
			//and subtract health.
			if ( hunger >= 1.0f ) {
				/*hunger = 1.0f;
				health -= .001f;
				*/
				Eat( );
			}
		}
		/// <summary>
		/// Feeds the ant
		/// </summary>
		private void Eat( ) {
			hunger -= .001f;
		}
		/// <summary>
		/// digs a cell
		/// </summary>
		/// <param name="a">The address of the cell to dig.</param>
		private void DigCell( CellAddress a ) {
			//first check to see if a is a valid cell
			Utilities.BoundsChecker.check3dBounds( a, new Tuple<int, int, int>( world.ZSize, world.XSize, world.YSize ) );


		}
		private void LayPharomone( CellAddress a, Pheromone p ) {

		}
	}
}

