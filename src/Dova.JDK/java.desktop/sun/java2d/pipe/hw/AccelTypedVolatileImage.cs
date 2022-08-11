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

namespace Dova.JDK.sun.java2d.pipe.hw;

[JniSignatureAttribute("Lsun/java2d/pipe/hw/AccelTypedVolatileImage;", "public")]
public partial class AccelTypedVolatileImage
	: Dova.JDK.sun.awt.image.SunVolatileImage
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AccelTypedVolatileImage()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/pipe/hw/AccelTypedVolatileImage;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/GraphicsConfiguration;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createGraphics", "()Ljava/awt/Graphics2D;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AccelTypedVolatileImage(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/GraphicsConfiguration;IIII)V", "public")]
	public AccelTypedVolatileImage(Dova.JDK.java.awt.GraphicsConfiguration arg0, int arg1, int arg2, int arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/pipe/hw/AccelTypedVolatileImage;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/awt/Graphics2D;", "public")]
	public Dova.JDK.java.awt.Graphics2D createGraphics()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Graphics2D>(ret);
	}
}
