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

namespace Dova.JDK.sun.nio.cs;

[JniSignatureAttribute("Lsun/nio/cs/ArrayEncoder;", "public abstract interface")]
public partial interface ArrayEncoder
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ArrayEncoder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/cs/ArrayEncoder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isASCIICompatible", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeFromLatin1", "([BII[B)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeFromUTF16", "([BII[B)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encode", "([CII[B)I"));
	}

	[JniSignatureAttribute("()Z", "public")]
	bool isASCIICompatible()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("([BII[B)I", "public")]
	int encodeFromLatin1(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([BII[B)I", "public")]
	int encodeFromUTF16(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([CII[B)I", "public abstract")]
	int encode(JavaArray<char> arg0, int arg1, int arg2, JavaArray<byte> arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return ret;
	}
}
