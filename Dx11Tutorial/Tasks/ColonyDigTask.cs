using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntSimulator.Ants;

namespace AntSimulator.Tasks {
	class ColonyDigTask : ColonyTask {

		private float size;


		public float Size { get { return size; } }

		public ColonyDigTask(float size) {

		}

		public override void giveToAntMind( AntMind am ) {
			throw new NotImplementedException( );
		}
	}
}
