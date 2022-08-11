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

namespace Dova.JDK.java.lang.@ref;

[JniSignatureAttribute("Ljava/lang/ref/Cleaner;", "public final")]
public partial class Cleaner
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Cleaner()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/ref/Cleaner;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "impl", "Ljdk/internal/ref/CleanerImpl;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Ljava/lang/Object;Ljava/lang/Runnable;)Ljava/lang/ref/Cleaner$Cleanable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "()Ljava/lang/ref/Cleaner;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/util/concurrent/ThreadFactory;)Ljava/lang/ref/Cleaner;"));
	}

	[JniSignatureAttribute("Ljdk/internal/ref/CleanerImpl;", "final")]
	public Dova.JDK.jdk.@internal.@ref.CleanerImpl impl_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.@ref.CleanerImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Cleaner(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public Cleaner() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/ref/Cleaner;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Runnable;)Ljava/lang/ref/Cleaner$Cleanable;", "public")]
	public Dova.JDK.java.lang.@ref.Cleaner.Cleanable register(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Runnable arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.Cleaner.Cleanable>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/ref/Cleaner;", "public static")]
	public static Dova.JDK.java.lang.@ref.Cleaner create()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.Cleaner>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ThreadFactory;)Ljava/lang/ref/Cleaner;", "public static")]
	public static Dova.JDK.java.lang.@ref.Cleaner create(Dova.JDK.java.util.concurrent.ThreadFactory arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.Cleaner>(ret);
	}

	[JniSignatureAttribute("Ljava/lang/ref/Cleaner$Cleanable;", "public abstract static interface")]
	public partial interface Cleanable
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Cleanable()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/ref/Cleaner$Cleanable;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clean", "()V"));
		}

		[JniSignatureAttribute("()V", "public abstract")]
		void clean()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}
}
