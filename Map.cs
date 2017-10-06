namespace Tower_Defense
{
    class Map
    {
        public readonly int Width;
        public readonly int Height;

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }
        
        public bool OnMap(Point point)
        {
            return point.X >= 0 && point.X < Width && 
                   point.Y >= 0 && point.Y < Height;
            //bool inBounds = !(point.X < 0 || point.X >= Width || point.Y < 0 || point.Y >= Height); ///not needed
            //return inBounds; //not needed
        }
    }










}