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

namespace Dova.JDK.com.sun.nio.file;

[JniSignatureAttribute("Lcom/sun/nio/file/ExtendedWatchEventModifier;", "public final")]
public partial class ExtendedWatchEventModifier
	: Dova.JDK.java.lang.Enum
	, Dova.JDK.java.nio.file.WatchEvent.Modifier
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ExtendedWatchEventModifier()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/nio/file/ExtendedWatchEventModifier;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FILE_TREE", "Lcom/sun/nio/file/ExtendedWatchEventModifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/nio/file/ExtendedWatchEventModifier;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjdk/internal/misc/FileSystemOption;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/nio/file/ExtendedWatchEventModifier;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/nio/file/ExtendedWatchEventModifier;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/nio/file/ExtendedWatchEventModifier;"));
	}

	[JniSignatureAttribute("Lcom/sun/nio/file/ExtendedWatchEventModifier;", "public static final")]
	public static Dova.JDK.com.sun.nio.file.ExtendedWatchEventModifier FILE_TREE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.file.ExtendedWatchEventModifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/nio/file/ExtendedWatchEventModifier;", "private static final")]
	public static JavaArray<Dova.JDK.com.sun.nio.file.ExtendedWatchEventModifier> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.nio.file.ExtendedWatchEventModifier>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ExtendedWatchEventModifier(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjdk/internal/misc/FileSystemOption;)V", "private")]
	public ExtendedWatchEventModifier(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.jdk.@internal.misc.FileSystemOption arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/nio/file/ExtendedWatchEventModifier;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lcom/sun/nio/file/ExtendedWatchEventModifier;", "public static")]
	public static JavaArray<Dova.JDK.com.sun.nio.file.ExtendedWatchEventModifier> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.nio.file.ExtendedWatchEventModifier>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/nio/file/ExtendedWatchEventModifier;", "public static")]
	public static Dova.JDK.com.sun.nio.file.ExtendedWatchEventModifier valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.file.ExtendedWatchEventModifier>(ret);
	}

	[JniSignatureAttribute("()[Lcom/sun/nio/file/ExtendedWatchEventModifier;", "private static")]
	public static JavaArray<Dova.JDK.com.sun.nio.file.ExtendedWatchEventModifier> _values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.nio.file.ExtendedWatchEventModifier>>(ret);
	}
}
