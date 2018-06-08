using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWAgain.API.Areas.Contracts
{
    public class StaticMessageResponder : IMessage
    {
        public string GetMessage()
        {
            return "Hello World";
        }
    }
}