using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEvents
{
	class BallEventArgs : EventArgs
	{
		public int Angle { get; private set; }
		public int Distance { get; private set; }

		public BallEventArgs(int angle, int distance)
		{ 
			this.Angle = angle;
			this.Distance = distance;
		}

	}
}
