/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.@internal.net.http.hpack;

[JniSignatureAttribute("Ljdk/internal/net/http/hpack/DecodingCallback;", "public abstract interface")]
public partial interface DecodingCallback
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DecodingCallback()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/net/http/hpack/DecodingCallback;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "onDecoded", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "onDecoded", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "onIndexed", "(ILjava/lang/CharSequence;Ljava/lang/CharSequence;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "onLiteral", "(Ljava/lang/CharSequence;ZLjava/lang/CharSequence;Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "onLiteral", "(ILjava/lang/CharSequence;Ljava/lang/CharSequence;Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "onLiteralNeverIndexed", "(Ljava/lang/CharSequence;ZLjava/lang/CharSequence;Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "onLiteralNeverIndexed", "(ILjava/lang/CharSequence;Ljava/lang/CharSequence;Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "onLiteralWithIndexing", "(Ljava/lang/CharSequence;ZLjava/lang/CharSequence;Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "onLiteralWithIndexing", "(ILjava/lang/CharSequence;Ljava/lang/CharSequence;Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "onSizeUpdate", "(I)V"));
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)V", "public abstract")]
	void onDecoded(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.java.lang.CharSequence arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)V", "public")]
	void onDecoded(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.java.lang.CharSequence arg1, bool arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/lang/CharSequence;Ljava/lang/CharSequence;)V", "public")]
	void onIndexed(int arg0, Dova.JDK.java.lang.CharSequence arg1, Dova.JDK.java.lang.CharSequence arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;ZLjava/lang/CharSequence;Z)V", "public")]
	void onLiteral(Dova.JDK.java.lang.CharSequence arg0, bool arg1, Dova.JDK.java.lang.CharSequence arg2, bool arg3)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILjava/lang/CharSequence;Ljava/lang/CharSequence;Z)V", "public")]
	void onLiteral(int arg0, Dova.JDK.java.lang.CharSequence arg1, Dova.JDK.java.lang.CharSequence arg2, bool arg3)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;ZLjava/lang/CharSequence;Z)V", "public")]
	void onLiteralNeverIndexed(Dova.JDK.java.lang.CharSequence arg0, bool arg1, Dova.JDK.java.lang.CharSequence arg2, bool arg3)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILjava/lang/CharSequence;Ljava/lang/CharSequence;Z)V", "public")]
	void onLiteralNeverIndexed(int arg0, Dova.JDK.java.lang.CharSequence arg1, Dova.JDK.java.lang.CharSequence arg2, bool arg3)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;ZLjava/lang/CharSequence;Z)V", "public")]
	void onLiteralWithIndexing(Dova.JDK.java.lang.CharSequence arg0, bool arg1, Dova.JDK.java.lang.CharSequence arg2, bool arg3)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILjava/lang/CharSequence;Ljava/lang/CharSequence;Z)V", "public")]
	void onLiteralWithIndexing(int arg0, Dova.JDK.java.lang.CharSequence arg1, Dova.JDK.java.lang.CharSequence arg2, bool arg3)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(I)V", "public")]
	void onSizeUpdate(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}
}
