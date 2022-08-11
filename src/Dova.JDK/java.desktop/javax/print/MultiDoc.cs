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

namespace Dova.JDK.javax.print;

[JniSignatureAttribute("Ljavax/print/MultiDoc;", "public abstract interface")]
public partial interface MultiDoc
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MultiDoc()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/print/MultiDoc;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next", "()Ljavax/print/MultiDoc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDoc", "()Ljavax/print/Doc;"));
	}

	[JniSignatureAttribute("()Ljavax/print/MultiDoc;", "public abstract")]
	Dova.JDK.javax.print.MultiDoc next()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.print.MultiDoc>(ret);
	}

	[JniSignatureAttribute("()Ljavax/print/Doc;", "public abstract")]
	Dova.JDK.javax.print.Doc getDoc()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.print.Doc>(ret);
	}
}
