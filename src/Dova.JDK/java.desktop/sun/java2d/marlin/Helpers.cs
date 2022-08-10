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

namespace Dova.JDK.sun.java2d.marlin;

[JniSignatureAttribute("Lsun/java2d/marlin/Helpers;", "final")]
public partial class Helpers
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.java2d.marlin.MarlinConst
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Helpers()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/marlin/Helpers;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Helpers", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "within", "(DDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "quadraticRoots", "(DDD[DI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "cubicRootsInAB", "(DDDD[DIDD)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "filterOutNotInAB", "([DIIDD)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "linelen", "(DDDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isort", "([DI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "subdivideCubic", "([D[D[D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "subdivideQuad", "([D[D[D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "subdivideCubicAt", "(D[DI[DII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "subdivideLineAt", "(D[DI[DII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "subdivideQuadAt", "(D[DI[DII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "evalCubic", "(DDDDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "evalQuad", "(DDDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "fastLineLen", "(DDDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "fastQuadLen", "(DDDDDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "quadlen", "(DDDDDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "fastCurvelen", "(DDDDDDDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "curvelen", "(DDDDDDDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "findSubdivPoints", "(Lsun/java2d/marlin/Curve;[D[DID)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "findClipPoints", "(Lsun/java2d/marlin/Curve;[D[DII[D)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "subdivide", "([D[D[DI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "subdivideAt", "(D[DI[DII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "outcode", "(DD[D)I"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Helpers(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public Helpers() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/marlin/Helpers;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(DDD)Z", "static")]
	public static bool within(double arg0, double arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(DDD[DI)I", "static")]
	public static int quadraticRoots(double arg0, double arg1, double arg2, JavaArray<double> arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(DDDD[DIDD)I", "static")]
	public static int cubicRootsInAB(double arg0, double arg1, double arg2, double arg3, JavaArray<double> arg4, int arg5, double arg6, double arg7)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return ret;
	}

	[JniSignatureAttribute("([DIIDD)I", "static")]
	public static int filterOutNotInAB(JavaArray<double> arg0, int arg1, int arg2, double arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(DDDD)D", "static")]
	public static double linelen(double arg0, double arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([DI)V", "static")]
	public static void isort(JavaArray<double> arg0, int arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("([D[D[D)V", "static")]
	public static void subdivideCubic(JavaArray<double> arg0, JavaArray<double> arg1, JavaArray<double> arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([D[D[D)V", "static")]
	public static void subdivideQuad(JavaArray<double> arg0, JavaArray<double> arg1, JavaArray<double> arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(D[DI[DII)V", "static")]
	public static void subdivideCubicAt(double arg0, JavaArray<double> arg1, int arg2, JavaArray<double> arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(D[DI[DII)V", "static")]
	public static void subdivideLineAt(double arg0, JavaArray<double> arg1, int arg2, JavaArray<double> arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(D[DI[DII)V", "static")]
	public static void subdivideQuadAt(double arg0, JavaArray<double> arg1, int arg2, JavaArray<double> arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(DDDDD)D", "static")]
	public static double evalCubic(double arg0, double arg1, double arg2, double arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(DDDD)D", "static")]
	public static double evalQuad(double arg0, double arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(DDDD)D", "static")]
	public static double fastLineLen(double arg0, double arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(DDDDDD)D", "static")]
	public static double fastQuadLen(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(DDDDDD)D", "static")]
	public static double quadlen(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(DDDDDDDD)D", "static")]
	public static double fastCurvelen(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return ret;
	}

	[JniSignatureAttribute("(DDDDDDDD)D", "static")]
	public static double curvelen(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/marlin/Curve;[D[DID)I", "static")]
	public static int findSubdivPoints(Dova.JDK.sun.java2d.marlin.Curve arg0, JavaArray<double> arg1, JavaArray<double> arg2, int arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/marlin/Curve;[D[DII[D)I", "static")]
	public static int findClipPoints(Dova.JDK.sun.java2d.marlin.Curve arg0, JavaArray<double> arg1, JavaArray<double> arg2, int arg3, int arg4, JavaArray<double> arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([D[D[DI)V", "static")]
	public static void subdivide(JavaArray<double> arg0, JavaArray<double> arg1, JavaArray<double> arg2, int arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(D[DI[DII)V", "static")]
	public static void subdivideAt(double arg0, JavaArray<double> arg1, int arg2, JavaArray<double> arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(DD[D)I", "static")]
	public static int outcode(double arg0, double arg1, JavaArray<double> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("Lsun/java2d/marlin/Helpers$IndexStack;", "static final")]
	public partial class IndexStack
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IndexStack()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/marlin/Helpers$IndexStack;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INITIAL_COUNT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "end", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "indices", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "indices_ref", "Lsun/java2d/marlin/IntArrayCache$Reference;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "indicesUseMark", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "stat_idxstack_indices", "Lsun/java2d/marlin/stats/StatLong;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "hist_idxstack_indices", "Lsun/java2d/marlin/stats/Histogram;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "stat_array_idxstack_indices", "Lsun/java2d/marlin/stats/StatLong;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "IndexStack", "(Lsun/java2d/marlin/RendererContext;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "IndexStack", "(Lsun/java2d/marlin/RendererContext;Lsun/java2d/marlin/stats/StatLong;Lsun/java2d/marlin/stats/Histogram;Lsun/java2d/marlin/stats/StatLong;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isEmpty", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reset", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "push", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dispose", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pullAll", "([DLsun/java2d/marlin/DPathConsumer2D;)V"));
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int INITIAL_COUNT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("I", "private")]
		public int end_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("[I", "private")]
		public JavaArray<int> indices_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/java2d/marlin/IntArrayCache$Reference;", "private final")]
		public Dova.JDK.sun.java2d.marlin.IntArrayCache.Reference indices_ref_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.IntArrayCache.Reference>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "private")]
		public int indicesUseMark_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("Lsun/java2d/marlin/stats/StatLong;", "private final")]
		public Dova.JDK.sun.java2d.marlin.stats.StatLong stat_idxstack_indices_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.stats.StatLong>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/java2d/marlin/stats/Histogram;", "private final")]
		public Dova.JDK.sun.java2d.marlin.stats.Histogram hist_idxstack_indices_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.stats.Histogram>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/java2d/marlin/stats/StatLong;", "private final")]
		public Dova.JDK.sun.java2d.marlin.stats.StatLong stat_array_idxstack_indices_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.stats.StatLong>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IndexStack(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/java2d/marlin/RendererContext;)V", "")]
		public IndexStack(Dova.JDK.sun.java2d.marlin.RendererContext arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Lsun/java2d/marlin/RendererContext;Lsun/java2d/marlin/stats/StatLong;Lsun/java2d/marlin/stats/Histogram;Lsun/java2d/marlin/stats/StatLong;)V", "")]
		public IndexStack(Dova.JDK.sun.java2d.marlin.RendererContext arg0, Dova.JDK.sun.java2d.marlin.stats.StatLong arg1, Dova.JDK.sun.java2d.marlin.stats.Histogram arg2, Dova.JDK.sun.java2d.marlin.stats.StatLong arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/marlin/Helpers$IndexStack;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "")]
		public bool isEmpty()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()V", "")]
		public void reset()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(I)V", "")]
		public void push(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()V", "")]
		public void dispose()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("([DLsun/java2d/marlin/DPathConsumer2D;)V", "")]
		public void pullAll(JavaArray<double> arg0, Dova.JDK.sun.java2d.marlin.DPathConsumer2D arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/marlin/Helpers$PolyStack;", "static final")]
	public partial class PolyStack
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PolyStack()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/marlin/Helpers$PolyStack;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TYPE_LINETO", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TYPE_QUADTO", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TYPE_CUBICTO", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INITIAL_CURVES_COUNT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INITIAL_TYPES_COUNT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "curves", "[D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "end", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "curveTypes", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "numCurves", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "curves_ref", "Lsun/java2d/marlin/DoubleArrayCache$Reference;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "curveTypes_ref", "Lsun/java2d/marlin/ByteArrayCache$Reference;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "curveTypesUseMark", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "curvesUseMark", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "stat_polystack_types", "Lsun/java2d/marlin/stats/StatLong;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "stat_polystack_curves", "Lsun/java2d/marlin/stats/StatLong;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "hist_polystack_curves", "Lsun/java2d/marlin/stats/Histogram;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "stat_array_polystack_curves", "Lsun/java2d/marlin/stats/StatLong;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "stat_array_polystack_curveTypes", "Lsun/java2d/marlin/stats/StatLong;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PolyStack", "(Lsun/java2d/marlin/RendererContext;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PolyStack", "(Lsun/java2d/marlin/RendererContext;Lsun/java2d/marlin/stats/StatLong;Lsun/java2d/marlin/stats/StatLong;Lsun/java2d/marlin/stats/Histogram;Lsun/java2d/marlin/stats/StatLong;Lsun/java2d/marlin/stats/StatLong;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dispose", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pullAll", "(Lsun/java2d/marlin/DPathConsumer2D;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ensureSpace", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pushCubic", "(DDDDDD)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pushQuad", "(DDDD)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pushLine", "(DD)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "popAll", "(Lsun/java2d/marlin/DPathConsumer2D;)V"));
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte TYPE_LINETO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte TYPE_QUADTO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte TYPE_CUBICTO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int INITIAL_CURVES_COUNT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int INITIAL_TYPES_COUNT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("[D", "")]
		public JavaArray<double> curves_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "")]
		public int end_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
		}

		[JniSignatureAttribute("[B", "")]
		public JavaArray<byte> curveTypes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "")]
		public int numCurves_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
		}

		[JniSignatureAttribute("Lsun/java2d/marlin/DoubleArrayCache$Reference;", "final")]
		public Dova.JDK.sun.java2d.marlin.DoubleArrayCache.Reference curves_ref_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.DoubleArrayCache.Reference>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/java2d/marlin/ByteArrayCache$Reference;", "final")]
		public Dova.JDK.sun.java2d.marlin.ByteArrayCache.Reference curveTypes_ref_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.ByteArrayCache.Reference>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "")]
		public int curveTypesUseMark_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[11]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[11], value);
		}

		[JniSignatureAttribute("I", "")]
		public int curvesUseMark_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[12]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[12], value);
		}

		[JniSignatureAttribute("Lsun/java2d/marlin/stats/StatLong;", "private final")]
		public Dova.JDK.sun.java2d.marlin.stats.StatLong stat_polystack_types_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.stats.StatLong>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/java2d/marlin/stats/StatLong;", "private final")]
		public Dova.JDK.sun.java2d.marlin.stats.StatLong stat_polystack_curves_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.stats.StatLong>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/java2d/marlin/stats/Histogram;", "private final")]
		public Dova.JDK.sun.java2d.marlin.stats.Histogram hist_polystack_curves_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.stats.Histogram>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/java2d/marlin/stats/StatLong;", "private final")]
		public Dova.JDK.sun.java2d.marlin.stats.StatLong stat_array_polystack_curves_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.stats.StatLong>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/java2d/marlin/stats/StatLong;", "private final")]
		public Dova.JDK.sun.java2d.marlin.stats.StatLong stat_array_polystack_curveTypes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.stats.StatLong>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PolyStack(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/java2d/marlin/RendererContext;)V", "")]
		public PolyStack(Dova.JDK.sun.java2d.marlin.RendererContext arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Lsun/java2d/marlin/RendererContext;Lsun/java2d/marlin/stats/StatLong;Lsun/java2d/marlin/stats/StatLong;Lsun/java2d/marlin/stats/Histogram;Lsun/java2d/marlin/stats/StatLong;Lsun/java2d/marlin/stats/StatLong;)V", "")]
		public PolyStack(Dova.JDK.sun.java2d.marlin.RendererContext arg0, Dova.JDK.sun.java2d.marlin.stats.StatLong arg1, Dova.JDK.sun.java2d.marlin.stats.StatLong arg2, Dova.JDK.sun.java2d.marlin.stats.Histogram arg3, Dova.JDK.sun.java2d.marlin.stats.StatLong arg4, Dova.JDK.sun.java2d.marlin.stats.StatLong arg5) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/marlin/Helpers$PolyStack;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()V", "")]
		public void dispose()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(Lsun/java2d/marlin/DPathConsumer2D;)V", "")]
		public void pullAll(Dova.JDK.sun.java2d.marlin.DPathConsumer2D arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(I)V", "private")]
		public void ensureSpace(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(DDDDDD)V", "")]
		public void pushCubic(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5);
		}

		[JniSignatureAttribute("(DDDD)V", "")]
		public void pushQuad(double arg0, double arg1, double arg2, double arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(DD)V", "")]
		public void pushLine(double arg0, double arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		}

		[JniSignatureAttribute("(Lsun/java2d/marlin/DPathConsumer2D;)V", "")]
		public void popAll(Dova.JDK.sun.java2d.marlin.DPathConsumer2D arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}
	}
}
