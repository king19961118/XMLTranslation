using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLTranslation.domainXML.BSXX_1.MD_BS_2.SJJGS_3;

namespace XMLTranslation.domainXML.BSXX_1.MD_BS_2
{
    [XmlRoot("数据集格式")]
    [Serializable]
    class SJJGS
    {
        /// <summary>
        /// MD_格式
        /// </summary>
        [XmlElement(ElementName = "MD_格式")]
        public MD_GS MD_GS
        {
            set;
            get;
        }
    }
}
