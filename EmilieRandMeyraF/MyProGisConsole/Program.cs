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
            IFeatureLayer ProvincePath = new FeatureLayer();
            ProvincePath.FeatureClass = @"C:\data\prov.shp";
            Provinces.Name = "Provinces";
            Canada.AddLayer(Provinces);
            ILayer Lakes = new Layer();
            IFeatureLayer LakesPath = new FeatureLayer();
            LakesPath.FeatureClass = @"C:\data\canlakes.shp";
            Lakes.Name = "Lakes";
            Canada.AddLayer(Lakes);
            ILayer States = new Layer();
            States.Name = "U.S.";
            IFeatureLayer StatesPath = new FeatureLayer();
            StatesPath.FeatureClass = @"C:\data\states.shp";
            US.AddLayer(States);
            ILayer Lakes1 = new Layer();
            Lakes1.Name = "Lakes";
            IFeatureLayer UsLakesPath = new FeatureLayer();
            UsLakesPath.FeatureClass = @"C:\data\uslakes.shp";
            US.AddLayer(Lakes1);
            ILayer Rivers = new Layer();
            IFeatureLayer RiverPath = new FeatureLayer();
            RiverPath.FeatureClass = @"C:\data\rivers.shp";
            Rivers.Name = "Rivers";
            US.AddLayer(Rivers);


            Console.WriteLine("Map Document Report");
            Console.WriteLine("Focus Map = {0} ", Mapname.FocusMap.Name);
            Console.WriteLine("Map Name = {0} ", Canada.Name);
            Console.WriteLine("Layer Count = {0} ", Canada.Layers.Length);
            Console.WriteLine("     FeatureLayer name = {0}", Canada.Layers[0].Name);
            Console.WriteLine("     FeatureLayer featureClass = {0}", ProvincePath.FeatureClass);
            Console.WriteLine(); //space
            Console.WriteLine("     FeatureLayer name = {0}", Canada.Layers[1].Name);
            Console.WriteLine("     FeatureLayer featureClass = {0}", LakesPath.FeatureClass);
            Console.WriteLine(); //space
            Console.WriteLine("Map Name = {0} ", US.Name);
            Console.WriteLine("Layer Count = {0} ", US.Layers.Length);
            Console.WriteLine("     FeatureLayer name = {0}", US.Layers[0].Name);
            Console.WriteLine("     FeatureLayer featureClass = {0}", StatesPath.FeatureClass);
            Console.WriteLine(); //space
            Console.WriteLine("     FeatureLayer name = {0}", US.Layers[1].Name);
            Console.WriteLine("     FeatureLayer featureClass = {0}", UsLakesPath.FeatureClass);
            Console.WriteLine(); //space
            Console.WriteLine("     FeatureLayer name = {0}", US.Layers[2].Name);
            Console.WriteLine("     FeatureLayer featureClass = {0}", RiverPath.FeatureClass);

            Mymap.RemoveMap(0);
            
            US.RemoveLayer(2);

            Console.WriteLine("Map Document Report");
            Console.WriteLine("Focus Map = {0} ", Mapname.FocusMap.Name);
            Console.WriteLine("Map Name = {0} ", Canada.Name);
            Console.WriteLine("Layer Count = {0} ", Canada.Layers.Length);
            Console.WriteLine("     FeatureLayer name = {0}", Canada.Layers[0].Name);
            Console.WriteLine("     FeatureLayer featureClass = {0}", ProvincePath.FeatureClass);
            Console.WriteLine(); //space
            Console.WriteLine("     FeatureLayer name = {0}", Canada.Layers[1].Name);
            Console.WriteLine("     FeatureLayer featureClass = {0}", LakesPath.FeatureClass);
            Console.WriteLine(); //space
            Console.WriteLine("Map Name = {0} ", US.Name);
            Console.WriteLine("Layer Count = {0} ", US.Layers.Length);
            Console.WriteLine("     FeatureLayer name = {0}", US.Layers[0].Name);
            Console.WriteLine("     FeatureLayer featureClass = {0}", StatesPath.FeatureClass);
            Console.WriteLine(); //space
            Console.WriteLine("     FeatureLayer name = {0}", US.Layers[1].Name);
            Console.WriteLine("     FeatureLayer featureClass = {0}", UsLakesPath.FeatureClass);
            Console.WriteLine(); //space
            Console.WriteLine("     FeatureLayer name = {0}", US.Layers[2].Name);
            Console.WriteLine("     FeatureLayer featureClass = {0}", RiverPath.FeatureClass);


            Console.ReadKey();
        }
        
    }
}
