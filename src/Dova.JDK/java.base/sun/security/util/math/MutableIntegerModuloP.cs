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
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/util/math/MutableIntegerModuloP;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setValue", "([BIIB)Lsun/security/util/math/MutableIntegerModuloP;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setValue", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setValue", "(Ljava/nio/ByteBuffer;IB)Lsun/security/util/math/MutableIntegerModuloP;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "conditionalSwapWith", "(Lsun/security/util/math/MutableIntegerModuloP;I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setProduct", "(Lsun/security/util/math/SmallValue;)Lsun/security/util/math/MutableIntegerModuloP;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setProduct", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setAdditiveInverse", "()Lsun/security/util/math/MutableIntegerModuloP;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "conditionalSet", "(Lsun/security/util/math/IntegerModuloP;I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setSum", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setSquare", "()Lsun/security/util/math/MutableIntegerModuloP;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setDifference", "(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setReduced", "()Lsun/security/util/math/MutableIntegerModuloP;"));
	}

	[JniSignatureAttribute("([BIIB)Lsun/security/util/math/MutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.MutableIntegerModuloP setValue(JavaArray<byte> arg0, int arg1, int arg2, byte arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.MutableIntegerModuloP setValue(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;IB)Lsun/security/util/math/MutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.MutableIntegerModuloP setValue(Dova.JDK.java.nio.ByteBuffer arg0, int arg1, byte arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/util/math/MutableIntegerModuloP;I)V", "public abstract")]
	void conditionalSwapWith(Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/security/util/math/SmallValue;)Lsun/security/util/math/MutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.MutableIntegerModuloP setProduct(Dova.JDK.sun.security.util.math.SmallValue arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.MutableIntegerModuloP setProduct(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/MutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.MutableIntegerModuloP setAdditiveInverse()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;I)V", "public abstract")]
	void conditionalSet(Dova.JDK.sun.security.util.math.IntegerModuloP arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.MutableIntegerModuloP setSum(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/MutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.MutableIntegerModuloP setSquare()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;)Lsun/security/util/math/MutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.MutableIntegerModuloP setDifference(Dova.JDK.sun.security.util.math.IntegerModuloP arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/MutableIntegerModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.MutableIntegerModuloP setReduced()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.MutableIntegerModuloP>(ret);
	}
}
