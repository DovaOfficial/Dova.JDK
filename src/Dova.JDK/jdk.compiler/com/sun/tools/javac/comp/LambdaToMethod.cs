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

[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod;", "public")]
public partial class LambdaToMethod
	: Dova.JDK.com.sun.tools.javac.tree.TreeTranslator
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LambdaToMethod()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/LambdaToMethod;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attr", "Lcom/sun/tools/javac/comp/Attr;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "diags", "Lcom/sun/tools/javac/util/JCDiagnostic$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "log", "Lcom/sun/tools/javac/util/Log;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lower", "Lcom/sun/tools/javac/comp/Lower;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "names", "Lcom/sun/tools/javac/util/Names;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "syms", "Lcom/sun/tools/javac/code/Symtab;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rs", "Lcom/sun/tools/javac/comp/Resolve;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "operators", "Lcom/sun/tools/javac/comp/Operators;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "make", "Lcom/sun/tools/javac/tree/TreeMaker;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "types", "Lcom/sun/tools/javac/code/Types;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transTypes", "Lcom/sun/tools/javac/comp/TransTypes;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attrEnv", "Lcom/sun/tools/javac/comp/Env;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "analyzer", "Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "contextMap", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "context", "Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$TranslationContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kInfo", "Lcom/sun/tools/javac/comp/LambdaToMethod$KlassInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dumpLambdaToMethodStats", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "forceSerializable", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "debugLinesOrVars", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "verboseDeduplication", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "deduplicateLambdas", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nestmateLambdas", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLAG_SERIALIZABLE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLAG_MARKERS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLAG_BRIDGES", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "unlambdaKey", "Lcom/sun/tools/javac/util/Context$Key;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Context;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instance", "(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/comp/LambdaToMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "classSig", "(Lcom/sun/tools/javac/code/Type;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeSig", "(Lcom/sun/tools/javac/code/Type;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeSig", "(Lcom/sun/tools/javac/code/Type;Z)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVarDef", "(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIdent", "(Lcom/sun/tools/javac/tree/JCTree$JCIdent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSelect", "(Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassDef", "(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLambda", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNewClass", "(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeDeserializeMethod", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apportionTypeAnnotations", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;Ljava/util/function/Supplier;Ljava/util/function/Consumer;Ljava/util/function/Consumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeLambdaBody", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)Lcom/sun/tools/javac/tree/JCTree$JCBlock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeMetafactoryIndyCall", "(Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$TranslationContext;Lcom/sun/tools/javac/code/Symbol$MethodHandleSymbol;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeLambdaExpressionBody", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)Lcom/sun/tools/javac/tree/JCTree$JCBlock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeLambdaStatementBody", "(Lcom/sun/tools/javac/tree/JCTree$JCBlock;Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;Z)Lcom/sun/tools/javac/tree/JCTree$JCBlock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deserGetter", "(Ljava/lang/String;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deserGetter", "(Ljava/lang/String;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eqTest", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deserTest", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeIndyCall", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type$MethodType;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setVarargsIfNeeded", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeToMethodType", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type$MethodType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDeserializationCase", "(Lcom/sun/tools/javac/code/Symbol$MethodHandleSymbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type$MethodType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makePrivateSyntheticMethod", "(JLcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Symbol$MethodSymbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeSyntheticVar", "(JLcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Symbol$VarSymbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertArgs", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isProtectedInSuperClassOfEnclosingClassInOtherPackage", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReference", "(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateTopLevelClass", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/TreeMaker;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeThis", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/tree/JCTree$JCIdent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeNewClass", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/tree/JCTree$JCNewClass;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeNewClass", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCNewClass;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$TranslationContext;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$TranslationContext;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "(Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/tree/JCTree;"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr;", "private")]
	public Dova.JDK.com.sun.tools.javac.comp.Attr attr_Property
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

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Factory;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Factory diags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Log;", "private")]
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

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Lower;", "private")]
	public Dova.JDK.com.sun.tools.javac.comp.Lower lower_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Lower>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Names;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.Names names_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Names>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symtab;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Symtab syms_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symtab>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Resolve;", "private")]
	public Dova.JDK.com.sun.tools.javac.comp.Resolve rs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Resolve>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Operators;", "private")]
	public Dova.JDK.com.sun.tools.javac.comp.Operators operators_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Operators>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/TreeMaker;", "private")]
	public Dova.JDK.com.sun.tools.javac.tree.TreeMaker make_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.TreeMaker>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Types types_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/TransTypes;", "private")]
	public Dova.JDK.com.sun.tools.javac.comp.TransTypes transTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.TransTypes>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Env;", "private")]
	public Dova.JDK.com.sun.tools.javac.comp.Env attrEnv_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Env>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor;", "private")]
	public Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor analyzer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map contextMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$TranslationContext;", "private")]
	public Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor.TranslationContext context_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor.TranslationContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$KlassInfo;", "private")]
	public Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.KlassInfo kInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.KlassInfo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool dumpLambdaToMethodStats_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool forceSerializable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool debugLinesOrVars_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool verboseDeduplication_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool deduplicateLambdas_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool nestmateLambdas_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int FLAG_SERIALIZABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int FLAG_MARKERS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int FLAG_BRIDGES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Context$Key;", "protected static final")]
	public static Dova.JDK.com.sun.tools.javac.util.Context.Key unlambdaKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Context.Key>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LambdaToMethod(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)V", "private")]
	public LambdaToMethod(Dova.JDK.com.sun.tools.javac.util.Context arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/LambdaToMethod;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/comp/LambdaToMethod;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod instance(Dova.JDK.com.sun.tools.javac.util.Context arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String classSig(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String typeSig(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Z)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String typeSig(Dova.JDK.com.sun.tools.javac.code.Type arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V", "public")]
	public void visitVarDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCIdent;)V", "public")]
	public void visitIdent(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCIdent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;)V", "public")]
	public void visitSelect(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCFieldAccess arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V", "public")]
	public void visitClassDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V", "public")]
	public void visitLambda(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V", "public")]
	public void visitNewClass(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;", "private")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodDecl makeDeserializeMethod(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodDecl>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;Ljava/util/function/Supplier;Ljava/util/function/Consumer;Ljava/util/function/Consumer;)V", "private")]
	public void apportionTypeAnnotations(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0, Dova.JDK.java.util.function.Supplier arg1, Dova.JDK.java.util.function.Consumer arg2, Dova.JDK.java.util.function.Consumer arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)Lcom/sun/tools/javac/tree/JCTree$JCBlock;", "private")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock makeLambdaBody(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodDecl arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$TranslationContext;Lcom/sun/tools/javac/code/Symbol$MethodHandleSymbol;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "private")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression makeMetafactoryIndyCall(Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor.TranslationContext arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.MethodHandleSymbol arg1, Dova.JDK.com.sun.tools.javac.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)Lcom/sun/tools/javac/tree/JCTree$JCBlock;", "private")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock makeLambdaExpressionBody(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodDecl arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBlock;Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;Z)Lcom/sun/tools/javac/tree/JCTree$JCBlock;", "private")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock makeLambdaStatementBody(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodDecl arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "private")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression deserGetter(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.List arg2, Dova.JDK.com.sun.tools.javac.util.List arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "private")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression deserGetter(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "private")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression eqTest(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "private")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression deserTest(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type$MethodType;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "private")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression makeIndyCall(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.Name arg2, Dova.JDK.com.sun.tools.javac.util.List arg3, Dova.JDK.com.sun.tools.javac.code.Type.MethodType arg4, Dova.JDK.com.sun.tools.javac.util.List arg5, Dova.JDK.com.sun.tools.javac.util.Name arg6)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Type;)V", "private")]
	public void setVarargsIfNeeded(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type$MethodType;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Type.MethodType typeToMethodType(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.MethodType>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$MethodHandleSymbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type$MethodType;)V", "private")]
	public void addDeserializationCase(Dova.JDK.com.sun.tools.javac.code.Symbol.MethodHandleSymbol arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg3, Dova.JDK.com.sun.tools.javac.util.List arg4, Dova.JDK.com.sun.tools.javac.code.Type.MethodType arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(JLcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Symbol$MethodSymbol;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol makePrivateSyntheticMethod(long arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.com.sun.tools.javac.code.Symbol arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol>(ret);
	}

	[JniSignatureAttribute("(JLcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Symbol$VarSymbol;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol makeSyntheticVar(long arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.com.sun.tools.javac.code.Symbol arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/List;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.List convertArgs(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Z", "private")]
	public bool isProtectedInSuperClassOfEnclosingClassInOtherPackage(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;)V", "public")]
	public void visitReference(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/TreeMaker;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree translateTopLevelClass(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1, Dova.JDK.com.sun.tools.javac.tree.TreeMaker arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/tree/JCTree$JCIdent;", "private")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCIdent makeThis(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCIdent>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/tree/JCTree$JCNewClass;", "")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass makeNewClass(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCNewClass;", "")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass makeNewClass(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$TranslationContext;)Lcom/sun/tools/javac/tree/JCTree;", "")]
	public Dova.JDK.java.lang.Object translate(Dova.JDK.java.lang.Object arg0, Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor.TranslationContext arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$TranslationContext;)Lcom/sun/tools/javac/util/List;", "")]
	public Dova.JDK.com.sun.tools.javac.util.List translate(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor.TranslationContext arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.java.lang.Object translate(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor;", "")]
	public partial class LambdaAnalyzerPreprocessor
		: Dova.JDK.com.sun.tools.javac.tree.TreeTranslator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LambdaAnalyzerPreprocessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "frameStack", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lambdaCount", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typesUnderConstruction", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "syntheticMethodNameCounts", "Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$SyntheticMethodNameCounter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localClassDefs", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clinits", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/LambdaToMethod;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/LambdaToMethod;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "context", "()Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$TranslationContext;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "owner", "(Z)Lcom/sun/tools/javac/code/Symbol;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "owner", "()Lcom/sun/tools/javac/code/Symbol;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "currentClass", "()Lcom/sun/tools/javac/code/Symbol$ClassSymbol;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitApply", "(Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBlock", "(Lcom/sun/tools/javac/tree/JCTree$JCBlock;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVarDef", "(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodDef", "(Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIdent", "(Lcom/sun/tools/javac/tree/JCTree$JCIdent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSelect", "(Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassDef", "(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLambda", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNewClass", "(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "analyzeAndPreprocessClass", "(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lambdaIdentSymbolFilter", "(Lcom/sun/tools/javac/code/Symbol;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lambdaFieldAccessFilter", "(Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lambdaNewClassFilter", "(Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$TranslationContext;Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "directlyEnclosingLambda", "()Lcom/sun/tools/javac/tree/JCTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "capturedDecl", "(ILcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/tree/JCTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "currentlyInClass", "(Lcom/sun/tools/javac/code/Symbol;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "captureLocalClassDefs", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$LambdaTranslationContext;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inClassWithinLambda", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initSym", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;J)Lcom/sun/tools/javac/code/Symbol;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "analyzeLambda", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "analyzeLambda", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;Ljava/lang/String;)Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$LambdaTranslationContext;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReference", "(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "private")]
		public Dova.JDK.com.sun.tools.javac.util.List frameStack_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int lambdaCount_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "private")]
		public Dova.JDK.com.sun.tools.javac.util.List typesUnderConstruction_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$SyntheticMethodNameCounter;", "private")]
		public Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor.SyntheticMethodNameCounter syntheticMethodNameCounts_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor.SyntheticMethodNameCounter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private")]
		public Dova.JDK.java.util.Map localClassDefs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private")]
		public Dova.JDK.java.util.Map clinits_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LambdaAnalyzerPreprocessor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/LambdaToMethod;)V", "")]
		public LambdaAnalyzerPreprocessor(Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$TranslationContext;", "private")]
		public Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor.TranslationContext context()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor.TranslationContext>(ret);
		}

		[JniSignatureAttribute("(Z)Lcom/sun/tools/javac/code/Symbol;", "private")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol owner(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Symbol;", "private")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol owner()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Symbol$ClassSymbol;", "private")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol currentClass()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;)V", "public")]
		public void visitApply(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodInvocation arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBlock;)V", "public")]
		public void visitBlock(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V", "public")]
		public void visitVarDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)V", "public")]
		public void visitMethodDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCIdent;)V", "public")]
		public void visitIdent(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCIdent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;)V", "public")]
		public void visitSelect(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCFieldAccess arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V", "public")]
		public void visitClassDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V", "public")]
		public void visitLambda(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V", "public")]
		public void visitNewClass(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;", "private")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl analyzeAndPreprocessClass(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Z", "private")]
		public bool lambdaIdentSymbolFilter(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;)Z", "private")]
		public bool lambdaFieldAccessFilter(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCFieldAccess arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$TranslationContext;Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)Z", "private")]
		public bool lambdaNewClassFilter(Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor.TranslationContext arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree;", "private")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree directlyEnclosingLambda()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}

		[JniSignatureAttribute("(ILcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/tree/JCTree;", "private")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree capturedDecl(int arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Z", "")]
		public bool currentlyInClass(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$LambdaTranslationContext;)V", "")]
		public void captureLocalClassDefs(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor.LambdaTranslationContext arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		}

		[JniSignatureAttribute("()Z", "private")]
		public bool inClassWithinLambda()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;J)Lcom/sun/tools/javac/code/Symbol;", "private")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol initSym(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0, long arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V", "private")]
		public void analyzeLambda(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;Ljava/lang/String;)Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$LambdaTranslationContext;", "private")]
		public Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor.LambdaTranslationContext analyzeLambda(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor.LambdaTranslationContext>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;)V", "public")]
		public void visitReference(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$SyntheticMethodNameCounter;", "private")]
		public partial class SyntheticMethodNameCounter
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SyntheticMethodNameCounter()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$SyntheticMethodNameCounter;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "map", "Ljava/util/Map;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndex", "(Ljava/lang/StringBuilder;)I"));
			}

			[JniSignatureAttribute("Ljava/util/Map;", "private")]
			public Dova.JDK.java.util.Map map_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SyntheticMethodNameCounter(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor;)V", "private")]
			public SyntheticMethodNameCounter(Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$SyntheticMethodNameCounter;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/StringBuilder;)I", "")]
			public int getIndex(Dova.JDK.java.lang.StringBuilder arg0)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$Frame;", "private")]
		public partial class Frame
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Frame()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$Frame;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tree", "Lcom/sun/tools/javac/tree/JCTree;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "locals", "Lcom/sun/tools/javac/util/List;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor;Lcom/sun/tools/javac/tree/JCTree;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addLocal", "(Lcom/sun/tools/javac/code/Symbol;)V"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree;", "final")]
			public Dova.JDK.com.sun.tools.javac.tree.JCTree tree_Property
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

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "")]
			public Dova.JDK.com.sun.tools.javac.util.List locals_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Frame(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor;Lcom/sun/tools/javac/tree/JCTree;)V", "public")]
			public Frame(Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$Frame;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "")]
			public void addLocal(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$TranslationContext;", "abstract")]
		public partial class TranslationContext
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TranslationContext()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$TranslationContext;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tree", "Lcom/sun/tools/javac/tree/JCTree$JCFunctionalExpression;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "owner", "Lcom/sun/tools/javac/code/Symbol;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "depth", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prev", "Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$TranslationContext;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bridges", "Lcom/sun/tools/javac/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor;Lcom/sun/tools/javac/tree/JCTree$JCFunctionalExpression;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSerializable", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "needsAltMetafactory", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "syntheticMethodNameComponent", "(Lcom/sun/tools/javac/util/Name;)Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "enclosingMethodName", "()Ljava/lang/String;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCFunctionalExpression;", "final")]
			public Dova.JDK.java.lang.Object tree_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol;", "final")]
			public Dova.JDK.com.sun.tools.javac.code.Symbol owner_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "final")]
			public int depth_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$TranslationContext;", "final")]
			public Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor.TranslationContext prev_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor.TranslationContext>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "final")]
			public Dova.JDK.com.sun.tools.javac.util.List bridges_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor;", "final")]
			public Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public TranslationContext(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor;Lcom/sun/tools/javac/tree/JCTree$JCFunctionalExpression;)V", "")]
			public TranslationContext(Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCFunctionalExpression arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$TranslationContext;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Z", "")]
			public bool isSerializable()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "")]
			public bool needsAltMetafactory()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Ljava/lang/String;", "")]
			public Dova.JDK.java.lang.String syntheticMethodNameComponent(Dova.JDK.com.sun.tools.javac.util.Name arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "")]
			public Dova.JDK.java.lang.String enclosingMethodName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$LambdaTranslationContext;", "")]
		public partial class LambdaTranslationContext
			: Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor.TranslationContext
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static LambdaTranslationContext()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$LambdaTranslationContext;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "self", "Lcom/sun/tools/javac/code/Symbol;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "assignedTo", "Lcom/sun/tools/javac/code/Symbol;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "translatedSymbols", "Ljava/util/Map;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "translatedSym", "Lcom/sun/tools/javac/code/Symbol$MethodSymbol;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "syntheticParams", "Lcom/sun/tools/javac/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "freeVarProcessedLocalClasses", "Ljava/util/Set;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodReferenceReceiver", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor;Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lambdaName", "()Lcom/sun/tools/javac/util/Name;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSymbol", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbolMap", "(Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;)Ljava/util/Map;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "serializedLambdaDisambiguation", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "serializedLambdaName", "()Lcom/sun/tools/javac/util/Name;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generatedLambdaSig", "()Lcom/sun/tools/javac/code/Type;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "(Lcom/sun/tools/javac/tree/JCTree$JCIdent;)Lcom/sun/tools/javac/tree/JCTree;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)Lcom/sun/tools/javac/tree/JCTree$JCNewClass;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "(Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;)Lcom/sun/tools/javac/tree/JCTree;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;)Lcom/sun/tools/javac/code/Symbol;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol;", "final")]
			public Dova.JDK.com.sun.tools.javac.code.Symbol self_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol;", "final")]
			public Dova.JDK.com.sun.tools.javac.code.Symbol assignedTo_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/Map;", "")]
			public Dova.JDK.java.util.Map translatedSymbols_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol$MethodSymbol;", "")]
			public Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol translatedSym_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "")]
			public Dova.JDK.com.sun.tools.javac.util.List syntheticParams_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/Set;", "final")]
			public Dova.JDK.java.util.Set freeVarProcessedLocalClasses_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "")]
			public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression methodReferenceReceiver_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor;", "final")]
			public Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public LambdaTranslationContext(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor;Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V", "")]
			public LambdaTranslationContext(Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$LambdaTranslationContext;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Name;", "private")]
			public Dova.JDK.com.sun.tools.javac.util.Name lambdaName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
			}

			[JniSignatureAttribute("()V", "")]
			public void complete()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;)V", "")]
			public void addSymbol(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaSymbolKind arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;)Ljava/util/Map;", "")]
			public Dova.JDK.java.util.Map getSymbolMap(Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaSymbolKind arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "private")]
			public Dova.JDK.java.lang.String serializedLambdaDisambiguation()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Name;", "private")]
			public Dova.JDK.com.sun.tools.javac.util.Name serializedLambdaName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
			}

			[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "")]
			public Dova.JDK.com.sun.tools.javac.code.Type generatedLambdaSig()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCIdent;)Lcom/sun/tools/javac/tree/JCTree;", "")]
			public Dova.JDK.com.sun.tools.javac.tree.JCTree translate(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCIdent arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)Lcom/sun/tools/javac/tree/JCTree$JCNewClass;", "public")]
			public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass translate(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
			public Dova.JDK.com.sun.tools.javac.tree.JCTree translate(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCFieldAccess arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;)Lcom/sun/tools/javac/code/Symbol;", "")]
			public Dova.JDK.com.sun.tools.javac.code.Symbol translate(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaSymbolKind arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$ReferenceTranslationContext;", "final")]
		public partial class ReferenceTranslationContext
			: Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor.TranslationContext
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ReferenceTranslationContext()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$ReferenceTranslationContext;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isSuper", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor;Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isIntersectionOrUnionType", "(Lcom/sun/tools/javac/code/Type;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "interfaceParameterIsIntersectionOrUnionType", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "needsVarArgsConversion", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArrayOp", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrivateInOtherClass", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "receiverAccessible", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "needsConversionToLambda", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generatedRefSig", "()Lcom/sun/tools/javac/code/Type;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bridgedRefSig", "()Lcom/sun/tools/javac/code/Type;"));
			}

			[JniSignatureAttribute("Z", "final")]
			public bool isSuper_Property
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

			[JniSignatureAttribute("Z", "static final")]
			public static bool assertionsDisabled_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor;", "final")]
			public Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ReferenceTranslationContext(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor;Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;)V", "")]
			public ReferenceTranslationContext(Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$ReferenceTranslationContext;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Z", "")]
			public bool isIntersectionOrUnionType(Dova.JDK.com.sun.tools.javac.code.Type arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Z", "")]
			public bool interfaceParameterIsIntersectionOrUnionType()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "")]
			public bool needsVarArgsConversion()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "")]
			public bool isArrayOp()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "")]
			public bool isPrivateInOtherClass()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "")]
			public bool receiverAccessible()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "final")]
			public bool needsConversionToLambda()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
				return ret;
			}

			[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "")]
			public Dova.JDK.com.sun.tools.javac.code.Type generatedRefSig()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}

			[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "")]
			public Dova.JDK.com.sun.tools.javac.code.Type bridgedRefSig()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$KlassInfo;", "private")]
	public partial class KlassInfo
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static KlassInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/LambdaToMethod$KlassInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "appendedMethodList", "Lcom/sun/tools/javac/util/ListBuffer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dedupedLambdas", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dynMethSyms", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "deserializeCases", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "deserMethodSym", "Lcom/sun/tools/javac/code/Symbol$MethodSymbol;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "deserParamSym", "Lcom/sun/tools/javac/code/Symbol$VarSymbol;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clazz", "Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/LambdaToMethod;Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMethod", "(Lcom/sun/tools/javac/tree/JCTree;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/ListBuffer;", "private")]
		public Dova.JDK.com.sun.tools.javac.util.ListBuffer appendedMethodList_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.ListBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private")]
		public Dova.JDK.java.util.Map dedupedLambdas_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private")]
		public Dova.JDK.java.util.Map dynMethSyms_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map deserializeCases_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol$MethodSymbol;", "private final")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol deserMethodSym_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol$VarSymbol;", "private final")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol deserParamSym_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;", "private final")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl clazz_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public KlassInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/LambdaToMethod;Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V", "private")]
		public KlassInfo(Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/LambdaToMethod$KlassInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)V", "private")]
		public void addMethod(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$DedupedLambda;", "")]
	public partial class DedupedLambda
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DedupedLambda()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/LambdaToMethod$DedupedLambda;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "symbol", "Lcom/sun/tools/javac/code/Symbol$MethodSymbol;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tree", "Lcom/sun/tools/javac/tree/JCTree;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/LambdaToMethod;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/LambdaToMethod;Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Lcom/sun/tools/javac/tree/JCTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol$MethodSymbol;", "private final")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol symbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree;", "private final")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree tree_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int hashCode_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DedupedLambda(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/LambdaToMethod;Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Lcom/sun/tools/javac/tree/JCTree;)V", "")]
		public DedupedLambda(Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/LambdaToMethod$DedupedLambda;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;", "static final")]
	public partial class LambdaSymbolKind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LambdaSymbolKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PARAM", "Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOCAL_VAR", "Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CAPTURED_VAR", "Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CAPTURED_THIS", "Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CAPTURED_OUTER_THIS", "Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "propagateAnnotations", "()Z"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaSymbolKind PARAM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaSymbolKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaSymbolKind LOCAL_VAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaSymbolKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaSymbolKind CAPTURED_VAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaSymbolKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaSymbolKind CAPTURED_THIS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaSymbolKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaSymbolKind CAPTURED_OUTER_THIS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaSymbolKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaSymbolKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaSymbolKind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LambdaSymbolKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public LambdaSymbolKind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaSymbolKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaSymbolKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaSymbolKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaSymbolKind>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaSymbolKind;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaSymbolKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaSymbolKind>>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool propagateAnnotations()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$L2MSignatureGenerator;", "private")]
	public partial class L2MSignatureGenerator
		: Dova.JDK.com.sun.tools.javac.code.Types.SignatureGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static L2MSignatureGenerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/LambdaToMethod$L2MSignatureGenerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sb", "Ljava/lang/StringBuilder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allowIllegalSignatures", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/LambdaToMethod;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/LambdaToMethod;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "([B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(Lcom/sun/tools/javac/util/Name;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(C)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reportIllegalSignature", "(Lcom/sun/tools/javac/code/Type;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/StringBuilder;", "")]
		public Dova.JDK.java.lang.StringBuilder sb_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool allowIllegalSignatures_Property
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

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public L2MSignatureGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/LambdaToMethod;Z)V", "")]
		public L2MSignatureGenerator(Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/LambdaToMethod$L2MSignatureGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("([B)V", "protected")]
		public void append(JavaArray<byte> arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)V", "protected")]
		public void append(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(C)V", "protected")]
		public void append(char arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)V", "protected")]
		public void reportIllegalSignature(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$MemberReferenceToLambda;", "private")]
	public partial class MemberReferenceToLambda
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MemberReferenceToLambda()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/LambdaToMethod$MemberReferenceToLambda;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tree", "Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localContext", "Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$ReferenceTranslationContext;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "owner", "Lcom/sun/tools/javac/code/Symbol;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "args", "Lcom/sun/tools/javac/util/ListBuffer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "params", "Lcom/sun/tools/javac/util/ListBuffer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "receiverExpression", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/LambdaToMethod;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/LambdaToMethod;Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$ReferenceTranslationContext;Lcom/sun/tools/javac/code/Symbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lambda", "()Lcom/sun/tools/javac/tree/JCTree$JCLambda;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addParameter", "(Ljava/lang/String;Lcom/sun/tools/javac/code/Type;Z)Lcom/sun/tools/javac/code/Symbol$VarSymbol;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReceiverExpression", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addParametersReturnReceiver", "()Lcom/sun/tools/javac/code/Symbol$VarSymbol;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expressionNew", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeReceiver", "(Lcom/sun/tools/javac/code/Symbol$VarSymbol;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expressionInvoke", "(Lcom/sun/tools/javac/code/Symbol$VarSymbol;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;", "private final")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference tree_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$ReferenceTranslationContext;", "private final")]
		public Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor.ReferenceTranslationContext localContext_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor.ReferenceTranslationContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol;", "private final")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol owner_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/ListBuffer;", "private final")]
		public Dova.JDK.com.sun.tools.javac.util.ListBuffer args_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.ListBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/ListBuffer;", "private final")]
		public Dova.JDK.com.sun.tools.javac.util.ListBuffer @params_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.ListBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "private")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression receiverExpression_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/LambdaToMethod;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MemberReferenceToLambda(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/LambdaToMethod;Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;Lcom/sun/tools/javac/comp/LambdaToMethod$LambdaAnalyzerPreprocessor$ReferenceTranslationContext;Lcom/sun/tools/javac/code/Symbol;)V", "")]
		public MemberReferenceToLambda(Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference arg1, Dova.JDK.com.sun.tools.javac.comp.LambdaToMethod.LambdaAnalyzerPreprocessor.ReferenceTranslationContext arg2, Dova.JDK.com.sun.tools.javac.code.Symbol arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/LambdaToMethod$MemberReferenceToLambda;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCLambda;", "")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda lambda()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/javac/code/Type;Z)Lcom/sun/tools/javac/code/Symbol$VarSymbol;", "private")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol addParameter(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, bool arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getReceiverExpression()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Symbol$VarSymbol;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol addParametersReturnReceiver()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "private")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression expressionNew()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$VarSymbol;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "private")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression makeReceiver(Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$VarSymbol;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "private")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression expressionInvoke(Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}
	}
}
