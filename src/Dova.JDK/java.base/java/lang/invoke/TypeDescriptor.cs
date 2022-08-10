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

namespace Dova.JDK.java.lang.invoke;

[JniSignatureAttribute("Ljava/lang/invoke/TypeDescriptor;", "public abstract interface")]
public partial interface TypeDescriptor
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TypeDescriptor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/TypeDescriptor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "descriptorString", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String descriptorString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("Ljava/lang/invoke/TypeDescriptor$OfMethod;", "public abstract static interface")]
	public partial interface OfMethod
		: IJavaObject
		, Dova.JDK.java.lang.invoke.TypeDescriptor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OfMethod()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/TypeDescriptor$OfMethod;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "returnType", "()Ljava/lang/invoke/TypeDescriptor$OfField;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parameterType", "(I)Ljava/lang/invoke/TypeDescriptor$OfField;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insertParameterTypes", "(I[Ljava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "changeReturnType", "(Ljava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dropParameterTypes", "(II)Ljava/lang/invoke/TypeDescriptor$OfMethod;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parameterCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parameterList", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parameterArray", "()[Ljava/lang/invoke/TypeDescriptor$OfField;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "changeParameterType", "(ILjava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;"));
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/TypeDescriptor$OfField;", "public abstract")]
		Dova.JDK.java.lang.Object returnType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)Ljava/lang/invoke/TypeDescriptor$OfField;", "public abstract")]
		Dova.JDK.java.lang.Object parameterType(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I[Ljava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;", "public abstract transient")]
		Dova.JDK.java.lang.Object insertParameterTypes(int arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;", "public abstract")]
		Dova.JDK.java.lang.Object changeReturnType(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(II)Ljava/lang/invoke/TypeDescriptor$OfMethod;", "public abstract")]
		Dova.JDK.java.lang.Object dropParameterTypes(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()I", "public abstract")]
		int parameterCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
		Dova.JDK.java.util.List parameterList()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()[Ljava/lang/invoke/TypeDescriptor$OfField;", "public abstract")]
		JavaArray<Dova.JDK.java.lang.Object> parameterArray()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}

		[JniSignatureAttribute("(ILjava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;", "public abstract")]
		Dova.JDK.java.lang.Object changeParameterType(int arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/TypeDescriptor$OfField;", "public abstract static interface")]
	public partial interface OfField
		: IJavaObject
		, Dova.JDK.java.lang.invoke.TypeDescriptor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OfField()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/TypeDescriptor$OfField;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isArray", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isPrimitive", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "componentType", "()Ljava/lang/invoke/TypeDescriptor$OfField;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "arrayType", "()Ljava/lang/invoke/TypeDescriptor$OfField;"));
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isArray()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isPrimitive()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/TypeDescriptor$OfField;", "public abstract")]
		Dova.JDK.java.lang.Object componentType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/TypeDescriptor$OfField;", "public abstract")]
		Dova.JDK.java.lang.Object arrayType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
