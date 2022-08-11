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

[JniSignatureAttribute("Ljava/lang/invoke/VarHandleFloats;", "final")]
public partial class VarHandleFloats
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static VarHandleFloats()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/VarHandleFloats;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public VarHandleFloats(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public VarHandleFloats() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleFloats;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandleFloats$Array;", "static final")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/VarHandleFloats$Array;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "abase", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ashift", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FORM", "Ljava/lang/invoke/VarForm;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(II)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IIZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "get", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "describeConstable", "()Ljava/util/Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "set", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IF)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accessModeTypeUncached", "(Ljava/lang/invoke/VarHandle$AccessType;)Ljava/lang/invoke/MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getVolatile", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setVolatile", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IF)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getOpaque", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setOpaque", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IF)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IF)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFF)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareAndExchange", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFF)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareAndExchangeAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFF)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareAndExchangeRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFF)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "weakCompareAndSetPlain", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFF)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "weakCompareAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFF)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "weakCompareAndSetAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFF)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "weakCompareAndSetRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFF)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IF)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndSetAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IF)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndSetRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IF)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndAdd", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IF)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndAddAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IF)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndAddRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IF)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeExactBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeExactBehavior_1", "()Ljava/lang/invoke/VarHandleFloats$Array;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeBehavior_1", "()Ljava/lang/invoke/VarHandleFloats$Array;"));
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
		public Array(int arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(IIZ)V", "private")]
		public Array(int arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleFloats$Array;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)F", "static")]
		public static float get(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Optional;", "public")]
		public Dova.JDK.java.util.Optional describeConstable()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IF)V", "static")]
		public static void set(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, float arg3)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle$AccessType;)Ljava/lang/invoke/MethodType;", "final")]
		public Dova.JDK.java.lang.invoke.MethodType accessModeTypeUncached(Dova.JDK.java.lang.invoke.VarHandle.AccessType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)F", "static")]
		public static float getVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IF)V", "static")]
		public static void setVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, float arg3)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)F", "static")]
		public static float getOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IF)V", "static")]
		public static void setOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, float arg3)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)F", "static")]
		public static float getAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IF)V", "static")]
		public static void setRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, float arg3)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFF)Z", "static")]
		public static bool compareAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, float arg3, float arg4)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFF)F", "static")]
		public static float compareAndExchange(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, float arg3, float arg4)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFF)F", "static")]
		public static float compareAndExchangeAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, float arg3, float arg4)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFF)F", "static")]
		public static float compareAndExchangeRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, float arg3, float arg4)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFF)Z", "static")]
		public static bool weakCompareAndSetPlain(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, float arg3, float arg4)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFF)Z", "static")]
		public static bool weakCompareAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, float arg3, float arg4)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFF)Z", "static")]
		public static bool weakCompareAndSetAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, float arg3, float arg4)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFF)Z", "static")]
		public static bool weakCompareAndSetRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, float arg3, float arg4)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IF)F", "static")]
		public static float getAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, float arg3)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IF)F", "static")]
		public static float getAndSetAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, float arg3)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IF)F", "static")]
		public static float getAndSetRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, float arg3)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IF)F", "static")]
		public static float getAndAdd(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, float arg3)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IF)F", "static")]
		public static float getAndAddAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, float arg3)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IF)F", "static")]
		public static float getAndAddRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, float arg3)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeExactBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleFloats$Array;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleFloats.Array withInvokeExactBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleFloats.Array>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleFloats$Array;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleFloats.Array withInvokeBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleFloats.Array>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandleFloats$FieldStaticReadWrite;", "static final")]
	public partial class FieldStaticReadWrite
		: Dova.JDK.java.lang.invoke.VarHandleFloats.FieldStaticReadOnly
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FieldStaticReadWrite()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/VarHandleFloats$FieldStaticReadWrite;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FORM", "Ljava/lang/invoke/VarForm;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;J)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;JZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "set", "(Ljava/lang/invoke/VarHandle;F)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setVolatile", "(Ljava/lang/invoke/VarHandle;F)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setOpaque", "(Ljava/lang/invoke/VarHandle;F)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setRelease", "(Ljava/lang/invoke/VarHandle;F)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareAndSet", "(Ljava/lang/invoke/VarHandle;FF)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareAndExchange", "(Ljava/lang/invoke/VarHandle;FF)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareAndExchangeAcquire", "(Ljava/lang/invoke/VarHandle;FF)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareAndExchangeRelease", "(Ljava/lang/invoke/VarHandle;FF)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "weakCompareAndSetPlain", "(Ljava/lang/invoke/VarHandle;FF)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "weakCompareAndSet", "(Ljava/lang/invoke/VarHandle;FF)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "weakCompareAndSetAcquire", "(Ljava/lang/invoke/VarHandle;FF)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "weakCompareAndSetRelease", "(Ljava/lang/invoke/VarHandle;FF)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndSet", "(Ljava/lang/invoke/VarHandle;F)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndSetAcquire", "(Ljava/lang/invoke/VarHandle;F)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndSetRelease", "(Ljava/lang/invoke/VarHandle;F)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndAdd", "(Ljava/lang/invoke/VarHandle;F)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndAddAcquire", "(Ljava/lang/invoke/VarHandle;F)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndAddRelease", "(Ljava/lang/invoke/VarHandle;F)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeExactBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeExactBehavior_1", "()Ljava/lang/invoke/VarHandleFloats$FieldStaticReadOnly;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeExactBehavior_2", "()Ljava/lang/invoke/VarHandleFloats$FieldStaticReadWrite;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeBehavior_0", "()Ljava/lang/invoke/VarHandleFloats$FieldStaticReadWrite;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeBehavior_1", "()Ljava/lang/invoke/VarHandleFloats$FieldStaticReadOnly;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeBehavior_2", "()Ljava/lang/invoke/VarHandle;"));
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
		public FieldStaticReadWrite(Dova.JDK.java.lang.Object arg0, long arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;JZ)V", "private")]
		public FieldStaticReadWrite(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleFloats$FieldStaticReadWrite;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;F)V", "static")]
		public static void set(Dova.JDK.java.lang.invoke.VarHandle arg0, float arg1)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;F)V", "static")]
		public static void setVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0, float arg1)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;F)V", "static")]
		public static void setOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0, float arg1)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;F)V", "static")]
		public static void setRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, float arg1)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;FF)Z", "static")]
		public static bool compareAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, float arg1, float arg2)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;FF)F", "static")]
		public static float compareAndExchange(Dova.JDK.java.lang.invoke.VarHandle arg0, float arg1, float arg2)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;FF)F", "static")]
		public static float compareAndExchangeAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, float arg1, float arg2)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;FF)F", "static")]
		public static float compareAndExchangeRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, float arg1, float arg2)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;FF)Z", "static")]
		public static bool weakCompareAndSetPlain(Dova.JDK.java.lang.invoke.VarHandle arg0, float arg1, float arg2)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;FF)Z", "static")]
		public static bool weakCompareAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, float arg1, float arg2)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;FF)Z", "static")]
		public static bool weakCompareAndSetAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, float arg1, float arg2)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;FF)Z", "static")]
		public static bool weakCompareAndSetRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, float arg1, float arg2)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;F)F", "static")]
		public static float getAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, float arg1)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;F)F", "static")]
		public static float getAndSetAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, float arg1)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;F)F", "static")]
		public static float getAndSetRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, float arg1)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;F)F", "static")]
		public static float getAndAdd(Dova.JDK.java.lang.invoke.VarHandle arg0, float arg1)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;F)F", "static")]
		public static float getAndAddAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, float arg1)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;F)F", "static")]
		public static float getAndAddRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, float arg1)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeExactBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleFloats$FieldStaticReadOnly;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandleFloats.FieldStaticReadOnly withInvokeExactBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleFloats.FieldStaticReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleFloats$FieldStaticReadWrite;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleFloats.FieldStaticReadWrite withInvokeExactBehavior_2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleFloats.FieldStaticReadWrite>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleFloats$FieldStaticReadWrite;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleFloats.FieldStaticReadWrite withInvokeBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleFloats.FieldStaticReadWrite>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleFloats$FieldStaticReadOnly;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandleFloats.FieldStaticReadOnly withInvokeBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleFloats.FieldStaticReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeBehavior_2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandleFloats$FieldStaticReadOnly;", "static")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/VarHandleFloats$FieldStaticReadOnly;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "base", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldOffset", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FORM", "Ljava/lang/invoke/VarForm;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;J)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;JLjava/lang/invoke/VarForm;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "get", "(Ljava/lang/invoke/VarHandle;)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "describeConstable", "()Ljava/util/Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accessModeTypeUncached", "(Ljava/lang/invoke/VarHandle$AccessType;)Ljava/lang/invoke/MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getVolatile", "(Ljava/lang/invoke/VarHandle;)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getOpaque", "(Ljava/lang/invoke/VarHandle;)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAcquire", "(Ljava/lang/invoke/VarHandle;)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeExactBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeExactBehavior_1", "()Ljava/lang/invoke/VarHandleFloats$FieldStaticReadOnly;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeBehavior_0", "()Ljava/lang/invoke/VarHandleFloats$FieldStaticReadOnly;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeBehavior_1", "()Ljava/lang/invoke/VarHandle;"));
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
		public FieldStaticReadOnly(Dova.JDK.java.lang.Object arg0, long arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/invoke/VarForm;Z)V", "protected")]
		public FieldStaticReadOnly(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.invoke.VarForm arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleFloats$FieldStaticReadOnly;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;)F", "static")]
		public static float get(Dova.JDK.java.lang.invoke.VarHandle arg0)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[0], arg0);
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

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;)F", "static")]
		public static float getVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;)F", "static")]
		public static float getOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;)F", "static")]
		public static float getAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeExactBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleFloats$FieldStaticReadOnly;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleFloats.FieldStaticReadOnly withInvokeExactBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleFloats.FieldStaticReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleFloats$FieldStaticReadOnly;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleFloats.FieldStaticReadOnly withInvokeBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleFloats.FieldStaticReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandleFloats$FieldInstanceReadWrite;", "static final")]
	public partial class FieldInstanceReadWrite
		: Dova.JDK.java.lang.invoke.VarHandleFloats.FieldInstanceReadOnly
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FieldInstanceReadWrite()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/VarHandleFloats$FieldInstanceReadWrite;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FORM", "Ljava/lang/invoke/VarForm;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;J)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;JZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "set", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;F)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setVolatile", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;F)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setOpaque", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;F)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;F)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FF)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareAndExchange", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FF)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareAndExchangeAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FF)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareAndExchangeRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FF)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "weakCompareAndSetPlain", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FF)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "weakCompareAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FF)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "weakCompareAndSetAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FF)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "weakCompareAndSetRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FF)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;F)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndSetAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;F)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndSetRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;F)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndAdd", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;F)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndAddAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;F)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndAddRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;F)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeExactBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeExactBehavior_1", "()Ljava/lang/invoke/VarHandleFloats$FieldInstanceReadOnly;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeExactBehavior_2", "()Ljava/lang/invoke/VarHandleFloats$FieldInstanceReadWrite;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeBehavior_0", "()Ljava/lang/invoke/VarHandleFloats$FieldInstanceReadWrite;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeBehavior_1", "()Ljava/lang/invoke/VarHandleFloats$FieldInstanceReadOnly;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeBehavior_2", "()Ljava/lang/invoke/VarHandle;"));
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
		public FieldInstanceReadWrite(Dova.JDK.java.lang.Class arg0, long arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Class;JZ)V", "private")]
		public FieldInstanceReadWrite(Dova.JDK.java.lang.Class arg0, long arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleFloats$FieldInstanceReadWrite;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;F)V", "static")]
		public static void set(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, float arg2)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;F)V", "static")]
		public static void setVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, float arg2)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;F)V", "static")]
		public static void setOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, float arg2)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;F)V", "static")]
		public static void setRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, float arg2)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FF)Z", "static")]
		public static bool compareAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, float arg2, float arg3)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FF)F", "static")]
		public static float compareAndExchange(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, float arg2, float arg3)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FF)F", "static")]
		public static float compareAndExchangeAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, float arg2, float arg3)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FF)F", "static")]
		public static float compareAndExchangeRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, float arg2, float arg3)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FF)Z", "static")]
		public static bool weakCompareAndSetPlain(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, float arg2, float arg3)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FF)Z", "static")]
		public static bool weakCompareAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, float arg2, float arg3)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FF)Z", "static")]
		public static bool weakCompareAndSetAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, float arg2, float arg3)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FF)Z", "static")]
		public static bool weakCompareAndSetRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, float arg2, float arg3)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;F)F", "static")]
		public static float getAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, float arg2)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;F)F", "static")]
		public static float getAndSetAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, float arg2)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;F)F", "static")]
		public static float getAndSetRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, float arg2)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;F)F", "static")]
		public static float getAndAdd(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, float arg2)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;F)F", "static")]
		public static float getAndAddAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, float arg2)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;F)F", "static")]
		public static float getAndAddRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, float arg2)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeExactBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleFloats$FieldInstanceReadOnly;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandleFloats.FieldInstanceReadOnly withInvokeExactBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleFloats.FieldInstanceReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleFloats$FieldInstanceReadWrite;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleFloats.FieldInstanceReadWrite withInvokeExactBehavior_2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleFloats.FieldInstanceReadWrite>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleFloats$FieldInstanceReadWrite;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleFloats.FieldInstanceReadWrite withInvokeBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleFloats.FieldInstanceReadWrite>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleFloats$FieldInstanceReadOnly;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandleFloats.FieldInstanceReadOnly withInvokeBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleFloats.FieldInstanceReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeBehavior_2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandleFloats$FieldInstanceReadOnly;", "static")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/VarHandleFloats$FieldInstanceReadOnly;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldOffset", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "receiverType", "Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FORM", "Ljava/lang/invoke/VarForm;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;J)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;JLjava/lang/invoke/VarForm;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "get", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "describeConstable", "()Ljava/util/Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accessModeTypeUncached", "(Ljava/lang/invoke/VarHandle$AccessType;)Ljava/lang/invoke/MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getVolatile", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getOpaque", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeExactBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeExactBehavior_1", "()Ljava/lang/invoke/VarHandleFloats$FieldInstanceReadOnly;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeBehavior_0", "()Ljava/lang/invoke/VarHandleFloats$FieldInstanceReadOnly;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeBehavior_1", "()Ljava/lang/invoke/VarHandle;"));
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
		public FieldInstanceReadOnly(Dova.JDK.java.lang.Class arg0, long arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Class;JLjava/lang/invoke/VarForm;Z)V", "protected")]
		public FieldInstanceReadOnly(Dova.JDK.java.lang.Class arg0, long arg1, Dova.JDK.java.lang.invoke.VarForm arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleFloats$FieldInstanceReadOnly;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)F", "static")]
		public static float get(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
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

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)F", "static")]
		public static float getVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)F", "static")]
		public static float getOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;)F", "static")]
		public static float getAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeExactBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleFloats$FieldInstanceReadOnly;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleFloats.FieldInstanceReadOnly withInvokeExactBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleFloats.FieldInstanceReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleFloats$FieldInstanceReadOnly;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleFloats.FieldInstanceReadOnly withInvokeBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleFloats.FieldInstanceReadOnly>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
	}
}
