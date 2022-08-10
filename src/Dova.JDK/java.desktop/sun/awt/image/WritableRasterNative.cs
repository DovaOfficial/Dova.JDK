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

namespace Dova.JDK.sun.awt.image;

[JniSignatureAttribute("Lsun/awt/image/WritableRasterNative;", "public")]
public partial class WritableRasterNative
	: Dova.JDK.java.awt.image.WritableRaster
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static WritableRasterNative()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/WritableRasterNative;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "WritableRasterNative", "(Ljava/awt/image/SampleModel;Ljava/awt/image/DataBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createNativeRaster", "(Ljava/awt/image/SampleModel;Ljava/awt/image/DataBuffer;)Lsun/awt/image/WritableRasterNative;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createNativeRaster", "(Ljava/awt/image/ColorModel;Lsun/java2d/SurfaceData;II)Lsun/awt/image/WritableRasterNative;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public WritableRasterNative(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/image/SampleModel;Ljava/awt/image/DataBuffer;)V", "protected")]
	public WritableRasterNative(Dova.JDK.java.awt.image.SampleModel arg0, Dova.JDK.java.awt.image.DataBuffer arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/image/WritableRasterNative;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/image/SampleModel;Ljava/awt/image/DataBuffer;)Lsun/awt/image/WritableRasterNative;", "public static")]
	public static Dova.JDK.sun.awt.image.WritableRasterNative createNativeRaster(Dova.JDK.java.awt.image.SampleModel arg0, Dova.JDK.java.awt.image.DataBuffer arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.WritableRasterNative>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/ColorModel;Lsun/java2d/SurfaceData;II)Lsun/awt/image/WritableRasterNative;", "public static")]
	public static Dova.JDK.sun.awt.image.WritableRasterNative createNativeRaster(Dova.JDK.java.awt.image.ColorModel arg0, Dova.JDK.sun.java2d.SurfaceData arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.WritableRasterNative>(ret);
	}
}
