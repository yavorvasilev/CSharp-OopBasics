namespace _09RectangleIntersection
{
    public class Rectangle
    {
        public Rectangle(string id, double width, double height, double topLeftX, double topLeftY)
        {
            this.ID = id;
            this.Width = width;
            this.Height = height;
            this.TopLeftX = topLeftX;
            this.TopLeftY = TopLeftY;
            this.BottomRightX = topLeftX + width;
            this.BottomRightY = topLeftY + height;
        }

        public bool CheckingIntersectRectangle(Rectangle rectangle)
        {
            bool intersect = false;

            if (this.BottomRightX >= rectangle.TopLeftX && this.BottomRightY >= rectangle.TopLeftY)
            {
                if (this.TopLeftX <= rectangle.BottomRightX && this.TopLeftY <= rectangle.BottomRightY)
                {
                    return intersect = true;
                }
            }

            if (rectangle.BottomRightX >= this.TopLeftX && rectangle.BottomRightY >= this.TopLeftY)
            {
                if (rectangle.TopLeftX <= this.BottomRightX && rectangle.TopLeftY <= this.BottomRightY)
                {
                    return intersect = true;
                }
            }

            return intersect;
        }
        

        public string ID { get; }
        public double Width { get; }
        public double Height { get; }
        public double TopLeftX { get; }
        public double TopLeftY { get; }
        public double BottomRightX { get; }
        public double BottomRightY { get; }
    }
}
