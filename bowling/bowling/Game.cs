using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bowling
{
     class Game
     {
          private int TotalScore = 0;
          private int[] Pins = new int[20] ;
          public void SetPins(int p)
          {
               TotalScore += p;
          }
      //    private int count;
       /*   public void SetPins(int p)
          {
              
                    if(p==10 && i%2==0)
                    {
                         Pins[i] = p;
                         i += 2;
                      
                    }
                    else
                    {
                         Pins[i] = p;
                    }
               
          }*/

          public int GetScore(int p)
          {
               return Pins[p];
          }

          public int GetFinalScore()
          {
               return TotalScore;
          }


      

     }
}
