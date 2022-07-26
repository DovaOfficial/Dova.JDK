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

namespace Dova.JDK.sun.java2d.pipe;

[JniSignatureAttribute("Lsun/java2d/pipe/AATileGenerator;", "public abstract interface")]
public partial interface AATileGenerator
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AATileGenerator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/pipe/AATileGenerator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypicalAlpha", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextTile", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAlpha", "([BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTileWidth", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTileHeight", "()I"));
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getTypicalAlpha()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void nextTile()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("([BII)V", "public abstract")]
	void getAlpha(JavaArray<byte> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getTileWidth()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getTileHeight()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}
}
