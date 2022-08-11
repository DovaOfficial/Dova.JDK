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

[JniSignatureAttribute("Lsun/awt/image/SurfaceManager;", "public abstract")]
public partial class SurfaceManager
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SurfaceManager()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/SurfaceManager;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "imgaccessor", "Lsun/awt/image/SurfaceManager$ImageAccessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cacheMap", "Ljava/util/concurrent/ConcurrentHashMap;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flush", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flush", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCapabilities", "(Ljava/awt/GraphicsConfiguration;)Ljava/awt/ImageCapabilities;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccelerationPriority", "(F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setImageAccessor", "(Lsun/awt/image/SurfaceManager$ImageAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setManager", "(Ljava/awt/Image;Lsun/awt/image/SurfaceManager;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getManager", "(Ljava/awt/Image;)Lsun/awt/image/SurfaceManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrimarySurfaceData", "()Lsun/java2d/SurfaceData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCacheData", "(Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCacheData", "(Ljava/lang/Object;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "restoreContents", "()Lsun/java2d/SurfaceData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceleratedSurfaceLost", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getImageScaleX", "(Ljava/awt/Image;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getImageScaleY", "(Ljava/awt/Image;)D"));
	}

	[JniSignatureAttribute("Lsun/awt/image/SurfaceManager$ImageAccessor;", "private static")]
	public static Dova.JDK.sun.awt.image.SurfaceManager.ImageAccessor imgaccessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.SurfaceManager.ImageAccessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentHashMap;", "private")]
	public Dova.JDK.java.util.concurrent.ConcurrentHashMap cacheMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentHashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SurfaceManager(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SurfaceManager() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/image/SurfaceManager;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Z)V", "synchronized")]
	public void flush(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void flush()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Ljava/awt/GraphicsConfiguration;)Ljava/awt/ImageCapabilities;", "public")]
	public Dova.JDK.java.awt.ImageCapabilities getCapabilities(Dova.JDK.java.awt.GraphicsConfiguration arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.ImageCapabilities>(ret);
	}

	[JniSignatureAttribute("(F)V", "public")]
	public void setAccelerationPriority(float arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/image/SurfaceManager$ImageAccessor;)V", "public static")]
	public static void setImageAccessor(Dova.JDK.sun.awt.image.SurfaceManager.ImageAccessor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Image;Lsun/awt/image/SurfaceManager;)V", "public static")]
	public static void setManager(Dova.JDK.java.awt.Image arg0, Dova.JDK.sun.awt.image.SurfaceManager arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Image;)Lsun/awt/image/SurfaceManager;", "public static")]
	public static Dova.JDK.sun.awt.image.SurfaceManager getManager(Dova.JDK.java.awt.Image arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.SurfaceManager>(ret);
	}

	[JniSignatureAttribute("()Lsun/java2d/SurfaceData;", "public abstract")]
	public Dova.JDK.sun.java2d.SurfaceData getPrimarySurfaceData()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getCacheData(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)V", "public")]
	public void setCacheData(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("()Lsun/java2d/SurfaceData;", "public abstract")]
	public Dova.JDK.sun.java2d.SurfaceData restoreContents()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void acceleratedSurfaceLost()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("(Ljava/awt/Image;)D", "public static")]
	public static double getImageScaleX(Dova.JDK.java.awt.Image arg0)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Image;)D", "public static")]
	public static double getImageScaleY(Dova.JDK.java.awt.Image arg0)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lsun/awt/image/SurfaceManager$ImageAccessor;", "public abstract static")]
	public partial class ImageAccessor
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ImageAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/SurfaceManager$ImageAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSurfaceManager", "(Ljava/awt/Image;)Lsun/awt/image/SurfaceManager;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSurfaceManager", "(Ljava/awt/Image;Lsun/awt/image/SurfaceManager;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ImageAccessor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public ImageAccessor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/image/SurfaceManager$ImageAccessor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Image;)Lsun/awt/image/SurfaceManager;", "public abstract")]
		public Dova.JDK.sun.awt.image.SurfaceManager getSurfaceManager(Dova.JDK.java.awt.Image arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.SurfaceManager>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Image;Lsun/awt/image/SurfaceManager;)V", "public abstract")]
		public void setSurfaceManager(Dova.JDK.java.awt.Image arg0, Dova.JDK.sun.awt.image.SurfaceManager arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/awt/image/SurfaceManager$ImageCapabilitiesGc;", "")]
	public partial class ImageCapabilitiesGc
		: Dova.JDK.java.awt.ImageCapabilities
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ImageCapabilitiesGc()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/SurfaceManager$ImageCapabilitiesGc;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gc", "Ljava/awt/GraphicsConfiguration;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/awt/image/SurfaceManager;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/awt/image/SurfaceManager;Ljava/awt/GraphicsConfiguration;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccelerated", "()Z"));
		}

		[JniSignatureAttribute("Ljava/awt/GraphicsConfiguration;", "")]
		public Dova.JDK.java.awt.GraphicsConfiguration gc_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsConfiguration>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/awt/image/SurfaceManager;", "final")]
		public Dova.JDK.sun.awt.image.SurfaceManager this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.SurfaceManager>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ImageCapabilitiesGc(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/awt/image/SurfaceManager;Ljava/awt/GraphicsConfiguration;)V", "public")]
		public ImageCapabilitiesGc(Dova.JDK.sun.awt.image.SurfaceManager arg0, Dova.JDK.java.awt.GraphicsConfiguration arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/image/SurfaceManager$ImageCapabilitiesGc;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool isAccelerated()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/image/SurfaceManager$FlushableCacheData;", "public abstract static interface")]
	public partial interface FlushableCacheData
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FlushableCacheData()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/SurfaceManager$FlushableCacheData;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flush", "(Z)Z"));
		}

		[JniSignatureAttribute("(Z)Z", "public abstract")]
		bool flush(bool arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/image/SurfaceManager$ProxiedGraphicsConfig;", "public abstract static interface")]
	public partial interface ProxiedGraphicsConfig
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ProxiedGraphicsConfig()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/SurfaceManager$ProxiedGraphicsConfig;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProxyKey", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object getProxyKey()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
