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
                _name = value;
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
                return _layerCount;
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
            if (index < 0 || index > _layerCount - 1)
                return;

            ILayer[] newLayers = new ILayer[_layers.Length - 1];
            for (int i = 0; i < _layers.Length; i++)
            {
                if (i == index)
                    continue;
                else if (i < index)
                    newLayers[i] = _layers[i];
                else
                    newLayers[i - 1] = _layers[i];
            }
            _layers = newLayers;
            _layerCount = _layers.Length;

        }
    }
}
