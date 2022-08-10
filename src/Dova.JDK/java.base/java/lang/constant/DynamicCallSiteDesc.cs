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

namespace Dova.JDK.java.lang.constant;

[JniSignatureAttribute("Ljava/lang/constant/DynamicCallSiteDesc;", "public")]
public partial class DynamicCallSiteDesc
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DynamicCallSiteDesc()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/constant/DynamicCallSiteDesc;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "bootstrapMethod", "Ljava/lang/constant/DirectMethodHandleDesc;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "bootstrapArgs", "[Ljava/lang/constant/ConstantDesc;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "invocationName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "invocationType", "Ljava/lang/constant/MethodTypeDesc;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DynamicCallSiteDesc", "(Ljava/lang/constant/DirectMethodHandleDesc;Ljava/lang/String;Ljava/lang/constant/MethodTypeDesc;[Ljava/lang/constant/ConstantDesc;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(Ljava/lang/constant/DirectMethodHandleDesc;Ljava/lang/String;Ljava/lang/constant/MethodTypeDesc;[Ljava/lang/constant/ConstantDesc;)Ljava/lang/constant/DynamicCallSiteDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(Ljava/lang/constant/DirectMethodHandleDesc;Ljava/lang/String;Ljava/lang/constant/MethodTypeDesc;)Ljava/lang/constant/DynamicCallSiteDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(Ljava/lang/constant/DirectMethodHandleDesc;Ljava/lang/constant/MethodTypeDesc;)Ljava/lang/constant/DynamicCallSiteDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "invocationType", "()Ljava/lang/constant/MethodTypeDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bootstrapMethod", "()Ljava/lang/constant/MethodHandleDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "invocationName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withArgs", "([Ljava/lang/constant/ConstantDesc;)Ljava/lang/constant/DynamicCallSiteDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withNameAndType", "(Ljava/lang/String;Ljava/lang/constant/MethodTypeDesc;)Ljava/lang/constant/DynamicCallSiteDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "resolveCallSiteDesc", "(Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/invoke/CallSite;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bootstrapArgs", "()[Ljava/lang/constant/ConstantDesc;"));
	}

	[JniSignatureAttribute("Ljava/lang/constant/DirectMethodHandleDesc;", "private final")]
	public Dova.JDK.java.lang.constant.DirectMethodHandleDesc bootstrapMethod_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/lang/constant/ConstantDesc;", "private final")]
	public JavaArray<Dova.JDK.java.lang.constant.ConstantDesc> bootstrapArgs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.constant.ConstantDesc>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String invocationName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/constant/MethodTypeDesc;", "private final")]
	public Dova.JDK.java.lang.constant.MethodTypeDesc invocationType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.MethodTypeDesc>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DynamicCallSiteDesc(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/constant/DirectMethodHandleDesc;Ljava/lang/String;Ljava/lang/constant/MethodTypeDesc;[Ljava/lang/constant/ConstantDesc;)V", "private")]
	public DynamicCallSiteDesc(Dova.JDK.java.lang.constant.DirectMethodHandleDesc arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.constant.MethodTypeDesc arg2, JavaArray<Dova.JDK.java.lang.constant.ConstantDesc> arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/constant/DynamicCallSiteDesc;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public final")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/constant/DirectMethodHandleDesc;Ljava/lang/String;Ljava/lang/constant/MethodTypeDesc;[Ljava/lang/constant/ConstantDesc;)Ljava/lang/constant/DynamicCallSiteDesc;", "public static transient")]
	public static Dova.JDK.java.lang.constant.DynamicCallSiteDesc of(Dova.JDK.java.lang.constant.DirectMethodHandleDesc arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.constant.MethodTypeDesc arg2, JavaArray<Dova.JDK.java.lang.constant.ConstantDesc> arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DynamicCallSiteDesc>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/constant/DirectMethodHandleDesc;Ljava/lang/String;Ljava/lang/constant/MethodTypeDesc;)Ljava/lang/constant/DynamicCallSiteDesc;", "public static")]
	public static Dova.JDK.java.lang.constant.DynamicCallSiteDesc of(Dova.JDK.java.lang.constant.DirectMethodHandleDesc arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.constant.MethodTypeDesc arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DynamicCallSiteDesc>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/constant/DirectMethodHandleDesc;Ljava/lang/constant/MethodTypeDesc;)Ljava/lang/constant/DynamicCallSiteDesc;", "public static")]
	public static Dova.JDK.java.lang.constant.DynamicCallSiteDesc of(Dova.JDK.java.lang.constant.DirectMethodHandleDesc arg0, Dova.JDK.java.lang.constant.MethodTypeDesc arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DynamicCallSiteDesc>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/constant/MethodTypeDesc;", "public")]
	public Dova.JDK.java.lang.constant.MethodTypeDesc invocationType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.MethodTypeDesc>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/constant/MethodHandleDesc;", "public")]
	public Dova.JDK.java.lang.constant.MethodHandleDesc bootstrapMethod()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.MethodHandleDesc>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String invocationName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/constant/ConstantDesc;)Ljava/lang/constant/DynamicCallSiteDesc;", "public transient")]
	public Dova.JDK.java.lang.constant.DynamicCallSiteDesc withArgs(JavaArray<Dova.JDK.java.lang.constant.ConstantDesc> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DynamicCallSiteDesc>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/constant/MethodTypeDesc;)Ljava/lang/constant/DynamicCallSiteDesc;", "public")]
	public Dova.JDK.java.lang.constant.DynamicCallSiteDesc withNameAndType(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.constant.MethodTypeDesc arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DynamicCallSiteDesc>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/invoke/CallSite;", "public")]
	public Dova.JDK.java.lang.invoke.CallSite resolveCallSiteDesc(Dova.JDK.java.lang.invoke.MethodHandles.Lookup arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.CallSite>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/constant/ConstantDesc;", "public")]
	public JavaArray<Dova.JDK.java.lang.constant.ConstantDesc> bootstrapArgs()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.constant.ConstantDesc>>(ret);
	}
}
