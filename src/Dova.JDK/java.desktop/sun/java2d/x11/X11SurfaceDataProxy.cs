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

namespace Dova.JDK.sun.java2d.x11;

[JniSignatureAttribute("Lsun/java2d/x11/X11SurfaceDataProxy;", "public abstract")]
public partial class X11SurfaceDataProxy
	: Dova.JDK.sun.java2d.SurfaceDataProxy
	, Dova.JDK.java.awt.Transparency
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static X11SurfaceDataProxy()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/x11/X11SurfaceDataProxy;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x11gc", "Lsun/awt/X11GraphicsConfig;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/awt/X11GraphicsConfig;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateSurfaceData", "(Lsun/java2d/SurfaceData;Lsun/java2d/SurfaceData;II)Lsun/java2d/SurfaceData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createProxy", "(Lsun/java2d/SurfaceData;Lsun/awt/X11GraphicsConfig;)Lsun/java2d/SurfaceDataProxy;"));
	}

	[JniSignatureAttribute("Lsun/awt/X11GraphicsConfig;", "")]
	public Dova.JDK.sun.awt.X11GraphicsConfig x11gc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11GraphicsConfig>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public X11SurfaceDataProxy(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/awt/X11GraphicsConfig;)V", "public")]
	public X11SurfaceDataProxy(Dova.JDK.sun.awt.X11GraphicsConfig arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/x11/X11SurfaceDataProxy;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/SurfaceData;Lsun/java2d/SurfaceData;II)Lsun/java2d/SurfaceData;", "public")]
	public Dova.JDK.sun.java2d.SurfaceData validateSurfaceData(Dova.JDK.sun.java2d.SurfaceData arg0, Dova.JDK.sun.java2d.SurfaceData arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/SurfaceData;Lsun/awt/X11GraphicsConfig;)Lsun/java2d/SurfaceDataProxy;", "public static")]
	public static Dova.JDK.sun.java2d.SurfaceDataProxy createProxy(Dova.JDK.sun.java2d.SurfaceData arg0, Dova.JDK.sun.awt.X11GraphicsConfig arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceDataProxy>(ret);
	}

	[JniSignatureAttribute("Lsun/java2d/x11/X11SurfaceDataProxy$Opaque;", "public static")]
	public partial class Opaque
		: Dova.JDK.sun.java2d.x11.X11SurfaceDataProxy
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Opaque()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/x11/X11SurfaceDataProxy$Opaque;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/awt/X11GraphicsConfig;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupportedOperation", "(Lsun/java2d/SurfaceData;ILsun/java2d/loops/CompositeType;Ljava/awt/Color;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransparency", "()I"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Opaque(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/awt/X11GraphicsConfig;)V", "public")]
		public Opaque(Dova.JDK.sun.awt.X11GraphicsConfig arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/x11/X11SurfaceDataProxy$Opaque;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/java2d/SurfaceData;ILsun/java2d/loops/CompositeType;Ljava/awt/Color;)Z", "public")]
		public bool isSupportedOperation(Dova.JDK.sun.java2d.SurfaceData arg0, int arg1, Dova.JDK.sun.java2d.loops.CompositeType arg2, Dova.JDK.java.awt.Color arg3)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getTransparency()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/java2d/x11/X11SurfaceDataProxy$Bitmask;", "public static")]
	public partial class Bitmask
		: Dova.JDK.sun.java2d.x11.X11SurfaceDataProxy
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Bitmask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/x11/X11SurfaceDataProxy$Bitmask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/awt/X11GraphicsConfig;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupportedOperation", "(Lsun/java2d/SurfaceData;ILsun/java2d/loops/CompositeType;Ljava/awt/Color;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransparency", "()I"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Bitmask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/awt/X11GraphicsConfig;)V", "public")]
		public Bitmask(Dova.JDK.sun.awt.X11GraphicsConfig arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/x11/X11SurfaceDataProxy$Bitmask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/java2d/SurfaceData;ILsun/java2d/loops/CompositeType;Ljava/awt/Color;)Z", "public")]
		public bool isSupportedOperation(Dova.JDK.sun.java2d.SurfaceData arg0, int arg1, Dova.JDK.sun.java2d.loops.CompositeType arg2, Dova.JDK.java.awt.Color arg3)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getTransparency()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}
}
