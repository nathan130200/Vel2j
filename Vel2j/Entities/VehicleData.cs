using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vel2j.Entities
{
    public class Vehicle : IEquatable<Vehicle>
    {
        [JsonIgnore]
        private VehicleQuaternion _quaternion;

        [JsonIgnore]
        private VehicleColor _color;

        public Vehicle()
        {

        }

        [JsonProperty("model")]
        public VehicleModelType Model { get; set; }

        [JsonProperty("location")]
        public VehicleQuaternion Location
        {

            get
            {
                if (_quaternion == null)
                    _quaternion = new VehicleQuaternion();

                return _quaternion;
            }
            set
            {
                _quaternion = value;
            }
        }

        [JsonProperty("color")]
        public VehicleColor Color
        {
            get
            {
                if (_color == null)
                    _color = new VehicleColor(0, 0);

                return _color;
            }
            set
            {
                _color = value;
            }
        }

        [JsonProperty("respawn")]
        public int Respawn { get; set; } = -1;

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Vehicle);
        }

        public bool Equals(Vehicle other)
        {
            return other != null &&
                this.Model == other.Model &&
                EqualityComparer<VehicleQuaternion>.Default.Equals(this.Location, other.Location) &&
                EqualityComparer<VehicleColor>.Default.Equals(this.Color, other.Color) &&
                this.Respawn == other.Respawn;
        }

        public override int GetHashCode()
        {
            var hashCode = -929881854;
            hashCode = hashCode * -1521134295 + this.Model.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<VehicleQuaternion>.Default.GetHashCode(this.Location);
            hashCode = hashCode * -1521134295 + EqualityComparer<VehicleColor>.Default.GetHashCode(this.Color);
            hashCode = hashCode * -1521134295 + this.Respawn.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Vehicle left, Vehicle right)
        {
            return EqualityComparer<Vehicle>.Default.Equals(left, right);
        }

        public static bool operator !=(Vehicle left, Vehicle right)
        {
            return !(left == right);
        }
    }
}