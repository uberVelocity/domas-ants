namespace agents
{
    public class Agent
    {
        private int _id;
        private double _speed;
        private int _age;

        public Agent(double speed, int age) 
        {
            this._age = age;
            this._speed = speed;
        }

        public Agent(int id, double speed, int age) 
        {
            this._id = id;
            this._speed = speed;
            this._age = age;
        }

        public int Id 
        {
            get 
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        public double Speed
        {
            get
            {
                return this._speed;
            }
            set
            {
                this._speed = value;
            }
        }

        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }
    }
}