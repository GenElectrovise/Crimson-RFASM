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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ICrimsonListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class CrimsonBaseListener : ICrimsonListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.compilationUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompilationUnit([NotNull] CrimsonParser.CompilationUnitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.compilationUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompilationUnit([NotNull] CrimsonParser.CompilationUnitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.packageDefinitionList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPackageDefinitionList([NotNull] CrimsonParser.PackageDefinitionListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.packageDefinitionList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPackageDefinitionList([NotNull] CrimsonParser.PackageDefinitionListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.packageDefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPackageDefinition([NotNull] CrimsonParser.PackageDefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.packageDefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPackageDefinition([NotNull] CrimsonParser.PackageDefinitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.packageDependencyList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPackageDependencyList([NotNull] CrimsonParser.PackageDependencyListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.packageDependencyList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPackageDependencyList([NotNull] CrimsonParser.PackageDependencyListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.packageDependency"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPackageDependency([NotNull] CrimsonParser.PackageDependencyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.packageDependency"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPackageDependency([NotNull] CrimsonParser.PackageDependencyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.packageBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPackageBody([NotNull] CrimsonParser.PackageBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.packageBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPackageBody([NotNull] CrimsonParser.PackageBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.topLevelStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTopLevelStatement([NotNull] CrimsonParser.TopLevelStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.topLevelStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTopLevelStatement([NotNull] CrimsonParser.TopLevelStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.globalVariableDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGlobalVariableDeclaration([NotNull] CrimsonParser.GlobalVariableDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.globalVariableDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGlobalVariableDeclaration([NotNull] CrimsonParser.GlobalVariableDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.functionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionDeclaration([NotNull] CrimsonParser.FunctionDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.functionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionDeclaration([NotNull] CrimsonParser.FunctionDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.functionBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionBody([NotNull] CrimsonParser.FunctionBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.functionBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionBody([NotNull] CrimsonParser.FunctionBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.functionOnlyStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionOnlyStatement([NotNull] CrimsonParser.FunctionOnlyStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.functionOnlyStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionOnlyStatement([NotNull] CrimsonParser.FunctionOnlyStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.internalVariableDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInternalVariableDeclaration([NotNull] CrimsonParser.InternalVariableDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.internalVariableDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInternalVariableDeclaration([NotNull] CrimsonParser.InternalVariableDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.assignVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignVariable([NotNull] CrimsonParser.AssignVariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.assignVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignVariable([NotNull] CrimsonParser.AssignVariableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.ifBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfBlock([NotNull] CrimsonParser.IfBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.ifBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfBlock([NotNull] CrimsonParser.IfBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCondition([NotNull] CrimsonParser.ConditionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCondition([NotNull] CrimsonParser.ConditionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.elifBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElifBlock([NotNull] CrimsonParser.ElifBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.elifBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElifBlock([NotNull] CrimsonParser.ElifBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.elseBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElseBlock([NotNull] CrimsonParser.ElseBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.elseBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElseBlock([NotNull] CrimsonParser.ElseBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionCall([NotNull] CrimsonParser.FunctionCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionCall([NotNull] CrimsonParser.FunctionCallContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.inputParameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInputParameters([NotNull] CrimsonParser.InputParametersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.inputParameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInputParameters([NotNull] CrimsonParser.InputParametersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.allocateMemory"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAllocateMemory([NotNull] CrimsonParser.AllocateMemoryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.allocateMemory"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAllocateMemory([NotNull] CrimsonParser.AllocateMemoryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.functionReturn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionReturn([NotNull] CrimsonParser.FunctionReturnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.functionReturn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionReturn([NotNull] CrimsonParser.FunctionReturnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.resolvableValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResolvableValue([NotNull] CrimsonParser.ResolvableValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.resolvableValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResolvableValue([NotNull] CrimsonParser.ResolvableValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.parameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameterList([NotNull] CrimsonParser.ParameterListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.parameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameterList([NotNull] CrimsonParser.ParameterListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameter([NotNull] CrimsonParser.ParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameter([NotNull] CrimsonParser.ParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.structureDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStructureDeclaration([NotNull] CrimsonParser.StructureDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.structureDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStructureDeclaration([NotNull] CrimsonParser.StructureDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.structureBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStructureBody([NotNull] CrimsonParser.StructureBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.structureBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStructureBody([NotNull] CrimsonParser.StructureBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType([NotNull] CrimsonParser.TypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType([NotNull] CrimsonParser.TypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CrimsonParser.array"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArray([NotNull] CrimsonParser.ArrayContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CrimsonParser.array"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArray([NotNull] CrimsonParser.ArrayContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Crimson.AntlrBuild
