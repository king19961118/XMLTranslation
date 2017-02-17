using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLTranslation.domainXML.KJCZXTXX_1.RS_CZXX_2;

namespace XMLTranslation.domainXML.KJCZXTXX_1
{
    [XmlRoot("RS_参照系统")]
    [Serializable]
    class RS_CZXX
    {
        /// <summary>
        /// SC_大地坐标参照系统
        /// </summary>
        [XmlElement(ElementName = "SC_大地坐标参照系统")]
        public SC_DDZBCZXX SC_DDZBCZXX
        {
            set;
            get;
        }
    }
}
