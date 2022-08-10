/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
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

[JniSignatureAttribute("Ljava/lang/invoke/VarHandleBytes;", "final")]
public partial class VarHandleBytes
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static VarHandleBytes()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/VarHandleBytes;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "VarHandleBytes", "()V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public VarHandleBytes(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public VarHandleBytes() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleBytes;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandleBytes$Array;", "static final")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/VarHandleBytes$Array;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "abase", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "ashift", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FORM", "Ljava/lang/invoke/VarForm;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Array", "(II)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Array", "(IIZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "get", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "describeConstable", "()Ljava/util/Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "set", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "accessModeTypeUncached", "(Ljava/lang/invoke/VarHandle$AccessType;)Ljava/lang/invoke/MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getVolatile", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setVolatile", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getOpaque", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setOpaque", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IBB)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndExchange", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IBB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndExchangeAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IBB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndExchangeRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IBB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSetPlain", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IBB)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IBB)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSetAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IBB)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSetRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IBB)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndSetAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndSetRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndAdd", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndAddAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndAddRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseOr", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseOrAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseOrRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseAnd", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseAndAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseAndRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseXor", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseXorAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseXorRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_1", "()Ljava/lang/invoke/VarHandleBytes$Array;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_1", "()Ljava/lang/invoke/VarHandleBytes$Array;"));
		}

		[JniSignatureAttribute("I", "final")]
		public int abase_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "final")]
		public int ashift_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/VarForm;", "static final")]
		public static Dova.JDK.java.lang.invoke.VarForm FORM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarForm>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Array(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(II)V", "")]
		public Array(int arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(IIZ)V", "private")]
		public Array(int arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleBytes$Array;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)B", "static")]
		public static byte get(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Optional;", "public")]
		public Dova.JDK.java.util.Optional describeConstable()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)V", "static")]
		public static void set(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle$AccessType;)Ljava/lang/invoke/MethodType;", "final")]
		public Dova.JDK.java.lang.invoke.MethodType accessModeTypeUncached(Dova.JDK.java.lang.invoke.VarHandle.AccessType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)B", "static")]
		public static byte getVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)V", "static")]
		public static void setVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)B", "static")]
		public static byte getOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)V", "static")]
		public static void setOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)B", "static")]
		public static byte getAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)V", "static")]
		public static void setRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IBB)Z", "static")]
		public static bool compareAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3, byte arg4)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IBB)B", "static")]
		public static byte compareAndExchange(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3, byte arg4)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IBB)B", "static")]
		public static byte compareAndExchangeAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3, byte arg4)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IBB)B", "static")]
		public static byte compareAndExchangeRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3, byte arg4)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IBB)Z", "static")]
		public static bool weakCompareAndSetPlain(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3, byte arg4)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IBB)Z", "static")]
		public static bool weakCompareAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3, byte arg4)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IBB)Z", "static")]
		public static bool weakCompareAndSetAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3, byte arg4)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IBB)Z", "static")]
		public static bool weakCompareAndSetRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3, byte arg4)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B", "static")]
		public static byte getAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B", "static")]
		public static byte getAndSetAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B", "static")]
		public static byte getAndSetRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B", "static")]
		public static byte getAndAdd(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B", "static")]
		public static byte getAndAddAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B", "static")]
		public static byte getAndAddRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B", "static")]
		public static byte getAndBitwiseOr(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B", "static")]
		public static byte getAndBitwiseOrAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B", "static")]
		public static byte getAndBitwiseOrRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B", "static")]
		public static byte getAndBitwiseAnd(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B", "static")]
		public static byte getAndBitwiseAndAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B", "static")]
		public static byte getAndBitwiseAndRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B", "static")]
		public static byte getAndBitwiseXor(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B", "static")]
		public static byte getAndBitwiseXorAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IB)B", "static")]
		public static byte getAndBitwiseXorRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeExactBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleBytes$Array;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleBytes.Array withInvokeExactBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleBytes.Array>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleBytes$Array;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleBytes.Array withInvokeBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleBytes.Array>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandleBytes$FieldStaticReadWrite;", "static final")]
	public partial class FieldStaticReadWrite
		: Dova.JDK.java.lang.invoke.VarHandleBytes.FieldStaticReadOnly
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FieldStaticReadWrite()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/VarHandleBytes$FieldStaticReadWrite;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FORM", "Ljava/lang/invoke/VarForm;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "FieldStaticReadWrite", "(Ljava/lang/Object;J)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "FieldStaticReadWrite", "(Ljava/lang/Object;JZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "set", "(Ljava/lang/invoke/VarHandle;B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setVolatile", "(Ljava/lang/invoke/VarHandle;B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setOpaque", "(Ljava/lang/invoke/VarHandle;B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setRelease", "(Ljava/lang/invoke/VarHandle;B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndSet", "(Ljava/lang/invoke/VarHandle;BB)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndExchange", "(Ljava/lang/invoke/VarHandle;BB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndExchangeAcquire", "(Ljava/lang/invoke/VarHandle;BB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndExchangeRelease", "(Ljava/lang/invoke/VarHandle;BB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSetPlain", "(Ljava/lang/invoke/VarHandle;BB)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSet", "(Ljava/lang/invoke/VarHandle;BB)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSetAcquire", "(Ljava/lang/invoke/VarHandle;BB)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSetRelease", "(Ljava/lang/invoke/VarHandle;BB)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndSet", "(Ljava/lang/invoke/VarHandle;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndSetAcquire", "(Ljava/lang/invoke/VarHandle;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndSetRelease", "(Ljava/lang/invoke/VarHandle;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndAdd", "(Ljava/lang/invoke/VarHandle;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndAddAcquire", "(Ljava/lang/invoke/VarHandle;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndAddRelease", "(Ljava/lang/invoke/VarHandle;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseOr", "(Ljava/lang/invoke/VarHandle;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseOrAcquire", "(Ljava/lang/invoke/VarHandle;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseOrRelease", "(Ljava/lang/invoke/VarHandle;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseAnd", "(Ljava/lang/invoke/VarHandle;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseAndAcquire", "(Ljava/lang/invoke/VarHandle;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseAndRelease", "(Ljava/lang/invoke/VarHandle;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseXor", "(Ljava/lang/invoke/VarHandle;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseXorAcquire", "(Ljava/lang/invoke/VarHandle;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseXorRelease", "(Ljava/lang/invoke/VarHandle;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_1", "()Ljava/lang/invoke/VarHandleBytes$FieldStaticReadOnly;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_2", "()Ljava/lang/invoke/VarHandleBytes$FieldStaticReadWrite;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_0", "()Ljava/lang/invoke/VarHandleBytes$FieldStaticReadWrite;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_1", "()Ljava/lang/invoke/VarHandleBytes$FieldStaticReadOnly;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_2", "()Ljava/lang/invoke/VarHandle;"));
		}

		[JniSignatureAttribute("Ljava/lang/invoke/VarForm;", "static final")]
		public static Dova.JDK.java.lang.invoke.VarForm FORM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarForm>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FieldStaticReadWrite(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;J)V", "")]
		public FieldStaticReadWrite(Dova.JDK.java.lang.Object arg0, long arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;JZ)V", "private")]
		public FieldStaticReadWrite(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleBytes$FieldStaticReadWrite;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;B)V", "static")]
		public static void set(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;B)V", "static")]
		public static void setVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;B)V", "static")]
		public static void setOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;B)V", "static")]
		public static void setRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;BB)Z", "static")]
		public static bool compareAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;BB)B", "static")]
		public static byte compareAndExchange(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;BB)B", "static")]
		public static byte compareAndExchangeAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;BB)B", "static")]
		public static byte compareAndExchangeRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;BB)Z", "static")]
		public static bool weakCompareAndSetPlain(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;BB)Z", "static")]
		public static bool weakCompareAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;BB)Z", "static")]
		public static bool weakCompareAndSetAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;BB)Z", "static")]
		public static bool weakCompareAndSetRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;B)B", "static")]
		public static byte getAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;B)B", "static")]
		public static byte getAndSetAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;B)B", "static")]
		public static byte getAndSetRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;B)B", "static")]
		public static byte getAndAdd(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;B)B", "static")]
		public static byte getAndAddAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;B)B", "static")]
		public static byte getAndAddRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;B)B", "static")]
		public static byte getAndBitwiseOr(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;B)B", "static")]
		public static byte getAndBitwiseOrAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;B)B", "static")]
		public static byte getAndBitwiseOrRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;B)B", "static")]
		public static byte getAndBitwiseAnd(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;B)B", "static")]
		public static byte getAndBitwiseAndAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;B)B", "static")]
		public static byte getAndBitwiseAndRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;B)B", "static")]
		public static byte getAndBitwiseXor(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;B)B", "static")]
		public static byte getAndBitwiseXorAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;B)B", "static")]
		public static byte getAndBitwiseXorRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, byte arg1)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeExactBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleBytes$FieldStaticReadOnly;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandleBytes.FieldStaticReadOnly withInvokeExactBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleBytes.FieldStaticReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleBytes$FieldStaticReadWrite;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleBytes.FieldStaticReadWrite withInvokeExactBehavior_2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleBytes.FieldStaticReadWrite>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleBytes$FieldStaticReadWrite;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleBytes.FieldStaticReadWrite withInvokeBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleBytes.FieldStaticReadWrite>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleBytes$FieldStaticReadOnly;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandleBytes.FieldStaticReadOnly withInvokeBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleBytes.FieldStaticReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeBehavior_2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandleBytes$FieldStaticReadOnly;", "static")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/VarHandleBytes$FieldStaticReadOnly;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "base", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fieldOffset", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FORM", "Ljava/lang/invoke/VarForm;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "FieldStaticReadOnly", "(Ljava/lang/Object;J)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "FieldStaticReadOnly", "(Ljava/lang/Object;JLjava/lang/invoke/VarForm;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "get", "(Ljava/lang/invoke/VarHandle;)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "describeConstable", "()Ljava/util/Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "accessModeTypeUncached", "(Ljava/lang/invoke/VarHandle$AccessType;)Ljava/lang/invoke/MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getVolatile", "(Ljava/lang/invoke/VarHandle;)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getOpaque", "(Ljava/lang/invoke/VarHandle;)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAcquire", "(Ljava/lang/invoke/VarHandle;)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_1", "()Ljava/lang/invoke/VarHandleBytes$FieldStaticReadOnly;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_0", "()Ljava/lang/invoke/VarHandleBytes$FieldStaticReadOnly;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_1", "()Ljava/lang/invoke/VarHandle;"));
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "final")]
		public Dova.JDK.java.lang.Object @base_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("J", "final")]
		public long fieldOffset_Property
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

		[JniSignatureAttribute("Ljava/lang/invoke/VarForm;", "static final")]
		public static Dova.JDK.java.lang.invoke.VarForm FORM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarForm>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FieldStaticReadOnly(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;J)V", "")]
		public FieldStaticReadOnly(Dova.JDK.java.lang.Object arg0, long arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/invoke/VarForm;Z)V", "protected")]
		public FieldStaticReadOnly(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.invoke.VarForm arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleBytes$FieldStaticReadOnly;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;)B", "static")]
		public static byte get(Dova.JDK.java.lang.invoke.VarHandle arg0)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Optional;", "public")]
		public Dova.JDK.java.util.Optional describeConstable()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle$AccessType;)Ljava/lang/invoke/MethodType;", "final")]
		public Dova.JDK.java.lang.invoke.MethodType accessModeTypeUncached(Dova.JDK.java.lang.invoke.VarHandle.AccessType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;)B", "static")]
		public static byte getVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;)B", "static")]
		public static byte getOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;)B", "static")]
		public static byte getAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeExactBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleBytes$FieldStaticReadOnly;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleBytes.FieldStaticReadOnly withInvokeExactBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleBytes.FieldStaticReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleBytes$FieldStaticReadOnly;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleBytes.FieldStaticReadOnly withInvokeBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleBytes.FieldStaticReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandleBytes$FieldInstanceReadWrite;", "static final")]
	public partial class FieldInstanceReadWrite
		: Dova.JDK.java.lang.invoke.VarHandleBytes.FieldInstanceReadOnly
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FieldInstanceReadWrite()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/VarHandleBytes$FieldInstanceReadWrite;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FORM", "Ljava/lang/invoke/VarForm;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "FieldInstanceReadWrite", "(Ljava/lang/Class;J)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "FieldInstanceReadWrite", "(Ljava/lang/Class;JZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "set", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setVolatile", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setOpaque", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;BB)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndExchange", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;BB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndExchangeAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;BB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "compareAndExchangeRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;BB)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSetPlain", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;BB)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;BB)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSetAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;BB)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "weakCompareAndSetRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;BB)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndSetAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndSetRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndAdd", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndAddAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndAddRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseOr", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseOrAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseOrRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseAnd", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseAndAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseAndRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseXor", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseXorAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAndBitwiseXorRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_1", "()Ljava/lang/invoke/VarHandleBytes$FieldInstanceReadOnly;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_2", "()Ljava/lang/invoke/VarHandleBytes$FieldInstanceReadWrite;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_0", "()Ljava/lang/invoke/VarHandleBytes$FieldInstanceReadWrite;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_1", "()Ljava/lang/invoke/VarHandleBytes$FieldInstanceReadOnly;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_2", "()Ljava/lang/invoke/VarHandle;"));
		}

		[JniSignatureAttribute("Ljava/lang/invoke/VarForm;", "static final")]
		public static Dova.JDK.java.lang.invoke.VarForm FORM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarForm>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FieldInstanceReadWrite(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Class;J)V", "")]
		public FieldInstanceReadWrite(Dova.JDK.java.lang.Class arg0, long arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Class;JZ)V", "private")]
		public FieldInstanceReadWrite(Dova.JDK.java.lang.Class arg0, long arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleBytes$FieldInstanceReadWrite;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)V", "static")]
		public static void set(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)V", "static")]
		public static void setVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)V", "static")]
		public static void setOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)V", "static")]
		public static void setRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;BB)Z", "static")]
		public static bool compareAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;BB)B", "static")]
		public static byte compareAndExchange(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;BB)B", "static")]
		public static byte compareAndExchangeAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;BB)B", "static")]
		public static byte compareAndExchangeRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;BB)Z", "static")]
		public static bool weakCompareAndSetPlain(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;BB)Z", "static")]
		public static bool weakCompareAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;BB)Z", "static")]
		public static bool weakCompareAndSetAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;BB)Z", "static")]
		public static bool weakCompareAndSetRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2, byte arg3)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B", "static")]
		public static byte getAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B", "static")]
		public static byte getAndSetAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B", "static")]
		public static byte getAndSetRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B", "static")]
		public static byte getAndAdd(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B", "static")]
		public static byte getAndAddAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B", "static")]
		public static byte getAndAddRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B", "static")]
		public static byte getAndBitwiseOr(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B", "static")]
		public static byte getAndBitwiseOrAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B", "static")]
		public static byte getAndBitwiseOrRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B", "static")]
		public static byte getAndBitwiseAnd(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B", "static")]
		public static byte getAndBitwiseAndAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B", "static")]
		public static byte getAndBitwiseAndRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B", "static")]
		public static byte getAndBitwiseXor(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B", "static")]
		public static byte getAndBitwiseXorAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;B)B", "static")]
		public static byte getAndBitwiseXorRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, byte arg2)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeExactBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleBytes$FieldInstanceReadOnly;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandleBytes.FieldInstanceReadOnly withInvokeExactBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleBytes.FieldInstanceReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleBytes$FieldInstanceReadWrite;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleBytes.FieldInstanceReadWrite withInvokeExactBehavior_2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleBytes.FieldInstanceReadWrite>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleBytes$FieldInstanceReadWrite;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleBytes.FieldInstanceReadWrite withInvokeBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleBytes.FieldInstanceReadWrite>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleBytes$FieldInstanceReadOnly;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandleBytes.FieldInstanceReadOnly withInvokeBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleBytes.FieldInstanceReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeBehavior_2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandleBytes$FieldInstanceReadOnly;", "static")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/VarHandleBytes$FieldInstanceReadOnly;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fieldOffset", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "receiverType", "Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FORM", "Ljava/lang/invoke/VarForm;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "FieldInstanceReadOnly", "(Ljava/lang/Class;J)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "FieldInstanceReadOnly", "(Ljava/lang/Class;JLjava/lang/invoke/VarForm;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "get", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "describeConstable", "()Ljava/util/Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "accessModeTypeUncached", "(Ljava/lang/invoke/VarHandle$AccessType;)Ljava/lang/invoke/MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getVolatile", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getOpaque", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeExactBehavior_1", "()Ljava/lang/invoke/VarHandleBytes$FieldInstanceReadOnly;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_0", "()Ljava/lang/invoke/VarHandleBytes$FieldInstanceReadOnly;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withInvokeBehavior_1", "()Ljava/lang/invoke/VarHandle;"));
		}

		[JniSignatureAttribute("J", "final")]
		public long fieldOffset_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Class;", "final")]
		public Dova.JDK.java.lang.Class receiverType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/VarForm;", "static final")]
		public static Dova.JDK.java.lang.invoke.VarForm FORM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarForm>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FieldInstanceReadOnly(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Class;J)V", "")]
		public FieldInstanceReadOnly(Dova.JDK.java.lang.Class arg0, long arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Class;JLjava/lang/invoke/VarForm;Z)V", "protected")]
		public FieldInstanceReadOnly(Dova.JDK.java.lang.Class arg0, long arg1, Dova.JDK.java.lang.invoke.VarForm arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleBytes$FieldInstanceReadOnly;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)B", "static")]
		public static byte get(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Optional;", "public")]
		public Dova.JDK.java.util.Optional describeConstable()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle$AccessType;)Ljava/lang/invoke/MethodType;", "final")]
		public Dova.JDK.java.lang.invoke.MethodType accessModeTypeUncached(Dova.JDK.java.lang.invoke.VarHandle.AccessType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)B", "static")]
		public static byte getVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)B", "static")]
		public static byte getOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)B", "static")]
		public static byte getAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeExactBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleBytes$FieldInstanceReadOnly;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleBytes.FieldInstanceReadOnly withInvokeExactBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleBytes.FieldInstanceReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleBytes$FieldInstanceReadOnly;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleBytes.FieldInstanceReadOnly withInvokeBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleBytes.FieldInstanceReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
	}
}
