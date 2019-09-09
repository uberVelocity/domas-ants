namespace agents.model.agents
{
    public class Food
    {
        private int _energy;
        private string _name;
        private int _consumptionTime;

        /** 
         *  Default constructor with instant food consumption time.
         */
        public Food(int energy, string name)
        {
            this._energy = energy;
            this._name = name;
            this._consumptionTime = 0;
        }

        /**
         *  Food consumption time constructor.
         */
        public Food(int energy, string name, int consumptionTime)
        {
            this._energy = energy;
            this._name = name;
            this._consumptionTime = consumptionTime;
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
    }
}