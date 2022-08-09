/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.java.util.concurrent.atomic;

[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicMarkableReference;", "public")]
public partial class AtomicMarkableReference
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AtomicMarkableReference()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/concurrent/atomic/AtomicMarkableReference;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "pair", "Ljava/util/concurrent/atomic/AtomicMarkableReference$Pair;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PAIR", "Ljava/lang/invoke/VarHandle;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "AtomicMarkableReference", "(Ljava/lang/Object;Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get", "([Z)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getReference", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "set", "(Ljava/lang/Object;Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;ZZ)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;ZZ)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isMarked", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "casPair", "(Ljava/util/concurrent/atomic/AtomicMarkableReference$Pair;Ljava/util/concurrent/atomic/AtomicMarkableReference$Pair;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "attemptMark", "(Ljava/lang/Object;Z)Z"));
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicMarkableReference$Pair;", "private volatile")]
	public Dova.JDK.java.util.concurrent.atomic.AtomicMarkableReference.Pair pair_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicMarkableReference.Pair>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.VarHandle PAIR_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AtomicMarkableReference(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Z)V", "public")]
	public AtomicMarkableReference(Dova.JDK.java.lang.Object arg0, bool arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/concurrent/atomic/AtomicMarkableReference;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Z)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object get(JavaArray<bool> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getReference()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Z)V", "public")]
	public void set(Dova.JDK.java.lang.Object arg0, bool arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;ZZ)Z", "public")]
	public bool compareAndSet(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, bool arg2, bool arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;ZZ)Z", "public")]
	public bool weakCompareAndSet(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, bool arg2, bool arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isMarked()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/atomic/AtomicMarkableReference$Pair;Ljava/util/concurrent/atomic/AtomicMarkableReference$Pair;)Z", "private")]
	public bool casPair(Dova.JDK.java.util.concurrent.atomic.AtomicMarkableReference.Pair arg0, Dova.JDK.java.util.concurrent.atomic.AtomicMarkableReference.Pair arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Z)Z", "public")]
	public bool attemptMark(Dova.JDK.java.lang.Object arg0, bool arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicMarkableReference$Pair;", "private static")]
	public partial class Pair
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Pair()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/concurrent/atomic/AtomicMarkableReference$Pair;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "reference", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "mark", "Z"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Pair", "(Ljava/lang/Object;Z)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(Ljava/lang/Object;Z)Ljava/util/concurrent/atomic/AtomicMarkableReference$Pair;"));
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "final")]
		public Dova.JDK.java.lang.Object reference_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "final")]
		public bool mark_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Pair(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Z)V", "private")]
		public Pair(Dova.JDK.java.lang.Object arg0, bool arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/atomic/AtomicMarkableReference$Pair;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Z)Ljava/util/concurrent/atomic/AtomicMarkableReference$Pair;", "static")]
		public static Dova.JDK.java.util.concurrent.atomic.AtomicMarkableReference.Pair of(Dova.JDK.java.lang.Object arg0, bool arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicMarkableReference.Pair>(ret);
		}
	}
}