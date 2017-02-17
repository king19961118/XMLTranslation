using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLTranslation.domainXML.BSXX_1.MD_BS_2.DLMS_3;

namespace XMLTranslation.domainXML.BSXX_1.MD_BS_2
{
    [XmlRoot("地理描述")]
    [Serializable]
    class DLMS
    {
        /// <summary>
        /// SI_地理描述
        /// </summary>
        [XmlElement(ElementName = "SI_地理描述")]
        public SI_DLMS SI_DLMS
        {
            set;
            get;
        }
    }
}
