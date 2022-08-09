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

namespace Dova.JDK.java.util;

[JniSignatureAttribute("Ljava/util/ArrayPrefixHelpers;", "")]
public partial class ArrayPrefixHelpers
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ArrayPrefixHelpers()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/ArrayPrefixHelpers;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CUMULATE", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SUMMED", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "FINISHED", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MIN_PARTITION", "I"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ArrayPrefixHelpers", "()V"));
	}

	[JniSignatureAttribute("I", "static final")]
	public static int CUMULATE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("I", "static final")]
	public static int SUMMED_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("I", "static final")]
	public static int FINISHED_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("I", "static final")]
	public static int MIN_PARTITION_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ArrayPrefixHelpers(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public ArrayPrefixHelpers() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/ArrayPrefixHelpers;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("Ljava/util/ArrayPrefixHelpers$IntCumulateTask;", "static final")]
	public partial class IntCumulateTask
		: Dova.JDK.java.util.concurrent.CountedCompleter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IntCumulateTask()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/ArrayPrefixHelpers$IntCumulateTask;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "array", "[I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "function", "Ljava/util/function/IntBinaryOperator;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "left", "Ljava/util/ArrayPrefixHelpers$IntCumulateTask;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "right", "Ljava/util/ArrayPrefixHelpers$IntCumulateTask;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "in", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "out", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "lo", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "hi", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "origin", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fence", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "threshold", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "IntCumulateTask", "(Ljava/util/ArrayPrefixHelpers$IntCumulateTask;Ljava/util/function/IntBinaryOperator;[III)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "IntCumulateTask", "(Ljava/util/ArrayPrefixHelpers$IntCumulateTask;Ljava/util/function/IntBinaryOperator;[IIIIII)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "compute", "()V"));
		}

		[JniSignatureAttribute("[I", "final")]
		public JavaArray<int> array_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/function/IntBinaryOperator;", "final")]
		public Dova.JDK.java.util.function.IntBinaryOperator function_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.IntBinaryOperator>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/ArrayPrefixHelpers$IntCumulateTask;", "")]
		public Dova.JDK.java.util.ArrayPrefixHelpers.IntCumulateTask left_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayPrefixHelpers.IntCumulateTask>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/ArrayPrefixHelpers$IntCumulateTask;", "")]
		public Dova.JDK.java.util.ArrayPrefixHelpers.IntCumulateTask right_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayPrefixHelpers.IntCumulateTask>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "")]
		public int @in_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("I", "")]
		public int @out_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("I", "final")]
		public int lo_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
		}

		[JniSignatureAttribute("I", "final")]
		public int hi_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
		}

		[JniSignatureAttribute("I", "final")]
		public int origin_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
		}

		[JniSignatureAttribute("I", "final")]
		public int fence_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
		}

		[JniSignatureAttribute("I", "final")]
		public int threshold_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[11]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[11], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IntCumulateTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/ArrayPrefixHelpers$IntCumulateTask;Ljava/util/function/IntBinaryOperator;[III)V", "public")]
		public IntCumulateTask(Dova.JDK.java.util.ArrayPrefixHelpers.IntCumulateTask arg0, Dova.JDK.java.util.function.IntBinaryOperator arg1, JavaArray<int> arg2, int arg3, int arg4) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(Ljava/util/ArrayPrefixHelpers$IntCumulateTask;Ljava/util/function/IntBinaryOperator;[IIIIII)V", "")]
		public IntCumulateTask(Dova.JDK.java.util.ArrayPrefixHelpers.IntCumulateTask arg0, Dova.JDK.java.util.function.IntBinaryOperator arg1, JavaArray<int> arg2, int arg3, int arg4, int arg5, int arg6, int arg7) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/ArrayPrefixHelpers$IntCumulateTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public final")]
		public void compute()
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Ljava/util/ArrayPrefixHelpers$DoubleCumulateTask;", "static final")]
	public partial class DoubleCumulateTask
		: Dova.JDK.java.util.concurrent.CountedCompleter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DoubleCumulateTask()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/ArrayPrefixHelpers$DoubleCumulateTask;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "array", "[D"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "function", "Ljava/util/function/DoubleBinaryOperator;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "left", "Ljava/util/ArrayPrefixHelpers$DoubleCumulateTask;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "right", "Ljava/util/ArrayPrefixHelpers$DoubleCumulateTask;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "in", "D"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "out", "D"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "lo", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "hi", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "origin", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fence", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "threshold", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DoubleCumulateTask", "(Ljava/util/ArrayPrefixHelpers$DoubleCumulateTask;Ljava/util/function/DoubleBinaryOperator;[DII)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DoubleCumulateTask", "(Ljava/util/ArrayPrefixHelpers$DoubleCumulateTask;Ljava/util/function/DoubleBinaryOperator;[DIIIII)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "compute", "()V"));
		}

		[JniSignatureAttribute("[D", "final")]
		public JavaArray<double> array_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/function/DoubleBinaryOperator;", "final")]
		public Dova.JDK.java.util.function.DoubleBinaryOperator function_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.DoubleBinaryOperator>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/ArrayPrefixHelpers$DoubleCumulateTask;", "")]
		public Dova.JDK.java.util.ArrayPrefixHelpers.DoubleCumulateTask left_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayPrefixHelpers.DoubleCumulateTask>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/ArrayPrefixHelpers$DoubleCumulateTask;", "")]
		public Dova.JDK.java.util.ArrayPrefixHelpers.DoubleCumulateTask right_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayPrefixHelpers.DoubleCumulateTask>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("D", "")]
		public double @in_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("D", "")]
		public double @out_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("I", "final")]
		public int lo_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
		}

		[JniSignatureAttribute("I", "final")]
		public int hi_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
		}

		[JniSignatureAttribute("I", "final")]
		public int origin_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
		}

		[JniSignatureAttribute("I", "final")]
		public int fence_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
		}

		[JniSignatureAttribute("I", "final")]
		public int threshold_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[11]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[11], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DoubleCumulateTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/ArrayPrefixHelpers$DoubleCumulateTask;Ljava/util/function/DoubleBinaryOperator;[DII)V", "public")]
		public DoubleCumulateTask(Dova.JDK.java.util.ArrayPrefixHelpers.DoubleCumulateTask arg0, Dova.JDK.java.util.function.DoubleBinaryOperator arg1, JavaArray<double> arg2, int arg3, int arg4) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(Ljava/util/ArrayPrefixHelpers$DoubleCumulateTask;Ljava/util/function/DoubleBinaryOperator;[DIIIII)V", "")]
		public DoubleCumulateTask(Dova.JDK.java.util.ArrayPrefixHelpers.DoubleCumulateTask arg0, Dova.JDK.java.util.function.DoubleBinaryOperator arg1, JavaArray<double> arg2, int arg3, int arg4, int arg5, int arg6, int arg7) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/ArrayPrefixHelpers$DoubleCumulateTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public final")]
		public void compute()
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Ljava/util/ArrayPrefixHelpers$LongCumulateTask;", "static final")]
	public partial class LongCumulateTask
		: Dova.JDK.java.util.concurrent.CountedCompleter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LongCumulateTask()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/ArrayPrefixHelpers$LongCumulateTask;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "array", "[J"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "function", "Ljava/util/function/LongBinaryOperator;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "left", "Ljava/util/ArrayPrefixHelpers$LongCumulateTask;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "right", "Ljava/util/ArrayPrefixHelpers$LongCumulateTask;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "in", "J"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "out", "J"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "lo", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "hi", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "origin", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fence", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "threshold", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "LongCumulateTask", "(Ljava/util/ArrayPrefixHelpers$LongCumulateTask;Ljava/util/function/LongBinaryOperator;[JII)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "LongCumulateTask", "(Ljava/util/ArrayPrefixHelpers$LongCumulateTask;Ljava/util/function/LongBinaryOperator;[JIIIII)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "compute", "()V"));
		}

		[JniSignatureAttribute("[J", "final")]
		public JavaArray<long> array_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/function/LongBinaryOperator;", "final")]
		public Dova.JDK.java.util.function.LongBinaryOperator function_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.LongBinaryOperator>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/ArrayPrefixHelpers$LongCumulateTask;", "")]
		public Dova.JDK.java.util.ArrayPrefixHelpers.LongCumulateTask left_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayPrefixHelpers.LongCumulateTask>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/ArrayPrefixHelpers$LongCumulateTask;", "")]
		public Dova.JDK.java.util.ArrayPrefixHelpers.LongCumulateTask right_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayPrefixHelpers.LongCumulateTask>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("J", "")]
		public long @in_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("J", "")]
		public long @out_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("I", "final")]
		public int lo_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
		}

		[JniSignatureAttribute("I", "final")]
		public int hi_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
		}

		[JniSignatureAttribute("I", "final")]
		public int origin_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
		}

		[JniSignatureAttribute("I", "final")]
		public int fence_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
		}

		[JniSignatureAttribute("I", "final")]
		public int threshold_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[11]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[11], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LongCumulateTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/ArrayPrefixHelpers$LongCumulateTask;Ljava/util/function/LongBinaryOperator;[JII)V", "public")]
		public LongCumulateTask(Dova.JDK.java.util.ArrayPrefixHelpers.LongCumulateTask arg0, Dova.JDK.java.util.function.LongBinaryOperator arg1, JavaArray<long> arg2, int arg3, int arg4) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(Ljava/util/ArrayPrefixHelpers$LongCumulateTask;Ljava/util/function/LongBinaryOperator;[JIIIII)V", "")]
		public LongCumulateTask(Dova.JDK.java.util.ArrayPrefixHelpers.LongCumulateTask arg0, Dova.JDK.java.util.function.LongBinaryOperator arg1, JavaArray<long> arg2, int arg3, int arg4, int arg5, int arg6, int arg7) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/ArrayPrefixHelpers$LongCumulateTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public final")]
		public void compute()
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Ljava/util/ArrayPrefixHelpers$CumulateTask;", "static final")]
	public partial class CumulateTask
		: Dova.JDK.java.util.concurrent.CountedCompleter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CumulateTask()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/ArrayPrefixHelpers$CumulateTask;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "array", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "function", "Ljava/util/function/BinaryOperator;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "left", "Ljava/util/ArrayPrefixHelpers$CumulateTask;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "right", "Ljava/util/ArrayPrefixHelpers$CumulateTask;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "in", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "out", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "lo", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "hi", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "origin", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fence", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "threshold", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CumulateTask", "(Ljava/util/ArrayPrefixHelpers$CumulateTask;Ljava/util/function/BinaryOperator;[Ljava/lang/Object;II)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CumulateTask", "(Ljava/util/ArrayPrefixHelpers$CumulateTask;Ljava/util/function/BinaryOperator;[Ljava/lang/Object;IIIII)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "compute", "()V"));
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "final")]
		public JavaArray<Dova.JDK.java.lang.Object> array_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/function/BinaryOperator;", "final")]
		public Dova.JDK.java.util.function.BinaryOperator function_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BinaryOperator>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/ArrayPrefixHelpers$CumulateTask;", "")]
		public Dova.JDK.java.util.ArrayPrefixHelpers.CumulateTask left_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayPrefixHelpers.CumulateTask>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/ArrayPrefixHelpers$CumulateTask;", "")]
		public Dova.JDK.java.util.ArrayPrefixHelpers.CumulateTask right_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayPrefixHelpers.CumulateTask>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "")]
		public Dova.JDK.java.lang.Object @in_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "")]
		public Dova.JDK.java.lang.Object @out_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "final")]
		public int lo_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
		}

		[JniSignatureAttribute("I", "final")]
		public int hi_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
		}

		[JniSignatureAttribute("I", "final")]
		public int origin_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
		}

		[JniSignatureAttribute("I", "final")]
		public int fence_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
		}

		[JniSignatureAttribute("I", "final")]
		public int threshold_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[11]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[11], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CumulateTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/ArrayPrefixHelpers$CumulateTask;Ljava/util/function/BinaryOperator;[Ljava/lang/Object;II)V", "public")]
		public CumulateTask(Dova.JDK.java.util.ArrayPrefixHelpers.CumulateTask arg0, Dova.JDK.java.util.function.BinaryOperator arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, int arg3, int arg4) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(Ljava/util/ArrayPrefixHelpers$CumulateTask;Ljava/util/function/BinaryOperator;[Ljava/lang/Object;IIIII)V", "")]
		public CumulateTask(Dova.JDK.java.util.ArrayPrefixHelpers.CumulateTask arg0, Dova.JDK.java.util.function.BinaryOperator arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, int arg3, int arg4, int arg5, int arg6, int arg7) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/ArrayPrefixHelpers$CumulateTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public final")]
		public void compute()
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}
}
