using HWAgain.API.Areas.Contracts;
using HWAgain.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWAgain.API.Areas.Providers
{
    /// <summary>
    /// Gives the Message responder dynamically
    /// </summary>
    public class MessageProviderFactory
    {
        public IMessage MessageProvider { get; private set; }

        public MessageProviderFactory(IMessage messageProvider)
        {
            this.MessageProvider = messageProvider;
        }

        public MessageModel GetMessage()
        {
            return new MessageModel()
            {
                Content = this.MessageProvider.GetMessage()
            };
        }
    }
}