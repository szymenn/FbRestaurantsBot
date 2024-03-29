using System;
using FbRestaurantsBot.Core.Helpers;
using Microsoft.AspNetCore.Http;

namespace FbRestaurantsBot.Core.Exceptions
{
    public class MessengerException : Exception
    {
        public int StatusCode { get; }
        public string ReasonPhrase { get; }

        public MessengerException()
        {
            StatusCode = StatusCodes.Status400BadRequest;
            ReasonPhrase = Constants.BadRequest;
        }

        public MessengerException(string message)
            : base(message)
        {
            StatusCode = StatusCodes.Status400BadRequest;
            ReasonPhrase = Constants.BadRequest;
        }

        public MessengerException(string message, Exception inner)
            : base(message, inner)
        {
            StatusCode = StatusCodes.Status400BadRequest;
            ReasonPhrase = Constants.BadRequest;
        }
    }
}