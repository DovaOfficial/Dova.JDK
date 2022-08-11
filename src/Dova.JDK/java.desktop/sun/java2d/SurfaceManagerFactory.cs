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

namespace Dova.JDK.sun.java2d;

[JniSignatureAttribute("Lsun/java2d/SurfaceManagerFactory;", "public abstract")]
public partial class SurfaceManagerFactory
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SurfaceManagerFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/SurfaceManagerFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/java2d/SurfaceManagerFactory;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "()Lsun/java2d/SurfaceManagerFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createVolatileManager", "(Lsun/awt/image/SunVolatileImage;Ljava/lang/Object;)Lsun/awt/image/VolatileSurfaceManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setInstance", "(Lsun/java2d/SurfaceManagerFactory;)V"));
	}

	[JniSignatureAttribute("Lsun/java2d/SurfaceManagerFactory;", "private static")]
	public static Dova.JDK.sun.java2d.SurfaceManagerFactory instance_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceManagerFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SurfaceManagerFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SurfaceManagerFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/SurfaceManagerFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/java2d/SurfaceManagerFactory;", "public static synchronized")]
	public static Dova.JDK.sun.java2d.SurfaceManagerFactory getInstance()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceManagerFactory>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/image/SunVolatileImage;Ljava/lang/Object;)Lsun/awt/image/VolatileSurfaceManager;", "public abstract")]
	public Dova.JDK.sun.awt.image.VolatileSurfaceManager createVolatileManager(Dova.JDK.sun.awt.image.SunVolatileImage arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.VolatileSurfaceManager>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/SurfaceManagerFactory;)V", "public static synchronized")]
	public static void setInstance(Dova.JDK.sun.java2d.SurfaceManagerFactory arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0);
	}
}
