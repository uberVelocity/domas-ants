using System.Collections.Generic;

namespace agents.model
{
    public sealed class Model
    {
        private List<Agent> _agents;

        public Model() {

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