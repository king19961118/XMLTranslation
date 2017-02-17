using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLTranslation.domainXML.FFXX_1;

namespace XMLTranslation.domainXML
{
    [XmlRoot("标识信息")]
    [Serializable]
    class FFXX
    {
        /// <summary>
        /// MD_分发
        /// </summary>
        [XmlElement(ElementName = "MD_分发")]
        public MD_FF MD_FF
        {
            set;
            get;
        }
    }
}
