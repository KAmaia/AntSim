using System;
using System.Collections.Generic;

using AntSimulator.Tasks;


namespace AntSimulator.Ants {
	internal class AntMind {
		private bool idle;

		private bool hasColonyTask;
		private ColonyTask currentColonyTask; //I might not use this.

		private ITask currentJob;
		private Ant ant;

		public ITask CurrentJob { get { return currentJob; } }
		public bool Idle { get { return idle; } }

		public Ant Ant { get { return ant; } set { ant = value; } }

		public AntMind( Ant a ) {
			ant = a;
			currentJob = null;
		}

		public void OnTick( ) {
			//Make the ant do stuff here.
		}
		public void AddColonyTask( ColonyTask task ) {
			throw new NotImplementedException( );
		}
	}
}