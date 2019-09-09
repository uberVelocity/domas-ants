using System.Collections.Generic;
using agents.model.agents;
using agents.model.environment;

namespace agents.model
{
    public sealed class Model
    {
        private List<Agent> _agents;
        private Map map;

        public Model(int mapSize) {
            // Initialize agents
            this.map = new Map(mapSize);
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

    }
}