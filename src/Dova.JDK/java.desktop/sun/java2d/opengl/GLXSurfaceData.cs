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

[JniSignatureAttribute("Lsun/java2d/opengl/GLXSurfaceData;", "public abstract")]
public partial class GLXSurfaceData
	: Dova.JDK.sun.java2d.opengl.OGLSurfaceData
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GLXSurfaceData()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/opengl/GLXSurfaceData;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "peer", "Lsun/awt/X11ComponentPeer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "graphicsConfig", "Lsun/java2d/opengl/GLXGraphicsConfig;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "GLXSurfaceData", "(Lsun/awt/X11ComponentPeer;Lsun/java2d/opengl/GLXGraphicsConfig;Ljava/awt/image/ColorModel;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getGC", "(Lsun/awt/X11ComponentPeer;)Lsun/java2d/opengl/GLXGraphicsConfig;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "initOps", "(Lsun/java2d/opengl/OGLGraphicsConfig;Lsun/awt/X11ComponentPeer;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDeviceConfiguration", "()Ljava/awt/GraphicsConfiguration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createData", "(Lsun/awt/X11ComponentPeer;)Lsun/java2d/opengl/GLXSurfaceData$GLXWindowSurfaceData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createData", "(Lsun/java2d/opengl/GLXGraphicsConfig;IILjava/awt/image/ColorModel;Ljava/awt/Image;I)Lsun/java2d/opengl/GLXSurfaceData$GLXOffScreenSurfaceData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createData", "(Lsun/awt/X11ComponentPeer;Ljava/awt/Image;I)Lsun/java2d/opengl/GLXSurfaceData$GLXOffScreenSurfaceData;"));
	}

	[JniSignatureAttribute("Lsun/awt/X11ComponentPeer;", "protected")]
	public Dova.JDK.sun.awt.X11ComponentPeer peer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11ComponentPeer>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/java2d/opengl/GLXGraphicsConfig;", "private")]
	public Dova.JDK.sun.java2d.opengl.GLXGraphicsConfig graphicsConfig_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.opengl.GLXGraphicsConfig>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GLXSurfaceData(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/awt/X11ComponentPeer;Lsun/java2d/opengl/GLXGraphicsConfig;Ljava/awt/image/ColorModel;I)V", "protected")]
	public GLXSurfaceData(Dova.JDK.sun.awt.X11ComponentPeer arg0, Dova.JDK.sun.java2d.opengl.GLXGraphicsConfig arg1, Dova.JDK.java.awt.image.ColorModel arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/opengl/GLXSurfaceData;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/awt/X11ComponentPeer;)Lsun/java2d/opengl/GLXGraphicsConfig;", "public static")]
	public static Dova.JDK.sun.java2d.opengl.GLXGraphicsConfig getGC(Dova.JDK.sun.awt.X11ComponentPeer arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.opengl.GLXGraphicsConfig>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/opengl/OGLGraphicsConfig;Lsun/awt/X11ComponentPeer;J)V", "private native")]
	public void initOps(Dova.JDK.sun.java2d.opengl.OGLGraphicsConfig arg0, Dova.JDK.sun.awt.X11ComponentPeer arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljava/awt/GraphicsConfiguration;", "public")]
	public Dova.JDK.java.awt.GraphicsConfiguration getDeviceConfiguration()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsConfiguration>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/X11ComponentPeer;)Lsun/java2d/opengl/GLXSurfaceData$GLXWindowSurfaceData;", "public static")]
	public static Dova.JDK.sun.java2d.opengl.GLXSurfaceData.GLXWindowSurfaceData createData(Dova.JDK.sun.awt.X11ComponentPeer arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.opengl.GLXSurfaceData.GLXWindowSurfaceData>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/opengl/GLXGraphicsConfig;IILjava/awt/image/ColorModel;Ljava/awt/Image;I)Lsun/java2d/opengl/GLXSurfaceData$GLXOffScreenSurfaceData;", "public static")]
	public static Dova.JDK.sun.java2d.opengl.GLXSurfaceData.GLXOffScreenSurfaceData createData(Dova.JDK.sun.java2d.opengl.GLXGraphicsConfig arg0, int arg1, int arg2, Dova.JDK.java.awt.image.ColorModel arg3, Dova.JDK.java.awt.Image arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.opengl.GLXSurfaceData.GLXOffScreenSurfaceData>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/X11ComponentPeer;Ljava/awt/Image;I)Lsun/java2d/opengl/GLXSurfaceData$GLXOffScreenSurfaceData;", "public static")]
	public static Dova.JDK.sun.java2d.opengl.GLXSurfaceData.GLXOffScreenSurfaceData createData(Dova.JDK.sun.awt.X11ComponentPeer arg0, Dova.JDK.java.awt.Image arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.opengl.GLXSurfaceData.GLXOffScreenSurfaceData>(ret);
	}

	[JniSignatureAttribute("Lsun/java2d/opengl/GLXSurfaceData$GLXWindowSurfaceData;", "public static")]
	public partial class GLXWindowSurfaceData
		: Dova.JDK.sun.java2d.opengl.GLXSurfaceData
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GLXWindowSurfaceData()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/opengl/GLXSurfaceData$GLXWindowSurfaceData;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "scale", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "GLXWindowSurfaceData", "(Lsun/awt/X11ComponentPeer;Lsun/java2d/opengl/GLXGraphicsConfig;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getBounds", "()Ljava/awt/Rectangle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getReplacement", "()Lsun/java2d/SurfaceData;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDestination", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDefaultScaleX", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDefaultScaleY", "()D"));
		}

		[JniSignatureAttribute("I", "protected final")]
		public int scale_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public GLXWindowSurfaceData(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/awt/X11ComponentPeer;Lsun/java2d/opengl/GLXGraphicsConfig;)V", "public")]
		public GLXWindowSurfaceData(Dova.JDK.sun.awt.X11ComponentPeer arg0, Dova.JDK.sun.java2d.opengl.GLXGraphicsConfig arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/opengl/GLXSurfaceData$GLXWindowSurfaceData;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/awt/Rectangle;", "public")]
		public Dova.JDK.java.awt.Rectangle getBounds()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}

		[JniSignatureAttribute("()Lsun/java2d/SurfaceData;", "public")]
		public Dova.JDK.sun.java2d.SurfaceData getReplacement()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object getDestination()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()D", "public")]
		public double getDefaultScaleX()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getDefaultScaleY()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/java2d/opengl/GLXSurfaceData$GLXOffScreenSurfaceData;", "public static")]
	public partial class GLXOffScreenSurfaceData
		: Dova.JDK.sun.java2d.opengl.GLXSurfaceData
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GLXOffScreenSurfaceData()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/opengl/GLXSurfaceData$GLXOffScreenSurfaceData;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "offscreenImage", "Ljava/awt/Image;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "width", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "height", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "scale", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "GLXOffScreenSurfaceData", "(Lsun/awt/X11ComponentPeer;Lsun/java2d/opengl/GLXGraphicsConfig;IILjava/awt/Image;Ljava/awt/image/ColorModel;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getBounds", "()Ljava/awt/Rectangle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getReplacement", "()Lsun/java2d/SurfaceData;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDestination", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDefaultScaleX", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDefaultScaleY", "()D"));
		}

		[JniSignatureAttribute("Ljava/awt/Image;", "private")]
		public Dova.JDK.java.awt.Image offscreenImage_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Image>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "private")]
		public int width_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("I", "private")]
		public int height_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("I", "private final")]
		public int scale_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public GLXOffScreenSurfaceData(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/awt/X11ComponentPeer;Lsun/java2d/opengl/GLXGraphicsConfig;IILjava/awt/Image;Ljava/awt/image/ColorModel;I)V", "public")]
		public GLXOffScreenSurfaceData(Dova.JDK.sun.awt.X11ComponentPeer arg0, Dova.JDK.sun.java2d.opengl.GLXGraphicsConfig arg1, int arg2, int arg3, Dova.JDK.java.awt.Image arg4, Dova.JDK.java.awt.image.ColorModel arg5, int arg6) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/opengl/GLXSurfaceData$GLXOffScreenSurfaceData;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/awt/Rectangle;", "public")]
		public Dova.JDK.java.awt.Rectangle getBounds()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}

		[JniSignatureAttribute("()Lsun/java2d/SurfaceData;", "public")]
		public Dova.JDK.sun.java2d.SurfaceData getReplacement()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object getDestination()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()D", "public")]
		public double getDefaultScaleX()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getDefaultScaleY()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/java2d/opengl/GLXSurfaceData$GLXVSyncOffScreenSurfaceData;", "public static")]
	public partial class GLXVSyncOffScreenSurfaceData
		: Dova.JDK.sun.java2d.opengl.GLXSurfaceData.GLXOffScreenSurfaceData
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GLXVSyncOffScreenSurfaceData()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/opengl/GLXSurfaceData$GLXVSyncOffScreenSurfaceData;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "flipSurface", "Lsun/java2d/opengl/GLXSurfaceData$GLXOffScreenSurfaceData;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "GLXVSyncOffScreenSurfaceData", "(Lsun/awt/X11ComponentPeer;Lsun/java2d/opengl/GLXGraphicsConfig;IILjava/awt/Image;Ljava/awt/image/ColorModel;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "flush", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFlipSurface", "()Lsun/java2d/SurfaceData;"));
		}

		[JniSignatureAttribute("Lsun/java2d/opengl/GLXSurfaceData$GLXOffScreenSurfaceData;", "private")]
		public Dova.JDK.sun.java2d.opengl.GLXSurfaceData.GLXOffScreenSurfaceData flipSurface_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.opengl.GLXSurfaceData.GLXOffScreenSurfaceData>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public GLXVSyncOffScreenSurfaceData(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/awt/X11ComponentPeer;Lsun/java2d/opengl/GLXGraphicsConfig;IILjava/awt/Image;Ljava/awt/image/ColorModel;I)V", "public")]
		public GLXVSyncOffScreenSurfaceData(Dova.JDK.sun.awt.X11ComponentPeer arg0, Dova.JDK.sun.java2d.opengl.GLXGraphicsConfig arg1, int arg2, int arg3, Dova.JDK.java.awt.Image arg4, Dova.JDK.java.awt.image.ColorModel arg5, int arg6) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/opengl/GLXSurfaceData$GLXVSyncOffScreenSurfaceData;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void flush()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Lsun/java2d/SurfaceData;", "public")]
		public Dova.JDK.sun.java2d.SurfaceData getFlipSurface()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
		}
	}
}
