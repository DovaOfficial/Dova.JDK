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

[JniSignatureAttribute("Ljava/lang/invoke/VarHandleByteArrayAsLongs;", "final")]
public partial class VarHandleByteArrayAsLongs
	: Dova.JDK.java.lang.invoke.VarHandleByteArrayBase
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static VarHandleByteArrayAsLongs()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/VarHandleByteArrayAsLongs;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NIO_ACCESS", "Ljdk/internal/access/JavaNioAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALIGN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SCOPED_MEMORY_ACCESS", "Ljdk/internal/misc/ScopedMemoryAccess;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convEndian", "(ZJ)J"));
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaNioAccess;", "static final")]
	public static Dova.JDK.jdk.@internal.access.JavaNioAccess NIO_ACCESS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaNioAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int ALIGN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/misc/ScopedMemoryAccess;", "static final")]
	public static Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess SCOPED_MEMORY_ACCESS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public VarHandleByteArrayAsLongs(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public VarHandleByteArrayAsLongs() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleByteArrayAsLongs;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(ZJ)J", "static")]
	public static long convEndian(bool arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandleByteArrayAsLongs$ByteBufferHandle;", "static final")]
	public partial class ByteBufferHandle
		: Dova.JDK.java.lang.invoke.VarHandleByteArrayAsLongs.ByteArrayViewVarHandle
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ByteBufferHandle()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/VarHandleByteArrayAsLongs$ByteBufferHandle;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FORM", "Ljava/lang/invoke/VarForm;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Z)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "index", "(Ljava/nio/ByteBuffer;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "get", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "set", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accessModeTypeUncached", "(Ljava/lang/invoke/VarHandle$AccessType;)Ljava/lang/invoke/MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getVolatile", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setVolatile", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getOpaque", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setOpaque", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareAndExchange", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareAndExchangeAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareAndExchangeRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "weakCompareAndSetPlain", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "weakCompareAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "weakCompareAndSetAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "weakCompareAndSetRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndSetAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndSetRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndAdd", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndAddAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndAddRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseOr", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseOrAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseOrRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseAnd", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseAndAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseAndRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseXor", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseXorAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseXorRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeExactBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeExactBehavior_1", "()Ljava/lang/invoke/VarHandleByteArrayAsLongs$ByteBufferHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeBehavior_1", "()Ljava/lang/invoke/VarHandleByteArrayAsLongs$ByteBufferHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "address", "(Ljava/nio/ByteBuffer;I)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "scope", "(Ljava/nio/ByteBuffer;)Ljdk/internal/misc/ScopedMemoryAccess$Scope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndAddConvEndianWithCAS", "(Ljava/nio/ByteBuffer;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseOrConvEndianWithCAS", "(Ljava/nio/ByteBuffer;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseAndConvEndianWithCAS", "(Ljava/nio/ByteBuffer;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseXorConvEndianWithCAS", "(Ljava/nio/ByteBuffer;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "indexRO", "(Ljava/nio/ByteBuffer;I)I"));
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
		public ByteBufferHandle(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Z)V", "")]
		public ByteBufferHandle(bool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(ZZ)V", "private")]
		public ByteBufferHandle(bool arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleByteArrayAsLongs$ByteBufferHandle;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;I)I", "static")]
		public static int index(Dova.JDK.java.nio.ByteBuffer arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)J", "static")]
		public static long get(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)V", "static")]
		public static void set(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle$AccessType;)Ljava/lang/invoke/MethodType;", "final")]
		public Dova.JDK.java.lang.invoke.MethodType accessModeTypeUncached(Dova.JDK.java.lang.invoke.VarHandle.AccessType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)J", "static")]
		public static long getVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)V", "static")]
		public static void setVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)J", "static")]
		public static long getOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)V", "static")]
		public static void setOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)J", "static")]
		public static long getAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)V", "static")]
		public static void setRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)Z", "static")]
		public static bool compareAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3, long arg4)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)J", "static")]
		public static long compareAndExchange(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3, long arg4)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)J", "static")]
		public static long compareAndExchangeAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3, long arg4)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)J", "static")]
		public static long compareAndExchangeRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3, long arg4)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)Z", "static")]
		public static bool weakCompareAndSetPlain(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3, long arg4)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)Z", "static")]
		public static bool weakCompareAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3, long arg4)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)Z", "static")]
		public static bool weakCompareAndSetAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3, long arg4)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)Z", "static")]
		public static bool weakCompareAndSetRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3, long arg4)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndSetAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndSetRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndAdd(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndAddAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndAddRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndBitwiseOr(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndBitwiseOrAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndBitwiseOrRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndBitwiseAnd(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndBitwiseAndAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndBitwiseAndRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndBitwiseXor(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndBitwiseXorAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndBitwiseXorRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeExactBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleByteArrayAsLongs$ByteBufferHandle;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleByteArrayAsLongs.ByteBufferHandle withInvokeExactBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleByteArrayAsLongs.ByteBufferHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleByteArrayAsLongs$ByteBufferHandle;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleByteArrayAsLongs.ByteBufferHandle withInvokeBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleByteArrayAsLongs.ByteBufferHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;I)J", "static")]
		public static long address(Dova.JDK.java.nio.ByteBuffer arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Ljdk/internal/misc/ScopedMemoryAccess$Scope;", "static")]
		public static Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope scope(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;IJ)J", "static")]
		public static long getAndAddConvEndianWithCAS(Dova.JDK.java.nio.ByteBuffer arg0, int arg1, long arg2)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;IJ)J", "static")]
		public static long getAndBitwiseOrConvEndianWithCAS(Dova.JDK.java.nio.ByteBuffer arg0, int arg1, long arg2)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;IJ)J", "static")]
		public static long getAndBitwiseAndConvEndianWithCAS(Dova.JDK.java.nio.ByteBuffer arg0, int arg1, long arg2)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[41], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;IJ)J", "static")]
		public static long getAndBitwiseXorConvEndianWithCAS(Dova.JDK.java.nio.ByteBuffer arg0, int arg1, long arg2)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;I)I", "static")]
		public static int indexRO(Dova.JDK.java.nio.ByteBuffer arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[43], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandleByteArrayAsLongs$ArrayHandle;", "static final")]
	public partial class ArrayHandle
		: Dova.JDK.java.lang.invoke.VarHandleByteArrayAsLongs.ByteArrayViewVarHandle
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ArrayHandle()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/VarHandleByteArrayAsLongs$ArrayHandle;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FORM", "Ljava/lang/invoke/VarForm;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Z)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "index", "([BI)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "get", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "set", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accessModeTypeUncached", "(Ljava/lang/invoke/VarHandle$AccessType;)Ljava/lang/invoke/MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getVolatile", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setVolatile", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getOpaque", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setOpaque", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareAndExchange", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareAndExchangeAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareAndExchangeRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "weakCompareAndSetPlain", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "weakCompareAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "weakCompareAndSetAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "weakCompareAndSetRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndSet", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndSetAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndSetRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndAdd", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndAddAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndAddRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseOr", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseOrAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseOrRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseAnd", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseAndAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseAndRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseXor", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseXorAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseXorRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeExactBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeExactBehavior_1", "()Ljava/lang/invoke/VarHandleByteArrayAsLongs$ArrayHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeBehavior_1", "()Ljava/lang/invoke/VarHandleByteArrayAsLongs$ArrayHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "address", "([BI)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndAddConvEndianWithCAS", "([BIJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseOrConvEndianWithCAS", "([BIJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseAndConvEndianWithCAS", "([BIJ)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAndBitwiseXorConvEndianWithCAS", "([BIJ)J"));
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
		public ArrayHandle(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Z)V", "")]
		public ArrayHandle(bool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(ZZ)V", "private")]
		public ArrayHandle(bool arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleByteArrayAsLongs$ArrayHandle;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([BI)I", "static")]
		public static int index(JavaArray<byte> arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)J", "static")]
		public static long get(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)V", "static")]
		public static void set(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle$AccessType;)Ljava/lang/invoke/MethodType;", "final")]
		public Dova.JDK.java.lang.invoke.MethodType accessModeTypeUncached(Dova.JDK.java.lang.invoke.VarHandle.AccessType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)J", "static")]
		public static long getVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)V", "static")]
		public static void setVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)J", "static")]
		public static long getOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)V", "static")]
		public static void setOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;I)J", "static")]
		public static long getAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)V", "static")]
		public static void setRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)Z", "static")]
		public static bool compareAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3, long arg4)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)J", "static")]
		public static long compareAndExchange(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3, long arg4)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)J", "static")]
		public static long compareAndExchangeAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3, long arg4)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)J", "static")]
		public static long compareAndExchangeRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3, long arg4)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)Z", "static")]
		public static bool weakCompareAndSetPlain(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3, long arg4)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)Z", "static")]
		public static bool weakCompareAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3, long arg4)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)Z", "static")]
		public static bool weakCompareAndSetAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3, long arg4)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJ)Z", "static")]
		public static bool weakCompareAndSetRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3, long arg4)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndSet(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndSetAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndSetRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndAdd(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndAddAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndAddRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndBitwiseOr(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndBitwiseOrAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndBitwiseOrRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndBitwiseAnd(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndBitwiseAndAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndBitwiseAndRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndBitwiseXor(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndBitwiseXorAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJ)J", "static")]
		public static long getAndBitwiseXorRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeExactBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleByteArrayAsLongs$ArrayHandle;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleByteArrayAsLongs.ArrayHandle withInvokeExactBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleByteArrayAsLongs.ArrayHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
		public Dova.JDK.java.lang.invoke.VarHandle withInvokeBehavior_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/VarHandleByteArrayAsLongs$ArrayHandle;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandleByteArrayAsLongs.ArrayHandle withInvokeBehavior_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandleByteArrayAsLongs.ArrayHandle>(ret);
		}

		[JniSignatureAttribute("([BI)J", "static")]
		public static long address(JavaArray<byte> arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("([BIJ)J", "static")]
		public static long getAndAddConvEndianWithCAS(JavaArray<byte> arg0, int arg1, long arg2)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[38], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("([BIJ)J", "static")]
		public static long getAndBitwiseOrConvEndianWithCAS(JavaArray<byte> arg0, int arg1, long arg2)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("([BIJ)J", "static")]
		public static long getAndBitwiseAndConvEndianWithCAS(JavaArray<byte> arg0, int arg1, long arg2)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("([BIJ)J", "static")]
		public static long getAndBitwiseXorConvEndianWithCAS(JavaArray<byte> arg0, int arg1, long arg2)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[41], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandleByteArrayAsLongs$ByteArrayViewVarHandle;", "private abstract static")]
	public partial class ByteArrayViewVarHandle
		: Dova.JDK.java.lang.invoke.VarHandle
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ByteArrayViewVarHandle()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/VarHandleByteArrayAsLongs$ByteArrayViewVarHandle;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "be", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/invoke/VarForm;ZZ)V"));
		}

		[JniSignatureAttribute("Z", "final")]
		public bool be_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ByteArrayViewVarHandle(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/VarForm;ZZ)V", "")]
		public ByteArrayViewVarHandle(Dova.JDK.java.lang.invoke.VarForm arg0, bool arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleByteArrayAsLongs$ByteArrayViewVarHandle;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
