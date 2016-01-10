using System;
using System.Collections.Generic;

namespace AntSimulator.Ants {
	class ColonyMind {
		private Colony colony;
		private float desiredColonyFood;
		private float desiredColonySpace;
		private float desiredColonyEggs;
		private float desiredColonyEggStatus;

		private List<Job> AvailableJobs;
		private List<AntMind> AntMinds;

		public ColonyMind( Colony c ) {
			colony = c;
		}


		public void OnTick( ) {
			if ( Colony.Food < desiredColonyFood ) {
				CreateNewFoodJob( );
			}
			if ( Colony.Space < desiredColonySpace ) {
				CreateNewDigJob( );
			}
			if ( Colony.Eggs < desiredColonyEggs ) {
				CreateNewEggJob( );
			}
			HandleJobAssignation( );

		}

		private void HandleJobAssignation( ) {
			int checks = 0;
			int desiredChecks = 3;
			while ( checks <= desiredChecks ) {
				if ( AvailableJobs.Count == 0 ) {
					foreach ( AntMind am in AntMinds ) {
						if ( am.Idle ) {
							am.CurrentJob = AvailableJobs[0];
							AvailableJobs.RemoveAt( 0 );
						}
					}
				}
				else {
					break;
				}
				checks++;
			}
		}



		private void CreateNewEggJob( ) {
			throw new NotImplementedException( );
		}

		private void CreateNewDigJob( ) {
			throw new NotImplementedException( );
		}

		private void CreateNewFoodJob( ) {
			throw new NotImplementedException( );
		}


	}
}