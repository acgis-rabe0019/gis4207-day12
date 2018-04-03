using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProGisBLL;

namespace MyProGisBLLTests
{
    [TestClass]
    public class MapTests
    {
        [TestMethod]
        public void AddLayer_AddOneLayer_NameMatches()
        {
            IMap map = new Map();
            ILayer layer = new Layer();
            layer.Name = "Test";
            map.AddLayer(layer);
            Assert.AreEqual(layer.Name, map.Layers[0].Name);
        }
    }
}
