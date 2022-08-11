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

[JniSignatureAttribute("Ljava/awt/image/DataBufferFloat;", "public final")]
public partial class DataBufferFloat
	: Dova.JDK.java.awt.image.DataBuffer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DataBufferFloat()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/image/DataBufferFloat;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bankdata", "[[F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "data", "[F"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([[FI[I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([[FI)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([FII)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(II)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([FI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBankData", "()[[F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElem", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElem", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setElem", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setElem", "(III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElemFloat", "(II)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElemFloat", "(I)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setElemFloat", "(IIF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setElemFloat", "(IF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElemDouble", "(I)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElemDouble", "(II)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setElemDouble", "(ID)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setElemDouble", "(IID)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getData", "()[F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getData", "(I)[F"));
	}

	[JniSignatureAttribute("[[F", "")]
	public JavaArray<JavaArray<float>> bankdata_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<float>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[F", "")]
	public JavaArray<float> data_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DataBufferFloat(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([[FI[I)V", "public")]
	public DataBufferFloat(JavaArray<JavaArray<float>> arg0, int arg1, JavaArray<int> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("([[FI)V", "public")]
	public DataBufferFloat(JavaArray<JavaArray<float>> arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("([FII)V", "public")]
	public DataBufferFloat(JavaArray<float> arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public DataBufferFloat(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0))
	{
	}

	[JniSignatureAttribute("(II)V", "public")]
	public DataBufferFloat(int arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0, arg1))
	{
	}

	[JniSignatureAttribute("([FI)V", "public")]
	public DataBufferFloat(JavaArray<float> arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[5], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/image/DataBufferFloat;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[[F", "public")]
	public JavaArray<JavaArray<float>> getBankData()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<JavaArray<float>>>(ret);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getElem(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "public")]
	public int getElem(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void setElem(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(III)V", "public")]
	public void setElem(int arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(II)F", "public")]
	public float getElemFloat(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)F", "public")]
	public float getElemFloat(int arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IIF)V", "public")]
	public void setElemFloat(int arg0, int arg1, float arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(IF)V", "public")]
	public void setElemFloat(int arg0, float arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(I)D", "public")]
	public double getElemDouble(int arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)D", "public")]
	public double getElemDouble(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ID)V", "public")]
	public void setElemDouble(int arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(IID)V", "public")]
	public void setElemDouble(int arg0, int arg1, double arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()[F", "public")]
	public JavaArray<float> getData()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
	}

	[JniSignatureAttribute("(I)[F", "public")]
	public JavaArray<float> getData(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
	}
}
