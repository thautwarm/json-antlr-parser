using System.Collections.Generic;
using System.Collections;
using Antlr4.Runtime;
using System;
using System.Linq;
using System.Diagnostics;

namespace simple_json
{

    public class App
    {
        public static JsonValue Parse(string s)
        {
            ICharStream stream = CharStreams.fromString(s);
            ITokenSource lexer = new JsonLexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            var parser = new JsonParser(tokens);
            parser.BuildParseTree = false;
            var result = parser.start().result;
            return result;
        }
        public static void Main(string[] modes)
        {
            var text = System.IO.File.ReadAllText(modes[0]);
            Console.WriteLine(Parse(text).ToString());
        }
    }
}