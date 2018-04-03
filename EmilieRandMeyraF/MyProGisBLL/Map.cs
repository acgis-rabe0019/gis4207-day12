using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProGisBLL
{
    public class Map:IMap
    {
        private ILayer[] _layers = new ILayer[0];
        private int _layerCount = 0;
        public string _name = "party layer";

        string IMap.Name
        {
            get
            {
                return _name;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        ILayer[] IMap.Layers
        {
            get
            {
               return _layers ;
            }
        }

        int IMap.LayerCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        void IMap.AddLayer(ILayer layer)
        {
            Array.Resize(ref _layers, _layers.Length + 1);
            _layers[_layers.Length - 1] = layer;
            _layerCount++;
        }

        void IMap.RemoveLayer(int index)
        {
            throw new NotImplementedException();
        }
    }
}
