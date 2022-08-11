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

namespace Dova.JDK.sun.awt.image;

[JniSignatureAttribute("Lsun/awt/image/ShortComponentRaster;", "public")]
public partial class ShortComponentRaster
	: Dova.JDK.sun.awt.image.SunWritableRaster
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ShortComponentRaster()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/ShortComponentRaster;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bandOffset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dataOffsets", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "scanlineStride", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pixelStride", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "data", "[S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxX", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxY", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/image/SampleModel;Ljava/awt/image/DataBufferUShort;Ljava/awt/Point;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/image/SampleModel;Ljava/awt/Point;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/image/SampleModel;Ljava/awt/image/DataBufferUShort;Ljava/awt/Rectangle;Ljava/awt/Point;Lsun/awt/image/ShortComponentRaster;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initIDs", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verify", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDataOffsets", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createChild", "(IIIIII[I)Ljava/awt/image/Raster;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShortData", "(IIIII[S)[S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShortData", "(IIII[S)[S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putShortData", "(IIIII[S)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putShortData", "(IIII[S)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDataStorage", "()[S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDataOffset", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCompatibleWritableRaster", "()Ljava/awt/image/WritableRaster;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCompatibleWritableRaster", "(II)Ljava/awt/image/WritableRaster;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPixelStride", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDataElements", "(IIIILjava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDataElements", "(IILjava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDataElements", "(IIIILjava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDataElements", "(IIIILjava/awt/image/Raster;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDataElements", "(IILjava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDataElements", "(IILjava/awt/image/Raster;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createWritableChild", "(IIIIII[I)Ljava/awt/image/WritableRaster;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScanlineStride", "()I"));
	}

	[JniSignatureAttribute("I", "protected")]
	public int bandOffset_Property
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

	[JniSignatureAttribute("[I", "protected")]
	public JavaArray<int> dataOffsets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int scanlineStride_Property
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
	public int pixelStride_Property
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

	[JniSignatureAttribute("[S", "protected")]
	public JavaArray<short> data_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<short>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int type_Property
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

	[JniSignatureAttribute("I", "private")]
	public int maxX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int maxY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ShortComponentRaster(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/image/SampleModel;Ljava/awt/image/DataBufferUShort;Ljava/awt/Point;)V", "public")]
	public ShortComponentRaster(Dova.JDK.java.awt.image.SampleModel arg0, Dova.JDK.java.awt.image.DataBufferUShort arg1, Dova.JDK.java.awt.Point arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/image/SampleModel;Ljava/awt/Point;)V", "public")]
	public ShortComponentRaster(Dova.JDK.java.awt.image.SampleModel arg0, Dova.JDK.java.awt.Point arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/image/SampleModel;Ljava/awt/image/DataBufferUShort;Ljava/awt/Rectangle;Ljava/awt/Point;Lsun/awt/image/ShortComponentRaster;)V", "public")]
	public ShortComponentRaster(Dova.JDK.java.awt.image.SampleModel arg0, Dova.JDK.java.awt.image.DataBufferUShort arg1, Dova.JDK.java.awt.Rectangle arg2, Dova.JDK.java.awt.Point arg3, Dova.JDK.sun.awt.image.ShortComponentRaster arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/image/ShortComponentRaster;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "private static native")]
	public static void initIDs()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()V", "protected final")]
	public void verify()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()[I", "public")]
	public JavaArray<int> getDataOffsets()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(IIIIII[I)Ljava/awt/image/Raster;", "public")]
	public Dova.JDK.java.awt.image.Raster createChild(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, JavaArray<int> arg6)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.Raster>(ret);
	}

	[JniSignatureAttribute("(IIIII[S)[S", "public")]
	public JavaArray<short> getShortData(int arg0, int arg1, int arg2, int arg3, int arg4, JavaArray<short> arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<JavaArray<short>>(ret);
	}

	[JniSignatureAttribute("(IIII[S)[S", "public")]
	public JavaArray<short> getShortData(int arg0, int arg1, int arg2, int arg3, JavaArray<short> arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<JavaArray<short>>(ret);
	}

	[JniSignatureAttribute("(IIIII[S)V", "public")]
	public void putShortData(int arg0, int arg1, int arg2, int arg3, int arg4, JavaArray<short> arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(IIII[S)V", "public")]
	public void putShortData(int arg0, int arg1, int arg2, int arg3, JavaArray<short> arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()[S", "public")]
	public JavaArray<short> getDataStorage()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<JavaArray<short>>(ret);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getDataOffset(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/image/WritableRaster;", "public")]
	public Dova.JDK.java.awt.image.WritableRaster createCompatibleWritableRaster()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.WritableRaster>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/awt/image/WritableRaster;", "public")]
	public Dova.JDK.java.awt.image.WritableRaster createCompatibleWritableRaster(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.WritableRaster>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getPixelStride()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("(IIIILjava/lang/Object;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getDataElements(int arg0, int arg1, int arg2, int arg3, Dova.JDK.java.lang.Object arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(IILjava/lang/Object;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getDataElements(int arg0, int arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(IIIILjava/lang/Object;)V", "public")]
	public void setDataElements(int arg0, int arg1, int arg2, int arg3, Dova.JDK.java.lang.Object arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(IIIILjava/awt/image/Raster;)V", "private")]
	public void setDataElements(int arg0, int arg1, int arg2, int arg3, Dova.JDK.java.awt.image.Raster arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(IILjava/lang/Object;)V", "public")]
	public void setDataElements(int arg0, int arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(IILjava/awt/image/Raster;)V", "public")]
	public void setDataElements(int arg0, int arg1, Dova.JDK.java.awt.image.Raster arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(IIIIII[I)Ljava/awt/image/WritableRaster;", "public")]
	public Dova.JDK.java.awt.image.WritableRaster createWritableChild(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, JavaArray<int> arg6)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.WritableRaster>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getScanlineStride()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}
}
