using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProGisBLL
{
    public interface IMapDocument
        {
        IMap FocusMap { get; set; }
        IMap[] Maps {get;}
        IMap GetMap(string name);
        }
}
