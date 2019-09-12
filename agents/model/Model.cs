using System.Collections.Generic;
using agents.model.agents;
using agents.model.environment;

namespace agents.model
{
    public sealed class Model
    {
        private List<Agent> _agents;
        private List<MapObject> _mapObjects;
        private Map _map;

        public Model(int mapSize) {
            // Initialize agents
            this._map = new Map(mapSize);
        }

        public List<Agent> Agents
        {
            get
            {
                return this._agents;
            }
            set
            {
                this._agents = value;
            }
        }

        public Map Map
        {
            get
            {
                return this._map;
            }
            set
            {
                this._map = value;
            }
        }

        public List<MapObject> MapObjects
        {
            get
            {
                return this._mapObjects;
            }
            set
            {
                this._mapObjects = value;
            }
        }

    }
}