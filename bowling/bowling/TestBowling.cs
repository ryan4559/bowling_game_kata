using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling
{
    [TestFixture]
    public class TestBowling
    {
        [Test]
        public void AllZero()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
            {
                g.SetPins(0);
            }
            Assert.That(g.GetFinalScore(), Is.EqualTo(0));
        }
        [Test]
        public void TestScore()
        {
             Game g = new Game();
             for (int i = 0; i < 20; i+=2)
             {
                  g.SetPins(10);
             }
             Assert.That(g.GetScore(0), Is.EqualTo(10));
             Assert.That(g.GetScore(1), Is.EqualTo(0));

             Assert.That(g.GetScore(18), Is.EqualTo(10));
             Assert.That(g.GetScore(19), Is.EqualTo(0));

      
        }
        [Test]
        public void TestGetFinalScore()
        {
             Game g = new Game();
             for (int i = 0; i < 20; i += 2)
             {
                  g.SetPins(10);
             }

             Assert.That(g.GetFinalScore(), Is.EqualTo(100));

        }
        //[Test]
        //public void Strike()
        //{
        //     Game g = new Game();
        //     for (int i = 0; i < 20; i += 2)
        //     {
        //          g.SetPins(10);
        //     }
        //     g.SetPins(10);

        //     Assert.That(g.GetFinalScore(), Is.EqualTo(300));


        //}



    }
}
