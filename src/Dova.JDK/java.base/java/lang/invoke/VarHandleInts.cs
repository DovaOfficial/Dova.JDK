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

namespace Dova.JDK.java.lang.invoke;

[JniSignatureAttribute("Ljava/lang/invoke/VarHandleInts;", "final")]
public partial class VarHandleInts
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static VarHandleInts()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/lang/invoke/VarHandleInts;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "VarHandleInts", "()V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public VarHandleInts(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public VarHandleInts() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleInts;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandleInts$Array;", "static final")]
	public partial class Array
		: Dova.JDK.java.lang.invoke.VarHandle
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Array()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/lang/invoke/VarHandleInts$Array;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "abase", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "ashift", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "FORM", "Ljava/lang/invoke/VarForm;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Array", "(II)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Array", "(IIZ)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "get", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "describeConstable", "()Ljava/util/Optional;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "set", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accessModeTypeUncached", "(Ljava/lang/invoke/VarHandle$AccessType;)Ljava/lang/invoke/MethodType;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getVolatile", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setVolatile", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getOpaque", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setOpaque", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;III)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndExchange", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;III)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndExchangeAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;III)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndExchangeRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;III)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSetPlain", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;III)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;III)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSetAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;III)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSetRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;III)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndSetAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndSetRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndAdd", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndAddAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndAddRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseOr", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseOrAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseOrRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseAnd", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseAndAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseAndRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseXor", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseXorAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseXorRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_1", "()Ljava/lang/invoke/VarHandleInts$Array;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_1", "()Ljava/lang/invoke/VarHandleInts$Array;"));
		}

		[JniSignatureAttribute("I", "final")]
		public int abase_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("I", "final")]
		public int ashift_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("Ljava/lang/invoke/VarForm;", "static final")]
		public static Dova.JDK.java.lang.invoke.VarForm FORM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarForm>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Array(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(II)V", "")]
		public Array(int arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(IIZ)V", "private")]
		public Array(int arg0, int arg1, bool arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleInts$Array;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I", "static")]
		public static int get(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Optional;", "public")]
		public Dova.JDK.java.util.Optional describeConstable()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)V", "static")]
		public static void set(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle$AccessType;)Ljava/lang/invoke/MethodType;", "final")]
		public Dova.JDK.java.lang.invoke.MethodType accessModeTypeUncached(Dova.JDK.java.lang.invoke.VarHandle.AccessType arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I", "static")]
		public static int getVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)V", "static")]
		public static void setVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I", "static")]
		public static int getOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)V", "static")]
		public static void setOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I", "static")]
		public static int getAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)V", "static")]
		public static void setRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;III)Z", "static")]
		public static bool compareAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3, int arg4)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;III)I", "static")]
		public static int compareAndExchange(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3, int arg4)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;III)I", "static")]
		public static int compareAndExchangeAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3, int arg4)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;III)I", "static")]
		public static int compareAndExchangeRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3, int arg4)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;III)Z", "static")]
		public static bool weakCompareAndSetPlain(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3, int arg4)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;III)Z", "static")]
		public static bool weakCompareAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3, int arg4)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;III)Z", "static")]
		public static bool weakCompareAndSetAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3, int arg4)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;III)Z", "static")]
		public static bool weakCompareAndSetRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3, int arg4)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I", "static")]
		public static int getAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I", "static")]
		public static int getAndSetAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I", "static")]
		public static int getAndSetRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I", "static")]
		public static int getAndAdd(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I", "static")]
		public static int getAndAddAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I", "static")]
		public static int getAndAddRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I", "static")]
		public static int getAndBitwiseOr(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I", "static")]
		public static int getAndBitwiseOrAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I", "static")]
		public static int getAndBitwiseOrRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I", "static")]
		public static int getAndBitwiseAnd(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I", "static")]
		public static int getAndBitwiseAndAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I", "static")]
		public static int getAndBitwiseAndRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I", "static")]
		public static int getAndBitwiseXor(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I", "static")]
		public static int getAndBitwiseXorAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I", "static")]
		public static int getAndBitwiseXorRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeExactBehavior_0()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleInts$Array;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleInts.Array withInvokeExactBehavior_1()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleInts.Array>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeBehavior_0()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleInts$Array;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleInts.Array withInvokeBehavior_1()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleInts.Array>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandleInts$FieldStaticReadWrite;", "static final")]
	public partial class FieldStaticReadWrite
		: Dova.JDK.java.lang.invoke.VarHandleInts.FieldStaticReadOnly
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FieldStaticReadWrite()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/lang/invoke/VarHandleInts$FieldStaticReadWrite;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "FORM", "Ljava/lang/invoke/VarForm;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "FieldStaticReadWrite", "(Ljava/lang/Object;J)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "FieldStaticReadWrite", "(Ljava/lang/Object;JZ)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "set", "(Ljava/lang/invoke/VarHandle;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setVolatile", "(Ljava/lang/invoke/VarHandle;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setOpaque", "(Ljava/lang/invoke/VarHandle;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setRelease", "(Ljava/lang/invoke/VarHandle;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndSet", "(Ljava/lang/invoke/VarHandle;II)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndExchange", "(Ljava/lang/invoke/VarHandle;II)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndExchangeAcquire", "(Ljava/lang/invoke/VarHandle;II)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndExchangeRelease", "(Ljava/lang/invoke/VarHandle;II)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSetPlain", "(Ljava/lang/invoke/VarHandle;II)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSet", "(Ljava/lang/invoke/VarHandle;II)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSetAcquire", "(Ljava/lang/invoke/VarHandle;II)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSetRelease", "(Ljava/lang/invoke/VarHandle;II)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndSet", "(Ljava/lang/invoke/VarHandle;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndSetAcquire", "(Ljava/lang/invoke/VarHandle;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndSetRelease", "(Ljava/lang/invoke/VarHandle;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndAdd", "(Ljava/lang/invoke/VarHandle;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndAddAcquire", "(Ljava/lang/invoke/VarHandle;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndAddRelease", "(Ljava/lang/invoke/VarHandle;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseOr", "(Ljava/lang/invoke/VarHandle;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseOrAcquire", "(Ljava/lang/invoke/VarHandle;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseOrRelease", "(Ljava/lang/invoke/VarHandle;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseAnd", "(Ljava/lang/invoke/VarHandle;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseAndAcquire", "(Ljava/lang/invoke/VarHandle;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseAndRelease", "(Ljava/lang/invoke/VarHandle;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseXor", "(Ljava/lang/invoke/VarHandle;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseXorAcquire", "(Ljava/lang/invoke/VarHandle;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseXorRelease", "(Ljava/lang/invoke/VarHandle;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_1", "()Ljava/lang/invoke/VarHandleInts$FieldStaticReadOnly;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_2", "()Ljava/lang/invoke/VarHandleInts$FieldStaticReadWrite;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_0", "()Ljava/lang/invoke/VarHandleInts$FieldStaticReadWrite;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_1", "()Ljava/lang/invoke/VarHandleInts$FieldStaticReadOnly;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_2", "()Ljava/lang/invoke/VarHandle;"));
		}

		[JniSignatureAttribute("Ljava/lang/invoke/VarForm;", "static final")]
		public static Dova.JDK.java.lang.invoke.VarForm FORM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarForm>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FieldStaticReadWrite(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;J)V", "")]
		public FieldStaticReadWrite(Dova.JDK.java.lang.Object arg0, long arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;JZ)V", "private")]
		public FieldStaticReadWrite(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleInts$FieldStaticReadWrite;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;I)V", "static")]
		public static void set(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1)
		{
			DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;I)V", "static")]
		public static void setVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1)
		{
			DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;I)V", "static")]
		public static void setOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1)
		{
			DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;I)V", "static")]
		public static void setRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1)
		{
			DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;II)Z", "static")]
		public static bool compareAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;II)I", "static")]
		public static int compareAndExchange(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;II)I", "static")]
		public static int compareAndExchangeAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;II)I", "static")]
		public static int compareAndExchangeRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;II)Z", "static")]
		public static bool weakCompareAndSetPlain(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;II)Z", "static")]
		public static bool weakCompareAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;II)Z", "static")]
		public static bool weakCompareAndSetAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;II)Z", "static")]
		public static bool weakCompareAndSetRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;I)I", "static")]
		public static int getAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;I)I", "static")]
		public static int getAndSetAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;I)I", "static")]
		public static int getAndSetRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;I)I", "static")]
		public static int getAndAdd(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;I)I", "static")]
		public static int getAndAddAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;I)I", "static")]
		public static int getAndAddRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;I)I", "static")]
		public static int getAndBitwiseOr(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;I)I", "static")]
		public static int getAndBitwiseOrAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;I)I", "static")]
		public static int getAndBitwiseOrRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;I)I", "static")]
		public static int getAndBitwiseAnd(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;I)I", "static")]
		public static int getAndBitwiseAndAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;I)I", "static")]
		public static int getAndBitwiseAndRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;I)I", "static")]
		public static int getAndBitwiseXor(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;I)I", "static")]
		public static int getAndBitwiseXorAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;I)I", "static")]
		public static int getAndBitwiseXorRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeExactBehavior_0()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleInts$FieldStaticReadOnly;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandleInts.FieldStaticReadOnly withInvokeExactBehavior_1()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleInts.FieldStaticReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleInts$FieldStaticReadWrite;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleInts.FieldStaticReadWrite withInvokeExactBehavior_2()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleInts.FieldStaticReadWrite>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleInts$FieldStaticReadWrite;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleInts.FieldStaticReadWrite withInvokeBehavior_0()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleInts.FieldStaticReadWrite>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleInts$FieldStaticReadOnly;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandleInts.FieldStaticReadOnly withInvokeBehavior_1()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleInts.FieldStaticReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeBehavior_2()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandleInts$FieldStaticReadOnly;", "static")]
	public partial class FieldStaticReadOnly
		: Dova.JDK.java.lang.invoke.VarHandle
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FieldStaticReadOnly()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/lang/invoke/VarHandleInts$FieldStaticReadOnly;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "base", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fieldOffset", "J"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "FORM", "Ljava/lang/invoke/VarForm;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "FieldStaticReadOnly", "(Ljava/lang/Object;J)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "FieldStaticReadOnly", "(Ljava/lang/Object;JLjava/lang/invoke/VarForm;Z)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "get", "(Ljava/lang/invoke/VarHandle;)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "describeConstable", "()Ljava/util/Optional;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accessModeTypeUncached", "(Ljava/lang/invoke/VarHandle$AccessType;)Ljava/lang/invoke/MethodType;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getVolatile", "(Ljava/lang/invoke/VarHandle;)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getOpaque", "(Ljava/lang/invoke/VarHandle;)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAcquire", "(Ljava/lang/invoke/VarHandle;)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_1", "()Ljava/lang/invoke/VarHandleInts$FieldStaticReadOnly;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_0", "()Ljava/lang/invoke/VarHandleInts$FieldStaticReadOnly;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_1", "()Ljava/lang/invoke/VarHandle;"));
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "final")]
		public Dova.JDK.java.lang.Object @base_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("J", "final")]
		public long fieldOffset_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("Ljava/lang/invoke/VarForm;", "static final")]
		public static Dova.JDK.java.lang.invoke.VarForm FORM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarForm>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FieldStaticReadOnly(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;J)V", "")]
		public FieldStaticReadOnly(Dova.JDK.java.lang.Object arg0, long arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/invoke/VarForm;Z)V", "protected")]
		public FieldStaticReadOnly(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.invoke.VarForm arg2, bool arg3) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleInts$FieldStaticReadOnly;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;)I", "static")]
		public static int get(Dova.JDK.java.lang.invoke.VarHandle arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Optional;", "public")]
		public Dova.JDK.java.util.Optional describeConstable()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle$AccessType;)Ljava/lang/invoke/MethodType;", "final")]
		public Dova.JDK.java.lang.invoke.MethodType accessModeTypeUncached(Dova.JDK.java.lang.invoke.VarHandle.AccessType arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;)I", "static")]
		public static int getVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;)I", "static")]
		public static int getOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;)I", "static")]
		public static int getAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeExactBehavior_0()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleInts$FieldStaticReadOnly;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleInts.FieldStaticReadOnly withInvokeExactBehavior_1()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleInts.FieldStaticReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleInts$FieldStaticReadOnly;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleInts.FieldStaticReadOnly withInvokeBehavior_0()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleInts.FieldStaticReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeBehavior_1()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandleInts$FieldInstanceReadWrite;", "static final")]
	public partial class FieldInstanceReadWrite
		: Dova.JDK.java.lang.invoke.VarHandleInts.FieldInstanceReadOnly
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FieldInstanceReadWrite()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/lang/invoke/VarHandleInts$FieldInstanceReadWrite;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "FORM", "Ljava/lang/invoke/VarForm;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "FieldInstanceReadWrite", "(Ljava/lang/Class;J)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "FieldInstanceReadWrite", "(Ljava/lang/Class;JZ)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "set", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setVolatile", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setOpaque", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndExchange", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndExchangeAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndExchangeRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSetPlain", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSetAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSetRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndSetAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndSetRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndAdd", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndAddAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndAddRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseOr", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseOrAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseOrRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseAnd", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseAndAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseAndRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseXor", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseXorAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseXorRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_1", "()Ljava/lang/invoke/VarHandleInts$FieldInstanceReadOnly;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_2", "()Ljava/lang/invoke/VarHandleInts$FieldInstanceReadWrite;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_0", "()Ljava/lang/invoke/VarHandleInts$FieldInstanceReadWrite;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_1", "()Ljava/lang/invoke/VarHandleInts$FieldInstanceReadOnly;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_2", "()Ljava/lang/invoke/VarHandle;"));
		}

		[JniSignatureAttribute("Ljava/lang/invoke/VarForm;", "static final")]
		public static Dova.JDK.java.lang.invoke.VarForm FORM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarForm>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FieldInstanceReadWrite(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Class;J)V", "")]
		public FieldInstanceReadWrite(Dova.JDK.java.lang.Class arg0, long arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Class;JZ)V", "private")]
		public FieldInstanceReadWrite(Dova.JDK.java.lang.Class arg0, long arg1, bool arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleInts$FieldInstanceReadWrite;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)V", "static")]
		public static void set(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)V", "static")]
		public static void setVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)V", "static")]
		public static void setOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)V", "static")]
		public static void setRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)Z", "static")]
		public static bool compareAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I", "static")]
		public static int compareAndExchange(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I", "static")]
		public static int compareAndExchangeAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)I", "static")]
		public static int compareAndExchangeRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)Z", "static")]
		public static bool weakCompareAndSetPlain(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)Z", "static")]
		public static bool weakCompareAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)Z", "static")]
		public static bool weakCompareAndSetAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;II)Z", "static")]
		public static bool weakCompareAndSetRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I", "static")]
		public static int getAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I", "static")]
		public static int getAndSetAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I", "static")]
		public static int getAndSetRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I", "static")]
		public static int getAndAdd(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I", "static")]
		public static int getAndAddAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I", "static")]
		public static int getAndAddRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I", "static")]
		public static int getAndBitwiseOr(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I", "static")]
		public static int getAndBitwiseOrAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I", "static")]
		public static int getAndBitwiseOrRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I", "static")]
		public static int getAndBitwiseAnd(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I", "static")]
		public static int getAndBitwiseAndAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I", "static")]
		public static int getAndBitwiseAndRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I", "static")]
		public static int getAndBitwiseXor(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I", "static")]
		public static int getAndBitwiseXorAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)I", "static")]
		public static int getAndBitwiseXorRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeExactBehavior_0()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleInts$FieldInstanceReadOnly;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandleInts.FieldInstanceReadOnly withInvokeExactBehavior_1()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleInts.FieldInstanceReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleInts$FieldInstanceReadWrite;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleInts.FieldInstanceReadWrite withInvokeExactBehavior_2()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleInts.FieldInstanceReadWrite>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleInts$FieldInstanceReadWrite;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleInts.FieldInstanceReadWrite withInvokeBehavior_0()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleInts.FieldInstanceReadWrite>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleInts$FieldInstanceReadOnly;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandleInts.FieldInstanceReadOnly withInvokeBehavior_1()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleInts.FieldInstanceReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeBehavior_2()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandleInts$FieldInstanceReadOnly;", "static")]
	public partial class FieldInstanceReadOnly
		: Dova.JDK.java.lang.invoke.VarHandle
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FieldInstanceReadOnly()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/lang/invoke/VarHandleInts$FieldInstanceReadOnly;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fieldOffset", "J"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "receiverType", "Ljava/lang/Class;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "FORM", "Ljava/lang/invoke/VarForm;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "FieldInstanceReadOnly", "(Ljava/lang/Class;J)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "FieldInstanceReadOnly", "(Ljava/lang/Class;JLjava/lang/invoke/VarForm;Z)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "get", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "describeConstable", "()Ljava/util/Optional;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accessModeTypeUncached", "(Ljava/lang/invoke/VarHandle$AccessType;)Ljava/lang/invoke/MethodType;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getVolatile", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getOpaque", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_1", "()Ljava/lang/invoke/VarHandleInts$FieldInstanceReadOnly;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_0", "()Ljava/lang/invoke/VarHandleInts$FieldInstanceReadOnly;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_1", "()Ljava/lang/invoke/VarHandle;"));
		}

		[JniSignatureAttribute("J", "final")]
		public long fieldOffset_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("Ljava/lang/Class;", "final")]
		public Dova.JDK.java.lang.Class receiverType_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/invoke/VarForm;", "static final")]
		public static Dova.JDK.java.lang.invoke.VarForm FORM_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarForm>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FieldInstanceReadOnly(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Class;J)V", "")]
		public FieldInstanceReadOnly(Dova.JDK.java.lang.Class arg0, long arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Class;JLjava/lang/invoke/VarForm;Z)V", "protected")]
		public FieldInstanceReadOnly(Dova.JDK.java.lang.Class arg0, long arg1, Dova.JDK.java.lang.invoke.VarForm arg2, bool arg3) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleInts$FieldInstanceReadOnly;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)I", "static")]
		public static int get(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Optional;", "public")]
		public Dova.JDK.java.util.Optional describeConstable()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle$AccessType;)Ljava/lang/invoke/MethodType;", "final")]
		public Dova.JDK.java.lang.invoke.MethodType accessModeTypeUncached(Dova.JDK.java.lang.invoke.VarHandle.AccessType arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)I", "static")]
		public static int getVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)I", "static")]
		public static int getOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)I", "static")]
		public static int getAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeExactBehavior_0()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleInts$FieldInstanceReadOnly;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleInts.FieldInstanceReadOnly withInvokeExactBehavior_1()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleInts.FieldInstanceReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleInts$FieldInstanceReadOnly;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleInts.FieldInstanceReadOnly withInvokeBehavior_0()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleInts.FieldInstanceReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeBehavior_1()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
	}
}
