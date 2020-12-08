using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Средняя_оценка
{
    class Note
    {
        int sum = 0;
        int qty = 0;

        public Note()
        {
            Clear();
        }

        public void AddNote(int note)
        {
            if (note < 2 || note > 5) return;
            sum += note;
            qty ++;
        }

        public void Clear()
        {
            sum = 0;
            qty = 0;
        }

        public string getAvg()
        {
            float avg;
            if (qty == 0)
                avg = (float)0.0;
            else
                avg = ((float)sum) / ((float)qty);
            return avg.ToString("0.0");
        }

        public string getQty()
        {
            return qty.ToString();
        }
    }
}
