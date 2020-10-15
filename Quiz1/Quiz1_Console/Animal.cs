namespace Quiz1_Console
{
    class Animal
    {
        #region Attributes
        string name;
        string diet;
        #endregion

        #region Constructor
        public Animal()
        {

        }
        public Animal(string name)
        {
            this.name = name;
        }
        #endregion

        #region Methods
        public void SetDiet(string food) { this.diet = food; }
        public string Name
        {
            get
            {
                return name;
            }
            set { name = value; }
        }


        public string Eat()
        {
            return $"{name} eats {diet}";
        }

        public void Sleep()
        {

        }

        public void Drink()
        {

        }
        #endregion
    }
}
