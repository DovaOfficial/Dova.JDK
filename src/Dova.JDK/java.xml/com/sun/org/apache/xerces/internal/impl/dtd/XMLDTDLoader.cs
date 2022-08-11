/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:58)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLDTDLoader;", "public")]
public partial class XMLDTDLoader
	: Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.XMLDTDProcessor
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarLoader
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMLDTDLoader()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLDTDLoader;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STANDARD_URI_CONFORMANT_FEATURE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BALANCE_SYNTAX_TREES", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOADER_RECOGNIZED_FEATURES", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ERROR_HANDLER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENTITY_RESOLVER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOCALE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOADER_RECOGNIZED_PROPERTIES", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fStrictURI", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fBalanceSyntaxTrees", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fEntityResolver", "Lcom/sun/org/apache/xerces/internal/xni/parser/XMLEntityResolver;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDTDScanner", "Lcom/sun/org/apache/xerces/internal/impl/XMLDTDScannerImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fEntityManager", "Lcom/sun/org/apache/xerces/internal/impl/XMLEntityManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fLocale", "Ljava/util/Locale;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/util/SymbolTable;Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarPool;Lcom/sun/org/apache/xerces/internal/impl/XMLErrorReporter;Lcom/sun/org/apache/xerces/internal/xni/parser/XMLEntityResolver;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/util/SymbolTable;Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarPool;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/util/SymbolTable;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocale", "()Ljava/util/Locale;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocale", "(Ljava/util/Locale;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDTDScanner", "(Lcom/sun/org/apache/xerces/internal/util/SymbolTable;Lcom/sun/org/apache/xerces/internal/impl/XMLErrorReporter;Lcom/sun/org/apache/xerces/internal/impl/XMLEntityManager;)Lcom/sun/org/apache/xerces/internal/impl/XMLDTDScannerImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScannerVersion", "()S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadGrammarWithContext", "(Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLDTDValidator;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEntityResolver", "(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLEntityResolver;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setErrorHandler", "(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLErrorHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecognizedFeatures", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecognizedProperties", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getErrorHandler", "()Lcom/sun/org/apache/xerces/internal/xni/parser/XMLErrorHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFeature", "(Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEntityResolver", "()Lcom/sun/org/apache/xerces/internal/xni/parser/XMLEntityResolver;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadGrammar", "(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLInputSource;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFeature", "(Ljava/lang/String;)Z"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String STANDARD_URI_CONFORMANT_FEATURE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String BALANCE_SYNTAX_TREES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> LOADER_RECOGNIZED_FEATURES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String ERROR_HANDLER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String ENTITY_RESOLVER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String LOCALE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> LOADER_RECOGNIZED_PROPERTIES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fStrictURI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fBalanceSyntaxTrees_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/parser/XMLEntityResolver;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLEntityResolver fEntityResolver_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLEntityResolver>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/XMLDTDScannerImpl;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLDTDScannerImpl fDTDScanner_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLDTDScannerImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/XMLEntityManager;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLEntityManager fEntityManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLEntityManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Locale;", "protected")]
	public Dova.JDK.java.util.Locale fLocale_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XMLDTDLoader(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/util/SymbolTable;Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarPool;Lcom/sun/org/apache/xerces/internal/impl/XMLErrorReporter;Lcom/sun/org/apache/xerces/internal/xni/parser/XMLEntityResolver;)V", "")]
	public XMLDTDLoader(Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarPool arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLErrorReporter arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLEntityResolver arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/util/SymbolTable;Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarPool;)V", "public")]
	public XMLDTDLoader(Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarPool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/util/SymbolTable;)V", "public")]
	public XMLDTDLoader(Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XMLDTDLoader() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLDTDLoader;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getProperty(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void setProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void reset()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()Ljava/util/Locale;", "public")]
	public Dova.JDK.java.util.Locale getLocale()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)V", "public")]
	public void setLocale(Dova.JDK.java.util.Locale arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/util/SymbolTable;Lcom/sun/org/apache/xerces/internal/impl/XMLErrorReporter;Lcom/sun/org/apache/xerces/internal/impl/XMLEntityManager;)Lcom/sun/org/apache/xerces/internal/impl/XMLDTDScannerImpl;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLDTDScannerImpl createDTDScanner(Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLErrorReporter arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLEntityManager arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLDTDScannerImpl>(ret);
	}

	[JniSignatureAttribute("()S", "protected")]
	public short getScannerVersion()
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dtd/XMLDTDValidator;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void loadGrammarWithContext(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.XMLDTDValidator arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLEntityResolver;)V", "public")]
	public void setEntityResolver(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLEntityResolver arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLErrorHandler;)V", "public")]
	public void setErrorHandler(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLErrorHandler arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getRecognizedFeatures()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getRecognizedProperties()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xni/parser/XMLErrorHandler;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLErrorHandler getErrorHandler()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLErrorHandler>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)V", "public")]
	public void setFeature(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xni/parser/XMLEntityResolver;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLEntityResolver getEntityResolver()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLEntityResolver>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLInputSource;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar loadGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLInputSource arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool getFeature(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}
}
