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

namespace Dova.JDK.java.awt.im;

[JniSignatureAttribute("Ljava/awt/im/InputMethodRequests;", "public abstract interface")]
public partial interface InputMethodRequests
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InputMethodRequests()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/im/InputMethodRequests;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedText", "([Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/text/AttributedCharacterIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTextLocation", "(Ljava/awt/font/TextHitInfo;)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationOffset", "(II)Ljava/awt/font/TextHitInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInsertPositionOffset", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCommittedText", "(II[Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/text/AttributedCharacterIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCommittedTextLength", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cancelLatestCommittedText", "([Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/text/AttributedCharacterIterator;"));
	}

	[JniSignatureAttribute("([Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/text/AttributedCharacterIterator;", "public abstract")]
	Dova.JDK.java.text.AttributedCharacterIterator getSelectedText(JavaArray<Dova.JDK.java.text.AttributedCharacterIterator.Attribute> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.AttributedCharacterIterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/font/TextHitInfo;)Ljava/awt/Rectangle;", "public abstract")]
	Dova.JDK.java.awt.Rectangle getTextLocation(Dova.JDK.java.awt.font.TextHitInfo arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/awt/font/TextHitInfo;", "public abstract")]
	Dova.JDK.java.awt.font.TextHitInfo getLocationOffset(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.font.TextHitInfo>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getInsertPositionOffset()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(II[Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/text/AttributedCharacterIterator;", "public abstract")]
	Dova.JDK.java.text.AttributedCharacterIterator getCommittedText(int arg0, int arg1, JavaArray<Dova.JDK.java.text.AttributedCharacterIterator.Attribute> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.AttributedCharacterIterator>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getCommittedTextLength()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/text/AttributedCharacterIterator;", "public abstract")]
	Dova.JDK.java.text.AttributedCharacterIterator cancelLatestCommittedText(JavaArray<Dova.JDK.java.text.AttributedCharacterIterator.Attribute> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.AttributedCharacterIterator>(ret);
	}
}
