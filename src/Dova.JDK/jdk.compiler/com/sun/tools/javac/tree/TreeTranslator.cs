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

[JniSignatureAttribute("Lcom/sun/tools/javac/tree/TreeTranslator;", "public")]
public partial class TreeTranslator
	: Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TreeTranslator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/TreeTranslator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "result", "Lcom/sun/tools/javac/tree/JCTree;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Lcom/sun/tools/javac/tree/JCTree$JCAnnotation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateCatchers", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateTypeParams", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateVarDefs", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateCases", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateAnnotations", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCForLoop;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassDef", "(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodDef", "(Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVarDef", "(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTree", "(Lcom/sun/tools/javac/tree/JCTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTopLevel", "(Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPackageDef", "(Lcom/sun/tools/javac/tree/JCTree$JCPackageDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitImport", "(Lcom/sun/tools/javac/tree/JCTree$JCImport;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSkip", "(Lcom/sun/tools/javac/tree/JCTree$JCSkip;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBlock", "(Lcom/sun/tools/javac/tree/JCTree$JCBlock;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDoLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCDoWhileLoop;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWhileLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCWhileLoop;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForeachLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCEnhancedForLoop;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLabelled", "(Lcom/sun/tools/javac/tree/JCTree$JCLabeledStatement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSwitch", "(Lcom/sun/tools/javac/tree/JCTree$JCSwitch;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCase", "(Lcom/sun/tools/javac/tree/JCTree$JCCase;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSwitchExpression", "(Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSynchronized", "(Lcom/sun/tools/javac/tree/JCTree$JCSynchronized;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTry", "(Lcom/sun/tools/javac/tree/JCTree$JCTry;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCatch", "(Lcom/sun/tools/javac/tree/JCTree$JCCatch;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConditional", "(Lcom/sun/tools/javac/tree/JCTree$JCConditional;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIf", "(Lcom/sun/tools/javac/tree/JCTree$JCIf;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitExec", "(Lcom/sun/tools/javac/tree/JCTree$JCExpressionStatement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBreak", "(Lcom/sun/tools/javac/tree/JCTree$JCBreak;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitYield", "(Lcom/sun/tools/javac/tree/JCTree$JCYield;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitContinue", "(Lcom/sun/tools/javac/tree/JCTree$JCContinue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReturn", "(Lcom/sun/tools/javac/tree/JCTree$JCReturn;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitThrow", "(Lcom/sun/tools/javac/tree/JCTree$JCThrow;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAssert", "(Lcom/sun/tools/javac/tree/JCTree$JCAssert;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitApply", "(Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNewClass", "(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNewArray", "(Lcom/sun/tools/javac/tree/JCTree$JCNewArray;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLambda", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParens", "(Lcom/sun/tools/javac/tree/JCTree$JCParens;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAssignop", "(Lcom/sun/tools/javac/tree/JCTree$JCAssignOp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUnary", "(Lcom/sun/tools/javac/tree/JCTree$JCUnary;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBinary", "(Lcom/sun/tools/javac/tree/JCTree$JCBinary;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeCast", "(Lcom/sun/tools/javac/tree/JCTree$JCTypeCast;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeTest", "(Lcom/sun/tools/javac/tree/JCTree$JCInstanceOf;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDefaultCaseLabel", "(Lcom/sun/tools/javac/tree/JCTree$JCDefaultCaseLabel;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParenthesizedPattern", "(Lcom/sun/tools/javac/tree/JCTree$JCParenthesizedPattern;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitGuardPattern", "(Lcom/sun/tools/javac/tree/JCTree$JCGuardPattern;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIndexed", "(Lcom/sun/tools/javac/tree/JCTree$JCArrayAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSelect", "(Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReference", "(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIdent", "(Lcom/sun/tools/javac/tree/JCTree$JCIdent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLiteral", "(Lcom/sun/tools/javac/tree/JCTree$JCLiteral;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeIdent", "(Lcom/sun/tools/javac/tree/JCTree$JCPrimitiveTypeTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeArray", "(Lcom/sun/tools/javac/tree/JCTree$JCArrayTypeTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeApply", "(Lcom/sun/tools/javac/tree/JCTree$JCTypeApply;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeUnion", "(Lcom/sun/tools/javac/tree/JCTree$JCTypeUnion;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeIntersection", "(Lcom/sun/tools/javac/tree/JCTree$JCTypeIntersection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeParameter", "(Lcom/sun/tools/javac/tree/JCTree$JCTypeParameter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeBoundKind", "(Lcom/sun/tools/javac/tree/JCTree$TypeBoundKind;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModifiers", "(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotatedType", "(Lcom/sun/tools/javac/tree/JCTree$JCAnnotatedType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitErroneous", "(Lcom/sun/tools/javac/tree/JCTree$JCErroneous;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLetExpr", "(Lcom/sun/tools/javac/tree/JCTree$LetExpr;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBindingPattern", "(Lcom/sun/tools/javac/tree/JCTree$JCBindingPattern;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAssign", "(Lcom/sun/tools/javac/tree/JCTree$JCAssign;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcard", "(Lcom/sun/tools/javac/tree/JCTree$JCWildcard;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "(Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/tree/JCTree;"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree;", "protected")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree result_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TreeTranslator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public TreeTranslator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/TreeTranslator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAnnotation;)V", "public")]
	public void visitAnnotation(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAnnotation arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List translateCatchers(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List translateTypeParams(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List translateVarDefs(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List translateCases(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List translateAnnotations(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCForLoop;)V", "public")]
	public void visitForLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCForLoop arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V", "public")]
	public void visitClassDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)V", "public")]
	public void visitMethodDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V", "public")]
	public void visitVarDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)V", "public")]
	public void visitTree(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;)V", "public")]
	public void visitTopLevel(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCompilationUnit arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCPackageDecl;)V", "public")]
	public void visitPackageDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPackageDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCImport;)V", "public")]
	public void visitImport(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCImport arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCSkip;)V", "public")]
	public void visitSkip(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSkip arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBlock;)V", "public")]
	public void visitBlock(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCDoWhileLoop;)V", "public")]
	public void visitDoLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCDoWhileLoop arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCWhileLoop;)V", "public")]
	public void visitWhileLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCWhileLoop arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCEnhancedForLoop;)V", "public")]
	public void visitForeachLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCEnhancedForLoop arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLabeledStatement;)V", "public")]
	public void visitLabelled(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLabeledStatement arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCSwitch;)V", "public")]
	public void visitSwitch(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSwitch arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCCase;)V", "public")]
	public void visitCase(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCase arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;)V", "public")]
	public void visitSwitchExpression(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSwitchExpression arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCSynchronized;)V", "public")]
	public void visitSynchronized(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSynchronized arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTry;)V", "public")]
	public void visitTry(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTry arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCCatch;)V", "public")]
	public void visitCatch(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCatch arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCConditional;)V", "public")]
	public void visitConditional(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCConditional arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCIf;)V", "public")]
	public void visitIf(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCIf arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpressionStatement;)V", "public")]
	public void visitExec(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpressionStatement arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBreak;)V", "public")]
	public void visitBreak(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBreak arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCYield;)V", "public")]
	public void visitYield(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCYield arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCContinue;)V", "public")]
	public void visitContinue(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCContinue arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCReturn;)V", "public")]
	public void visitReturn(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCReturn arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCThrow;)V", "public")]
	public void visitThrow(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCThrow arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAssert;)V", "public")]
	public void visitAssert(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAssert arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;)V", "public")]
	public void visitApply(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodInvocation arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V", "public")]
	public void visitNewClass(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCNewArray;)V", "public")]
	public void visitNewArray(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewArray arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V", "public")]
	public void visitLambda(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCParens;)V", "public")]
	public void visitParens(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCParens arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAssignOp;)V", "public")]
	public void visitAssignop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAssignOp arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCUnary;)V", "public")]
	public void visitUnary(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCUnary arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBinary;)V", "public")]
	public void visitBinary(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBinary arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTypeCast;)V", "public")]
	public void visitTypeCast(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeCast arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCInstanceOf;)V", "public")]
	public void visitTypeTest(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCInstanceOf arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCDefaultCaseLabel;)V", "public")]
	public void visitDefaultCaseLabel(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCDefaultCaseLabel arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCParenthesizedPattern;)V", "public")]
	public void visitParenthesizedPattern(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCParenthesizedPattern arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCGuardPattern;)V", "public")]
	public void visitGuardPattern(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCGuardPattern arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCArrayAccess;)V", "public")]
	public void visitIndexed(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCArrayAccess arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;)V", "public")]
	public void visitSelect(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCFieldAccess arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;)V", "public")]
	public void visitReference(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCIdent;)V", "public")]
	public void visitIdent(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCIdent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLiteral;)V", "public")]
	public void visitLiteral(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLiteral arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCPrimitiveTypeTree;)V", "public")]
	public void visitTypeIdent(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPrimitiveTypeTree arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCArrayTypeTree;)V", "public")]
	public void visitTypeArray(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCArrayTypeTree arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTypeApply;)V", "public")]
	public void visitTypeApply(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeApply arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTypeUnion;)V", "public")]
	public void visitTypeUnion(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeUnion arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTypeIntersection;)V", "public")]
	public void visitTypeIntersection(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeIntersection arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTypeParameter;)V", "public")]
	public void visitTypeParameter(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeParameter arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$TypeBoundKind;)V", "public")]
	public void visitTypeBoundKind(Dova.JDK.com.sun.tools.javac.tree.JCTree.TypeBoundKind arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;)V", "public")]
	public void visitModifiers(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAnnotatedType;)V", "public")]
	public void visitAnnotatedType(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAnnotatedType arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCErroneous;)V", "public")]
	public void visitErroneous(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCErroneous arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$LetExpr;)V", "public")]
	public void visitLetExpr(Dova.JDK.com.sun.tools.javac.tree.JCTree.LetExpr arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBindingPattern;)V", "public")]
	public void visitBindingPattern(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBindingPattern arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAssign;)V", "public")]
	public void visitAssign(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAssign arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCWildcard;)V", "public")]
	public void visitWildcard(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCWildcard arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[66], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List translate(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.java.lang.Object translate(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}
