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

namespace Dova.JDK.sun.java2d.xr;

[JniSignatureAttribute("Lsun/java2d/xr/XRRenderer;", "public")]
public partial class XRRenderer
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.java2d.pipe.PixelDrawPipe
	, Dova.JDK.sun.java2d.pipe.PixelFillPipe
	, Dova.JDK.sun.java2d.pipe.ShapeDrawPipe
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XRRenderer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/xr/XRRenderer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "drawHandler", "Lsun/java2d/xr/XRRenderer$XRDrawHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tileManager", "Lsun/java2d/xr/MaskTileManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lineGen", "Lsun/java2d/xr/XRDrawLine;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rectBuffer", "Lsun/java2d/xr/GrowableRectArray;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/xr/MaskTileManager;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fill", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawLine", "(Lsun/java2d/SunGraphics2D;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawPolygon", "(Lsun/java2d/SunGraphics2D;[I[II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillPolygon", "(Lsun/java2d/SunGraphics2D;[I[II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawRoundRect", "(Lsun/java2d/SunGraphics2D;IIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillRoundRect", "(Lsun/java2d/SunGraphics2D;IIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawOval", "(Lsun/java2d/SunGraphics2D;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillOval", "(Lsun/java2d/SunGraphics2D;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawArc", "(Lsun/java2d/SunGraphics2D;IIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillArc", "(Lsun/java2d/SunGraphics2D;IIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawPolyline", "(Lsun/java2d/SunGraphics2D;[I[II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawRect", "(Lsun/java2d/SunGraphics2D;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateSurface", "(Lsun/java2d/SunGraphics2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillSpans", "(Lsun/java2d/SunGraphics2D;Lsun/java2d/pipe/SpanIterator;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillPath", "(Lsun/java2d/SunGraphics2D;Ljava/awt/geom/Path2D$Float;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillRect", "(Lsun/java2d/SunGraphics2D;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "draw", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawPath", "(Lsun/java2d/SunGraphics2D;Ljava/awt/geom/Path2D$Float;II)V"));
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRRenderer$XRDrawHandler;", "")]
	public Dova.JDK.sun.java2d.xr.XRRenderer.XRDrawHandler drawHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRRenderer.XRDrawHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/MaskTileManager;", "")]
	public Dova.JDK.sun.java2d.xr.MaskTileManager tileManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.MaskTileManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRDrawLine;", "")]
	public Dova.JDK.sun.java2d.xr.XRDrawLine lineGen_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRDrawLine>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/GrowableRectArray;", "")]
	public Dova.JDK.sun.java2d.xr.GrowableRectArray rectBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.GrowableRectArray>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XRRenderer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/java2d/xr/MaskTileManager;)V", "public")]
	public XRRenderer(Dova.JDK.sun.java2d.xr.MaskTileManager arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/xr/XRRenderer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;)V", "public")]
	public void fill(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Shape arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIII)V", "public")]
	public void drawLine(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;[I[II)V", "public")]
	public void drawPolygon(Dova.JDK.sun.java2d.SunGraphics2D arg0, JavaArray<int> arg1, JavaArray<int> arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;[I[II)V", "public")]
	public void fillPolygon(Dova.JDK.sun.java2d.SunGraphics2D arg0, JavaArray<int> arg1, JavaArray<int> arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIIIII)V", "public")]
	public void drawRoundRect(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIIIII)V", "public")]
	public void fillRoundRect(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIII)V", "public")]
	public void drawOval(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIII)V", "public")]
	public void fillOval(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIIIII)V", "public")]
	public void drawArc(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIIIII)V", "public")]
	public void fillArc(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;[I[II)V", "public")]
	public void drawPolyline(Dova.JDK.sun.java2d.SunGraphics2D arg0, JavaArray<int> arg1, JavaArray<int> arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIII)V", "public")]
	public void drawRect(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;)V", "private")]
	public void validateSurface(Dova.JDK.sun.java2d.SunGraphics2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Lsun/java2d/pipe/SpanIterator;II)V", "protected")]
	public void fillSpans(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.sun.java2d.pipe.SpanIterator arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/geom/Path2D$Float;II)V", "protected")]
	public void fillPath(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.geom.Path2D.Float arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIII)V", "public")]
	public void fillRect(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;)V", "public")]
	public void draw(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Shape arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/geom/Path2D$Float;II)V", "protected")]
	public void drawPath(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.geom.Path2D.Float arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRRenderer$XRDrawHandler;", "private")]
	public partial class XRDrawHandler
		: Dova.JDK.sun.java2d.loops.ProcessPath.DrawHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XRDrawHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/xr/XRRenderer$XRDrawHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "region", "Lsun/java2d/xr/DirtyRegion;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/java2d/xr/XRRenderer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/xr/XRRenderer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validate", "(Lsun/java2d/SunGraphics2D;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawLine", "(IIII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawPixel", "(II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawScanline", "(III)V"));
		}

		[JniSignatureAttribute("Lsun/java2d/xr/DirtyRegion;", "")]
		public Dova.JDK.sun.java2d.xr.DirtyRegion region_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.DirtyRegion>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/java2d/xr/XRRenderer;", "final")]
		public Dova.JDK.sun.java2d.xr.XRRenderer this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRRenderer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XRDrawHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/java2d/xr/XRRenderer;)V", "")]
		public XRDrawHandler(Dova.JDK.sun.java2d.xr.XRRenderer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/xr/XRRenderer$XRDrawHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;)V", "")]
		public void validate(Dova.JDK.sun.java2d.SunGraphics2D arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(IIII)V", "public")]
		public void drawLine(int arg0, int arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(II)V", "public")]
		public void drawPixel(int arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(III)V", "public")]
		public void drawScanline(int arg0, int arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		}
	}
}
