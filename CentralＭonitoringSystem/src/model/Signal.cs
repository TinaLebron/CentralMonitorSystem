using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralＭonitoringSystem.src.model
{
    class Signal
    {
        int point;
        bool signalType;
        bool alarmOutput;
        bool signalPreset;
        string groupNumber;
        string signalDescription;
        string signalDisplayTextNormally;
        string signalAnomalyDisplayText;
        string normalSignalFileName;
        string signalAnomalyFileName;
        string graphicXCoordinate;
        string graphicYCoordinate;
        string titleContent;

        public Signal() { }
        public Signal(int point,bool signalType, bool alarmOutput, bool signalPreset, string groupNumber, string signalDescription, string signalDisplayTextNormally, string signalAnomalyDisplayText, string normalSignalFileName, string signalAnomalyFileName, string graphicXCoordinate, string graphicYCoordinate, string titleContent)
        {
            this.point = point;
            this.signalType = signalType;
            this.alarmOutput = alarmOutput;
            this.signalPreset = signalPreset;
            this.groupNumber = groupNumber;
            this.signalDescription = signalDescription;
            this.signalDisplayTextNormally = signalDisplayTextNormally;
            this.signalAnomalyDisplayText = signalAnomalyDisplayText;
            this.normalSignalFileName = normalSignalFileName;
            this.signalAnomalyFileName = signalAnomalyFileName;
            this.graphicXCoordinate = graphicXCoordinate;
            this.graphicYCoordinate = graphicYCoordinate;
            this.titleContent = titleContent;
        }

        public int Point
        {
            get
            {
                return point;
            }
            set
            {
                point = value;
            }
        }
        public bool SignalType
        {
            get
            {
                return signalType;
            }
            set
            {
                signalType = value;
            }
        }
        public bool AlarmOutput
        {
            get
            {
                return alarmOutput;
            }
            set
            {
                alarmOutput = value;
            }
        }
        public bool SignalPreset
        {
            get
            {
                return signalPreset;
            }
            set
            {
                signalPreset = value;
            }
        }
        public string GroupNumber
        {
            get
            {
                return groupNumber;
            }
            set
            {
                groupNumber = value;
            }
        }
        public string SignalDescription
        {
            get
            {
                return signalDescription;
            }
            set
            {
                signalDescription = value;
            }
        }
        public string SignalDisplayTextNormally
        {
            get
            {
                return signalDisplayTextNormally;
            }
            set
            {
                signalDisplayTextNormally = value;
            }
        }
        public string SignalAnomalyDisplayText
        {
            get
            {
                return signalAnomalyDisplayText;
            }
            set
            {
                signalAnomalyDisplayText = value;
            }
        }
        public string NormalSignalFileName
        {
            get
            {
                return normalSignalFileName;
            }
            set
            {
                normalSignalFileName = value;
            }
        }
        public string SignalAnomalyFileName
        {
            get
            {
                return signalAnomalyFileName;
            }
            set
            {
                signalAnomalyFileName = value;
            }
        }
        public string GraphicXCoordinate
        {
            get
            {
                return graphicXCoordinate;
            }
            set
            {
                graphicXCoordinate = value;
            }
        }
        public string GraphicYCoordinate
        {
            get
            {
                return graphicYCoordinate;
            }
            set
            {
                graphicYCoordinate = value;
            }
        }
        public string TitleContent
        {
            get
            {
                return titleContent;
            }
            set
            {
                titleContent = value;
            }
        }
    }
}
