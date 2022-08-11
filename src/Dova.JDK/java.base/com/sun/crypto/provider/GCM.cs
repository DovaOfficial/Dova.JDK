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

namespace Dova.JDK.com.sun.crypto.provider;

[JniSignatureAttribute("Lcom/sun/crypto/provider/GCM;", "public abstract interface")]
public partial interface GCM
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GCM()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/GCM;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "([BIILjava/nio/ByteBuffer;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "([BII[BI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doFinal", "([BII[BI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doFinal", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I"));
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I", "public abstract")]
	int update(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.nio.ByteBuffer arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([BIILjava/nio/ByteBuffer;)I", "public abstract")]
	int update(JavaArray<byte> arg0, int arg1, int arg2, Dova.JDK.java.nio.ByteBuffer arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([BII[BI)I", "public abstract")]
	int update(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("([BII[BI)I", "public abstract")]
	int doFinal(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I", "public abstract")]
	int doFinal(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.nio.ByteBuffer arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}
}
