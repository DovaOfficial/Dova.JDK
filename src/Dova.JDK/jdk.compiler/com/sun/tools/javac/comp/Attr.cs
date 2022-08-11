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

namespace Dova.JDK.com.sun.tools.javac.comp;

[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr;", "public")]
public partial class Attr
	: Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Attr()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Attr;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "attrKey", "Lcom/sun/tools/javac/util/Context$Key;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "names", "Lcom/sun/tools/javac/util/Names;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "log", "Lcom/sun/tools/javac/util/Log;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "syms", "Lcom/sun/tools/javac/code/Symtab;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rs", "Lcom/sun/tools/javac/comp/Resolve;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "operators", "Lcom/sun/tools/javac/comp/Operators;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "infer", "Lcom/sun/tools/javac/comp/Infer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "analyzer", "Lcom/sun/tools/javac/comp/Analyzer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "deferredAttr", "Lcom/sun/tools/javac/comp/DeferredAttr;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chk", "Lcom/sun/tools/javac/comp/Check;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flow", "Lcom/sun/tools/javac/comp/Flow;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "memberEnter", "Lcom/sun/tools/javac/comp/MemberEnter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeEnter", "Lcom/sun/tools/javac/comp/TypeEnter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "make", "Lcom/sun/tools/javac/tree/TreeMaker;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cfolder", "Lcom/sun/tools/javac/comp/ConstFold;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enter", "Lcom/sun/tools/javac/comp/Enter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Lcom/sun/tools/javac/jvm/Target;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "types", "Lcom/sun/tools/javac/code/Types;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "preview", "Lcom/sun/tools/javac/code/Preview;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "diags", "Lcom/sun/tools/javac/util/JCDiagnostic$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeAnnotations", "Lcom/sun/tools/javac/code/TypeAnnotations;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "deferredLintHandler", "Lcom/sun/tools/javac/code/DeferredLintHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeEnvs", "Lcom/sun/tools/javac/comp/TypeEnvs;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dependencies", "Lcom/sun/tools/javac/util/Dependencies;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotate", "Lcom/sun/tools/javac/comp/Annotate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argumentAttr", "Lcom/sun/tools/javac/comp/ArgumentAttr;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matchBindingsComputer", "Lcom/sun/tools/javac/comp/MatchBindingsComputer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attrRecover", "Lcom/sun/tools/javac/comp/AttrRecover;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allowPoly", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allowTypeAnnos", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allowLambda", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allowDefaultMethods", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allowStaticInterfaceMethods", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allowReifiableTypesInInstanceof", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allowRecords", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allowPatternSwitch", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "useBeforeDeclarationWarning", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "identAttributer", "Lcom/sun/source/tree/TreeVisitor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "breakTree", "Lcom/sun/tools/javac/tree/JCTree;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "statInfo", "Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "varAssignmentInfo", "Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodAttrInfo", "Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unknownExprInfo", "Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unknownTypeInfo", "Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unknownTypeExprInfo", "Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recoveryInfo", "Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "env", "Lcom/sun/tools/javac/comp/Env;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resultInfo", "Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "result", "Lcom/sun/tools/javac/code/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matchBindings", "Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "removeClassParams", "Lcom/sun/tools/javac/tree/TreeTranslator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "primitiveTags", "[Lcom/sun/tools/javac/code/TypeTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetChecker", "Lcom/sun/tools/javac/code/Types$MapVisitor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clinits", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Context;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkBase", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;ZZZ)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isType", "(Lcom/sun/tools/javac/code/Symbol;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pt", "()Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "check", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Kinds$KindSelector;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instance", "(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/comp/Attr;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkMethod", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Lcom/sun/tools/javac/tree/JCTree$JCAnnotation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "capture", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBinary", "(Lcom/sun/tools/javac/tree/JCTree$JCBinary;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeIdent", "(Lcom/sun/tools/javac/tree/JCTree$JCPrimitiveTypeTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitApply", "(Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBlock", "(Lcom/sun/tools/javac/tree/JCTree$JCBlock;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVarDef", "(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModifiers", "(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParenthesizedPattern", "(Lcom/sun/tools/javac/tree/JCTree$JCParenthesizedPattern;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBindingPattern", "(Lcom/sun/tools/javac/tree/JCTree$JCBindingPattern;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitGuardPattern", "(Lcom/sun/tools/javac/tree/JCTree$JCGuardPattern;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodDef", "(Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAssign", "(Lcom/sun/tools/javac/tree/JCTree$JCAssign;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAssignop", "(Lcom/sun/tools/javac/tree/JCTree$JCAssignOp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConditional", "(Lcom/sun/tools/javac/tree/JCTree$JCConditional;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeArray", "(Lcom/sun/tools/javac/tree/JCTree$JCArrayTypeTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotatedType", "(Lcom/sun/tools/javac/tree/JCTree$JCAnnotatedType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUnary", "(Lcom/sun/tools/javac/tree/JCTree$JCUnary;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeIntersection", "(Lcom/sun/tools/javac/tree/JCTree$JCTypeIntersection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeCast", "(Lcom/sun/tools/javac/tree/JCTree$JCTypeCast;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParens", "(Lcom/sun/tools/javac/tree/JCTree$JCParens;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIdent", "(Lcom/sun/tools/javac/tree/JCTree$JCIdent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIndexed", "(Lcom/sun/tools/javac/tree/JCTree$JCArrayAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSelect", "(Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeApply", "(Lcom/sun/tools/javac/tree/JCTree$JCTypeApply;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSwitchExpression", "(Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNewArray", "(Lcom/sun/tools/javac/tree/JCTree$JCNewArray;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassDef", "(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitExec", "(Lcom/sun/tools/javac/tree/JCTree$JCExpressionStatement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLambda", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNewClass", "(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitYield", "(Lcom/sun/tools/javac/tree/JCTree$JCYield;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIf", "(Lcom/sun/tools/javac/tree/JCTree$JCIf;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForeachLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCEnhancedForLoop;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCForLoop;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWhileLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCWhileLoop;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDoLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCDoWhileLoop;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTry", "(Lcom/sun/tools/javac/tree/JCTree$JCTry;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSwitch", "(Lcom/sun/tools/javac/tree/JCTree$JCSwitch;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSynchronized", "(Lcom/sun/tools/javac/tree/JCTree$JCSynchronized;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitThrow", "(Lcom/sun/tools/javac/tree/JCTree$JCThrow;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBreak", "(Lcom/sun/tools/javac/tree/JCTree$JCBreak;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitContinue", "(Lcom/sun/tools/javac/tree/JCTree$JCContinue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSkip", "(Lcom/sun/tools/javac/tree/JCTree$JCSkip;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAssert", "(Lcom/sun/tools/javac/tree/JCTree$JCAssert;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeUnion", "(Lcom/sun/tools/javac/tree/JCTree$JCTypeUnion;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModuleDef", "(Lcom/sun/tools/javac/tree/JCTree$JCModuleDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitImport", "(Lcom/sun/tools/javac/tree/JCTree$JCImport;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeParameter", "(Lcom/sun/tools/javac/tree/JCTree$JCTypeParameter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDiagnosticPosition", "(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribToTree", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/comp/Env;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribLazyConstantValue", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;Lcom/sun/tools/javac/code/Type;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pkind", "()Lcom/sun/tools/javac/code/Kinds$KindSelector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribType", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribType", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribType", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attrib", "(Lcom/sun/tools/javac/comp/Env;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribClass", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribClass", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribIdent", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/code/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribIdent", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;)Lcom/sun/tools/javac/code/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "coerce", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribTree", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkFirstConstructorStat", "(Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canInferLocalVarType", "(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSyntheticVariableType", "(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;Lcom/sun/tools/javac/code/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNonArgsMethodInObject", "(Lcom/sun/tools/javac/util/Name;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "breaksOutOf", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/JCTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bindingEnv", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/comp/Env;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bindingEnv", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/comp/Env;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preFlow", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preFlow", "(Lcom/sun/tools/javac/tree/JCTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleSwitch", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Ljava/util/function/BiConsumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "switchExpressionContext", "(Lcom/sun/tools/javac/comp/Check$CheckContext;)Lcom/sun/tools/javac/comp/Check$CheckContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "condType", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignableAsBlankFinal", "(Lcom/sun/tools/javac/code/Symbol$VarSymbol;Lcom/sun/tools/javac/comp/Env;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribStats", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/comp/Env;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyEnv", "(Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/Env;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "breakTreeFound", "(Lcom/sun/tools/javac/comp/Env;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyScope", "(Lcom/sun/tools/javac/code/Scope$WriteableScope;)Lcom/sun/tools/javac/code/Scope$WriteableScope;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribExpr", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribExpr", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribStat", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribAnyTypes", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "enumConstant", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkCaseLabelDominated", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkCastablePattern", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addVars", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Scope$WriteableScope;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValueBased", "(Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkAutoCloseable", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/code/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBooleanOrNumeric", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "conditionalContext", "(Lcom/sun/tools/javac/comp/Check$CheckContext;)Lcom/sun/tools/javac/comp/Check$CheckContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "primitiveOrBoxed", "(Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findJumpTarget", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/tree/JCTree$Tag;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findJumpTargetNoError", "(Lcom/sun/tools/javac/tree/JCTree$Tag;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/util/Pair;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribArgs", "(Lcom/sun/tools/javac/code/Kinds$KindSelector;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/util/ListBuffer;)Lcom/sun/tools/javac/code/Kinds$KindSelector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribTypes", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newMethodTemplate", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkId", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adjustMethodReturnType", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribIdentAsEnumType", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCIdent;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "diamondContext", "(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/comp/Check$CheckContext;)Lcom/sun/tools/javac/comp/Check$CheckContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnonymousClassDefinition", "(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Kinds$KindSelector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribExprs", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lambdaEnv", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/Env;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetInfo", "(Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression;Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/comp/Attr$TargetInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFunctionalInfo", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCFunctionalExpression;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Check$CheckContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lambdaBodyResult", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkLambdaCompatible", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Check$CheckContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkExConstraints", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/comp/InferenceContext;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkAccessibleTypes", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/comp/InferenceContext;Lcom/sun/tools/javac/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkAccessibleTypes", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/comp/InferenceContext;[Lcom/sun/tools/javac/code/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fallbackDescriptorType", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "memberReferenceQualifierResult", "(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkReferenceCompatible", "(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Check$CheckContext;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkInit", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/code/Symbol$VarSymbol;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkAssignable", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Symbol$VarSymbol;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thisSym", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/code/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "selectSym", "(Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/code/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkMethodIdInternal", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkIdInternal", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStaticReference", "(Lcom/sun/tools/javac/tree/JCTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "enclosingInitEnv", "(Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/Env;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStaticEnumField", "(Lcom/sun/tools/javac/code/Symbol$VarSymbol;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkEnumInitializer", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/code/Symbol$VarSymbol;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "litType", "(Lcom/sun/tools/javac/code/TypeTag;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkIntersection", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribAnnotationTypes", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/comp/Env;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribModule", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Symbol$ModuleSymbol;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribModule", "(Lcom/sun/tools/javac/code/Symbol$ModuleSymbol;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribTopLevel", "(Lcom/sun/tools/javac/comp/Env;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribPackage", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Symbol$PackageSymbol;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribPackage", "(Lcom/sun/tools/javac/code/Symbol$PackageSymbol;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribClassBody", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateTypeAnnotations", "(Lcom/sun/tools/javac/tree/JCTree;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribImportQualifier", "(Lcom/sun/tools/javac/tree/JCTree$JCImport;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribExprToTree", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/comp/Env;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribStatToTree", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/comp/Env;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribTypeVariables", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/comp/Env;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribBase", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;ZZZ)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLabelled", "(Lcom/sun/tools/javac/tree/JCTree$JCLabeledStatement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeNullCheck", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeClinit", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)Lcom/sun/tools/javac/code/Symbol$MethodSymbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeTest", "(Lcom/sun/tools/javac/tree/JCTree$JCInstanceOf;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTree", "(Lcom/sun/tools/javac/tree/JCTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postAttr", "(Lcom/sun/tools/javac/tree/JCTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPackageSymbols", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/code/Symbol;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReturn", "(Lcom/sun/tools/javac/tree/JCTree$JCReturn;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLiteral", "(Lcom/sun/tools/javac/tree/JCTree$JCLiteral;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitErroneous", "(Lcom/sun/tools/javac/tree/JCTree$JCErroneous;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReference", "(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcard", "(Lcom/sun/tools/javac/tree/JCTree$JCWildcard;)V"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Context$Key;", "protected static final")]
	public static Dova.JDK.com.sun.tools.javac.util.Context.Key attrKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Context.Key>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Names;", "final")]
	public Dova.JDK.com.sun.tools.javac.util.Names names_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Names>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Log;", "final")]
	public Dova.JDK.com.sun.tools.javac.util.Log log_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Log>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symtab;", "final")]
	public Dova.JDK.com.sun.tools.javac.code.Symtab syms_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symtab>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Resolve;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.Resolve rs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Resolve>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Operators;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.Operators operators_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Operators>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.Infer infer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Analyzer;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.Analyzer analyzer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Analyzer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/DeferredAttr;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.DeferredAttr deferredAttr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.DeferredAttr>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Check;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.Check chk_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Check>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.Flow flow_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/MemberEnter;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.MemberEnter memberEnter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.MemberEnter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/TypeEnter;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.TypeEnter typeEnter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.TypeEnter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/TreeMaker;", "final")]
	public Dova.JDK.com.sun.tools.javac.tree.TreeMaker make_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.TreeMaker>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/ConstFold;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.ConstFold cfolder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ConstFold>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Enter;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.Enter enter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Enter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/Target;", "final")]
	public Dova.JDK.com.sun.tools.javac.jvm.Target target_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.Target>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "final")]
	public Dova.JDK.com.sun.tools.javac.code.Types types_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Preview;", "final")]
	public Dova.JDK.com.sun.tools.javac.code.Preview preview_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Preview>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Factory;", "final")]
	public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Factory diags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/TypeAnnotations;", "final")]
	public Dova.JDK.com.sun.tools.javac.code.TypeAnnotations typeAnnotations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotations>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/DeferredLintHandler;", "final")]
	public Dova.JDK.com.sun.tools.javac.code.DeferredLintHandler deferredLintHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.DeferredLintHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/TypeEnvs;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.TypeEnvs typeEnvs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.TypeEnvs>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies;", "final")]
	public Dova.JDK.com.sun.tools.javac.util.Dependencies dependencies_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Annotate;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.Annotate annotate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Annotate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/ArgumentAttr;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr argumentAttr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/MatchBindingsComputer;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer matchBindingsComputer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/AttrRecover;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.AttrRecover attrRecover_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.AttrRecover>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool allowPoly_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[28]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[28], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool allowTypeAnnos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool allowLambda_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[30]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[30], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool allowDefaultMethods_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[31]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[31], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool allowStaticInterfaceMethods_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[32]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[32], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool allowReifiableTypesInInstanceof_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[33]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[33], value);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool allowRecords_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[34]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[34], value);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool allowPatternSwitch_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[35]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[35], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool useBeforeDeclarationWarning_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[36]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[36], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String sourceName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/source/tree/TreeVisitor;", "private")]
	public Dova.JDK.com.sun.source.tree.TreeVisitor identAttributer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.TreeVisitor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree;", "private")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree breakTree_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo statInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo varAssignmentInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo methodAttrInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo unknownExprInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo unknownTypeInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[44]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo unknownTypeExprInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[45]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo recoveryInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[46]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Env;", "")]
	public Dova.JDK.com.sun.tools.javac.comp.Env env_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[47]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Env>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[47], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "")]
	public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo resultInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[48]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type result_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[49]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[49], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;", "")]
	public Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings matchBindings_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[50]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[50], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/TreeTranslator;", "")]
	public Dova.JDK.com.sun.tools.javac.tree.TreeTranslator removeClassParams_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[51]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.TreeTranslator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[51], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/tools/javac/code/TypeTag;", "static final")]
	public static JavaArray<Dova.JDK.com.sun.tools.javac.code.TypeTag> primitiveTags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.TypeTag>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$MapVisitor;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Types.MapVisitor targetChecker_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[53]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.MapVisitor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[53], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map clinits_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[54]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[54], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Attr(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)V", "protected")]
	public Attr(Dova.JDK.com.sun.tools.javac.util.Context arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Attr;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;ZZZ)Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type checkBase(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1, Dova.JDK.com.sun.tools.javac.comp.Env arg2, bool arg3, bool arg4, bool arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Z", "static")]
	public static bool isType(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type pt()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Kinds$KindSelector;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type check(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector arg2, Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/comp/Attr;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.comp.Attr instance(Dova.JDK.com.sun.tools.javac.util.Context arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type checkMethod(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg2, Dova.JDK.com.sun.tools.javac.comp.Env arg3, Dova.JDK.com.sun.tools.javac.util.List arg4, Dova.JDK.com.sun.tools.javac.util.List arg5, Dova.JDK.com.sun.tools.javac.util.List arg6)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAnnotation;)V", "public")]
	public void visitAnnotation(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAnnotation arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Type capture(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBinary;)V", "public")]
	public void visitBinary(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBinary arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCPrimitiveTypeTree;)V", "public")]
	public void visitTypeIdent(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPrimitiveTypeTree arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;)V", "public")]
	public void visitApply(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodInvocation arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBlock;)V", "public")]
	public void visitBlock(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V", "public")]
	public void visitVarDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;)V", "public")]
	public void visitModifiers(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCParenthesizedPattern;)V", "public")]
	public void visitParenthesizedPattern(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCParenthesizedPattern arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBindingPattern;)V", "public")]
	public void visitBindingPattern(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBindingPattern arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCGuardPattern;)V", "public")]
	public void visitGuardPattern(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCGuardPattern arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)V", "public")]
	public void visitMethodDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAssign;)V", "public")]
	public void visitAssign(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAssign arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAssignOp;)V", "public")]
	public void visitAssignop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAssignOp arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCConditional;)V", "public")]
	public void visitConditional(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCConditional arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCArrayTypeTree;)V", "public")]
	public void visitTypeArray(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCArrayTypeTree arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAnnotatedType;)V", "public")]
	public void visitAnnotatedType(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAnnotatedType arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCUnary;)V", "public")]
	public void visitUnary(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCUnary arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTypeIntersection;)V", "public")]
	public void visitTypeIntersection(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeIntersection arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTypeCast;)V", "public")]
	public void visitTypeCast(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeCast arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCParens;)V", "public")]
	public void visitParens(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCParens arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCIdent;)V", "public")]
	public void visitIdent(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCIdent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCArrayAccess;)V", "public")]
	public void visitIndexed(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCArrayAccess arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;)V", "public")]
	public void visitSelect(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCFieldAccess arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTypeApply;)V", "public")]
	public void visitTypeApply(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeApply arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;)V", "public")]
	public void visitSwitchExpression(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSwitchExpression arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCNewArray;)V", "public")]
	public void visitNewArray(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewArray arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V", "public")]
	public void visitClassDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpressionStatement;)V", "public")]
	public void visitExec(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpressionStatement arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V", "public")]
	public void visitLambda(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V", "public")]
	public void visitNewClass(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCYield;)V", "public")]
	public void visitYield(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCYield arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCIf;)V", "public")]
	public void visitIf(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCIf arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCEnhancedForLoop;)V", "public")]
	public void visitForeachLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCEnhancedForLoop arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCForLoop;)V", "public")]
	public void visitForLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCForLoop arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCWhileLoop;)V", "public")]
	public void visitWhileLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCWhileLoop arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCDoWhileLoop;)V", "public")]
	public void visitDoLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCDoWhileLoop arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTry;)V", "public")]
	public void visitTry(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTry arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCSwitch;)V", "public")]
	public void visitSwitch(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSwitch arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCSynchronized;)V", "public")]
	public void visitSynchronized(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSynchronized arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCThrow;)V", "public")]
	public void visitThrow(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCThrow arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBreak;)V", "public")]
	public void visitBreak(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBreak arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCContinue;)V", "public")]
	public void visitContinue(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCContinue arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCSkip;)V", "public")]
	public void visitSkip(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSkip arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAssert;)V", "public")]
	public void visitAssert(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAssert arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTypeUnion;)V", "public")]
	public void visitTypeUnion(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeUnion arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCModuleDecl;)V", "public")]
	public void visitModuleDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModuleDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCImport;)V", "public")]
	public void visitImport(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCImport arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTypeParameter;)V", "public")]
	public void visitTypeParameter(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeParameter arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition getDiagnosticPosition(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/comp/Env;", "private")]
	public Dova.JDK.com.sun.tools.javac.comp.Env attribToTree(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree arg2, Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Env>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;Lcom/sun/tools/javac/code/Type;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object attribLazyConstantValue(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Kinds$KindSelector;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector pkind()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type attribType(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type attribType(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type attribType(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;)V", "public")]
	public void attrib(Dova.JDK.com.sun.tools.javac.comp.Env arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V", "")]
	public void attribClass(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V", "public")]
	public void attribClass(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/code/Symbol;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol attribIdent(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;)Lcom/sun/tools/javac/code/Symbol;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol attribIdent(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCompilationUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type coerce(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type attribTree(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1, Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;Z)Z", "")]
	public bool checkFirstConstructorStat(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodInvocation arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodDecl arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[69], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "")]
	public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment canInferLocalVarType(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;Lcom/sun/tools/javac/code/Type;)V", "private")]
	public void setSyntheticVariableType(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[71], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Z", "private")]
	public bool isNonArgsMethodInObject(Dova.JDK.com.sun.tools.javac.util.Name arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[72], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/JCTree;)Z", "private")]
	public bool breaksOutOf(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[73], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/comp/Env;", "")]
	public Dova.JDK.com.sun.tools.javac.comp.Env bindingEnv(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1, Dova.JDK.com.sun.tools.javac.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[74], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Env>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/comp/Env;", "")]
	public Dova.JDK.com.sun.tools.javac.comp.Env bindingEnv(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Env>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V", "")]
	public void preFlow(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[76], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)V", "")]
	public void preFlow(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[77], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Ljava/util/function/BiConsumer;)V", "private")]
	public void handleSwitch(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.util.List arg2, Dova.JDK.java.util.function.BiConsumer arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[78], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Check$CheckContext;)Lcom/sun/tools/javac/comp/Check$CheckContext;", "")]
	public Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext switchExpressionContext(Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[79], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type condType(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[80], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$VarSymbol;Lcom/sun/tools/javac/comp/Env;)Z", "")]
	public bool isAssignableAsBlankFinal(Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[81], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/comp/Env;)V", "")]
	public void attribStats(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[82], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/Env;", "")]
	public Dova.JDK.com.sun.tools.javac.comp.Env copyEnv(Dova.JDK.com.sun.tools.javac.comp.Env arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[83], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Env>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;)V", "protected")]
	public void breakTreeFound(Dova.JDK.com.sun.tools.javac.comp.Env arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[84], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Scope$WriteableScope;)Lcom/sun/tools/javac/code/Scope$WriteableScope;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope copyScope(Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[85], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type attribExpr(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[86], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type attribExpr(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[87], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type attribStat(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[88], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/util/List;", "")]
	public Dova.JDK.com.sun.tools.javac.util.List attribAnyTypes(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[89], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Symbol;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol enumConstant(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[90], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type;)V", "private")]
	public void checkCaseLabelDominated(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[91], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z", "private")]
	public bool checkCastablePattern(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[92], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Scope$WriteableScope;)V", "private static")]
	public static void addVars(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[93], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Z", "private")]
	public bool isValueBased(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[94], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/code/Type;)V", "")]
	public void checkAutoCloseable(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[95], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Z", "private")]
	public bool isBooleanOrNumeric(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[96], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Check$CheckContext;)Lcom/sun/tools/javac/comp/Check$CheckContext;", "")]
	public Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext conditionalContext(Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[97], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Z", "")]
	public bool primitiveOrBoxed(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[98], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/tree/JCTree$Tag;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/tree/JCTree;", "private")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree findJumpTarget(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag arg1, Dova.JDK.com.sun.tools.javac.util.Name arg2, Dova.JDK.com.sun.tools.javac.comp.Env arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[99], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Tag;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/util/Pair;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.Pair findJumpTargetNoError(Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.comp.Env arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[100], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Pair>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindSelector;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/util/ListBuffer;)Lcom/sun/tools/javac/code/Kinds$KindSelector;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector attribArgs(Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.comp.Env arg2, Dova.JDK.com.sun.tools.javac.util.ListBuffer arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[101], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/util/List;", "")]
	public Dova.JDK.com.sun.tools.javac.util.List attribTypes(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[102], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type newMethodTemplate(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[103], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type checkId(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.comp.Env arg3, Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[104], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type adjustMethodReturnType(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.Name arg2, Dova.JDK.com.sun.tools.javac.util.List arg3, Dova.JDK.com.sun.tools.javac.code.Type arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[105], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCIdent;)Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type attribIdentAsEnumType(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCIdent arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[106], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/comp/Check$CheckContext;)Lcom/sun/tools/javac/comp/Check$CheckContext;", "")]
	public Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext diamondContext(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg1, Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[107], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Kinds$KindSelector;)V", "private")]
	public void visitAnonymousClassDefinition(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg3, Dova.JDK.com.sun.tools.javac.comp.Env arg4, Dova.JDK.com.sun.tools.javac.util.List arg5, Dova.JDK.com.sun.tools.javac.util.List arg6, Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[108], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/List;", "")]
	public Dova.JDK.com.sun.tools.javac.util.List attribExprs(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[109], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/Env;", "public")]
	public Dova.JDK.com.sun.tools.javac.comp.Env lambdaEnv(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[110], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Env>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression;Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/comp/Attr$TargetInfo;", "")]
	public Dova.JDK.com.sun.tools.javac.comp.Attr.TargetInfo getTargetInfo(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPolyExpression arg0, Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg1, Dova.JDK.com.sun.tools.javac.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[111], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.TargetInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCFunctionalExpression;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Check$CheckContext;)V", "private")]
	public void setFunctionalInfo(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCFunctionalExpression arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.com.sun.tools.javac.code.Type arg3, Dova.JDK.com.sun.tools.javac.code.Type arg4, Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[112], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "")]
	public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo lambdaBodyResult(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[113], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Check$CheckContext;)V", "")]
	public void checkLambdaCompatible(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[114], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/comp/InferenceContext;)Z", "")]
	public bool checkExConstraints(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.comp.InferenceContext arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[115], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/comp/InferenceContext;Lcom/sun/tools/javac/util/List;)V", "private")]
	public void checkAccessibleTypes(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1, Dova.JDK.com.sun.tools.javac.comp.InferenceContext arg2, Dova.JDK.com.sun.tools.javac.util.List arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[116], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/comp/InferenceContext;[Lcom/sun/tools/javac/code/Type;)V", "private transient")]
	public void checkAccessibleTypes(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1, Dova.JDK.com.sun.tools.javac.comp.InferenceContext arg2, JavaArray<Dova.JDK.com.sun.tools.javac.code.Type> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[117], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/code/Type;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Type fallbackDescriptorType(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[118], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "")]
	public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo memberReferenceQualifierResult(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[119], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Check$CheckContext;Z)V", "")]
	public void checkReferenceCompatible(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[120], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/code/Symbol$VarSymbol;Z)V", "private")]
	public void checkInit(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1, Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[121], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Symbol$VarSymbol;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;)V", "")]
	public void checkAssignable(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree arg2, Dova.JDK.com.sun.tools.javac.comp.Env arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[122], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/code/Symbol;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol thisSym(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[123], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/code/Symbol;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol selectSym(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCFieldAccess arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.com.sun.tools.javac.comp.Env arg3, Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[124], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type checkMethodIdInternal(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.comp.Env arg3, Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[125], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type checkIdInternal(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.code.Type arg3, Dova.JDK.com.sun.tools.javac.comp.Env arg4, Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[126], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)Z", "")]
	public bool isStaticReference(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[127], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/Env;", "")]
	public Dova.JDK.com.sun.tools.javac.comp.Env enclosingInitEnv(Dova.JDK.com.sun.tools.javac.comp.Env arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[128], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Env>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$VarSymbol;)Z", "private")]
	public bool isStaticEnumField(Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[129], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/code/Symbol$VarSymbol;)V", "private")]
	public void checkEnumInitializer(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1, Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[130], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeTag;)Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type litType(Dova.JDK.com.sun.tools.javac.code.TypeTag arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[131], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type checkIntersection(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[132], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/comp/Env;)V", "")]
	public void attribAnnotationTypes(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[133], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Symbol$ModuleSymbol;)V", "public")]
	public void attribModule(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.ModuleSymbol arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[134], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ModuleSymbol;)V", "")]
	public void attribModule(Dova.JDK.com.sun.tools.javac.code.Symbol.ModuleSymbol arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[135], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;)V", "public")]
	public void attribTopLevel(Dova.JDK.com.sun.tools.javac.comp.Env arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[136], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Symbol$PackageSymbol;)V", "public")]
	public void attribPackage(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.PackageSymbol arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[137], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$PackageSymbol;)V", "")]
	public void attribPackage(Dova.JDK.com.sun.tools.javac.code.Symbol.PackageSymbol arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[138], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V", "private")]
	public void attribClassBody(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[139], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Z)V", "public")]
	public void validateTypeAnnotations(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[140], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCImport;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type attribImportQualifier(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCImport arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[141], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/comp/Env;", "public")]
	public Dova.JDK.com.sun.tools.javac.comp.Env attribExprToTree(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[142], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Env>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/comp/Env;", "public")]
	public Dova.JDK.com.sun.tools.javac.comp.Env attribStatToTree(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[143], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Env>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/comp/Env;Z)V", "")]
	public void attribTypeVariables(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[144], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;ZZZ)Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type attribBase(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1, bool arg2, bool arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[145], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLabeledStatement;)V", "public")]
	public void visitLabelled(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLabeledStatement arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[146], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression makeNullCheck(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[147], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)Lcom/sun/tools/javac/code/Symbol$MethodSymbol;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol removeClinit(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[148], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCInstanceOf;)V", "public")]
	public void visitTypeTest(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCInstanceOf arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[149], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)V", "public")]
	public void visitTree(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[150], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)V", "public")]
	public void postAttr(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[151], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/code/Symbol;)V", "public")]
	public void setPackageSymbols(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[152], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCReturn;)V", "public")]
	public void visitReturn(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCReturn arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[153], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLiteral;)V", "public")]
	public void visitLiteral(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLiteral arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[154], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCErroneous;)V", "public")]
	public void visitErroneous(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCErroneous arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[155], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;)V", "public")]
	public void visitReference(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[156], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCWildcard;)V", "public")]
	public void visitWildcard(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCWildcard arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[157], arg0);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$IdentAttributer;", "private")]
	public partial class IdentAttributer
		: Dova.JDK.com.sun.source.util.SimpleTreeVisitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IdentAttributer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Attr$IdentAttributer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Attr;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Attr;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMemberSelect", "(Lcom/sun/source/tree/MemberSelectTree;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMemberSelect", "(Lcom/sun/source/tree/MemberSelectTree;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/code/Symbol;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIdentifier", "(Lcom/sun/source/tree/IdentifierTree;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIdentifier", "(Lcom/sun/source/tree/IdentifierTree;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/code/Symbol;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Attr this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IdentAttributer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr;)V", "private")]
		public IdentAttributer(Dova.JDK.com.sun.tools.javac.comp.Attr arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Attr$IdentAttributer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/MemberSelectTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitMemberSelect(Dova.JDK.com.sun.source.tree.MemberSelectTree arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/MemberSelectTree;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/code/Symbol;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol visitMemberSelect(Dova.JDK.com.sun.source.tree.MemberSelectTree arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/IdentifierTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitIdentifier(Dova.JDK.com.sun.source.tree.IdentifierTree arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/IdentifierTree;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/code/Symbol;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol visitIdentifier(Dova.JDK.com.sun.source.tree.IdentifierTree arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "")]
	public partial class ResultInfo
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ResultInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Attr$ResultInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pkind", "Lcom/sun/tools/javac/code/Kinds$KindSelector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pt", "Lcom/sun/tools/javac/code/Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "checkContext", "Lcom/sun/tools/javac/comp/Check$CheckContext;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "checkMode", "Lcom/sun/tools/javac/comp/Attr$CheckMode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Attr;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Attr;Lcom/sun/tools/javac/code/Kinds$KindSelector;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Check$CheckContext;Lcom/sun/tools/javac/comp/Attr$CheckMode;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Attr;Lcom/sun/tools/javac/code/Kinds$KindSelector;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Check$CheckContext;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Attr;Lcom/sun/tools/javac/code/Kinds$KindSelector;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Attr$CheckMode;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Attr;Lcom/sun/tools/javac/code/Kinds$KindSelector;Lcom/sun/tools/javac/code/Type;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "check", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Check$CheckContext;Lcom/sun/tools/javac/comp/Attr$CheckMode;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/comp/Attr$CheckMode;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/comp/Check$CheckContext;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Check$CheckContext;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "needsArgumentAttr", "(Lcom/sun/tools/javac/tree/JCTree;)Z"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindSelector;", "final")]
		public Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector pkind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "final")]
		public Dova.JDK.com.sun.tools.javac.code.Type pt_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Check$CheckContext;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext checkContext_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$CheckMode;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Attr.CheckMode checkMode_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.CheckMode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Attr this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ResultInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr;Lcom/sun/tools/javac/code/Kinds$KindSelector;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Check$CheckContext;Lcom/sun/tools/javac/comp/Attr$CheckMode;)V", "protected")]
		public ResultInfo(Dova.JDK.com.sun.tools.javac.comp.Attr arg0, Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext arg3, Dova.JDK.com.sun.tools.javac.comp.Attr.CheckMode arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr;Lcom/sun/tools/javac/code/Kinds$KindSelector;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Check$CheckContext;)V", "protected")]
		public ResultInfo(Dova.JDK.com.sun.tools.javac.comp.Attr arg0, Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr;Lcom/sun/tools/javac/code/Kinds$KindSelector;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Attr$CheckMode;)V", "")]
		public ResultInfo(Dova.JDK.com.sun.tools.javac.comp.Attr arg0, Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.com.sun.tools.javac.comp.Attr.CheckMode arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr;Lcom/sun/tools/javac/code/Kinds$KindSelector;Lcom/sun/tools/javac/code/Type;)V", "")]
		public ResultInfo(Dova.JDK.com.sun.tools.javac.comp.Attr arg0, Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Attr$ResultInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "protected")]
		public Dova.JDK.com.sun.tools.javac.code.Type check(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Check$CheckContext;Lcom/sun/tools/javac/comp/Attr$CheckMode;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "protected")]
		public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo dup(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext arg1, Dova.JDK.com.sun.tools.javac.comp.Attr.CheckMode arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr$CheckMode;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "protected")]
		public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo dup(Dova.JDK.com.sun.tools.javac.comp.Attr.CheckMode arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "protected")]
		public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo dup(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Check$CheckContext;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "protected")]
		public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo dup(Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Check$CheckContext;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "protected")]
		public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo dup(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)Z", "protected")]
		public bool needsArgumentAttr(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$MethodAttrInfo;", "")]
	public partial class MethodAttrInfo
		: Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MethodAttrInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Attr$MethodAttrInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Attr;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Attr;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Attr;Lcom/sun/tools/javac/comp/Check$CheckContext;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Check$CheckContext;Lcom/sun/tools/javac/comp/Attr$CheckMode;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Check$CheckContext;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/comp/Attr$CheckMode;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/comp/Check$CheckContext;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "needsArgumentAttr", "(Lcom/sun/tools/javac/tree/JCTree;)Z"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Attr this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MethodAttrInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr;)V", "public")]
		public MethodAttrInfo(Dova.JDK.com.sun.tools.javac.comp.Attr arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr;Lcom/sun/tools/javac/comp/Check$CheckContext;)V", "public")]
		public MethodAttrInfo(Dova.JDK.com.sun.tools.javac.comp.Attr arg0, Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Attr$MethodAttrInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Check$CheckContext;Lcom/sun/tools/javac/comp/Attr$CheckMode;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "protected")]
		public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo dup(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext arg1, Dova.JDK.com.sun.tools.javac.comp.Attr.CheckMode arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Check$CheckContext;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "protected")]
		public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo dup(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr$CheckMode;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "protected")]
		public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo dup(Dova.JDK.com.sun.tools.javac.comp.Attr.CheckMode arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Check$CheckContext;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "protected")]
		public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo dup(Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "protected")]
		public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo dup(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)Z", "protected")]
		public bool needsArgumentAttr(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$RecoveryInfo;", "")]
	public partial class RecoveryInfo
		: Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RecoveryInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Attr$RecoveryInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Attr;Lcom/sun/tools/javac/comp/DeferredAttr$DeferredAttrContext;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Attr;Lcom/sun/tools/javac/comp/DeferredAttr$DeferredAttrContext;Lcom/sun/tools/javac/code/Type;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RecoveryInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr;Lcom/sun/tools/javac/comp/DeferredAttr$DeferredAttrContext;)V", "public")]
		public RecoveryInfo(Dova.JDK.com.sun.tools.javac.comp.Attr arg0, Dova.JDK.com.sun.tools.javac.comp.DeferredAttr.DeferredAttrContext arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr;Lcom/sun/tools/javac/comp/DeferredAttr$DeferredAttrContext;Lcom/sun/tools/javac/code/Type;)V", "public")]
		public RecoveryInfo(Dova.JDK.com.sun.tools.javac.comp.Attr arg0, Dova.JDK.com.sun.tools.javac.comp.DeferredAttr.DeferredAttrContext arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Attr$RecoveryInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$CheckMode;", "static")]
	public partial class CheckMode
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CheckMode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Attr$CheckMode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NORMAL", "Lcom/sun/tools/javac/comp/Attr$CheckMode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_TREE_UPDATE", "Lcom/sun/tools/javac/comp/Attr$CheckMode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_INFERENCE_HOOK", "Lcom/sun/tools/javac/comp/Attr$CheckMode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/comp/Attr$CheckMode;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/comp/Attr$CheckMode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/comp/Attr$CheckMode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/comp/Attr$CheckMode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installPostInferenceHook", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateTreeType", "()Z"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$CheckMode;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Attr.CheckMode NORMAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.CheckMode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$CheckMode;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Attr.CheckMode NO_TREE_UPDATE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.CheckMode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$CheckMode;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Attr.CheckMode NO_INFERENCE_HOOK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.CheckMode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/comp/Attr$CheckMode;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Attr.CheckMode> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Attr.CheckMode>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CheckMode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public CheckMode(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Attr$CheckMode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/comp/Attr$CheckMode;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Attr.CheckMode> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Attr.CheckMode>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/comp/Attr$CheckMode;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.comp.Attr.CheckMode valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.CheckMode>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/comp/Attr$CheckMode;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Attr.CheckMode> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Attr.CheckMode>>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool installPostInferenceHook()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool updateTreeType()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$BreakAttr;", "private static")]
	public partial class BreakAttr
		: Dova.JDK.java.lang.RuntimeException
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BreakAttr()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Attr$BreakAttr;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "env", "Lcom/sun/tools/javac/comp/Env;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Env;)V"));
		}

		[JniSignatureAttribute("J", "static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Env;", "private transient")]
		public Dova.JDK.com.sun.tools.javac.comp.Env env_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Env>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BreakAttr(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;)V", "private")]
		public BreakAttr(Dova.JDK.com.sun.tools.javac.comp.Env arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Attr$BreakAttr;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$LocalInitScanner;", "static")]
	public partial class LocalInitScanner
		: Dova.JDK.com.sun.tools.javac.tree.TreeScanner
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LocalInitScanner()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Attr$LocalInitScanner;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "badInferenceMsg", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "needsTarget", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitApply", "(Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeCast", "(Lcom/sun/tools/javac/tree/JCTree$JCTypeCast;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNewArray", "(Lcom/sun/tools/javac/tree/JCTree$JCNewArray;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLambda", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNewClass", "(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReference", "(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "")]
		public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment badInferenceMsg_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool needsTarget_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LocalInitScanner(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public LocalInitScanner() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Attr$LocalInitScanner;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;)V", "public")]
		public void visitApply(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodInvocation arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTypeCast;)V", "public")]
		public void visitTypeCast(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeCast arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCNewArray;)V", "public")]
		public void visitNewArray(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewArray arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V", "public")]
		public void visitLambda(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V", "public")]
		public void visitNewClass(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;)V", "public")]
		public void visitReference(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$TargetInfo;", "")]
	public partial class TargetInfo
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TargetInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Attr$TargetInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Lcom/sun/tools/javac/code/Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptor", "Lcom/sun/tools/javac/code/Type;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Attr;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Type target_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Type descriptor_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TargetInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)V", "public")]
		public TargetInfo(Dova.JDK.com.sun.tools.javac.comp.Attr arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Attr$TargetInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$ExpressionLambdaReturnContext;", "")]
	public partial class ExpressionLambdaReturnContext
		: Dova.JDK.com.sun.tools.javac.comp.Attr.FunctionalReturnContext
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ExpressionLambdaReturnContext()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Attr$ExpressionLambdaReturnContext;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expr", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expStmtExpected", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Attr;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Attr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Check$CheckContext;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compatible", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "report", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/util/JCDiagnostic;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression expr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool expStmtExpected_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Attr this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ExpressionLambdaReturnContext(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Check$CheckContext;)V", "")]
		public ExpressionLambdaReturnContext(Dova.JDK.com.sun.tools.javac.comp.Attr arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Attr$ExpressionLambdaReturnContext;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z", "public")]
		public bool compatible(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.Warner arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/util/JCDiagnostic;)V", "public")]
		public void report(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$FunctionalReturnContext;", "")]
	public partial class FunctionalReturnContext
		: Dova.JDK.com.sun.tools.javac.comp.Check.NestedCheckContext
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FunctionalReturnContext()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Attr$FunctionalReturnContext;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Attr;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Attr;Lcom/sun/tools/javac/comp/Check$CheckContext;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compatible", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "report", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/util/JCDiagnostic;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Attr this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FunctionalReturnContext(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr;Lcom/sun/tools/javac/comp/Check$CheckContext;)V", "")]
		public FunctionalReturnContext(Dova.JDK.com.sun.tools.javac.comp.Attr arg0, Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Attr$FunctionalReturnContext;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z", "public")]
		public bool compatible(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.Warner arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/util/JCDiagnostic;)V", "public")]
		public void report(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$TypeAnnotationsValidator;", "private final")]
	public partial class TypeAnnotationsValidator
		: Dova.JDK.com.sun.tools.javac.tree.TreeScanner
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypeAnnotationsValidator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Attr$TypeAnnotationsValidator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sigOnly", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Attr;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Attr;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Lcom/sun/tools/javac/tree/JCTree$JCAnnotation;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBlock", "(Lcom/sun/tools/javac/tree/JCTree$JCBlock;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVarDef", "(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodDef", "(Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotatedType", "(Lcom/sun/tools/javac/tree/JCTree$JCAnnotatedType;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeCast", "(Lcom/sun/tools/javac/tree/JCTree$JCTypeCast;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNewArray", "(Lcom/sun/tools/javac/tree/JCTree$JCNewArray;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassDef", "(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNewClass", "(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeParameter", "(Lcom/sun/tools/javac/tree/JCTree$JCTypeParameter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkForDeclarationAnnotations", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Symbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateAnnotatedType", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Type;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeTest", "(Lcom/sun/tools/javac/tree/JCTree$JCInstanceOf;)V"));
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool sigOnly_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Attr this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TypeAnnotationsValidator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr;Z)V", "public")]
		public TypeAnnotationsValidator(Dova.JDK.com.sun.tools.javac.comp.Attr arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Attr$TypeAnnotationsValidator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAnnotation;)V", "public")]
		public void visitAnnotation(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAnnotation arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBlock;)V", "public")]
		public void visitBlock(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V", "public")]
		public void visitVarDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)V", "public")]
		public void visitMethodDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAnnotatedType;)V", "public")]
		public void visitAnnotatedType(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAnnotatedType arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTypeCast;)V", "public")]
		public void visitTypeCast(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeCast arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCNewArray;)V", "public")]
		public void visitNewArray(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewArray arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V", "public")]
		public void visitClassDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V", "public")]
		public void visitNewClass(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTypeParameter;)V", "public")]
		public void visitTypeParameter(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeParameter arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Symbol;)V", "private")]
		public void checkForDeclarationAnnotations(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Type;)V", "private")]
		public void validateAnnotatedType(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCInstanceOf;)V", "public")]
		public void visitTypeTest(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCInstanceOf arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr$PostAttrAnalyzer;", "")]
	public partial class PostAttrAnalyzer
		: Dova.JDK.com.sun.tools.javac.tree.TreeScanner
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PostAttrAnalyzer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Attr$PostAttrAnalyzer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Attr;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Attr;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scan", "(Lcom/sun/tools/javac/tree/JCTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBinary", "(Lcom/sun/tools/javac/tree/JCTree$JCBinary;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVarDef", "(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBindingPattern", "(Lcom/sun/tools/javac/tree/JCTree$JCBindingPattern;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodDef", "(Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAssignop", "(Lcom/sun/tools/javac/tree/JCTree$JCAssignOp;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUnary", "(Lcom/sun/tools/javac/tree/JCTree$JCUnary;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIdent", "(Lcom/sun/tools/javac/tree/JCTree$JCIdent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSelect", "(Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassDef", "(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNewClass", "(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dummyMethodType", "()Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dummyMethodType", "(Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initTypeIfNeeded", "(Lcom/sun/tools/javac/tree/JCTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReference", "(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Attr this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PostAttrAnalyzer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr;)V", "")]
		public PostAttrAnalyzer(Dova.JDK.com.sun.tools.javac.comp.Attr arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Attr$PostAttrAnalyzer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)V", "public")]
		public void scan(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBinary;)V", "public")]
		public void visitBinary(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBinary arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V", "public")]
		public void visitVarDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBindingPattern;)V", "public")]
		public void visitBindingPattern(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBindingPattern arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)V", "public")]
		public void visitMethodDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAssignOp;)V", "public")]
		public void visitAssignop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAssignOp arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCUnary;)V", "public")]
		public void visitUnary(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCUnary arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCIdent;)V", "public")]
		public void visitIdent(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCIdent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;)V", "public")]
		public void visitSelect(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCFieldAccess arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V", "public")]
		public void visitClassDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V", "public")]
		public void visitNewClass(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "private")]
		public Dova.JDK.com.sun.tools.javac.code.Type dummyMethodType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)Lcom/sun/tools/javac/code/Type;", "private")]
		public Dova.JDK.com.sun.tools.javac.code.Type dummyMethodType(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodDecl arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)V", "private")]
		public void initTypeIfNeeded(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;)V", "public")]
		public void visitReference(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		}
	}
}
