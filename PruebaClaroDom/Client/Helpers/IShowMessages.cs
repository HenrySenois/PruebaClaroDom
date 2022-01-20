using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaClaroDom.Client.Helpers
{
    interface IShowMessages
    {
        Task ShowErrorMessage(string message);
        Task ShowSuccessfulMessage(string message);
    }
}
