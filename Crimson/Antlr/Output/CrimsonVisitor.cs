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
	/// Visit a parse tree produced by <see cref="CrimsonParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompilationUnit([NotNull] CrimsonParser.CompilationUnitContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.importUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitImportUnit([NotNull] CrimsonParser.ImportUnitContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>GlobalVariableUnitStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.globalStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGlobalVariableUnitStatement([NotNull] CrimsonParser.GlobalVariableUnitStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FunctionUnitStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.globalStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionUnitStatement([NotNull] CrimsonParser.FunctionUnitStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>StructureUnitStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.globalStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructureUnitStatement([NotNull] CrimsonParser.StructureUnitStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.globalVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGlobalVariableDeclaration([NotNull] CrimsonParser.GlobalVariableDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.functionDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDeclaration([NotNull] CrimsonParser.FunctionDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.functionBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionBody([NotNull] CrimsonParser.FunctionBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FunctionVariableDeclarationStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.internalStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionVariableDeclarationStatement([NotNull] CrimsonParser.FunctionVariableDeclarationStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FunctionReturnStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.internalStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionReturnStatement([NotNull] CrimsonParser.FunctionReturnStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FunctionAssignVariableStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.internalStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionAssignVariableStatement([NotNull] CrimsonParser.FunctionAssignVariableStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FunctionAllocateMemoryStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.internalStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionAllocateMemoryStatement([NotNull] CrimsonParser.FunctionAllocateMemoryStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FunctionFunctionCallStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.internalStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionFunctionCallStatement([NotNull] CrimsonParser.FunctionFunctionCallStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FunctionIfStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.internalStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionIfStatement([NotNull] CrimsonParser.FunctionIfStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FunctionAssemblyCallStatement</c>
	/// labeled alternative in <see cref="CrimsonParser.internalStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionAssemblyCallStatement([NotNull] CrimsonParser.FunctionAssemblyCallStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.internalVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInternalVariableDeclaration([NotNull] CrimsonParser.InternalVariableDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.assignVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignVariable([NotNull] CrimsonParser.AssignVariableContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfBlock([NotNull] CrimsonParser.IfBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondition([NotNull] CrimsonParser.ConditionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.elifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElifBlock([NotNull] CrimsonParser.ElifBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.elseBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseBlock([NotNull] CrimsonParser.ElseBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.assemblyCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssemblyCall([NotNull] CrimsonParser.AssemblyCallContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCall([NotNull] CrimsonParser.FunctionCallContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.inputParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInputParameters([NotNull] CrimsonParser.InputParametersContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.allocateMemory"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAllocateMemory([NotNull] CrimsonParser.AllocateMemoryContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.functionReturn"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionReturn([NotNull] CrimsonParser.FunctionReturnContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.resolvableValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitResolvableValue([NotNull] CrimsonParser.ResolvableValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterList([NotNull] CrimsonParser.ParameterListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameter([NotNull] CrimsonParser.ParameterContext context);
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
	/// Visit a parse tree produced by <see cref="CrimsonParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType([NotNull] CrimsonParser.TypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CrimsonParser.array"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArray([NotNull] CrimsonParser.ArrayContext context);
}
} // namespace Crimson.AntlrBuild
