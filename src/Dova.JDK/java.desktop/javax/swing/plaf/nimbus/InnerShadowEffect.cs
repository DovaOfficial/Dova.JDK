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

namespace Dova.JDK.javax.swing.plaf.nimbus;

[JniSignatureAttribute("Ljavax/swing/plaf/nimbus/InnerShadowEffect;", "")]
public partial class InnerShadowEffect
	: Dova.JDK.javax.swing.plaf.nimbus.ShadowEffect
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InnerShadowEffect()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/nimbus/InnerShadowEffect;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEffectType", "()Ljavax/swing/plaf/nimbus/Effect$EffectType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyEffect", "(Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImage;II)Ljava/awt/image/BufferedImage;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public InnerShadowEffect(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public InnerShadowEffect() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/nimbus/InnerShadowEffect;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/swing/plaf/nimbus/Effect$EffectType;", "")]
	public Dova.JDK.javax.swing.plaf.nimbus.Effect.EffectType getEffectType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.nimbus.Effect.EffectType>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImage;II)Ljava/awt/image/BufferedImage;", "")]
	public Dova.JDK.java.awt.image.BufferedImage applyEffect(Dova.JDK.java.awt.image.BufferedImage arg0, Dova.JDK.java.awt.image.BufferedImage arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
	}
}
