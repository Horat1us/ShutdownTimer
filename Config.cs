using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ShutdownTimer_Pro
{
    public class Config
    {
        private string configDirPath = Path.GetTempPath() + "\\shutdown_timer\\";
        public Config()
        {
            if(!Directory.Exists(this.configDirPath))
            {
                Directory.CreateDirectory(this.configDirPath);
            }
        }
        // Saving configuration values to files in template directory
        private void writeValue(string name,string value)
        {
            string confPath = this.configDirPath + name;
            if (File.Exists(confPath))
            {
                File.Delete(confPath);
            }
            File.WriteAllText(
                confPath,
                value
            );
        }
        private void writeValue(string name, int value)
        {
            string value_converted = Convert.ToString(value);
            this.writeValue(name,value_converted);
        }
        private void writeValue(string name, bool value)
        {
            string value_converted = value ? "true" : "false";
            this.writeValue(name,value_converted);
        }
        private void writeValue(string name, int[]value)
        {
            string values_converted = String.Join("|", value);
            this.writeValue(name, values_converted);
        }

        // Checking variables for default value
        private bool checkVariable(string value)
        {
            return value != "";
        }
        private bool checkVariable(int value)
        {
            return value != 0;
        }
        private bool checkVariable(int[] value)
        {
            return value.Length > 2 ? (value[2] != 0) : false;
        }
        private bool checkVariable(bool value)
        {
            return !value;
        }

        // Reading config file
        private string readConfig(string name)
        {
            string confPath = this.configDirPath + name;
            return
                File.Exists(confPath)
                ?   File.ReadAllText(confPath)
                :   "";
        }
        private int getConfigInt(string name)
        {
            string config = this.readConfig(name);
            return config == "" ? 0 : Convert.ToInt32(config);
        }
        private int[] getConfigIntRow(string name,int[] defaults)
        {
            string config = this.readConfig(name);
            if(config=="")
                return defaults;
            string[] res = config.Split('|'); // Result
            int[] ret = new int[res.Length];
            int i = 0;
            foreach(string element in res)
                ret[i++] = Convert.ToInt32(element);
            return ret;
        }
        private string getConfigString(string name)
        {
            return this.readConfig(name);
        }
        private bool getConfigBoolean(string name)
        {
            string config = this.readConfig(name);
            return !(config == "" || config == "false");
        }
        /*
         * Configuration variables
         */

        public bool
           timerEnableProperty = true;
        public bool timerEnabled
        {
            get
            {
                if (this.checkVariable(this.timerEnableProperty))
                {
                    return this.timerEnableProperty;
                }
                else
                {
                    return this.timerEnableProperty =
                        this.getConfigBoolean("timerEnabled");
                }
            }
            set
            {
                this.timerEnableProperty = value;
                this.writeValue("timerEnabled", value);
            }
        }

        /*
         * Languages:
         *  0 - English
         *  1 - Russian
         *  2 - Ukranian
         *  .. to be continued
         */
        private int
            languageProperty = 0;
        public int language
        {
            get
            {
                if (this.checkVariable(this.languageProperty))
                    return this.languageProperty;
                else
                    return this.languageProperty =
                        this.getConfigInt("language");
            }
            set
            {
                this.languageProperty = value;
                this.writeValue("language", value);
            }
        }

        private int[] timerProperty =
           new int[3] { 0, 0, 0 };
        /*
         * Actions:
         *  0 - Disabled
         *  1 - Shutdown
         *  2 - Hibernate
         *  3 - Reboot
         *  4 - Sleep
         *  The end
         */
        public int[] timer
        {
            get
            {
                if (this.checkVariable(this.timerProperty))
                {
                    return this.timerProperty;
                }
                else
                {
                    return this.timerProperty =
                        this.getConfigIntRow(
                            "timer",
                            this.timerProperty
                        );
                }
            }
            set
            {
                this.timerProperty = value;
                this.writeValue("timer", value);
            }
        }

        private int
            actionTypeProperty = 0;
        public int actionType
        {
            get
            {
                if (this.checkVariable(this.actionTypeProperty))
                    return this.actionTypeProperty;
                else
                    return this.actionTypeProperty =
                        this.getConfigInt("actionType");
            }
            set
            {
                this.actionTypeProperty = value;
                this.writeValue("actionType", value);
            }
        }

        private bool
            forcedActionProperty = false;
        public bool forcedAction
        {
            get
            {
                if (this.checkVariable(this.forcedActionProperty))
                    return this.forcedActionProperty;
                else
                    return this.forcedActionProperty =
                        this.getConfigBoolean("forcedAction");
            }
            set
            {
                this.forcedActionProperty = value;
                this.writeValue("forcedAction", value);
            }
        }
        // Run application
        private bool
            runEnabledProperty = false;
        public bool runEnabled
        {
            get
            {
                if (this.checkVariable(this.runEnabledProperty))
                    return this.runEnabledProperty;
                else
                    return this.runEnabledProperty =
                        this.getConfigBoolean("runEnabled");
            }
            set
            {
                this.runEnabledProperty = value;
                this.writeValue("runEnabled", value);
            }
        }

        private string
            runTargetProperty = "";
        public string runTarget
        {
            get
            {
                if (this.checkVariable(this.runTargetProperty))
                    return this.runTargetProperty;
                else
                    return this.runTargetProperty =
                        this.getConfigString("runTarget");
            }
            set
            {
                this.runTargetProperty = value;
                this.writeValue("runTarget", value);
            }
        }
    }
}
