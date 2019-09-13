using agents.model.agents;
using System.Diagnostics;

namespace agents.model.environment
{
    public class Map
    {
        private MapObject[, ] _gridMap;  // Currently the 'Map' is a 2D MapObject array
        private int _size;

        public Map() {}

        // Blank MapObject array constructor
        public Map(int size)
        {
            this._size = size;
            InitializeMap();
            PrintMap();
        }

        // Prints the current state of the map
        public void PrintMap()
        {
            for (int i = 0; i < _size; i++) {
                for (int j = 0; j < _size; j++) {
                    Renderer.RenderObject(_gridMap[i, j]);
                }
                System.Console.WriteLine();
            }
        }

        private void InitializeMap() {
            // Initialize 2D Agent array
            this._gridMap = new MapObject[_size, _size];
            for (int i = 0; i < _size; i++) 
            {
                for (int j = 0; j < _size; j++) 
                {
                    this._gridMap[i, j] = new MapObject();
                    Debug.Assert(this._gridMap[i, j].GetType() == typeof(MapObject));
                }
            }
        }

        public int Size
        {
            get
            {
                return this._size;
            }
            set
            {
                this._size = value;
            }
        }

        public MapObject[,] GridMap
        {
            get
            {
                return this._gridMap;
            }
            set
            {
                this._gridMap = value;
            }
        }
    }
}