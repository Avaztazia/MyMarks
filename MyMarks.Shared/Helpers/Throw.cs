using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace MyMarks.Shared.Helpers;

public static class Throw
{
    [DoesNotReturn]
    public static void ArgumentNull(string name, object? additionalParams = null) =>
        throw new ArgumentNullException(name, JsonConvert.SerializeObject(additionalParams));
}