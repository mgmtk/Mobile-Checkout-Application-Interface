using System;
namespace SolutionItems {
    public class Customer
    {
        String email;
        String name;
        int numberOfItems;
        Boolean hasBasket;
        Basket newBasket;

        public Customer(String email, String name, int numberOfItems)
        {
            this.email = email;
            this.name = name;
            this.numberOfItems = numberOfItems;
            hasBasket = false;

        }
        public Boolean addBasket()
        {
            if (!this.hasBasket)
            {
                newBasket = new Basket();
                hasBasket = true;
                return true;
            }


            Console.Write("Customer already has exisiting basket");
            return false;



        }
        public Boolean deleteBasket()
        {

            if (this.hasBasket)
            {
                newBasket = null;
                this.hasBasket = false;
                return true;

            }


            Console.Write("Basket doesnt exist ");
            return false;


        }
        public Boolean addItem(Item item)
        {
            if (this.hasBasket)
            {

                return newBasket.add(item);
            }

        }
        public Boolean removeItem(Item item)
        {
            if (this.hasBasket)
            {
                return newBasket.remove(item);
            }

        }
        public void clearBasket()
        {
            if (hasBasket)
            {
                newBasket.clear();
            }


        }
        public int getCustomerTotalItems()
        {

            return numberOfItems + newBasket.getTotalItemCount();

        }
        public int currentBasketTotal() {

            return newBasket.basketValue();
        }
    }

}

