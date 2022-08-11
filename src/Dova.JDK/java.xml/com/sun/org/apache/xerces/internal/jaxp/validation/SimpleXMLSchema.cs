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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/jaxp/validation/SimpleXMLSchema;", "final")]
public partial class SimpleXMLSchema
	: Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation.AbstractXMLSchema
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarPool
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SimpleXMLSchema()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/jaxp/validation/SimpleXMLSchema;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ZERO_LENGTH_GRAMMAR_ARRAY", "[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGrammar", "Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGrammars", "[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGrammarDescription", "Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "retrieveInitialGrammarSet", "(Ljava/lang/String;)[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cacheGrammars", "(Ljava/lang/String;[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "retrieveGrammar", "(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lockPool", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unlockPool", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGrammarPool", "()Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarPool;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFullyComposed", "()Z"));
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "private static final")]
	public static JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar> ZERO_LENGTH_GRAMMAR_ARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar fGrammar_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar> fGrammars_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription fGrammarDescription_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SimpleXMLSchema(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;)V", "public")]
	public SimpleXMLSchema(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/jaxp/validation/SimpleXMLSchema;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void clear()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "public")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar> retrieveInitialGrammarSet(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;)V", "public")]
	public void cacheGrammars(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarDescription;)Lcom/sun/org/apache/xerces/internal/xni/grammars/Grammar;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar retrieveGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarDescription arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.Grammar>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void lockPool()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void unlockPool()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xni/grammars/XMLGrammarPool;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarPool getGrammarPool()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLGrammarPool>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isFullyComposed()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}
}
