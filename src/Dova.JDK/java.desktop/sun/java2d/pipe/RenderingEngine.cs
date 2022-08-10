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

namespace Dova.JDK.sun.java2d.pipe;

[JniSignatureAttribute("Lsun/java2d/pipe/RenderingEngine;", "public abstract")]
public partial class RenderingEngine
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RenderingEngine()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/pipe/RenderingEngine;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "reImpl", "Lsun/java2d/pipe/RenderingEngine;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "RenderingEngine", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "()Lsun/java2d/pipe/RenderingEngine;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createStrokedShape", "(Ljava/awt/Shape;FIIF[FF)Ljava/awt/Shape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "strokeTo", "(Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;Lsun/java2d/pipe/Region;Ljava/awt/BasicStroke;ZZZLsun/awt/geom/PathConsumer2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "strokeTo", "(Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;Ljava/awt/BasicStroke;ZZZLsun/awt/geom/PathConsumer2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAATileGenerator", "(DDDDDDDDLsun/java2d/pipe/Region;[I)Lsun/java2d/pipe/AATileGenerator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAATileGenerator", "(Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;Lsun/java2d/pipe/Region;Ljava/awt/BasicStroke;ZZ[I)Lsun/java2d/pipe/AATileGenerator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMinimumAAPenSize", "()F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "feedConsumer", "(Ljava/awt/geom/PathIterator;Lsun/awt/geom/PathConsumer2D;)V"));
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/RenderingEngine;", "private static")]
	public static Dova.JDK.sun.java2d.pipe.RenderingEngine reImpl_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderingEngine>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RenderingEngine(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public RenderingEngine() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/pipe/RenderingEngine;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/java2d/pipe/RenderingEngine;", "public static synchronized")]
	public static Dova.JDK.sun.java2d.pipe.RenderingEngine getInstance()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderingEngine>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;FIIF[FF)Ljava/awt/Shape;", "public abstract")]
	public Dova.JDK.java.awt.Shape createStrokedShape(Dova.JDK.java.awt.Shape arg0, float arg1, int arg2, int arg3, float arg4, JavaArray<float> arg5, float arg6)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;Lsun/java2d/pipe/Region;Ljava/awt/BasicStroke;ZZZLsun/awt/geom/PathConsumer2D;)V", "public")]
	public void strokeTo(Dova.JDK.java.awt.Shape arg0, Dova.JDK.java.awt.geom.AffineTransform arg1, Dova.JDK.sun.java2d.pipe.Region arg2, Dova.JDK.java.awt.BasicStroke arg3, bool arg4, bool arg5, bool arg6, Dova.JDK.sun.awt.geom.PathConsumer2D arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;Ljava/awt/BasicStroke;ZZZLsun/awt/geom/PathConsumer2D;)V", "public abstract")]
	public void strokeTo(Dova.JDK.java.awt.Shape arg0, Dova.JDK.java.awt.geom.AffineTransform arg1, Dova.JDK.java.awt.BasicStroke arg2, bool arg3, bool arg4, bool arg5, Dova.JDK.sun.awt.geom.PathConsumer2D arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(DDDDDDDDLsun/java2d/pipe/Region;[I)Lsun/java2d/pipe/AATileGenerator;", "public abstract")]
	public Dova.JDK.sun.java2d.pipe.AATileGenerator getAATileGenerator(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7, Dova.JDK.sun.java2d.pipe.Region arg8, JavaArray<int> arg9)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.AATileGenerator>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;Lsun/java2d/pipe/Region;Ljava/awt/BasicStroke;ZZ[I)Lsun/java2d/pipe/AATileGenerator;", "public abstract")]
	public Dova.JDK.sun.java2d.pipe.AATileGenerator getAATileGenerator(Dova.JDK.java.awt.Shape arg0, Dova.JDK.java.awt.geom.AffineTransform arg1, Dova.JDK.sun.java2d.pipe.Region arg2, Dova.JDK.java.awt.BasicStroke arg3, bool arg4, bool arg5, JavaArray<int> arg6)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.AATileGenerator>(ret);
	}

	[JniSignatureAttribute("()F", "public abstract")]
	public float getMinimumAAPenSize()
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/geom/PathIterator;Lsun/awt/geom/PathConsumer2D;)V", "public static")]
	public static void feedConsumer(Dova.JDK.java.awt.geom.PathIterator arg0, Dova.JDK.sun.awt.geom.PathConsumer2D arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/RenderingEngine$Tracer;", "static")]
	public partial class Tracer
		: Dova.JDK.sun.java2d.pipe.RenderingEngine
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Tracer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/pipe/RenderingEngine$Tracer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "target", "Lsun/java2d/pipe/RenderingEngine;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "name", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Tracer", "(Lsun/java2d/pipe/RenderingEngine;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createStrokedShape", "(Ljava/awt/Shape;FIIF[FF)Ljava/awt/Shape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "strokeTo", "(Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;Lsun/java2d/pipe/Region;Ljava/awt/BasicStroke;ZZZLsun/awt/geom/PathConsumer2D;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "strokeTo", "(Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;Ljava/awt/BasicStroke;ZZZLsun/awt/geom/PathConsumer2D;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAATileGenerator", "(DDDDDDDDLsun/java2d/pipe/Region;[I)Lsun/java2d/pipe/AATileGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAATileGenerator", "(Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;Lsun/java2d/pipe/Region;Ljava/awt/BasicStroke;ZZ[I)Lsun/java2d/pipe/AATileGenerator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMinimumAAPenSize", "()F"));
		}

		[JniSignatureAttribute("Lsun/java2d/pipe/RenderingEngine;", "")]
		public Dova.JDK.sun.java2d.pipe.RenderingEngine target_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderingEngine>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Tracer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/java2d/pipe/RenderingEngine;)V", "public")]
		public Tracer(Dova.JDK.sun.java2d.pipe.RenderingEngine arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/pipe/RenderingEngine$Tracer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Shape;FIIF[FF)Ljava/awt/Shape;", "public")]
		public Dova.JDK.java.awt.Shape createStrokedShape(Dova.JDK.java.awt.Shape arg0, float arg1, int arg2, int arg3, float arg4, JavaArray<float> arg5, float arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;Lsun/java2d/pipe/Region;Ljava/awt/BasicStroke;ZZZLsun/awt/geom/PathConsumer2D;)V", "public")]
		public void strokeTo(Dova.JDK.java.awt.Shape arg0, Dova.JDK.java.awt.geom.AffineTransform arg1, Dova.JDK.sun.java2d.pipe.Region arg2, Dova.JDK.java.awt.BasicStroke arg3, bool arg4, bool arg5, bool arg6, Dova.JDK.sun.awt.geom.PathConsumer2D arg7)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		}

		[JniSignatureAttribute("(Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;Ljava/awt/BasicStroke;ZZZLsun/awt/geom/PathConsumer2D;)V", "public")]
		public void strokeTo(Dova.JDK.java.awt.Shape arg0, Dova.JDK.java.awt.geom.AffineTransform arg1, Dova.JDK.java.awt.BasicStroke arg2, bool arg3, bool arg4, bool arg5, Dova.JDK.sun.awt.geom.PathConsumer2D arg6)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		}

		[JniSignatureAttribute("(DDDDDDDDLsun/java2d/pipe/Region;[I)Lsun/java2d/pipe/AATileGenerator;", "public")]
		public Dova.JDK.sun.java2d.pipe.AATileGenerator getAATileGenerator(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7, Dova.JDK.sun.java2d.pipe.Region arg8, JavaArray<int> arg9)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.AATileGenerator>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;Lsun/java2d/pipe/Region;Ljava/awt/BasicStroke;ZZ[I)Lsun/java2d/pipe/AATileGenerator;", "public")]
		public Dova.JDK.sun.java2d.pipe.AATileGenerator getAATileGenerator(Dova.JDK.java.awt.Shape arg0, Dova.JDK.java.awt.geom.AffineTransform arg1, Dova.JDK.sun.java2d.pipe.Region arg2, Dova.JDK.java.awt.BasicStroke arg3, bool arg4, bool arg5, JavaArray<int> arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.AATileGenerator>(ret);
		}

		[JniSignatureAttribute("()F", "public")]
		public float getMinimumAAPenSize()
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}
	}
}
