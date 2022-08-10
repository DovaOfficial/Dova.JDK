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

namespace Dova.JDK.sun.security.util.math;

[JniSignatureAttribute("Lsun/security/util/math/IntegerFieldModuloP;", "public abstract interface")]
public partial interface IntegerFieldModuloP
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static IntegerFieldModuloP()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/util/math/IntegerFieldModuloP;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSize", "()Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "get0", "()Lsun/security/util/math/ImmutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getElement", "([B)Lsun/security/util/math/ImmutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getElement", "(Ljava/math/BigInteger;)Lsun/security/util/math/ImmutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getElement", "([BIIB)Lsun/security/util/math/ImmutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSmallValue", "(I)Lsun/security/util/math/SmallValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "get1", "()Lsun/security/util/math/ImmutableIntegerModuloP;"));
	}

	[JniSignatureAttribute("()Ljava/math/BigInteger;", "public abstract")]
	Dova.JDK.java.math.BigInteger getSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/ImmutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP get0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("([B)Lsun/security/util/math/ImmutableIntegerModuloP;", "public")]
	Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP getElement(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("(Ljava/math/BigInteger;)Lsun/security/util/math/ImmutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP getElement(Dova.JDK.java.math.BigInteger arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("([BIIB)Lsun/security/util/math/ImmutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP getElement(JavaArray<byte> arg0, int arg1, int arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("(I)Lsun/security/util/math/SmallValue;", "public abstract")]
	Dova.JDK.sun.security.util.math.SmallValue getSmallValue(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.SmallValue>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/ImmutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP get1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
	}
}
