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

namespace Dova.JDK.java.lang.constant;

[JniSignatureAttribute("Ljava/lang/constant/DirectMethodHandleDescImpl;", "final")]
public partial class DirectMethodHandleDescImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.lang.constant.DirectMethodHandleDesc
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DirectMethodHandleDescImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/constant/DirectMethodHandleDescImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kind", "Ljava/lang/constant/DirectMethodHandleDesc$Kind;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "owner", "Ljava/lang/constant/ClassDesc;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "invocationType", "Ljava/lang/constant/MethodTypeDesc;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/constant/DirectMethodHandleDesc$Kind;Ljava/lang/constant/ClassDesc;Ljava/lang/String;Ljava/lang/constant/MethodTypeDesc;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "methodName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveConstantDesc_0", "(Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveConstantDesc_1", "(Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "kind", "()Ljava/lang/constant/DirectMethodHandleDesc$Kind;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "refKind", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invocationType", "()Ljava/lang/constant/MethodTypeDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "owner", "()Ljava/lang/constant/ClassDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupDescriptor", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "validateConstructor", "(Ljava/lang/constant/MethodTypeDesc;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "validateFieldType", "(Ljava/lang/constant/MethodTypeDesc;ZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isOwnerInterface", "()Z"));
	}

	[JniSignatureAttribute("Ljava/lang/constant/DirectMethodHandleDesc$Kind;", "private final")]
	public Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind kind_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/constant/ClassDesc;", "private final")]
	public Dova.JDK.java.lang.constant.ClassDesc owner_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ClassDesc>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/constant/MethodTypeDesc;", "private final")]
	public Dova.JDK.java.lang.constant.MethodTypeDesc invocationType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.MethodTypeDesc>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DirectMethodHandleDescImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/constant/DirectMethodHandleDesc$Kind;Ljava/lang/constant/ClassDesc;Ljava/lang/String;Ljava/lang/constant/MethodTypeDesc;)V", "")]
	public DirectMethodHandleDescImpl(Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind arg0, Dova.JDK.java.lang.constant.ClassDesc arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.constant.MethodTypeDesc arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/constant/DirectMethodHandleDescImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
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

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String methodName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/invoke/MethodHandle;", "public")]
	public Dova.JDK.java.lang.invoke.MethodHandle resolveConstantDesc_0(Dova.JDK.java.lang.invoke.MethodHandles.Lookup arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object resolveConstantDesc_1(Dova.JDK.java.lang.invoke.MethodHandles.Lookup arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/constant/DirectMethodHandleDesc$Kind;", "public")]
	public Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind kind()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int refKind()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/constant/MethodTypeDesc;", "public")]
	public Dova.JDK.java.lang.constant.MethodTypeDesc invocationType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.MethodTypeDesc>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/constant/ClassDesc;", "public")]
	public Dova.JDK.java.lang.constant.ClassDesc owner()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ClassDesc>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String lookupDescriptor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/constant/MethodTypeDesc;)V", "private static")]
	public static void validateConstructor(Dova.JDK.java.lang.constant.MethodTypeDesc arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/constant/MethodTypeDesc;ZZ)V", "private static")]
	public static void validateFieldType(Dova.JDK.java.lang.constant.MethodTypeDesc arg0, bool arg1, bool arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isOwnerInterface()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}
}
