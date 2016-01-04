using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator {
	class Ant {
		private float hunger;	//Huger grows from 0 to 1.0.  When it hits 1.0f ant starts taking damage.
		private float health;	//Health starts at 1.0f and is reduced to 0.0f, ant dies.
		private bool alive;		//Pretty self commenting.  Is the ant Alive?
		private Colony colony;	//The colony that owns the Ant

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
			alive = true;
			health = 1.0f; //Set health to 100%
			hunger = 0.0f; //Set hunger to 0%

		}
		/// <summary>
		/// Handles Sim Ticks()
		/// </summary>
		/// <param name="delta">The amount of time that has passed since the last update.</param>
		public void OnTick( long delta ) {
			AddHunger( );
			alive = health > 0;

			//Debug text message to print.
			String tickMessage = this.ToString() + " is Ticking\nHunger=" + hunger + "\nHealth=" + health +"\n";

			Console.Write( tickMessage );

		}
		/// <summary>
		/// Add's .001 to ant's hunger level.
		/// </summary>
		private void AddHunger( ) {
			hunger += 0.001f;
			//if hunger is 100% or greater, leave it 100%
			//and subtract health.
			if ( hunger >= 1.0f ) {
				hunger = 1.0f;
				health -= .001f;
			}
		}
	}
}
