using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant {
	class Ant {
		private float hunger;
		private float health;
		private bool alive;
		private Colony.Colony colony;

		public float Hunger { get { return hunger; } }
		public float Health { get { return health; } }
		public bool Alive { get { return alive; } }

		public Colony.Colony Colony { get { return colony; } }


		/// <summary>
		/// Ant Constructor.
		/// </summary>
		/// <param name="colony"> The Colony that owns this ant</param>
		public Ant( Colony.Colony colony ) {
			this.colony = colony;
			alive = true;
			health = 1.0f;
			hunger = 0.0f;

		}
		public void OnTick( ) {
			AddHunger( );
			alive = health > 0;

			String tickMessage = this.ToString() + " is Ticking\nHunger=" + hunger + "\nHealth=" + health +"\n";
			Console.Write( tickMessage );

		}
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
