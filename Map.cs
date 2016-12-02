namespace TreehouseDefense
{
  class Map {
    public int Width;
    public int Height;
    
    public Map(int width, int height) {
      Width = width;
      Height = height;
    }
    
    public bool onMap(Point point){
      return point.X >= 0 && 
             point.X < Width && 
             point.Y >= 0 && 
             point.Y < Height;
    }
  }
}
