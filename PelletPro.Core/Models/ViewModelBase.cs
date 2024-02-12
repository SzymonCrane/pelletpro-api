using System.Net;

namespace PelletPro.Application.Models
{
    public class ViewModelBase
    {
        public void Set(HttpStatusCode status, string message = null)
        {
            Status = status;
            Code = (int)status;
            Message = message;
        }
        public HttpStatusCode Status { get; private set; }
        public int Code { get; private set; }
        public string Message { get; private set; }
    }
}
