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

[JniSignatureAttribute("Lsun/java2d/xr/XRSurfaceData;", "public abstract")]
public partial class XRSurfaceData
	: Dova.JDK.sun.java2d.x11.XSurfaceData
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XRSurfaceData()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/xr/XRSurfaceData;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "peer", "Lsun/awt/X11ComponentPeer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "graphicsConfig", "Lsun/java2d/xr/XRGraphicsConfig;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "renderQueue", "Lsun/java2d/xr/XRBackend;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "solidloops", "Lsun/java2d/loops/RenderLoops;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "depth", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESC_BYTE_A8_X11", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESC_INT_RGB_X11", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESC_INT_ARGB_X11", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ByteA8X11", "Lsun/java2d/loops/SurfaceType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IntRgbX11", "Lsun/java2d/loops/SurfaceType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IntArgbPreX11", "Lsun/java2d/loops/SurfaceType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xrpipe", "Lsun/java2d/xr/XRRenderer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xrtxpipe", "Lsun/java2d/pipe/PixelToShapeConverter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xrtextpipe", "Lsun/java2d/pipe/TextPipe;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xrDrawImage", "Lsun/java2d/xr/XRDrawImage;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "aaShapePipe", "Lsun/java2d/pipe/ShapeDrawPipe;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "aaPixelToShapeConv", "Lsun/java2d/pipe/PixelToShapeConverter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xgc", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "validatedGCForegroundPixel", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "validatedXorComp", "Lsun/java2d/loops/XORComposite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xid", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "picture", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maskBuffer", "Lsun/java2d/xr/XRCompositeManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "validatedClip", "Lsun/java2d/pipe/Region;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "validatedGCClip", "Lsun/java2d/pipe/Region;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "validatedExposures", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transformInUse", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "validatedSourceTransform", "Ljava/awt/geom/AffineTransform;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "staticSrcTx", "Ljava/awt/geom/AffineTransform;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "validatedRepeat", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "validatedFilter", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/xr/XRBackend;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/awt/X11ComponentPeer;Lsun/java2d/xr/XRGraphicsConfig;Lsun/java2d/loops/SurfaceType;Ljava/awt/image/ColorModel;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initIDs", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyArea", "(Lsun/java2d/SunGraphics2D;IIIIII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initXRSurfaceData", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTextPipe", "(Lsun/java2d/SunGraphics2D;)Lsun/java2d/pipe/TextPipe;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validatePipe", "(Lsun/java2d/SunGraphics2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaskFill", "(Lsun/java2d/SunGraphics2D;)Lsun/java2d/loops/MaskFill;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRenderLoops", "(Lsun/java2d/SunGraphics2D;)Lsun/java2d/loops/RenderLoops;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGC", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getGC", "(Lsun/awt/X11ComponentPeer;)Lsun/java2d/xr/XRGraphicsConfig;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSurfaceType", "(Lsun/java2d/xr/XRGraphicsConfig;I)Lsun/java2d/loops/SurfaceType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initXRPicture", "(JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isXRDrawableValid", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makePipes", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canSourceSendExposures", "(IIII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateCopyAreaGC", "(Lsun/java2d/pipe/Region;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "XRInitSurface", "(IIIJI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "freeXSDOPicture", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeProxyFor", "(Lsun/java2d/SurfaceData;)Lsun/java2d/SurfaceDataProxy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createData", "(Lsun/awt/X11ComponentPeer;)Lsun/java2d/xr/XRSurfaceData$XRWindowSurfaceData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createData", "(Lsun/java2d/xr/XRGraphicsConfig;IILjava/awt/image/ColorModel;Ljava/awt/Image;JIZ)Lsun/java2d/xr/XRSurfaceData$XRPixmapSurfaceData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateAsSource", "(Ljava/awt/geom/AffineTransform;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateAsDestination", "(Lsun/java2d/SunGraphics2D;Lsun/java2d/pipe/Region;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPicture", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getXid", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGraphicsConfig", "()Lsun/java2d/xr/XRGraphicsConfig;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStaticSrcTx", "(Ljava/awt/geom/AffineTransform;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initXRender", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invalidate", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRaster", "(IIII)Ljava/awt/image/Raster;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeviceConfiguration", "()Ljava/awt/GraphicsConfiguration;"));
	}

	[JniSignatureAttribute("Lsun/awt/X11ComponentPeer;", "")]
	public Dova.JDK.sun.awt.X11ComponentPeer peer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11ComponentPeer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRGraphicsConfig;", "")]
	public Dova.JDK.sun.java2d.xr.XRGraphicsConfig graphicsConfig_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRGraphicsConfig>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRBackend;", "")]
	public Dova.JDK.sun.java2d.xr.XRBackend renderQueue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRBackend>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/loops/RenderLoops;", "private")]
	public Dova.JDK.sun.java2d.loops.RenderLoops solidloops_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.RenderLoops>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int depth_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DESC_BYTE_A8_X11_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DESC_INT_RGB_X11_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DESC_INT_ARGB_X11_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/loops/SurfaceType;", "public static final")]
	public static Dova.JDK.sun.java2d.loops.SurfaceType ByteA8X11_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.SurfaceType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/loops/SurfaceType;", "public static final")]
	public static Dova.JDK.sun.java2d.loops.SurfaceType IntRgbX11_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.SurfaceType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/loops/SurfaceType;", "public static final")]
	public static Dova.JDK.sun.java2d.loops.SurfaceType IntArgbPreX11_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.SurfaceType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRRenderer;", "protected")]
	public Dova.JDK.sun.java2d.xr.XRRenderer xrpipe_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRRenderer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/PixelToShapeConverter;", "protected")]
	public Dova.JDK.sun.java2d.pipe.PixelToShapeConverter xrtxpipe_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.PixelToShapeConverter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/TextPipe;", "protected")]
	public Dova.JDK.sun.java2d.pipe.TextPipe xrtextpipe_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.TextPipe>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRDrawImage;", "protected")]
	public Dova.JDK.sun.java2d.xr.XRDrawImage xrDrawImage_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRDrawImage>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/ShapeDrawPipe;", "protected")]
	public Dova.JDK.sun.java2d.pipe.ShapeDrawPipe aaShapePipe_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.ShapeDrawPipe>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/PixelToShapeConverter;", "protected")]
	public Dova.JDK.sun.java2d.pipe.PixelToShapeConverter aaPixelToShapeConv_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.PixelToShapeConverter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long xgc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int validatedGCForegroundPixel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/loops/XORComposite;", "private")]
	public Dova.JDK.sun.java2d.loops.XORComposite validatedXorComp_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.XORComposite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int xid_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("I", "public")]
	public int picture_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRCompositeManager;", "public")]
	public Dova.JDK.sun.java2d.xr.XRCompositeManager maskBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRCompositeManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/Region;", "private")]
	public Dova.JDK.sun.java2d.pipe.Region validatedClip_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/Region;", "private")]
	public Dova.JDK.sun.java2d.pipe.Region validatedGCClip_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool validatedExposures_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool transformInUse_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/geom/AffineTransform;", "")]
	public Dova.JDK.java.awt.geom.AffineTransform validatedSourceTransform_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/geom/AffineTransform;", "")]
	public Dova.JDK.java.awt.geom.AffineTransform staticSrcTx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int validatedRepeat_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int validatedFilter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[30]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[30], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XRSurfaceData(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/java2d/xr/XRBackend;)V", "protected")]
	public XRSurfaceData(Dova.JDK.sun.java2d.xr.XRBackend arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Lsun/awt/X11ComponentPeer;Lsun/java2d/xr/XRGraphicsConfig;Lsun/java2d/loops/SurfaceType;Ljava/awt/image/ColorModel;II)V", "protected")]
	public XRSurfaceData(Dova.JDK.sun.awt.X11ComponentPeer arg0, Dova.JDK.sun.java2d.xr.XRGraphicsConfig arg1, Dova.JDK.sun.java2d.loops.SurfaceType arg2, Dova.JDK.java.awt.image.ColorModel arg3, int arg4, int arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/xr/XRSurfaceData;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "private static native")]
	public static void initIDs()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIIIII)Z", "public")]
	public bool copyArea(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("()V", "public static")]
	public static void initXRSurfaceData()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;)Lsun/java2d/pipe/TextPipe;", "protected")]
	public Dova.JDK.sun.java2d.pipe.TextPipe getTextPipe(Dova.JDK.sun.java2d.SunGraphics2D arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.TextPipe>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;)V", "public")]
	public void validatePipe(Dova.JDK.sun.java2d.SunGraphics2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;)Lsun/java2d/loops/MaskFill;", "protected")]
	public Dova.JDK.sun.java2d.loops.MaskFill getMaskFill(Dova.JDK.sun.java2d.SunGraphics2D arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.MaskFill>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;)Lsun/java2d/loops/RenderLoops;", "public")]
	public Dova.JDK.sun.java2d.loops.RenderLoops getRenderLoops(Dova.JDK.sun.java2d.SunGraphics2D arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.RenderLoops>(ret);
	}

	[JniSignatureAttribute("()J", "public")]
	public long getGC()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11ComponentPeer;)Lsun/java2d/xr/XRGraphicsConfig;", "public static")]
	public static Dova.JDK.sun.java2d.xr.XRGraphicsConfig getGC(Dova.JDK.sun.awt.X11ComponentPeer arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRGraphicsConfig>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/xr/XRGraphicsConfig;I)Lsun/java2d/loops/SurfaceType;", "public static")]
	public static Dova.JDK.sun.java2d.loops.SurfaceType getSurfaceType(Dova.JDK.sun.java2d.xr.XRGraphicsConfig arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.SurfaceType>(ret);
	}

	[JniSignatureAttribute("(JI)V", "native")]
	public void initXRPicture(long arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool isXRDrawableValid()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void makePipes()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}

	[JniSignatureAttribute("(IIII)Z", "public abstract")]
	public bool canSourceSendExposures(int arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/Region;Z)V", "public")]
	public void validateCopyAreaGC(Dova.JDK.sun.java2d.pipe.Region arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("(IIIJI)V", "protected native")]
	public void XRInitSurface(int arg0, int arg1, int arg2, long arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(J)V", "native")]
	public void freeXSDOPicture(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Lsun/java2d/SurfaceData;)Lsun/java2d/SurfaceDataProxy;", "public")]
	public Dova.JDK.sun.java2d.SurfaceDataProxy makeProxyFor(Dova.JDK.sun.java2d.SurfaceData arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceDataProxy>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/X11ComponentPeer;)Lsun/java2d/xr/XRSurfaceData$XRWindowSurfaceData;", "public static")]
	public static Dova.JDK.sun.java2d.xr.XRSurfaceData.XRWindowSurfaceData createData(Dova.JDK.sun.awt.X11ComponentPeer arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRSurfaceData.XRWindowSurfaceData>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/xr/XRGraphicsConfig;IILjava/awt/image/ColorModel;Ljava/awt/Image;JIZ)Lsun/java2d/xr/XRSurfaceData$XRPixmapSurfaceData;", "public static")]
	public static Dova.JDK.sun.java2d.xr.XRSurfaceData.XRPixmapSurfaceData createData(Dova.JDK.sun.java2d.xr.XRGraphicsConfig arg0, int arg1, int arg2, Dova.JDK.java.awt.image.ColorModel arg3, Dova.JDK.java.awt.Image arg4, long arg5, int arg6, bool arg7)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRSurfaceData.XRPixmapSurfaceData>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;II)V", "")]
	public void validateAsSource(Dova.JDK.java.awt.geom.AffineTransform arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Lsun/java2d/pipe/Region;)V", "public")]
	public void validateAsDestination(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.sun.java2d.pipe.Region arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getPicture()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getXid()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/java2d/xr/XRGraphicsConfig;", "public")]
	public Dova.JDK.sun.java2d.xr.XRGraphicsConfig getGraphicsConfig()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRGraphicsConfig>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;)V", "public")]
	public void setStaticSrcTx(Dova.JDK.java.awt.geom.AffineTransform arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void initXRender(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void invalidate()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27]);
	}

	[JniSignatureAttribute("(IIII)Ljava/awt/image/Raster;", "public")]
	public Dova.JDK.java.awt.image.Raster getRaster(int arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.Raster>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/GraphicsConfiguration;", "public")]
	public Dova.JDK.java.awt.GraphicsConfiguration getDeviceConfiguration()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsConfiguration>(ret);
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRSurfaceData$XRWindowSurfaceData;", "public static")]
	public partial class XRWindowSurfaceData
		: Dova.JDK.sun.java2d.xr.XRSurfaceData
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XRWindowSurfaceData()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/xr/XRSurfaceData$XRWindowSurfaceData;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "scale", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/awt/X11ComponentPeer;Lsun/java2d/xr/XRGraphicsConfig;Lsun/java2d/loops/SurfaceType;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "()Ljava/awt/Rectangle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canSourceSendExposures", "(IIII)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReplacement", "()Lsun/java2d/SurfaceData;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDestination", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultScaleX", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultScaleY", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invalidate", "()V"));
		}

		[JniSignatureAttribute("I", "protected final")]
		public int scale_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XRWindowSurfaceData(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/awt/X11ComponentPeer;Lsun/java2d/xr/XRGraphicsConfig;Lsun/java2d/loops/SurfaceType;)V", "public")]
		public XRWindowSurfaceData(Dova.JDK.sun.awt.X11ComponentPeer arg0, Dova.JDK.sun.java2d.xr.XRGraphicsConfig arg1, Dova.JDK.sun.java2d.loops.SurfaceType arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/xr/XRSurfaceData$XRWindowSurfaceData;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/awt/Rectangle;", "public")]
		public Dova.JDK.java.awt.Rectangle getBounds()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}

		[JniSignatureAttribute("(IIII)Z", "public")]
		public bool canSourceSendExposures(int arg0, int arg1, int arg2, int arg3)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("()Lsun/java2d/SurfaceData;", "public")]
		public Dova.JDK.sun.java2d.SurfaceData getReplacement()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object getDestination()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()D", "public")]
		public double getDefaultScaleX()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getDefaultScaleY()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()V", "public")]
		public void invalidate()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRSurfaceData$XRPixmapSurfaceData;", "public static")]
	public partial class XRPixmapSurfaceData
		: Dova.JDK.sun.java2d.xr.XRSurfaceData
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XRPixmapSurfaceData()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/xr/XRSurfaceData$XRPixmapSurfaceData;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offscreenImage", "Ljava/awt/Image;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "width", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "height", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transparency", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "scale", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/xr/XRGraphicsConfig;IILjava/awt/Image;Lsun/java2d/loops/SurfaceType;Ljava/awt/image/ColorModel;JIIIZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flush", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "()Ljava/awt/Rectangle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canSourceSendExposures", "(IIII)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReplacement", "()Lsun/java2d/SurfaceData;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initSurface", "(IIIJI)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDestination", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultScaleX", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultScaleY", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransparency", "()I"));
		}

		[JniSignatureAttribute("Ljava/awt/Image;", "")]
		public Dova.JDK.java.awt.Image offscreenImage_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Image>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int width_Property
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
		public int height_Property
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
		public int transparency_Property
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

		[JniSignatureAttribute("I", "private final")]
		public int scale_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XRPixmapSurfaceData(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/java2d/xr/XRGraphicsConfig;IILjava/awt/Image;Lsun/java2d/loops/SurfaceType;Ljava/awt/image/ColorModel;JIIIZ)V", "public")]
		public XRPixmapSurfaceData(Dova.JDK.sun.java2d.xr.XRGraphicsConfig arg0, int arg1, int arg2, Dova.JDK.java.awt.Image arg3, Dova.JDK.sun.java2d.loops.SurfaceType arg4, Dova.JDK.java.awt.image.ColorModel arg5, long arg6, int arg7, int arg8, int arg9, bool arg10) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/xr/XRSurfaceData$XRPixmapSurfaceData;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void flush()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Ljava/awt/Rectangle;", "public")]
		public Dova.JDK.java.awt.Rectangle getBounds()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}

		[JniSignatureAttribute("(IIII)Z", "public")]
		public bool canSourceSendExposures(int arg0, int arg1, int arg2, int arg3)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("()Lsun/java2d/SurfaceData;", "public")]
		public Dova.JDK.sun.java2d.SurfaceData getReplacement()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
		}

		[JniSignatureAttribute("(IIIJI)V", "public")]
		public void initSurface(int arg0, int arg1, int arg2, long arg3, int arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object getDestination()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()D", "public")]
		public double getDefaultScaleX()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getDefaultScaleY()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getTransparency()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRSurfaceData$LazyPipe;", "public static")]
	public partial class LazyPipe
		: Dova.JDK.sun.java2d.pipe.ValidatePipe
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LazyPipe()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/xr/XRSurfaceData$LazyPipe;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validate", "(Lsun/java2d/SunGraphics2D;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LazyPipe(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public LazyPipe() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/xr/XRSurfaceData$LazyPipe;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;)Z", "public")]
		public bool validate(Dova.JDK.sun.java2d.SunGraphics2D arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRSurfaceData$XRInternalSurfaceData;", "public static")]
	public partial class XRInternalSurfaceData
		: Dova.JDK.sun.java2d.xr.XRSurfaceData
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XRInternalSurfaceData()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/xr/XRSurfaceData$XRInternalSurfaceData;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/xr/XRBackend;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "()Ljava/awt/Rectangle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canSourceSendExposures", "(IIII)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReplacement", "()Lsun/java2d/SurfaceData;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDestination", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XRInternalSurfaceData(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/java2d/xr/XRBackend;I)V", "public")]
		public XRInternalSurfaceData(Dova.JDK.sun.java2d.xr.XRBackend arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/xr/XRSurfaceData$XRInternalSurfaceData;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/awt/Rectangle;", "public")]
		public Dova.JDK.java.awt.Rectangle getBounds()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}

		[JniSignatureAttribute("(IIII)Z", "public")]
		public bool canSourceSendExposures(int arg0, int arg1, int arg2, int arg3)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("()Lsun/java2d/SurfaceData;", "public")]
		public Dova.JDK.sun.java2d.SurfaceData getReplacement()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object getDestination()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
