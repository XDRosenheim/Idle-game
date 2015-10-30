using System;
using System.Windows.Forms;

namespace Idle_game {
    public partial class Form1 : Form {
        private static long _coins;
        private static int _upgradeOneCost, _upgradeOneInterval, _upgradeOneGive;
        public Form1() {
            _coins = 0;
            InitializeComponent();
            lblCoins.Text = _coins.ToString();
            _upgradeOneCost = 10;
            _upgradeOneInterval = 1000;
            _upgradeOneGive = 1;

        }

        private void btnManuelClick_Click(object sender, EventArgs e) {
            _coins += 1;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            lblCoins.Text = _coins.ToString("N0");
            btnUpgOne.Enabled = _upgradeOneCost <= _coins;

        }

        private void upgrade1_Tick(object sender, EventArgs e) {
            _coins += _upgradeOneGive;
        }

        private void btnUpgOne_Click(object sender, EventArgs e) {
            _coins -= _upgradeOneCost;
            if (!upgrade1.Enabled) {
                upgrade1.Enabled = true;
            }
            label1.Text = _upgradeOneInterval.ToString();
            if (_upgradeOneInterval >= 50) {
                upgrade1.Interval = _upgradeOneInterval;
                if (_upgradeOneInterval - 50 >= 0)
                    _upgradeOneInterval = _upgradeOneInterval - 50;
                else _upgradeOneInterval = 1;
            }
            _upgradeOneGive += 1;
            _upgradeOneCost += 10;
        }
    }
}
