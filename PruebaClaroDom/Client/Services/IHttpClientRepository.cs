using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaClaroDom.Client.Services
{
    public interface IHttpClientRepository
    {
        Task<HttpResponseWrapper<object>> Delete(string url);
        Task<HttpResponseWrapper<T>> Get<T>(string url);
        Task<HttpResponseWrapper<object>> Post<T>(string url, T deliver);
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T deliver);
        Task<HttpResponseWrapper<object>> Put<T>(string url, T deliver);
    }
}
