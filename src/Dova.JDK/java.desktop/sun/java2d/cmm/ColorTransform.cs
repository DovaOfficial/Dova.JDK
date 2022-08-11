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

namespace Dova.JDK.sun.java2d.cmm;

[JniSignatureAttribute("Lsun/java2d/cmm/ColorTransform;", "public abstract interface")]
public partial interface ColorTransform
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ColorTransform()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/cmm/ColorTransform;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Any", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "In", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Out", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Gamut", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Simulation", "I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "colorConvert", "([S[S)[S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "colorConvert", "(Ljava/awt/image/Raster;Ljava/awt/image/WritableRaster;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "colorConvert", "([B[B)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "colorConvert", "(Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImage;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "colorConvert", "(Ljava/awt/image/Raster;Ljava/awt/image/WritableRaster;[F[F[F[F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumInComponents", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumOutComponents", "()I"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int Any_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int In_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int Out_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int Gamut_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int Simulation_Property
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

	[JniSignatureAttribute("([S[S)[S", "public abstract")]
	JavaArray<short> colorConvert(JavaArray<short> arg0, JavaArray<short> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<short>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/Raster;Ljava/awt/image/WritableRaster;)V", "public abstract")]
	void colorConvert(Dova.JDK.java.awt.image.Raster arg0, Dova.JDK.java.awt.image.WritableRaster arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("([B[B)[B", "public abstract")]
	JavaArray<byte> colorConvert(JavaArray<byte> arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImage;)V", "public abstract")]
	void colorConvert(Dova.JDK.java.awt.image.BufferedImage arg0, Dova.JDK.java.awt.image.BufferedImage arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/image/Raster;Ljava/awt/image/WritableRaster;[F[F[F[F)V", "public abstract")]
	void colorConvert(Dova.JDK.java.awt.image.Raster arg0, Dova.JDK.java.awt.image.WritableRaster arg1, JavaArray<float> arg2, JavaArray<float> arg3, JavaArray<float> arg4, JavaArray<float> arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getNumInComponents()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getNumOutComponents()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}
}
