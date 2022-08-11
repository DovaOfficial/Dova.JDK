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

namespace Dova.JDK.javax.imageio.spi;

[JniSignatureAttribute("Ljavax/imageio/spi/ImageReaderSpi;", "public abstract")]
public partial class ImageReaderSpi
	: Dova.JDK.javax.imageio.spi.ImageReaderWriterSpi
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ImageReaderSpi()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/imageio/spi/ImageReaderSpi;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STANDARD_INPUT_TYPE", "[Ljava/lang/Class;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inputTypes", "[Ljava/lang/Class;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writerSpiNames", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readerClass", "Ljava/lang/Class;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/String;ZLjava/lang/String;Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;ZLjava/lang/String;Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createReaderInstance", "(Ljava/lang/Object;)Ljavax/imageio/ImageReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createReaderInstance", "()Ljavax/imageio/ImageReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInputTypes", "()[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canDecodeInput", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isOwnReader", "(Ljavax/imageio/ImageReader;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImageWriterSpiNames", "()[Ljava/lang/String;"));
	}

	[JniSignatureAttribute("[Ljava/lang/Class;", "public static final")]
	public static JavaArray<Dova.JDK.java.lang.Class> STANDARD_INPUT_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/Class;", "protected")]
	public JavaArray<Dova.JDK.java.lang.Class> inputTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "protected")]
	public JavaArray<Dova.JDK.java.lang.String> writerSpiNames_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Class;", "private")]
	public Dova.JDK.java.lang.Class readerClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ImageReaderSpi(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public ImageReaderSpi() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/String;ZLjava/lang/String;Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;ZLjava/lang/String;Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V", "public")]
	public ImageReaderSpi(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.String> arg2, JavaArray<Dova.JDK.java.lang.String> arg3, JavaArray<Dova.JDK.java.lang.String> arg4, Dova.JDK.java.lang.String arg5, JavaArray<Dova.JDK.java.lang.Class> arg6, JavaArray<Dova.JDK.java.lang.String> arg7, bool arg8, Dova.JDK.java.lang.String arg9, Dova.JDK.java.lang.String arg10, JavaArray<Dova.JDK.java.lang.String> arg11, JavaArray<Dova.JDK.java.lang.String> arg12, bool arg13, Dova.JDK.java.lang.String arg14, Dova.JDK.java.lang.String arg15, JavaArray<Dova.JDK.java.lang.String> arg16, JavaArray<Dova.JDK.java.lang.String> arg17) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/imageio/spi/ImageReaderSpi;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljavax/imageio/ImageReader;", "public abstract")]
	public Dova.JDK.javax.imageio.ImageReader createReaderInstance(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.ImageReader>(ret);
	}

	[JniSignatureAttribute("()Ljavax/imageio/ImageReader;", "public")]
	public Dova.JDK.javax.imageio.ImageReader createReaderInstance()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.ImageReader>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/Class;", "public")]
	public JavaArray<Dova.JDK.java.lang.Class> getInputTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public abstract")]
	public bool canDecodeInput(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageReader;)Z", "public")]
	public bool isOwnReader(Dova.JDK.javax.imageio.ImageReader arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getImageWriterSpiNames()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}
}
