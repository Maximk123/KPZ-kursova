using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursov
{
    class SampleRow
    {
        public string Placeofdispatch { get; set; } //обязательно нужно использовать get конструкцию
        public string Placeofarrival { get; set; }
        public string Deliverytime { get; set; }
        public string Carbrand { get; set; }
        public int Numberofcars { get; set; }
        public string Thestateofcars { get; set; }

        public string Hidden = ""; //Данное свойство не будет отображаться как колонка

        public SampleRow(string Placeofdispatch, string Placeofarrival, string Deliverytime, string Carbrand, int Numberofcars, string Thestateofcars)
        {
            this.Placeofdispatch = Placeofdispatch;
            this.Placeofarrival = Placeofarrival;
            this.Deliverytime = Deliverytime;
            this.Carbrand = Carbrand;
            this.Numberofcars = Numberofcars;
            this.Thestateofcars = Thestateofcars;
        }
    }
}
