namespace AntSimulator.Ants {
	class Job {
		private bool complete;
		private float workNeeded;
		private float workDone;

		public float WorkDone { get { return workDone; } }
		public bool Complete { get { return workDone >= workNeeded; } }

	}
}