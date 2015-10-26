using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bowling
{
     class Game
     {
          private int TotalScore = 0;
          private int[] Pins = new int[21];
          private int count = 0;
          //private int bouns = 0;
          public void SetPins(int p)
          {

               if(count==20)
               {
                    if (Pins[18] + Pins[19] >= 10)
                         Pins[count] = p;
               }
               else
               if (p == 10 && count % 2 == 0 && count!=18)
               {         
                         Pins[count] = p;
                         count += 2;

               }
               else
               {
                    Pins[count] = p;
                    count += 1;
               }
          }

          public int GetScore(int p)
          {
               return Pins[p];
          }


          public int GetFinalScore()
          {
               for (int i = 0; i < 21; i++)
               {
                    if(Pins[i])
                    TotalScore += Pins[i];
               }
               return TotalScore;
          }




     }
}
