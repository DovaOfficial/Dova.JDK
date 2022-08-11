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

[JniSignatureAttribute("Ljava/awt/image/MultiPixelPackedSampleModel;", "public")]
public partial class MultiPixelPackedSampleModel
	: Dova.JDK.java.awt.image.SampleModel
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MultiPixelPackedSampleModel()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/image/MultiPixelPackedSampleModel;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pixelBitStride", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bitMask", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pixelsPerDataElement", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dataElementSize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dataBitOffset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "scanlineStride", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IIII)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOffset", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDataBuffer", "()Ljava/awt/image/DataBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSubsetSampleModel", "([I)Ljava/awt/image/SampleModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSample", "(IIILjava/awt/image/DataBuffer;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSample", "(IIIILjava/awt/image/DataBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPixelBitStride", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDataBitOffset", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDataElements", "(IILjava/lang/Object;Ljava/awt/image/DataBuffer;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransferType", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCompatibleSampleModel", "(II)Ljava/awt/image/SampleModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPixel", "(II[ILjava/awt/image/DataBuffer;)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPixel", "(II[ILjava/awt/image/DataBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumDataElements", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScanlineStride", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBitOffset", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSampleSize", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSampleSize", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDataElements", "(IILjava/lang/Object;Ljava/awt/image/DataBuffer;)V"));
	}

	[JniSignatureAttribute("I", "")]
	public int pixelBitStride_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int bitMask_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int pixelsPerDataElement_Property
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
	public int dataElementSize_Property
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

	[JniSignatureAttribute("I", "")]
	public int dataBitOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int scanlineStride_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MultiPixelPackedSampleModel(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public MultiPixelPackedSampleModel(int arg0, int arg1, int arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(IIIIII)V", "public")]
	public MultiPixelPackedSampleModel(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/image/MultiPixelPackedSampleModel;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "public")]
	public int getOffset(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/image/DataBuffer;", "public")]
	public Dova.JDK.java.awt.image.DataBuffer createDataBuffer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.DataBuffer>(ret);
	}

	[JniSignatureAttribute("([I)Ljava/awt/image/SampleModel;", "public")]
	public Dova.JDK.java.awt.image.SampleModel createSubsetSampleModel(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.SampleModel>(ret);
	}

	[JniSignatureAttribute("(IIILjava/awt/image/DataBuffer;)I", "public")]
	public int getSample(int arg0, int arg1, int arg2, Dova.JDK.java.awt.image.DataBuffer arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(IIIILjava/awt/image/DataBuffer;)V", "public")]
	public void setSample(int arg0, int arg1, int arg2, int arg3, Dova.JDK.java.awt.image.DataBuffer arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getPixelBitStride()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getDataBitOffset()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("(IILjava/lang/Object;Ljava/awt/image/DataBuffer;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getDataElements(int arg0, int arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.awt.image.DataBuffer arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getTransferType()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(II)Ljava/awt/image/SampleModel;", "public")]
	public Dova.JDK.java.awt.image.SampleModel createCompatibleSampleModel(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.SampleModel>(ret);
	}

	[JniSignatureAttribute("(II[ILjava/awt/image/DataBuffer;)[I", "public")]
	public JavaArray<int> getPixel(int arg0, int arg1, JavaArray<int> arg2, Dova.JDK.java.awt.image.DataBuffer arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(II[ILjava/awt/image/DataBuffer;)V", "public")]
	public void setPixel(int arg0, int arg1, JavaArray<int> arg2, Dova.JDK.java.awt.image.DataBuffer arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getNumDataElements()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getScanlineStride()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getBitOffset(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[I", "public")]
	public JavaArray<int> getSampleSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getSampleSize(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IILjava/lang/Object;Ljava/awt/image/DataBuffer;)V", "public")]
	public void setDataElements(int arg0, int arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.awt.image.DataBuffer arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
	}
}
