using System;
using System.Net;
using System.Runtime.Serialization;

namespace esapm
{
    [Serializable]
    public class HttpResponseException : Exception
    {
        public HttpResponseException(Exception E, int Status)
        {
            this.Status = Status;
            this.Value = E;
        }
        public int Status { get; }

        public object Value { get; }
    }
}