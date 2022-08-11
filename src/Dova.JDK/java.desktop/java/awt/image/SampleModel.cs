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

[JniSignatureAttribute("Ljava/awt/image/SampleModel;", "public abstract")]
public partial class SampleModel
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SampleModel()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/image/SampleModel;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "width", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "height", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "numBands", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dataType", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initIDs", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPixels", "(IIII[DLjava/awt/image/DataBuffer;)[D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPixels", "(IIII[ILjava/awt/image/DataBuffer;)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPixels", "(IIII[FLjava/awt/image/DataBuffer;)[F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDataType", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPixel", "(II[ILjava/awt/image/DataBuffer;)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPixel", "(II[DLjava/awt/image/DataBuffer;)[D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPixel", "(II[FLjava/awt/image/DataBuffer;)[F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPixel", "(II[ILjava/awt/image/DataBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPixel", "(II[DLjava/awt/image/DataBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPixel", "(II[FLjava/awt/image/DataBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumBands", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSampleSize", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSampleSize", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDataElements", "(IIIILjava/lang/Object;Ljava/awt/image/DataBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDataElements", "(IILjava/lang/Object;Ljava/awt/image/DataBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPixels", "(IIII[FLjava/awt/image/DataBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPixels", "(IIII[ILjava/awt/image/DataBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPixels", "(IIII[DLjava/awt/image/DataBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSample", "(IIIILjava/awt/image/DataBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSample", "(IIIFLjava/awt/image/DataBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSample", "(IIIDLjava/awt/image/DataBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSamples", "(IIIII[ILjava/awt/image/DataBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSamples", "(IIIII[DLjava/awt/image/DataBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSamples", "(IIIII[FLjava/awt/image/DataBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDataBuffer", "()Ljava/awt/image/DataBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumDataElements", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSubsetSampleModel", "([I)Ljava/awt/image/SampleModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSample", "(IIILjava/awt/image/DataBuffer;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSampleFloat", "(IIILjava/awt/image/DataBuffer;)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSampleDouble", "(IIILjava/awt/image/DataBuffer;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSamples", "(IIIII[DLjava/awt/image/DataBuffer;)[D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSamples", "(IIIII[ILjava/awt/image/DataBuffer;)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSamples", "(IIIII[FLjava/awt/image/DataBuffer;)[F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWidth", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeight", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDataElements", "(IIIILjava/lang/Object;Ljava/awt/image/DataBuffer;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDataElements", "(IILjava/lang/Object;Ljava/awt/image/DataBuffer;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransferType", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCompatibleSampleModel", "(II)Ljava/awt/image/SampleModel;"));
	}

	[JniSignatureAttribute("I", "protected")]
	public int width_Property
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

	[JniSignatureAttribute("I", "protected")]
	public int height_Property
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

	[JniSignatureAttribute("I", "protected")]
	public int numBands_Property
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

	[JniSignatureAttribute("I", "protected")]
	public int dataType_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SampleModel(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public SampleModel(int arg0, int arg1, int arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/image/SampleModel;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "private static native")]
	public static void initIDs()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(IIII[DLjava/awt/image/DataBuffer;)[D", "public")]
	public JavaArray<double> getPixels(int arg0, int arg1, int arg2, int arg3, JavaArray<double> arg4, Dova.JDK.java.awt.image.DataBuffer arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
	}

	[JniSignatureAttribute("(IIII[ILjava/awt/image/DataBuffer;)[I", "public")]
	public JavaArray<int> getPixels(int arg0, int arg1, int arg2, int arg3, JavaArray<int> arg4, Dova.JDK.java.awt.image.DataBuffer arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(IIII[FLjava/awt/image/DataBuffer;)[F", "public")]
	public JavaArray<float> getPixels(int arg0, int arg1, int arg2, int arg3, JavaArray<float> arg4, Dova.JDK.java.awt.image.DataBuffer arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int getDataType()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("(II[ILjava/awt/image/DataBuffer;)[I", "public")]
	public JavaArray<int> getPixel(int arg0, int arg1, JavaArray<int> arg2, Dova.JDK.java.awt.image.DataBuffer arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(II[DLjava/awt/image/DataBuffer;)[D", "public")]
	public JavaArray<double> getPixel(int arg0, int arg1, JavaArray<double> arg2, Dova.JDK.java.awt.image.DataBuffer arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
	}

	[JniSignatureAttribute("(II[FLjava/awt/image/DataBuffer;)[F", "public")]
	public JavaArray<float> getPixel(int arg0, int arg1, JavaArray<float> arg2, Dova.JDK.java.awt.image.DataBuffer arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
	}

	[JniSignatureAttribute("(II[ILjava/awt/image/DataBuffer;)V", "public")]
	public void setPixel(int arg0, int arg1, JavaArray<int> arg2, Dova.JDK.java.awt.image.DataBuffer arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(II[DLjava/awt/image/DataBuffer;)V", "public")]
	public void setPixel(int arg0, int arg1, JavaArray<double> arg2, Dova.JDK.java.awt.image.DataBuffer arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(II[FLjava/awt/image/DataBuffer;)V", "public")]
	public void setPixel(int arg0, int arg1, JavaArray<float> arg2, Dova.JDK.java.awt.image.DataBuffer arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int getNumBands()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()[I", "public abstract")]
	public JavaArray<int> getSampleSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(I)I", "public abstract")]
	public int getSampleSize(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IIIILjava/lang/Object;Ljava/awt/image/DataBuffer;)V", "public")]
	public void setDataElements(int arg0, int arg1, int arg2, int arg3, Dova.JDK.java.lang.Object arg4, Dova.JDK.java.awt.image.DataBuffer arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(IILjava/lang/Object;Ljava/awt/image/DataBuffer;)V", "public abstract")]
	public void setDataElements(int arg0, int arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.awt.image.DataBuffer arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(IIII[FLjava/awt/image/DataBuffer;)V", "public")]
	public void setPixels(int arg0, int arg1, int arg2, int arg3, JavaArray<float> arg4, Dova.JDK.java.awt.image.DataBuffer arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(IIII[ILjava/awt/image/DataBuffer;)V", "public")]
	public void setPixels(int arg0, int arg1, int arg2, int arg3, JavaArray<int> arg4, Dova.JDK.java.awt.image.DataBuffer arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(IIII[DLjava/awt/image/DataBuffer;)V", "public")]
	public void setPixels(int arg0, int arg1, int arg2, int arg3, JavaArray<double> arg4, Dova.JDK.java.awt.image.DataBuffer arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(IIIILjava/awt/image/DataBuffer;)V", "public abstract")]
	public void setSample(int arg0, int arg1, int arg2, int arg3, Dova.JDK.java.awt.image.DataBuffer arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(IIIFLjava/awt/image/DataBuffer;)V", "public")]
	public void setSample(int arg0, int arg1, int arg2, float arg3, Dova.JDK.java.awt.image.DataBuffer arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(IIIDLjava/awt/image/DataBuffer;)V", "public")]
	public void setSample(int arg0, int arg1, int arg2, double arg3, Dova.JDK.java.awt.image.DataBuffer arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(IIIII[ILjava/awt/image/DataBuffer;)V", "public")]
	public void setSamples(int arg0, int arg1, int arg2, int arg3, int arg4, JavaArray<int> arg5, Dova.JDK.java.awt.image.DataBuffer arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(IIIII[DLjava/awt/image/DataBuffer;)V", "public")]
	public void setSamples(int arg0, int arg1, int arg2, int arg3, int arg4, JavaArray<double> arg5, Dova.JDK.java.awt.image.DataBuffer arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(IIIII[FLjava/awt/image/DataBuffer;)V", "public")]
	public void setSamples(int arg0, int arg1, int arg2, int arg3, int arg4, JavaArray<float> arg5, Dova.JDK.java.awt.image.DataBuffer arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("()Ljava/awt/image/DataBuffer;", "public abstract")]
	public Dova.JDK.java.awt.image.DataBuffer createDataBuffer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.DataBuffer>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	public int getNumDataElements()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("([I)Ljava/awt/image/SampleModel;", "public abstract")]
	public Dova.JDK.java.awt.image.SampleModel createSubsetSampleModel(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.SampleModel>(ret);
	}

	[JniSignatureAttribute("(IIILjava/awt/image/DataBuffer;)I", "public abstract")]
	public int getSample(int arg0, int arg1, int arg2, Dova.JDK.java.awt.image.DataBuffer arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(IIILjava/awt/image/DataBuffer;)F", "public")]
	public float getSampleFloat(int arg0, int arg1, int arg2, Dova.JDK.java.awt.image.DataBuffer arg3)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(IIILjava/awt/image/DataBuffer;)D", "public")]
	public double getSampleDouble(int arg0, int arg1, int arg2, Dova.JDK.java.awt.image.DataBuffer arg3)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(IIIII[DLjava/awt/image/DataBuffer;)[D", "public")]
	public JavaArray<double> getSamples(int arg0, int arg1, int arg2, int arg3, int arg4, JavaArray<double> arg5, Dova.JDK.java.awt.image.DataBuffer arg6)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
	}

	[JniSignatureAttribute("(IIIII[ILjava/awt/image/DataBuffer;)[I", "public")]
	public JavaArray<int> getSamples(int arg0, int arg1, int arg2, int arg3, int arg4, JavaArray<int> arg5, Dova.JDK.java.awt.image.DataBuffer arg6)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(IIIII[FLjava/awt/image/DataBuffer;)[F", "public")]
	public JavaArray<float> getSamples(int arg0, int arg1, int arg2, int arg3, int arg4, JavaArray<float> arg5, Dova.JDK.java.awt.image.DataBuffer arg6)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int getWidth()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[34]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public final")]
	public int getHeight()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[35]);
		return ret;
	}

	[JniSignatureAttribute("(IIIILjava/lang/Object;Ljava/awt/image/DataBuffer;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getDataElements(int arg0, int arg1, int arg2, int arg3, Dova.JDK.java.lang.Object arg4, Dova.JDK.java.awt.image.DataBuffer arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(IILjava/lang/Object;Ljava/awt/image/DataBuffer;)Ljava/lang/Object;", "public abstract")]
	public Dova.JDK.java.lang.Object getDataElements(int arg0, int arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.awt.image.DataBuffer arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getTransferType()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[38]);
		return ret;
	}

	[JniSignatureAttribute("(II)Ljava/awt/image/SampleModel;", "public abstract")]
	public Dova.JDK.java.awt.image.SampleModel createCompatibleSampleModel(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.SampleModel>(ret);
	}
}
