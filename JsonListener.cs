//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Json.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace simple_json {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="JsonParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public interface IJsonListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="JsonParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStart([NotNull] JsonParser.StartContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JsonParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStart([NotNull] JsonParser.StartContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JsonParser.jsonpair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJsonpair([NotNull] JsonParser.JsonpairContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JsonParser.jsonpair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJsonpair([NotNull] JsonParser.JsonpairContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JsonParser.seplist_of_comma_and_json"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSeplist_of_comma_and_json([NotNull] JsonParser.Seplist_of_comma_and_jsonContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JsonParser.seplist_of_comma_and_json"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSeplist_of_comma_and_json([NotNull] JsonParser.Seplist_of_comma_and_jsonContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JsonParser.seplist_of_comma_and_json_pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSeplist_of_comma_and_json_pair([NotNull] JsonParser.Seplist_of_comma_and_json_pairContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JsonParser.seplist_of_comma_and_json_pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSeplist_of_comma_and_json_pair([NotNull] JsonParser.Seplist_of_comma_and_json_pairContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JsonParser.json"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJson([NotNull] JsonParser.JsonContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JsonParser.json"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJson([NotNull] JsonParser.JsonContext context);
}
} // namespace simple_json
