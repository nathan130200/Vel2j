using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Vel2j.Entities
{
    public class VehicleColor : IEquatable<VehicleColor>
    {
        [JsonIgnore]
        public static readonly VehicleColor Empty = new VehicleColor(0, 0);

        public VehicleColor()
        {

        }

        public VehicleColor(int primary, int secondary)
        {
            this.Primary = primary;
            this.Secondary = secondary;
        }

        [JsonProperty("primary")]
        public int Primary { get; set; } = 0;

        [JsonProperty("secondary")]
        public int Secondary { get; set; } = 0;

        public override bool Equals(object obj)
        {
            return this.Equals(obj as VehicleColor);
        }

        public bool Equals(VehicleColor other)
        {
            return other != null &&
                   this.Primary == other.Primary &&
                   this.Secondary == other.Secondary;
        }

        public override int GetHashCode()
        {
            var hashCode = -1305200686;
            hashCode = hashCode * -1521134295 + this.Primary.GetHashCode();
            hashCode = hashCode * -1521134295 + this.Secondary.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(VehicleColor left, VehicleColor right)
        {
            return EqualityComparer<VehicleColor>.Default.Equals(left, right);
        }

        public static bool operator !=(VehicleColor left, VehicleColor right)
        {
            return !(left == right);
        }
    }
}
