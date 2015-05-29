namespace ShutdownTimer_Pro
{
    partial class ShutdownTimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShutdownTimer));
            this.dev_label = new System.Windows.Forms.Label();
            this.dev_link = new System.Windows.Forms.LinkLabel();
            this.appname_label = new System.Windows.Forms.Label();
            this.timer_groupbox = new System.Windows.Forms.GroupBox();
            this.timer_disabler = new System.Windows.Forms.Button();
            this.seconds_updown = new System.Windows.Forms.NumericUpDown();
            this.seconds_label = new System.Windows.Forms.Label();
            this.minutes_updown = new System.Windows.Forms.NumericUpDown();
            this.minutes_label = new System.Windows.Forms.Label();
            this.hours_updown = new System.Windows.Forms.NumericUpDown();
            this.hours_label = new System.Windows.Forms.Label();
            this.language_combobox = new System.Windows.Forms.ComboBox();
            this.action_groupbox = new System.Windows.Forms.GroupBox();
            this.runapp_label = new System.Windows.Forms.Label();
            this.runapp_select = new System.Windows.Forms.Button();
            this.runapp_input = new System.Windows.Forms.TextBox();
            this.disable_combo = new System.Windows.Forms.RadioButton();
            this.runall_check = new System.Windows.Forms.CheckBox();
            this.forced_check = new System.Windows.Forms.CheckBox();
            this.sleep_combo = new System.Windows.Forms.RadioButton();
            this.hiber_combo = new System.Windows.Forms.RadioButton();
            this.reboot_combo = new System.Windows.Forms.RadioButton();
            this.shutdown_combo = new System.Windows.Forms.RadioButton();
            this.timer_status = new System.Windows.Forms.Label();
            this.starter_button = new System.Windows.Forms.Button();
            this.timer_progress = new System.Windows.Forms.ProgressBar();
            this.timer_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seconds_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours_updown)).BeginInit();
            this.action_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dev_label
            // 
            this.dev_label.AutoSize = true;
            this.dev_label.Cursor = System.Windows.Forms.Cursors.Help;
            this.dev_label.Location = new System.Drawing.Point(12, 255);
            this.dev_label.Name = "dev_label";
            this.dev_label.Size = new System.Drawing.Size(105, 13);
            this.dev_label.TabIndex = 0;
            this.dev_label.Text = "Developed by Inferik";
            // 
            // dev_link
            // 
            this.dev_link.AutoSize = true;
            this.dev_link.Location = new System.Drawing.Point(413, 255);
            this.dev_link.Name = "dev_link";
            this.dev_link.Size = new System.Drawing.Size(58, 13);
            this.dev_link.TabIndex = 1;
            this.dev_link.TabStop = true;
            this.dev_link.Text = "inferik.com";
            // 
            // appname_label
            // 
            this.appname_label.AutoSize = true;
            this.appname_label.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.appname_label.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.appname_label.Location = new System.Drawing.Point(12, 8);
            this.appname_label.Name = "appname_label";
            this.appname_label.Size = new System.Drawing.Size(149, 21);
            this.appname_label.TabIndex = 2;
            this.appname_label.Text = "ShutdownTimer Pro";
            // 
            // timer_groupbox
            // 
            this.timer_groupbox.Controls.Add(this.timer_disabler);
            this.timer_groupbox.Controls.Add(this.seconds_updown);
            this.timer_groupbox.Controls.Add(this.seconds_label);
            this.timer_groupbox.Controls.Add(this.minutes_updown);
            this.timer_groupbox.Controls.Add(this.minutes_label);
            this.timer_groupbox.Controls.Add(this.hours_updown);
            this.timer_groupbox.Controls.Add(this.hours_label);
            this.timer_groupbox.Location = new System.Drawing.Point(15, 32);
            this.timer_groupbox.Name = "timer_groupbox";
            this.timer_groupbox.Size = new System.Drawing.Size(456, 66);
            this.timer_groupbox.TabIndex = 3;
            this.timer_groupbox.TabStop = false;
            this.timer_groupbox.Text = "Timer";
            // 
            // timer_disabler
            // 
            this.timer_disabler.Location = new System.Drawing.Point(382, 38);
            this.timer_disabler.Name = "timer_disabler";
            this.timer_disabler.Size = new System.Drawing.Size(68, 23);
            this.timer_disabler.TabIndex = 8;
            this.timer_disabler.Text = "Disable";
            this.timer_disabler.UseVisualStyleBackColor = true;
            this.timer_disabler.Click += new System.EventHandler(this.timer_disabler_Click);
            // 
            // seconds_updown
            // 
            this.seconds_updown.Location = new System.Drawing.Point(256, 40);
            this.seconds_updown.Name = "seconds_updown";
            this.seconds_updown.Size = new System.Drawing.Size(120, 20);
            this.seconds_updown.TabIndex = 7;
            this.seconds_updown.ValueChanged += new System.EventHandler(this.seconds_updown_ValueChanged);
            // 
            // seconds_label
            // 
            this.seconds_label.AutoSize = true;
            this.seconds_label.Location = new System.Drawing.Point(327, 24);
            this.seconds_label.Name = "seconds_label";
            this.seconds_label.Size = new System.Drawing.Size(49, 13);
            this.seconds_label.TabIndex = 6;
            this.seconds_label.Text = "Seconds";
            // 
            // minutes_updown
            // 
            this.minutes_updown.Location = new System.Drawing.Point(133, 40);
            this.minutes_updown.Name = "minutes_updown";
            this.minutes_updown.Size = new System.Drawing.Size(120, 20);
            this.minutes_updown.TabIndex = 5;
            this.minutes_updown.ValueChanged += new System.EventHandler(this.minutes_updown_ValueChanged);
            // 
            // minutes_label
            // 
            this.minutes_label.AutoSize = true;
            this.minutes_label.Location = new System.Drawing.Point(209, 24);
            this.minutes_label.Name = "minutes_label";
            this.minutes_label.Size = new System.Drawing.Size(44, 13);
            this.minutes_label.TabIndex = 4;
            this.minutes_label.Text = "Minutes";
            // 
            // hours_updown
            // 
            this.hours_updown.Location = new System.Drawing.Point(6, 40);
            this.hours_updown.Name = "hours_updown";
            this.hours_updown.Size = new System.Drawing.Size(120, 20);
            this.hours_updown.TabIndex = 3;
            this.hours_updown.ValueChanged += new System.EventHandler(this.hours_updown_ValueChanged);
            // 
            // hours_label
            // 
            this.hours_label.AutoSize = true;
            this.hours_label.Location = new System.Drawing.Point(82, 24);
            this.hours_label.Name = "hours_label";
            this.hours_label.Size = new System.Drawing.Size(35, 13);
            this.hours_label.TabIndex = 2;
            this.hours_label.Text = "Hours";
            // 
            // language_combobox
            // 
            this.language_combobox.FormattingEnabled = true;
            this.language_combobox.Items.AddRange(new object[] {
            "English",
            "Russian",
            "Ukranian"});
            this.language_combobox.Location = new System.Drawing.Point(350, 8);
            this.language_combobox.Name = "language_combobox";
            this.language_combobox.Size = new System.Drawing.Size(121, 21);
            this.language_combobox.TabIndex = 4;
            this.language_combobox.Text = "Language";
            // 
            // action_groupbox
            // 
            this.action_groupbox.Controls.Add(this.runapp_label);
            this.action_groupbox.Controls.Add(this.runapp_select);
            this.action_groupbox.Controls.Add(this.runapp_input);
            this.action_groupbox.Controls.Add(this.disable_combo);
            this.action_groupbox.Controls.Add(this.runall_check);
            this.action_groupbox.Controls.Add(this.forced_check);
            this.action_groupbox.Controls.Add(this.sleep_combo);
            this.action_groupbox.Controls.Add(this.hiber_combo);
            this.action_groupbox.Controls.Add(this.reboot_combo);
            this.action_groupbox.Controls.Add(this.shutdown_combo);
            this.action_groupbox.Location = new System.Drawing.Point(15, 105);
            this.action_groupbox.Name = "action_groupbox";
            this.action_groupbox.Size = new System.Drawing.Size(456, 97);
            this.action_groupbox.TabIndex = 4;
            this.action_groupbox.TabStop = false;
            this.action_groupbox.Text = "Action";
            // 
            // runapp_label
            // 
            this.runapp_label.AutoSize = true;
            this.runapp_label.Location = new System.Drawing.Point(182, 24);
            this.runapp_label.Name = "runapp_label";
            this.runapp_label.Size = new System.Drawing.Size(81, 13);
            this.runapp_label.TabIndex = 7;
            this.runapp_label.Text = "Run application";
            // 
            // runapp_select
            // 
            this.runapp_select.Enabled = false;
            this.runapp_select.Location = new System.Drawing.Point(364, 66);
            this.runapp_select.Name = "runapp_select";
            this.runapp_select.Size = new System.Drawing.Size(75, 23);
            this.runapp_select.TabIndex = 2;
            this.runapp_select.Text = "Browse";
            this.runapp_select.UseVisualStyleBackColor = true;
            // 
            // runapp_input
            // 
            this.runapp_input.Location = new System.Drawing.Point(185, 43);
            this.runapp_input.Name = "runapp_input";
            this.runapp_input.ReadOnly = true;
            this.runapp_input.Size = new System.Drawing.Size(253, 20);
            this.runapp_input.TabIndex = 1;
            this.runapp_input.Text = "Click Browse to select";
            // 
            // disable_combo
            // 
            this.disable_combo.AutoSize = true;
            this.disable_combo.Location = new System.Drawing.Point(85, 69);
            this.disable_combo.Name = "disable_combo";
            this.disable_combo.Size = new System.Drawing.Size(60, 17);
            this.disable_combo.TabIndex = 6;
            this.disable_combo.TabStop = true;
            this.disable_combo.Text = "Disable";
            this.disable_combo.UseVisualStyleBackColor = true;
            this.disable_combo.CheckedChanged += new System.EventHandler(this.disable_combo_CheckedChanged);
            // 
            // runall_check
            // 
            this.runall_check.AutoSize = true;
            this.runall_check.Location = new System.Drawing.Point(185, 66);
            this.runall_check.Name = "runall_check";
            this.runall_check.Size = new System.Drawing.Size(59, 17);
            this.runall_check.TabIndex = 0;
            this.runall_check.Text = "Enable";
            this.runall_check.UseVisualStyleBackColor = true;
            // 
            // forced_check
            // 
            this.forced_check.AutoSize = true;
            this.forced_check.Location = new System.Drawing.Point(7, 70);
            this.forced_check.Name = "forced_check";
            this.forced_check.Size = new System.Drawing.Size(59, 17);
            this.forced_check.TabIndex = 4;
            this.forced_check.Text = "Forced";
            this.forced_check.UseVisualStyleBackColor = true;
            this.forced_check.CheckedChanged += new System.EventHandler(this.forced_check_CheckedChanged);
            // 
            // sleep_combo
            // 
            this.sleep_combo.AutoSize = true;
            this.sleep_combo.Location = new System.Drawing.Point(86, 42);
            this.sleep_combo.Name = "sleep_combo";
            this.sleep_combo.Size = new System.Drawing.Size(52, 17);
            this.sleep_combo.TabIndex = 3;
            this.sleep_combo.TabStop = true;
            this.sleep_combo.Text = "Sleep";
            this.sleep_combo.UseVisualStyleBackColor = true;
            this.sleep_combo.CheckedChanged += new System.EventHandler(this.sleep_combo_CheckedChanged);
            // 
            // hiber_combo
            // 
            this.hiber_combo.AutoSize = true;
            this.hiber_combo.Location = new System.Drawing.Point(86, 19);
            this.hiber_combo.Name = "hiber_combo";
            this.hiber_combo.Size = new System.Drawing.Size(71, 17);
            this.hiber_combo.TabIndex = 2;
            this.hiber_combo.TabStop = true;
            this.hiber_combo.Text = "Hibernate";
            this.hiber_combo.UseVisualStyleBackColor = true;
            this.hiber_combo.CheckedChanged += new System.EventHandler(this.hiber_combo_CheckedChanged);
            // 
            // reboot_combo
            // 
            this.reboot_combo.AutoSize = true;
            this.reboot_combo.Location = new System.Drawing.Point(7, 43);
            this.reboot_combo.Name = "reboot_combo";
            this.reboot_combo.Size = new System.Drawing.Size(60, 17);
            this.reboot_combo.TabIndex = 1;
            this.reboot_combo.TabStop = true;
            this.reboot_combo.Text = "Reboot";
            this.reboot_combo.UseVisualStyleBackColor = true;
            this.reboot_combo.CheckedChanged += new System.EventHandler(this.reboot_combo_CheckedChanged);
            // 
            // shutdown_combo
            // 
            this.shutdown_combo.AutoSize = true;
            this.shutdown_combo.Location = new System.Drawing.Point(7, 20);
            this.shutdown_combo.Name = "shutdown_combo";
            this.shutdown_combo.Size = new System.Drawing.Size(73, 17);
            this.shutdown_combo.TabIndex = 0;
            this.shutdown_combo.TabStop = true;
            this.shutdown_combo.Text = "Shutdown";
            this.shutdown_combo.UseVisualStyleBackColor = true;
            this.shutdown_combo.CheckedChanged += new System.EventHandler(this.shutdown_combo_CheckedChanged);
            // 
            // timer_status
            // 
            this.timer_status.AutoSize = true;
            this.timer_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.timer_status.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.timer_status.Location = new System.Drawing.Point(12, 232);
            this.timer_status.Name = "timer_status";
            this.timer_status.Size = new System.Drawing.Size(74, 13);
            this.timer_status.TabIndex = 5;
            this.timer_status.Text = "timer_identifier";
            this.timer_status.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // starter_button
            // 
            this.starter_button.Location = new System.Drawing.Point(376, 207);
            this.starter_button.Name = "starter_button";
            this.starter_button.Size = new System.Drawing.Size(95, 41);
            this.starter_button.TabIndex = 6;
            this.starter_button.Text = "Start";
            this.starter_button.UseVisualStyleBackColor = true;
            // 
            // timer_progress
            // 
            this.timer_progress.Location = new System.Drawing.Point(15, 208);
            this.timer_progress.Name = "timer_progress";
            this.timer_progress.Size = new System.Drawing.Size(355, 22);
            this.timer_progress.TabIndex = 7;
            // 
            // ShutdownTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 274);
            this.Controls.Add(this.timer_progress);
            this.Controls.Add(this.appname_label);
            this.Controls.Add(this.starter_button);
            this.Controls.Add(this.timer_status);
            this.Controls.Add(this.action_groupbox);
            this.Controls.Add(this.language_combobox);
            this.Controls.Add(this.timer_groupbox);
            this.Controls.Add(this.dev_link);
            this.Controls.Add(this.dev_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShutdownTimer";
            this.Text = "ShutdownTimer Pro";
            this.timer_groupbox.ResumeLayout(false);
            this.timer_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seconds_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours_updown)).EndInit();
            this.action_groupbox.ResumeLayout(false);
            this.action_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dev_label;
        private System.Windows.Forms.LinkLabel dev_link;
        private System.Windows.Forms.Label appname_label;
        private System.Windows.Forms.GroupBox timer_groupbox;
        private System.Windows.Forms.ComboBox language_combobox;
        private System.Windows.Forms.GroupBox action_groupbox;
        private System.Windows.Forms.Label timer_status;
        private System.Windows.Forms.Button starter_button;
        private System.Windows.Forms.ProgressBar timer_progress;
        private System.Windows.Forms.Label hours_label;
        private System.Windows.Forms.NumericUpDown hours_updown;
        private System.Windows.Forms.NumericUpDown seconds_updown;
        private System.Windows.Forms.Label seconds_label;
        private System.Windows.Forms.NumericUpDown minutes_updown;
        private System.Windows.Forms.Label minutes_label;
        private System.Windows.Forms.Button timer_disabler;
        private System.Windows.Forms.CheckBox forced_check;
        private System.Windows.Forms.RadioButton sleep_combo;
        private System.Windows.Forms.RadioButton hiber_combo;
        private System.Windows.Forms.RadioButton reboot_combo;
        private System.Windows.Forms.RadioButton shutdown_combo;
        private System.Windows.Forms.Button runapp_select;
        private System.Windows.Forms.TextBox runapp_input;
        private System.Windows.Forms.CheckBox runall_check;
        private System.Windows.Forms.RadioButton disable_combo;
        private System.Windows.Forms.Label runapp_label;
    }
}

