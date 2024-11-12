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
        private Vector2 platformDirectionRight = new Vector2(+5, 0);
        private Vector2 platformDirectionLeft = new Vector2(-5, 0);
        private Vector2 platformPosition;
        private bool IsGoingLeft;
        public void Setup()
        {
            platformPosition.X = Random.Float(50, 750);
            platformPosition.Y = Random.Float(500, 550);
            platformSizeX = Random.Float(50, 100);
            platformSizeY = 10;
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
            if (!IsGoingLeft)
            {
                Vector2 directionalMovement = platformDirectionLeft * Time.DeltaTime;
                platformSpeed += directionalMovement;
                platformPosition += platformSpeed;
            }
            else
            {
                Vector2 directionalMovement = platformDirectionRight * Time.DeltaTime;
                platformSpeed += directionalMovement;
                platformPosition += platformSpeed;
            }
            
        }

    }
}
