using System;
using System.Collections.Generic;
using System.Linq;

namespace LetsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do your testing here.
           
            Console.ReadKey();
        }
    }
    public class CoffeeShop
    {
        // TODO: Implement coffee shop without changing method signature. Replace comments with your code to succeed in this task. Good luck!

        Dictionary<Coffee, int> _coffees = new Dictionary<Coffee, int>();
        Queue<int> _customers = new Queue<int>();
        int _ticket = 1;
        int _coffeesServed = 0;

        public CoffeeShop(Coffee[] coffeesPrepared)
        {
            // TODO: Remove throw new NotImplementedException. Add coffees to coffee dictionary.
            foreach (var coffee in coffeesPrepared)
            {
                if (_coffees.ContainsKey(coffee))
                {
                    _coffees[coffee] = _coffees[coffee] + 1; 
                }
                else
                {
                    _coffees.Add(coffee, 1);
                }
            }
        }
        public CoffeeShop(Coffee[] coffeesPrepared, int customersInQueue) : this(coffeesPrepared)
        {
            // TODO: Remove throw new NotImplementedException. Add customers to queue with their ticket number. 
            for (var i = 1; i <= customersInQueue; i ++)
            {
                _customers.Enqueue(i);
                _ticket += 1;
            }
            

        }

        public void AddCustomer()
        {
            //// TODO: Add customer to queue.
            _customers.Enqueue(_ticket);
            _ticket += 1;
        }

        public bool ServeCustomer(Coffee coffee)
        {
            // TODO: remove customer from queue and give him coffee. If coffee not yet made do nothing and return false.
            if (_coffees.ContainsKey(coffee) &&_coffees[coffee] > 0)
            {
                RemoveCoffee(coffee);
                _coffeesServed += 1;
                _customers.Dequeue();
                return true;
            } else
            {
                return false;
            }
        }

        public bool AddCoffee(Coffee coffee)
        {
            // TODO: Add prepared coffee.
            if (_coffees.ContainsKey(coffee))
            {
                _coffees[coffee] = _coffees[coffee] + 1;
            }
            else
            {
                _coffees.Add(coffee, 1);
            }
            return true;
        }

        public bool RemoveCoffee(Coffee coffee)
        {
            // TODO: Subtract given coffee
            bool result;
            if (_coffees[coffee] != 0)
            {
                _coffees[coffee] = _coffees[coffee] - 1;
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public int[] Customers
        {
            get
            {
                // TODO: Return ticket numbers of people in queue.
                return _customers.ToArray();

            }

        }

        public int NextTicket
        {
            get
            {
                // TODO: return next ticket.
                return _ticket;
            }
        }

        public int CoffeesServed
        {
            get
            {
                // TODO: Track all coffees served & their count.
                return _coffeesServed;
            }
        }

        public int CustomersServed
        {
            get
            {
                // TODO: Track all customers served.
                return _ticket - _customers.Count - 1;
            }
        }

        public Dictionary<Coffee, int> CoffeesReadyToServe
        {
            get
            {
                // TODO: Track all currently availbale coffees.
                return _coffees;
            }
        }

        public Queue<int> CustomersInQueue
        {
            get
            {
                // TODO: Return customers.
                return _customers;
            }
        }

    }
}
