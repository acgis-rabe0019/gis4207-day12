using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IMapManager
{

    void AddMap(MyProGisBLL.IMap map);
    void RemoveMap(int index);
    void SetFocusMap(int index);
}