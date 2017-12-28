using System;
using System.ComponentModel;
using System.Windows.Controls.WpfPropertyGrid.Attributes;
using Hawk.Core.Connectors;
using Hawk.Core.Utils.Plugins;

namespace Hawk.ETL.Plugins.Transformers
{
    [XFrmWork("获取当前时间",  "将时间类型转换为特定格式的字符串")]
    public class TimeNow : TransformerBase
    {
        public TimeNow()
        {
            Format = "yyyy-MM-dd";
        }

        [LocalizedDisplayName("格式")]
        public string Format { get; set; }
 
        public override object TransformData(IFreeDocument document)
        {
            return DateTime.Now.ToString(Format);
        }
    }
}