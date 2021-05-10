using System;
using System.Collections.Generic;

namespace Beehive
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Bees
            Bee John = new Bee("John", 3.2f);
            Bee Paul = new Bee("Paul", 2.7f);
            Bee Ringo = new Bee("Ringo", 1.1f);
            Bee George = new Bee("George", 2.0f);

            Bee Kurt = new Bee("Kurt", 2.3f);
            Bee Dave = new Bee("Dave", 7.4f);
            Bee Krist = new Bee("Krist", 1.5f);

            //Create Array of bees for beehives
            Bee[] beatles = new Bee[4];
            beatles[0] = John;
            beatles[1] = Paul;
            beatles[2] = Ringo;
            beatles[3] = George;

            Bee[] nirvana = new Bee[3];
            nirvana[0]= Kurt;
            nirvana[1]= Dave;
            nirvana[2]= Krist;

            //Instantiate Beehives
            Beehive Beatles = new Beehive(beatles, 4);
            Beehive Nirvana = new Beehive(nirvana, 3);
            
            //Collect Honey method
            Beatles.CollectHoney(10, Paul);

            //Number of bees in hive
            Nirvana.BeeNumber(Nirvana);
        }
    }

//Class (Bee)
    class Bee{
        //attributes
        public string Name;
        public float Size;

        //Constructors
        public Bee(string n, float s){
            this.Name = n;
            this.Size = s;
        }

    }

//class (Beehive)
    class Beehive{
        //attributes
        public Array bees;
        public int maxbees;

        //Constructors
        
        public Beehive(Array b, int mb){
            this.bees = b;
            this.maxbees = mb;
        }
        //functions
        public void CollectHoney(int days, Bee x){
            float Amount = days*x.Size*0.2f;
            Console.WriteLine(x.Name+" collected "+Amount+" units of honey in "+days+" days.");
        }
        public void BeeNumber(Beehive x){
            int Amount = x.bees.Length;
            Console.WriteLine("There are " + Amount + " bees in this hive.");
        }
    }
}
