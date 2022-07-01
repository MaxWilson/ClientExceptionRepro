using Microsoft.Dynamics.Commerce.Runtime;
using MSE.D365.Library.Telemetry;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MSE.D365.RetailServer.Extensions
{
    public static class ResponseHelper
    {
        public static void NullCheck<T>(T arg, string argName)
        {
            if (arg == null || (arg is string && string.IsNullOrWhiteSpace(arg as string)))
            {
                throw new CommerceException(argName, $"'{argName}' must be set in request");
            }
        }

        // returns an exception just so you can use it to satisfy the typechecker
        public static CommerceException Fail(string msg)
        {
            throw new CommerceException(msg, msg);
        }

        public static PagedResult<T> ToPagedResult<T>(this IEnumerable<T> input) => new PagedResult<T>((input == null ? new T[0] : input).AsReadOnly(), false);

        public static T ValidateJsonParameter<T>(string json, string parameterName, [CallerMemberName] string method = null)
        where T : class
        {
            try
            {
                var converted = JsonConvert.DeserializeObject<T>(json);
                return converted;
            }
            catch (Exception e)
            {
                throw Fail($"'{parameterName}'  from '{method}' - {e.Message}");
            }
        }
    }
}
