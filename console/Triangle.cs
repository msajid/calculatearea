namespace CalculateArea
{
    public class Triangle : Shape
    {
        private readonly float _base;
        private readonly float _height;

        public Triangle(float @base, float height)
        {
            this._base = @base;
            this._height = height;
        }
        public float GetArea()
        {
            return _base * _height * 0.5f;
        }
    }
}