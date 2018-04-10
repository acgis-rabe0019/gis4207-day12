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
        private IMap[] _Maps = new IMap[0];
        private int _mapCount = 0;
        

        IMap IMapDocument.FocusMap
        {
            get
            {
                return _FocusMap;
            }

            set
            {
                _FocusMap = value;
            }
        }
        IMap[] IMapDocument.Maps
        {
            get
            {
                return _Maps;
            }
        }
        

        void IMapManager.AddMap(IMap mapi)
        {

            Array.Resize(ref _Maps, _Maps.Length + 1);
            _Maps[_Maps.Length - 1] = mapi;
            _mapCount++;
        }

        IMap IMapDocument.GetMap(string name)
        {
            IMap map = null;
            foreach (IMap mp in _Maps)
            {
                if (mp.Name == name)
                    return mp;
            }
            return map;
        }

        void IMapManager.RemoveMap(int index)
        {
           
            
                if (index < 0 || index > _mapCount - 1)
                    return;

                IMap[] newMaps = new IMap[_Maps.Length - 1];
                for (int i = 0; i < _Maps.Length; i++)
                {
                    if (i == index)
                        continue;
                    else if (i < index)
                        newMaps[i] = _Maps[i];
                    else
                        newMaps[i - 1] = _Maps[i];
                }
                _Maps = newMaps;
                _mapCount = _Maps.Length;
            
            

        }

        void IMapManager.SetFocusMap(int index)
        {


            _FocusMap = _Maps[index] ;
        }
    }
}
