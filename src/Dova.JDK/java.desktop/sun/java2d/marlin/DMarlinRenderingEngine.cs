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

[JniSignatureAttribute("Lsun/java2d/marlin/DMarlinRenderingEngine;", "public final")]
public partial class DMarlinRenderingEngine
	: Dova.JDK.sun.java2d.pipe.RenderingEngine
	, Dova.JDK.sun.java2d.marlin.MarlinConst
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DMarlinRenderingEngine()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/marlin/DMarlinRenderingEngine;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DISABLE_2ND_STROKER_CLIPPING", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DO_TRACE_PATH", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DO_CLIP", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DO_CLIP_FILL", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DO_CLIP_RUNTIME_ENABLE", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MIN_PEN_SIZE", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "UPPER_BND", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LOWER_BND", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "USE_THREAD_LOCAL", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "REF_TYPE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RDR_CTX_PROVIDER", "Lsun/java2d/ReentrantContextProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SETTINGS_LOGGED", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DMarlinRenderingEngine", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createStrokedShape", "(Ljava/awt/Shape;FIIF[FF)Ljava/awt/Shape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "strokeTo", "(Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;Ljava/awt/BasicStroke;ZZZLsun/awt/geom/PathConsumer2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "strokeTo", "(Lsun/java2d/marlin/RendererContext;Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;DLsun/java2d/marlin/DMarlinRenderingEngine$NormMode;IIF[FFLsun/java2d/marlin/DPathConsumer2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "strokeTo", "(Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;Lsun/java2d/pipe/Region;Ljava/awt/BasicStroke;ZZZLsun/awt/geom/PathConsumer2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "strokeTo", "(Lsun/java2d/marlin/RendererContext;Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;Ljava/awt/BasicStroke;ZLsun/java2d/marlin/DMarlinRenderingEngine$NormMode;ZLsun/java2d/marlin/DPathConsumer2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAATileGenerator", "(Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;Lsun/java2d/pipe/Region;Ljava/awt/BasicStroke;ZZ[I)Lsun/java2d/pipe/AATileGenerator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAATileGenerator", "(DDDDDDDDLsun/java2d/pipe/Region;[I)Lsun/java2d/pipe/AATileGenerator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMinimumAAPenSize", "()F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "logSettings", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getRendererContext", "()Lsun/java2d/marlin/RendererContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "returnRendererContext", "(Lsun/java2d/marlin/RendererContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "userSpaceLineWidth", "(Ljava/awt/geom/AffineTransform;D)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "nearZero", "(D)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "pathTo", "(Lsun/java2d/marlin/RendererContext;Ljava/awt/geom/PathIterator;Lsun/java2d/marlin/DPathConsumer2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "pathToLoop", "([DLjava/awt/geom/PathIterator;Lsun/java2d/marlin/DPathConsumer2D;)V"));
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool DISABLE_2ND_STROKER_CLIPPING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool DO_TRACE_PATH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool DO_CLIP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool DO_CLIP_FILL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool DO_CLIP_RUNTIME_ENABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("F", "private static final")]
	public static float MIN_PEN_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticFloatField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticFloatField(ClassRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("D", "static final")]
	public static double UPPER_BND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[6], value);
	}

	[JniSignatureAttribute("D", "static final")]
	public static double LOWER_BND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[7], value);
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool USE_THREAD_LOCAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[8], value);
	}

	[JniSignatureAttribute("I", "static final")]
	public static int REF_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
	}

	[JniSignatureAttribute("Lsun/java2d/ReentrantContextProvider;", "private static final")]
	public static Dova.JDK.sun.java2d.ReentrantContextProvider RDR_CTX_PROVIDER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.ReentrantContextProvider>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private static")]
	public static bool SETTINGS_LOGGED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[11], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DMarlinRenderingEngine(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DMarlinRenderingEngine() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/marlin/DMarlinRenderingEngine;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/Shape;FIIF[FF)Ljava/awt/Shape;", "public")]
	public Dova.JDK.java.awt.Shape createStrokedShape(Dova.JDK.java.awt.Shape arg0, float arg1, int arg2, int arg3, float arg4, JavaArray<float> arg5, float arg6)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;Ljava/awt/BasicStroke;ZZZLsun/awt/geom/PathConsumer2D;)V", "public")]
	public void strokeTo(Dova.JDK.java.awt.Shape arg0, Dova.JDK.java.awt.geom.AffineTransform arg1, Dova.JDK.java.awt.BasicStroke arg2, bool arg3, bool arg4, bool arg5, Dova.JDK.sun.awt.geom.PathConsumer2D arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Lsun/java2d/marlin/RendererContext;Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;DLsun/java2d/marlin/DMarlinRenderingEngine$NormMode;IIF[FFLsun/java2d/marlin/DPathConsumer2D;)V", "")]
	public void strokeTo(Dova.JDK.sun.java2d.marlin.RendererContext arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.java.awt.geom.AffineTransform arg2, double arg3, Dova.JDK.sun.java2d.marlin.DMarlinRenderingEngine.NormMode arg4, int arg5, int arg6, float arg7, JavaArray<float> arg8, float arg9, Dova.JDK.sun.java2d.marlin.DPathConsumer2D arg10)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;Lsun/java2d/pipe/Region;Ljava/awt/BasicStroke;ZZZLsun/awt/geom/PathConsumer2D;)V", "public")]
	public void strokeTo(Dova.JDK.java.awt.Shape arg0, Dova.JDK.java.awt.geom.AffineTransform arg1, Dova.JDK.sun.java2d.pipe.Region arg2, Dova.JDK.java.awt.BasicStroke arg3, bool arg4, bool arg5, bool arg6, Dova.JDK.sun.awt.geom.PathConsumer2D arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(Lsun/java2d/marlin/RendererContext;Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;Ljava/awt/BasicStroke;ZLsun/java2d/marlin/DMarlinRenderingEngine$NormMode;ZLsun/java2d/marlin/DPathConsumer2D;)V", "")]
	public void strokeTo(Dova.JDK.sun.java2d.marlin.RendererContext arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.java.awt.geom.AffineTransform arg2, Dova.JDK.java.awt.BasicStroke arg3, bool arg4, Dova.JDK.sun.java2d.marlin.DMarlinRenderingEngine.NormMode arg5, bool arg6, Dova.JDK.sun.java2d.marlin.DPathConsumer2D arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;Lsun/java2d/pipe/Region;Ljava/awt/BasicStroke;ZZ[I)Lsun/java2d/pipe/AATileGenerator;", "public")]
	public Dova.JDK.sun.java2d.pipe.AATileGenerator getAATileGenerator(Dova.JDK.java.awt.Shape arg0, Dova.JDK.java.awt.geom.AffineTransform arg1, Dova.JDK.sun.java2d.pipe.Region arg2, Dova.JDK.java.awt.BasicStroke arg3, bool arg4, bool arg5, JavaArray<int> arg6)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.AATileGenerator>(ret);
	}

	[JniSignatureAttribute("(DDDDDDDDLsun/java2d/pipe/Region;[I)Lsun/java2d/pipe/AATileGenerator;", "public")]
	public Dova.JDK.sun.java2d.pipe.AATileGenerator getAATileGenerator(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7, Dova.JDK.sun.java2d.pipe.Region arg8, JavaArray<int> arg9)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.AATileGenerator>(ret);
	}

	[JniSignatureAttribute("()F", "public")]
	public float getMinimumAAPenSize()
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private static")]
	public static void logSettings(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()Lsun/java2d/marlin/RendererContext;", "static")]
	public static Dova.JDK.sun.java2d.marlin.RendererContext getRendererContext()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.RendererContext>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/marlin/RendererContext;)V", "static")]
	public static void returnRendererContext(Dova.JDK.sun.java2d.marlin.RendererContext arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;D)D", "private")]
	public double userSpaceLineWidth(Dova.JDK.java.awt.geom.AffineTransform arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(D)Z", "private static")]
	public static bool nearZero(double arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/marlin/RendererContext;Ljava/awt/geom/PathIterator;Lsun/java2d/marlin/DPathConsumer2D;)V", "private static")]
	public static void pathTo(Dova.JDK.sun.java2d.marlin.RendererContext arg0, Dova.JDK.java.awt.geom.PathIterator arg1, Dova.JDK.sun.java2d.marlin.DPathConsumer2D arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([DLjava/awt/geom/PathIterator;Lsun/java2d/marlin/DPathConsumer2D;)V", "private static")]
	public static void pathToLoop(JavaArray<double> arg0, Dova.JDK.java.awt.geom.PathIterator arg1, Dova.JDK.sun.java2d.marlin.DPathConsumer2D arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("Lsun/java2d/marlin/DMarlinRenderingEngine$NormMode;", "private abstract static")]
	public partial class NormMode
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NormMode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/marlin/DMarlinRenderingEngine$NormMode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ON_WITH_AA", "Lsun/java2d/marlin/DMarlinRenderingEngine$NormMode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ON_NO_AA", "Lsun/java2d/marlin/DMarlinRenderingEngine$NormMode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OFF", "Lsun/java2d/marlin/DMarlinRenderingEngine$NormMode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lsun/java2d/marlin/DMarlinRenderingEngine$NormMode;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "NormMode", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lsun/java2d/marlin/DMarlinRenderingEngine$NormMode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lsun/java2d/marlin/DMarlinRenderingEngine$NormMode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lsun/java2d/marlin/DMarlinRenderingEngine$NormMode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNormalizingPathIterator", "(Lsun/java2d/marlin/RendererContext;Ljava/awt/geom/PathIterator;)Ljava/awt/geom/PathIterator;"));
		}

		[JniSignatureAttribute("Lsun/java2d/marlin/DMarlinRenderingEngine$NormMode;", "public static final")]
		public static Dova.JDK.sun.java2d.marlin.DMarlinRenderingEngine.NormMode ON_WITH_AA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.DMarlinRenderingEngine.NormMode>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/java2d/marlin/DMarlinRenderingEngine$NormMode;", "public static final")]
		public static Dova.JDK.sun.java2d.marlin.DMarlinRenderingEngine.NormMode ON_NO_AA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.DMarlinRenderingEngine.NormMode>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/java2d/marlin/DMarlinRenderingEngine$NormMode;", "public static final")]
		public static Dova.JDK.sun.java2d.marlin.DMarlinRenderingEngine.NormMode OFF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.DMarlinRenderingEngine.NormMode>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Lsun/java2d/marlin/DMarlinRenderingEngine$NormMode;", "private static final")]
		public static JavaArray<Dova.JDK.sun.java2d.marlin.DMarlinRenderingEngine.NormMode> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.java2d.marlin.DMarlinRenderingEngine.NormMode>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NormMode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public NormMode(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/marlin/DMarlinRenderingEngine$NormMode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lsun/java2d/marlin/DMarlinRenderingEngine$NormMode;", "public static")]
		public static JavaArray<Dova.JDK.sun.java2d.marlin.DMarlinRenderingEngine.NormMode> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.java2d.marlin.DMarlinRenderingEngine.NormMode>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/java2d/marlin/DMarlinRenderingEngine$NormMode;", "public static")]
		public static Dova.JDK.sun.java2d.marlin.DMarlinRenderingEngine.NormMode valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.DMarlinRenderingEngine.NormMode>(ret);
		}

		[JniSignatureAttribute("()[Lsun/java2d/marlin/DMarlinRenderingEngine$NormMode;", "private static")]
		public static JavaArray<Dova.JDK.sun.java2d.marlin.DMarlinRenderingEngine.NormMode> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.java2d.marlin.DMarlinRenderingEngine.NormMode>>(ret);
		}

		[JniSignatureAttribute("(Lsun/java2d/marlin/RendererContext;Ljava/awt/geom/PathIterator;)Ljava/awt/geom/PathIterator;", "abstract")]
		public Dova.JDK.java.awt.geom.PathIterator getNormalizingPathIterator(Dova.JDK.sun.java2d.marlin.RendererContext arg0, Dova.JDK.java.awt.geom.PathIterator arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.PathIterator>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/marlin/DMarlinRenderingEngine$NormalizingPathIterator;", "abstract static")]
	public partial class NormalizingPathIterator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.awt.geom.PathIterator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NormalizingPathIterator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/marlin/DMarlinRenderingEngine$NormalizingPathIterator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "src", "Ljava/awt/geom/PathIterator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "curx_adjust", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "cury_adjust", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "movx_adjust", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "movy_adjust", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "tmp", "[D"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "NormalizingPathIterator", "([D)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "next", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "init", "(Ljava/awt/geom/PathIterator;)Lsun/java2d/marlin/DMarlinRenderingEngine$NormalizingPathIterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isDone", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dispose", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "normCoord", "(D)D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "currentSegment", "([D)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "currentSegment", "([F)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getWindingRule", "()I"));
		}

		[JniSignatureAttribute("Ljava/awt/geom/PathIterator;", "private")]
		public Dova.JDK.java.awt.geom.PathIterator src_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.PathIterator>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("D", "private")]
		public double curx_adjust_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("D", "private")]
		public double cury_adjust_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("D", "private")]
		public double movx_adjust_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("D", "private")]
		public double movy_adjust_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("[D", "private final")]
		public JavaArray<double> tmp_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NormalizingPathIterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([D)V", "")]
		public NormalizingPathIterator(JavaArray<double> arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/marlin/DMarlinRenderingEngine$NormalizingPathIterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public final")]
		public void next()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Ljava/awt/geom/PathIterator;)Lsun/java2d/marlin/DMarlinRenderingEngine$NormalizingPathIterator;", "final")]
		public Dova.JDK.sun.java2d.marlin.DMarlinRenderingEngine.NormalizingPathIterator init(Dova.JDK.java.awt.geom.PathIterator arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.DMarlinRenderingEngine.NormalizingPathIterator>(ret);
		}

		[JniSignatureAttribute("()Z", "public final")]
		public bool isDone()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()V", "final")]
		public void dispose()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("(D)D", "abstract")]
		public double normCoord(double arg0)
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("([D)I", "public final")]
		public int currentSegment(JavaArray<double> arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("([F)I", "public final")]
		public int currentSegment(JavaArray<float> arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public final")]
		public int getWindingRule()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("Lsun/java2d/marlin/DMarlinRenderingEngine$NormalizingPathIterator$NearestPixelQuarter;", "static final")]
		public partial class NearestPixelQuarter
			: Dova.JDK.sun.java2d.marlin.DMarlinRenderingEngine.NormalizingPathIterator
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static NearestPixelQuarter()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/marlin/DMarlinRenderingEngine$NormalizingPathIterator$NearestPixelQuarter;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "NearestPixelQuarter", "([D)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "normCoord", "(D)D"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public NearestPixelQuarter(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("([D)V", "")]
			public NearestPixelQuarter(JavaArray<double> arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/java2d/marlin/DMarlinRenderingEngine$NormalizingPathIterator$NearestPixelQuarter;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(D)D", "")]
			public double normCoord(double arg0)
			{
				var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}
		}

		[JniSignatureAttribute("Lsun/java2d/marlin/DMarlinRenderingEngine$NormalizingPathIterator$NearestPixelCenter;", "static final")]
		public partial class NearestPixelCenter
			: Dova.JDK.sun.java2d.marlin.DMarlinRenderingEngine.NormalizingPathIterator
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static NearestPixelCenter()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/marlin/DMarlinRenderingEngine$NormalizingPathIterator$NearestPixelCenter;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "NearestPixelCenter", "([D)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "normCoord", "(D)D"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public NearestPixelCenter(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("([D)V", "")]
			public NearestPixelCenter(JavaArray<double> arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/java2d/marlin/DMarlinRenderingEngine$NormalizingPathIterator$NearestPixelCenter;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(D)D", "")]
			public double normCoord(double arg0)
			{
				var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}
		}
	}
}
