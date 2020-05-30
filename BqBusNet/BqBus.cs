﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Windows.Forms;

namespace BqBusNet
{
    public partial class BqBus : Component
    {
        private string[] previousRegs;
        private string[] regs;
        private string msg;
        private List<int> changedRegs = new List<int>();
        private int size;

        /// <summary>
        /// Serial Port to be used
        /// </summary>
        [Description("Serial Port to be used")]
        public SerialPort Serial { get; set; }

        /// <summary>
        /// Get or Set Size of exchanged bqbus data (regs count)
        /// </summary>
        [Description("Get or Set Size of exchanged bqbus data (regs count)")]
        public int Size { get => size; set => size = value; }

        /// <summary>
        /// Checks if device is connected
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool IsConnected { get; private set; } = false;

        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            previousRegs = regs;
            try
            {
                msg = Serial.ReadTo("\n");
                regs = msg.Split(',');
            }
            catch (Exception)
            {

                throw;
            }
            keepChangedRegs();
            sendData();
        }

        private void keepChangedRegs()
        {
            foreach (var idx in changedRegs)
            {
                regs[idx] = previousRegs[idx];
            }
            changedRegs.Clear();
        }

        private void sendData()
        {
            var serialData = "";
            if (regs == null) return;
            int cont = 0;
            foreach (var reg in regs)
            {
                serialData += reg;
                serialData += cont == regs.Length ? "\n" : ",";
                cont++;
            }
            if (Serial.IsOpen)
            {
                Serial.Write(serialData);
            }
        }

        /// <summary>
        /// Create an BqBus Communication Instance
        /// </summary>
        public BqBus()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create an BqBus Communication Instance
        /// </summary>
        public BqBus(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        /// <summary>
        /// Connect to device using selected serial port
        /// </summary>
        public void Connect()
        {
            if (!Serial.IsOpen)
            {
                Serial.Open();
            }
            regs = new string[size];
            sendData();
            IsConnected = true;
            Serial.DataReceived += Serial_DataReceived;
        }

        /// <summary>
        /// Disconnect from device
        /// </summary>
        public void Disconnect()
        {
            if (Serial.IsOpen)
            {
                try
                {
                    Serial.DataReceived -= Serial_DataReceived;
                    Application.DoEvents();
                    Serial.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            IsConnected = false;
        }

        /// <summary>
        /// Set new value to register
        /// </summary>
        /// <param name="address">Address of register</param>
        /// <param name="value">New value</param>
        public void SetReg(int address, int value)
        {
            if(regs != null)
            {
                if (regs.Length > address)
                {
                    regs[address] = value.ToString();
                    changedRegs.Add(address);
                }
            }
        }

        /// <summary>
        /// Get current value of register
        /// </summary>
        /// <param name="address">Address of register</param>
        /// <returns>Value of register</returns>
        public int GetReg(int address)
        {
            if (regs != null)
            {
                if(regs.Length > address)
                {
                    return (int.Parse(regs[address]));
                }
            }
            return (0);
        }

    }
}
