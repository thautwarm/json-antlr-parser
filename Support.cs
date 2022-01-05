using System.Collections.Generic;
using System.Collections;
using Antlr4.Runtime;
using System;
using System.Linq;
using System.Diagnostics;

namespace simple_json
{

    public partial interface JsonValue { }
    public partial record JBool(bool value) : JsonValue;
    public partial record JDict(List<JsonPair> value) : JsonValue;
    public partial record JFlt(float value) : JsonValue;
    public partial record JInt(int value) : JsonValue;
    public partial record JList(List<JsonValue> elements) : JsonValue;
    public partial record JNull() : JsonValue;
    public partial record JStr(string value) : JsonValue;

    public partial record JsonPair(string name, JsonValue value);


    public partial class JsonParser
    {
        public static string getStr(IToken token)
        {
            return token.Text;
        }
        public static List<T> appendList<T>(List<T> lst, T e)
        {
            lst.Add(e);
            return lst;
        }
        public static Dictionary<K, V> mk_dict<K, V>(List<(K, V)> lst)
        {
            var ret = new Dictionary<K, V>();
            foreach (var (k, v) in lst)
            {
                ret[k] = v;
            }
            return ret;
        }
        public static int parseInt(string s) => int.Parse(s, System.Globalization.NumberStyles.AllowExponent);
        public static float parseFlt(string s) => float.Parse(s);
        public static string unesc(string s) =>
            System.Text.RegularExpressions.Regex.Unescape(s.Substring(1, s.Length - 2));

    }
}

