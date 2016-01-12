using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntSimulator.Ants;

namespace AntSimulator.Tasks {
	abstract class ColonyTask : ITask {

		private TaskType type;          //The type of task this is.
		private bool inProcess;       //Is This Job In Process.

		public TaskType Type { get { return type; } }
		public bool InProcess { get { return inProcess; } set { inProcess = value; }}
		

		public abstract void giveToAntMind( AntMind am );
	}

}
