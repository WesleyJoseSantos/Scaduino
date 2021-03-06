﻿namespace Tester
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
            Scaduino.Components.EmailSender emailSender1 = new Scaduino.Components.EmailSender();
            Scaduino.Components.Alarm alarm1 = new Scaduino.Components.Alarm();
            Scaduino.Components.Tag tag1 = new Scaduino.Components.Tag();
            Scaduino.Controls.LabelStyle labelStyle1 = new Scaduino.Controls.LabelStyle();
            Scaduino.Controls.LabelStyle labelStyle2 = new Scaduino.Controls.LabelStyle();
            Scaduino.Components.Tag tag2 = new Scaduino.Components.Tag();
            Scaduino.Components.Tag tag3 = new Scaduino.Components.Tag();
            Scaduino.Components.Tag tag4 = new Scaduino.Components.Tag();
            Scaduino.Components.Tag tag5 = new Scaduino.Components.Tag();
            Scaduino.Components.Tag tag6 = new Scaduino.Components.Tag();
            Scaduino.Components.Tag tag7 = new Scaduino.Components.Tag();
            Scaduino.Protocols.BqBus.BqBusSerialDriver bqBusSerialDriver1 = new Scaduino.Protocols.BqBus.BqBusSerialDriver();
            Scaduino.Components.Tag tag8 = new Scaduino.Components.Tag();
            Scaduino.Components.Tag tag9 = new Scaduino.Components.Tag();
            Scaduino.Components.Tag tag10 = new Scaduino.Components.Tag();
            Scaduino.ArduinoBoard.Pin pin1 = new Scaduino.ArduinoBoard.Pin();
            Scaduino.ArduinoBoard.Pin pin2 = new Scaduino.ArduinoBoard.Pin();
            Scaduino.ArduinoBoard.Pin pin3 = new Scaduino.ArduinoBoard.Pin();
            Scaduino.ArduinoBoard.Pin pin4 = new Scaduino.ArduinoBoard.Pin();
            Scaduino.ArduinoBoard.Pin pin5 = new Scaduino.ArduinoBoard.Pin();
            Scaduino.ArduinoBoard.Pin pin6 = new Scaduino.ArduinoBoard.Pin();
            Scaduino.ArduinoBoard.Pin pin7 = new Scaduino.ArduinoBoard.Pin();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.alarmsViewer1 = new Scaduino.Controls.ScaduinoAlarmsViewer();
            this.alarms1 = new Scaduino.Components.Alarms(this.components);
            this.scaduinoLabel1 = new Scaduino.Controls.ScaduinoLabel();
            this.scaduinoHScrollBar1 = new Scaduino.Controls.ScaduinoHScrollBar();
            this.scaduinoVScrollBar1 = new Scaduino.Controls.ScaduinoVScrollBar();
            this.scaduinoComboBox1 = new Scaduino.Controls.ScaduinoComboBox();
            this.scaduinoCheckBox1 = new Scaduino.Controls.ScaduinoCheckBox();
            this.scaduinoButton1 = new Scaduino.Controls.ScaduinoButton();
            this.arduino1 = new Scaduino.ArduinoBoard.Arduino(this.components);
            this.communicationChannels1 = new Scaduino.Protocols.CommunicationChannels(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Led1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(616, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Led2";
            // 
            // alarmsViewer1
            // 
            this.alarmsViewer1.Alarms = this.alarms1;
            this.alarmsViewer1.BackColor = System.Drawing.Color.Black;
            this.alarmsViewer1.EmailServiceEnabled = true;
            emailSender1.DestinationMail = "BINARY_QUANTUM@outlook.com";
            emailSender1.DestinationName = "Binary Quantum";
            emailSender1.SmtpHost = "smtp.gmail.com";
            emailSender1.SmtpPass = "Wjsantos002";
            emailSender1.SmtpPort = 587;
            emailSender1.SmtpUser = "wesleypro37@gmail.com";
            this.alarmsViewer1.EmailSettings = emailSender1;
            this.alarmsViewer1.Location = new System.Drawing.Point(12, 351);
            this.alarmsViewer1.Name = "alarmsViewer1";
            this.alarmsViewer1.Size = new System.Drawing.Size(888, 156);
            this.alarmsViewer1.TabIndex = 7;
            // 
            // alarms1
            // 
            alarm1.Acknowledged = false;
            alarm1.Date = null;
            alarm1.Limit = 200D;
            alarm1.Message = "Alarme acionado!";
            alarm1.Status = Scaduino.Components.Alarm.AlarmState.Inactived;
            tag1.Name = "HSCROLLBAR";
            tag1.Value = 0;
            alarm1.Tag = tag1;
            alarm1.Type = Scaduino.Components.Alarm.AlarmType.High;
            this.alarms1.AlarmsList = new Scaduino.Components.Alarm[] {
        alarm1};
            this.alarms1.ColorAck = System.Drawing.Color.Yellow;
            this.alarms1.ColorActived = System.Drawing.Color.Red;
            this.alarms1.ColorInactived = System.Drawing.Color.Green;
            // 
            // scaduinoLabel1
            // 
            this.scaduinoLabel1.AutoSize = true;
            this.scaduinoLabel1.BackColor = System.Drawing.Color.Red;
            this.scaduinoLabel1.CommunicationSource = null;
            this.scaduinoLabel1.ForeColor = System.Drawing.Color.Black;
            this.scaduinoLabel1.Location = new System.Drawing.Point(813, 84);
            this.scaduinoLabel1.Name = "scaduinoLabel1";
            this.scaduinoLabel1.Size = new System.Drawing.Size(54, 13);
            labelStyle1.BackColor = System.Drawing.Color.Red;
            labelStyle1.ForeColor = System.Drawing.Color.Black;
            labelStyle1.Text = "Desligado";
            labelStyle2.BackColor = System.Drawing.Color.LimeGreen;
            labelStyle2.ForeColor = System.Drawing.Color.Black;
            labelStyle2.Text = "Ligado";
            this.scaduinoLabel1.Styles = new Scaduino.Controls.LabelStyle[] {
        labelStyle1,
        labelStyle2};
            this.scaduinoLabel1.TabIndex = 6;
            tag2.Name = "LABEL";
            tag2.Value = 0;
            this.scaduinoLabel1.Tag = tag2;
            this.scaduinoLabel1.Text = "Desligado";
            // 
            // scaduinoHScrollBar1
            // 
            this.scaduinoHScrollBar1.CommunicationSource = null;
            this.scaduinoHScrollBar1.Location = new System.Drawing.Point(657, 81);
            this.scaduinoHScrollBar1.Maximum = 255;
            this.scaduinoHScrollBar1.Name = "scaduinoHScrollBar1";
            this.scaduinoHScrollBar1.Size = new System.Drawing.Size(92, 17);
            this.scaduinoHScrollBar1.TabIndex = 5;
            tag3.Name = "HSCROLLBAR";
            tag3.Value = 0;
            this.scaduinoHScrollBar1.Tag = tag3;
            // 
            // scaduinoVScrollBar1
            // 
            this.scaduinoVScrollBar1.CommunicationSource = null;
            this.scaduinoVScrollBar1.Location = new System.Drawing.Point(536, 61);
            this.scaduinoVScrollBar1.Maximum = 255;
            this.scaduinoVScrollBar1.Name = "scaduinoVScrollBar1";
            this.scaduinoVScrollBar1.Size = new System.Drawing.Size(17, 80);
            this.scaduinoVScrollBar1.TabIndex = 3;
            tag4.Name = "VSCROLLBAR";
            tag4.Value = 0;
            this.scaduinoVScrollBar1.Tag = tag4;
            // 
            // scaduinoComboBox1
            // 
            this.scaduinoComboBox1.CommunicationSource = null;
            this.scaduinoComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scaduinoComboBox1.FormattingEnabled = true;
            this.scaduinoComboBox1.Items.AddRange(new object[] {
            "Desligado",
            "Ligado"});
            this.scaduinoComboBox1.Location = new System.Drawing.Point(342, 78);
            this.scaduinoComboBox1.Name = "scaduinoComboBox1";
            this.scaduinoComboBox1.Size = new System.Drawing.Size(121, 21);
            this.scaduinoComboBox1.TabIndex = 2;
            tag5.Name = "COMBOBOX";
            tag5.Value = 0;
            this.scaduinoComboBox1.Tag = tag5;
            // 
            // scaduinoCheckBox1
            // 
            this.scaduinoCheckBox1.AutoSize = true;
            this.scaduinoCheckBox1.CommunicationSource = null;
            this.scaduinoCheckBox1.Location = new System.Drawing.Point(195, 80);
            this.scaduinoCheckBox1.Name = "scaduinoCheckBox1";
            this.scaduinoCheckBox1.Size = new System.Drawing.Size(96, 17);
            this.scaduinoCheckBox1.TabIndex = 1;
            tag6.Name = "CHECKBOX";
            tag6.Value = 0;
            this.scaduinoCheckBox1.Tag = tag6;
            this.scaduinoCheckBox1.Text = "button pressed";
            this.scaduinoCheckBox1.UseVisualStyleBackColor = true;
            // 
            // scaduinoButton1
            // 
            this.scaduinoButton1.BackColor = System.Drawing.Color.LightGray;
            this.scaduinoButton1.ColorMouseEnter = System.Drawing.Color.Gray;
            this.scaduinoButton1.ColorMouseLeave = System.Drawing.Color.LightGray;
            this.scaduinoButton1.ColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.scaduinoButton1.CommunicationSource = null;
            this.scaduinoButton1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaduinoButton1.ForeColor = System.Drawing.Color.Black;
            this.scaduinoButton1.ForeColorMouseEnter = System.Drawing.Color.White;
            this.scaduinoButton1.ForeColorMouseLeave = System.Drawing.Color.Black;
            this.scaduinoButton1.ForeColorOnClick = System.Drawing.Color.White;
            this.scaduinoButton1.Location = new System.Drawing.Point(39, 78);
            this.scaduinoButton1.Mode = Scaduino.Controls.ScaduinoButton.ButtonMode.Pulse;
            this.scaduinoButton1.Name = "scaduinoButton1";
            this.scaduinoButton1.Size = new System.Drawing.Size(120, 20);
            this.scaduinoButton1.TabIndex = 0;
            tag7.Name = "BUTTON";
            tag7.Value = 0;
            this.scaduinoButton1.Tag = tag7;
            this.scaduinoButton1.Text = "scaduinoButton1";
            this.scaduinoButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arduino1
            // 
            this.arduino1.Code = null;
            bqBusSerialDriver1.AutoConnect = true;
            bqBusSerialDriver1.BaudRate = 9600;
            bqBusSerialDriver1.Name = "BqBusSerial";
            bqBusSerialDriver1.PortName = "COM4";
            tag8.Name = "VSCROLLBAR";
            tag8.Value = 0;
            tag9.Name = "PICTUREBOX";
            tag9.Value = 0;
            tag10.Name = "NOVATAG";
            tag10.Value = 0;
            bqBusSerialDriver1.Tags = new Scaduino.Components.Tag[] {
        tag7,
        tag6,
        tag5,
        tag8,
        tag1,
        tag2,
        tag9,
        tag10};
            this.arduino1.CommunicationChannel = bqBusSerialDriver1;
            this.arduino1.CommunicationSource = this.communicationChannels1;
            pin1.Mode = Scaduino.ArduinoBoard.Pin.PinType.Output;
            pin1.Name = "pinLed";
            pin1.Number = 13;
            pin1.Tag = tag7;
            pin2.Mode = Scaduino.ArduinoBoard.Pin.PinType.Input;
            pin2.Name = "pinButton";
            pin2.Number = 3;
            pin2.Tag = tag6;
            pin3.Mode = Scaduino.ArduinoBoard.Pin.PinType.Output;
            pin3.Name = "pinLed2";
            pin3.Number = 4;
            pin3.Tag = tag5;
            pin4.Mode = Scaduino.ArduinoBoard.Pin.PinType.AnalogOutput;
            pin4.Name = "pinLed3";
            pin4.Number = 5;
            pin4.Tag = tag8;
            pin5.Mode = Scaduino.ArduinoBoard.Pin.PinType.AnalogOutput;
            pin5.Name = "pinLed4";
            pin5.Number = 6;
            pin5.Tag = tag1;
            pin6.Mode = Scaduino.ArduinoBoard.Pin.PinType.Input;
            pin6.Name = "pinLed5";
            pin6.Number = 7;
            pin6.Tag = tag2;
            pin7.Mode = Scaduino.ArduinoBoard.Pin.PinType.Input;
            pin7.Name = "pinLed6";
            pin7.Number = 8;
            pin7.Tag = tag9;
            this.arduino1.Pins = new Scaduino.ArduinoBoard.Pin[] {
        pin1,
        pin2,
        pin3,
        pin4,
        pin5,
        pin6,
        pin7};
            // 
            // communicationChannels1
            // 
            this.communicationChannels1.Drivers = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 519);
            this.Controls.Add(this.alarmsViewer1);
            this.Controls.Add(this.scaduinoLabel1);
            this.Controls.Add(this.scaduinoHScrollBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scaduinoVScrollBar1);
            this.Controls.Add(this.scaduinoComboBox1);
            this.Controls.Add(this.scaduinoCheckBox1);
            this.Controls.Add(this.scaduinoButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Scaduino.Controls.ScaduinoButton scaduinoButton1;
        private Scaduino.Controls.ScaduinoCheckBox scaduinoCheckBox1;
        private Scaduino.ArduinoBoard.Arduino arduino1;
        private Scaduino.Controls.ScaduinoComboBox scaduinoComboBox1;
        private Scaduino.Controls.ScaduinoVScrollBar scaduinoVScrollBar1;
        private System.Windows.Forms.Label label1;
        private Scaduino.Controls.ScaduinoHScrollBar scaduinoHScrollBar1;
        private System.Windows.Forms.Label label2;
        private Scaduino.Controls.ScaduinoLabel scaduinoLabel1;
        private Scaduino.Components.Alarms alarms1;
        private Scaduino.Controls.ScaduinoAlarmsViewer alarmsViewer1;
        private Scaduino.Protocols.CommunicationChannels communicationChannels1;
    }
}