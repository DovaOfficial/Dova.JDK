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

namespace Dova.JDK.jdk.@internal.module;

[JniSignatureAttribute("Ljdk/internal/module/ModuleResolution;", "public final")]
public partial class ModuleResolution
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ModuleResolution()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/module/ModuleResolution;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "empty", "()Ljdk/internal/module/ModuleResolution;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasIncubatingWarning", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hasIncubatingWarning", "(Ljava/lang/module/ModuleReference;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doNotResolveByDefault", "(Ljava/lang/module/ModuleReference;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doNotResolveByDefault", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasDeprecatedWarning", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasDeprecatedForRemovalWarning", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDoNotResolveByDefault", "()Ljdk/internal/module/ModuleResolution;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDeprecated", "()Ljdk/internal/module/ModuleResolution;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDeprecatedForRemoval", "()Ljdk/internal/module/ModuleResolution;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withIncubating", "()Ljdk/internal/module/ModuleResolution;"));
	}

	[JniSignatureAttribute("I", "final")]
	public int value_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ModuleResolution(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I)V", "")]
	public ModuleResolution(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/module/ModuleResolution;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()I", "public")]
	public int value()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/module/ModuleResolution;", "public static")]
	public static Dova.JDK.jdk.@internal.module.ModuleResolution empty()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.module.ModuleResolution>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasIncubatingWarning()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/module/ModuleReference;)Z", "public static")]
	public static bool hasIncubatingWarning(Dova.JDK.java.lang.module.ModuleReference arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/module/ModuleReference;)Z", "public static")]
	public static bool doNotResolveByDefault(Dova.JDK.java.lang.module.ModuleReference arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool doNotResolveByDefault()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasDeprecatedWarning()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasDeprecatedForRemovalWarning()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/internal/module/ModuleResolution;", "public")]
	public Dova.JDK.jdk.@internal.module.ModuleResolution withDoNotResolveByDefault()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.module.ModuleResolution>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/module/ModuleResolution;", "public")]
	public Dova.JDK.jdk.@internal.module.ModuleResolution withDeprecated()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.module.ModuleResolution>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/module/ModuleResolution;", "public")]
	public Dova.JDK.jdk.@internal.module.ModuleResolution withDeprecatedForRemoval()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.module.ModuleResolution>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/module/ModuleResolution;", "public")]
	public Dova.JDK.jdk.@internal.module.ModuleResolution withIncubating()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.module.ModuleResolution>(ret);
	}
}
