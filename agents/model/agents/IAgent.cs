using agents.model;
using agents.model.items;

namespace agents.model.agents
{
    public interface IAgent
    {
        void Move();
        void Feed(Food resource);
    }
}