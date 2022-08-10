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

namespace Dova.JDK.sun.security.ec.point;

[JniSignatureAttribute("Lsun/security/ec/point/Point;", "public abstract interface")]
public partial interface Point
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Point()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ec/point/Point;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getField", "()Lsun/security/util/math/IntegerFieldModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fixed", "()Lsun/security/ec/point/ImmutablePoint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "asAffine", "()Lsun/security/ec/point/AffinePoint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mutable", "()Lsun/security/ec/point/MutablePoint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "affineEquals", "(Lsun/security/ec/point/Point;)Z"));
	}

	[JniSignatureAttribute("()Lsun/security/util/math/IntegerFieldModuloP;", "public abstract")]
	Dova.JDK.sun.security.util.math.IntegerFieldModuloP getField()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.IntegerFieldModuloP>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/ec/point/ImmutablePoint;", "public abstract")]
	Dova.JDK.sun.security.ec.point.ImmutablePoint @fixed()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.ImmutablePoint>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/ec/point/AffinePoint;", "public abstract")]
	Dova.JDK.sun.security.ec.point.AffinePoint asAffine()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.AffinePoint>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/ec/point/MutablePoint;", "public abstract")]
	Dova.JDK.sun.security.ec.point.MutablePoint mutable()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.MutablePoint>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ec/point/Point;)Z", "public abstract")]
	bool affineEquals(Dova.JDK.sun.security.ec.point.Point arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}
}
