using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator.Utilities {
	class BoundsChecker {
		public static bool check3dBounds(CellAddress a, Tuple<int, int, int> sizesZXY ) {
			
			return ( a.Z >= 0 && a.Z < sizesZXY.Item1 && a.X >= 0 && a.X < sizesZXY.Item2 && a.Y >= 0 && a.Y < sizesZXY.Item3 );
		}

		public static bool check2dBounds(int y, int x, Tuple<int, int> sizeYX ) {
			return ( y >= 0 && y < sizeYX.Item1 && x >= 0 && x < sizeYX.Item2 );
		}
	}
}
