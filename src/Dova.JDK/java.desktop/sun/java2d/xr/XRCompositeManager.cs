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

[JniSignatureAttribute("Lsun/java2d/xr/XRCompositeManager;", "public")]
public partial class XRCompositeManager
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XRCompositeManager()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/xr/XRCompositeManager;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "enableGradCache", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/java2d/xr/XRCompositeManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SOLID", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TEXTURE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GRADIENT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "srcType", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "solidSrc32", "Lsun/java2d/xr/XRSolidSrcPict;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "texture", "Lsun/java2d/xr/XRSurfaceData;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gradient", "Lsun/java2d/xr/XRSurfaceData;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "alphaMask", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "solidColor", "Lsun/java2d/xr/XRColor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "extraAlpha", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "compRule", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "alphaColor", "Lsun/java2d/xr/XRColor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "solidSrcPict", "Lsun/java2d/xr/XRSurfaceData;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "alphaMaskPict", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gradCachePixmap", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gradCachePicture", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xorEnabled", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "validatedPixel", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "validatedComp", "Ljava/awt/Composite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "validatedPaint", "Ljava/awt/Paint;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "validatedExtraAlpha", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "con", "Lsun/java2d/xr/XRBackend;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maskBuffer", "Lsun/java2d/xr/MaskTileManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "textRenderer", "Lsun/font/XRTextRenderer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maskImage", "Lsun/java2d/xr/XRMaskImage;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/xr/XRSurfaceData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Lsun/java2d/xr/XRSurfaceData;)Lsun/java2d/xr/XRCompositeManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateCompositeState", "(Ljava/awt/Composite;Ljava/awt/geom/AffineTransform;Ljava/awt/Paint;Lsun/java2d/SunGraphics2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compositeBlit", "(Lsun/java2d/xr/XRSurfaceData;Lsun/java2d/xr/XRSurfaceData;IIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBackend", "()Lsun/java2d/xr/XRBackend;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaskBuffer", "()Lsun/java2d/xr/MaskTileManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTextRenderer", "()Lsun/font/XRTextRenderer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaskImage", "()Lsun/java2d/xr/XRMaskImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExtraAlphaMask", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCompRule", "()B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "XRComposite", "(IIIIIIIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initResources", "(Lsun/java2d/xr/XRSurfaceData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "XRResetPaint", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentSource", "()Lsun/java2d/xr/XRSurfaceData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTexturePaintActive", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAlphaColor", "()Lsun/java2d/xr/XRColor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGradientPaint", "(Lsun/java2d/xr/XRSurfaceData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTexturePaint", "(Lsun/java2d/xr/XRSurfaceData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "maskRequired", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "XRRenderRectangles", "(Lsun/java2d/xr/XRSurfaceData;Lsun/java2d/xr/GrowableRectArray;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "XRCompositeRectangles", "(Lsun/java2d/xr/XRSurfaceData;Lsun/java2d/xr/GrowableRectArray;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compositeText", "(Lsun/java2d/xr/XRSurfaceData;IIIILsun/java2d/xr/GrowableEltArray;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaskColor", "()Lsun/java2d/xr/XRColor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSolidPaintActive", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExtraAlpha", "()F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setForeground", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setComposite", "(Ljava/awt/Composite;)V"));
	}

	[JniSignatureAttribute("Z", "private static")]
	public static bool enableGradCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRCompositeManager;", "private static")]
	public static Dova.JDK.sun.java2d.xr.XRCompositeManager instance_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRCompositeManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int SOLID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int TEXTURE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int GRADIENT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int srcType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRSolidSrcPict;", "")]
	public Dova.JDK.sun.java2d.xr.XRSolidSrcPict solidSrc32_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRSolidSrcPict>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRSurfaceData;", "")]
	public Dova.JDK.sun.java2d.xr.XRSurfaceData texture_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRSurfaceData>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRSurfaceData;", "")]
	public Dova.JDK.sun.java2d.xr.XRSurfaceData gradient_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRSurfaceData>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int alphaMask_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRColor;", "")]
	public Dova.JDK.sun.java2d.xr.XRColor solidColor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRColor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("F", "")]
	public float extraAlpha_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("B", "")]
	public byte compRule_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRColor;", "")]
	public Dova.JDK.sun.java2d.xr.XRColor alphaColor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRColor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRSurfaceData;", "")]
	public Dova.JDK.sun.java2d.xr.XRSurfaceData solidSrcPict_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRSurfaceData>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int alphaMaskPict_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int gradCachePixmap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int gradCachePicture_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool xorEnabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int validatedPixel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Composite;", "")]
	public Dova.JDK.java.awt.Composite validatedComp_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Composite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Paint;", "")]
	public Dova.JDK.java.awt.Paint validatedPaint_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("F", "")]
	public float validatedExtraAlpha_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRBackend;", "")]
	public Dova.JDK.sun.java2d.xr.XRBackend con_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRBackend>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/MaskTileManager;", "")]
	public Dova.JDK.sun.java2d.xr.MaskTileManager maskBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.MaskTileManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/font/XRTextRenderer;", "")]
	public Dova.JDK.sun.font.XRTextRenderer textRenderer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.font.XRTextRenderer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRMaskImage;", "")]
	public Dova.JDK.sun.java2d.xr.XRMaskImage maskImage_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRMaskImage>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XRCompositeManager(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/java2d/xr/XRSurfaceData;)V", "private")]
	public XRCompositeManager(Dova.JDK.sun.java2d.xr.XRSurfaceData arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/xr/XRCompositeManager;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/xr/XRSurfaceData;)Lsun/java2d/xr/XRCompositeManager;", "public static synchronized")]
	public static Dova.JDK.sun.java2d.xr.XRCompositeManager getInstance(Dova.JDK.sun.java2d.xr.XRSurfaceData arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRCompositeManager>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Composite;Ljava/awt/geom/AffineTransform;Ljava/awt/Paint;Lsun/java2d/SunGraphics2D;)V", "public")]
	public void validateCompositeState(Dova.JDK.java.awt.Composite arg0, Dova.JDK.java.awt.geom.AffineTransform arg1, Dova.JDK.java.awt.Paint arg2, Dova.JDK.sun.java2d.SunGraphics2D arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/xr/XRSurfaceData;Lsun/java2d/xr/XRSurfaceData;IIIIII)V", "public")]
	public void compositeBlit(Dova.JDK.sun.java2d.xr.XRSurfaceData arg0, Dova.JDK.sun.java2d.xr.XRSurfaceData arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("()Lsun/java2d/xr/XRBackend;", "public")]
	public Dova.JDK.sun.java2d.xr.XRBackend getBackend()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRBackend>(ret);
	}

	[JniSignatureAttribute("()Lsun/java2d/xr/MaskTileManager;", "public")]
	public Dova.JDK.sun.java2d.xr.MaskTileManager getMaskBuffer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.MaskTileManager>(ret);
	}

	[JniSignatureAttribute("()Lsun/font/XRTextRenderer;", "public")]
	public Dova.JDK.sun.font.XRTextRenderer getTextRenderer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.XRTextRenderer>(ret);
	}

	[JniSignatureAttribute("()Lsun/java2d/xr/XRMaskImage;", "public")]
	public Dova.JDK.sun.java2d.xr.XRMaskImage getMaskImage()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRMaskImage>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getExtraAlphaMask()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()B", "public")]
	public byte getCompRule()
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("(IIIIIIIIIII)V", "public")]
	public void XRComposite(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
	}

	[JniSignatureAttribute("(Lsun/java2d/xr/XRSurfaceData;)V", "public")]
	public void initResources(Dova.JDK.sun.java2d.xr.XRSurfaceData arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void XRResetPaint()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("()Lsun/java2d/xr/XRSurfaceData;", "protected")]
	public Dova.JDK.sun.java2d.xr.XRSurfaceData getCurrentSource()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRSurfaceData>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isTexturePaintActive()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/java2d/xr/XRColor;", "public")]
	public Dova.JDK.sun.java2d.xr.XRColor getAlphaColor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRColor>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/xr/XRSurfaceData;)V", "public")]
	public void setGradientPaint(Dova.JDK.sun.java2d.xr.XRSurfaceData arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Lsun/java2d/xr/XRSurfaceData;)V", "public")]
	public void setTexturePaint(Dova.JDK.sun.java2d.xr.XRSurfaceData arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool maskRequired()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/xr/XRSurfaceData;Lsun/java2d/xr/GrowableRectArray;)V", "public")]
	public void XRRenderRectangles(Dova.JDK.sun.java2d.xr.XRSurfaceData arg0, Dova.JDK.sun.java2d.xr.GrowableRectArray arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/java2d/xr/XRSurfaceData;Lsun/java2d/xr/GrowableRectArray;)V", "public")]
	public void XRCompositeRectangles(Dova.JDK.sun.java2d.xr.XRSurfaceData arg0, Dova.JDK.sun.java2d.xr.GrowableRectArray arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/java2d/xr/XRSurfaceData;IIIILsun/java2d/xr/GrowableEltArray;)V", "public")]
	public void compositeText(Dova.JDK.sun.java2d.xr.XRSurfaceData arg0, int arg1, int arg2, int arg3, int arg4, Dova.JDK.sun.java2d.xr.GrowableEltArray arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("()Lsun/java2d/xr/XRColor;", "public")]
	public Dova.JDK.sun.java2d.xr.XRColor getMaskColor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRColor>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isSolidPaintActive()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("()F", "public")]
	public float getExtraAlpha()
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setForeground(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Composite;)V", "private")]
	public void setComposite(Dova.JDK.java.awt.Composite arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}
}
