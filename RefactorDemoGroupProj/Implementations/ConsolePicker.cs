using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorDemoGroupProj
{
    internal class ConsolePicker : IChoice
    {
        Picker IChoice.GetResult()
        {
            return (Picker)ConsoleIO.GetInt("Pick 1:");
        }
    }
}
