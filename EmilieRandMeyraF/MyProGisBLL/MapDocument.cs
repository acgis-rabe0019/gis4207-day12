using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProGisBLL
{
    public class MapDocument : IMapDocument, IMapManager
    {
        private IMap _FocusMap;
        private IMap[] _Maps;

        IMap IMapDocument.FocusMap
        {
            get
            {
                return _FocusMap;
            }
        }

        IMap[] IMapDocument.Maps
        {
            get
            {
                return _Maps;
            }
        }

        void IMapManager.AddMap()
        {
            throw new NotImplementedException();
        }

        IMap IMapDocument.GetMap(string name)
        {
            throw new NotImplementedException();

        }

        void IMapManager.RemoveMap(int index)
        {
            throw new NotImplementedException();
        }

        void IMapManager.SetFocusMap(int index)
        {
            throw new NotImplementedException();
        }
    }
}
