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
        private Vector2 platformDirection = new Vector2(+20, 0);
        private Vector2 platformPosition;

        public void Setup()
        {
            platformPosition.X = Random.Float(50, 750);
            platformPosition.Y = Random.Float(500, 550);
            platformSizeX = Random.Float(20, 50);
            platformSizeY = 10;
        }
        public void Update()
        {
            Draw.FillColor = Color.DarkGray;
            Draw.Rectangle(platformPosition.X, platformPosition.Y, platformSizeX, platformSizeY);
        }

    }
}
