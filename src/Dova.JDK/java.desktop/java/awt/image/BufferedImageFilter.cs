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

namespace Dova.JDK.java.awt.image;

[JniSignatureAttribute("Ljava/awt/image/BufferedImageFilter;", "public")]
public partial class BufferedImageFilter
	: Dova.JDK.java.awt.image.ImageFilter
	, Dova.JDK.java.lang.Cloneable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BufferedImageFilter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/image/BufferedImageFilter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bufferedImageOp", "Ljava/awt/image/BufferedImageOp;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "model", "Ljava/awt/image/ColorModel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "width", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "height", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bytePixels", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "intPixels", "[I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/image/BufferedImageOp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertToRGB", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDCMraster", "()Ljava/awt/image/WritableRaster;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBufferedImageOp", "()Ljava/awt/image/BufferedImageOp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setColorModel", "(Ljava/awt/image/ColorModel;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPixels", "(IIIILjava/awt/image/ColorModel;[III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPixels", "(IIIILjava/awt/image/ColorModel;[BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDimensions", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "imageComplete", "(I)V"));
	}

	[JniSignatureAttribute("Ljava/awt/image/BufferedImageOp;", "")]
	public Dova.JDK.java.awt.image.BufferedImageOp bufferedImageOp_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImageOp>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/image/ColorModel;", "")]
	public Dova.JDK.java.awt.image.ColorModel model_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.ColorModel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int width_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int height_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("[B", "")]
	public JavaArray<byte> bytePixels_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "")]
	public JavaArray<int> intPixels_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BufferedImageFilter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImageOp;)V", "public")]
	public BufferedImageFilter(Dova.JDK.java.awt.image.BufferedImageOp arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/image/BufferedImageFilter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "private")]
	public void convertToRGB()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()Ljava/awt/image/WritableRaster;", "private")]
	public Dova.JDK.java.awt.image.WritableRaster createDCMraster()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.WritableRaster>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/image/BufferedImageOp;", "public")]
	public Dova.JDK.java.awt.image.BufferedImageOp getBufferedImageOp()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImageOp>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/ColorModel;)V", "public")]
	public void setColorModel(Dova.JDK.java.awt.image.ColorModel arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(IIIILjava/awt/image/ColorModel;[III)V", "public")]
	public void setPixels(int arg0, int arg1, int arg2, int arg3, Dova.JDK.java.awt.image.ColorModel arg4, JavaArray<int> arg5, int arg6, int arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(IIIILjava/awt/image/ColorModel;[BII)V", "public")]
	public void setPixels(int arg0, int arg1, int arg2, int arg3, Dova.JDK.java.awt.image.ColorModel arg4, JavaArray<byte> arg5, int arg6, int arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void setDimensions(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void imageComplete(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}
}
