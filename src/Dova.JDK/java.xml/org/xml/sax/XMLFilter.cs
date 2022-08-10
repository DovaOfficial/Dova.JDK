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

namespace Dova.JDK.org.xml.sax;

[JniSignatureAttribute("Lorg/xml/sax/XMLFilter;", "public abstract interface")]
public partial interface XMLFilter
	: IJavaObject
	, Dova.JDK.org.xml.sax.XMLReader
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMLFilter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/xml/sax/XMLFilter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getParent", "()Lorg/xml/sax/XMLReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setParent", "(Lorg/xml/sax/XMLReader;)V"));
	}

	[JniSignatureAttribute("()Lorg/xml/sax/XMLReader;", "public abstract")]
	Dova.JDK.org.xml.sax.XMLReader getParent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.xml.sax.XMLReader>(ret);
	}

	[JniSignatureAttribute("(Lorg/xml/sax/XMLReader;)V", "public abstract")]
	void setParent(Dova.JDK.org.xml.sax.XMLReader arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}
