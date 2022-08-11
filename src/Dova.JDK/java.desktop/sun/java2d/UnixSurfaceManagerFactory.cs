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

[JniSignatureAttribute("Lsun/java2d/UnixSurfaceManagerFactory;", "public")]
public partial class UnixSurfaceManagerFactory
	: Dova.JDK.sun.java2d.SurfaceManagerFactory
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static UnixSurfaceManagerFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/UnixSurfaceManagerFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createVolatileManager", "(Lsun/awt/image/SunVolatileImage;Ljava/lang/Object;)Lsun/awt/image/VolatileSurfaceManager;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public UnixSurfaceManagerFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public UnixSurfaceManagerFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/UnixSurfaceManagerFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/awt/image/SunVolatileImage;Ljava/lang/Object;)Lsun/awt/image/VolatileSurfaceManager;", "public")]
	public Dova.JDK.sun.awt.image.VolatileSurfaceManager createVolatileManager(Dova.JDK.sun.awt.image.SunVolatileImage arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.VolatileSurfaceManager>(ret);
	}
}
