using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongProject;
using System.Collections.Generic;
using PingPongProject.Models;

namespace PingPongProject.Tests
{
  [TestClass]
  public class PingPongProjectTest
  {
    [TestMethod]
    public void TestNumberCalc()
    {
      PingPong newPingPong = new PingPong();
      List<string> setValuesPingPongList = new List<string>{"1","2","Pong","4","Ping"};
      CollectionAssert.AreEqual(setValuesPingPongList, newPingPong.NumberCalc(5));
    }
  }
}
