//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.11.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Input/Crimson.g4 by ANTLR 4.11.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Crimson.AntlrBuild {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="CrimsonParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
[System.CLSCompliant(false)]
public interface ICrimsonVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.scope"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScope([NotNull] CrimsonParser.ScopeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.importUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitImportUnit([NotNull] CrimsonParser.ImportUnitContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.operationHandler"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperationHandler([NotNull] CrimsonParser.OperationHandlerContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>VariableDeclarationStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableDeclarationStatement([NotNull] CrimsonParser.VariableDeclarationStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ReturnStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturnStatement([NotNull] CrimsonParser.ReturnStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AssignVariableStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignVariableStatement([NotNull] CrimsonParser.AssignVariableStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FunctionCallStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCallStatement([NotNull] CrimsonParser.FunctionCallStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IfStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStatement([NotNull] CrimsonParser.IfStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>WhileStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileStatement([NotNull] CrimsonParser.WhileStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BasicCallStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBasicCallStatement([NotNull] CrimsonParser.BasicCallStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AssemblyCallStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssemblyCallStatement([NotNull] CrimsonParser.AssemblyCallStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>GlobalVariableStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGlobalVariableStatement([NotNull] CrimsonParser.GlobalVariableStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FunctionDeclarationStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDeclarationStatement([NotNull] CrimsonParser.FunctionDeclarationStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>StructureDeclarationStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructureDeclarationStatement([NotNull] CrimsonParser.StructureDeclarationStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.internalVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInternalVariableDeclaration([NotNull] CrimsonParser.InternalVariableDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AssignVariableDirect</c>
	/// labeled alternative in <see cref="CrimsonParser.assignVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignVariableDirect([NotNull] CrimsonParser.AssignVariableDirectContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AssignVariableAtPointer</c>
	/// labeled alternative in <see cref="CrimsonParser.assignVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignVariableAtPointer([NotNull] CrimsonParser.AssignVariableAtPointerContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfBlock([NotNull] CrimsonParser.IfBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileBlock([NotNull] CrimsonParser.WhileBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondition([NotNull] CrimsonParser.ConditionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseIfBlock([NotNull] CrimsonParser.ElseIfBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.elseBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseBlock([NotNull] CrimsonParser.ElseBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.basicCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBasicCall([NotNull] CrimsonParser.BasicCallContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.assemblyCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssemblyCall([NotNull] CrimsonParser.AssemblyCallContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.globalVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGlobalVariableDeclaration([NotNull] CrimsonParser.GlobalVariableDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.scopedVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScopedVariableDeclaration([NotNull] CrimsonParser.ScopedVariableDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.functionDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDeclaration([NotNull] CrimsonParser.FunctionDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.functionHeader"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionHeader([NotNull] CrimsonParser.FunctionHeaderContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCall([NotNull] CrimsonParser.FunctionCallContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArguments([NotNull] CrimsonParser.ArgumentsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.functionReturn"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionReturn([NotNull] CrimsonParser.FunctionReturnContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.simpleValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleValue([NotNull] CrimsonParser.SimpleValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.complexValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComplexValue([NotNull] CrimsonParser.ComplexValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.rawValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRawValue([NotNull] CrimsonParser.RawValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperation([NotNull] CrimsonParser.OperationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameter([NotNull] CrimsonParser.ParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterList([NotNull] CrimsonParser.ParameterListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.structureDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructureDeclaration([NotNull] CrimsonParser.StructureDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.structureBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructureBody([NotNull] CrimsonParser.StructureBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.array"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArray([NotNull] CrimsonParser.ArrayContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.fullName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFullName([NotNull] CrimsonParser.FullNameContext context);
}
} // namespace Crimson.AntlrBuild
