using System;

namespace LetsQueue
{
    public class Coffee
    {
        public Coffee(string typeOfCoffee)
        {
            TypeOfCoffee = typeOfCoffee;
        }
        public string TypeOfCoffee { get; }

        public override int GetHashCode()
        {
            // TODO: Get Hash of TypeOfCoffee string and return it.
            return TypeOfCoffee.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            // TODO: Implement equals check between obj and coffee. Hint : this.TypeOfCoffee == ((Coffee)obj).TypeOfCoffee 
            if (obj == null)
            {
                return false;
            }
            else
            {
                return this.TypeOfCoffee == ((Coffee)obj).TypeOfCoffee;
            }
        }
    }
}