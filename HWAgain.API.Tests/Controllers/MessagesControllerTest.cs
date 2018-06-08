using System;
using HWAgain.API.Areas.Contracts;
using HWAgain.API.Areas.Providers;
using HWAgain.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HWAgain.API.Tests.Controllers
{
    [TestClass]
    public class MessagesControllerTest
    {
        [TestMethod]
        public void TestTestableMessageResponder()
        {
            MessageProviderFactory factory = new MessageProviderFactory(new  TestMessageResponder());
            MessageModel message = factory.GetMessage();
            Assert.AreEqual(message.Content, new MessageModel() { Content = "Hello World from Unit Test" }.Content);
        }
    }

    public class TestMessageResponder : IMessage
    {
        public string GetMessage()
        {
            return "Hello World from Unit Test";
        }
    }
}
