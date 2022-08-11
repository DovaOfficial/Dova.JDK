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

namespace Dova.JDK.sun.java2d.opengl;

[JniSignatureAttribute("Lsun/java2d/opengl/OGLBlitLoops;", "final")]
public partial class OGLBlitLoops
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static OGLBlitLoops()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/opengl/OGLBlitLoops;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OFFSET_SRCTYPE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OFFSET_HINT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OFFSET_TEXTURE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OFFSET_RTT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OFFSET_XFORM", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OFFSET_ISOBLIT", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "register", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enqueueBlit", "(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SurfaceData;Lsun/java2d/SurfaceData;IIIIIDDDD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IsoBlit", "(Lsun/java2d/SurfaceData;Lsun/java2d/SurfaceData;Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImageOp;Ljava/awt/Composite;Lsun/java2d/pipe/Region;Ljava/awt/geom/AffineTransform;IIIIIDDDDZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "Blit", "(Lsun/java2d/SurfaceData;Lsun/java2d/SurfaceData;Ljava/awt/Composite;Lsun/java2d/pipe/Region;Ljava/awt/geom/AffineTransform;IIIIIDDDDIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createPackedParams", "(ZZZZII)I"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int OFFSET_SRCTYPE_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int OFFSET_HINT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int OFFSET_TEXTURE_Property
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
	public static int OFFSET_RTT_Property
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
	public static int OFFSET_XFORM_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int OFFSET_ISOBLIT_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public OGLBlitLoops(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public OGLBlitLoops() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/opengl/OGLBlitLoops;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "static")]
	public static void register()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SurfaceData;Lsun/java2d/SurfaceData;IIIIIDDDD)V", "private static")]
	public static void enqueueBlit(Dova.JDK.sun.java2d.pipe.RenderQueue arg0, Dova.JDK.sun.java2d.SurfaceData arg1, Dova.JDK.sun.java2d.SurfaceData arg2, int arg3, int arg4, int arg5, int arg6, int arg7, double arg8, double arg9, double arg10, double arg11)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
	}

	[JniSignatureAttribute("(Lsun/java2d/SurfaceData;Lsun/java2d/SurfaceData;Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImageOp;Ljava/awt/Composite;Lsun/java2d/pipe/Region;Ljava/awt/geom/AffineTransform;IIIIIDDDDZ)V", "static")]
	public static void IsoBlit(Dova.JDK.sun.java2d.SurfaceData arg0, Dova.JDK.sun.java2d.SurfaceData arg1, Dova.JDK.java.awt.image.BufferedImage arg2, Dova.JDK.java.awt.image.BufferedImageOp arg3, Dova.JDK.java.awt.Composite arg4, Dova.JDK.sun.java2d.pipe.Region arg5, Dova.JDK.java.awt.geom.AffineTransform arg6, int arg7, int arg8, int arg9, int arg10, int arg11, double arg12, double arg13, double arg14, double arg15, bool arg16)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
	}

	[JniSignatureAttribute("(Lsun/java2d/SurfaceData;Lsun/java2d/SurfaceData;Ljava/awt/Composite;Lsun/java2d/pipe/Region;Ljava/awt/geom/AffineTransform;IIIIIDDDDIZ)V", "static")]
	public static void Blit(Dova.JDK.sun.java2d.SurfaceData arg0, Dova.JDK.sun.java2d.SurfaceData arg1, Dova.JDK.java.awt.Composite arg2, Dova.JDK.sun.java2d.pipe.Region arg3, Dova.JDK.java.awt.geom.AffineTransform arg4, int arg5, int arg6, int arg7, int arg8, int arg9, double arg10, double arg11, double arg12, double arg13, int arg14, bool arg15)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
	}

	[JniSignatureAttribute("(ZZZZII)I", "private static")]
	public static int createPackedParams(bool arg0, bool arg1, bool arg2, bool arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}
}
