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

[JniSignatureAttribute("Lsun/java2d/pipe/PixelToShapeConverter;", "public")]
public partial class PixelToShapeConverter
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.java2d.pipe.PixelDrawPipe
	, Dova.JDK.sun.java2d.pipe.PixelFillPipe
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PixelToShapeConverter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/pipe/PixelToShapeConverter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outpipe", "Lsun/java2d/pipe/ShapeDrawPipe;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/pipe/ShapeDrawPipe;)V"));
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
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makePoly", "([I[IIZ)Ljava/awt/Shape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillRect", "(Lsun/java2d/SunGraphics2D;IIII)V"));
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/ShapeDrawPipe;", "")]
	public Dova.JDK.sun.java2d.pipe.ShapeDrawPipe outpipe_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.ShapeDrawPipe>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PixelToShapeConverter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/ShapeDrawPipe;)V", "public")]
	public PixelToShapeConverter(Dova.JDK.sun.java2d.pipe.ShapeDrawPipe arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/pipe/PixelToShapeConverter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIII)V", "public")]
	public void drawLine(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;[I[II)V", "public")]
	public void drawPolygon(Dova.JDK.sun.java2d.SunGraphics2D arg0, JavaArray<int> arg1, JavaArray<int> arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;[I[II)V", "public")]
	public void fillPolygon(Dova.JDK.sun.java2d.SunGraphics2D arg0, JavaArray<int> arg1, JavaArray<int> arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIIIII)V", "public")]
	public void drawRoundRect(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIIIII)V", "public")]
	public void fillRoundRect(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIII)V", "public")]
	public void drawOval(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIII)V", "public")]
	public void fillOval(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIIIII)V", "public")]
	public void drawArc(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIIIII)V", "public")]
	public void fillArc(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;[I[II)V", "public")]
	public void drawPolyline(Dova.JDK.sun.java2d.SunGraphics2D arg0, JavaArray<int> arg1, JavaArray<int> arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIII)V", "public")]
	public void drawRect(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("([I[IIZ)Ljava/awt/Shape;", "private")]
	public Dova.JDK.java.awt.Shape makePoly(JavaArray<int> arg0, JavaArray<int> arg1, int arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIII)V", "public")]
	public void fillRect(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4);
	}
}
