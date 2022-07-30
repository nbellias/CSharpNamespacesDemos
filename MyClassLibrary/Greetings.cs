using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Greetings
    {
        private int size;
        private Greeting[] greetingList;

        public Greetings(int s)
        {
            size = s;
            greetingList = new Greeting[size];
            for (int i = 0; i < size; i++)
            {
                greetingList[i] = new Greeting();
            }
        }

        public Greeting this[int index]
        {
            get
            {
                Greeting? tmp;

                if (index >= 0 && index <= size - 1)
                {
                    tmp = greetingList[index];
                }
                else
                {
                    tmp = null;
                }

                return tmp;
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    greetingList[index] = value;
                }
            }
        }

        public int this[Greeting greeting]
        {
            get
            {
                int index = 0;

                while (index < size)
                {
                    if (greetingList[index] == greeting)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }
        }
    }
}
