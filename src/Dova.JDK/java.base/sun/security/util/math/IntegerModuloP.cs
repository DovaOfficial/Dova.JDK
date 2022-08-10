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

[JniSignatureAttribute("Lsun/security/util/math/IntegerModuloP;", "public abstract interface")]
public partial interface IntegerModuloP
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static IntegerModuloP()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/util/math/IntegerModuloP;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "add", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/ImmutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pow", "(Ljava/math/BigInteger;)Lsun/security/util/math/ImmutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getField", "()Lsun/security/util/math/IntegerFieldModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fixed", "()Lsun/security/util/math/ImmutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "multiply", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/ImmutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "subtract", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/ImmutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "square", "()Lsun/security/util/math/ImmutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "asByteArray", "([B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "asByteArray", "(I)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addModPowerTwo", "(Lsun/security/util/math/IntegerModuloP;I)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addModPowerTwo", "(Lsun/security/util/math/IntegerModuloP;[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "asBigInteger", "()Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "multiplicativeInverse", "()Lsun/security/util/math/ImmutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "additiveInverse", "()Lsun/security/util/math/ImmutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mutable", "()Lsun/security/util/math/MutableIntegerModuloP;"));
	}

	[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/ImmutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP add(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("(Ljava/math/BigInteger;)Lsun/security/util/math/ImmutableIntegerModuloP;", "public")]
	Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP pow(Dova.JDK.java.math.BigInteger arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/IntegerFieldModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.IntegerFieldModuloP getField()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.IntegerFieldModuloP>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/ImmutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP @fixed()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/ImmutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP multiply(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/ImmutableIntegerModuloP;", "public")]
	Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP subtract(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/ImmutableIntegerModuloP;", "public")]
	Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP square()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("([B)V", "public abstract")]
	void asByteArray(JavaArray<byte> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(I)[B", "public")]
	JavaArray<byte> asByteArray(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;I)[B", "public")]
	JavaArray<byte> addModPowerTwo(Dova.JDK.sun.security.util.math.IntegerModuloP arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;[B)V", "public abstract")]
	void addModPowerTwo(Dova.JDK.sun.security.util.math.IntegerModuloP arg0, JavaArray<byte> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/math/BigInteger;", "public abstract")]
	Dova.JDK.java.math.BigInteger asBigInteger()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/ImmutableIntegerModuloP;", "public")]
	Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP multiplicativeInverse()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/ImmutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP additiveInverse()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/MutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.MutableIntegerModuloP mutable()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
	}
}
