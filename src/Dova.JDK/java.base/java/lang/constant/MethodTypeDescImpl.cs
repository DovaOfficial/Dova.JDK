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

[JniSignatureAttribute("Ljava/lang/constant/MethodTypeDescImpl;", "final")]
public partial class MethodTypeDescImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.lang.constant.MethodTypeDesc
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MethodTypeDescImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/constant/MethodTypeDescImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returnType", "Ljava/lang/constant/ClassDesc;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argTypes", "[Ljava/lang/constant/ClassDesc;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/constant/ClassDesc;[Ljava/lang/constant/ClassDesc;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnType_0", "()Ljava/lang/constant/ClassDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnType_1", "()Ljava/lang/invoke/TypeDescriptor$OfField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveConstantDesc_0", "(Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/invoke/MethodType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveConstantDesc_1", "(Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofDescriptor", "(Ljava/lang/String;)Ljava/lang/constant/MethodTypeDescImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parameterType_0", "(I)Ljava/lang/constant/ClassDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parameterType_1", "(I)Ljava/lang/invoke/TypeDescriptor$OfField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertParameterTypes", "(I[Ljava/lang/constant/ClassDesc;)Ljava/lang/constant/MethodTypeDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertParameterTypes", "(I[Ljava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changeReturnType", "(Ljava/lang/constant/ClassDesc;)Ljava/lang/constant/MethodTypeDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changeReturnType", "(Ljava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dropParameterTypes_0", "(II)Ljava/lang/invoke/TypeDescriptor$OfMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dropParameterTypes_1", "(II)Ljava/lang/constant/MethodTypeDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parameterCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parameterList", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parameterArray_0", "()[Ljava/lang/constant/ClassDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parameterArray_1", "()[Ljava/lang/invoke/TypeDescriptor$OfField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changeParameterType", "(ILjava/lang/constant/ClassDesc;)Ljava/lang/constant/MethodTypeDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changeParameterType", "(ILjava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;"));
	}

	[JniSignatureAttribute("Ljava/lang/constant/ClassDesc;", "private final")]
	public Dova.JDK.java.lang.constant.ClassDesc returnType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ClassDesc>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/constant/ClassDesc;", "private final")]
	public JavaArray<Dova.JDK.java.lang.constant.ClassDesc> argTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.constant.ClassDesc>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MethodTypeDescImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/constant/ClassDesc;[Ljava/lang/constant/ClassDesc;)V", "")]
	public MethodTypeDescImpl(Dova.JDK.java.lang.constant.ClassDesc arg0, JavaArray<Dova.JDK.java.lang.constant.ClassDesc> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/constant/MethodTypeDescImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/constant/ClassDesc;", "public")]
	public Dova.JDK.java.lang.constant.ClassDesc returnType_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ClassDesc>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/TypeDescriptor$OfField;", "public volatile")]
	public Dova.JDK.java.lang.invoke.TypeDescriptor.OfField returnType_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.TypeDescriptor.OfField>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/invoke/MethodType;", "public")]
	public Dova.JDK.java.lang.invoke.MethodType resolveConstantDesc_0(Dova.JDK.java.lang.invoke.MethodHandles.Lookup arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object resolveConstantDesc_1(Dova.JDK.java.lang.invoke.MethodHandles.Lookup arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/constant/MethodTypeDescImpl;", "static")]
	public static Dova.JDK.java.lang.constant.MethodTypeDescImpl ofDescriptor(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.MethodTypeDescImpl>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/constant/ClassDesc;", "public")]
	public Dova.JDK.java.lang.constant.ClassDesc parameterType_0(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ClassDesc>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/invoke/TypeDescriptor$OfField;", "public volatile")]
	public Dova.JDK.java.lang.invoke.TypeDescriptor.OfField parameterType_1(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.TypeDescriptor.OfField>(ret);
	}

	[JniSignatureAttribute("(I[Ljava/lang/constant/ClassDesc;)Ljava/lang/constant/MethodTypeDesc;", "public transient")]
	public Dova.JDK.java.lang.constant.MethodTypeDesc insertParameterTypes(int arg0, JavaArray<Dova.JDK.java.lang.constant.ClassDesc> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.MethodTypeDesc>(ret);
	}

	[JniSignatureAttribute("(I[Ljava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;", "public volatile")]
	public Dova.JDK.java.lang.invoke.TypeDescriptor.OfMethod insertParameterTypes(int arg0, JavaArray<Dova.JDK.java.lang.invoke.TypeDescriptor.OfField> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.TypeDescriptor.OfMethod>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/constant/ClassDesc;)Ljava/lang/constant/MethodTypeDesc;", "public")]
	public Dova.JDK.java.lang.constant.MethodTypeDesc changeReturnType(Dova.JDK.java.lang.constant.ClassDesc arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.MethodTypeDesc>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;", "public volatile")]
	public Dova.JDK.java.lang.invoke.TypeDescriptor.OfMethod changeReturnType(Dova.JDK.java.lang.invoke.TypeDescriptor.OfField arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.TypeDescriptor.OfMethod>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/lang/invoke/TypeDescriptor$OfMethod;", "public volatile")]
	public Dova.JDK.java.lang.invoke.TypeDescriptor.OfMethod dropParameterTypes_0(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.TypeDescriptor.OfMethod>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/lang/constant/MethodTypeDesc;", "public")]
	public Dova.JDK.java.lang.constant.MethodTypeDesc dropParameterTypes_1(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.MethodTypeDesc>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int parameterCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List parameterList()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/constant/ClassDesc;", "public")]
	public JavaArray<Dova.JDK.java.lang.constant.ClassDesc> parameterArray_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.constant.ClassDesc>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/invoke/TypeDescriptor$OfField;", "public volatile")]
	public JavaArray<Dova.JDK.java.lang.invoke.TypeDescriptor.OfField> parameterArray_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.TypeDescriptor.OfField>>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/constant/ClassDesc;)Ljava/lang/constant/MethodTypeDesc;", "public")]
	public Dova.JDK.java.lang.constant.MethodTypeDesc changeParameterType(int arg0, Dova.JDK.java.lang.constant.ClassDesc arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.MethodTypeDesc>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;", "public volatile")]
	public Dova.JDK.java.lang.invoke.TypeDescriptor.OfMethod changeParameterType(int arg0, Dova.JDK.java.lang.invoke.TypeDescriptor.OfField arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.TypeDescriptor.OfMethod>(ret);
	}
}
