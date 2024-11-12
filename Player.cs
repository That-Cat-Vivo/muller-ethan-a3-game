using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Game10003
{
    public class Player
    {
        public Vector2 playPosition;
        private Vector2 playVelocity;
        private Vector2 playGravity = new Vector2(0, +30);
        bool IsCollidingWithPlatform;

        public void Setup()
        {
           
            
         
        }
        public void Update()
        {
            Draw.FillColor = Color.LightGray;
            Draw.Square(playPosition, 40);


            //If Else Statement used to prevent collision contradicting normal movement path.
            if (IsCollidingWithPlatform)
            {
                
            }

            else
            {
                Vector2 playDownGrav = playGravity * Time.DeltaTime;
                playVelocity += playDownGrav;
                playPosition += playVelocity;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.Left))
            {
                playPosition.X += -10;
            }
            if (Input.IsKeyboardKeyDown (KeyboardInput.Right))
            {
                playPosition.X += 10;
            }
            
        }
    }
}
