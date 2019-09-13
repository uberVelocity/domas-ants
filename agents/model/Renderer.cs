using agents.model.environment;

namespace agents.model
{
    public class Renderer
    {
        public Renderer() {}

        public static void RenderObject(MapObject map) {
            string type = map.GetType().ToString();
            switch(type) {
                case("MapObject"):
                    System.Console.Write("B");
                    break;
                case("Agent"):
                    System.Console.Write("A");
                    break;
                default:
                    System.Console.Write("B");
                    break;
            }
        }
    }
}