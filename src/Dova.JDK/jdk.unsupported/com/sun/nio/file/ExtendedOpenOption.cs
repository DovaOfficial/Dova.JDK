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

namespace Dova.JDK.com.sun.nio.file;

[JniSignatureAttribute("Lcom/sun/nio/file/ExtendedOpenOption;", "public final")]
public partial class ExtendedOpenOption
	: Dova.JDK.java.lang.Enum
	, Dova.JDK.java.nio.file.OpenOption
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ExtendedOpenOption()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/nio/file/ExtendedOpenOption;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NOSHARE_READ", "Lcom/sun/nio/file/ExtendedOpenOption;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NOSHARE_WRITE", "Lcom/sun/nio/file/ExtendedOpenOption;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NOSHARE_DELETE", "Lcom/sun/nio/file/ExtendedOpenOption;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECT", "Lcom/sun/nio/file/ExtendedOpenOption;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/nio/file/ExtendedOpenOption;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ExtendedOpenOption", "(Ljava/lang/String;ILjdk/internal/misc/FileSystemOption;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/nio/file/ExtendedOpenOption;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/nio/file/ExtendedOpenOption;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/nio/file/ExtendedOpenOption;"));
	}

	[JniSignatureAttribute("Lcom/sun/nio/file/ExtendedOpenOption;", "public static final")]
	public static Dova.JDK.com.sun.nio.file.ExtendedOpenOption NOSHARE_READ_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.file.ExtendedOpenOption>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/nio/file/ExtendedOpenOption;", "public static final")]
	public static Dova.JDK.com.sun.nio.file.ExtendedOpenOption NOSHARE_WRITE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.file.ExtendedOpenOption>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/nio/file/ExtendedOpenOption;", "public static final")]
	public static Dova.JDK.com.sun.nio.file.ExtendedOpenOption NOSHARE_DELETE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.file.ExtendedOpenOption>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/nio/file/ExtendedOpenOption;", "public static final")]
	public static Dova.JDK.com.sun.nio.file.ExtendedOpenOption DIRECT_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.file.ExtendedOpenOption>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Lcom/sun/nio/file/ExtendedOpenOption;", "private static final")]
	public static JavaArray<Dova.JDK.com.sun.nio.file.ExtendedOpenOption> VALUES_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.nio.file.ExtendedOpenOption>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ExtendedOpenOption(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjdk/internal/misc/FileSystemOption;)V", "private")]
	public ExtendedOpenOption(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.jdk.@internal.misc.FileSystemOption arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/nio/file/ExtendedOpenOption;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lcom/sun/nio/file/ExtendedOpenOption;", "public static")]
	public static JavaArray<Dova.JDK.com.sun.nio.file.ExtendedOpenOption> values()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.nio.file.ExtendedOpenOption>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/nio/file/ExtendedOpenOption;", "public static")]
	public static Dova.JDK.com.sun.nio.file.ExtendedOpenOption valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.file.ExtendedOpenOption>(ret);
	}

	[JniSignatureAttribute("()[Lcom/sun/nio/file/ExtendedOpenOption;", "private static")]
	public static JavaArray<Dova.JDK.com.sun.nio.file.ExtendedOpenOption> _values()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.nio.file.ExtendedOpenOption>>(ret);
	}
}
