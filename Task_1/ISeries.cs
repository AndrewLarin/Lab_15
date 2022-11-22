using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }

    class ArithProgression : ISeries
    {
        int step;
        int startValue, curentValue;
        public void setStep(int s)
        {
            step = s;
        }

        public int getNext()
        {
            curentValue += step;
            return curentValue;
        }

        public void reset()
        {
            curentValue = startValue;
            Console.WriteLine("Reset");

        }

        public void setStart(int x)
        {
            startValue = x;
            curentValue = startValue;
        }

    }
    class GeomProgression : ISeries
    {
        int step;
        int startValue, curentValue;
        public void setStep(int s) 
        {
            step = s;
        }

        public int getNext()
        {
            curentValue *= step;
            return curentValue;
        }

        public void reset()
        {
            curentValue = startValue;
            Console.WriteLine("Reset");
        }

        public void setStart(int x)
        {
            startValue = x;
            curentValue = startValue;
        }
    }

}
