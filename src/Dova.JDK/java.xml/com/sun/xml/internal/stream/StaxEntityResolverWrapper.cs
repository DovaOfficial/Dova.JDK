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

namespace Dova.JDK.com.sun.xml.@internal.stream;

[JniSignatureAttribute("Lcom/sun/xml/internal/stream/StaxEntityResolverWrapper;", "public")]
public partial class StaxEntityResolverWrapper
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StaxEntityResolverWrapper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/xml/internal/stream/StaxEntityResolverWrapper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fStaxResolver", "Ljavax/xml/stream/XMLResolver;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/xml/stream/XMLResolver;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveEntity", "(Lcom/sun/org/apache/xerces/internal/xni/XMLResourceIdentifier;)Lcom/sun/xml/internal/stream/StaxXMLInputSource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStaxInputSource", "(Ljava/lang/Object;)Lcom/sun/xml/internal/stream/StaxXMLInputSource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStaxEntityResolver", "(Ljavax/xml/stream/XMLResolver;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStaxEntityResolver", "()Ljavax/xml/stream/XMLResolver;"));
	}

	[JniSignatureAttribute("Ljavax/xml/stream/XMLResolver;", "")]
	public Dova.JDK.javax.xml.stream.XMLResolver fStaxResolver_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLResolver>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StaxEntityResolverWrapper(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/XMLResolver;)V", "public")]
	public StaxEntityResolverWrapper(Dova.JDK.javax.xml.stream.XMLResolver arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/xml/internal/stream/StaxEntityResolverWrapper;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLResourceIdentifier;)Lcom/sun/xml/internal/stream/StaxXMLInputSource;", "public")]
	public Dova.JDK.com.sun.xml.@internal.stream.StaxXMLInputSource resolveEntity(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLResourceIdentifier arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.xml.@internal.stream.StaxXMLInputSource>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Lcom/sun/xml/internal/stream/StaxXMLInputSource;", "")]
	public Dova.JDK.com.sun.xml.@internal.stream.StaxXMLInputSource getStaxInputSource(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.xml.@internal.stream.StaxXMLInputSource>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/XMLResolver;)V", "public")]
	public void setStaxEntityResolver(Dova.JDK.javax.xml.stream.XMLResolver arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Ljavax/xml/stream/XMLResolver;", "public")]
	public Dova.JDK.javax.xml.stream.XMLResolver getStaxEntityResolver()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLResolver>(ret);
	}
}
