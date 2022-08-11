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

namespace Dova.JDK.jdk.@internal.@ref;

[JniSignatureAttribute("Ljdk/internal/ref/Cleaner;", "public")]
public partial class Cleaner
	: Dova.JDK.java.lang.@ref.PhantomReference
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Cleaner()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/ref/Cleaner;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "dummyQueue", "Ljava/lang/ref/ReferenceQueue;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "first", "Ljdk/internal/ref/Cleaner;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "next", "Ljdk/internal/ref/Cleaner;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prev", "Ljdk/internal/ref/Cleaner;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thunk", "Ljava/lang/Runnable;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;Ljava/lang/Runnable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "add", "(Ljdk/internal/ref/Cleaner;)Ljdk/internal/ref/Cleaner;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "remove", "(Ljdk/internal/ref/Cleaner;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clean", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/lang/Object;Ljava/lang/Runnable;)Ljdk/internal/ref/Cleaner;"));
	}

	[JniSignatureAttribute("Ljava/lang/ref/ReferenceQueue;", "private static final")]
	public static Dova.JDK.java.lang.@ref.ReferenceQueue dummyQueue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.ReferenceQueue>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/ref/Cleaner;", "private static")]
	public static Dova.JDK.jdk.@internal.@ref.Cleaner first_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.@ref.Cleaner>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/ref/Cleaner;", "private")]
	public Dova.JDK.jdk.@internal.@ref.Cleaner next_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.@ref.Cleaner>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/ref/Cleaner;", "private")]
	public Dova.JDK.jdk.@internal.@ref.Cleaner prev_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.@ref.Cleaner>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Runnable;", "private final")]
	public Dova.JDK.java.lang.Runnable thunk_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Cleaner(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Runnable;)V", "private")]
	public Cleaner(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Runnable arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/ref/Cleaner;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/ref/Cleaner;)Ljdk/internal/ref/Cleaner;", "private static synchronized")]
	public static Dova.JDK.jdk.@internal.@ref.Cleaner add(Dova.JDK.jdk.@internal.@ref.Cleaner arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.@ref.Cleaner>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/ref/Cleaner;)Z", "private static synchronized")]
	public static bool remove(Dova.JDK.jdk.@internal.@ref.Cleaner arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void clean()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Runnable;)Ljdk/internal/ref/Cleaner;", "public static")]
	public static Dova.JDK.jdk.@internal.@ref.Cleaner create(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Runnable arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.@ref.Cleaner>(ret);
	}
}
