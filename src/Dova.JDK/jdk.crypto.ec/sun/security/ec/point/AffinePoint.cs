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

namespace Dova.JDK.sun.security.ec.point;

[JniSignatureAttribute("Lsun/security/ec/point/AffinePoint;", "public")]
public partial class AffinePoint
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AffinePoint()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ec/point/AffinePoint;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x", "Lsun/security/util/math/ImmutableIntegerModuloP;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "y", "Lsun/security/util/math/ImmutableIntegerModuloP;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/util/math/ImmutableIntegerModuloP;Lsun/security/util/math/ImmutableIntegerModuloP;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getX", "()Lsun/security/util/math/ImmutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getY", "()Lsun/security/util/math/ImmutableIntegerModuloP;"));
	}

	[JniSignatureAttribute("Lsun/security/util/math/ImmutableIntegerModuloP;", "private final")]
	public Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP x_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/math/ImmutableIntegerModuloP;", "private final")]
	public Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP y_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AffinePoint(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/util/math/ImmutableIntegerModuloP;Lsun/security/util/math/ImmutableIntegerModuloP;)V", "public")]
	public AffinePoint(Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP arg0, Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ec/point/AffinePoint;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/security/util/math/ImmutableIntegerModuloP;", "public")]
	public Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP getX()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/ImmutableIntegerModuloP;", "public")]
	public Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP getY()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
	}
}
