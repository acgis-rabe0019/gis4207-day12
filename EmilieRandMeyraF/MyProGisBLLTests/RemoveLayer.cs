using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProGisBLL;

namespace MyProGisBLLTests
{
    [TestClass]
    public class RemoveLayer
    {
        [TestMethod]
        public void RemoveLayer_RemoveOnelayer_ArrayMatches()
        {
            IMap map = new Map();
            ILayer layer = new Layer();
            layer.Name = "Test";
            map.AddLayer(layer);
            map.RemoveLayer(1);
            Assert.AreEqual(layer.Name, map.Layers[0].Name);
        }
    }
}
