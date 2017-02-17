using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLTranslation.domainXML.FFXX_1.MD_FF_2.FFZ_3.MD_FFZ_4.FFZLXXX_5;

namespace XMLTranslation.domainXML.FFXX_1.MD_FF_2.FFZ_3.MD_FFZ_4
{
    [XmlRoot("分发者联系信息")]
    [Serializable]
    class FFZLXXX
    {
        /// <summary>
        /// CI_负责单位
        /// </summary>
        [XmlElement(ElementName = "CI_负责单位")]
        public CI_FZDW CI_FZDW
        {
            set;
            get;
        }
    }
}
