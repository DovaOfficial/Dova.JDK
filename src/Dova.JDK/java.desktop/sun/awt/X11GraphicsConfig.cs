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

namespace Dova.JDK.sun.awt;

[JniSignatureAttribute("Lsun/awt/X11GraphicsConfig;", "public")]
public partial class X11GraphicsConfig
	: Dova.JDK.java.awt.GraphicsConfiguration
	, Dova.JDK.sun.awt.image.SurfaceManager.ProxiedGraphicsConfig
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static X11GraphicsConfig()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11GraphicsConfig;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "device", "Lsun/awt/X11GraphicsDevice;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visual", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "depth", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "colormap", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "colorModel", "Ljava/awt/image/ColorModel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "aData", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "doubleBuffer", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "disposerReferent", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bufferCaps", "Ljava/awt/BufferCapabilities;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "imageCaps", "Ljava/awt/ImageCapabilities;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bitsPerPixel", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "surfaceType", "Lsun/java2d/loops/SurfaceType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "solidloops", "Lsun/java2d/loops/RenderLoops;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/awt/X11GraphicsDevice;IIIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "()Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flip", "(Lsun/awt/X11ComponentPeer;Ljava/awt/Component;Ljava/awt/image/VolatileImage;IIIILjava/awt/BufferCapabilities$FlipContents;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initIDs", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scaleUp", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "dispose", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTranslucencyCapable", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTranslucencyCapable", "(J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scaleDown", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSurfaceType", "()Lsun/java2d/loops/SurfaceType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSolidLoops", "(Lsun/java2d/loops/SurfaceType;)Lsun/java2d/loops/RenderLoops;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProxyKey", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getConfig", "(Lsun/awt/X11GraphicsDevice;IIIZ)Lsun/awt/X11GraphicsConfig;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getConfig", "(Lsun/awt/X11GraphicsDevice;IIII)Lsun/awt/X11GraphicsConfig;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultTransform", "()Ljava/awt/geom/AffineTransform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDepth", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNormalizingTransform", "()Ljava/awt/geom/AffineTransform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSurfaceData", "(Lsun/awt/X11ComponentPeer;)Lsun/java2d/SurfaceData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAData", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeColorModel", "()Ljava/awt/image/ColorModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScale", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getXResolution", "(I)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getYResolution", "(I)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBufferCapabilities", "()Ljava/awt/BufferCapabilities;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSwapAction", "(Ljava/awt/BufferCapabilities$FlipContents;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createBackBuffer", "(JI)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createBackBuffer", "(Lsun/awt/X11ComponentPeer;ILjava/awt/BufferCapabilities;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "swapBuffers", "(JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumColors", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisual", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColormap", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBitsPerPixel", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createDCM32", "(IIIIZ)Ljava/awt/image/DirectColorModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createABGRCCM", "()Ljava/awt/image/ComponentColorModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImageCapabilities", "()Ljava/awt/ImageCapabilities;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createAcceleratedImage", "(Ljava/awt/Component;II)Ljava/awt/Image;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "destroyBackBuffer", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createBackBufferImage", "(Ljava/awt/Component;J)Ljava/awt/image/VolatileImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDoubleBuffered", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDevice_0", "()Ljava/awt/GraphicsDevice;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDevice_1", "()Lsun/awt/X11GraphicsDevice;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColorModel", "(I)Ljava/awt/image/ColorModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColorModel", "()Ljava/awt/image/ColorModel;"));
	}

	[JniSignatureAttribute("Lsun/awt/X11GraphicsDevice;", "private final")]
	public Dova.JDK.sun.awt.X11GraphicsDevice device_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11GraphicsDevice>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int visual_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int depth_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int colormap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/image/ColorModel;", "")]
	public Dova.JDK.java.awt.image.ColorModel colorModel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.ColorModel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "")]
	public long aData_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool doubleBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object disposerReferent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/BufferCapabilities;", "private")]
	public Dova.JDK.java.awt.BufferCapabilities bufferCaps_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.BufferCapabilities>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/ImageCapabilities;", "private static")]
	public static Dova.JDK.java.awt.ImageCapabilities imageCaps_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.ImageCapabilities>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int bitsPerPixel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/loops/SurfaceType;", "protected")]
	public Dova.JDK.sun.java2d.loops.SurfaceType surfaceType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.SurfaceType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/loops/RenderLoops;", "public")]
	public Dova.JDK.sun.java2d.loops.RenderLoops solidloops_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.RenderLoops>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public X11GraphicsConfig(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/awt/X11GraphicsDevice;IIIZ)V", "protected")]
	public X11GraphicsConfig(Dova.JDK.sun.awt.X11GraphicsDevice arg0, int arg1, int arg2, int arg3, bool arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/X11GraphicsConfig;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Rectangle;", "public final")]
	public Dova.JDK.java.awt.Rectangle getBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(II)V", "private native")]
	public void init(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/awt/X11ComponentPeer;Ljava/awt/Component;Ljava/awt/image/VolatileImage;IIIILjava/awt/BufferCapabilities$FlipContents;)V", "public")]
	public void flip(Dova.JDK.sun.awt.X11ComponentPeer arg0, Dova.JDK.java.awt.Component arg1, Dova.JDK.java.awt.image.VolatileImage arg2, int arg3, int arg4, int arg5, int arg6, Dova.JDK.java.awt.BufferCapabilities.FlipContents arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("()V", "private static native")]
	public static void initIDs()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int scaleUp(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "private static native")]
	public static void dispose(long arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isTranslucencyCapable()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("(J)Z", "private native")]
	public bool isTranslucencyCapable(long arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int scaleDown(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/java2d/loops/SurfaceType;", "public synchronized")]
	public Dova.JDK.sun.java2d.loops.SurfaceType getSurfaceType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.SurfaceType>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/SurfaceType;)Lsun/java2d/loops/RenderLoops;", "public synchronized")]
	public Dova.JDK.sun.java2d.loops.RenderLoops getSolidLoops(Dova.JDK.sun.java2d.loops.SurfaceType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.RenderLoops>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getProxyKey()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/X11GraphicsDevice;IIIZ)Lsun/awt/X11GraphicsConfig;", "public static")]
	public static Dova.JDK.sun.awt.X11GraphicsConfig getConfig(Dova.JDK.sun.awt.X11GraphicsDevice arg0, int arg1, int arg2, int arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11GraphicsConfig>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/X11GraphicsDevice;IIII)Lsun/awt/X11GraphicsConfig;", "public static")]
	public static Dova.JDK.sun.awt.X11GraphicsConfig getConfig(Dova.JDK.sun.awt.X11GraphicsDevice arg0, int arg1, int arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11GraphicsConfig>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/AffineTransform;", "public")]
	public Dova.JDK.java.awt.geom.AffineTransform getDefaultTransform()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getDepth()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/geom/AffineTransform;", "public")]
	public Dova.JDK.java.awt.geom.AffineTransform getNormalizingTransform()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/X11ComponentPeer;)Lsun/java2d/SurfaceData;", "public")]
	public Dova.JDK.sun.java2d.SurfaceData createSurfaceData(Dova.JDK.sun.awt.X11ComponentPeer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
	}

	[JniSignatureAttribute("()J", "public")]
	public long getAData()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/image/ColorModel;", "private native")]
	public Dova.JDK.java.awt.image.ColorModel makeColorModel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.ColorModel>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getScale()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("(I)D", "private native")]
	public double getXResolution(int arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)D", "private native")]
	public double getYResolution(int arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/BufferCapabilities;", "public")]
	public Dova.JDK.java.awt.BufferCapabilities getBufferCapabilities()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.BufferCapabilities>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/BufferCapabilities$FlipContents;)I", "private static")]
	public static int getSwapAction(Dova.JDK.java.awt.BufferCapabilities.FlipContents arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[25], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JI)J", "private native")]
	public long createBackBuffer(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11ComponentPeer;ILjava/awt/BufferCapabilities;)J", "public")]
	public long createBackBuffer(Dova.JDK.sun.awt.X11ComponentPeer arg0, int arg1, Dova.JDK.java.awt.BufferCapabilities arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(JI)V", "private native")]
	public void swapBuffers(long arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
	}

	[JniSignatureAttribute("()I", "private native")]
	public int getNumColors()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[29]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getVisual()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[30]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getColormap()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[31]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getBitsPerPixel()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[32]);
		return ret;
	}

	[JniSignatureAttribute("(IIIIZ)Ljava/awt/image/DirectColorModel;", "public static")]
	public static Dova.JDK.java.awt.image.DirectColorModel createDCM32(int arg0, int arg1, int arg2, int arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.DirectColorModel>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/image/ComponentColorModel;", "public static")]
	public static Dova.JDK.java.awt.image.ComponentColorModel createABGRCCM()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.ComponentColorModel>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/ImageCapabilities;", "public")]
	public Dova.JDK.java.awt.ImageCapabilities getImageCapabilities()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.ImageCapabilities>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;II)Ljava/awt/Image;", "public")]
	public Dova.JDK.java.awt.Image createAcceleratedImage(Dova.JDK.java.awt.Component arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Image>(ret);
	}

	[JniSignatureAttribute("(J)V", "public native")]
	public void destroyBackBuffer(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;J)Ljava/awt/image/VolatileImage;", "public")]
	public Dova.JDK.java.awt.image.VolatileImage createBackBufferImage(Dova.JDK.java.awt.Component arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.VolatileImage>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isDoubleBuffered()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[39]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/GraphicsDevice;", "public volatile")]
	public Dova.JDK.java.awt.GraphicsDevice getDevice_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsDevice>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11GraphicsDevice;", "public")]
	public Dova.JDK.sun.awt.X11GraphicsDevice getDevice_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11GraphicsDevice>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/awt/image/ColorModel;", "public")]
	public Dova.JDK.java.awt.image.ColorModel getColorModel(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.ColorModel>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/image/ColorModel;", "public synchronized")]
	public Dova.JDK.java.awt.image.ColorModel getColorModel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.ColorModel>(ret);
	}

	[JniSignatureAttribute("Lsun/awt/X11GraphicsConfig$X11GCDisposerRecord;", "private static")]
	public partial class X11GCDisposerRecord
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.java2d.DisposerRecord
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static X11GCDisposerRecord()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11GraphicsConfig$X11GCDisposerRecord;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x11ConfigData", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		}

		[JniSignatureAttribute("J", "private")]
		public long x11ConfigData_Property
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
		public X11GCDisposerRecord(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(J)V", "public")]
		public X11GCDisposerRecord(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/X11GraphicsConfig$X11GCDisposerRecord;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public synchronized")]
		public void dispose()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11GraphicsConfig$XDBECapabilities;", "private static")]
	public partial class XDBECapabilities
		: Dova.JDK.java.awt.BufferCapabilities
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XDBECapabilities()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11GraphicsConfig$XDBECapabilities;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XDBECapabilities(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public XDBECapabilities() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/X11GraphicsConfig$XDBECapabilities;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
