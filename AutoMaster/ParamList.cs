using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AutoMaster
{
    public class ParamsList
    {
        public List<Page> pages { get; set; }
        public class Page
        {
            public int index { get; set; }
            public string name { get; set; }
            public List<Group> groups { get; set; }
            Page()
            {
                groups = new List<Group>();
            }
        }
        public class Group
        {
            public string name { get; set; }
            public List<Entry> entries { get; set; }
            Group()
            {
                entries = new List<Entry>();
            }
        }
        public class Entry
        {
            public int id { get; set; }
            public int type { get; set; }
            public string name { get; set; }
            public string value { get; set; }
            public string formula { get; set; }
            public string unit { get; set; }
            public string description { get; set; }
            public bool showBitMap { get; set; }
            public List<Bit> bits { get; set; }
            Entry()
            {
                bits = new List<Bit>();
            }
        }
        public class Bit
        {
            public int bitstart { get; set; }
            public int bitend { get; set; }
            public string name { get; set; }
            public string value { get; set; }
            public string formula { get; set; }
            public string unit { get; set; }
            public string description { get; set; }
        }
        public ParamsList()
        {
            pages = new List<Page>();
        }
    }
    class ParamList
    {
        public class BitMap
        {
            public int bitstart { get; set; }
            public int bitend { get; set; }
            public string name { get; set; }
            public string value { get; set; }
            public string formula { get; set; }
            public string unit { get; set; }
            public string description { get; set; }
            public ParamItem parent;
            public BitMap(ParamItem parent)
            {
                this.parent = parent;
            }
        }
        public class ParamItem
        {
            public int id { get; set; }
            public int type { get; set; }
            public string name { get; set; }
            public string value { get; set; }
            public string formula { get; set; }
            public string unit { get; set; }
            public string description { get; set; }
            public bool showBitMap { get; set; }
            public List<BitMap> bitMap { get; set; }
            public ParamItem(int id, string name, string value,string formula, string unit)
            {
                this.id = id;
                this.name = name;
                this.value = value;
                this.formula = formula;
                this.unit = unit;
                bitMap = new List<BitMap>();
            }
            public ParamItem (int id, string name, string value, string unit)
            {
                this.id = id;
                this.name = name;
                this.value = value;
                this.unit = unit;
                bitMap = new List<BitMap>();
            }

            public ParamItem(int id, string name, int value, string unit)
            {
                this.id = id;
                this.name = name;
                this.value = value.ToString();
                this.unit = unit;
                bitMap = new List<BitMap>();
            }

            public ParamItem(int id, string name, string unit)
            {
                this.id = id;
                this.name = name;
                this.unit = unit;
                this.value = "";
                bitMap = new List<BitMap>();
            }
            public ParamItem()
            {
                bitMap = new List<BitMap>();
            }
        }
        class FRAME
        {
            public byte head;
            public UInt16 id;
            public byte data_type;
            public byte[] data;
            public byte crc;
        }
        public static int FindById(List<ParamItem> list, int id)
        {
            int index  = 0;
            for (index = 0; index < list.Count; index++)
            {
                if (list[index].id == id)
                    return index;
            }
            return -1;
        }
        public static List<ParamItem> ParamList_GetFromXml()
        {
            List<ParamItem> items = new List<ParamItem>();
            XmlDocument xmlDoc = new XmlDocument();

            XmlReaderSettings settings = new XmlReaderSettings();

            settings.IgnoreComments = true;//忽略文档里面的注释

            try
            {
                XmlReader reader = XmlReader.Create(Application.StartupPath + "/paramList.xml", settings);

                xmlDoc.Load(reader);
                XmlNodeList nodelist = xmlDoc.SelectNodes("paramList/param");
                foreach (XmlNode node in nodelist)
                {
                    ParamItem entity = new ParamItem();
                    // 将节点转换为元素，便于得到节点的属性值
                    XmlElement xe = (XmlElement)node;
                    // 得到id和name两个属性的属性值
                    entity.id = Convert.ToInt32(xe.GetAttribute("id").ToString());
                    entity.name = xe.GetAttribute("name").ToString();
                    entity.type = Convert.ToInt32(xe.GetAttribute("type").ToString());
                    entity.formula = xe.GetAttribute("formula").ToString();
                    entity.unit = xe.GetAttribute("unit").ToString();
                    entity.description = xe.GetAttribute("description").ToString();

                    // 得到所有子节点
                    XmlNodeList xnl0 = xe.ChildNodes;
                    foreach (XmlNode childNode in xnl0)
                    {
                        XmlElement param = (XmlElement)childNode;
                        if (param.Name.Equals("bitmap"))
                        {
                            BitMap bitmap = new BitMap(entity);
                            bitmap.bitstart = Convert.ToInt32(param.GetAttribute("bitstart").ToString());
                            bitmap.bitend = Convert.ToInt32(param.GetAttribute("bitend").ToString());
                            bitmap.name = param.GetAttribute("name").ToString();
                            bitmap.formula = param.GetAttribute("formula").ToString();
                            bitmap.unit = param.GetAttribute("unit").ToString();
                            bitmap.description = param.GetAttribute("description").ToString();
                            entity.bitMap.Add(bitmap);
                        }
                    }
                    items.Add(entity);
                }
                reader.Close();
                /* 排序 */
                items.Sort((left, right) =>
                {
                    if (left.id > right.id)
                        return 1;
                    else if (left.id == right.id)
                        return 0;
                    else
                        return -1;
                });
            }
            catch (Exception)
            { }
#if false
            /* id不连续时插入空的条目 */
            int count = items.Count;
            for (int i = 1; i < count; i++)
            {
                if (items[i-1].id + 1 != items[i].id)
                {
                    ParamItem item = new ParamItem(i, "", "");
                    items.Insert(i, item);
                    count++;
                }
            }
#endif
            return items;
        }
        public static List<ParamItem> ParamList_Init()
        {
            List<ParamItem> items = new List<ParamItem>();
            items.AddRange(ParamList_GetFromXml());
            return items;
        }
        static byte calculate_crc(byte[] stream, int len)
        {
            return 0;
        }
        static int find(byte[] array, int start, int end, byte value)
        {
            int i = 0;
            if (end >= array.Length)
            {
                end = array.Length - 1;
            }
            if (start > end || start < 0)
            {
                return -1;
            }
            for (i = start; i <= end; i++)
            {
                if (value == array[i])
                {
                    return i;
                }
            }
            return -1;
        }
        public static int ParamList_Update(List<ParamItem> list, ArrayList rxBuffer)
        {
            FRAME frame = new FRAME();
            int count = 0;
            byte[] stream;
            int payloadSize = 0;
            int headSize = 4; //起始符(1) + ID(2) + type(1) = 4
            int index = 0, end;
            for (;;)
            {
                try
                {
                    stream = (byte[])rxBuffer.ToArray(typeof(byte));
                    index = find(stream, 0, rxBuffer.Count, 0x5a);
                    if (index < 0)
                    {
                        rxBuffer.Clear();
                        break;
                    }
                    if (rxBuffer.Count < index + 5)
                        break;
                    frame.data_type = stream[index + 3];
                    payloadSize = frame.data_type & 0x0f;
                    if (rxBuffer.Count < index + headSize + payloadSize + 2)
                        break;
                    frame.crc = stream[index + headSize + payloadSize];

                    end = find(stream, index + headSize + payloadSize + 1, rxBuffer.Count, Convert.ToByte('\n'));
                    if (end < 0)
                    {
                        rxBuffer.Clear();
                        break;
                    }
                    frame.head = stream[index];
                    rxBuffer.RemoveRange(0, end + 1);
                    if (calculate_crc(stream.Skip(1).Take(headSize + payloadSize - 1).ToArray(), headSize + payloadSize - 1) != frame.crc)
                    {
                        break;
                    }
                    frame.id = (UInt16)(256 * stream[index + 2] + stream[index + 1]);
                    int listIndex = FindById(list, frame.id);
                    if (listIndex < 0)
                    {
                        continue;
                    }
                    frame.data = new byte[payloadSize];
                    for (int i = 0; i < payloadSize; i++)
                    {
                        frame.data[i] = stream[index + headSize + i];
                    }
                    if (frame.data_type == 0x20 || frame.data_type == 0x80)
                    {
                        continue;
                    }
                    if (list[listIndex].formula != null &&
                        list[listIndex].formula.Length > 0)
                    {
                        if (list[listIndex].formula.Substring(0, 1).Equals("/"))
                        {
                            double value = 0;
                            string formula;
                            if ((frame.data_type & 0x30) == 0x00)
                            {
                                for (int i = 0; i < payloadSize; i++)
                                {
                                    value = value * 256 + frame.data[i];
                                }
                            }
                            else
                            {
                                MessageBox.Show("暂不支持改格式数据!", "警告");
                                continue;
                            }
                            formula = list[listIndex].formula.Substring(1);
                            value = value / Convert.ToDouble(formula);
                            list[listIndex].value = value.ToString("f6");
                        }
                    }
                    else
                    {
                        if ((frame.data_type & 0x30) == 0x00 || (frame.data_type & 0xC0) == 0x00)
                        {
                            UInt64 s_value = 0;
                            UInt64 temp = 0;
                            for (int i = 0; i < payloadSize; i++)
                            {
                                temp = frame.data[i];
                                s_value = s_value + (temp << 8 * i);
                            }
                            list[listIndex].value = s_value.ToString();
                        }
                        else
                        {
                            MessageBox.Show("暂不支持改格式数据!", "警告");
                            continue;
                        }
                    }
                    count++;
                }
                catch (Exception)
                {
                    rxBuffer.Remove(null);
                }
            }

            return count;
        }
    }
}
