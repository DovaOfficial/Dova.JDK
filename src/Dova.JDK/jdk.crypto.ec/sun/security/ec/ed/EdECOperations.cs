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

namespace Dova.JDK.sun.security.ec.ed;

[JniSignatureAttribute("Lsun/security/ec/ed/EdECOperations;", "public abstract")]
public partial class EdECOperations
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EdECOperations()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/ec/ed/EdECOperations;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "EdECOperations", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "of", "(Lsun/security/ec/point/AffinePoint;)Lsun/security/ec/point/ImmutablePoint;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setDouble", "(Lsun/security/ec/point/MutablePoint;Lsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;)Lsun/security/ec/point/MutablePoint;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "basePointMultiply", "([B)Lsun/security/ec/point/Point;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "decodeAffinePoint", "(Ljava/util/function/Function;ILsun/security/util/math/IntegerModuloP;)Lsun/security/ec/point/AffinePoint;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setProduct", "(Lsun/security/ec/point/MutablePoint;[B)Lsun/security/ec/point/MutablePoint;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setSum", "(Lsun/security/ec/point/MutablePoint;Lsun/security/ec/point/MutablePoint;)Lsun/security/ec/point/MutablePoint;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setSum", "(Lsun/security/ec/point/MutablePoint;Lsun/security/ec/point/MutablePoint;Lsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;)Lsun/security/ec/point/MutablePoint;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNeutral", "()Lsun/security/ec/point/ImmutablePoint;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "bitAt", "([BI)I"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public EdECOperations(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public EdECOperations() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ec/ed/EdECOperations;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/security/ec/point/AffinePoint;)Lsun/security/ec/point/ImmutablePoint;", "public abstract")]
	public Dova.JDK.sun.security.ec.point.ImmutablePoint of(Dova.JDK.sun.security.ec.point.AffinePoint arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.ImmutablePoint>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ec/point/MutablePoint;Lsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;)Lsun/security/ec/point/MutablePoint;", "protected abstract")]
	public Dova.JDK.sun.security.ec.point.MutablePoint setDouble(Dova.JDK.sun.security.ec.point.MutablePoint arg0, Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg1, Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.MutablePoint>(ret);
	}

	[JniSignatureAttribute("([B)Lsun/security/ec/point/Point;", "public abstract")]
	public Dova.JDK.sun.security.ec.point.Point basePointMultiply(JavaArray<byte> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.Point>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;ILsun/security/util/math/IntegerModuloP;)Lsun/security/ec/point/AffinePoint;", "public abstract")]
	public Dova.JDK.sun.security.ec.point.AffinePoint decodeAffinePoint(Dova.JDK.java.util.function.Function arg0, int arg1, Dova.JDK.sun.security.util.math.IntegerModuloP arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.AffinePoint>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ec/point/MutablePoint;[B)Lsun/security/ec/point/MutablePoint;", "public")]
	public Dova.JDK.sun.security.ec.point.MutablePoint setProduct(Dova.JDK.sun.security.ec.point.MutablePoint arg0, JavaArray<byte> arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.MutablePoint>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ec/point/MutablePoint;Lsun/security/ec/point/MutablePoint;)Lsun/security/ec/point/MutablePoint;", "public")]
	public Dova.JDK.sun.security.ec.point.MutablePoint setSum(Dova.JDK.sun.security.ec.point.MutablePoint arg0, Dova.JDK.sun.security.ec.point.MutablePoint arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.MutablePoint>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ec/point/MutablePoint;Lsun/security/ec/point/MutablePoint;Lsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;)Lsun/security/ec/point/MutablePoint;", "protected abstract")]
	public Dova.JDK.sun.security.ec.point.MutablePoint setSum(Dova.JDK.sun.security.ec.point.MutablePoint arg0, Dova.JDK.sun.security.ec.point.MutablePoint arg1, Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg2, Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg3, Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg4)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.MutablePoint>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/ec/point/ImmutablePoint;", "protected abstract")]
	public Dova.JDK.sun.security.ec.point.ImmutablePoint getNeutral()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.ImmutablePoint>(ret);
	}

	[JniSignatureAttribute("([BI)I", "private static")]
	public static int bitAt(JavaArray<byte> arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return ret;
	}
}
