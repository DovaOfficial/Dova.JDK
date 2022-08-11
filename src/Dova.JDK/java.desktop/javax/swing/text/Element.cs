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

namespace Dova.JDK.javax.swing.text;

[JniSignatureAttribute("Ljavax/swing/text/Element;", "public abstract interface")]
public partial interface Element
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Element()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/Element;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "()Ljavax/swing/text/AttributeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLeaf", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElement", "(I)Ljavax/swing/text/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocument", "()Ljavax/swing/text/Document;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementIndex", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParentElement", "()Ljavax/swing/text/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndOffset", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartOffset", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementCount", "()I"));
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/AttributeSet;", "public abstract")]
	Dova.JDK.javax.swing.text.AttributeSet getAttributes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isLeaf()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljavax/swing/text/Element;", "public abstract")]
	Dova.JDK.javax.swing.text.Element getElement(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/Document;", "public abstract")]
	Dova.JDK.javax.swing.text.Document getDocument()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Document>(ret);
	}

	[JniSignatureAttribute("(I)I", "public abstract")]
	int getElementIndex(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/text/Element;", "public abstract")]
	Dova.JDK.javax.swing.text.Element getParentElement()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getEndOffset()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getStartOffset()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getElementCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}
}
