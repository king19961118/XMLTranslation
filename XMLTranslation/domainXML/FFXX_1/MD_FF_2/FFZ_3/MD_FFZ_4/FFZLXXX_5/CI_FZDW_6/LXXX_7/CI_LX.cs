﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLTranslation.domainXML.FFXX_1.MD_FF_2.FFZ_3.MD_FFZ_4.FFZLXXX_5.CI_FZDW_6.LXXX_7
{
    [XmlRoot("CI_联系")]
    [Serializable]
    class CI_LX
    {
        /// <summary>
        /// 电话
        /// </summary>
        [XmlElement(ElementName = "电话")]
        public String DH
        {
            set;
            get;
        }
        /// <summary>
        /// 传真
        /// </summary>
        [XmlElement(ElementName = "传真")]
        public String CZ
        {
            set;
            get;
        }
        /// <summary>
        /// 通信地址
        /// </summary>
        [XmlElement(ElementName = "通信地址")]
        public String TXDZ
        {
            set;
            get;
        }
         /// <summary>
        /// 邮政编码
        /// </summary>
        [XmlElement(ElementName = "邮政编码")]
        public String YZBM
        {
            set;
            get;
        }
        /// <summary>
        /// 电子信箱地址
        /// </summary>
        [XmlElement(ElementName = "电子信箱地址")]
        public String DZXXDZ
        {
            set;
            get;
        }
        /// <summary>
        /// 网址
        /// </summary>
        [XmlElement(ElementName = "网址")]
        public String WZ
        {
            set;
            get;
        }
    }
}
