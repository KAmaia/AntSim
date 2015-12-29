using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant {
	class Ant {
		private float hunger;
		private float health;

		public float Hunger { get { return hunger; } }
		public float Health { get { return health; } }

		public Ant( ) {
			health = 1.0f;
			hunger = 0.0f;
			}
		}
	}
