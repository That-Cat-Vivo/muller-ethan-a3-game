using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Game10003
{
    public class Platform
    {
        private float platformSizeX;
        private float platformSizeY;
        private Vector2 platformSpeed;
        private Vector2 platformDirection = new Vector2(+100, 0);
        private Vector2 platformPosition;
        private bool IsGoingLeft;

        public Platform()
        {
            Setup();

        }

        public void Setup()
        {
            //Important Variables seperated from everything else.
            platformPosition.X = Random.Float(200, 600);
            platformPosition.Y = Random.Float(500, 550);
            platformSizeX = Random.Float(50, 100);
            platformSizeY = 10;
            MovePlat();
        }
        public void Update()
        {
            Draw.FillColor = Color.DarkGray;
            Draw.Rectangle(platformPosition.X, platformPosition.Y, platformSizeX, platformSizeY);

            
            //Movement
            if (platformPosition.X <= -30)
            {
                IsGoingLeft = false;
            }
            if (platformPosition.X >= 30)
            {
                IsGoingLeft = true;
            }
         
            
        }
        public void MovePlat()
        {
           while(IsGoingLeft)
           {
                platformSpeed.X = platformDirection.X * Time.DeltaTime;
                platformPosition = platformSpeed;
           }
            
        }
    }
}
