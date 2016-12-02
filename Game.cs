namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
          Map map = new Map(8,3);
          
          Point point = new Point(4,2);
          bool isOnMap = map.OnMap(point);
          Console.WriteLine(inOnMap);
          
          point = new Point(8,5);
          isOnMap = map.onMap(point);
          Console.WriteLine(inOnMap);
        }
    }
}

