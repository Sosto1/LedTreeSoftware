
namespace LedTreeSoftware
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.roundPanel_Settings = new LedTreeSoftware.RoundCornerControl();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Devices = new System.Windows.Forms.ComboBox();
            this.label_ArduinoStatus = new System.Windows.Forms.Label();
            this.label_SettingsHeader = new System.Windows.Forms.Label();
            this.roundedButton_Save = new LedTreeSoftware.RoundedButton();
            this.label_Port = new System.Windows.Forms.Label();
            this.comboBox_Ports = new System.Windows.Forms.ComboBox();
            this.roundPanel_Tree = new LedTreeSoftware.RoundCornerControl();
            this.label_TreeOff = new System.Windows.Forms.Label();
            this.roundPanel_ColorInfo = new LedTreeSoftware.RoundCornerControl();
            this.roundPanel_More = new LedTreeSoftware.RoundCornerControl();
            this.roundedButton_Sound = new LedTreeSoftware.RoundedButton();
            this.roundedButton_ColorCycle = new LedTreeSoftware.RoundedButton();
            this.roundedButton_Blue = new LedTreeSoftware.RoundedButton();
            this.roundedButton_Winter = new LedTreeSoftware.RoundedButton();
            this.roundedButton_Yellow = new LedTreeSoftware.RoundedButton();
            this.roundedButton_Green = new LedTreeSoftware.RoundedButton();
            this.roundPanel_ColorSpectre = new LedTreeSoftware.RoundCornerControl();
            this.roundedButton_MoreOptions = new LedTreeSoftware.RoundedButton();
            this.roundedButton_Settings = new LedTreeSoftware.RoundedButton();
            this.roundedButton_Power = new LedTreeSoftware.RoundedButton();
            this.roundPanel_Settings.SuspendLayout();
            this.roundPanel_Tree.SuspendLayout();
            this.roundPanel_More.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Hue";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // roundPanel_Settings
            // 
            this.roundPanel_Settings.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.roundPanel_Settings.Controls.Add(this.label1);
            this.roundPanel_Settings.Controls.Add(this.comboBox_Devices);
            this.roundPanel_Settings.Controls.Add(this.label_ArduinoStatus);
            this.roundPanel_Settings.Controls.Add(this.label_SettingsHeader);
            this.roundPanel_Settings.Controls.Add(this.roundedButton_Save);
            this.roundPanel_Settings.Controls.Add(this.label_Port);
            this.roundPanel_Settings.Controls.Add(this.comboBox_Ports);
            this.roundPanel_Settings.Location = new System.Drawing.Point(12, 12);
            this.roundPanel_Settings.Name = "roundPanel_Settings";
            this.roundPanel_Settings.Radius = 40;
            this.roundPanel_Settings.Size = new System.Drawing.Size(329, 180);
            this.roundPanel_Settings.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Audio device";
            // 
            // comboBox_Devices
            // 
            this.comboBox_Devices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Devices.FormattingEnabled = true;
            this.comboBox_Devices.Location = new System.Drawing.Point(153, 104);
            this.comboBox_Devices.Name = "comboBox_Devices";
            this.comboBox_Devices.Size = new System.Drawing.Size(156, 24);
            this.comboBox_Devices.TabIndex = 8;
            // 
            // label_ArduinoStatus
            // 
            this.label_ArduinoStatus.AutoSize = true;
            this.label_ArduinoStatus.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ArduinoStatus.ForeColor = System.Drawing.Color.Red;
            this.label_ArduinoStatus.Location = new System.Drawing.Point(73, 150);
            this.label_ArduinoStatus.Name = "label_ArduinoStatus";
            this.label_ArduinoStatus.Size = new System.Drawing.Size(150, 16);
            this.label_ArduinoStatus.TabIndex = 7;
            this.label_ArduinoStatus.Text = "Arduino disconnected";
            // 
            // label_SettingsHeader
            // 
            this.label_SettingsHeader.AutoSize = true;
            this.label_SettingsHeader.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_SettingsHeader.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SettingsHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_SettingsHeader.Location = new System.Drawing.Point(109, 1);
            this.label_SettingsHeader.Name = "label_SettingsHeader";
            this.label_SettingsHeader.Size = new System.Drawing.Size(88, 24);
            this.label_SettingsHeader.TabIndex = 6;
            this.label_SettingsHeader.Text = "Settings";
            // 
            // roundedButton_Save
            // 
            this.roundedButton_Save.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.roundedButton_Save.Location = new System.Drawing.Point(203, 45);
            this.roundedButton_Save.Name = "roundedButton_Save";
            this.roundedButton_Save.Radius = 30;
            this.roundedButton_Save.Size = new System.Drawing.Size(103, 38);
            this.roundedButton_Save.TabIndex = 4;
            this.roundedButton_Save.Text = "Save";
            this.roundedButton_Save.UseVisualStyleBackColor = true;
            this.roundedButton_Save.Click += new System.EventHandler(this.roundedButton_Save_Click);
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_Port.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Port.Location = new System.Drawing.Point(12, 53);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(48, 24);
            this.label_Port.TabIndex = 5;
            this.label_Port.Text = "Port";
            // 
            // comboBox_Ports
            // 
            this.comboBox_Ports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Ports.FormattingEnabled = true;
            this.comboBox_Ports.Location = new System.Drawing.Point(76, 53);
            this.comboBox_Ports.Name = "comboBox_Ports";
            this.comboBox_Ports.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Ports.TabIndex = 3;
            // 
            // roundPanel_Tree
            // 
            this.roundPanel_Tree.BackColor = System.Drawing.SystemColors.ControlLight;
            this.roundPanel_Tree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundPanel_Tree.BackgroundImage")));
            this.roundPanel_Tree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundPanel_Tree.Controls.Add(this.label_TreeOff);
            this.roundPanel_Tree.Controls.Add(this.roundPanel_ColorInfo);
            this.roundPanel_Tree.Location = new System.Drawing.Point(78, 12);
            this.roundPanel_Tree.Name = "roundPanel_Tree";
            this.roundPanel_Tree.Radius = 40;
            this.roundPanel_Tree.Size = new System.Drawing.Size(196, 236);
            this.roundPanel_Tree.TabIndex = 9;
            // 
            // label_TreeOff
            // 
            this.label_TreeOff.AutoSize = true;
            this.label_TreeOff.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TreeOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_TreeOff.Location = new System.Drawing.Point(83, 1);
            this.label_TreeOff.Name = "label_TreeOff";
            this.label_TreeOff.Size = new System.Drawing.Size(31, 19);
            this.label_TreeOff.TabIndex = 11;
            this.label_TreeOff.Text = "Off";
            // 
            // roundPanel_ColorInfo
            // 
            this.roundPanel_ColorInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.roundPanel_ColorInfo.Location = new System.Drawing.Point(76, 220);
            this.roundPanel_ColorInfo.Name = "roundPanel_ColorInfo";
            this.roundPanel_ColorInfo.Radius = 10;
            this.roundPanel_ColorInfo.Size = new System.Drawing.Size(44, 10);
            this.roundPanel_ColorInfo.TabIndex = 10;
            // 
            // roundPanel_More
            // 
            this.roundPanel_More.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.roundPanel_More.Controls.Add(this.roundedButton_Sound);
            this.roundPanel_More.Controls.Add(this.roundedButton_ColorCycle);
            this.roundPanel_More.Controls.Add(this.roundedButton_Blue);
            this.roundPanel_More.Controls.Add(this.roundedButton_Winter);
            this.roundPanel_More.Controls.Add(this.roundedButton_Yellow);
            this.roundPanel_More.Controls.Add(this.roundedButton_Green);
            this.roundPanel_More.Location = new System.Drawing.Point(12, 167);
            this.roundPanel_More.Name = "roundPanel_More";
            this.roundPanel_More.Radius = 40;
            this.roundPanel_More.Size = new System.Drawing.Size(329, 134);
            this.roundPanel_More.TabIndex = 8;
            // 
            // roundedButton_Sound
            // 
            this.roundedButton_Sound.BackColor = System.Drawing.SystemColors.ControlLight;
            this.roundedButton_Sound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedButton_Sound.BackgroundImage")));
            this.roundedButton_Sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedButton_Sound.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.roundedButton_Sound.FlatAppearance.BorderSize = 0;
            this.roundedButton_Sound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Sound.Location = new System.Drawing.Point(226, 70);
            this.roundedButton_Sound.Name = "roundedButton_Sound";
            this.roundedButton_Sound.Radius = 40;
            this.roundedButton_Sound.Size = new System.Drawing.Size(83, 50);
            this.roundedButton_Sound.TabIndex = 14;
            this.roundedButton_Sound.UseVisualStyleBackColor = false;
            this.roundedButton_Sound.Click += new System.EventHandler(this.roundedButton_Sound_Click);
            // 
            // roundedButton_ColorCycle
            // 
            this.roundedButton_ColorCycle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.roundedButton_ColorCycle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedButton_ColorCycle.BackgroundImage")));
            this.roundedButton_ColorCycle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedButton_ColorCycle.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.roundedButton_ColorCycle.FlatAppearance.BorderSize = 0;
            this.roundedButton_ColorCycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_ColorCycle.Location = new System.Drawing.Point(226, 14);
            this.roundedButton_ColorCycle.Name = "roundedButton_ColorCycle";
            this.roundedButton_ColorCycle.Radius = 40;
            this.roundedButton_ColorCycle.Size = new System.Drawing.Size(83, 50);
            this.roundedButton_ColorCycle.TabIndex = 13;
            this.roundedButton_ColorCycle.UseVisualStyleBackColor = false;
            this.roundedButton_ColorCycle.Click += new System.EventHandler(this.roundedButton_ColorCycle_Click);
            // 
            // roundedButton_Blue
            // 
            this.roundedButton_Blue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(188)))), ((int)(((byte)(245)))));
            this.roundedButton_Blue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedButton_Blue.BackgroundImage")));
            this.roundedButton_Blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedButton_Blue.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.roundedButton_Blue.FlatAppearance.BorderSize = 0;
            this.roundedButton_Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Blue.Location = new System.Drawing.Point(123, 70);
            this.roundedButton_Blue.Name = "roundedButton_Blue";
            this.roundedButton_Blue.Radius = 40;
            this.roundedButton_Blue.Size = new System.Drawing.Size(83, 50);
            this.roundedButton_Blue.TabIndex = 12;
            this.roundedButton_Blue.UseVisualStyleBackColor = false;
            this.roundedButton_Blue.Click += new System.EventHandler(this.roundedButton_Blue_Click);
            // 
            // roundedButton_Winter
            // 
            this.roundedButton_Winter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.roundedButton_Winter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedButton_Winter.BackgroundImage")));
            this.roundedButton_Winter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedButton_Winter.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.roundedButton_Winter.FlatAppearance.BorderSize = 0;
            this.roundedButton_Winter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Winter.Location = new System.Drawing.Point(123, 14);
            this.roundedButton_Winter.Name = "roundedButton_Winter";
            this.roundedButton_Winter.Radius = 40;
            this.roundedButton_Winter.Size = new System.Drawing.Size(83, 50);
            this.roundedButton_Winter.TabIndex = 11;
            this.roundedButton_Winter.UseVisualStyleBackColor = false;
            this.roundedButton_Winter.Click += new System.EventHandler(this.roundedButton_Winter_Click);
            // 
            // roundedButton_Yellow
            // 
            this.roundedButton_Yellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(221)))), ((int)(((byte)(188)))));
            this.roundedButton_Yellow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedButton_Yellow.BackgroundImage")));
            this.roundedButton_Yellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedButton_Yellow.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.roundedButton_Yellow.FlatAppearance.BorderSize = 0;
            this.roundedButton_Yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Yellow.Location = new System.Drawing.Point(19, 70);
            this.roundedButton_Yellow.Name = "roundedButton_Yellow";
            this.roundedButton_Yellow.Radius = 40;
            this.roundedButton_Yellow.Size = new System.Drawing.Size(83, 50);
            this.roundedButton_Yellow.TabIndex = 10;
            this.roundedButton_Yellow.UseVisualStyleBackColor = false;
            this.roundedButton_Yellow.Click += new System.EventHandler(this.roundedButton_Yellow_Click);
            // 
            // roundedButton_Green
            // 
            this.roundedButton_Green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(245)))), ((int)(((byte)(188)))));
            this.roundedButton_Green.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedButton_Green.BackgroundImage")));
            this.roundedButton_Green.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedButton_Green.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.roundedButton_Green.FlatAppearance.BorderSize = 0;
            this.roundedButton_Green.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Green.Location = new System.Drawing.Point(19, 14);
            this.roundedButton_Green.Name = "roundedButton_Green";
            this.roundedButton_Green.Radius = 40;
            this.roundedButton_Green.Size = new System.Drawing.Size(83, 50);
            this.roundedButton_Green.TabIndex = 9;
            this.roundedButton_Green.UseVisualStyleBackColor = false;
            this.roundedButton_Green.Click += new System.EventHandler(this.roundedButton_Green_Click);
            // 
            // roundPanel_ColorSpectre
            // 
            this.roundPanel_ColorSpectre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundPanel_ColorSpectre.BackgroundImage")));
            this.roundPanel_ColorSpectre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundPanel_ColorSpectre.Location = new System.Drawing.Point(12, 266);
            this.roundPanel_ColorSpectre.Name = "roundPanel_ColorSpectre";
            this.roundPanel_ColorSpectre.Size = new System.Drawing.Size(329, 25);
            this.roundPanel_ColorSpectre.TabIndex = 8;
            this.roundPanel_ColorSpectre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roundPanel_ColorSpectre_MouseDown);
            this.roundPanel_ColorSpectre.MouseMove += new System.Windows.Forms.MouseEventHandler(this.roundPanel_ColorSpectre_MouseMove);
            this.roundPanel_ColorSpectre.MouseUp += new System.Windows.Forms.MouseEventHandler(this.roundPanel_ColorSpectre_MouseUp);
            // 
            // roundedButton_MoreOptions
            // 
            this.roundedButton_MoreOptions.BackColor = System.Drawing.SystemColors.ControlLight;
            this.roundedButton_MoreOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedButton_MoreOptions.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedButton_MoreOptions.FlatAppearance.BorderSize = 0;
            this.roundedButton_MoreOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_MoreOptions.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton_MoreOptions.Location = new System.Drawing.Point(145, 307);
            this.roundedButton_MoreOptions.Name = "roundedButton_MoreOptions";
            this.roundedButton_MoreOptions.Radius = 50;
            this.roundedButton_MoreOptions.Size = new System.Drawing.Size(50, 50);
            this.roundedButton_MoreOptions.TabIndex = 7;
            this.roundedButton_MoreOptions.Text = "ᐱ";
            this.roundedButton_MoreOptions.UseVisualStyleBackColor = false;
            this.roundedButton_MoreOptions.Click += new System.EventHandler(this.roundedButton_MoreOptions_Click);
            // 
            // roundedButton_Settings
            // 
            this.roundedButton_Settings.BackColor = System.Drawing.SystemColors.ControlLight;
            this.roundedButton_Settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedButton_Settings.BackgroundImage")));
            this.roundedButton_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedButton_Settings.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedButton_Settings.FlatAppearance.BorderSize = 0;
            this.roundedButton_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Settings.Location = new System.Drawing.Point(291, 321);
            this.roundedButton_Settings.Name = "roundedButton_Settings";
            this.roundedButton_Settings.Radius = 50;
            this.roundedButton_Settings.Size = new System.Drawing.Size(50, 50);
            this.roundedButton_Settings.TabIndex = 1;
            this.roundedButton_Settings.UseVisualStyleBackColor = false;
            this.roundedButton_Settings.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // roundedButton_Power
            // 
            this.roundedButton_Power.BackColor = System.Drawing.SystemColors.ControlLight;
            this.roundedButton_Power.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedButton_Power.BackgroundImage")));
            this.roundedButton_Power.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedButton_Power.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedButton_Power.FlatAppearance.BorderSize = 0;
            this.roundedButton_Power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Power.Location = new System.Drawing.Point(3, 3);
            this.roundedButton_Power.Name = "roundedButton_Power";
            this.roundedButton_Power.Radius = 50;
            this.roundedButton_Power.Size = new System.Drawing.Size(50, 50);
            this.roundedButton_Power.TabIndex = 0;
            this.roundedButton_Power.UseVisualStyleBackColor = false;
            this.roundedButton_Power.Click += new System.EventHandler(this.roundedButton_Power_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 378);
            this.Controls.Add(this.roundPanel_Settings);
            this.Controls.Add(this.roundPanel_Tree);
            this.Controls.Add(this.roundPanel_More);
            this.Controls.Add(this.roundPanel_ColorSpectre);
            this.Controls.Add(this.roundedButton_MoreOptions);
            this.Controls.Add(this.roundedButton_Settings);
            this.Controls.Add(this.roundedButton_Power);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hue";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.roundPanel_Settings.ResumeLayout(false);
            this.roundPanel_Settings.PerformLayout();
            this.roundPanel_Tree.ResumeLayout(false);
            this.roundPanel_Tree.PerformLayout();
            this.roundPanel_More.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton roundedButton_Power;
        private RoundedButton roundedButton_Settings;
        private System.Windows.Forms.ComboBox comboBox_Ports;
        private RoundedButton roundedButton_Save;
        private System.Windows.Forms.Label label_Port;
        private RoundCornerControl roundPanel_Settings;
        private System.Windows.Forms.Label label_SettingsHeader;
        private System.Windows.Forms.Label label_ArduinoStatus;
        private RoundedButton roundedButton_MoreOptions;
        private RoundCornerControl roundPanel_ColorSpectre;
        private RoundCornerControl roundPanel_More;
        private RoundedButton roundedButton_Sound;
        private RoundedButton roundedButton_ColorCycle;
        private RoundedButton roundedButton_Blue;
        private RoundedButton roundedButton_Winter;
        private RoundedButton roundedButton_Yellow;
        private RoundedButton roundedButton_Green;
        private RoundCornerControl roundPanel_Tree;
        private RoundCornerControl roundPanel_ColorInfo;
        private System.Windows.Forms.Label label_TreeOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Devices;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

