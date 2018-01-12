using System.ComponentModel;

namespace DariusDDD.Domain.Enums
{
    public enum TypeTransmission
    {
        [Description("Transmisie fata")]
        Front = 1,
        [Description("Transmisie 4x4")]
        Double = 2
    }
}
