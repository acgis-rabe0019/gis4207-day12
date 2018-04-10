using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProGisBLL;

namespace MyProGisBLLTests
{
    [TestClass]
    public class AddMap
    {
        [TestMethod]
        public void AddMap_AddOneMap_Matches()
        {
            IMapManager Mymap = new MapDocument();
            IMapDocument Mapname = (IMapDocument)Mymap;
            IMap testMap = new Map();
            Mymap.AddMap(testMap);

            IMap expected = testMap;
            IMap actual = Mapname.Maps[0];
            Assert.AreEqual(expected, actual);

        }
    }
}
