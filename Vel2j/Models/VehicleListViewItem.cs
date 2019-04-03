using System;
using System.Windows.Forms;
using Vel2j.Entities;

namespace Vel2j.Models
{
    public class VehicleListViewItem : ListViewItem
    {
        public Vehicle Vehicle
        {
            get;
            private set;
        }

        public VehicleListViewItem(Vehicle vehicle) : base()
        {
            this.Vehicle = vehicle;
            this.Update();
        }

        public void Update()
        {
            this.Text = string.Empty;
            this.SubItems.Clear();

            this.Text = this.Vehicle.Model.ToString();
            this.SubItems.Add($"{this.Vehicle.Location.X:F2}");
            this.SubItems.Add($"{this.Vehicle.Location.Y:F2}");
            this.SubItems.Add($"{this.Vehicle.Location.Z:F2}");
            this.SubItems.Add($"{this.Vehicle.Location.W:F2}");
            this.SubItems.Add($"{this.Vehicle.Color.Primary}");
            this.SubItems.Add($"{this.Vehicle.Color.Secondary}");
            this.SubItems.Add($"{TimeSpan.FromSeconds(this.Vehicle.Respawn)}");
        }
    }
}
