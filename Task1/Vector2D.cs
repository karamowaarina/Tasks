using System;

namespace Task1
{
    public class Vector2D
    {
        private float _x;
        public float X
        {
            get => _x;
            set => _x = value;
        }
        
        private float _y;
        public float Y
        {
            get => _y;
            set => _y = value;
        }

        public float Length => (float)Math.Sqrt(_x * _x + _y * _y);

        public Vector2D(float x, float y)
        {
            _x = x;
            _y = y;
        }

        public override bool Equals(object other)
        {
            if (other is not Vector2D)
                throw new ArgumentException("Объект должен быть того же типа");
            var otherVector = (Vector2D)other;
            return X.Equals(otherVector.X) && Y.Equals(otherVector.Y); 
        }

        public static Vector2D operator +(Vector2D a, Vector2D b)
        {
            return new Vector2D(a.X + b.X, a.Y + b.Y);
        }
        
        public static Vector2D operator -(Vector2D a, Vector2D b)
        {
            return new Vector2D(a.X - b.X, a.Y - b.Y);
        }
        
        public static Vector2D operator *(float n, Vector2D a)
        {
            return new Vector2D(n * a.X, n * a.Y);
        }
        
        public static float operator *(Vector2D a, Vector2D b)
        {
            return b.X * a.X + b.Y * a.Y;
        }
    }
}