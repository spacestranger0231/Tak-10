using System;
using System.Collections.Generic;
//pryblyznyj code

namespace Task_10
{

    class Shop
    {
        public string pr;
        public int price;
        public string Product
        {
            get
            {
                return pr;
            }
            set
            {
                pr = value;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public int Decreases(int d)
        {
            int newp;
            newp = (price * d) / 100;
            return newp;
        }

    }

    class Clients
    {
        private int psize;

        public int Psize
        {
            get
            {
                return psize;
            }
            set
            {
                psize = value;
            }
        }

        public bool Which_client()
        {
            bool a;
            Console.WriteLine("Have you ever been to us?\n" + "1.I was here\n" + "0.No, I wasn`t\n");
            a = Convert.ToBoolean(Console.ReadLine());
            if (a == true)
            {
                Console.WriteLine("Oftem visists the shop");
                return true;
            }
            else
            {
                Console.WriteLine("Came here for the first time");
                return false;
            }
        }

        public bool If_unique()
        {
            if (Which_client() == true)
            {
                bool u;
                Console.WriteLine("Unique?");
                u = Convert.ToBoolean(Console.ReadLine());
                if (u == true)
                {
                    return true;
                }
            }
            return false;
        }

        public void Watch(Shop[] sh, int size)
        {
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine(sh[i].Product + " ");
            }
        }

        public bool Gettobag(Shop[] sh, int size)
        {
            const int max_bag_size = 50;
            string[] bag = new string[max_bag_size];
            int bag_size;
            Console.WriteLine("Input size of the bag");
            bag_size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(sh[i].Product + " ");
            }
            Console.WriteLine("Choose what you want");
            for (int i = 0; i < bag_size; i++)
            {
                bag[i] = Console.ReadLine();
                return true;
            }
            return false;
        }

        public bool Make_an_offer(Shop[] sh, int size)
        {
            const int max_bag_size = 50;
            string[] offer = new string[max_bag_size];
            int offer_size;
            Console.WriteLine("Input size of the bag");
            offer_size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(sh[i].Product + " ");
            }
            Console.WriteLine("Choose what you want");
            for (int i = 0; i < offer_size; i++)
            {
                offer[i] = Console.ReadLine();
                return true;
            }
            return false;
        }

        public void bought(Shop[] sh, int size)
        {
            Console.WriteLine("Will you buy what you choosed&?"+"1.Yes"+"0.No");
            bool v;
            for (int i = 0; i < size; i++)
            {
                v = Convert.ToBoolean(Console.ReadLine());
                if ((Gettobag(sh, size) == true || Make_an_offer(sh, size) == true) && v == true)
                {
                    i++;
                }
                  
            }
        }
        public bool Adress(bool a)
        {
            if (a == true)
            {
                Console.WriteLine("SAMOVYVIZ");
                return true;
            }
            else
            {
                Console.WriteLine("DOSTAVKA");
                return false;
            }
        }
        public bool Changeprice(Shop[] sh, int pr)
        {
            for(int i = 0; i < psize; i++)
            {
                if (If_unique() == true)
                {
                    sh[i].Decreases(pr);
                    return true;
                }
            }
            return false;
        }
    }

    class Administrator
    {
        private Shop[] sh;
        private void AddandDelete(int size)
        {
            int v;
            string additional;
            Console.WriteLine("Will you buy what you choosed?" + "1.Add" + "2.Delete");
            v = Convert.ToInt32(Console.ReadLine());
            if (v == 1)
            {
                additional = Console.ReadLine();
                sh[size++].Product = additional;
            }
            else if (v == 2)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(sh[i].Product + " ");
                }

                for (int i = 0; i < size; i++)
                {
                    int ind;
                    Console.WriteLine("Input the index to delete:");
                    ind = Convert.ToInt32(Console.ReadLine());
                    if (i == ind)
                    {
                        i++;
                    }

                }
            }
        }
        private void Setclient(bool a, Clients c)
        {
            if (a == true)
            {
                c.If_unique();
            }
            else
            {
                c.If_unique();
            }
        }
    }

    class Moderator
    {
        private Shop[] sh;
        public int Decreases2(int size,int pr)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(sh[i].Product + " ");
            }
            for (int i = 0; i < size; i++)
            {
                sh[i].Decreases(pr);
                return sh[i].Price;
            }
            return 0;
        }
        private void Delete(int ind, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(sh[i].Product + " ");
            }

            for (int i = 0; i < size; i++)
            {
                if (i == ind)
                {
                    i++;
                }
            }
        }

    }

}

