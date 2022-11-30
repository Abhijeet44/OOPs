using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Oops_Concepts
{
    class Order
    {
        int orderId;
        String orderDate;
        Customer cust;
        Item item1;

        public Order()
        {

        }

        public Order(int oId, String date, Customer c, Item it)
        {
            this.orderId = oId;
            this.orderDate = date;
            this.cust = c;
            this.item1 = it;
        }

        public int OrderId
        {
            set { orderId = value; }
            get { return orderId; }
        }

        public String Orderdate
        {
            set { orderDate = value; }
            get { return orderDate; }
        }

        public Customer Cust
        {
            set { cust = value; }
            get { return cust; }
        }

        public Item Item1
        {
            set { item1 = value; }
            get { return item1; }
        }

        static void Main(string[] args)
        {
            Order o = new Order();
            o.orderId = 123;
            o.orderDate = "28 Aug 2022";

            Console.WriteLine("Order Id : " + o.orderId);
            Console.WriteLine("Order Date : "+ o.Orderdate);

            Customer c = new Customer();
            c.CustId = 175;
            c.CustName = "AB";

            Console.WriteLine("Customer Id : " + c.CustId);
            Console.WriteLine("Customer Name : " + c.CustName);

            /*Item i = new Item();
            i.ItemId = 001;
            i.ItemName = "Book";
            i.Price = 250;*/

            o.Cust = c;
            //o.Cust.Address = a;
            //o.Item1 = i;

            o.item1.ItemId = 100;
            o.item1.ItemName = "AB";
            o.item1.Price = 250;

            Console.WriteLine("Item Id : " + o.item1.ItemId);
            Console.WriteLine("Item Name : " + o.item1.ItemName);
            Console.WriteLine("Price : " + o.item1.Price);

            o.cust.Address.Add1 = "Jule Solapur";
            o.cust.Address.City = "Solapur";
            o.cust.Address.Pincode = 413004;

            Console.WriteLine("Address : " + o.cust.Address.Add1);
            Console.WriteLine("City : " + o.cust.Address.City);
            Console.WriteLine("Pincode : " + o.cust.Address.Pincode);

        }
    }

    class Customer
    {
        int custId;
        String custName;
        Address address;

        public Customer()
        {

        }

        public Customer(int cId, String cnm, Address add)
        {
            cId= this.custId;
            cnm = this.custName;
            add = this.address;
        }

        public int CustId
        {
            set { custId = value; }
            get { return custId; }
        }

        public String CustName
        {
            set { custName = value; }
            get { return custName; }
        }

        public Address Address
        {
            set { address = value; }
            get { return address; }
        }
    }

    class Address
    {
        String add1;
        String city;
        int pincode;

        public Address()
        {
        
        }

        public Address(String add, String c, int pin)
        {
            add = this.add1;
            c = this.city;
            pin = this.pincode;
        }

        public String Add1
        {
            set { add1 = value; }
            get { return add1; }
        }

        public String City
        {
            set { city = value; }
            get { return city; }
        } 

        public int Pincode
        {
            set { pincode = value; }
            get { return pincode; }
        }
    }

    class Item
    {
        int itemId;
        String itemName;
        int price;

        public Item()
        {

        }

        public Item(int id, String nm, int pr)
        {
            id = this.itemId;
            nm = this.itemName;
            pr = this.price;
        }

        public int ItemId
        {
            set { itemId = value; }
            get { return itemId; }
        }

        public String ItemName
        {
            set { itemName = value; }
            get { return itemName; }
        }

        public int Price
        {
            set { price = value; }
            get { return price; }
        }
    }
}
