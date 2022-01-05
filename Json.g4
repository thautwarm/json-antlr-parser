grammar Json;
options {
	language = CSharp;
}

start
	returns[JsonValue result]:
	var_0__1 = json { $result = _localctx.var_0__1.result; };
jsonpair
	returns[JsonPair result]:
	var_0__1 = STR ':' var_0__3 = json { $result = new JsonPair(unesc(getStr(_localctx.var_0__1)), _localctx.var_0__3.result); 
		};
seplist_of_comma_and_json
	returns[List<JsonValue> result]:
	var_0__1 = json { $result = new List<JsonValue> { _localctx.var_0__1.result }; }
	| var_1__1 = seplist_of_comma_and_json ',' var_1__3 = json { 
                _localctx.var_1__1.result.Add(_localctx.var_1__3.result);
                $result = _localctx.var_1__1.result;
            };
seplist_of_comma_and_json_pair
	returns[List<JsonPair> result]:
	var_0__1 = jsonpair {  $result = new List<JsonPair> { _localctx.var_0__1.result };
            }
	| var_1__1 = seplist_of_comma_and_json_pair ',' var_1__3 = jsonpair { 
                _localctx.var_1__1.result.Add(_localctx.var_1__3.result);
                $result = _localctx.var_1__1.result;
            };
json
	returns[JsonValue result]:
	var_0__1 = INT { $result = new JInt(parseInt(getStr(_localctx.var_0__1))); }
	| var_1__1 = FLOAT { $result = new JFlt(parseFlt(getStr(_localctx.var_1__1))); }
	| 'null' { $result = new JNull(); }
	| var_3__1 = STR { $result = new JStr(unesc(getStr(_localctx.var_3__1))); }
	| '[' ']' { $result = new JList(new List<JsonValue> {  }); }
	| '{' '}' { $result = new JDict(new List<JsonPair> {  }); }
	| 'true' { $result = new JBool(true); }
	| 'false' { $result = new JBool(false); }
	| '[' var_8__2 = seplist_of_comma_and_json ']' { $result = new JList(_localctx.var_8__2.result); }
	| '{' var_9__2 = seplist_of_comma_and_json_pair '}' { $result = new JDict(_localctx.var_9__2.result); }
    ;

fragment DIGIT: [\u0030-\u0039];
INT: DIGIT+;
FLOAT: DIGIT* '.' INT;
STR: '"' (('\\' .) | ~'"')* '"';
SPACE: ('\t' | '\n' | '\r' | ' ')+ -> skip;
