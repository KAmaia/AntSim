using System;
using System.Collections.Generic;
using System.Linq;

using AntSimulator.Tasks;

namespace AntSimulator.Ants {
	class ColonyMind {
		private Colony colony;
		private float desiredColonyFood;
		private float desiredColonySpace;
		private float desiredColonyEggs;
		private float desiredColonyEggStatus;

		private List<ColonyTask> availableTasks;
		private List<AntMind> AntMinds;

		public ColonyMind( Colony c ) {
			colony = c;
		}

		//TODO: Replace this method with a better one.  But first, we need to get job creation going, and actually figure out how to prioritze stuff.
		public void OnTick( ) {




			//FOR NOW...A simple decision tree.
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


		/// <summary>
		/// Handles task assignments.  
		/// first it loops over tasks until it finds one !InProcess
		/// then it looks for an idle AntMind to assign the task to.
		/// The AntMind then either accepts or rejects the task(not implemented), toggling inProcess to true if the task is accepted.  
		/// </summary>
		private void HandleJobAssignation( ) {
			//TODO: Clean this up a bit with LINQ.  
			//TODO: Learn LINQ
			//find each task that is not in process
			foreach ( ColonyTask task in availableTasks ) {
				//find each task that is not in process
				if ( task.InProcess ) {
					continue;
				}
				else {
					//find the first ant that is idle
					foreach ( AntMind am in AntMinds ) {
						if ( am.Idle ) {
							am.AddColonyTask( task );
							break;
						}
					}
				}
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