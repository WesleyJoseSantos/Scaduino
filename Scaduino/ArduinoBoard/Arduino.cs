﻿using Scaduino.Components;
using Scaduino.Protocols;
using Scaduino.Protocols.BqBus;
using Scaduino.Editors;
using System.ComponentModel;
using System.Drawing.Design;

namespace Scaduino.ArduinoBoard
{
    public partial class Arduino : Component
    {
        private CommunicationChannels communicationSource;
        private BqBusSerialDriver communicationChannel;
        private string code;

        /// <summary>
        /// Collection of communication channels to be used for this device
        /// </summary>
        [Description("Collection of communication channels to be used for this device")]
        public CommunicationChannels CommunicationSource
        {
            get
            {
                GlobalData.SelectedCommunicationChannels = communicationSource;
                return communicationSource;
            }
            set => communicationSource = value;
        }

        /// <summary>
        /// "Communication driver of this device"
        /// </summary>
        [Description("Communication driver of this device")]
        [Editor(typeof(SelectCommunicationChannelEditor), typeof(UITypeEditor))]
        public BqBusSerialDriver CommunicationChannel
        {
            get
            {
                GlobalData.SelectedCommunicationDriver = communicationChannel;
                return communicationChannel;
            }
            set => communicationChannel = value;
        }

        /// <summary>
        /// "Definition of hardware pinout of this device"
        /// </summary>
        [Description("Definition of hardware pinout of this device")]
        [Editor(typeof(ArduinoPinsEditor), typeof(UITypeEditor))]
        public Pin[] Pins { get; set; }

        /// <summary>
        /// "Source Code of this device"
        /// </summary>
        [Description("Source Code of this device")]
        [Editor(typeof(CodeEditorEditor), typeof(UITypeEditor))]
        public string Code
        {
            get
            {
                GlobalData.SelectedArduino = this;
                return code;
            }

            set => code = value;
        }

        public string GetCode()
        {
            string code = "";
            code += CommunicationChannel.GetLibraryCode();
            code += CommunicationChannel.GetInstanceCode();
            code += "\nenum Regs {\n";
            foreach (Tag tag in CommunicationChannel.Tags)
            {
                code += "\t" + tag.Name + "_REG,\n";
            }
            code += "};\n\n";
            foreach (Pin pin in Pins)
            {
                code += pin.GetDefineSnippet();
            }
            code += "\nvoid setup(){\n";
            code += CommunicationChannel.GetInitCode();
            foreach (Pin pin in Pins)
            {
                code += pin.GetSetupSnippet();
            }
            code += "}\n\n";
            code += "void loop(){\n";
            code += "\tscaduino.communicationTask();\n\n";
            foreach (Pin pin in Pins)
            {
                code += pin.GetControllerSnippet();
            }
            code += "}\n";
            return (code);
        }

        public Arduino()
        {
            InitializeComponent();
            //CodeManager = new CodeManager(this);
            communicationSource = GlobalData.SelectedCommunicationChannels;
        }

        public Arduino(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            //CodeManager = new CodeManager(this);
            communicationSource = GlobalData.SelectedCommunicationChannels;
        }
    }
}
