/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.xml.@internal.stream.events;

[JniSignatureAttribute("Lcom/sun/xml/internal/stream/events/XMLEventAllocatorImpl;", "public")]
public partial class XMLEventAllocatorImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.xml.stream.util.XMLEventAllocator
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMLEventAllocatorImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/xml/internal/stream/events/XMLEventAllocatorImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "XMLEventAllocatorImpl", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newInstance", "()Ljavax/xml/stream/util/XMLEventAllocator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "allocate", "(Ljavax/xml/stream/XMLStreamReader;Ljavax/xml/stream/util/XMLEventConsumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "allocate", "(Ljavax/xml/stream/XMLStreamReader;)Ljavax/xml/stream/events/XMLEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setNamespaceContext", "(Lcom/sun/xml/internal/stream/events/StartElementEvent;Ljavax/xml/stream/XMLStreamReader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getQName", "(Ljavax/xml/stream/XMLStreamReader;)Ljavax/xml/namespace/QName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNextEvent", "(Ljavax/xml/stream/XMLStreamReader;)Ljavax/xml/stream/events/XMLEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getXMLEvent", "(Ljavax/xml/stream/XMLStreamReader;)Ljavax/xml/stream/events/XMLEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fillAttributes", "(Lcom/sun/xml/internal/stream/events/StartElementEvent;Ljavax/xml/stream/XMLStreamReader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fillNamespaceAttributes", "(Lcom/sun/xml/internal/stream/events/StartElementEvent;Ljavax/xml/stream/XMLStreamReader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fillNamespaceAttributes", "(Lcom/sun/xml/internal/stream/events/EndElementEvent;Ljavax/xml/stream/XMLStreamReader;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XMLEventAllocatorImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XMLEventAllocatorImpl() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/xml/internal/stream/events/XMLEventAllocatorImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/xml/stream/util/XMLEventAllocator;", "public")]
	public Dova.JDK.javax.xml.stream.util.XMLEventAllocator newInstance()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.util.XMLEventAllocator>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/XMLStreamReader;Ljavax/xml/stream/util/XMLEventConsumer;)V", "public")]
	public void allocate(Dova.JDK.javax.xml.stream.XMLStreamReader arg0, Dova.JDK.javax.xml.stream.util.XMLEventConsumer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/XMLStreamReader;)Ljavax/xml/stream/events/XMLEvent;", "public")]
	public Dova.JDK.javax.xml.stream.events.XMLEvent allocate(Dova.JDK.javax.xml.stream.XMLStreamReader arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.XMLEvent>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/xml/internal/stream/events/StartElementEvent;Ljavax/xml/stream/XMLStreamReader;)V", "private")]
	public void setNamespaceContext(Dova.JDK.com.sun.xml.@internal.stream.events.StartElementEvent arg0, Dova.JDK.javax.xml.stream.XMLStreamReader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/XMLStreamReader;)Ljavax/xml/namespace/QName;", "private")]
	public Dova.JDK.javax.xml.@namespace.QName getQName(Dova.JDK.javax.xml.stream.XMLStreamReader arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.@namespace.QName>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/XMLStreamReader;)Ljavax/xml/stream/events/XMLEvent;", "protected")]
	public Dova.JDK.javax.xml.stream.events.XMLEvent getNextEvent(Dova.JDK.javax.xml.stream.XMLStreamReader arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.XMLEvent>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/XMLStreamReader;)Ljavax/xml/stream/events/XMLEvent;", "")]
	public Dova.JDK.javax.xml.stream.events.XMLEvent getXMLEvent(Dova.JDK.javax.xml.stream.XMLStreamReader arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.XMLEvent>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/xml/internal/stream/events/StartElementEvent;Ljavax/xml/stream/XMLStreamReader;)V", "protected")]
	public void fillAttributes(Dova.JDK.com.sun.xml.@internal.stream.events.StartElementEvent arg0, Dova.JDK.javax.xml.stream.XMLStreamReader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/xml/internal/stream/events/StartElementEvent;Ljavax/xml/stream/XMLStreamReader;)V", "protected")]
	public void fillNamespaceAttributes(Dova.JDK.com.sun.xml.@internal.stream.events.StartElementEvent arg0, Dova.JDK.javax.xml.stream.XMLStreamReader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/xml/internal/stream/events/EndElementEvent;Ljavax/xml/stream/XMLStreamReader;)V", "protected")]
	public void fillNamespaceAttributes(Dova.JDK.com.sun.xml.@internal.stream.events.EndElementEvent arg0, Dova.JDK.javax.xml.stream.XMLStreamReader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}
}
