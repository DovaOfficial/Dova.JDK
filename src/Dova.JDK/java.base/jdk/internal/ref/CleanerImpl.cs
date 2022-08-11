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

[JniSignatureAttribute("Ljdk/internal/ref/CleanerImpl;", "public final")]
public partial class CleanerImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.lang.Runnable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CleanerImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/ref/CleanerImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "cleanerImplAccess", "Ljava/util/function/Function;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "phantomCleanableList", "Ljdk/internal/ref/PhantomCleanable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "queue", "Ljava/lang/ref/ReferenceQueue;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "start", "(Ljava/lang/ref/Cleaner;Ljava/util/concurrent/ThreadFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCleanerImpl", "(Ljava/lang/ref/Cleaner;)Ljdk/internal/ref/CleanerImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setCleanerImplAccess", "(Ljava/util/function/Function;)V"));
	}

	[JniSignatureAttribute("Ljava/util/function/Function;", "private static")]
	public static Dova.JDK.java.util.function.Function cleanerImplAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/ref/PhantomCleanable;", "final")]
	public Dova.JDK.jdk.@internal.@ref.PhantomCleanable phantomCleanableList_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.@ref.PhantomCleanable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ref/ReferenceQueue;", "final")]
	public Dova.JDK.java.lang.@ref.ReferenceQueue queue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.ReferenceQueue>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CleanerImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public CleanerImpl() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/ref/CleanerImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void run()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljava/lang/ref/Cleaner;Ljava/util/concurrent/ThreadFactory;)V", "public")]
	public void start(Dova.JDK.java.lang.@ref.Cleaner arg0, Dova.JDK.java.util.concurrent.ThreadFactory arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/ref/Cleaner;)Ljdk/internal/ref/CleanerImpl;", "static")]
	public static Dova.JDK.jdk.@internal.@ref.CleanerImpl getCleanerImpl(Dova.JDK.java.lang.@ref.Cleaner arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.@ref.CleanerImpl>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)V", "public static")]
	public static void setCleanerImplAccess(Dova.JDK.java.util.function.Function arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("Ljdk/internal/ref/CleanerImpl$PhantomCleanableRef;", "public static final")]
	public partial class PhantomCleanableRef
		: Dova.JDK.jdk.@internal.@ref.PhantomCleanable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PhantomCleanableRef()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/ref/CleanerImpl$PhantomCleanableRef;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "action", "Ljava/lang/Runnable;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;Ljava/lang/ref/Cleaner;Ljava/lang/Runnable;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "performCleanup", "()V"));
		}

		[JniSignatureAttribute("Ljava/lang/Runnable;", "private final")]
		public Dova.JDK.java.lang.Runnable action_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PhantomCleanableRef(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/ref/Cleaner;Ljava/lang/Runnable;)V", "public")]
		public PhantomCleanableRef(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.@ref.Cleaner arg1, Dova.JDK.java.lang.Runnable arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("()V", "")]
		public PhantomCleanableRef() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/ref/CleanerImpl$PhantomCleanableRef;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object get()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void clear()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("()V", "protected")]
		public void performCleanup()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/ref/CleanerImpl$CleanerCleanable;", "static final")]
	public partial class CleanerCleanable
		: Dova.JDK.jdk.@internal.@ref.PhantomCleanable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CleanerCleanable()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/ref/CleanerImpl$CleanerCleanable;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ref/Cleaner;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "performCleanup", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CleanerCleanable(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/ref/Cleaner;)V", "")]
		public CleanerCleanable(Dova.JDK.java.lang.@ref.Cleaner arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/ref/CleanerImpl$CleanerCleanable;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "protected")]
		public void performCleanup()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/ref/CleanerImpl$InnocuousThreadFactory;", "static final")]
	public partial class InnocuousThreadFactory
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.concurrent.ThreadFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InnocuousThreadFactory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/ref/CleanerImpl$InnocuousThreadFactory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "factory", "Ljava/util/concurrent/ThreadFactory;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cleanerThreadNumber", "Ljava/util/concurrent/atomic/AtomicInteger;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "factory", "()Ljava/util/concurrent/ThreadFactory;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/ThreadFactory;", "static final")]
		public static Dova.JDK.java.util.concurrent.ThreadFactory factory_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ThreadFactory>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicInteger;", "final")]
		public Dova.JDK.java.util.concurrent.atomic.AtomicInteger cleanerThreadNumber_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicInteger>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InnocuousThreadFactory(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public InnocuousThreadFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/ref/CleanerImpl$InnocuousThreadFactory;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/concurrent/ThreadFactory;", "static")]
		public static Dova.JDK.java.util.concurrent.ThreadFactory factory()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ThreadFactory>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Runnable;)Ljava/lang/Thread;", "public")]
		public Dova.JDK.java.lang.Thread newThread(Dova.JDK.java.lang.Runnable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
		}
	}
}
