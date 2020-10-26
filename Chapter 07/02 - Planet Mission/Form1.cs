using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02___Planet_Mission
{
    public partial class Form1 : Form
    {
        class Mars : PlanetMission
        {
            public Mars()
            {
                SetMissionInfo(75000000, 100000, 25000);
            }
            public override void SetMissionInfo(int milesToPlanet, int rocketFuelPerMile, long rocketSpeedMPH)
            {
                this.MilesToPlanet = milesToPlanet;
                this.RocketFuelPerMile = rocketFuelPerMile;
                this.RocketSpeedMPH = rocketSpeedMPH;
            }
        }


        class Venus : PlanetMission
        {
            public Venus()
            {
                SetMissionInfo(40000000, 100000, 25000);
            }
            public override void SetMissionInfo(int milesToPlanet, int rocketFuelPerMile, long rocketSpeedMPH)
            {
                this.MilesToPlanet = milesToPlanet;
                this.RocketFuelPerMile = rocketFuelPerMile;
                this.RocketSpeedMPH = rocketSpeedMPH;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mars mars = new Mars();
            MessageBox.Show(mars.FuelNeeded());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Venus venus = new Venus();
            MessageBox.Show(venus.FuelNeeded());
        }

        private void button3_Click(object sender, EventArgs e)
        {
/*            PlanetMission planet = new PlanetMission();
            MessageBox.Show(planet.FuelNeeded());
*/        }
    }
}

