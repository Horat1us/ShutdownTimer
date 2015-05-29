using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ShutdownTimer_Pro
{
    
    public partial class ShutdownTimer : Form
    {
        
        // Config object initialization
        // Sync configuration with file DB
        private Config config = new Config();

        public ShutdownTimer()
        {
            InitializeComponent();


            // Loading values from config

            /* Timer */
            this.initTimer();
            /* Action Type and Forced checkbox */
            this.initAction();
        }

        private int actionType;
        private bool forcedAction;
        private void initAction()
        {
            this.actionType = this.config.actionType;
            switch(this.actionType)
            {
                case 0:
                    disable_combo.Checked = true;
                    break;
                case 1:
                    shutdown_combo.Checked = true;
                    break;
                case 2:
                    hiber_combo.Checked = true;
                    break;
                case 3:
                    reboot_combo.Checked = true;
                    break;
                case 4:
                    sleep_combo.Checked = true;
                    break;
            }
            forced_check.Checked = 
                this.forcedAction = 
                    this.config.forcedAction;
            
        }
        private void changeAction(int actionType)
        {
            if (actionType > 4)
                actionType = 0;
            this.config.actionType = this.actionType = actionType;
        }

        // Variable to stopping ValueChanged callback
        private bool timerInit;
        private bool timerEnable;
        private int[] timerData;
        private void initTimer()
        {
            this.timerInit = true;
            // Loading data from config
            this.timerData = config.timer;
            // Changing elements properties
            this.timerStatusChange(config.timerEnabled);
            // Loading values to elements from config
            this.loadTimerValues();
            this.timerInit = false;
        }
        private void timerStatusChange(bool status)
        {
            // Changing elements status
            hours_updown.Enabled = status;
            minutes_updown.Enabled = status;
            seconds_updown.Enabled = status;
            // Changing button text
            timer_disabler.Text = status ? "Disable" : "Enable";
            // Changing variable status
            this.timerEnable = config.timerEnabled = status;
        }
        private void loadTimerValues()
        {

            // If values not loaded from config
            // Or if values is nulled
            if (!(this.timerData.Length > 0))
            {
                for(int i=0;i<3;i++)
                    this.timerData[i] = 0;
            }
            seconds_updown.Value = this.timerData[2];
            minutes_updown.Value = this.timerData[1];
            hours_updown.Value = this.timerData[0];
            
        }
        private void updateTimerValues()
        {
            this.timerData[0] = Convert.ToInt32(hours_updown.Value);
            this.timerData[1] = Convert.ToInt32(minutes_updown.Value);
            this.timerData[2] = Convert.ToInt32(seconds_updown.Value);
            this.config.timer = this.timerData;
        }

        private void hours_updown_ValueChanged(object sender, EventArgs e)
        {
            if (this.timerInit)
                return;
            this.updateTimerValues();
        }

        private void minutes_updown_ValueChanged(object sender, EventArgs e)
        {
            if (this.timerInit)
                return;
            this.minutes_updown_ValueChanged();
        }
        private void minutes_updown_ValueChanged()
        {
            if (this.timerInit)
                return;
            if (Convert.ToInt32(minutes_updown.Value) > 60)
            {
                hours_updown.Value +=
                    Convert.ToInt32(minutes_updown.Value / 60);
                minutes_updown.Value = minutes_updown.Value % 60;
            }
            this.updateTimerValues();
        }

        private void seconds_updown_ValueChanged(object sender, EventArgs e)
        {
            if (this.timerInit)
                return;
            if (Convert.ToInt32(seconds_updown.Value) > 60)
            {
                minutes_updown.Value +=
                    Convert.ToInt32(seconds_updown.Value / 60);
               seconds_updown.Value %= 60;
            }
            this.updateTimerValues();
        }

        private void timer_disabler_Click(object sender, EventArgs e)
        {
            this.timerStatusChange(!this.timerEnable);
        }

        
        private void shutdown_combo_CheckedChanged(object sender, EventArgs e)
        {
            this.changeAction(1);
        }

        private void reboot_combo_CheckedChanged(object sender, EventArgs e)
        {
            this.changeAction(3);
        }

        private void sleep_combo_CheckedChanged(object sender, EventArgs e)
        {
            this.changeAction(4);
        }

        private void hiber_combo_CheckedChanged(object sender, EventArgs e)
        {
            this.changeAction(2);
        }

        private void disable_combo_CheckedChanged(object sender, EventArgs e)
        {
            this.changeAction(0);
        }

        private void forced_check_CheckedChanged(object sender, EventArgs e)
        {
            this.config.forcedAction =
                this.forcedAction =
                   !this.forcedAction;
        }

        private void changeElementsStatus(bool status)
        {
            hours_updown.Enabled = status;
            minutes_updown.Enabled = status;
            seconds_updown.Enabled = status;
            timer_disabler.Enabled = status;
            shutdown_combo.Enabled = status;
            reboot_combo.Enabled = status;
            sleep_combo.Enabled = status;
            hiber_combo.Enabled = status;
            forced_check.Enabled = status;
            disable_combo.Enabled = status;
            runall_check.Enabled = status;
            runapp_select.Enabled = status;
        }
        private void changeStartButton()
        {
            starter_button.Text = this.timer_on ? "Stop" : "Start";
        }
        private bool timer_on = false;
        public  System.Windows.Forms.Timer timer =
           new System.Windows.Forms.Timer();
        public int timerNow, timerEnd;
        private void starter_button_Click(object sender, EventArgs e)
        {
            this.timer_on = !this.timer_on;
            if(this.timer_on)
            {
               
                // Starting tick is 0
                this.timerNow = 0;
                this.timerEnd = 0;
                // Counting seconds to timer end
                for (int i = 0; i < 3; i++)
                    this.timerEnd +=
                        this.timerData[i]
                        * Convert.ToInt32((Math.Pow(60, 2-i)));
                MessageBox.Show(
                    "Timer is on. " 
                    + this.timerEnd 
                    + " seconds"
                );
                // Tick function is this.timerTick
                this.timer.Tick += new EventHandler(this.timerTick);
                this.timer.Interval = 1000; // One second interval
                this.timer_progress.Maximum = this.timerEnd;
                this.timer.Start();
            }
            else
            {
                MessageBox.Show("Timer is off");
                // Stopping timer
                this.timer.Stop();
                this.timer_progress.Value = 0;
            }
            this.changeStartButton();
            this.changeElementsStatus(!this.timer_on);
        }
        private void timerTick(Object sender, EventArgs e)
        {
            if(++this.timerNow>=this.timerEnd)
            {
                this.doAction();
                this.timer_on = !this.timer_on;
                this.changeStartButton();
                this.changeElementsStatus(this.timer_on);
                this.timer_progress.Value = 0;
            }
            else
            {
                this.timer_progress.Value = this.timerNow;
            }
        }
        private void doAction()
        {
            if (runall_check.Checked)
                this.runApp();
            string command = "";
            if(this.actionType==4)
            {
                command = 
                    "rundll32.exe powrprof.dll,SetSuspendState 0,1,0";
            }
            else if(this.actionType!=0 && this.actionType<5)
            {
                command = "shutdown ";
                switch(this.actionType)
                {
                    case 1:
                        command += "/s";
                        
                        break;
                    case 2:
                        command += "/h";
                        break;
                    case 3:
                        command += "/r";
                        break;
                }
                // Forced mode, if on
                if (forced_check.Checked)
                        command += " /f";
            }
            if(command.Length>0)
            {
                Process.Start(
                    "cmd.exe",
                    "/C " + command
                );
            }
        }
        private void runApp()
        {
            if(File.Exists(this.runapp_input.Text))
            {
                try
                {
                    Process.Start(this.runapp_input.Text);
                }
                catch
                {
                    MessageBox.Show(
                        "Unknown error"
                        );
                }
            }
            else
            {
                MessageBox.Show(
                    "Error: \n\r File: '"
                    + this.runapp_input.Text
                    + "' not exists");
            }
        }
    }
}
