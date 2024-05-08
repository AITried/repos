using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFI_LR1
{
    class Program
    {
        static void Main(string[] args)
        {
            StateMechan stateMechan = new StateMechan(2);
            string start = Console.ReadLine();
            Console.WriteLine(start + " -> " + stateMechan.moveState(start));

        }
    }
    class StateMechan
    {
        string state;
        public string State
        {
            get { return state; }
        }
        public string[] stacState = { "q1", "q2", "q3", "q4", "q5" };

        public StateMechan(int numState)
        {
            try
            {
                state = stacState[numState - 1];
            }
            catch (Exception)
            {
                state = stacState[4];
            }
        }


        public string moveWord(int input)
        {
            string res = "";
            string buf = Convert.ToString(input);

            foreach (char c in buf)
            {
                res += Convert.ToString(Convert.ToInt32(Convert.ToString(c)), 2);
            }

            return res;
        }
       
        public string moveState(string input)
        {
            string res = "";

            foreach (char c in input)
            {
                //Console.WriteLine("Текущее состояние: {0}", state);
                switch (state)
                {
                    case "q1":
                        res += stateQ1(c);
                        break;
                    case "q2":
                        res += stateQ2(c);
                        break;
                    case "q3":
                        res += stateQ3(c);
                        break;
                    case "q4":
                        res += stateQ4(c);
                        break;
                    case "q5":
                        res += stateQ5(c);
                        break;

                }
            }

            return res;
        }
        public char stateQ1(char c)
        {
            if (c == '0')
            {
                state = stacState[3];
                return '1';
            }
            else
            {
                state = stacState[2];
                return '0';
            }
        }
        public char stateQ2(char c)
        {
            if (c == '0')
            {
                state = stacState[0];
                return '0';
            }
            else
            {
                state = stacState[3];
                return '1';
            }
        }
        public char stateQ3(char c)
        {
            if (c == '0')
            {
                state = stacState[1];
                return '1';
            }
            else
            {
                state = stacState[0];
                return '0';
            }
        }

        public char stateQ4(char c)
        {
            if (c == '0')
            {
                state = stacState[2];
                return '0';
            }
            else
            {
                state = stacState[1];
                return '1';
            }
        }
        public char stateQ5(char c)
        {
            if (c == '0')
            {
                state = stacState[2];
                return '0';
            }
            else
            {
                state = stacState[3];
                return '1';
            }
        }
    }
}
