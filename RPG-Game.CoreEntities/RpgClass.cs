using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RPG_Game.CoreEntities
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        KNIGHT = 1,
        MAGE = 2,
        CLERIC = 3
    }
}
