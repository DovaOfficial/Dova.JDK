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

namespace Dova.JDK.sun.security.util.math;

[JniSignatureAttribute("Lsun/security/util/math/MutableIntegerModuloP;", "public abstract interface")]
public partial interface MutableIntegerModuloP
	: IJavaObject
	, Dova.JDK.sun.security.util.math.IntegerModuloP
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MutableIntegerModuloP()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/util/math/MutableIntegerModuloP;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "([BIIB)Lsun/security/util/math/MutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "(Ljava/nio/ByteBuffer;IB)Lsun/security/util/math/MutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "conditionalSwapWith", "(Lsun/security/util/math/MutableIntegerModuloP;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setProduct", "(Lsun/security/util/math/SmallValue;)Lsun/security/util/math/MutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setProduct", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAdditiveInverse", "()Lsun/security/util/math/MutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "conditionalSet", "(Lsun/security/util/math/IntegerModuloP;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSum", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSquare", "()Lsun/security/util/math/MutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDifference", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setReduced", "()Lsun/security/util/math/MutableIntegerModuloP;"));
	}

	[JniSignatureAttribute("([BIIB)Lsun/security/util/math/MutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.MutableIntegerModuloP setValue(JavaArray<byte> arg0, int arg1, int arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.MutableIntegerModuloP setValue(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;IB)Lsun/security/util/math/MutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.MutableIntegerModuloP setValue(Dova.JDK.java.nio.ByteBuffer arg0, int arg1, byte arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/util/math/MutableIntegerModuloP;I)V", "public abstract")]
	void conditionalSwapWith(Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/security/util/math/SmallValue;)Lsun/security/util/math/MutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.MutableIntegerModuloP setProduct(Dova.JDK.sun.security.util.math.SmallValue arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.MutableIntegerModuloP setProduct(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/MutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.MutableIntegerModuloP setAdditiveInverse()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;I)V", "public abstract")]
	void conditionalSet(Dova.JDK.sun.security.util.math.IntegerModuloP arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.MutableIntegerModuloP setSum(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/MutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.MutableIntegerModuloP setSquare()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.MutableIntegerModuloP setDifference(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/MutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.MutableIntegerModuloP setReduced()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
	}
}
