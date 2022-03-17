using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorDemoGroupProj
{
    internal class RandomPicker : IChoice
    {
        Picker IChoice.GetResult()
        {
            Random random = new Random();
            int returner = random.Next(1, 4);
            return (Picker)returner;
        }
    }
}
