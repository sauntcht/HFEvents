using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEvents
{
	class Ball
	{
		public event EventHandler<BallEventArgs> BallInPlay;

		public void OnBallInPlay(BallEventArgs e) => BallInPlay?.Invoke(this, e);

	}
}
