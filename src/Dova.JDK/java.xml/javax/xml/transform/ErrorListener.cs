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

namespace Dova.JDK.javax.xml.transform;

[JniSignatureAttribute("Ljavax/xml/transform/ErrorListener;", "public abstract interface")]
public partial interface ErrorListener
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ErrorListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/xml/transform/ErrorListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "error", "(Ljavax/xml/transform/TransformerException;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "warning", "(Ljavax/xml/transform/TransformerException;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fatalError", "(Ljavax/xml/transform/TransformerException;)V"));
	}

	[JniSignatureAttribute("(Ljavax/xml/transform/TransformerException;)V", "public abstract")]
	void error(Dova.JDK.javax.xml.transform.TransformerException arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljavax/xml/transform/TransformerException;)V", "public abstract")]
	void warning(Dova.JDK.javax.xml.transform.TransformerException arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljavax/xml/transform/TransformerException;)V", "public abstract")]
	void fatalError(Dova.JDK.javax.xml.transform.TransformerException arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}
}
