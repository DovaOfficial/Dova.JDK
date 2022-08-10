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

namespace Dova.JDK.com.sun.nio.file;

[JniSignatureAttribute("Lcom/sun/nio/file/ExtendedCopyOption;", "public final")]
public partial class ExtendedCopyOption
	: Dova.JDK.java.lang.Enum
	, Dova.JDK.java.nio.file.CopyOption
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ExtendedCopyOption()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/nio/file/ExtendedCopyOption;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INTERRUPTIBLE", "Lcom/sun/nio/file/ExtendedCopyOption;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/nio/file/ExtendedCopyOption;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ExtendedCopyOption", "(Ljava/lang/String;ILjdk/internal/misc/FileSystemOption;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/nio/file/ExtendedCopyOption;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/nio/file/ExtendedCopyOption;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/nio/file/ExtendedCopyOption;"));
	}

	[JniSignatureAttribute("Lcom/sun/nio/file/ExtendedCopyOption;", "public static final")]
	public static Dova.JDK.com.sun.nio.file.ExtendedCopyOption INTERRUPTIBLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.file.ExtendedCopyOption>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Lcom/sun/nio/file/ExtendedCopyOption;", "private static final")]
	public static JavaArray<Dova.JDK.com.sun.nio.file.ExtendedCopyOption> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.nio.file.ExtendedCopyOption>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ExtendedCopyOption(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjdk/internal/misc/FileSystemOption;)V", "private")]
	public ExtendedCopyOption(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.jdk.@internal.misc.FileSystemOption arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/nio/file/ExtendedCopyOption;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lcom/sun/nio/file/ExtendedCopyOption;", "public static")]
	public static JavaArray<Dova.JDK.com.sun.nio.file.ExtendedCopyOption> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.nio.file.ExtendedCopyOption>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/nio/file/ExtendedCopyOption;", "public static")]
	public static Dova.JDK.com.sun.nio.file.ExtendedCopyOption valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.file.ExtendedCopyOption>(ret);
	}

	[JniSignatureAttribute("()[Lcom/sun/nio/file/ExtendedCopyOption;", "private static")]
	public static JavaArray<Dova.JDK.com.sun.nio.file.ExtendedCopyOption> _values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.nio.file.ExtendedCopyOption>>(ret);
	}
}
