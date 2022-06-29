using System.Runtime.Serialization;

namespace RpgSandbox.Common;

public class ZombieApocalypseException : Exception
{
    public ZombieApocalypseException()
    {
    }

    protected ZombieApocalypseException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public ZombieApocalypseException(string message) : base(message)
    {
    }

    public ZombieApocalypseException(string message, Exception innerException) : base(message, innerException)
    {
    }
}