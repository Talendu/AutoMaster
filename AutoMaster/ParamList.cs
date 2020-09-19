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
            public FRAME()
            {
                data = new byte[2];
            }
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
            /*
            items.Add(new ParamItem(0, "SystemPara.TargetVersion", "0", "", ""));
            items.Add(new ParamItem(1, "SystemPara.SoftwareVersion", "0", "", ""));
            items.Add(new ParamItem(2, "SystemPara.SerialNumber", "0", "", ""));
            items.Add(new ParamItem(3, "VehicleWorkMode", "0", "{Power_Mode=0,Economy_Mode=1}", ""));
            items.Add(new ParamItem(4, "MotorWorkMode", "0", "{Speed_Mode=0,Torqu_Mode=1}", ""));
            items.Add(new ParamItem(5, "Typer_Max_Speed", "0", "", "rpm"));
            items.Add(new ParamItem(6, "Torque_Base", "0", "", ""));
            items.Add(new ParamItem(7, "SpeedModePara.Max_Speed", "0", "/327.67", "%"));
            items.Add(new ParamItem(8, "SpeedModePara.Kaff", "0", "/10", "A"));
            items.Add(new ParamItem(9, "SpeedModePara.Kbff", "0", "/10", "A"));
            //items.Add(new ParamItem(10, "SpeedModePara.Ka_b_BuiltRate", "0", "/1000", "s"));
            items.Add(new ParamItem(11, "SpeedModePara.Ka_b_ReleaseRate", "0", "/1000", "s"));
            items.Add(new ParamItem(12, "SpeedModePara.Full_Accel_Rate_HS", "0", "/1000", "s"));
            items.Add(new ParamItem(13, "SpeedModePara.Full_Accel_Rate_LS", "0", "/1000", "s"));
            items.Add(new ParamItem(14, "SpeedModePara.Low_Accel_Rate", "0", "/1000", "s"));
            items.Add(new ParamItem(15, "SpeedModePara.Neutral_Decel_Rate_HS", "0", "/1000", "s"));
            items.Add(new ParamItem(16, "SpeedModePara.Neutral_Decel_Rate_LS", "0", "/1000", "s"));
            items.Add(new ParamItem(17, "SpeedModePara.Full_Brake_Rate_HS", "0", "/1000", "s"));
            items.Add(new ParamItem(18, "SpeedModePara.Full_Brake_Rate_LS", "0", "/1000", "s"));
            items.Add(new ParamItem(19, "SpeedModePara.Low_Brake_Rate", "0", "/1000", "s"));
            items.Add(new ParamItem(20, "SpeedModePara.Partial_Decel_Rate", "0", "/1000", "s"));
            items.Add(new ParamItem(21, "SpeedModePara.High_Speed", "0", "/327.67", "%"));
            items.Add(new ParamItem(22, "SpeedModePara.Low_Speed", "0", "/327.67", "%"));
            items.Add(new ParamItem(23, "SpeedModePara.Reversal_Soften", "0", "/32767", "%"));
            items.Add(new ParamItem(24, "SpeedModePara.Max_Speed_Accel", "0", "/1000", "s"));
            items.Add(new ParamItem(25, "SpeedModePara.Max_Speed_Decel", "0", "/1000", "s"));
            items.Add(new ParamItem(26, "SpeedModePara.soft_stop_Speed", "0", "", "rpm"));
            items.Add(new ParamItem(27, "TorqueModePara.Max_Speed", "0", "/327.67", "%"));
            items.Add(new ParamItem(28, "TorqueModePara.Accel_Rate", "0", "/1000", "s"));
            items.Add(new ParamItem(29, "TorqueModePara.Accel_Release_Rate", "0", "/1000", "s"));
            items.Add(new ParamItem(30, "TorqueModePara.Brake_Rate", "0", "/1000", "s"));
            items.Add(new ParamItem(31, "TorqueModePara.Brake_Release_Rate", "0", "/1000", "s"));
            items.Add(new ParamItem(32, "TorqueModePara.Neutral_Braking", "0", "/327.67", "%"));
            items.Add(new ParamItem(33, "TorqueModePara.Neutral_Typer_Speed", "0", "", "rpm"));
            items.Add(new ParamItem(34, "TorqueModePara.Creep_Torque", "0", "/327.67", "%"));
            items.Add(new ParamItem(35, "TorqueModePara.Brake_Full_Creep_Cancel", "0", "/327.67", "%"));
            items.Add(new ParamItem(36, "TorqueModePara.Creep_Build_Rate", "0", "/1000", "s"));
            items.Add(new ParamItem(37, "TorqueModePara.Creep_Release_Rate", "0", "/1000", "s"));
            items.Add(new ParamItem(38, "TorqueModePara.Gear_Soften", "0", "/327.67", "%"));
            items.Add(new ParamItem(39, "TorqueModePara.Brake_Typer_Speed", "0", "", "rpm"));
            items.Add(new ParamItem(40, "TorqueModePara.Reversal_Soften", "0", "/30", "%"));
            items.Add(new ParamItem(41, "TorqueModePara.Max_Speed_Decel", "0", "/1000", "s"));
            items.Add(new ParamItem(42, "TorqueLimit.Restraint_Forward", "0", "/327.67", "%"));
            items.Add(new ParamItem(43, "TorqueLimit.Restraint_Back", "0", "/327.67", "%"));
            items.Add(new ParamItem(44, "TorqueLimit.Drive_Current_Limit", "0", "/327.67", "%"));
            items.Add(new ParamItem(45, "TorqueLimit.Regen_Current_Limit", "0", "/327.67", "%"));
            items.Add(new ParamItem(46, "TorqueLimit.Brake_Current_Limit", "0", "/327.67", "%"));
            items.Add(new ParamItem(47, "TorqueLimit.EMR_Current_Limit", "0", "/327.67", "%"));
            items.Add(new ParamItem(48, "TorqueLimit.Interlock_Brake_Limit", "0", "/327.67", "%"));
            items.Add(new ParamItem(49, "PowerLimitMap.Nominal_Speed", "0", "", ""));
            items.Add(new ParamItem(50, "PowerLimitMap.Delta_Speed", "0", "", ""));
            items.Add(new ParamItem(51, "DriveLimitMap.PowerMode.Nominal", "0", "/327.67", "%"));
            items.Add(new ParamItem(52, "DriveLimitMap.PowerMode.Plus_Delta", "0", "/327.67", "%"));
            items.Add(new ParamItem(53, "DriveLimitMap.PowerMode.Plus_2xDelta", "0", "/327.67", "%"));
            items.Add(new ParamItem(54, "DriveLimitMap.PowerMode.Plus_4xDelta", "0", "/327.67", "%"));
            items.Add(new ParamItem(55, "DriveLimitMap.PowerMode.Plus_8xDelta", "0", "/327.67", "%"));
            items.Add(new ParamItem(56, "DriveLimitMap.EconomyMode.Nominal", "0", "/327.67", "%"));
            items.Add(new ParamItem(57, "DriveLimitMap.EconomyMode.Plus_Delta", "0", "/327.67", "%"));
            items.Add(new ParamItem(58, "DriveLimitMap.EconomyMode.Plus_2xDelta", "0", "/327.67", "%"));
            items.Add(new ParamItem(59, "DriveLimitMap.EconomyMode.Plus_4xDelta", "0", "/327.67", "%"));
            items.Add(new ParamItem(60, "DriveLimitMap.EconomyMode.Plus_8xDelta", "0", "/327.67", "%"));
            items.Add(new ParamItem(61, "RegenLimitMap.Nominal", "0", "/327.67", "%"));
            items.Add(new ParamItem(62, "RegenLimitMap.Plus_Delta", "0", "/327.67", "%"));
            items.Add(new ParamItem(63, "RegenLimitMap.Plus_2xDelta", "0", "/327.67", "%"));
            items.Add(new ParamItem(64, "RegenLimitMap.Plus_4xDelta", "0", "/327.67", "%"));
            items.Add(new ParamItem(65, "RegenLimitMap.Plus_8xDelta", "0", "/327.67", "%"));
            items.Add(new ParamItem(66, "Throttle.Throttle_Type", "0", "", ""));
            items.Add(new ParamItem(67, "Throttle.Throttle_Chk_Range", "0", "/32760", ""));
            items.Add(new ParamItem(68, "Throttle.Forward_Deadband", "0", "/6553.4", "V"));
            items.Add(new ParamItem(69, "Throttle.Forward_Map", "0", "/327.67", "%"));
            items.Add(new ParamItem(70, "Throttle.Forward_Max", "0", "/6553.4", "V"));
            items.Add(new ParamItem(71, "Throttle.Forward_Offset", "0", "/327.67", "%"));
            items.Add(new ParamItem(72, "Throttle.Reverse_Deadband", "0", "/6553.4", "V"));
            items.Add(new ParamItem(73, "Throttle.Reverse_Map", "0", "/327.67", "%"));
            items.Add(new ParamItem(74, "Throttle.Reverse_Max", "0", "/6553.4", "V"));
            items.Add(new ParamItem(75, "Throttle.Reverse_Offset", "0", "/327.67", "%"));
            items.Add(new ParamItem(76, "Throttle.Throttle_Ctr_En", "0", "{off=0,on=1}", ""));
            items.Add(new ParamItem(77, "Throttle.Throttle_Value", "0", "/327.67", "%"));
            items.Add(new ParamItem(78, "Brake.Brake_Pedal_Enable", "0", "{off=0,on=1}", ""));
            items.Add(new ParamItem(79, "Brake.Brake_Type", "0", "", ""));
            items.Add(new ParamItem(80, "Brake.Brake_Deadband", "0", "/6553.4", "V"));
            items.Add(new ParamItem(81, "Brake.Brake_Map", "0", "/327.67", "%"));
            items.Add(new ParamItem(82, "Brake.Brake_Max", "0", "/6553.4", "V"));
            items.Add(new ParamItem(83, "Brake.Brake_Offset", "0", "/327.67", "%"));
            items.Add(new ParamItem(84, "Brake.Brake_Ctr_En", "0", "{off=0,on=1}", ""));
            items.Add(new ParamItem(85, "Brake.Brake_Value", "0", "/327.67", "%"));
            items.Add(new ParamItem(86, "LosCtr_En", "0", "{off=0,on=1}", ""));
            items.Add(new ParamItem(87, "TemperatureMap.Motor_Temp_En", "0", "{off=0,on=1}", ""));
            items.Add(new ParamItem(88, "TemperatureMap.Motor_Temp_Hot", "0", "/10", ""));
            items.Add(new ParamItem(89, "TemperatureMap.Motor_Temp_Max", "0", "/10", ""));
            items.Add(new ParamItem(90, "TemperatureMap.MCU_Temp_En", "0", "{off=0,on=1}", ""));
            items.Add(new ParamItem(91, "TemperatureMap.MCU_Temp_Hot", "0", "/10", ""));
            items.Add(new ParamItem(92, "TemperatureMap.MCU_Temp_Max", "0", "/10", ""));
            items.Add(new ParamItem(93, "TemperatureMap.MCU_LowTemp_En", "0", "{off=0,on=1}", ""));
            items.Add(new ParamItem(94, "TemperatureMap.MCU_Temp_Cool", "0", "/10", ""));
            items.Add(new ParamItem(95, "TemperatureMap.MCU_Temp_min", "0", "/10", ""));
            items.Add(new ParamItem(96, "VoltageMap.Nominal_Voltage", "0", "/10", "V"));
            items.Add(new ParamItem(97, "VoltageMap.UnderVol_Cutback_En", "0", "{disable=0,enable=1}", ""));
            items.Add(new ParamItem(98, "VoltageMap.UnderVol_Cutback_Range", "0", "/10", "V"));
            items.Add(new ParamItem(99, "VoltageMap.User_UnderVoltage", "0", "/40.96", "%"));
            items.Add(new ParamItem(100, "VoltageMap.OverVol_Cutback_En", "0", "{disable=0,enable=1}", ""));
            items.Add(new ParamItem(101, "VoltageMap.OverVol_Cutback_Range", "0", "/10", "V"));
            items.Add(new ParamItem(102, "VoltageMap.User_OverVoltage", "0", "/40.996", "V"));
            items.Add(new ParamItem(103, "Battery.Reset_Voltage_Level", "0", "/10", ""));
            items.Add(new ParamItem(104, "Battery.Full_Voltage_Level", "0", "/10", ""));
            items.Add(new ParamItem(105, "Battery.Empty_Voltage_Level", "0", "/10", ""));
            items.Add(new ParamItem(106, "Battery.Discharge_Time", "0", "", "min"));
            items.Add(new ParamItem(107, "Battery.BDI_Reset_Percent", "0", "", "%"));*/
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
        public static List<ParamItem> ParamList_Update(List<ParamItem> list, ArrayList rxBuffer)
        {
            FRAME frame = new FRAME();
            List<ParamItem> outList = new List<ParamItem>();
            byte[] stream;
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
                    end = find(stream, index + 6, rxBuffer.Count, Convert.ToByte('\n'));
                    if (end < 0)
                    {
                        rxBuffer.Clear();
                        break;
                    }
                    rxBuffer.RemoveRange(0, end + 1);
                    if (end - index < 6)
                        continue;
                    frame.head = stream[index];
                    frame.data_type = stream[index + 3];
                    if ((frame.data_type & 0x0f) == 2)
                    {
                        frame.crc = stream[index + 6];
                        if (calculate_crc(stream.Skip(1).Take(5).ToArray(), 5) == frame.crc)
                        {
                            frame.id = (UInt16)(256 * stream[index + 2] + stream[index + 1]);
                            frame.data[0] = stream[index + 4];
                            frame.data[1] = stream[index + 5];
                            int listIndex = FindById(list, frame.id);
                            if (listIndex < 0)
                            {
                                continue;
                            }
                            if (list[listIndex].formula != null &&
                                list[listIndex].formula.Length > 0 &&
                                list[listIndex].formula.Substring(0, 1).Equals("/"))
                            {
                                double value = Convert.ToDouble(frame.data[1]) * 256.0 + Convert.ToDouble(frame.data[0]);
                                string formula = list[listIndex].formula.Substring(1);
                                value = value / Convert.ToDouble(formula);
                                string str_value = value.ToString("f6");
                                //if (!str_value.Equals(list[frame.id].value))
                                //{
                                    list[listIndex].value = str_value;
                                //}
                                //else
                                //{
                                //    continue;
                                //}
                            }
                            else
                            {
                                list[listIndex].value = ((Convert.ToUInt16(frame.data[1]) << 8) + frame.data[0]).ToString();
                            }
                            outList.Add(list[listIndex]);
                        }
                    }
                }
                catch (Exception)
                {
                    rxBuffer.Remove(null);
                }
            }

            return outList;
        }
    }
}
