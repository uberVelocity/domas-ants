namespace agents.model.agents
{
    public class Worker:Agent
    {

        private double _digRate;

        public Worker()
        {
            
        }

        public Worker(double speed, int age) 
        {
            this.Age = age;
            this.Speed = speed;
        }

        public Worker(int id, double speed, int age) 
        {
            this.Id = id;
            this.Speed = speed;
            this.Age = age;
        }

        public Worker(int id, double speed, int age, string name) 
        {
            this.Id = id;
            this.Speed = speed;
            this.Age = age;
            this.Name = name;
        }

        public double DigRate
        {
            get
            {
                return this._digRate;
            }
            set
            {
                this._digRate = value;
            }
        }
    }
}