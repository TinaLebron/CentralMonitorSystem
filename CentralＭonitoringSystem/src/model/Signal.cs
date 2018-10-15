using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralＭonitoringSystem.src.model
{
    class Signal
    {
        int points;
        int signalType;
        int alarmOutput;
        int signalPreset;
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

        public int Points
        {
            get
            {
                return points;
            }
            set
            {
                points = value;
            }
        }
        public int SignalType
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
        public int AlarmOutput
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
        public int SignalPreset
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
