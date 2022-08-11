/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.tools.javac.tree;

[JniSignatureAttribute("Lcom/sun/tools/javac/tree/TreeCopier;", "public")]
public partial class TreeCopier
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.source.tree.TreeVisitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TreeCopier()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/TreeCopier;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "M", "Lcom/sun/tools/javac/tree/TreeMaker;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/TreeMaker;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy", "(Lcom/sun/tools/javac/util/List;Ljava/lang/Object;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy", "(Lcom/sun/tools/javac/tree/JCTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy", "(Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation_0", "(Lcom/sun/source/tree/AnnotationTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation_1", "(Lcom/sun/source/tree/AnnotationTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethod_0", "(Lcom/sun/source/tree/MethodTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethod_1", "(Lcom/sun/source/tree/MethodTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModule_0", "(Lcom/sun/source/tree/ModuleTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModule_1", "(Lcom/sun/source/tree/ModuleTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPackage_0", "(Lcom/sun/source/tree/PackageTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPackage_1", "(Lcom/sun/source/tree/PackageTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForLoop_0", "(Lcom/sun/source/tree/ForLoopTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForLoop_1", "(Lcom/sun/source/tree/ForLoopTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitOther_0", "(Lcom/sun/source/tree/Tree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitOther_1", "(Lcom/sun/source/tree/Tree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitImport_0", "(Lcom/sun/source/tree/ImportTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitImport_1", "(Lcom/sun/source/tree/ImportTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBlock_0", "(Lcom/sun/source/tree/BlockTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBlock_1", "(Lcom/sun/source/tree/BlockTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWhileLoop_0", "(Lcom/sun/source/tree/WhileLoopTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWhileLoop_1", "(Lcom/sun/source/tree/WhileLoopTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSwitch_0", "(Lcom/sun/source/tree/SwitchTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSwitch_1", "(Lcom/sun/source/tree/SwitchTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCase_0", "(Lcom/sun/source/tree/CaseTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCase_1", "(Lcom/sun/source/tree/CaseTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSwitchExpression_0", "(Lcom/sun/source/tree/SwitchExpressionTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSwitchExpression_1", "(Lcom/sun/source/tree/SwitchExpressionTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSynchronized_0", "(Lcom/sun/source/tree/SynchronizedTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSynchronized_1", "(Lcom/sun/source/tree/SynchronizedTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTry_0", "(Lcom/sun/source/tree/TryTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTry_1", "(Lcom/sun/source/tree/TryTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCatch_0", "(Lcom/sun/source/tree/CatchTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCatch_1", "(Lcom/sun/source/tree/CatchTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIf_0", "(Lcom/sun/source/tree/IfTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIf_1", "(Lcom/sun/source/tree/IfTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBreak_0", "(Lcom/sun/source/tree/BreakTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBreak_1", "(Lcom/sun/source/tree/BreakTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitYield_0", "(Lcom/sun/source/tree/YieldTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitYield_1", "(Lcom/sun/source/tree/YieldTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitContinue_0", "(Lcom/sun/source/tree/ContinueTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitContinue_1", "(Lcom/sun/source/tree/ContinueTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReturn_0", "(Lcom/sun/source/tree/ReturnTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReturn_1", "(Lcom/sun/source/tree/ReturnTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitThrow_0", "(Lcom/sun/source/tree/ThrowTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitThrow_1", "(Lcom/sun/source/tree/ThrowTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAssert_0", "(Lcom/sun/source/tree/AssertTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAssert_1", "(Lcom/sun/source/tree/AssertTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNewClass_0", "(Lcom/sun/source/tree/NewClassTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNewClass_1", "(Lcom/sun/source/tree/NewClassTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNewArray_0", "(Lcom/sun/source/tree/NewArrayTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNewArray_1", "(Lcom/sun/source/tree/NewArrayTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUnary_0", "(Lcom/sun/source/tree/UnaryTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUnary_1", "(Lcom/sun/source/tree/UnaryTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBinary_0", "(Lcom/sun/source/tree/BinaryTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBinary_1", "(Lcom/sun/source/tree/BinaryTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeCast_0", "(Lcom/sun/source/tree/TypeCastTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeCast_1", "(Lcom/sun/source/tree/TypeCastTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDefaultCaseLabel_0", "(Lcom/sun/source/tree/DefaultCaseLabelTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDefaultCaseLabel_1", "(Lcom/sun/source/tree/DefaultCaseLabelTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParenthesizedPattern_0", "(Lcom/sun/source/tree/ParenthesizedPatternTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParenthesizedPattern_1", "(Lcom/sun/source/tree/ParenthesizedPatternTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLiteral_0", "(Lcom/sun/source/tree/LiteralTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLiteral_1", "(Lcom/sun/source/tree/LiteralTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeParameter_0", "(Lcom/sun/source/tree/TypeParameterTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeParameter_1", "(Lcom/sun/source/tree/TypeParameterTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModifiers_0", "(Lcom/sun/source/tree/ModifiersTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModifiers_1", "(Lcom/sun/source/tree/ModifiersTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotatedType_0", "(Lcom/sun/source/tree/AnnotatedTypeTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotatedType_1", "(Lcom/sun/source/tree/AnnotatedTypeTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitErroneous_0", "(Lcom/sun/source/tree/ErroneousTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitErroneous_1", "(Lcom/sun/source/tree/ErroneousTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitExports_0", "(Lcom/sun/source/tree/ExportsTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitExports_1", "(Lcom/sun/source/tree/ExportsTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree$JCExports;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitOpens_0", "(Lcom/sun/source/tree/OpensTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree$JCOpens;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitOpens_1", "(Lcom/sun/source/tree/OpensTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitProvides_0", "(Lcom/sun/source/tree/ProvidesTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitProvides_1", "(Lcom/sun/source/tree/ProvidesTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree$JCProvides;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRequires_0", "(Lcom/sun/source/tree/RequiresTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree$JCRequires;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRequires_1", "(Lcom/sun/source/tree/RequiresTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUses_0", "(Lcom/sun/source/tree/UsesTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree$JCUses;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUses_1", "(Lcom/sun/source/tree/UsesTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClass_0", "(Lcom/sun/source/tree/ClassTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClass_1", "(Lcom/sun/source/tree/ClassTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVariable_0", "(Lcom/sun/source/tree/VariableTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVariable_1", "(Lcom/sun/source/tree/VariableTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCompilationUnit_0", "(Lcom/sun/source/tree/CompilationUnitTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCompilationUnit_1", "(Lcom/sun/source/tree/CompilationUnitTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEmptyStatement_0", "(Lcom/sun/source/tree/EmptyStatementTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEmptyStatement_1", "(Lcom/sun/source/tree/EmptyStatementTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDoWhileLoop_0", "(Lcom/sun/source/tree/DoWhileLoopTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDoWhileLoop_1", "(Lcom/sun/source/tree/DoWhileLoopTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnhancedForLoop_0", "(Lcom/sun/source/tree/EnhancedForLoopTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnhancedForLoop_1", "(Lcom/sun/source/tree/EnhancedForLoopTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLabeledStatement_0", "(Lcom/sun/source/tree/LabeledStatementTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLabeledStatement_1", "(Lcom/sun/source/tree/LabeledStatementTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConditionalExpression_0", "(Lcom/sun/source/tree/ConditionalExpressionTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConditionalExpression_1", "(Lcom/sun/source/tree/ConditionalExpressionTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitExpressionStatement_0", "(Lcom/sun/source/tree/ExpressionStatementTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitExpressionStatement_1", "(Lcom/sun/source/tree/ExpressionStatementTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodInvocation_0", "(Lcom/sun/source/tree/MethodInvocationTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodInvocation_1", "(Lcom/sun/source/tree/MethodInvocationTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLambdaExpression_0", "(Lcom/sun/source/tree/LambdaExpressionTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLambdaExpression_1", "(Lcom/sun/source/tree/LambdaExpressionTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParenthesized_0", "(Lcom/sun/source/tree/ParenthesizedTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParenthesized_1", "(Lcom/sun/source/tree/ParenthesizedTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCompoundAssignment_0", "(Lcom/sun/source/tree/CompoundAssignmentTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCompoundAssignment_1", "(Lcom/sun/source/tree/CompoundAssignmentTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInstanceOf_0", "(Lcom/sun/source/tree/InstanceOfTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInstanceOf_1", "(Lcom/sun/source/tree/InstanceOfTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitGuardedPattern_0", "(Lcom/sun/source/tree/GuardedPatternTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitGuardedPattern_1", "(Lcom/sun/source/tree/GuardedPatternTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayAccess_0", "(Lcom/sun/source/tree/ArrayAccessTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayAccess_1", "(Lcom/sun/source/tree/ArrayAccessTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMemberSelect_0", "(Lcom/sun/source/tree/MemberSelectTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMemberSelect_1", "(Lcom/sun/source/tree/MemberSelectTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMemberReference_0", "(Lcom/sun/source/tree/MemberReferenceTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMemberReference_1", "(Lcom/sun/source/tree/MemberReferenceTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIdentifier_0", "(Lcom/sun/source/tree/IdentifierTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIdentifier_1", "(Lcom/sun/source/tree/IdentifierTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPrimitiveType_0", "(Lcom/sun/source/tree/PrimitiveTypeTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPrimitiveType_1", "(Lcom/sun/source/tree/PrimitiveTypeTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayType_0", "(Lcom/sun/source/tree/ArrayTypeTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayType_1", "(Lcom/sun/source/tree/ArrayTypeTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParameterizedType_0", "(Lcom/sun/source/tree/ParameterizedTypeTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParameterizedType_1", "(Lcom/sun/source/tree/ParameterizedTypeTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUnionType_0", "(Lcom/sun/source/tree/UnionTypeTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUnionType_1", "(Lcom/sun/source/tree/UnionTypeTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIntersectionType_0", "(Lcom/sun/source/tree/IntersectionTypeTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIntersectionType_1", "(Lcom/sun/source/tree/IntersectionTypeTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAssignment_0", "(Lcom/sun/source/tree/AssignmentTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAssignment_1", "(Lcom/sun/source/tree/AssignmentTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBindingPattern_0", "(Lcom/sun/source/tree/BindingPatternTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBindingPattern_1", "(Lcom/sun/source/tree/BindingPatternTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcard_0", "(Lcom/sun/source/tree/WildcardTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcard_1", "(Lcom/sun/source/tree/WildcardTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/TreeMaker;", "private")]
	public Dova.JDK.com.sun.tools.javac.tree.TreeMaker M_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.TreeMaker>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TreeCopier(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/TreeMaker;)V", "public")]
	public TreeCopier(Dova.JDK.com.sun.tools.javac.tree.TreeMaker arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/TreeCopier;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Ljava/lang/Object;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List copy(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.java.lang.Object copy(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List copy(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.java.lang.Object copy(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/AnnotationTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitAnnotation_0(Dova.JDK.com.sun.source.tree.AnnotationTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/AnnotationTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitAnnotation_1(Dova.JDK.com.sun.source.tree.AnnotationTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/MethodTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitMethod_0(Dova.JDK.com.sun.source.tree.MethodTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/MethodTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitMethod_1(Dova.JDK.com.sun.source.tree.MethodTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ModuleTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitModule_0(Dova.JDK.com.sun.source.tree.ModuleTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ModuleTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitModule_1(Dova.JDK.com.sun.source.tree.ModuleTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/PackageTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitPackage_0(Dova.JDK.com.sun.source.tree.PackageTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/PackageTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitPackage_1(Dova.JDK.com.sun.source.tree.PackageTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ForLoopTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitForLoop_0(Dova.JDK.com.sun.source.tree.ForLoopTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ForLoopTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitForLoop_1(Dova.JDK.com.sun.source.tree.ForLoopTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/Tree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitOther_0(Dova.JDK.com.sun.source.tree.Tree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/Tree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitOther_1(Dova.JDK.com.sun.source.tree.Tree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ImportTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitImport_0(Dova.JDK.com.sun.source.tree.ImportTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ImportTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitImport_1(Dova.JDK.com.sun.source.tree.ImportTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/BlockTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitBlock_0(Dova.JDK.com.sun.source.tree.BlockTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/BlockTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitBlock_1(Dova.JDK.com.sun.source.tree.BlockTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/WhileLoopTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitWhileLoop_0(Dova.JDK.com.sun.source.tree.WhileLoopTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/WhileLoopTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitWhileLoop_1(Dova.JDK.com.sun.source.tree.WhileLoopTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/SwitchTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitSwitch_0(Dova.JDK.com.sun.source.tree.SwitchTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/SwitchTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitSwitch_1(Dova.JDK.com.sun.source.tree.SwitchTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/CaseTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitCase_0(Dova.JDK.com.sun.source.tree.CaseTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/CaseTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitCase_1(Dova.JDK.com.sun.source.tree.CaseTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/SwitchExpressionTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitSwitchExpression_0(Dova.JDK.com.sun.source.tree.SwitchExpressionTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/SwitchExpressionTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitSwitchExpression_1(Dova.JDK.com.sun.source.tree.SwitchExpressionTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/SynchronizedTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitSynchronized_0(Dova.JDK.com.sun.source.tree.SynchronizedTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/SynchronizedTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitSynchronized_1(Dova.JDK.com.sun.source.tree.SynchronizedTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/TryTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitTry_0(Dova.JDK.com.sun.source.tree.TryTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/TryTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitTry_1(Dova.JDK.com.sun.source.tree.TryTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/CatchTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitCatch_0(Dova.JDK.com.sun.source.tree.CatchTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/CatchTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitCatch_1(Dova.JDK.com.sun.source.tree.CatchTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/IfTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitIf_0(Dova.JDK.com.sun.source.tree.IfTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/IfTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitIf_1(Dova.JDK.com.sun.source.tree.IfTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/BreakTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitBreak_0(Dova.JDK.com.sun.source.tree.BreakTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/BreakTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitBreak_1(Dova.JDK.com.sun.source.tree.BreakTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/YieldTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitYield_0(Dova.JDK.com.sun.source.tree.YieldTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/YieldTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitYield_1(Dova.JDK.com.sun.source.tree.YieldTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ContinueTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitContinue_0(Dova.JDK.com.sun.source.tree.ContinueTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ContinueTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitContinue_1(Dova.JDK.com.sun.source.tree.ContinueTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ReturnTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitReturn_0(Dova.JDK.com.sun.source.tree.ReturnTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ReturnTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitReturn_1(Dova.JDK.com.sun.source.tree.ReturnTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ThrowTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitThrow_0(Dova.JDK.com.sun.source.tree.ThrowTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ThrowTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitThrow_1(Dova.JDK.com.sun.source.tree.ThrowTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/AssertTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitAssert_0(Dova.JDK.com.sun.source.tree.AssertTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/AssertTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitAssert_1(Dova.JDK.com.sun.source.tree.AssertTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/NewClassTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitNewClass_0(Dova.JDK.com.sun.source.tree.NewClassTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/NewClassTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitNewClass_1(Dova.JDK.com.sun.source.tree.NewClassTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/NewArrayTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitNewArray_0(Dova.JDK.com.sun.source.tree.NewArrayTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/NewArrayTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitNewArray_1(Dova.JDK.com.sun.source.tree.NewArrayTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/UnaryTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitUnary_0(Dova.JDK.com.sun.source.tree.UnaryTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/UnaryTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitUnary_1(Dova.JDK.com.sun.source.tree.UnaryTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/BinaryTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitBinary_0(Dova.JDK.com.sun.source.tree.BinaryTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/BinaryTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitBinary_1(Dova.JDK.com.sun.source.tree.BinaryTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/TypeCastTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitTypeCast_0(Dova.JDK.com.sun.source.tree.TypeCastTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/TypeCastTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitTypeCast_1(Dova.JDK.com.sun.source.tree.TypeCastTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/DefaultCaseLabelTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitDefaultCaseLabel_0(Dova.JDK.com.sun.source.tree.DefaultCaseLabelTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/DefaultCaseLabelTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitDefaultCaseLabel_1(Dova.JDK.com.sun.source.tree.DefaultCaseLabelTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ParenthesizedPatternTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitParenthesizedPattern_0(Dova.JDK.com.sun.source.tree.ParenthesizedPatternTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ParenthesizedPatternTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitParenthesizedPattern_1(Dova.JDK.com.sun.source.tree.ParenthesizedPatternTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/LiteralTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitLiteral_0(Dova.JDK.com.sun.source.tree.LiteralTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/LiteralTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitLiteral_1(Dova.JDK.com.sun.source.tree.LiteralTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/TypeParameterTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitTypeParameter_0(Dova.JDK.com.sun.source.tree.TypeParameterTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/TypeParameterTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitTypeParameter_1(Dova.JDK.com.sun.source.tree.TypeParameterTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ModifiersTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitModifiers_0(Dova.JDK.com.sun.source.tree.ModifiersTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ModifiersTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitModifiers_1(Dova.JDK.com.sun.source.tree.ModifiersTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/AnnotatedTypeTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitAnnotatedType_0(Dova.JDK.com.sun.source.tree.AnnotatedTypeTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/AnnotatedTypeTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitAnnotatedType_1(Dova.JDK.com.sun.source.tree.AnnotatedTypeTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ErroneousTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitErroneous_0(Dova.JDK.com.sun.source.tree.ErroneousTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ErroneousTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitErroneous_1(Dova.JDK.com.sun.source.tree.ErroneousTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[71], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ExportsTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitExports_0(Dova.JDK.com.sun.source.tree.ExportsTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[72], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ExportsTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree$JCExports;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExports visitExports_1(Dova.JDK.com.sun.source.tree.ExportsTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExports>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/OpensTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree$JCOpens;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOpens visitOpens_0(Dova.JDK.com.sun.source.tree.OpensTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[74], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOpens>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/OpensTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitOpens_1(Dova.JDK.com.sun.source.tree.OpensTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ProvidesTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitProvides_0(Dova.JDK.com.sun.source.tree.ProvidesTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ProvidesTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree$JCProvides;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCProvides visitProvides_1(Dova.JDK.com.sun.source.tree.ProvidesTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCProvides>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/RequiresTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree$JCRequires;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCRequires visitRequires_0(Dova.JDK.com.sun.source.tree.RequiresTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCRequires>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/RequiresTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitRequires_1(Dova.JDK.com.sun.source.tree.RequiresTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[79], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/UsesTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree$JCUses;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCUses visitUses_0(Dova.JDK.com.sun.source.tree.UsesTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[80], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCUses>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/UsesTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitUses_1(Dova.JDK.com.sun.source.tree.UsesTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[81], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ClassTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitClass_0(Dova.JDK.com.sun.source.tree.ClassTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[82], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ClassTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitClass_1(Dova.JDK.com.sun.source.tree.ClassTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[83], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/VariableTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitVariable_0(Dova.JDK.com.sun.source.tree.VariableTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[84], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/VariableTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitVariable_1(Dova.JDK.com.sun.source.tree.VariableTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[85], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/CompilationUnitTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitCompilationUnit_0(Dova.JDK.com.sun.source.tree.CompilationUnitTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[86], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/CompilationUnitTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitCompilationUnit_1(Dova.JDK.com.sun.source.tree.CompilationUnitTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[87], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/EmptyStatementTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitEmptyStatement_0(Dova.JDK.com.sun.source.tree.EmptyStatementTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[88], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/EmptyStatementTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitEmptyStatement_1(Dova.JDK.com.sun.source.tree.EmptyStatementTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[89], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/DoWhileLoopTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitDoWhileLoop_0(Dova.JDK.com.sun.source.tree.DoWhileLoopTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[90], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/DoWhileLoopTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitDoWhileLoop_1(Dova.JDK.com.sun.source.tree.DoWhileLoopTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[91], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/EnhancedForLoopTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitEnhancedForLoop_0(Dova.JDK.com.sun.source.tree.EnhancedForLoopTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[92], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/EnhancedForLoopTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitEnhancedForLoop_1(Dova.JDK.com.sun.source.tree.EnhancedForLoopTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[93], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/LabeledStatementTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitLabeledStatement_0(Dova.JDK.com.sun.source.tree.LabeledStatementTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[94], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/LabeledStatementTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitLabeledStatement_1(Dova.JDK.com.sun.source.tree.LabeledStatementTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[95], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ConditionalExpressionTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitConditionalExpression_0(Dova.JDK.com.sun.source.tree.ConditionalExpressionTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[96], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ConditionalExpressionTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitConditionalExpression_1(Dova.JDK.com.sun.source.tree.ConditionalExpressionTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[97], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ExpressionStatementTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitExpressionStatement_0(Dova.JDK.com.sun.source.tree.ExpressionStatementTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[98], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ExpressionStatementTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitExpressionStatement_1(Dova.JDK.com.sun.source.tree.ExpressionStatementTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[99], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/MethodInvocationTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitMethodInvocation_0(Dova.JDK.com.sun.source.tree.MethodInvocationTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[100], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/MethodInvocationTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitMethodInvocation_1(Dova.JDK.com.sun.source.tree.MethodInvocationTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[101], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/LambdaExpressionTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitLambdaExpression_0(Dova.JDK.com.sun.source.tree.LambdaExpressionTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[102], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/LambdaExpressionTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitLambdaExpression_1(Dova.JDK.com.sun.source.tree.LambdaExpressionTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[103], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ParenthesizedTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitParenthesized_0(Dova.JDK.com.sun.source.tree.ParenthesizedTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[104], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ParenthesizedTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitParenthesized_1(Dova.JDK.com.sun.source.tree.ParenthesizedTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[105], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/CompoundAssignmentTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitCompoundAssignment_0(Dova.JDK.com.sun.source.tree.CompoundAssignmentTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[106], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/CompoundAssignmentTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitCompoundAssignment_1(Dova.JDK.com.sun.source.tree.CompoundAssignmentTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[107], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/InstanceOfTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitInstanceOf_0(Dova.JDK.com.sun.source.tree.InstanceOfTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[108], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/InstanceOfTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitInstanceOf_1(Dova.JDK.com.sun.source.tree.InstanceOfTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[109], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/GuardedPatternTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitGuardedPattern_0(Dova.JDK.com.sun.source.tree.GuardedPatternTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[110], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/GuardedPatternTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitGuardedPattern_1(Dova.JDK.com.sun.source.tree.GuardedPatternTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[111], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ArrayAccessTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitArrayAccess_0(Dova.JDK.com.sun.source.tree.ArrayAccessTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[112], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ArrayAccessTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitArrayAccess_1(Dova.JDK.com.sun.source.tree.ArrayAccessTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[113], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/MemberSelectTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitMemberSelect_0(Dova.JDK.com.sun.source.tree.MemberSelectTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[114], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/MemberSelectTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitMemberSelect_1(Dova.JDK.com.sun.source.tree.MemberSelectTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[115], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/MemberReferenceTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitMemberReference_0(Dova.JDK.com.sun.source.tree.MemberReferenceTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[116], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/MemberReferenceTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitMemberReference_1(Dova.JDK.com.sun.source.tree.MemberReferenceTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[117], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/IdentifierTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitIdentifier_0(Dova.JDK.com.sun.source.tree.IdentifierTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[118], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/IdentifierTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitIdentifier_1(Dova.JDK.com.sun.source.tree.IdentifierTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[119], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/PrimitiveTypeTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitPrimitiveType_0(Dova.JDK.com.sun.source.tree.PrimitiveTypeTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[120], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/PrimitiveTypeTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitPrimitiveType_1(Dova.JDK.com.sun.source.tree.PrimitiveTypeTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[121], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ArrayTypeTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitArrayType_0(Dova.JDK.com.sun.source.tree.ArrayTypeTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[122], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ArrayTypeTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitArrayType_1(Dova.JDK.com.sun.source.tree.ArrayTypeTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[123], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ParameterizedTypeTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitParameterizedType_0(Dova.JDK.com.sun.source.tree.ParameterizedTypeTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[124], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ParameterizedTypeTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitParameterizedType_1(Dova.JDK.com.sun.source.tree.ParameterizedTypeTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[125], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/UnionTypeTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitUnionType_0(Dova.JDK.com.sun.source.tree.UnionTypeTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[126], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/UnionTypeTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitUnionType_1(Dova.JDK.com.sun.source.tree.UnionTypeTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[127], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/IntersectionTypeTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitIntersectionType_0(Dova.JDK.com.sun.source.tree.IntersectionTypeTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[128], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/IntersectionTypeTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitIntersectionType_1(Dova.JDK.com.sun.source.tree.IntersectionTypeTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[129], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/AssignmentTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitAssignment_0(Dova.JDK.com.sun.source.tree.AssignmentTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[130], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/AssignmentTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitAssignment_1(Dova.JDK.com.sun.source.tree.AssignmentTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[131], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/BindingPatternTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitBindingPattern_0(Dova.JDK.com.sun.source.tree.BindingPatternTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[132], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/BindingPatternTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitBindingPattern_1(Dova.JDK.com.sun.source.tree.BindingPatternTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[133], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/WildcardTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitWildcard_0(Dova.JDK.com.sun.source.tree.WildcardTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[134], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/WildcardTree;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree visitWildcard_1(Dova.JDK.com.sun.source.tree.WildcardTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[135], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}
}
