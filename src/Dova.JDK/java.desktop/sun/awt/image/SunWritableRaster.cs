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

[JniSignatureAttribute("Lsun/awt/image/SunWritableRaster;", "public")]
public partial class SunWritableRaster
	: Dova.JDK.java.awt.image.WritableRaster
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SunWritableRaster()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/SunWritableRaster;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "stealer", "Lsun/awt/image/SunWritableRaster$DataStealer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "theTrackable", "Lsun/java2d/StateTrackableDelegate;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SunWritableRaster", "(Ljava/awt/image/SampleModel;Ljava/awt/image/DataBuffer;Ljava/awt/Point;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SunWritableRaster", "(Ljava/awt/image/SampleModel;Ljava/awt/image/DataBuffer;Ljava/awt/Rectangle;Ljava/awt/Point;Ljava/awt/image/WritableRaster;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SunWritableRaster", "(Ljava/awt/image/SampleModel;Ljava/awt/Point;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setTrackable", "(Ljava/awt/image/DataBuffer;Lsun/java2d/StateTrackableDelegate;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setDataStealer", "(Lsun/awt/image/SunWritableRaster$DataStealer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makeTrackable", "(Ljava/awt/image/DataBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "markDirty", "(Ljava/awt/image/WritableRaster;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "markDirty", "(Ljava/awt/Image;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "markDirty", "(Ljava/awt/image/DataBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "markDirty", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "stealTrackable", "(Ljava/awt/image/DataBuffer;)Lsun/java2d/StateTrackableDelegate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "stealData", "(Ljava/awt/image/DataBufferUShort;I)[S"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "stealData", "(Ljava/awt/image/DataBufferByte;I)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "stealData", "(Ljava/awt/image/DataBufferInt;I)[I"));
	}

	[JniSignatureAttribute("Lsun/awt/image/SunWritableRaster$DataStealer;", "private static")]
	public static Dova.JDK.sun.awt.image.SunWritableRaster.DataStealer stealer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.SunWritableRaster.DataStealer>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/java2d/StateTrackableDelegate;", "private")]
	public Dova.JDK.sun.java2d.StateTrackableDelegate theTrackable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.StateTrackableDelegate>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SunWritableRaster(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/image/SampleModel;Ljava/awt/image/DataBuffer;Ljava/awt/Point;)V", "public")]
	public SunWritableRaster(Dova.JDK.java.awt.image.SampleModel arg0, Dova.JDK.java.awt.image.DataBuffer arg1, Dova.JDK.java.awt.Point arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/image/SampleModel;Ljava/awt/image/DataBuffer;Ljava/awt/Rectangle;Ljava/awt/Point;Ljava/awt/image/WritableRaster;)V", "public")]
	public SunWritableRaster(Dova.JDK.java.awt.image.SampleModel arg0, Dova.JDK.java.awt.image.DataBuffer arg1, Dova.JDK.java.awt.Rectangle arg2, Dova.JDK.java.awt.Point arg3, Dova.JDK.java.awt.image.WritableRaster arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/image/SampleModel;Ljava/awt/Point;)V", "public")]
	public SunWritableRaster(Dova.JDK.java.awt.image.SampleModel arg0, Dova.JDK.java.awt.Point arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/image/SunWritableRaster;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/image/DataBuffer;Lsun/java2d/StateTrackableDelegate;)V", "public static")]
	public static void setTrackable(Dova.JDK.java.awt.image.DataBuffer arg0, Dova.JDK.sun.java2d.StateTrackableDelegate arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/awt/image/SunWritableRaster$DataStealer;)V", "public static")]
	public static void setDataStealer(Dova.JDK.sun.awt.image.SunWritableRaster.DataStealer arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/image/DataBuffer;)V", "public static")]
	public static void makeTrackable(Dova.JDK.java.awt.image.DataBuffer arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/image/WritableRaster;)V", "public static")]
	public static void markDirty(Dova.JDK.java.awt.image.WritableRaster arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Image;)V", "public static")]
	public static void markDirty(Dova.JDK.java.awt.Image arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/image/DataBuffer;)V", "public static")]
	public static void markDirty(Dova.JDK.java.awt.image.DataBuffer arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("()V", "public final")]
	public void markDirty()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("(Ljava/awt/image/DataBuffer;)Lsun/java2d/StateTrackableDelegate;", "public static")]
	public static Dova.JDK.sun.java2d.StateTrackableDelegate stealTrackable(Dova.JDK.java.awt.image.DataBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.StateTrackableDelegate>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/DataBufferUShort;I)[S", "public static")]
	public static JavaArray<short> stealData(Dova.JDK.java.awt.image.DataBufferUShort arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<short>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/DataBufferByte;I)[B", "public static")]
	public static JavaArray<byte> stealData(Dova.JDK.java.awt.image.DataBufferByte arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/DataBufferInt;I)[I", "public static")]
	public static JavaArray<int> stealData(Dova.JDK.java.awt.image.DataBufferInt arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("Lsun/awt/image/SunWritableRaster$DataStealer;", "public abstract static interface")]
	public partial interface DataStealer
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DataStealer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/SunWritableRaster$DataStealer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getData", "(Ljava/awt/image/DataBufferInt;I)[I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getData", "(Ljava/awt/image/DataBufferUShort;I)[S"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getData", "(Ljava/awt/image/DataBufferByte;I)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTrackable", "(Ljava/awt/image/DataBuffer;)Lsun/java2d/StateTrackableDelegate;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setTrackable", "(Ljava/awt/image/DataBuffer;Lsun/java2d/StateTrackableDelegate;)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/image/DataBufferInt;I)[I", "public abstract")]
		JavaArray<int> getData(Dova.JDK.java.awt.image.DataBufferInt arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/image/DataBufferUShort;I)[S", "public abstract")]
		JavaArray<short> getData(Dova.JDK.java.awt.image.DataBufferUShort arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<short>>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/image/DataBufferByte;I)[B", "public abstract")]
		JavaArray<byte> getData(Dova.JDK.java.awt.image.DataBufferByte arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/image/DataBuffer;)Lsun/java2d/StateTrackableDelegate;", "public abstract")]
		Dova.JDK.sun.java2d.StateTrackableDelegate getTrackable(Dova.JDK.java.awt.image.DataBuffer arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.StateTrackableDelegate>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/image/DataBuffer;Lsun/java2d/StateTrackableDelegate;)V", "public abstract")]
		void setTrackable(Dova.JDK.java.awt.image.DataBuffer arg0, Dova.JDK.sun.java2d.StateTrackableDelegate arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}
	}
}
