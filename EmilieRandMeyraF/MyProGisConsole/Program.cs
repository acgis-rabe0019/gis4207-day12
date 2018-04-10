using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProGisBLL;

namespace MyProGisConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IMapManager Mymap = new MapDocument();
            IMapDocument Mapname = (IMapDocument)Mymap;
            IMap Canada = new Map();
            IMap US = new Map();
            Mymap.AddMap(Canada);
            Mymap.AddMap(US);
            Canada.Name = "Canada";
            US.Name = "U.S.";
            Mymap.SetFocusMap(1);
            ILayer Provinces = new Layer();
            Provinces.Name = "Provinces";
            Canada.AddLayer(Provinces);
            ILayer Lakes = new Layer();
            Lakes.Name = "Lakes";
            Canada.AddLayer(Lakes);
            ILayer States = new Layer();
            States.Name = "Lakes";
            US.AddLayer(States);
            ILayer Lakes1 = new Layer();
            Lakes1.Name = "Lakes";
            US.AddLayer(Lakes1);
            ILayer Rivers = new Layer();
            Rivers.Name = "Rivers";
            US.AddLayer(Rivers);

            Console.WriteLine("Map Document Report");
            Console.WriteLine("Focus Map = {} ", Mapname.FocusMap.Name);
            Console.WriteLine("Map Name = {} ", Canada.Name);
            Console.WriteLine("Layer Count = {} ", Canada.Layers.Length);

            Console.ReadKey();
        }
        
    }
}
