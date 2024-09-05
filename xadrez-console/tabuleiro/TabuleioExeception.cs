using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class TabuleioExeception : Exception
    {
        public TabuleioExeception(string msg):base (msg) { }
    }
}
