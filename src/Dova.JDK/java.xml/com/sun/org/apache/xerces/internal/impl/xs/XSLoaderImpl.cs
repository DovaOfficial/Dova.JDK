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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSLoaderImpl;", "public final")]
public partial class XSLoaderImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSLoader
	, Dova.JDK.org.w3c.dom.DOMConfiguration
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XSLoaderImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/XSLoaderImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGrammarPool", "Lcom/sun/org/apache/xerces/internal/impl/xs/util/XSGrammarPool;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSchemaLoader", "Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaLoader;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(Lorg/w3c/dom/ls/LSInput;)Lcom/sun/org/apache/xerces/internal/xs/XSModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConfig", "()Lorg/w3c/dom/DOMConfiguration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadInputList", "(Lcom/sun/org/apache/xerces/internal/xs/LSInputList;)Lcom/sun/org/apache/xerces/internal/xs/XSModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadURI", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadURIList", "(Lcom/sun/org/apache/xerces/internal/xs/StringList;)Lcom/sun/org/apache/xerces/internal/xs/XSModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canSetParameter", "(Ljava/lang/String;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterNames", "()Lorg/w3c/dom/DOMStringList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V"));
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/util/XSGrammarPool;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.XSGrammarPool fGrammarPool_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.XSGrammarPool>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XMLSchemaLoader;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaLoader fSchemaLoader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XMLSchemaLoader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XSLoaderImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XSLoaderImpl() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/XSLoaderImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lorg/w3c/dom/ls/LSInput;)Lcom/sun/org/apache/xerces/internal/xs/XSModel;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel load(Dova.JDK.org.w3c.dom.ls.LSInput arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel>(ret);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/DOMConfiguration;", "public")]
	public Dova.JDK.org.w3c.dom.DOMConfiguration getConfig()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.DOMConfiguration>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/LSInputList;)Lcom/sun/org/apache/xerces/internal/xs/XSModel;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel loadInputList(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.LSInputList arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSModel;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel loadURI(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/StringList;)Lcom/sun/org/apache/xerces/internal/xs/XSModel;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel loadURIList(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.StringList arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)Z", "public")]
	public bool canSetParameter(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/DOMStringList;", "public")]
	public Dova.JDK.org.w3c.dom.DOMStringList getParameterNames()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.DOMStringList>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getParameter(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void setParameter(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSLoaderImpl$XSGrammarMerger;", "private static final")]
	public partial class XSGrammarMerger
		: Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.XSGrammarPool
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XSGrammarMerger()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/XSLoaderImpl$XSGrammarMerger;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toSchemaGrammar", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;)Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeSchemaGrammars", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putGrammar", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGrammar", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsGrammar", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "retrieveInitialGrammarSet", "(Ljava/lang/String;)[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "retrieveGrammar", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XSGrammarMerger(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public XSGrammarMerger() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/XSLoaderImpl$XSGrammarMerger;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;)Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;", "private")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar toSchemaGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V", "private")]
		public void mergeSchemaGrammars(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;)V", "public")]
		public void putGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar getGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Z", "public")]
		public bool containsGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "public")]
		public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar> retrieveInitialGrammarSet(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar retrieveGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>(ret);
		}
	}
}
