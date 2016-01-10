using System;

namespace AntSimulator.Ants {
	internal class AntMind {
		private bool idle;
		private Job currentJob;

		public Job CurrentJob { get { return currentJob; } set { currentJob = value; } }
		public bool Idle { get { return idle; } }

		

		
	}
}