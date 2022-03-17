using System;
using System.Net;

namespace CoinTracker.Models
{
    public class CoinTrackerResponse<T> where T : class
    {
        public CoinTrackerResponse(T data)
        {
            TranscationId = Guid.NewGuid();
            Data = data;
            DateTime = DateTime.Now;
        }

        public CoinTrackerResponse(Exception ex)
        {
            TranscationId = Guid.NewGuid();
            Status = HttpStatusCode.InternalServerError;
            Error = ex.Message;
            DateTime = DateTime.Now;
        }

        public CoinTrackerResponse(HttpResponseMessage response)
        {
            TranscationId = Guid.NewGuid();
            Status = response.StatusCode;
            Error = response.StatusCode.ToString();
            DateTime = DateTime.Now;
        }

        public Guid TranscationId { get; private set; }
        public T? Data { get; private set; }
        public HttpStatusCode? Status { get; private set; }
        public string? Message { get; set; }
        public string? Error { get; private set; }
        public DateTime DateTime { get; set; }

        public static CoinTrackerResponse<T> WithOk(T data) => new(data);
        public static CoinTrackerResponse<T> WithException(Exception ex) => new(ex);
        public static CoinTrackerResponse<T> WithException(HttpResponseMessage response) => new(response);
    }
}

