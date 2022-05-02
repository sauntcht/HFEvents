using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEvents
{
	class Pitcher
	{
		public Pitcher(Ball ball) => ball.BallInPlay += BallInPlayEventHandler;
		private int pitchNumber = 0;
		
		 void BallInPlayEventHandler(object sender, BallEventArgs e)
		 {
			pitchNumber++;
			
			
				if (e.Distance < 95 && e.Angle < 60)
					Console.WriteLine($"Pitch #{pitchNumber}: I caught the ball");
				else
					Console.WriteLine($"Pitch #{pitchNumber}: I covered first base");
			
		 }
		
	}
}
