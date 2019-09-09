using agents.model.agents;
using System.Diagnostics;

namespace agents.model.environment
{
    public class Map
    {
        private Agent[, ] _gridMap;

        public Map() {}

        public Map(int size)
        {
            this._gridMap = new Agent[size, size];
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    this._gridMap[i, j] = new BlankAgent();
                    Debug.Assert(this._gridMap[i, j].GetType() == typeof(BlankAgent));
                }
            }
        }

        public Agent[,] GridMap
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