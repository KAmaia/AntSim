using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntSimulator.Ants;

namespace AntSimulator.Tasks {
	abstract class ColonyTask : ITask {

		protected TaskType type;           //The type of task this is.
		protected bool inProcess;          //Is This Job In Process.
		private bool assigned;             //Is this task assigned to an ant?

		public TaskType Type { get { return type; } }
		public bool InProcess { get { return inProcess; } }
		public bool Assigned { get { return assigned; } set { assigned = value; } }
	}

}
