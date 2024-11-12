using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Game10003
{
    internal class Fruit
    {
        private Vector2 fruitPosition;
        private Vector2 velocity;
        private Vector2 gravity = new Vector2(0, +30);

        public void Setup()
        {
            fruitPosition.X = Random.Float(10, 790);
            fruitPosition.Y = -50;
        }
        public void Update()
        {
            Draw.FillColor = Color.Red;
            Draw.Circle(fruitPosition, 20);
            //gravity
            Vector2 gravForce = gravity * Time.DeltaTime;
            velocity += gravForce;
            fruitPosition += gravForce;
        }
    }
}
