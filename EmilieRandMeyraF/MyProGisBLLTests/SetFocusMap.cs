using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProGisBLL;

namespace MyProGisBLLTests
{
    [TestClass]
    public class SetFocusMap
    {
        [TestMethod]
        public void SetFocusMap_AddMap_FocusMap()
        {
            IMapManager Mymap = new MapDocument();
            IMapDocument Mapname = (IMapDocument)Mymap;
            IMap testMap = new Map();
            IMap testMap1 = new Map();
            Mymap.AddMap(testMap);
            Mymap.AddMap(testMap1);
            testMap.Name = "Test1";
            testMap1.Name = "Test2";
            Mymap.SetFocusMap(0);

            Assert.AreEqual(testMap.Name, Mapname.FocusMap.Name);
        }
    }
}
