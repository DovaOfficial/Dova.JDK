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

namespace Dova.JDK.java.lang.invoke;

[JniSignatureAttribute("Ljava/lang/invoke/VarHandles;", "final")]
public partial class VarHandles
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static VarHandles()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/VarHandles;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ADDRESS_FACTORIES", "Ljava/lang/ClassValue;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "exceptionTypes", "(Ljava/lang/invoke/MethodHandle;)[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeArrayElementHandle", "(Ljava/lang/Class;)Ljava/lang/invoke/VarHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "byteArrayViewHandle", "(Ljava/lang/Class;Z)Ljava/lang/invoke/VarHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeByteBufferViewHandle", "(Ljava/lang/Class;Z)Ljava/lang/invoke/VarHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeFieldHandle", "(Ljava/lang/invoke/MemberName;Ljava/lang/Class;Ljava/lang/Class;Z)Ljava/lang/invoke/VarHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "handleCheckedExceptions", "(Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeMemoryAddressViewHandle", "(Ljava/lang/Class;ZJLjava/nio/ByteOrder;)Ljava/lang/invoke/VarHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "filterValue", "(Ljava/lang/invoke/VarHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/VarHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "filterCoordinates", "(Ljava/lang/invoke/VarHandle;I[Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/VarHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "dropCoordinates", "(Ljava/lang/invoke/VarHandle;I[Ljava/lang/Class;)Ljava/lang/invoke/VarHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "permuteCoordinates", "(Ljava/lang/invoke/VarHandle;Ljava/util/List;[I)Ljava/lang/invoke/VarHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "collectCoordinates", "(Ljava/lang/invoke/VarHandle;ILjava/lang/invoke/MethodHandle;)Ljava/lang/invoke/VarHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "insertCoordinates", "(Ljava/lang/invoke/VarHandle;I[Ljava/lang/Object;)Ljava/lang/invoke/VarHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFieldFromReceiverAndOffset", "(Ljava/lang/Class;JLjava/lang/Class;)Ljava/lang/reflect/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getStaticFieldFromBaseAndOffset", "(Ljava/lang/Object;JLjava/lang/Class;)Ljava/lang/reflect/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "maybeAdapt", "(Ljava/lang/invoke/VarHandle;)Ljava/lang/invoke/VarHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "adaptForCheckedExceptions", "(Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "numTrailingArgs", "(Ljava/lang/invoke/VarHandle$AccessType;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isCheckedException", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "methodTypeFor", "(Ljava/lang/invoke/VarHandle$AccessType;Ljava/lang/invoke/MethodType;Ljava/util/List;Ljava/util/List;)Ljava/lang/invoke/MethodType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "reorderArrayFor", "(Ljava/lang/invoke/VarHandle$AccessType;Ljava/util/List;[I)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "joinDuplicateArgs", "(Ljava/lang/invoke/MethodHandle;III)Ljava/lang/invoke/MethodHandle;"));
	}

	[JniSignatureAttribute("Ljava/lang/ClassValue;", "static")]
	public static Dova.JDK.java.lang.ClassValue ADDRESS_FACTORIES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassValue>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public VarHandles(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public VarHandles() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandles;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;)[Ljava/lang/Class;", "static")]
	public static JavaArray<Dova.JDK.java.lang.Class> exceptionTypes(Dova.JDK.java.lang.invoke.MethodHandle arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/VarHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.VarHandle makeArrayElementHandle(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Z)Ljava/lang/invoke/VarHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.VarHandle byteArrayViewHandle(Dova.JDK.java.lang.Class arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Z)Ljava/lang/invoke/VarHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.VarHandle makeByteBufferViewHandle(Dova.JDK.java.lang.Class arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MemberName;Ljava/lang/Class;Ljava/lang/Class;Z)Ljava/lang/invoke/VarHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.VarHandle makeFieldHandle(Dova.JDK.java.lang.invoke.MemberName arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.Class arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "static")]
	public static void handleCheckedExceptions(Dova.JDK.java.lang.Throwable arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;ZJLjava/nio/ByteOrder;)Ljava/lang/invoke/VarHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.VarHandle makeMemoryAddressViewHandle(Dova.JDK.java.lang.Class arg0, bool arg1, long arg2, Dova.JDK.java.nio.ByteOrder arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/VarHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.VarHandle filterValue(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;I[Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/VarHandle;", "public static transient")]
	public static Dova.JDK.java.lang.invoke.VarHandle filterCoordinates(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1, JavaArray<Dova.JDK.java.lang.invoke.MethodHandle> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;I[Ljava/lang/Class;)Ljava/lang/invoke/VarHandle;", "public static transient")]
	public static Dova.JDK.java.lang.invoke.VarHandle dropCoordinates(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1, JavaArray<Dova.JDK.java.lang.Class> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/util/List;[I)Ljava/lang/invoke/VarHandle;", "public static transient")]
	public static Dova.JDK.java.lang.invoke.VarHandle permuteCoordinates(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.util.List arg1, JavaArray<int> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;ILjava/lang/invoke/MethodHandle;)Ljava/lang/invoke/VarHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.VarHandle collectCoordinates(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;I[Ljava/lang/Object;)Ljava/lang/invoke/VarHandle;", "public static transient")]
	public static Dova.JDK.java.lang.invoke.VarHandle insertCoordinates(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;JLjava/lang/Class;)Ljava/lang/reflect/Field;", "static")]
	public static Dova.JDK.java.lang.reflect.Field getFieldFromReceiverAndOffset(Dova.JDK.java.lang.Class arg0, long arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Field>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Class;)Ljava/lang/reflect/Field;", "static")]
	public static Dova.JDK.java.lang.reflect.Field getStaticFieldFromBaseAndOffset(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Field>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;)Ljava/lang/invoke/VarHandle;", "private static")]
	public static Dova.JDK.java.lang.invoke.VarHandle maybeAdapt(Dova.JDK.java.lang.invoke.VarHandle arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle adaptForCheckedExceptions(Dova.JDK.java.lang.invoke.MethodHandle arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle$AccessType;)I", "private static")]
	public static int numTrailingArgs(Dova.JDK.java.lang.invoke.VarHandle.AccessType arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "private static")]
	public static bool isCheckedException(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle$AccessType;Ljava/lang/invoke/MethodType;Ljava/util/List;Ljava/util/List;)Ljava/lang/invoke/MethodType;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodType methodTypeFor(Dova.JDK.java.lang.invoke.VarHandle.AccessType arg0, Dova.JDK.java.lang.invoke.MethodType arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle$AccessType;Ljava/util/List;[I)[I", "private static")]
	public static JavaArray<int> reorderArrayFor(Dova.JDK.java.lang.invoke.VarHandle.AccessType arg0, Dova.JDK.java.util.List arg1, JavaArray<int> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;III)Ljava/lang/invoke/MethodHandle;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle joinDuplicateArgs(Dova.JDK.java.lang.invoke.MethodHandle arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}
}
