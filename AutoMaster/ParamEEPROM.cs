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
    public class IItem
    {
        public enum type_t
        {
            group,
            entry,
        };
        public type_t type { get; set; }
        public int group_id { get; set; }
        public int depth { get; set; }
    }
    public class ParamsEEPROM
    {
        public List<IItem> items { get; set; }
        public class Group : IItem
        {
            public int id { get; set; }
            public string name { get; set; }
            public Group(int group_id)
            {
                this.type = type_t.group;
                this.group_id = group_id;
            }
        }
        public class Entry : IItem
        {
            public int offset { get; set; }
            public string name { get; set; }
            public string value { get; set; }
            public Entry(int group_id)
            {
                this.type = type_t.entry;
                this.group_id = group_id;
            }
        }
        public ParamsEEPROM()
        {
            items = new List<IItem>();
        }
        int GetGroupIndex(int group_id)
        {
            int index = -1;
            foreach (Group item in items)
            {
                index++;
                if ((item.type == IItem.type_t.group) && (item.id == group_id))
                {
                    break;
                }
            }
            return index;
        }
        int GetEntryIndex(int offset)
        {
            int index = -1;
            foreach (Entry item in items)
            {
                index++;
                if ((item.type == IItem.type_t.entry) && (item.offset == offset))
                {
                    break;
                }
            }
            return index;
        }
        int GetIndex(IItem item, IItem.type_t type)
        {
            switch (type)
            {
            case IItem.type_t.entry:
            {
                return GetGroupIndex(((Entry)item).offset);
            }
            case IItem.type_t.group:
            {
                return GetGroupIndex(((Group)item).id);
            }
            default:
                return -1;
            }
        }
        public void AddGroup(Group group)
        {
            int index;
            Group temp;
            index = GetGroupIndex(group.id);
            if (index >= 0)
            {
                temp = (Group)items[index];
                temp.name = group.name;
            }
            else
            {
                temp = new Group(group.group_id);
                temp.id = group.id;
                temp.group_id = 0;
                temp.depth = 0;
                items.Add(temp);
            }
            if (temp.group_id != group.group_id)
            {
                index = GetGroupIndex(group.group_id);
                if (index < 0)
                {
                    temp.group_id = 0;
                    temp.depth = 0;
                }
                else
                {
                    temp.group_id = group.group_id;
                    temp.depth = ((Group)items[index]).depth + 1;
                }
            }
        }
        public void AddEntry(Entry entry)
        {
            int index;
            Entry temp;
            index = GetEntryIndex(entry.offset);
            if (index >= 0)
            {
                temp = (Entry)items[index];
                temp.name = entry.name;
            }
            else
            {
                temp = new Entry(entry.group_id);
                temp.offset = entry.offset;
                temp.group_id = 0;
                index = GetEntryIndex(entry.offset);
                items.Add(temp);
            }
            if (temp.group_id != entry.group_id)
            {
                index = GetGroupIndex(entry.group_id);
                if (index < 0)
                {
                    entry.group_id = 0;
                }
                temp.group_id = entry.group_id;
            }
        }
#if false
        public void Sort()
        {
            int index = 0;
            foreach (IItem item in items)
            {
                if (item.type == IItem.type_t.group)
                {
                }
            }
        }
#endif
    }
    class ParamEEPROM
    {
        private static int group_count;
        class FRAME
        {
            public byte head;
            public UInt16 id;
            public byte data_type;
            public byte[] data;
            public byte crc;
        }
        public static int FindById(List<IItem> list, int offset)
        {
            int index  = 0;
            for (index = 0; index < list.Count; index++)
            {
                if (list[index].type == IItem.type_t.group)
                {
                    continue;
                }
                if (((ParamsEEPROM.Entry)list[index]).offset == offset)
                    return index;
            }
            return -1;
        }
        private static int ParamItem_AddGroup(List<IItem> list, XmlNodeList nodelist, int id, int depth)
        {
            int id_out = id;
            ParamsEEPROM.Group group;
            ParamsEEPROM.Entry entry;
            foreach (XmlElement node in nodelist)
            {
                if (node.Name.Equals("group"))
                {
                    group_count++;
                    group = new ParamsEEPROM.Group(id);
                    group.name = node.GetAttribute("name").ToString();
                    group.depth = depth;
                    group.id = group_count;
                    list.Add(group);
                    XmlNodeList xnl0 = node.ChildNodes;
                    id_out = ParamItem_AddGroup(list, xnl0, id_out + 1, depth + 1);
                }
                else if (node.Name.Equals("param"))
                {
                    entry = new ParamsEEPROM.Entry(id);
                    entry.offset = Convert.ToInt32(node.GetAttribute("offset").ToString());
                    entry.name = node.GetAttribute("name").ToString();
                    entry.value = node.GetAttribute("value").ToString();
                    entry.depth = depth;
                    list.Add(entry);
                }
            }
            return id_out;
        }
        public static void ParamItem_GetFromXml(List<IItem> list, string fileName)
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlReaderSettings settings = new XmlReaderSettings();

            settings.IgnoreComments = true;//忽略文档里面的注释
            group_count = 0;
            try
            {
                //XmlReader reader = XmlReader.Create(Application.StartupPath + "/paramEEPROM.xml", settings);
                XmlReader reader = XmlReader.Create(fileName, settings);

                xmlDoc.Load(reader);
                XmlNodeList nodelist = ((XmlElement)xmlDoc.SelectNodes("paramList")[0]).ChildNodes;

                ParamItem_AddGroup(list, nodelist, 0, 0);
                reader.Close();
            }
            catch (Exception)
            { }
        }
        public static int ParamItem_CreatGroup(List<IItem> list, int start, int group_id, XmlDocument xmlDoc, XmlNode root)
        {
            int end;
            XmlElement node;
            for (end = start; end < list.Count; end++)
            {
                if (group_id != list[end].group_id)
                {
                    return end - 1;
                }
                if (list[end].type == IItem.type_t.group)
                {
                    ParamsEEPROM.Group group = (ParamsEEPROM.Group)list[end];
                    node = xmlDoc.CreateElement("group");
                    node.SetAttribute("name", group.name);
                    root.AppendChild(node);
                    end = ParamItem_CreatGroup(list, end + 1, group.id, xmlDoc, node);
                }
                else if (list[end].type == IItem.type_t.entry)
                {
                    ParamsEEPROM.Entry entry = (ParamsEEPROM.Entry)list[end];
                    node = xmlDoc.CreateElement("param");
                    node.SetAttribute("offset", entry.offset.ToString());
                    node.SetAttribute("name", entry.name);
                    node.SetAttribute("value", entry.value);
                    root.AppendChild(node);
                }
                else
                {
                    continue;
                }
            }
            return end;
        }
        public static void ParamItem_SaveXml(List<IItem> list, string fileName)
        {
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                XmlDeclaration dec = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
                xmlDoc.AppendChild(dec);
                XmlElement XMLroot = xmlDoc.CreateElement("paramList");
                xmlDoc.AppendChild(XMLroot);
                ParamItem_CreatGroup(list, 0, 0, xmlDoc, XMLroot);
                xmlDoc.Save(fileName);
            }
            catch (Exception)
            {
                MessageBox.Show("失败");
            }
        }
        public static byte[] toBuffer(List<IItem> list)
        {
            ArrayList buffer = new ArrayList();
            foreach (IItem item in list)
            {
                if (item.type == IItem.type_t.entry)
                {
                    string value_s = ((ParamsEEPROM.Entry)item).value;
                    byte[] value = stringToValue(value_s);
                    buffer.Add(value[0]);
                    buffer.Add(value[1]);
                }
            }

            return (byte[])buffer.ToArray(typeof(byte));
        }
        public static byte[] hexToValue(string hex)
        {
            byte[] bytes = new byte[4];
            UInt32 value = Convert.ToUInt32(hex, 16);
            bytes[0] = (byte)(value & 0xff);
            bytes[1] = (byte)(value >> 8 & 0xff);
            bytes[2] = (byte)(value >> 16 & 0xff);
            bytes[3] = (byte)(value >> 24 & 0xff);

            return bytes;
        }
        public static byte[] stringToValue(string text)
        {
            text = text.Trim();
            try
            {
                if (text.Substring(0, 2).Equals("0x") || text.Substring(0, 2).Equals("0X"))
                {
                    return hexToValue(text.Substring(2));
                }
                else
                {
                    byte[] bytes = new byte[4];
                    UInt32 value = Convert.ToUInt32(text);
                    bytes[0] = (byte)(value & 0xff);
                    bytes[1] = (byte)(value >> 8 & 0xff);
                    bytes[2] = (byte)(value >> 16 & 0xff);
                    bytes[3] = (byte)(value >> 24 & 0xff);

                    return bytes;
                }
            }
            catch (Exception)
            {
                return new byte[4] {0, 0, 0, 0 };
            }
        }
    }
}
