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

namespace Dova.JDK.sun.java2d.pipe;

[JniSignatureAttribute("Lsun/java2d/pipe/SpanShapeRenderer;", "public abstract")]
public partial class SpanShapeRenderer
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.java2d.pipe.ShapeDrawPipe
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SpanShapeRenderer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/pipe/SpanShapeRenderer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NON_RECTILINEAR_TRANSFORM_MASK", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fill", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startSequence", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;Ljava/awt/Rectangle;[I)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endSequence", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "renderBox", "(Ljava/lang/Object;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "renderSpans", "(Lsun/java2d/SunGraphics2D;Lsun/java2d/pipe/Region;Ljava/awt/Shape;Lsun/java2d/pipe/ShapeSpanIterator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "renderRect", "(Lsun/java2d/SunGraphics2D;Ljava/awt/geom/Rectangle2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spanClipLoop", "(Ljava/lang/Object;Lsun/java2d/pipe/SpanIterator;Lsun/java2d/pipe/Region;[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "draw", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;)V"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int NON_RECTILINEAR_TRANSFORM_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SpanShapeRenderer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SpanShapeRenderer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/pipe/SpanShapeRenderer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;)V", "public")]
	public void fill(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Shape arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;Ljava/awt/Rectangle;[I)Ljava/lang/Object;", "public abstract")]
	public Dova.JDK.java.lang.Object startSequence(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.java.awt.Rectangle arg2, JavaArray<int> arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public abstract")]
	public void endSequence(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;IIII)V", "public abstract")]
	public void renderBox(Dova.JDK.java.lang.Object arg0, int arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Lsun/java2d/pipe/Region;Ljava/awt/Shape;Lsun/java2d/pipe/ShapeSpanIterator;)V", "public")]
	public void renderSpans(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.sun.java2d.pipe.Region arg1, Dova.JDK.java.awt.Shape arg2, Dova.JDK.sun.java2d.pipe.ShapeSpanIterator arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/geom/Rectangle2D;)V", "public")]
	public void renderRect(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.geom.Rectangle2D arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Lsun/java2d/pipe/SpanIterator;Lsun/java2d/pipe/Region;[I)V", "public")]
	public void spanClipLoop(Dova.JDK.java.lang.Object arg0, Dova.JDK.sun.java2d.pipe.SpanIterator arg1, Dova.JDK.sun.java2d.pipe.Region arg2, JavaArray<int> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;)V", "public")]
	public void draw(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Shape arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/SpanShapeRenderer$Simple;", "public static")]
	public partial class Simple
		: Dova.JDK.sun.java2d.pipe.SpanShapeRenderer
		, Dova.JDK.sun.java2d.pipe.LoopBasedPipe
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Simple()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/pipe/SpanShapeRenderer$Simple;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startSequence", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;Ljava/awt/Rectangle;[I)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endSequence", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "renderBox", "(Ljava/lang/Object;IIII)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Simple(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Simple() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/pipe/SpanShapeRenderer$Simple;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;Ljava/awt/Rectangle;[I)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object startSequence(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.java.awt.Rectangle arg2, JavaArray<int> arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
		public void endSequence(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;IIII)V", "public")]
		public void renderBox(Dova.JDK.java.lang.Object arg0, int arg1, int arg2, int arg3, int arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/SpanShapeRenderer$Composite;", "public static")]
	public partial class Composite
		: Dova.JDK.sun.java2d.pipe.SpanShapeRenderer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Composite()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/pipe/SpanShapeRenderer$Composite;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "comppipe", "Lsun/java2d/pipe/CompositePipe;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/pipe/CompositePipe;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startSequence", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;Ljava/awt/Rectangle;[I)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endSequence", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "renderBox", "(Ljava/lang/Object;IIII)V"));
		}

		[JniSignatureAttribute("Lsun/java2d/pipe/CompositePipe;", "")]
		public Dova.JDK.sun.java2d.pipe.CompositePipe comppipe_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.CompositePipe>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Composite(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/java2d/pipe/CompositePipe;)V", "public")]
		public Composite(Dova.JDK.sun.java2d.pipe.CompositePipe arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/pipe/SpanShapeRenderer$Composite;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;Ljava/awt/Rectangle;[I)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object startSequence(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.java.awt.Rectangle arg2, JavaArray<int> arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
		public void endSequence(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;IIII)V", "public")]
		public void renderBox(Dova.JDK.java.lang.Object arg0, int arg1, int arg2, int arg3, int arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
		}
	}
}
