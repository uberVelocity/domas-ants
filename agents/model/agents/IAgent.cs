using agents.model;

namespace agents.model.agents
{
    public interface IAgent
    {
        void Move();
        void Feed(Food resource);
    }
}