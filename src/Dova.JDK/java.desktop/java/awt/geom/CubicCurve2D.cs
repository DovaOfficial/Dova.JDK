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

namespace Dova.JDK.java.awt.geom;

[JniSignatureAttribute("Ljava/awt/geom/CubicCurve2D;", "public abstract")]
public partial class CubicCurve2D
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.awt.Shape
	, Dova.JDK.java.lang.Cloneable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CubicCurve2D()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/geom/CubicCurve2D;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(DD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/awt/geom/Point2D;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/awt/geom/Rectangle2D;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(DDDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "()Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "within", "(DDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCurve", "([DI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCurve", "([Ljava/awt/geom/Point2D;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCurve", "(DDDDDDDD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCurve", "(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCurve", "(Ljava/awt/geom/CubicCurve2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCtrlX1", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCtrlY1", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCtrlX2", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCtrlY2", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFlatnessSq", "([DI)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFlatnessSq", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFlatnessSq", "(DDDDDDDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFlatness", "([DI)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFlatness", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFlatness", "(DDDDDDDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "solveCubic", "([D[D)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "solveCubic", "([D)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "iszero", "(DD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fixRoots", "([D[DI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getRootUpperBound", "([D)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "refineRootWithHint", "([DDDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "solveEqn", "([DID)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "oppositeSigns", "(DD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "bisectRootWithHint", "([DDDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "bisectRoot", "([DDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getP1", "()Ljava/awt/geom/Point2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCtrlP1", "()Ljava/awt/geom/Point2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCtrlP2", "()Ljava/awt/geom/Point2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getP2", "()Ljava/awt/geom/Point2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "subdivide", "([DI[DI[DI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "subdivide", "(Ljava/awt/geom/CubicCurve2D;Ljava/awt/geom/CubicCurve2D;Ljava/awt/geom/CubicCurve2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subdivide", "(Ljava/awt/geom/CubicCurve2D;Ljava/awt/geom/CubicCurve2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "inInterval", "(DDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rectCrossings", "(DDDD)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getX1", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getY1", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getX2", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getY2", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPathIterator", "(Ljava/awt/geom/AffineTransform;)Ljava/awt/geom/PathIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPathIterator", "(Ljava/awt/geom/AffineTransform;D)Ljava/awt/geom/PathIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intersects", "(DDDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intersects", "(Ljava/awt/geom/Rectangle2D;)Z"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CubicCurve2D(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public CubicCurve2D() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/geom/CubicCurve2D;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(DD)Z", "public")]
	public bool contains(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Point2D;)Z", "public")]
	public bool contains(Dova.JDK.java.awt.geom.Point2D arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Rectangle2D;)Z", "public")]
	public bool contains(Dova.JDK.java.awt.geom.Rectangle2D arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(DDDD)Z", "public")]
	public bool contains(double arg0, double arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/Rectangle;", "public")]
	public Dova.JDK.java.awt.Rectangle getBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(DDD)Z", "private static")]
	public static bool within(double arg0, double arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([DI)V", "public")]
	public void setCurve(JavaArray<double> arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("([Ljava/awt/geom/Point2D;I)V", "public")]
	public void setCurve(JavaArray<Dova.JDK.java.awt.geom.Point2D> arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(DDDDDDDD)V", "public abstract")]
	public void setCurve(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;)V", "public")]
	public void setCurve(Dova.JDK.java.awt.geom.Point2D arg0, Dova.JDK.java.awt.geom.Point2D arg1, Dova.JDK.java.awt.geom.Point2D arg2, Dova.JDK.java.awt.geom.Point2D arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/CubicCurve2D;)V", "public")]
	public void setCurve(Dova.JDK.java.awt.geom.CubicCurve2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double getCtrlX1()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double getCtrlY1()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double getCtrlX2()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double getCtrlY2()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("([DI)D", "public static")]
	public static double getFlatnessSq(JavaArray<double> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double getFlatnessSq()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("(DDDDDDDD)D", "public static")]
	public static double getFlatnessSq(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return ret;
	}

	[JniSignatureAttribute("([DI)D", "public static")]
	public static double getFlatness(JavaArray<double> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double getFlatness()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("(DDDDDDDD)D", "public static")]
	public static double getFlatness(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return ret;
	}

	[JniSignatureAttribute("([D[D)I", "public static")]
	public static int solveCubic(JavaArray<double> arg0, JavaArray<double> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([D)I", "public static")]
	public static int solveCubic(JavaArray<double> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(DD)Z", "private static")]
	public static bool iszero(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([D[DI)I", "private static")]
	public static int fixRoots(JavaArray<double> arg0, JavaArray<double> arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([D)D", "private static")]
	public static double getRootUpperBound(JavaArray<double> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[26], arg0);
		return ret;
	}

	[JniSignatureAttribute("([DDDD)D", "private static")]
	public static double refineRootWithHint(JavaArray<double> arg0, double arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([DID)D", "private static")]
	public static double solveEqn(JavaArray<double> arg0, int arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(DD)Z", "private static")]
	public static bool oppositeSigns(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([DDDD)D", "private static")]
	public static double bisectRootWithHint(JavaArray<double> arg0, double arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([DDD)D", "private static")]
	public static double bisectRoot(JavaArray<double> arg0, double arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Point2D;", "public abstract")]
	public Dova.JDK.java.awt.geom.Point2D getP1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Point2D;", "public abstract")]
	public Dova.JDK.java.awt.geom.Point2D getCtrlP1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Point2D;", "public abstract")]
	public Dova.JDK.java.awt.geom.Point2D getCtrlP2()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Point2D;", "public abstract")]
	public Dova.JDK.java.awt.geom.Point2D getP2()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
	}

	[JniSignatureAttribute("([DI[DI[DI)V", "public static")]
	public static void subdivide(JavaArray<double> arg0, int arg1, JavaArray<double> arg2, int arg3, JavaArray<double> arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[36], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/CubicCurve2D;Ljava/awt/geom/CubicCurve2D;Ljava/awt/geom/CubicCurve2D;)V", "public static")]
	public static void subdivide(Dova.JDK.java.awt.geom.CubicCurve2D arg0, Dova.JDK.java.awt.geom.CubicCurve2D arg1, Dova.JDK.java.awt.geom.CubicCurve2D arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/CubicCurve2D;Ljava/awt/geom/CubicCurve2D;)V", "public")]
	public void subdivide(Dova.JDK.java.awt.geom.CubicCurve2D arg0, Dova.JDK.java.awt.geom.CubicCurve2D arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
	}

	[JniSignatureAttribute("(DDD)Z", "private static")]
	public static bool inInterval(double arg0, double arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(DDDD)I", "private")]
	public int rectCrossings(double arg0, double arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double getX1()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[41]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double getY1()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[42]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double getX2()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[43]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double getY2()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[44]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;)Ljava/awt/geom/PathIterator;", "public")]
	public Dova.JDK.java.awt.geom.PathIterator getPathIterator(Dova.JDK.java.awt.geom.AffineTransform arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.PathIterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;D)Ljava/awt/geom/PathIterator;", "public")]
	public Dova.JDK.java.awt.geom.PathIterator getPathIterator(Dova.JDK.java.awt.geom.AffineTransform arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.PathIterator>(ret);
	}

	[JniSignatureAttribute("(DDDD)Z", "public")]
	public bool intersects(double arg0, double arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Rectangle2D;)Z", "public")]
	public bool intersects(Dova.JDK.java.awt.geom.Rectangle2D arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		return ret;
	}

	[JniSignatureAttribute("Ljava/awt/geom/CubicCurve2D$Double;", "public static")]
	public partial class Double
		: Dova.JDK.java.awt.geom.CubicCurve2D
		, Dova.JDK.java.io.Serializable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Double()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/geom/CubicCurve2D$Double;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x1", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "y1", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ctrlx1", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ctrly1", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ctrlx2", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ctrly2", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x2", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "y2", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(DDDDDDDD)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCurve", "(DDDDDDDD)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCtrlX1", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCtrlY1", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCtrlX2", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCtrlY2", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getP1", "()Ljava/awt/geom/Point2D;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCtrlP1", "()Ljava/awt/geom/Point2D;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCtrlP2", "()Ljava/awt/geom/Point2D;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getP2", "()Ljava/awt/geom/Point2D;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getX1", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getY1", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getX2", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getY2", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds2D", "()Ljava/awt/geom/Rectangle2D;"));
		}

		[JniSignatureAttribute("D", "public")]
		public double x1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("D", "public")]
		public double y1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("D", "public")]
		public double ctrlx1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("D", "public")]
		public double ctrly1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("D", "public")]
		public double ctrlx2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("D", "public")]
		public double ctrly2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("D", "public")]
		public double x2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("D", "public")]
		public double y2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[8]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[8], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Double(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Double() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(DDDDDDDD)V", "public")]
		public Double(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/geom/CubicCurve2D$Double;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(DDDDDDDD)V", "public")]
		public void setCurve(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		}

		[JniSignatureAttribute("()D", "public")]
		public double getCtrlX1()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getCtrlY1()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getCtrlX2()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getCtrlY2()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/awt/geom/Point2D;", "public")]
		public Dova.JDK.java.awt.geom.Point2D getP1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
		}

		[JniSignatureAttribute("()Ljava/awt/geom/Point2D;", "public")]
		public Dova.JDK.java.awt.geom.Point2D getCtrlP1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
		}

		[JniSignatureAttribute("()Ljava/awt/geom/Point2D;", "public")]
		public Dova.JDK.java.awt.geom.Point2D getCtrlP2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
		}

		[JniSignatureAttribute("()Ljava/awt/geom/Point2D;", "public")]
		public Dova.JDK.java.awt.geom.Point2D getP2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
		}

		[JniSignatureAttribute("()D", "public")]
		public double getX1()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getY1()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getX2()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getY2()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[12]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "public")]
		public Dova.JDK.java.awt.geom.Rectangle2D getBounds2D()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/awt/geom/CubicCurve2D$Float;", "public static")]
	public partial class Float
		: Dova.JDK.java.awt.geom.CubicCurve2D
		, Dova.JDK.java.io.Serializable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Float()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/geom/CubicCurve2D$Float;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x1", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "y1", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ctrlx1", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ctrly1", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ctrlx2", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ctrly2", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x2", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "y2", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(FFFFFFFF)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCurve", "(DDDDDDDD)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCurve", "(FFFFFFFF)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCtrlX1", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCtrlY1", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCtrlX2", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCtrlY2", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getP1", "()Ljava/awt/geom/Point2D;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCtrlP1", "()Ljava/awt/geom/Point2D;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCtrlP2", "()Ljava/awt/geom/Point2D;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getP2", "()Ljava/awt/geom/Point2D;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getX1", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getY1", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getX2", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getY2", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds2D", "()Ljava/awt/geom/Rectangle2D;"));
		}

		[JniSignatureAttribute("F", "public")]
		public float x1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("F", "public")]
		public float y1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("F", "public")]
		public float ctrlx1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("F", "public")]
		public float ctrly1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("F", "public")]
		public float ctrlx2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("F", "public")]
		public float ctrly2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("F", "public")]
		public float x2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("F", "public")]
		public float y2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[8]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[8], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Float(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Float() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(FFFFFFFF)V", "public")]
		public Float(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/geom/CubicCurve2D$Float;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(DDDDDDDD)V", "public")]
		public void setCurve(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		}

		[JniSignatureAttribute("(FFFFFFFF)V", "public")]
		public void setCurve(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		}

		[JniSignatureAttribute("()D", "public")]
		public double getCtrlX1()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getCtrlY1()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getCtrlX2()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getCtrlY2()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/awt/geom/Point2D;", "public")]
		public Dova.JDK.java.awt.geom.Point2D getP1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
		}

		[JniSignatureAttribute("()Ljava/awt/geom/Point2D;", "public")]
		public Dova.JDK.java.awt.geom.Point2D getCtrlP1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
		}

		[JniSignatureAttribute("()Ljava/awt/geom/Point2D;", "public")]
		public Dova.JDK.java.awt.geom.Point2D getCtrlP2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
		}

		[JniSignatureAttribute("()Ljava/awt/geom/Point2D;", "public")]
		public Dova.JDK.java.awt.geom.Point2D getP2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
		}

		[JniSignatureAttribute("()D", "public")]
		public double getX1()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getY1()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getX2()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[12]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getY2()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[13]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "public")]
		public Dova.JDK.java.awt.geom.Rectangle2D getBounds2D()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
		}
	}
}
