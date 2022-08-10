/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.java.util.stream;

[JniSignatureAttribute("Ljava/util/stream/ReduceOps;", "final")]
public partial class ReduceOps
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ReduceOps()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/ReduceOps;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ReduceOps", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makeLong", "(JLjava/util/function/LongBinaryOperator;)Ljava/util/stream/TerminalOp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makeLong", "(Ljava/util/function/LongBinaryOperator;)Ljava/util/stream/TerminalOp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makeLong", "(Ljava/util/function/Supplier;Ljava/util/function/ObjLongConsumer;Ljava/util/function/BinaryOperator;)Ljava/util/stream/TerminalOp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makeInt", "(ILjava/util/function/IntBinaryOperator;)Ljava/util/stream/TerminalOp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makeInt", "(Ljava/util/function/IntBinaryOperator;)Ljava/util/stream/TerminalOp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makeInt", "(Ljava/util/function/Supplier;Ljava/util/function/ObjIntConsumer;Ljava/util/function/BinaryOperator;)Ljava/util/stream/TerminalOp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makeRef", "(Ljava/util/stream/Collector;)Ljava/util/stream/TerminalOp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makeRef", "(Ljava/util/function/BinaryOperator;)Ljava/util/stream/TerminalOp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makeRef", "(Ljava/lang/Object;Ljava/util/function/BiFunction;Ljava/util/function/BinaryOperator;)Ljava/util/stream/TerminalOp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makeRef", "(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BiConsumer;)Ljava/util/stream/TerminalOp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makeRefCounting", "()Ljava/util/stream/TerminalOp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makeDouble", "(Ljava/util/function/Supplier;Ljava/util/function/ObjDoubleConsumer;Ljava/util/function/BinaryOperator;)Ljava/util/stream/TerminalOp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makeDouble", "(Ljava/util/function/DoubleBinaryOperator;)Ljava/util/stream/TerminalOp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makeDouble", "(DLjava/util/function/DoubleBinaryOperator;)Ljava/util/stream/TerminalOp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makeIntCounting", "()Ljava/util/stream/TerminalOp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makeLongCounting", "()Ljava/util/stream/TerminalOp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makeDoubleCounting", "()Ljava/util/stream/TerminalOp;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ReduceOps(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public ReduceOps() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/stream/ReduceOps;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(JLjava/util/function/LongBinaryOperator;)Ljava/util/stream/TerminalOp;", "public static")]
	public static Dova.JDK.java.util.stream.TerminalOp makeLong(long arg0, Dova.JDK.java.util.function.LongBinaryOperator arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.TerminalOp>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/LongBinaryOperator;)Ljava/util/stream/TerminalOp;", "public static")]
	public static Dova.JDK.java.util.stream.TerminalOp makeLong(Dova.JDK.java.util.function.LongBinaryOperator arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.TerminalOp>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;Ljava/util/function/ObjLongConsumer;Ljava/util/function/BinaryOperator;)Ljava/util/stream/TerminalOp;", "public static")]
	public static Dova.JDK.java.util.stream.TerminalOp makeLong(Dova.JDK.java.util.function.Supplier arg0, Dova.JDK.java.util.function.ObjLongConsumer arg1, Dova.JDK.java.util.function.BinaryOperator arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.TerminalOp>(ret);
	}

	[JniSignatureAttribute("(ILjava/util/function/IntBinaryOperator;)Ljava/util/stream/TerminalOp;", "public static")]
	public static Dova.JDK.java.util.stream.TerminalOp makeInt(int arg0, Dova.JDK.java.util.function.IntBinaryOperator arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.TerminalOp>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntBinaryOperator;)Ljava/util/stream/TerminalOp;", "public static")]
	public static Dova.JDK.java.util.stream.TerminalOp makeInt(Dova.JDK.java.util.function.IntBinaryOperator arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.TerminalOp>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;Ljava/util/function/ObjIntConsumer;Ljava/util/function/BinaryOperator;)Ljava/util/stream/TerminalOp;", "public static")]
	public static Dova.JDK.java.util.stream.TerminalOp makeInt(Dova.JDK.java.util.function.Supplier arg0, Dova.JDK.java.util.function.ObjIntConsumer arg1, Dova.JDK.java.util.function.BinaryOperator arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.TerminalOp>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/Collector;)Ljava/util/stream/TerminalOp;", "public static")]
	public static Dova.JDK.java.util.stream.TerminalOp makeRef(Dova.JDK.java.util.stream.Collector arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.TerminalOp>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/BinaryOperator;)Ljava/util/stream/TerminalOp;", "public static")]
	public static Dova.JDK.java.util.stream.TerminalOp makeRef(Dova.JDK.java.util.function.BinaryOperator arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.TerminalOp>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/function/BiFunction;Ljava/util/function/BinaryOperator;)Ljava/util/stream/TerminalOp;", "public static")]
	public static Dova.JDK.java.util.stream.TerminalOp makeRef(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.function.BiFunction arg1, Dova.JDK.java.util.function.BinaryOperator arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.TerminalOp>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BiConsumer;)Ljava/util/stream/TerminalOp;", "public static")]
	public static Dova.JDK.java.util.stream.TerminalOp makeRef(Dova.JDK.java.util.function.Supplier arg0, Dova.JDK.java.util.function.BiConsumer arg1, Dova.JDK.java.util.function.BiConsumer arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.TerminalOp>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/TerminalOp;", "public static")]
	public static Dova.JDK.java.util.stream.TerminalOp makeRefCounting()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.TerminalOp>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;Ljava/util/function/ObjDoubleConsumer;Ljava/util/function/BinaryOperator;)Ljava/util/stream/TerminalOp;", "public static")]
	public static Dova.JDK.java.util.stream.TerminalOp makeDouble(Dova.JDK.java.util.function.Supplier arg0, Dova.JDK.java.util.function.ObjDoubleConsumer arg1, Dova.JDK.java.util.function.BinaryOperator arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.TerminalOp>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/DoubleBinaryOperator;)Ljava/util/stream/TerminalOp;", "public static")]
	public static Dova.JDK.java.util.stream.TerminalOp makeDouble(Dova.JDK.java.util.function.DoubleBinaryOperator arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.TerminalOp>(ret);
	}

	[JniSignatureAttribute("(DLjava/util/function/DoubleBinaryOperator;)Ljava/util/stream/TerminalOp;", "public static")]
	public static Dova.JDK.java.util.stream.TerminalOp makeDouble(double arg0, Dova.JDK.java.util.function.DoubleBinaryOperator arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.TerminalOp>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/TerminalOp;", "public static")]
	public static Dova.JDK.java.util.stream.TerminalOp makeIntCounting()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.TerminalOp>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/TerminalOp;", "public static")]
	public static Dova.JDK.java.util.stream.TerminalOp makeLongCounting()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.TerminalOp>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/TerminalOp;", "public static")]
	public static Dova.JDK.java.util.stream.TerminalOp makeDoubleCounting()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.TerminalOp>(ret);
	}

	[JniSignatureAttribute("Ljava/util/stream/ReduceOps$ReduceTask;", "private static final")]
	public partial class ReduceTask
		: Dova.JDK.java.util.stream.AbstractTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ReduceTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/ReduceOps$ReduceTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "op", "Ljava/util/stream/ReduceOps$ReduceOp;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ReduceTask", "(Ljava/util/stream/ReduceOps$ReduceOp;Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ReduceTask", "(Ljava/util/stream/ReduceOps$ReduceTask;Ljava/util/Spliterator;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onCompletion", "(Ljava/util/concurrent/CountedCompleter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "makeChild_0", "(Ljava/util/Spliterator;)Ljava/util/stream/AbstractTask;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "makeChild_1", "(Ljava/util/Spliterator;)Ljava/util/stream/ReduceOps$ReduceTask;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "doLeaf_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "doLeaf_1", "()Ljava/util/stream/ReduceOps$AccumulatingSink;"));
		}

		[JniSignatureAttribute("Ljava/util/stream/ReduceOps$ReduceOp;", "private final")]
		public Dova.JDK.java.util.stream.ReduceOps.ReduceOp op_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.ReduceOps.ReduceOp>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ReduceTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/stream/ReduceOps$ReduceOp;Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;)V", "")]
		public ReduceTask(Dova.JDK.java.util.stream.ReduceOps.ReduceOp arg0, Dova.JDK.java.util.stream.PipelineHelper arg1, Dova.JDK.java.util.Spliterator arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljava/util/stream/ReduceOps$ReduceTask;Ljava/util/Spliterator;)V", "")]
		public ReduceTask(Dova.JDK.java.util.stream.ReduceOps.ReduceTask arg0, Dova.JDK.java.util.Spliterator arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/ReduceOps$ReduceTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/concurrent/CountedCompleter;)V", "public")]
		public void onCompletion(Dova.JDK.java.util.concurrent.CountedCompleter arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/stream/AbstractTask;", "protected volatile")]
		public Dova.JDK.java.util.stream.AbstractTask makeChild_0(Dova.JDK.java.util.Spliterator arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.AbstractTask>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/stream/ReduceOps$ReduceTask;", "protected")]
		public Dova.JDK.java.util.stream.ReduceOps.ReduceTask makeChild_1(Dova.JDK.java.util.Spliterator arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.ReduceOps.ReduceTask>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "protected volatile")]
		public Dova.JDK.java.lang.Object doLeaf_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/ReduceOps$AccumulatingSink;", "protected")]
		public Dova.JDK.java.lang.Object doLeaf_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/ReduceOps$ReduceOp;", "private abstract static")]
	public partial class ReduceOp
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.stream.TerminalOp
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ReduceOp()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/ReduceOps$ReduceOp;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "inputShape", "Ljava/util/stream/StreamShape;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ReduceOp", "(Ljava/util/stream/StreamShape;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "inputShape", "()Ljava/util/stream/StreamShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "evaluateParallel", "(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "evaluateSequential", "(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "makeSink", "()Ljava/util/stream/ReduceOps$AccumulatingSink;"));
		}

		[JniSignatureAttribute("Ljava/util/stream/StreamShape;", "private final")]
		public Dova.JDK.java.util.stream.StreamShape inputShape_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.StreamShape>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ReduceOp(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/stream/StreamShape;)V", "")]
		public ReduceOp(Dova.JDK.java.util.stream.StreamShape arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/ReduceOps$ReduceOp;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/stream/StreamShape;", "public")]
		public Dova.JDK.java.util.stream.StreamShape inputShape()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.StreamShape>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object evaluateParallel(Dova.JDK.java.util.stream.PipelineHelper arg0, Dova.JDK.java.util.Spliterator arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object evaluateSequential(Dova.JDK.java.util.stream.PipelineHelper arg0, Dova.JDK.java.util.Spliterator arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/ReduceOps$AccumulatingSink;", "public abstract")]
		public Dova.JDK.java.lang.Object makeSink()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/ReduceOps$Box;", "private abstract static")]
	public partial class Box
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Box()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/ReduceOps$Box;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "state", "Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Box", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "get", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "")]
		public Dova.JDK.java.lang.Object state_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Box(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Box() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/ReduceOps$Box;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object get()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/ReduceOps$AccumulatingSink;", "private abstract static interface")]
	public partial interface AccumulatingSink
		: IJavaObject
		, Dova.JDK.java.util.stream.TerminalSink
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AccumulatingSink()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/ReduceOps$AccumulatingSink;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "combine", "(Ljava/util/stream/ReduceOps$AccumulatingSink;)V"));
		}

		[JniSignatureAttribute("(Ljava/util/stream/ReduceOps$AccumulatingSink;)V", "public abstract")]
		void combine(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/ReduceOps$CountingSink;", "abstract static")]
	public partial class CountingSink
		: Dova.JDK.java.util.stream.ReduceOps.Box
		, Dova.JDK.java.util.stream.ReduceOps.AccumulatingSink
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CountingSink()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/ReduceOps$CountingSink;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "count", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CountingSink", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "get_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "get_1", "()Ljava/lang/Long;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "begin", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "combine", "(Ljava/util/stream/ReduceOps$AccumulatingSink;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "combine", "(Ljava/util/stream/ReduceOps$CountingSink;)V"));
		}

		[JniSignatureAttribute("J", "")]
		public long count_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CountingSink(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public CountingSink() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/ReduceOps$CountingSink;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object get_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Long;", "public")]
		public Dova.JDK.java.lang.Long get_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Long>(ret);
		}

		[JniSignatureAttribute("(J)V", "public")]
		public void begin(long arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/stream/ReduceOps$AccumulatingSink;)V", "public volatile")]
		public void combine(Dova.JDK.java.util.stream.ReduceOps.AccumulatingSink arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/stream/ReduceOps$CountingSink;)V", "public")]
		public void combine(Dova.JDK.java.util.stream.ReduceOps.CountingSink arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("Ljava/util/stream/ReduceOps$CountingSink$OfDouble;", "static final")]
		public partial class OfDouble
			: Dova.JDK.java.util.stream.ReduceOps.CountingSink
			, Dova.JDK.java.util.stream.Sink.OfDouble
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfDouble()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/ReduceOps$CountingSink$OfDouble;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "OfDouble", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "get", "()Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "accept", "(D)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "combine", "(Ljava/util/stream/ReduceOps$AccumulatingSink;)V"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfDouble(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public OfDouble() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/ReduceOps$CountingSink$OfDouble;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object get()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(D)V", "public")]
			public void accept(double arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/stream/ReduceOps$AccumulatingSink;)V", "public volatile")]
			public void combine(Dova.JDK.java.util.stream.ReduceOps.AccumulatingSink arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/ReduceOps$CountingSink$OfLong;", "static final")]
		public partial class OfLong
			: Dova.JDK.java.util.stream.ReduceOps.CountingSink
			, Dova.JDK.java.util.stream.Sink.OfLong
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfLong()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/ReduceOps$CountingSink$OfLong;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "OfLong", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "get", "()Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "accept", "(J)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "combine", "(Ljava/util/stream/ReduceOps$AccumulatingSink;)V"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfLong(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public OfLong() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/ReduceOps$CountingSink$OfLong;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object get()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(J)V", "public")]
			public void accept(long arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/stream/ReduceOps$AccumulatingSink;)V", "public volatile")]
			public void combine(Dova.JDK.java.util.stream.ReduceOps.AccumulatingSink arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/ReduceOps$CountingSink$OfInt;", "static final")]
		public partial class OfInt
			: Dova.JDK.java.util.stream.ReduceOps.CountingSink
			, Dova.JDK.java.util.stream.Sink.OfInt
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfInt()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/ReduceOps$CountingSink$OfInt;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "OfInt", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "get", "()Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "accept", "(I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "combine", "(Ljava/util/stream/ReduceOps$AccumulatingSink;)V"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfInt(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public OfInt() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/ReduceOps$CountingSink$OfInt;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object get()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(I)V", "public")]
			public void accept(int arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/stream/ReduceOps$AccumulatingSink;)V", "public volatile")]
			public void combine(Dova.JDK.java.util.stream.ReduceOps.AccumulatingSink arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/ReduceOps$CountingSink$OfRef;", "static final")]
		public partial class OfRef
			: Dova.JDK.java.util.stream.ReduceOps.CountingSink
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfRef()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/ReduceOps$CountingSink$OfRef;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "OfRef", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "get", "()Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "accept", "(Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "combine", "(Ljava/util/stream/ReduceOps$AccumulatingSink;)V"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfRef(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public OfRef() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/ReduceOps$CountingSink$OfRef;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object get()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
			public void accept(Dova.JDK.java.lang.Object arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/stream/ReduceOps$AccumulatingSink;)V", "public volatile")]
			public void combine(Dova.JDK.java.util.stream.ReduceOps.AccumulatingSink arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			}
		}
	}
}
