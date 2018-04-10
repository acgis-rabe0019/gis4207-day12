using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProGisBLL;

namespace MyProGisBLLTests
{
    [TestClass]
    public class RemoveMap
    {
        [TestMethod]
        public void RemoveMap_RemoveOnemap_ArrayMatches()
        {
            IMapManager Mymap = new MapDocument();
            IMapDocument Mapname = (IMapDocument)Mymap;
            IMap testMap = new Map();
            testMap.Name = "Test";
            Mymap.AddMap(testMap);
            Mymap.RemoveMap(1);
            Assert.AreEqual(testMap.Name, Mapname.Maps[0].Name);
        }
    }
}
