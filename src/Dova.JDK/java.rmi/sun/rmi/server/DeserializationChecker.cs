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

namespace Dova.JDK.sun.rmi.server;

[JniSignatureAttribute("Lsun/rmi/server/DeserializationChecker;", "public abstract interface")]
public partial interface DeserializationChecker
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DeserializationChecker()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/rmi/server/DeserializationChecker;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "end", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "check", "(Ljava/lang/reflect/Method;Ljava/io/ObjectStreamClass;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkProxyClass", "(Ljava/lang/reflect/Method;[Ljava/lang/String;II)V"));
	}

	[JniSignatureAttribute("(I)V", "public")]
	void end(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;Ljava/io/ObjectStreamClass;II)V", "public abstract")]
	void check(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.java.io.ObjectStreamClass arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;[Ljava/lang/String;II)V", "public abstract")]
	void checkProxyClass(Dova.JDK.java.lang.reflect.Method arg0, JavaArray<Dova.JDK.java.lang.String> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}
}
