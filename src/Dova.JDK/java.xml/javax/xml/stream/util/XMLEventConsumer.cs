/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
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

[JniSignatureAttribute("Ljavax/xml/stream/util/XMLEventConsumer;", "public abstract interface")]
public partial interface XMLEventConsumer
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMLEventConsumer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/xml/stream/util/XMLEventConsumer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "add", "(Ljavax/xml/stream/events/XMLEvent;)V"));
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/events/XMLEvent;)V", "public abstract")]
	void add(Dova.JDK.javax.xml.stream.events.XMLEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}
