using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using AvaExt.Manual.Table;
using AvaExt.Formating;

namespace AvaExt.Common
{
    public class ToolString
    {
        const char groupSep = ';';
        const char itemsSep = ',';

        public static IDictionary<string, string> explodeForParameters(string str, IDictionary<string, string> dic, char gS, char iS)
        {
            //qwe,123;qw,34

            str = str.Trim();
            string[] arrgrp = trim(str.Split(gS));
            for (int i = 0; i < arrgrp.Length; ++i)
                if (arrgrp[i] != string.Empty)
                {
                    string[] arrItm = trim(arrgrp[i].Split(iS));
                    if (arrItm.Length > 1 && !dic.ContainsKey(arrItm[0]))
                        dic.Add(arrItm[0], arrItm[1]);
                }
            return dic;
        }
        public static IDictionary<string, string> explodeForParameters(string str)
        {
            return explodeForParameters(str, new Dictionary<string, string>());
        }
        public static IDictionary<string, string> explodeForParameters(string str, IDictionary<string, string> dic)
        {
            return explodeForParameters(str, dic, ';', ',');
        }
        public static string[] trim(string[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
                arr[i] = arr[i].Trim();
            return arr;
        }
        public static string[] removeEmpty(string[] arr)
        {
            List<string> list = new List<string>(arr);
            for (int i = 0; i < list.Count; ++i)
            {
                if (arr[i] == string.Empty)
                {
                    list.RemoveAt(i);
                    --i;
                }
            }
            return list.ToArray();
        }
        public static string[] explodeList(string str)
        {
            return str.Split(',');
        }
        public static string[] explodeList(char sep, string str)
        {
            return str.Split(sep);
        }
        public static string[][] explodeGroupList(string text)
        {
            string[] arrGroup = explodeGroup(text);
            List<string[]> list = new List<string[]>();
            foreach (string str in arrGroup)
                list.Add(explodeList(str));
            return list.ToArray();

        }
        public static string joinList(string[] arr)
        {
            return joinList(",", arr);
        }
        public static string joinList(string sep, string[] arr)
        {
            return string.Join(sep, arr);
        }
        public static string joinList(char sep, string[] arr)
        {
            return string.Join(sep.ToString(), arr);
        }
        public static string[] explodeListLogical(string str)
        {
            return ToolString.removeEmpty(ToolString.trim(ToolString.explodeList(str)));
        }
        public static string[] explodeGroup(string str)
        {
            return str.Split(';');
        }
        public static bool isDigit(string txt)
        {
            for (int i = 0; i < txt.Length; ++i)
                if (!Char.IsDigit(txt[i]))
                    return false;
            return true;
        }
        public static string shrincDigit(string txt)
        {
            string res = string.Empty;
            for (int i = 0; i < txt.Length; ++i)
                if (Char.IsDigit(txt[i]))
                    res += txt[i];
            res = res.TrimStart('0');
            return (res == string.Empty ? "0" : res);
        }

        public static string reverce(string txt)
        {
            char[] arr = txt.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        public static string incrementAsDigt(string str, bool fromRight)
        {

            Int64 val = Int64.Parse(shrincDigit(fromRight ? str : reverce(str)));
            ++val;
            return shrincDigit(fromRight ? val.ToString() : reverce(val.ToString()));

        }

        public static DataTable explodeForTable(string text, string[] cols)
        {
            DataTable table = new DataTable(TableDUMMY.TABLE);
            for (int i = 0; i < cols.Length; ++i)
                table.Columns.Add(cols[i], typeof(string));

            string[] arrgrp = trim(text.Split(groupSep));
            for (int i = 0; i < arrgrp.Length; ++i)
                if (arrgrp[i] != string.Empty)
                {
                    string[] arrItm = trim(arrgrp[i].Split(itemsSep));
                    if (arrItm.Length > 0)
                        table.Rows.Add(arrItm);
                }
            return table;
        }

        public static string[] breakList(string str)
        {
            return breakList(itemsSep, str);
        }
        public static string[] breakList(char sep, string str)
        {
            if (str == null || str == string.Empty)
                return new string[0];
            return str.Split(new char[] { sep }, 2);
        }


        public static string substring(string str, int startIndx, short len)
        {
            int realStartIndx = Math.Min(startIndx, str.Length);
            int realLen = Math.Min(len, str.Length - realStartIndx);
            return str.Substring(realStartIndx, realLen);
        }

        public static string[] createArray(int len, string fill)
        {
            string[] arr = new string[len];
            for (int i = 0; i < arr.Length; ++i)
                arr[i] = fill;
            return arr;
        }

        public static string toHex(string p)
        {
            string res = string.Empty;
            for (int i = 0; i < p.Length; ++i)
                res += ((byte)p[i]).ToString("X").PadLeft(2, '0');
            return res;
        }
        public static string toHex(byte[] arr)
        {
            string res = string.Empty;
            for (int i = 0; i < arr.Length; ++i)
                res += (arr[i]).ToString("X").PadLeft(2, '0');
            return res;
        }
        public static string fromHex(string p)
        {
            string res = string.Empty;
            for (int i = 0; i < p.Length; i = i + 2)
                res += (char)byte.Parse(substring(p, i, 2).PadRight(2, '0'), System.Globalization.NumberStyles.HexNumber);
            return res;
        }

        public static string toGuid(string p)
        {
            return toHex(p).PadRight(32, '0').Insert(8, "-").Insert(12 + 1, "-").Insert(16 + 2, "-").Insert(20 + 3, "-");
        }


        public static string fromGuid(string p)
        {
            return fromHex(p.Replace("-", "").TrimEnd('0'));
        }




        public static string[] split(string str, string sep)
        {
            string data = str;
            int indx;
            List<string> list = new List<string>();
            if ((sep != string.Empty) && (str != string.Empty))
            {
                while (data != string.Empty && (indx = data.IndexOf(sep)) >= 0)
                {
                    list.Add(data.Substring(0, indx));
                    data = data.Remove(0, indx + sep.Length);
                }
                if (data != string.Empty)
                    list.Add(data);
            }
            return list.ToArray();
        }



        public static string[] toString(object[] data)
        {
            string[] arr = new string[data.Length];
            for (int i = 0; i < data.Length; ++i)
                arr[i] = data[i].ToString();
            return arr;

        }

        public static string separate(string p, int step, string sep)
        {
            string tmp = p;
            int indx = step;
            while (indx < tmp.Length)
            {
                tmp = tmp.Insert(indx, sep.ToString());
                indx += step + sep.Length;
            }
            return tmp;


        }
        public static double[] strToDoubleArr(string list)
        {
            XmlFormating _format = new XmlFormating();
            string[] items = ToolString.trim(ToolString.explodeList(list));
            List<double> valsList = new List<double>();
            foreach (string itm in items)
                if (itm != string.Empty)
                {
                    object obj = _format.parse(itm, typeof(double));
                    if (obj != null)
                        valsList.Add((double)obj);
                }
            return valsList.ToArray();
        }
        public static int[] strToIntArr(string list)
        {
            XmlFormating _format = new XmlFormating();
            string[] items = ToolString.trim(ToolString.explodeList(list));
            List<int> valsList = new List<int>();
            foreach (string itm in items)
                if (itm != string.Empty)
                {
                    object obj = _format.parse(itm, typeof(int));
                    if (obj != null)
                        valsList.Add((int)obj);
                }
            return valsList.ToArray();
        }



        public static string left(string pStr, int pLen)
        {
            pLen = Math.Max(0, pLen);
            return pStr.Substring(0, Math.Min(pLen, pStr.Length));
        }
        public static string right(string pStr, int pLen)
        {
            pLen = Math.Max(0, pLen);
            return pStr.Remove(0, Math.Max(pStr.Length - pLen, 0));
        }
    }
}
































