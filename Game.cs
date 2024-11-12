// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        
        Fruit orange = new Fruit();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Monkey Jump");

            

            orange.Setup();
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);
            orange.Update();


            
            

            //Player Object

            //Draw.FillColor = Color.LightGray;
            //Draw.Rectangle(playPosition, playSize);

            //Temp Collision Platform
            //Draw.FillColor = Color.DarkGray;//
            // Draw.Rectangle(20, 750, 760, 20);/

            //Fruit

            


        }
    }
}
