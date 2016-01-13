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
			this.type = TaskType.DIG_TASK;
			this.size = size;
		}
		public void ToggleInProcess( ) {
			inProcess = !inProcess;
		}
		
	}
}
