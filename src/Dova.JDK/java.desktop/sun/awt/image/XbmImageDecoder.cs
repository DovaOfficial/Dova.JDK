/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.awt.image;

[JniSignatureAttribute("Lsun/awt/image/XbmImageDecoder;", "public")]
public partial class XbmImageDecoder
	: Dova.JDK.sun.awt.image.ImageDecoder
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XbmImageDecoder()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/image/XbmImageDecoder;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "XbmColormap", "[B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "XbmHints", "I"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "XbmImageDecoder", "(Lsun/awt/image/InputStreamImageSource;Ljava/io/InputStream;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "error", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "produceImage", "()V"));
	}

	[JniSignatureAttribute("[B", "private static")]
	public static JavaArray<byte> XbmColormap_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private static")]
	public static int XbmHints_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XbmImageDecoder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/awt/image/InputStreamImageSource;Ljava/io/InputStream;)V", "public")]
	public XbmImageDecoder(Dova.JDK.sun.awt.image.InputStreamImageSource arg0, Dova.JDK.java.io.InputStream arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/image/XbmImageDecoder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private static")]
	public static void error(Dova.JDK.java.lang.String arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void produceImage()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}
}