using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWAgain.API.Areas.Contracts
{
    /// <summary>
    /// Interface for our messaging system
    /// </summary>
    public interface IMessage
    {
        string GetMessage();
    }
}
