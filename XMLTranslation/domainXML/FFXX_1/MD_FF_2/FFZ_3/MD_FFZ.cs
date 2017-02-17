using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLTranslation.domainXML.FFXX_1.MD_FF_2.FFZ_3.MD_FFZ_4;

namespace XMLTranslation.domainXML.FFXX_1.MD_FF_2.FFZ_3
{
    [XmlRoot("MD_分发者")]
    [Serializable]
    class MD_FFZ
    {
        /// <summary>
        /// 分发者联系信息
        /// </summary>
        [XmlElement(ElementName = "分发者联系信息")]
        public FFZLXXX FFZLXXX
        {
            set;
            get;
        }
    }
}
