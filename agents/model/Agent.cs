namespace agents.model
{
    public abstract class Agent:IAgent
    {
        private int _id;
        private int _age;
        private int _energy;
        private double _speed;
        private string _name;

        ~Agent() 
        {
            System.Console.WriteLine("Deconstructing agents");
        }

        public void Move()
        {
            System.Console.WriteLine("Attempting to move");   
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

        public int Energy
        {
            get
            {
                return this._energy;
            }
            set
            {
                this._energy = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
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