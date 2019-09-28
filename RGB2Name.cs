using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LEDAnalysor
{
    class CLR2Name
    {
        public enum RGBName
        {
            [Description("红")]
            Red = 1,
            [Description("绿")]
            Green,
            [Description("蓝")]
            Blue,
            [Description("深红")]
            DarkRed,
            [Description("深绿")]
            DarkGreen,
            [Description("深蓝")]
            DarkBlue,
            [Description("浅红")]
            LightRed,
            [Description("浅绿")]
            LightGreen,
            [Description("浅蓝")]
            LightBlue,
            [Description("黄")]
            Yellow,
            [Description("青")]
            Cyan,
            [Description("紫")]
            Purple,
            [Description("深黄")]
            DarkYellow,
            [Description("深青")]
            DarkCyan,
            [Description("深紫")]
            DarkPurple,
            [Description("浅黄")]
            LightYellow,
            [Description("浅青")]
            LightCyan,
            [Description("浅紫")]
            LightPurple,
            [Description("橙")]
            Orange,
            [Description("黄绿")]
            YellowGreen,
            [Description("青绿")]
            CyanGreen,
            [Description("青蓝")]
            CyanBlue,
            [Description("紫蓝")]
            PurpleBlue,
            [Description("紫红")]
            PurpleRed,
            [Description("黑")]
            Black,
            [Description("白")]
            White,
            [Description("灰")]
            Gray,
            [Description("浅灰")]
            LightGray,
        }

        public static string CLRToName(Color Clr)
        {
            double d_r = (double)Clr.R / 83;
            double d_g = (double)Clr.G / 83;
            double d_b = (double)Clr.B / 83;
            int r = (int)Math.Round(d_r);
            int g = (int)Math.Round(d_g);
            int b = (int)Math.Round(d_b);
            string rgb = r.ToString() + "," + g.ToString() + "," + b.ToString();           
            #region "switch (rgb)"
            switch (rgb)
            {
                case "0,0,0":
                case "1,1,1":
                case "2,2,2":
                case "3,3,3":
                    if (r == 0) return RGBName.Black.GetDescription();
                    if (r == 1) return RGBName.Gray.GetDescription();
                    if (r == 2) return RGBName.LightGray.GetDescription();
                    if (r == 3) return RGBName.White.GetDescription();
                    break;
                case "0,0,3":
                case "0,3,0":
                case "3,0,0":
                case "1,1,3":
                case "1,3,1":
                case "3,1,1":
                case "0,1,3":
                case "0,3,1":
                case "3,0,1":
                case "1,0,3":
                case "1,3,0":
                case "3,1,0":
                case "0,0,2":
                case "0,2,0":
                case "2,0,0":
                case "1,1,2":
                case "1,2,1":
                case "2,1,1":
                case "0,1,2":
                case "0,2,1":
                case "2,0,1":
                case "1,0,2":
                case "1,2,0":
                case "2,1,0":
                    if (r == 2) return RGBName.DarkRed.GetDescription();
                    if (g == 2) return RGBName.DarkGreen.GetDescription();
                    if (b == 2) return RGBName.DarkBlue.GetDescription();
                    if (r == 3) return RGBName.Red.GetDescription();
                    if (g == 3) return RGBName.Green.GetDescription();
                    if (b == 3) return RGBName.Blue.GetDescription();
                    break;
                case "0,0,1":
                case "0,1,0":
                case "1,0,0":                  
                case "2,2,3":
                case "2,3,2":
                case "3,2,2":
                    if (r == 1) return RGBName.DarkRed.GetDescription();
                    if (g == 1) return RGBName.DarkGreen.GetDescription();
                    if (b == 1) return RGBName.DarkBlue.GetDescription();
                    if (r == 3) return RGBName.LightRed.GetDescription();
                    if (g == 3) return RGBName.LightGreen.GetDescription();
                    if (b == 3) return RGBName.LightBlue.GetDescription();
                    break;
                case "1,1,0":
                case "0,1,1":
                case "1,0,1":
                case "2,2,0":
                case "0,2,2":
                case "2,0,2":
                case "2,2,1":
                case "1,2,2":
                case "2,1,2":
                case "3,3,0":
                case "0,3,3":
                case "3,0,3":
                case "3,3,1":
                case "1,3,3":
                case "3,1,3":
                case "3,3,2":
                case "2,3,3":
                case "3,2,3":
                    if (r == 1 && g == 1) return RGBName.DarkYellow.GetDescription();
                    if (g == 1 && b == 1) return RGBName.DarkCyan.GetDescription();
                    if (r == 1 && b == 1) return RGBName.DarkPurple.GetDescription();
                    if (r == 2 && g == 2) return RGBName.Yellow.GetDescription();
                    if (g == 2 && b == 2) return RGBName.Cyan.GetDescription();
                    if (r == 2 && b == 2) return RGBName.Purple.GetDescription();
                    if (r == 3 && g == 3) return RGBName.LightYellow.GetDescription();
                    if (g == 3 && b == 3) return RGBName.LightCyan.GetDescription();
                    if (r == 3 && b == 3) return RGBName.LightPurple.GetDescription();
                    break;
                case "3,2,0":
                case "3,2,1":
                    return RGBName.Orange.GetDescription();
                case "2,3,0":
                case "2,3,1":
                    return RGBName.YellowGreen.GetDescription();
                case "0,3,2":
                case "1,3,2":
                    return RGBName.CyanGreen.GetDescription();
                case "0,2,3":
                case "1,2,3":
                    return RGBName.CyanBlue.GetDescription();
                case "3,0,2":
                case "3,1,2":
                    return RGBName.PurpleRed.GetDescription();
                case "2,0,3":
                case "2,1,3":
                    return RGBName.PurpleBlue.GetDescription();
                default:
                    return "Error";
            }
            #endregion
            return "Error";
        }

        public static List <string> CLR2RGBN(Color Clr)
        {
            List<string> list = new List<string>();
            list.Add(Clr.R.ToString());
            list.Add(Clr.G.ToString());
            list.Add(Clr.B.ToString());
            list.Add(CLRToName(Clr));
            return list;
        }

        private static void Test()
        {
            foreach (var item in typeof(Color).GetMembers())
            {
                if (item.MemberType == System.Reflection.MemberTypes.Property && System.Drawing.Color.FromName(item.Name).IsKnownColor == true)
                //只取属性且为属性中的已知Color，剔除byte属性以及一些布尔属性等（A B G R IsKnownColor Name等）
                {
                    Color Clr = Color.FromName(item.Name);
                    List<string> list = CLR2RGBN(Clr);
                    string rgbn = item.Name + "(" + list[0] + "," + list[1] + "," + list[2] + "):" + list[3];
                    Console.WriteLine(rgbn);
                }
            }
        }

    }
    public static class Extension
    {
        public static string GetDescription(this Enum en)
        {
            Type type = en.GetType();   //获取类型     
            MemberInfo[] memberInfos = type.GetMember(en.ToString());   //获取成员     
            if (memberInfos != null && memberInfos.Length > 0)
            {
                DescriptionAttribute[] attrs = memberInfos[0].GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];   //获取描述特性          
                if (attrs != null && attrs.Length > 0)
                {
                    return attrs[0].Description;    //返回当前描述     
                }
            }
            return en.ToString();
        }

    }

}
