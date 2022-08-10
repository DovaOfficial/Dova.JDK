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

namespace Dova.JDK.sun.java2d.xr;

[JniSignatureAttribute("Lsun/java2d/xr/XRPaints;", "abstract")]
public partial class XRPaints
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XRPaints()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/xr/XRPaints;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "xrCompMan", "Lsun/java2d/xr/XRCompositeManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "xrGradient", "Lsun/java2d/xr/XRPaints$XRGradient;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "xrLinearGradient", "Lsun/java2d/xr/XRPaints$XRLinearGradient;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "xrRadialGradient", "Lsun/java2d/xr/XRPaints$XRRadialGradient;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "xrTexture", "Lsun/java2d/xr/XRPaints$XRTexture;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "XRPaints", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "register", "(Lsun/java2d/xr/XRCompositeManager;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isValid", "(Lsun/java2d/SunGraphics2D;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getXRPaint", "(Lsun/java2d/SunGraphics2D;)Lsun/java2d/xr/XRPaints;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isPaintValid", "(Lsun/java2d/SunGraphics2D;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setXRPaint", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Paint;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "colorToIntArgbPixel", "(Ljava/awt/Color;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getGradientLength", "(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "convertToIntArgbPixels", "([Ljava/awt/Color;)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setPaint", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Paint;)V"));
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRCompositeManager;", "static")]
	public static Dova.JDK.sun.java2d.xr.XRCompositeManager xrCompMan_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRCompositeManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRPaints$XRGradient;", "static final")]
	public static Dova.JDK.sun.java2d.xr.XRPaints.XRGradient xrGradient_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRPaints.XRGradient>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRPaints$XRLinearGradient;", "static final")]
	public static Dova.JDK.sun.java2d.xr.XRPaints.XRLinearGradient xrLinearGradient_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRPaints.XRLinearGradient>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRPaints$XRRadialGradient;", "static final")]
	public static Dova.JDK.sun.java2d.xr.XRPaints.XRRadialGradient xrRadialGradient_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRPaints.XRRadialGradient>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRPaints$XRTexture;", "static final")]
	public static Dova.JDK.sun.java2d.xr.XRPaints.XRTexture xrTexture_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRPaints.XRTexture>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XRPaints(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public XRPaints() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/xr/XRPaints;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/xr/XRCompositeManager;)V", "public static")]
	public static void register(Dova.JDK.sun.java2d.xr.XRCompositeManager arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;)Z", "static")]
	public static bool isValid(Dova.JDK.sun.java2d.SunGraphics2D arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;)Lsun/java2d/xr/XRPaints;", "private static")]
	public static Dova.JDK.sun.java2d.xr.XRPaints getXRPaint(Dova.JDK.sun.java2d.SunGraphics2D arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRPaints>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;)Z", "abstract")]
	public bool isPaintValid(Dova.JDK.sun.java2d.SunGraphics2D arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Paint;)V", "abstract")]
	public void setXRPaint(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Paint arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Color;)I", "public")]
	public int colorToIntArgbPixel(Dova.JDK.java.awt.Color arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;)I", "public")]
	public int getGradientLength(Dova.JDK.java.awt.geom.Point2D arg0, Dova.JDK.java.awt.geom.Point2D arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/awt/Color;)[I", "public")]
	public JavaArray<int> convertToIntArgbPixels(JavaArray<Dova.JDK.java.awt.Color> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Paint;)V", "static")]
	public static void setPaint(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Paint arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRPaints$XRGradient;", "private static")]
	public partial class XRGradient
		: Dova.JDK.sun.java2d.xr.XRPaints
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XRGradient()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/xr/XRPaints$XRGradient;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "XRGradient", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isPaintValid", "(Lsun/java2d/SunGraphics2D;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setXRPaint", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Paint;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XRGradient(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public XRGradient() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/xr/XRPaints$XRGradient;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;)Z", "")]
		public bool isPaintValid(Dova.JDK.sun.java2d.SunGraphics2D arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Paint;)V", "")]
		public void setXRPaint(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Paint arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRPaints$XRLinearGradient;", "private static")]
	public partial class XRLinearGradient
		: Dova.JDK.sun.java2d.xr.XRPaints
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XRLinearGradient()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/xr/XRPaints$XRLinearGradient;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "XRLinearGradient", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isPaintValid", "(Lsun/java2d/SunGraphics2D;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setXRPaint", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Paint;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XRLinearGradient(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public XRLinearGradient() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/xr/XRPaints$XRLinearGradient;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;)Z", "")]
		public bool isPaintValid(Dova.JDK.sun.java2d.SunGraphics2D arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Paint;)V", "")]
		public void setXRPaint(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Paint arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRPaints$XRRadialGradient;", "private static")]
	public partial class XRRadialGradient
		: Dova.JDK.sun.java2d.xr.XRPaints
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XRRadialGradient()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/xr/XRPaints$XRRadialGradient;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "XRRadialGradient", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isPaintValid", "(Lsun/java2d/SunGraphics2D;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setXRPaint", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Paint;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XRRadialGradient(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public XRRadialGradient() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/xr/XRPaints$XRRadialGradient;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;)Z", "")]
		public bool isPaintValid(Dova.JDK.sun.java2d.SunGraphics2D arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Paint;)V", "")]
		public void setXRPaint(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Paint arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRPaints$XRTexture;", "private static")]
	public partial class XRTexture
		: Dova.JDK.sun.java2d.xr.XRPaints
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XRTexture()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/xr/XRPaints$XRTexture;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "XRTexture", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isPaintValid", "(Lsun/java2d/SunGraphics2D;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setXRPaint", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Paint;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAccSrcSurface", "(Lsun/java2d/xr/XRSurfaceData;Ljava/awt/image/BufferedImage;)Lsun/java2d/xr/XRSurfaceData;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XRTexture(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public XRTexture() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/xr/XRPaints$XRTexture;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;)Z", "")]
		public bool isPaintValid(Dova.JDK.sun.java2d.SunGraphics2D arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Paint;)V", "")]
		public void setXRPaint(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Paint arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Lsun/java2d/xr/XRSurfaceData;Ljava/awt/image/BufferedImage;)Lsun/java2d/xr/XRSurfaceData;", "private")]
		public Dova.JDK.sun.java2d.xr.XRSurfaceData getAccSrcSurface(Dova.JDK.sun.java2d.xr.XRSurfaceData arg0, Dova.JDK.java.awt.image.BufferedImage arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRSurfaceData>(ret);
		}
	}
}
