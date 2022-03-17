using RefactorDemoGroupProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorDemoGroupProj
{
    internal class AlwaysPicksPaper : IChoice
    {
        Picker IChoice.GetResult()
        {
            return Picker.PAPER;
        }
    }
}
