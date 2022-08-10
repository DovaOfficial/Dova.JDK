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

namespace Dova.JDK.java.sql;

[JniSignatureAttribute("Ljava/sql/BatchUpdateException;", "public")]
public partial class BatchUpdateException
	: Dova.JDK.java.sql.SQLException
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BatchUpdateException()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/sql/BatchUpdateException;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "updateCounts", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "longUpdateCounts", "[J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BatchUpdateException", "(Ljava/lang/Throwable;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BatchUpdateException", "([ILjava/lang/Throwable;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BatchUpdateException", "(Ljava/lang/String;[ILjava/lang/Throwable;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BatchUpdateException", "(Ljava/lang/String;Ljava/lang/String;[ILjava/lang/Throwable;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BatchUpdateException", "(Ljava/lang/String;Ljava/lang/String;I[ILjava/lang/Throwable;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BatchUpdateException", "(Ljava/lang/String;Ljava/lang/String;I[JLjava/lang/Throwable;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BatchUpdateException", "(Ljava/lang/String;Ljava/lang/String;I[I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BatchUpdateException", "(Ljava/lang/String;Ljava/lang/String;[I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BatchUpdateException", "(Ljava/lang/String;[I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BatchUpdateException", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BatchUpdateException", "([I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getUpdateCounts", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLargeUpdateCounts", "()[J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "copyUpdateCount", "([J)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "copyUpdateCount", "([I)[J"));
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> updateCounts_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[J", "private")]
	public JavaArray<long> longUpdateCounts_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BatchUpdateException(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public")]
	public BatchUpdateException(Dova.JDK.java.lang.Throwable arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("([ILjava/lang/Throwable;)V", "public")]
	public BatchUpdateException(JavaArray<int> arg0, Dova.JDK.java.lang.Throwable arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;[ILjava/lang/Throwable;)V", "public")]
	public BatchUpdateException(Dova.JDK.java.lang.String arg0, JavaArray<int> arg1, Dova.JDK.java.lang.Throwable arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;[ILjava/lang/Throwable;)V", "public")]
	public BatchUpdateException(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, JavaArray<int> arg2, Dova.JDK.java.lang.Throwable arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;I[ILjava/lang/Throwable;)V", "public")]
	public BatchUpdateException(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, int arg2, JavaArray<int> arg3, Dova.JDK.java.lang.Throwable arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[4], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;I[JLjava/lang/Throwable;)V", "public")]
	public BatchUpdateException(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, int arg2, JavaArray<long> arg3, Dova.JDK.java.lang.Throwable arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[5], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;I[I)V", "public")]
	public BatchUpdateException(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, int arg2, JavaArray<int> arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[6], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;[I)V", "public")]
	public BatchUpdateException(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, JavaArray<int> arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[7], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;[I)V", "public")]
	public BatchUpdateException(Dova.JDK.java.lang.String arg0, JavaArray<int> arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[8], arg0, arg1))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public BatchUpdateException() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[9]))
	{
	}

	[JniSignatureAttribute("([I)V", "public")]
	public BatchUpdateException(JavaArray<int> arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[10], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/sql/BatchUpdateException;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private")]
	public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()[I", "public")]
	public JavaArray<int> getUpdateCounts()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("()[J", "public")]
	public JavaArray<long> getLargeUpdateCounts()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("([J)[I", "private static")]
	public static JavaArray<int> copyUpdateCount(JavaArray<long> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("([I)[J", "private static")]
	public static JavaArray<long> copyUpdateCount(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}
}
