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

namespace Dova.JDK.javax.xml.stream.util;

[JniSignatureAttribute("Ljavax/xml/stream/util/XMLEventAllocator;", "public abstract interface")]
public partial interface XMLEventAllocator
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMLEventAllocator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/xml/stream/util/XMLEventAllocator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newInstance", "()Ljavax/xml/stream/util/XMLEventAllocator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allocate", "(Ljavax/xml/stream/XMLStreamReader;)Ljavax/xml/stream/events/XMLEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allocate", "(Ljavax/xml/stream/XMLStreamReader;Ljavax/xml/stream/util/XMLEventConsumer;)V"));
	}

	[JniSignatureAttribute("()Ljavax/xml/stream/util/XMLEventAllocator;", "public abstract")]
	Dova.JDK.javax.xml.stream.util.XMLEventAllocator newInstance()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.util.XMLEventAllocator>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/XMLStreamReader;)Ljavax/xml/stream/events/XMLEvent;", "public abstract")]
	Dova.JDK.javax.xml.stream.events.XMLEvent allocate(Dova.JDK.javax.xml.stream.XMLStreamReader arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.XMLEvent>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/XMLStreamReader;Ljavax/xml/stream/util/XMLEventConsumer;)V", "public abstract")]
	void allocate(Dova.JDK.javax.xml.stream.XMLStreamReader arg0, Dova.JDK.javax.xml.stream.util.XMLEventConsumer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}
}
