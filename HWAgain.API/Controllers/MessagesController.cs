using HWAgain.API.Areas.Contracts;
using HWAgain.API.Areas.Providers;
using HWAgain.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HWAgain.API.Controllers
{
    public class MessagesController : ApiController
    {
        // GET api/<controller>
        public MessageModel Get()
        {
            return new MessageProviderFactory(new StaticMessageResponder()).GetMessage();
        }
    }
}