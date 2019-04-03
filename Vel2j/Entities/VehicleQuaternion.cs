using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Vel2j.Entities
{
    public class VehicleQuaternion : IEquatable<VehicleQuaternion>
    {
        [JsonIgnore]
        public static readonly VehicleQuaternion Empty = new VehicleQuaternion(0, 0, 0, 0);

        public VehicleQuaternion()
        {

        }

        public VehicleQuaternion(float x, float y, float z, float w)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.W = w;
        }

        [JsonProperty("x")]
        public float X { get; set; }

        [JsonProperty("y")]
        public float Y { get; set; }

        [JsonProperty("z")]
        public float Z { get; set; }

        [JsonProperty("w")]
        public float W { get; set; }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as VehicleQuaternion);
        }

        public bool Equals(VehicleQuaternion other)
        {
            return other != null &&
                   this.X == other.X &&
                   this.Y == other.Y &&
                   this.Z == other.Z &&
                   this.W == other.W;
        }

        public override int GetHashCode()
        {
            var hashCode = 707706286;
            hashCode = hashCode * -1521134295 + this.X.GetHashCode();
            hashCode = hashCode * -1521134295 + this.Y.GetHashCode();
            hashCode = hashCode * -1521134295 + this.Z.GetHashCode();
            hashCode = hashCode * -1521134295 + this.W.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(VehicleQuaternion left, VehicleQuaternion right)
        {
            return EqualityComparer<VehicleQuaternion>.Default.Equals(left, right);
        }

        public static bool operator !=(VehicleQuaternion left, VehicleQuaternion right)
        {
            return !(left == right);
        }
    }
}
