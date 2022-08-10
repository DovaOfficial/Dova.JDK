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

[JniSignatureAttribute("Lsun/security/ec/point/MutablePoint;", "public abstract interface")]
public partial interface MutablePoint
	: IJavaObject
	, Dova.JDK.sun.security.ec.point.Point
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MutablePoint()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ec/point/MutablePoint;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setValue", "(Lsun/security/ec/point/AffinePoint;)Lsun/security/ec/point/MutablePoint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setValue", "(Lsun/security/ec/point/Point;)Lsun/security/ec/point/MutablePoint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "conditionalSet", "(Lsun/security/ec/point/Point;I)Lsun/security/ec/point/MutablePoint;"));
	}

	[JniSignatureAttribute("(Lsun/security/ec/point/AffinePoint;)Lsun/security/ec/point/MutablePoint;", "public abstract")]
	Dova.JDK.sun.security.ec.point.MutablePoint setValue(Dova.JDK.sun.security.ec.point.AffinePoint arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.MutablePoint>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ec/point/Point;)Lsun/security/ec/point/MutablePoint;", "public abstract")]
	Dova.JDK.sun.security.ec.point.MutablePoint setValue(Dova.JDK.sun.security.ec.point.Point arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.MutablePoint>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ec/point/Point;I)Lsun/security/ec/point/MutablePoint;", "public abstract")]
	Dova.JDK.sun.security.ec.point.MutablePoint conditionalSet(Dova.JDK.sun.security.ec.point.Point arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.MutablePoint>(ret);
	}
}
