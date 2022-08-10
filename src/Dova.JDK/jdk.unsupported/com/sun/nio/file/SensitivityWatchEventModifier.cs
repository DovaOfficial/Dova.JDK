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

[JniSignatureAttribute("Lcom/sun/nio/file/SensitivityWatchEventModifier;", "public final")]
public partial class SensitivityWatchEventModifier
	: Dova.JDK.java.lang.Enum
	, Dova.JDK.java.nio.file.WatchEvent.Modifier
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SensitivityWatchEventModifier()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/nio/file/SensitivityWatchEventModifier;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HIGH", "Lcom/sun/nio/file/SensitivityWatchEventModifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MEDIUM", "Lcom/sun/nio/file/SensitivityWatchEventModifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LOW", "Lcom/sun/nio/file/SensitivityWatchEventModifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "sensitivity", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/nio/file/SensitivityWatchEventModifier;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SensitivityWatchEventModifier", "(Ljava/lang/String;ILjdk/internal/misc/FileSystemOption;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/nio/file/SensitivityWatchEventModifier;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/nio/file/SensitivityWatchEventModifier;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/nio/file/SensitivityWatchEventModifier;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "sensitivityValueInSeconds", "()I"));
	}

	[JniSignatureAttribute("Lcom/sun/nio/file/SensitivityWatchEventModifier;", "public static final")]
	public static Dova.JDK.com.sun.nio.file.SensitivityWatchEventModifier HIGH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.file.SensitivityWatchEventModifier>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/nio/file/SensitivityWatchEventModifier;", "public static final")]
	public static Dova.JDK.com.sun.nio.file.SensitivityWatchEventModifier MEDIUM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.file.SensitivityWatchEventModifier>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/nio/file/SensitivityWatchEventModifier;", "public static final")]
	public static Dova.JDK.com.sun.nio.file.SensitivityWatchEventModifier LOW_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.file.SensitivityWatchEventModifier>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private final")]
	public int sensitivity_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("[Lcom/sun/nio/file/SensitivityWatchEventModifier;", "private static final")]
	public static JavaArray<Dova.JDK.com.sun.nio.file.SensitivityWatchEventModifier> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.nio.file.SensitivityWatchEventModifier>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SensitivityWatchEventModifier(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjdk/internal/misc/FileSystemOption;I)V", "private")]
	public SensitivityWatchEventModifier(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.jdk.@internal.misc.FileSystemOption arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/nio/file/SensitivityWatchEventModifier;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lcom/sun/nio/file/SensitivityWatchEventModifier;", "public static")]
	public static JavaArray<Dova.JDK.com.sun.nio.file.SensitivityWatchEventModifier> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.nio.file.SensitivityWatchEventModifier>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/nio/file/SensitivityWatchEventModifier;", "public static")]
	public static Dova.JDK.com.sun.nio.file.SensitivityWatchEventModifier valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.file.SensitivityWatchEventModifier>(ret);
	}

	[JniSignatureAttribute("()[Lcom/sun/nio/file/SensitivityWatchEventModifier;", "private static")]
	public static JavaArray<Dova.JDK.com.sun.nio.file.SensitivityWatchEventModifier> _values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.nio.file.SensitivityWatchEventModifier>>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int sensitivityValueInSeconds()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}
}
