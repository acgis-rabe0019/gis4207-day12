using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProGisBLL;

namespace MyProGisBLLTests
{
    [TestClass]
    public class GetMap
    {
        [TestMethod]
        public void GetMap_AddOneMap_NameMatches()
        {
            IMapManager Mymap = new MapDocument();
            IMapDocument Mapname = (IMapDocument)Mymap;
            IMap testMap = new Map();
            testMap.Name = "Test";
            Mymap.AddMap(testMap);

            Assert.AreEqual(testMap.Name, Mapname.Maps[0].Name);

        }
    }
}
