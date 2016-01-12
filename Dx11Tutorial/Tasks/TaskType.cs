using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator.Tasks {
	class TaskType {

		public static TaskType DIG_TASK { get; } = new TaskType( );
		public static TaskType EAT_TASK { get; } = new TaskType( );


		private TaskType( ) {
		}
	}
}
