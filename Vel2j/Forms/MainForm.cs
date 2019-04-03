using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vel2j.Entities;
using Vel2j.Models;
using Newtonsoft.Json;
using System.Threading;

namespace Vel2j.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enabled = false;

            var nfmt = new NumberFormatInfo();
            nfmt.NumberDecimalSeparator = ".";
            nfmt.NumberGroupSeparator = ".";
            nfmt.CurrencyDecimalSeparator = ".";
            nfmt.CurrencyGroupSeparator = ".";
            nfmt.PercentDecimalSeparator = ".";
            nfmt.PercentGroupSeparator = ".";

            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                ofd.ShowReadOnly = true;
                ofd.ReadOnlyChecked = true;
                ofd.Multiselect = true;

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                int respawn = -1;

                using (var fd = new SetRespawnTimeForAllForm())
                {
                    if (fd.ShowDialog() != DialogResult.OK)
                        respawn = -1;
                    else
                        respawn = fd.RespawnTime;
                }

                foreach(var path in ofd.FileNames)
                {
                    using (var fs = new FileStream(path, FileMode.Open))
                    using (var reader = new StreamReader(fs))
                    {
                        var temp = new List<Vehicle>();
                        string line = null;

                        while ((line = reader.ReadLine()) != null)
                        {
                            var tokens = line.Split(',')
                                .ToList();

                            var index = 0;
                            var m = (VehicleModelType)int.Parse(tokens[index++]);
                            var x = float.Parse(tokens[index++], nfmt);
                            var y = float.Parse(tokens[index++], nfmt);
                            var z = float.Parse(tokens[index++], nfmt);
                            var w = float.Parse(tokens[index++], nfmt);
                            var p = int.Parse(tokens[index++]);

                            var eofp = tokens[index].IndexOf(';');
                            var eof = tokens[index];

                            var s = int.Parse(eof.Substring(0, eofp != -1 ? eofp - 1 : eof.Length));

                            var vel = new Vehicle();
                            vel.Model = m;
                            vel.Location = new VehicleQuaternion(x, w, z, w);
                            vel.Color = new VehicleColor(p, s);
                            vel.Respawn = respawn;

                            temp.Add(vel);
                        }

                        foreach (var vehicle in temp)
                        {
                            vehiclesList.Items.Add(new VehicleListViewItem(vehicle));
                        }
                    }
                }
            }

            Enabled = true;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                Enabled = false;

                sfd.Filter = "Json Files (*.json)|*.json|All Files (*.*)|*.*";
                sfd.CheckPathExists = true;

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                using (var fs = sfd.OpenFile())
                using (var writer = new StreamWriter(fs))
                {
                    var temp = new List<Vehicle>();

                    foreach(var item in vehiclesList.Items)
                    {
                        if(item is VehicleListViewItem vehicle)
                        {
                            temp.Add(vehicle.Vehicle);
                        }
                    }

                    writer.WriteLine(JsonConvert.SerializeObject(temp, Formatting.Indented));
                    temp = null;
                }

                Enabled = true;
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(var ofd = new OpenFileDialog())
            {
                var loading = new LoadingForm();
                loading.Show();

                Enabled = false;

                ofd.Filter = "Json Files (*.json)|*.json|All Files (*.*)|*.*";
                ofd.CheckPathExists = true;

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                vehiclesList.Groups.Clear();
                vehiclesList.Items.Clear();

                using (var fs = ofd.OpenFile())
                using (var reader = new StreamReader(fs))
                {
                    var temp = JsonConvert.DeserializeObject<IEnumerable<Vehicle>>(reader.ReadToEnd());

                    loading.SetMaximum(temp.Count());

                    foreach (var vehicle in temp)
                    {
                        vehiclesList.Items.Add(new VehicleListViewItem(vehicle));
                    }
                }

                loading.Close();
                loading.Dispose();
                loading = null;

                Enabled = true;
            }
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enabled = false;

            vehiclesList.Groups.Clear();
            vehiclesList.Items.Clear();

            Enabled = true;
        }
    }
}
