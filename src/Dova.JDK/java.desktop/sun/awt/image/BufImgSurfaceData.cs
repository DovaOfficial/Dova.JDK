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

namespace Dova.JDK.sun.awt.image;

[JniSignatureAttribute("Lsun/awt/image/BufImgSurfaceData;", "public")]
public partial class BufImgSurfaceData
	: Dova.JDK.sun.java2d.SurfaceData
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BufImgSurfaceData()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/BufImgSurfaceData;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bufImg", "Ljava/awt/image/BufferedImage;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "graphicsConfig", "Lsun/awt/image/BufferedImageGraphicsConfig;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "solidloops", "Lsun/java2d/loops/RenderLoops;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "scaleX", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "scaleY", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DCM_RGBX_RED_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DCM_RGBX_GREEN_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DCM_RGBX_BLUE_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DCM_555X_RED_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DCM_555X_GREEN_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DCM_555X_BLUE_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DCM_4444_RED_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DCM_4444_GREEN_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DCM_4444_BLUE_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DCM_4444_ALPHA_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DCM_ARGBBM_ALPHA_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DCM_ARGBBM_RED_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DCM_ARGBBM_GREEN_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DCM_ARGBBM_BLUE_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CACHE_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "loopcache", "[Lsun/java2d/loops/RenderLoops;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "typecache", "[Lsun/java2d/loops/SurfaceType;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/image/DataBuffer;Ljava/awt/image/BufferedImage;Lsun/java2d/loops/SurfaceType;DD)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/loops/SurfaceType;Ljava/awt/image/ColorModel;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "()Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initIDs", "(Ljava/lang/Class;Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRenderLoops", "(Lsun/java2d/SunGraphics2D;)Lsun/java2d/loops/RenderLoops;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSolidLoops", "(Lsun/java2d/loops/SurfaceType;)Lsun/java2d/loops/RenderLoops;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeviceConfiguration", "()Ljava/awt/GraphicsConfiguration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createData", "(Ljava/awt/image/BufferedImage;DD)Lsun/java2d/SurfaceData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createData", "(Ljava/awt/image/BufferedImage;)Lsun/java2d/SurfaceData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createData", "(Ljava/awt/image/Raster;Ljava/awt/image/ColorModel;)Lsun/java2d/SurfaceData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReplacement", "()Lsun/java2d/SurfaceData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkCustomComposite", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDestination", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultScaleX", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultScaleY", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createDataIC", "(Ljava/awt/image/BufferedImage;Lsun/java2d/loops/SurfaceType;DD)Lsun/java2d/SurfaceData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createDataBC", "(Ljava/awt/image/BufferedImage;Lsun/java2d/loops/SurfaceType;IDD)Lsun/java2d/SurfaceData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createDataSC", "(Ljava/awt/image/BufferedImage;Lsun/java2d/loops/SurfaceType;Ljava/awt/image/IndexColorModel;DD)Lsun/java2d/SurfaceData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createDataBP", "(Ljava/awt/image/BufferedImage;Lsun/java2d/loops/SurfaceType;DD)Lsun/java2d/SurfaceData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initSolidLoops", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initRaster", "(Ljava/lang/Object;IIIIIILjava/awt/image/IndexColorModel;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRaster", "(IIII)Ljava/awt/image/Raster;"));
	}

	[JniSignatureAttribute("Ljava/awt/image/BufferedImage;", "")]
	public Dova.JDK.java.awt.image.BufferedImage bufImg_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/image/BufferedImageGraphicsConfig;", "private")]
	public Dova.JDK.sun.awt.image.BufferedImageGraphicsConfig graphicsConfig_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.BufferedImageGraphicsConfig>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/loops/RenderLoops;", "")]
	public Dova.JDK.sun.java2d.loops.RenderLoops solidloops_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.RenderLoops>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("D", "private final")]
	public double scaleX_Property
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

	[JniSignatureAttribute("D", "private final")]
	public double scaleY_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int DCM_RGBX_RED_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DCM_RGBX_GREEN_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DCM_RGBX_BLUE_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DCM_555X_RED_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DCM_555X_GREEN_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DCM_555X_BLUE_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DCM_4444_RED_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DCM_4444_GREEN_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DCM_4444_BLUE_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DCM_4444_ALPHA_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DCM_ARGBBM_ALPHA_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DCM_ARGBBM_RED_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DCM_ARGBBM_GREEN_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DCM_ARGBBM_BLUE_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CACHE_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("[Lsun/java2d/loops/RenderLoops;", "private static")]
	public static JavaArray<Dova.JDK.sun.java2d.loops.RenderLoops> loopcache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.java2d.loops.RenderLoops>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/java2d/loops/SurfaceType;", "private static")]
	public static JavaArray<Dova.JDK.sun.java2d.loops.SurfaceType> typecache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.java2d.loops.SurfaceType>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BufImgSurfaceData(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/image/DataBuffer;Ljava/awt/image/BufferedImage;Lsun/java2d/loops/SurfaceType;DD)V", "public")]
	public BufImgSurfaceData(Dova.JDK.java.awt.image.DataBuffer arg0, Dova.JDK.java.awt.image.BufferedImage arg1, Dova.JDK.sun.java2d.loops.SurfaceType arg2, double arg3, double arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/SurfaceType;Ljava/awt/image/ColorModel;)V", "protected")]
	public BufImgSurfaceData(Dova.JDK.sun.java2d.loops.SurfaceType arg0, Dova.JDK.java.awt.image.ColorModel arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/image/BufImgSurfaceData;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/awt/Rectangle;", "public")]
	public Dova.JDK.java.awt.Rectangle getBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;)V", "private static native")]
	public static void initIDs(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;)Lsun/java2d/loops/RenderLoops;", "public")]
	public Dova.JDK.sun.java2d.loops.RenderLoops getRenderLoops(Dova.JDK.sun.java2d.SunGraphics2D arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.RenderLoops>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/SurfaceType;)Lsun/java2d/loops/RenderLoops;", "public static synchronized")]
	public static Dova.JDK.sun.java2d.loops.RenderLoops getSolidLoops(Dova.JDK.sun.java2d.loops.SurfaceType arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.RenderLoops>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/GraphicsConfiguration;", "public synchronized")]
	public Dova.JDK.java.awt.GraphicsConfiguration getDeviceConfiguration()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsConfiguration>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;DD)Lsun/java2d/SurfaceData;", "public static")]
	public static Dova.JDK.sun.java2d.SurfaceData createData(Dova.JDK.java.awt.image.BufferedImage arg0, double arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;)Lsun/java2d/SurfaceData;", "public static")]
	public static Dova.JDK.sun.java2d.SurfaceData createData(Dova.JDK.java.awt.image.BufferedImage arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/Raster;Ljava/awt/image/ColorModel;)Lsun/java2d/SurfaceData;", "public static")]
	public static Dova.JDK.sun.java2d.SurfaceData createData(Dova.JDK.java.awt.image.Raster arg0, Dova.JDK.java.awt.image.ColorModel arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
	}

	[JniSignatureAttribute("()Lsun/java2d/SurfaceData;", "public")]
	public Dova.JDK.sun.java2d.SurfaceData getReplacement()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void checkCustomComposite()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getDestination()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()D", "public")]
	public double getDefaultScaleX()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double getDefaultScaleY()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;Lsun/java2d/loops/SurfaceType;DD)Lsun/java2d/SurfaceData;", "public static")]
	public static Dova.JDK.sun.java2d.SurfaceData createDataIC(Dova.JDK.java.awt.image.BufferedImage arg0, Dova.JDK.sun.java2d.loops.SurfaceType arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;Lsun/java2d/loops/SurfaceType;IDD)Lsun/java2d/SurfaceData;", "public static")]
	public static Dova.JDK.sun.java2d.SurfaceData createDataBC(Dova.JDK.java.awt.image.BufferedImage arg0, Dova.JDK.sun.java2d.loops.SurfaceType arg1, int arg2, double arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;Lsun/java2d/loops/SurfaceType;Ljava/awt/image/IndexColorModel;DD)Lsun/java2d/SurfaceData;", "public static")]
	public static Dova.JDK.sun.java2d.SurfaceData createDataSC(Dova.JDK.java.awt.image.BufferedImage arg0, Dova.JDK.sun.java2d.loops.SurfaceType arg1, Dova.JDK.java.awt.image.IndexColorModel arg2, double arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;Lsun/java2d/loops/SurfaceType;DD)Lsun/java2d/SurfaceData;", "public static")]
	public static Dova.JDK.sun.java2d.SurfaceData createDataBP(Dova.JDK.java.awt.image.BufferedImage arg0, Dova.JDK.sun.java2d.loops.SurfaceType arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void initSolidLoops()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;IIIIIILjava/awt/image/IndexColorModel;)V", "protected native")]
	public void initRaster(Dova.JDK.java.lang.Object arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, Dova.JDK.java.awt.image.IndexColorModel arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(IIII)Ljava/awt/image/Raster;", "public")]
	public Dova.JDK.java.awt.image.Raster getRaster(int arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.Raster>(ret);
	}

	[JniSignatureAttribute("Lsun/awt/image/BufImgSurfaceData$ICMColorData;", "public static final")]
	public partial class ICMColorData
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ICMColorData()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/BufImgSurfaceData$ICMColorData;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pData", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
		}

		[JniSignatureAttribute("J", "private")]
		public long pData_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ICMColorData(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(J)V", "private")]
		public ICMColorData(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/image/BufImgSurfaceData$ICMColorData;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
