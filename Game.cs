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
        Player Monkey = new Player();
        Fruit[] Apples = new Fruit[5];
        Platform[] Bird = new Platform[6];
        

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Monkey Jump");

            //Player 
            new Player();
            //Birds
            for (int b = 0; b < Bird.Length; b++)
            {
                Bird[b] = new Platform();
            }
            //Fruit
            for (int a = 0; a < Apples.Length; a++)
            {
                Apples[a] = new Fruit();
            }

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);
            foreach (Platform Bird in Bird)
            {
                Bird.Update();
            }
            foreach (Fruit Apples in Apples)
            {
                Apples.Update();
            }
            
            Monkey.Update();
            
            

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
