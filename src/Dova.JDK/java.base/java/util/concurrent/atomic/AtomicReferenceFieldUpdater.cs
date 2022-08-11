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

namespace Dova.JDK.java.util.concurrent.atomic;

[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater;", "public abstract")]
public partial class AtomicReferenceFieldUpdater
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AtomicReferenceFieldUpdater()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(Ljava/lang/Object;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lazySet", "(Ljava/lang/Object;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndUpdate", "(Ljava/lang/Object;Ljava/util/function/UnaryOperator;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateAndGet", "(Ljava/lang/Object;Ljava/util/function/UnaryOperator;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAccumulate", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accumulateAndGet", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newUpdater", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AtomicReferenceFieldUpdater(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public AtomicReferenceFieldUpdater() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
	public Dova.JDK.java.lang.Object get(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)V", "public abstract")]
	public void set(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", "public abstract")]
	public bool compareAndSet(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", "public abstract")]
	public bool weakCompareAndSet(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getAndSet(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)V", "public abstract")]
	public void lazySet(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/function/UnaryOperator;)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object getAndUpdate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.function.UnaryOperator arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/function/UnaryOperator;)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object updateAndGet(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.function.UnaryOperator arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object getAndAccumulate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.function.BinaryOperator arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object accumulateAndGet(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.function.BinaryOperator arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater;", "public static")]
	public static Dova.JDK.java.util.concurrent.atomic.AtomicReferenceFieldUpdater newUpdater(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicReferenceFieldUpdater>(ret);
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater$AtomicReferenceFieldUpdaterImpl;", "private static final")]
	public partial class AtomicReferenceFieldUpdaterImpl
		: Dova.JDK.java.util.concurrent.atomic.AtomicReferenceFieldUpdater
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AtomicReferenceFieldUpdaterImpl()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater$AtomicReferenceFieldUpdaterImpl;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "U", "Ljdk/internal/misc/Unsafe;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offset", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cclass", "Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tclass", "Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vclass", "Ljava/lang/Class;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isAncestor", "(Ljava/lang/ClassLoader;Ljava/lang/ClassLoader;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(Ljava/lang/Object;Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSamePackage", "(Ljava/lang/Class;Ljava/lang/Class;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lazySet", "(Ljava/lang/Object;Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwAccessCheckException", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "throwCCE", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accessCheck", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "valueCheck", "(Ljava/lang/Object;)V"));
		}

		[JniSignatureAttribute("Ljdk/internal/misc/Unsafe;", "private static final")]
		public static Dova.JDK.jdk.@internal.misc.Unsafe U_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.misc.Unsafe>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("J", "private final")]
		public long offset_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
		public Dova.JDK.java.lang.Class cclass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
		public Dova.JDK.java.lang.Class tclass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
		public Dova.JDK.java.lang.Class vclass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AtomicReferenceFieldUpdaterImpl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)V", "")]
		public AtomicReferenceFieldUpdaterImpl(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.Class arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater$AtomicReferenceFieldUpdaterImpl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public final")]
		public Dova.JDK.java.lang.Object get(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/ClassLoader;)Z", "private static")]
		public static bool isAncestor(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.ClassLoader arg1)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)V", "public final")]
		public void set(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;)Z", "private static")]
		public static bool isSamePackage(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", "public final")]
		public bool compareAndSet(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", "public final")]
		public bool weakCompareAndSet(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "public final")]
		public Dova.JDK.java.lang.Object getAndSet(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)V", "public final")]
		public void lazySet(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "private final")]
		public void throwAccessCheckException(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("()V", "static")]
		public static void throwCCE()
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9]);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "private final")]
		public void accessCheck(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "private final")]
		public void valueCheck(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		}
	}
}
