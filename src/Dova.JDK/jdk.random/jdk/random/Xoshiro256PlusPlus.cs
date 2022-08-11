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

namespace Dova.JDK.jdk.random;

[JniSignatureAttribute("Ljdk/random/Xoshiro256PlusPlus;", "public final")]
public partial class Xoshiro256PlusPlus
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.util.random.RandomGenerator.LeapableGenerator
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Xoshiro256PlusPlus()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/random/Xoshiro256PlusPlus;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_GEN", "Ljava/util/concurrent/atomic/AtomicLong;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x0", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x1", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x2", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x3", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JUMP_TABLE", "[J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEAP_TABLE", "[J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([B)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(JJJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy_0", "()Ljava/util/random/RandomGenerator$LeapableGenerator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy_1", "()Ljava/util/random/RandomGenerator$JumpableGenerator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy_2", "()Ljdk/random/Xoshiro256PlusPlus;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "jump", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "leap", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextLong", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "jumpDistance", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "leapDistance", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "jumpAlgorithm", "([J)V"));
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicLong;", "private static final")]
	public static Dova.JDK.java.util.concurrent.atomic.AtomicLong DEFAULT_GEN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicLong>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long x0_Property
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

	[JniSignatureAttribute("J", "private")]
	public long x1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long x2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long x3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("[J", "private static final")]
	public static JavaArray<long> JUMP_TABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[J", "private static final")]
	public static JavaArray<long> LEAP_TABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Xoshiro256PlusPlus(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([B)V", "public")]
	public Xoshiro256PlusPlus(JavaArray<byte> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Xoshiro256PlusPlus() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
	{
	}

	[JniSignatureAttribute("(J)V", "public")]
	public Xoshiro256PlusPlus(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	[JniSignatureAttribute("(JJJJ)V", "public")]
	public Xoshiro256PlusPlus(long arg0, long arg1, long arg2, long arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/random/Xoshiro256PlusPlus;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/util/random/RandomGenerator$LeapableGenerator;", "public volatile")]
	public Dova.JDK.java.util.random.RandomGenerator.LeapableGenerator copy_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.LeapableGenerator>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/random/RandomGenerator$JumpableGenerator;", "public volatile")]
	public Dova.JDK.java.util.random.RandomGenerator.JumpableGenerator copy_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGenerator.JumpableGenerator>(ret);
	}

	[JniSignatureAttribute("()Ljdk/random/Xoshiro256PlusPlus;", "public")]
	public Dova.JDK.jdk.random.Xoshiro256PlusPlus copy_2()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.random.Xoshiro256PlusPlus>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void jump()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void leap()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()J", "public")]
	public long nextLong()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double jumpDistance()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double leapDistance()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("([J)V", "private")]
	public void jumpAlgorithm(JavaArray<long> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}
}
