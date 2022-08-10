/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
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

[JniSignatureAttribute("Lsun/security/ec/point/ProjectivePoint;", "public abstract")]
public partial class ProjectivePoint
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.security.ec.point.Point
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ProjectivePoint()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ec/point/ProjectivePoint;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "x", "Lsun/security/util/math/IntegerModuloP;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "y", "Lsun/security/util/math/IntegerModuloP;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "z", "Lsun/security/util/math/IntegerModuloP;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ProjectivePoint", "(Lsun/security/util/math/IntegerModuloP;Lsun/security/util/math/IntegerModuloP;Lsun/security/util/math/IntegerModuloP;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getField", "()Lsun/security/util/math/IntegerFieldModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fixed_0", "()Lsun/security/ec/point/ImmutablePoint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fixed_1", "()Lsun/security/ec/point/ProjectivePoint$Immutable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "asAffine", "()Lsun/security/ec/point/AffinePoint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mutable_0", "()Lsun/security/ec/point/MutablePoint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mutable_1", "()Lsun/security/ec/point/ProjectivePoint$Mutable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "affineEquals", "(Lsun/security/ec/point/Point;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "affineEquals", "(Lsun/security/ec/point/ProjectivePoint;Lsun/security/ec/point/ProjectivePoint;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getZ", "()Lsun/security/util/math/IntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getX", "()Lsun/security/util/math/IntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getY", "()Lsun/security/util/math/IntegerModuloP;"));
	}

	[JniSignatureAttribute("Lsun/security/util/math/IntegerModuloP;", "protected final")]
	public Dova.JDK.java.lang.Object x_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/math/IntegerModuloP;", "protected final")]
	public Dova.JDK.java.lang.Object y_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/math/IntegerModuloP;", "protected final")]
	public Dova.JDK.java.lang.Object z_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ProjectivePoint(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/util/math/IntegerModuloP;Lsun/security/util/math/IntegerModuloP;Lsun/security/util/math/IntegerModuloP;)V", "protected")]
	public ProjectivePoint(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ec/point/ProjectivePoint;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/security/util/math/IntegerFieldModuloP;", "public")]
	public Dova.JDK.sun.security.util.math.IntegerFieldModuloP getField()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.IntegerFieldModuloP>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/ec/point/ImmutablePoint;", "public volatile")]
	public Dova.JDK.sun.security.ec.point.ImmutablePoint fixed_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.ImmutablePoint>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/ec/point/ProjectivePoint$Immutable;", "public")]
	public Dova.JDK.sun.security.ec.point.ProjectivePoint.Immutable fixed_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.ProjectivePoint.Immutable>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/ec/point/AffinePoint;", "public")]
	public Dova.JDK.sun.security.ec.point.AffinePoint asAffine()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.AffinePoint>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/ec/point/MutablePoint;", "public volatile")]
	public Dova.JDK.sun.security.ec.point.MutablePoint mutable_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.MutablePoint>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/ec/point/ProjectivePoint$Mutable;", "public")]
	public Dova.JDK.sun.security.ec.point.ProjectivePoint.Mutable mutable_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.ProjectivePoint.Mutable>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ec/point/Point;)Z", "public")]
	public bool affineEquals(Dova.JDK.sun.security.ec.point.Point arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/security/ec/point/ProjectivePoint;Lsun/security/ec/point/ProjectivePoint;)Z", "private static")]
	public static bool affineEquals(Dova.JDK.sun.security.ec.point.ProjectivePoint arg0, Dova.JDK.sun.security.ec.point.ProjectivePoint arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/security/util/math/IntegerModuloP;", "public")]
	public Dova.JDK.java.lang.Object getZ()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/IntegerModuloP;", "public")]
	public Dova.JDK.java.lang.Object getX()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/IntegerModuloP;", "public")]
	public Dova.JDK.java.lang.Object getY()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("Lsun/security/ec/point/ProjectivePoint$Immutable;", "public static")]
	public partial class Immutable
		: Dova.JDK.sun.security.ec.point.ProjectivePoint
		, Dova.JDK.sun.security.ec.point.ImmutablePoint
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Immutable()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ec/point/ProjectivePoint$Immutable;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Immutable", "(Lsun/security/util/math/ImmutableIntegerModuloP;Lsun/security/util/math/ImmutableIntegerModuloP;Lsun/security/util/math/ImmutableIntegerModuloP;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fixed", "()Lsun/security/ec/point/ImmutablePoint;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mutable", "()Lsun/security/ec/point/MutablePoint;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Immutable(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/util/math/ImmutableIntegerModuloP;Lsun/security/util/math/ImmutableIntegerModuloP;Lsun/security/util/math/ImmutableIntegerModuloP;)V", "public")]
		public Immutable(Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP arg0, Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP arg1, Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ec/point/ProjectivePoint$Immutable;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lsun/security/ec/point/ImmutablePoint;", "public volatile")]
		public Dova.JDK.sun.security.ec.point.ImmutablePoint @fixed()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.ImmutablePoint>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/ec/point/MutablePoint;", "public volatile")]
		public Dova.JDK.sun.security.ec.point.MutablePoint mutable()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.MutablePoint>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ec/point/ProjectivePoint$Mutable;", "public static")]
	public partial class Mutable
		: Dova.JDK.sun.security.ec.point.ProjectivePoint
		, Dova.JDK.sun.security.ec.point.MutablePoint
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Mutable()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ec/point/ProjectivePoint$Mutable;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Mutable", "(Lsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Mutable", "(Lsun/security/util/math/IntegerFieldModuloP;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setValue", "(Lsun/security/ec/point/ProjectivePoint;)Lsun/security/ec/point/ProjectivePoint$Mutable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setValue_0", "(Lsun/security/ec/point/Point;)Lsun/security/ec/point/ProjectivePoint$Mutable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setValue_1", "(Lsun/security/ec/point/Point;)Lsun/security/ec/point/MutablePoint;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setValue_0", "(Lsun/security/ec/point/AffinePoint;)Lsun/security/ec/point/MutablePoint;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setValue_1", "(Lsun/security/ec/point/AffinePoint;)Lsun/security/ec/point/ProjectivePoint$Mutable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fixed", "()Lsun/security/ec/point/ImmutablePoint;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mutable", "()Lsun/security/ec/point/MutablePoint;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "conditionalSet_0", "(Lsun/security/ec/point/Point;I)Lsun/security/ec/point/ProjectivePoint$Mutable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "conditionalSet_1", "(Lsun/security/ec/point/Point;I)Lsun/security/ec/point/MutablePoint;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "conditionalSet", "(Lsun/security/ec/point/ProjectivePoint;I)Lsun/security/ec/point/ProjectivePoint$Mutable;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Mutable(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;)V", "public")]
		public Mutable(Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg0, Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg1, Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lsun/security/util/math/IntegerFieldModuloP;)V", "public")]
		public Mutable(Dova.JDK.sun.security.util.math.IntegerFieldModuloP arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ec/point/ProjectivePoint$Mutable;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ec/point/ProjectivePoint;)Lsun/security/ec/point/ProjectivePoint$Mutable;", "private")]
		public Dova.JDK.sun.security.ec.point.ProjectivePoint.Mutable setValue(Dova.JDK.sun.security.ec.point.ProjectivePoint arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.ProjectivePoint.Mutable>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ec/point/Point;)Lsun/security/ec/point/ProjectivePoint$Mutable;", "public")]
		public Dova.JDK.sun.security.ec.point.ProjectivePoint.Mutable setValue_0(Dova.JDK.sun.security.ec.point.Point arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.ProjectivePoint.Mutable>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ec/point/Point;)Lsun/security/ec/point/MutablePoint;", "public volatile")]
		public Dova.JDK.sun.security.ec.point.MutablePoint setValue_1(Dova.JDK.sun.security.ec.point.Point arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.MutablePoint>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ec/point/AffinePoint;)Lsun/security/ec/point/MutablePoint;", "public volatile")]
		public Dova.JDK.sun.security.ec.point.MutablePoint setValue_0(Dova.JDK.sun.security.ec.point.AffinePoint arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.MutablePoint>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ec/point/AffinePoint;)Lsun/security/ec/point/ProjectivePoint$Mutable;", "public")]
		public Dova.JDK.sun.security.ec.point.ProjectivePoint.Mutable setValue_1(Dova.JDK.sun.security.ec.point.AffinePoint arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.ProjectivePoint.Mutable>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/ec/point/ImmutablePoint;", "public volatile")]
		public Dova.JDK.sun.security.ec.point.ImmutablePoint @fixed()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.ImmutablePoint>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/ec/point/MutablePoint;", "public volatile")]
		public Dova.JDK.sun.security.ec.point.MutablePoint mutable()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.MutablePoint>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ec/point/Point;I)Lsun/security/ec/point/ProjectivePoint$Mutable;", "public")]
		public Dova.JDK.sun.security.ec.point.ProjectivePoint.Mutable conditionalSet_0(Dova.JDK.sun.security.ec.point.Point arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.ProjectivePoint.Mutable>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ec/point/Point;I)Lsun/security/ec/point/MutablePoint;", "public volatile")]
		public Dova.JDK.sun.security.ec.point.MutablePoint conditionalSet_1(Dova.JDK.sun.security.ec.point.Point arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.MutablePoint>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ec/point/ProjectivePoint;I)Lsun/security/ec/point/ProjectivePoint$Mutable;", "private")]
		public Dova.JDK.sun.security.ec.point.ProjectivePoint.Mutable conditionalSet(Dova.JDK.sun.security.ec.point.ProjectivePoint arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.ProjectivePoint.Mutable>(ret);
		}
	}
}
