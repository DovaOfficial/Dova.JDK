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

namespace Dova.JDK.sun.java2d.opengl;

[JniSignatureAttribute("Lsun/java2d/opengl/OGLRenderer;", "")]
public partial class OGLRenderer
	: Dova.JDK.sun.java2d.pipe.BufferedRenderPipe
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static OGLRenderer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/opengl/OGLRenderer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "OGLRenderer", "(Lsun/java2d/pipe/RenderQueue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyArea", "(Lsun/java2d/SunGraphics2D;IIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "traceWrap", "()Lsun/java2d/opengl/OGLRenderer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "drawPoly", "([I[IIZII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "validateContextAA", "(Lsun/java2d/SunGraphics2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "access$400", "(Lsun/java2d/opengl/OGLRenderer;Lsun/java2d/SunGraphics2D;Lsun/java2d/pipe/SpanIterator;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "validateContext", "(Lsun/java2d/SunGraphics2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "access$000", "(Lsun/java2d/opengl/OGLRenderer;)Lsun/java2d/pipe/RenderQueue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "access$100", "(Lsun/java2d/opengl/OGLRenderer;Lsun/java2d/SunGraphics2D;[I[IIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "access$200", "(Lsun/java2d/opengl/OGLRenderer;Lsun/java2d/SunGraphics2D;Ljava/awt/geom/Path2D$Float;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "access$300", "(Lsun/java2d/opengl/OGLRenderer;Lsun/java2d/SunGraphics2D;Ljava/awt/geom/Path2D$Float;II)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public OGLRenderer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;)V", "")]
	public OGLRenderer(Dova.JDK.sun.java2d.pipe.RenderQueue arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/opengl/OGLRenderer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIIIII)V", "")]
	public void copyArea(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("()Lsun/java2d/opengl/OGLRenderer;", "")]
	public Dova.JDK.sun.java2d.opengl.OGLRenderer traceWrap()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.opengl.OGLRenderer>(ret);
	}

	[JniSignatureAttribute("([I[IIZII)V", "protected native")]
	public void drawPoly(JavaArray<int> arg0, JavaArray<int> arg1, int arg2, bool arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;)V", "protected")]
	public void validateContextAA(Dova.JDK.sun.java2d.SunGraphics2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Lsun/java2d/opengl/OGLRenderer;Lsun/java2d/SunGraphics2D;Lsun/java2d/pipe/SpanIterator;II)V", "static")]
	public static void access_400(Dova.JDK.sun.java2d.opengl.OGLRenderer arg0, Dova.JDK.sun.java2d.SunGraphics2D arg1, Dova.JDK.sun.java2d.pipe.SpanIterator arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;)V", "protected")]
	public void validateContext(Dova.JDK.sun.java2d.SunGraphics2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Lsun/java2d/opengl/OGLRenderer;)Lsun/java2d/pipe/RenderQueue;", "static")]
	public static Dova.JDK.sun.java2d.pipe.RenderQueue access_000(Dova.JDK.sun.java2d.opengl.OGLRenderer arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderQueue>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/opengl/OGLRenderer;Lsun/java2d/SunGraphics2D;[I[IIZ)V", "static")]
	public static void access_100(Dova.JDK.sun.java2d.opengl.OGLRenderer arg0, Dova.JDK.sun.java2d.SunGraphics2D arg1, JavaArray<int> arg2, JavaArray<int> arg3, int arg4, bool arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lsun/java2d/opengl/OGLRenderer;Lsun/java2d/SunGraphics2D;Ljava/awt/geom/Path2D$Float;II)V", "static")]
	public static void access_200(Dova.JDK.sun.java2d.opengl.OGLRenderer arg0, Dova.JDK.sun.java2d.SunGraphics2D arg1, Dova.JDK.java.awt.geom.Path2D.Float arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lsun/java2d/opengl/OGLRenderer;Lsun/java2d/SunGraphics2D;Ljava/awt/geom/Path2D$Float;II)V", "static")]
	public static void access_300(Dova.JDK.sun.java2d.opengl.OGLRenderer arg0, Dova.JDK.sun.java2d.SunGraphics2D arg1, Dova.JDK.java.awt.geom.Path2D.Float arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("Lsun/java2d/opengl/OGLRenderer$Tracer;", "private static")]
	public partial class Tracer
		: Dova.JDK.sun.java2d.opengl.OGLRenderer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Tracer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/opengl/OGLRenderer$Tracer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "oglr", "Lsun/java2d/opengl/OGLRenderer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Tracer", "(Lsun/java2d/opengl/OGLRenderer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "drawLine", "(Lsun/java2d/SunGraphics2D;IIII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyArea", "(Lsun/java2d/SunGraphics2D;IIIIII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "drawRect", "(Lsun/java2d/SunGraphics2D;IIII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fillSpans", "(Lsun/java2d/SunGraphics2D;Lsun/java2d/pipe/SpanIterator;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fillParallelogram", "(Lsun/java2d/SunGraphics2D;DDDDDDDDDD)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "drawParallelogram", "(Lsun/java2d/SunGraphics2D;DDDDDDDDDDDD)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "drawPoly", "(Lsun/java2d/SunGraphics2D;[I[IIZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAAParallelogramPipe", "()Lsun/java2d/pipe/ParallelogramPipe;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fillPath", "(Lsun/java2d/SunGraphics2D;Ljava/awt/geom/Path2D$Float;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "validateContext", "(Lsun/java2d/SunGraphics2D;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fillRect", "(Lsun/java2d/SunGraphics2D;IIII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "drawPath", "(Lsun/java2d/SunGraphics2D;Ljava/awt/geom/Path2D$Float;II)V"));
		}

		[JniSignatureAttribute("Lsun/java2d/opengl/OGLRenderer;", "private")]
		public Dova.JDK.sun.java2d.opengl.OGLRenderer oglr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.opengl.OGLRenderer>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Tracer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/java2d/opengl/OGLRenderer;)V", "")]
		public Tracer(Dova.JDK.sun.java2d.opengl.OGLRenderer arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/opengl/OGLRenderer$Tracer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIII)V", "public")]
		public void drawLine(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		}

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIIIII)V", "public")]
		public void copyArea(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		}

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIII)V", "public")]
		public void drawRect(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
		}

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Lsun/java2d/pipe/SpanIterator;II)V", "protected")]
		public void fillSpans(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.sun.java2d.pipe.SpanIterator arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;DDDDDDDDDD)V", "public")]
		public void fillParallelogram(Dova.JDK.sun.java2d.SunGraphics2D arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7, double arg8, double arg9, double arg10)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
		}

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;DDDDDDDDDDDD)V", "public")]
		public void drawParallelogram(Dova.JDK.sun.java2d.SunGraphics2D arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7, double arg8, double arg9, double arg10, double arg11, double arg12)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
		}

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;[I[IIZ)V", "protected")]
		public void drawPoly(Dova.JDK.sun.java2d.SunGraphics2D arg0, JavaArray<int> arg1, JavaArray<int> arg2, int arg3, bool arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4);
		}

		[JniSignatureAttribute("()Lsun/java2d/pipe/ParallelogramPipe;", "public")]
		public Dova.JDK.sun.java2d.pipe.ParallelogramPipe getAAParallelogramPipe()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.ParallelogramPipe>(ret);
		}

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/geom/Path2D$Float;II)V", "protected")]
		public void fillPath(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.geom.Path2D.Float arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;)V", "protected")]
		public void validateContext(Dova.JDK.sun.java2d.SunGraphics2D arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIII)V", "public")]
		public void fillRect(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4);
		}

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/geom/Path2D$Float;II)V", "protected")]
		public void drawPath(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.geom.Path2D.Float arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
		}
	}
}
