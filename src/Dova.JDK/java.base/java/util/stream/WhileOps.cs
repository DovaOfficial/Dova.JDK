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

namespace Dova.JDK.java.util.stream;

[JniSignatureAttribute("Ljava/util/stream/WhileOps;", "final")]
public partial class WhileOps
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static WhileOps()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/stream/WhileOps;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TAKE_FLAGS", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DROP_FLAGS", "I"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "WhileOps", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "makeTakeWhileRef", "(Ljava/util/stream/AbstractPipeline;Ljava/util/function/Predicate;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "makeDropWhileRef", "(Ljava/util/stream/AbstractPipeline;Ljava/util/function/Predicate;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "makeTakeWhileInt", "(Ljava/util/stream/AbstractPipeline;Ljava/util/function/IntPredicate;)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "makeDropWhileInt", "(Ljava/util/stream/AbstractPipeline;Ljava/util/function/IntPredicate;)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "makeTakeWhileDouble", "(Ljava/util/stream/AbstractPipeline;Ljava/util/function/DoublePredicate;)Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "makeDropWhileDouble", "(Ljava/util/stream/AbstractPipeline;Ljava/util/function/DoublePredicate;)Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "makeTakeWhileLong", "(Ljava/util/stream/AbstractPipeline;Ljava/util/function/LongPredicate;)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "makeDropWhileLong", "(Ljava/util/stream/AbstractPipeline;Ljava/util/function/LongPredicate;)Ljava/util/stream/LongStream;"));
	}

	[JniSignatureAttribute("I", "static final")]
	public static int TAKE_FLAGS_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("I", "static final")]
	public static int DROP_FLAGS_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public WhileOps(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public WhileOps() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/stream/WhileOps;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/stream/AbstractPipeline;Ljava/util/function/Predicate;)Ljava/util/stream/Stream;", "static")]
	public static Dova.JDK.java.util.stream.Stream makeTakeWhileRef(Dova.JDK.java.util.stream.AbstractPipeline arg0, Dova.JDK.java.util.function.Predicate arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/AbstractPipeline;Ljava/util/function/Predicate;)Ljava/util/stream/Stream;", "static")]
	public static Dova.JDK.java.util.stream.Stream makeDropWhileRef(Dova.JDK.java.util.stream.AbstractPipeline arg0, Dova.JDK.java.util.function.Predicate arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/AbstractPipeline;Ljava/util/function/IntPredicate;)Ljava/util/stream/IntStream;", "static")]
	public static Dova.JDK.java.util.stream.IntStream makeTakeWhileInt(Dova.JDK.java.util.stream.AbstractPipeline arg0, Dova.JDK.java.util.function.IntPredicate arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/AbstractPipeline;Ljava/util/function/IntPredicate;)Ljava/util/stream/IntStream;", "static")]
	public static Dova.JDK.java.util.stream.IntStream makeDropWhileInt(Dova.JDK.java.util.stream.AbstractPipeline arg0, Dova.JDK.java.util.function.IntPredicate arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/AbstractPipeline;Ljava/util/function/DoublePredicate;)Ljava/util/stream/DoubleStream;", "static")]
	public static Dova.JDK.java.util.stream.DoubleStream makeTakeWhileDouble(Dova.JDK.java.util.stream.AbstractPipeline arg0, Dova.JDK.java.util.function.DoublePredicate arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/AbstractPipeline;Ljava/util/function/DoublePredicate;)Ljava/util/stream/DoubleStream;", "static")]
	public static Dova.JDK.java.util.stream.DoubleStream makeDropWhileDouble(Dova.JDK.java.util.stream.AbstractPipeline arg0, Dova.JDK.java.util.function.DoublePredicate arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/AbstractPipeline;Ljava/util/function/LongPredicate;)Ljava/util/stream/LongStream;", "static")]
	public static Dova.JDK.java.util.stream.LongStream makeTakeWhileLong(Dova.JDK.java.util.stream.AbstractPipeline arg0, Dova.JDK.java.util.function.LongPredicate arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/AbstractPipeline;Ljava/util/function/LongPredicate;)Ljava/util/stream/LongStream;", "static")]
	public static Dova.JDK.java.util.stream.LongStream makeDropWhileLong(Dova.JDK.java.util.stream.AbstractPipeline arg0, Dova.JDK.java.util.function.LongPredicate arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("Ljava/util/stream/WhileOps$DropWhileTask;", "private static final")]
	public partial class DropWhileTask
		: Dova.JDK.java.util.stream.AbstractTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DropWhileTask()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/stream/WhileOps$DropWhileTask;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "op", "Ljava/util/stream/AbstractPipeline;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "generator", "Ljava/util/function/IntFunction;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "isOrdered", "Z"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "thisNodeSize", "J"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "index", "J"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DropWhileTask", "(Ljava/util/stream/AbstractPipeline;Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;Ljava/util/function/IntFunction;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DropWhileTask", "(Ljava/util/stream/WhileOps$DropWhileTask;Ljava/util/Spliterator;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "merge", "()Ljava/util/stream/Node;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "onCompletion", "(Ljava/util/concurrent/CountedCompleter;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "makeChild_0", "(Ljava/util/Spliterator;)Ljava/util/stream/AbstractTask;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "makeChild_1", "(Ljava/util/Spliterator;)Ljava/util/stream/WhileOps$DropWhileTask;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "doLeaf_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "doLeaf_1", "()Ljava/util/stream/Node;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "doTruncate", "(Ljava/util/stream/Node;)Ljava/util/stream/Node;"));
		}

		[JniSignatureAttribute("Ljava/util/stream/AbstractPipeline;", "private final")]
		public Dova.JDK.java.util.stream.AbstractPipeline op_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.AbstractPipeline>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/function/IntFunction;", "private final")]
		public Dova.JDK.java.util.function.IntFunction generator_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.IntFunction>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool isOrdered_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("J", "private")]
		public long thisNodeSize_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("J", "private")]
		public long index_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DropWhileTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/stream/AbstractPipeline;Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;Ljava/util/function/IntFunction;)V", "")]
		public DropWhileTask(Dova.JDK.java.util.stream.AbstractPipeline arg0, Dova.JDK.java.util.stream.PipelineHelper arg1, Dova.JDK.java.util.Spliterator arg2, Dova.JDK.java.util.function.IntFunction arg3) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Ljava/util/stream/WhileOps$DropWhileTask;Ljava/util/Spliterator;)V", "")]
		public DropWhileTask(Dova.JDK.java.util.stream.WhileOps.DropWhileTask arg0, Dova.JDK.java.util.Spliterator arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/WhileOps$DropWhileTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/stream/Node;", "private")]
		public Dova.JDK.java.util.stream.Node merge()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CountedCompleter;)V", "public final")]
		public void onCompletion(Dova.JDK.java.util.concurrent.CountedCompleter arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/stream/AbstractTask;", "protected volatile")]
		public Dova.JDK.java.util.stream.AbstractTask makeChild_0(Dova.JDK.java.util.Spliterator arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.AbstractTask>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/stream/WhileOps$DropWhileTask;", "protected")]
		public Dova.JDK.java.util.stream.WhileOps.DropWhileTask makeChild_1(Dova.JDK.java.util.Spliterator arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.WhileOps.DropWhileTask>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "protected volatile")]
		public Dova.JDK.java.lang.Object doLeaf_0()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Node;", "protected final")]
		public Dova.JDK.java.util.stream.Node doLeaf_1()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/stream/Node;)Ljava/util/stream/Node;", "private")]
		public Dova.JDK.java.util.stream.Node doTruncate(Dova.JDK.java.util.stream.Node arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/WhileOps$TakeWhileTask;", "private static final")]
	public partial class TakeWhileTask
		: Dova.JDK.java.util.stream.AbstractShortCircuitTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TakeWhileTask()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/stream/WhileOps$TakeWhileTask;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "op", "Ljava/util/stream/AbstractPipeline;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "generator", "Ljava/util/function/IntFunction;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "isOrdered", "Z"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "thisNodeSize", "J"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "shortCircuited", "Z"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "completed", "Z"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "TakeWhileTask", "(Ljava/util/stream/AbstractPipeline;Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;Ljava/util/function/IntFunction;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "TakeWhileTask", "(Ljava/util/stream/WhileOps$TakeWhileTask;Ljava/util/Spliterator;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "merge", "()Ljava/util/stream/Node;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "cancel", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "onCompletion", "(Ljava/util/concurrent/CountedCompleter;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "makeChild_0", "(Ljava/util/Spliterator;)Ljava/util/stream/WhileOps$TakeWhileTask;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "makeChild_1", "(Ljava/util/Spliterator;)Ljava/util/stream/AbstractTask;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "doLeaf_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "doLeaf_1", "()Ljava/util/stream/Node;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getEmptyResult_0", "()Ljava/util/stream/Node;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getEmptyResult_1", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Ljava/util/stream/AbstractPipeline;", "private final")]
		public Dova.JDK.java.util.stream.AbstractPipeline op_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.AbstractPipeline>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/function/IntFunction;", "private final")]
		public Dova.JDK.java.util.function.IntFunction generator_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.IntFunction>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool isOrdered_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("J", "private")]
		public long thisNodeSize_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("Z", "private")]
		public bool shortCircuited_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("Z", "private volatile")]
		public bool completed_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TakeWhileTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/stream/AbstractPipeline;Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;Ljava/util/function/IntFunction;)V", "")]
		public TakeWhileTask(Dova.JDK.java.util.stream.AbstractPipeline arg0, Dova.JDK.java.util.stream.PipelineHelper arg1, Dova.JDK.java.util.Spliterator arg2, Dova.JDK.java.util.function.IntFunction arg3) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Ljava/util/stream/WhileOps$TakeWhileTask;Ljava/util/Spliterator;)V", "")]
		public TakeWhileTask(Dova.JDK.java.util.stream.WhileOps.TakeWhileTask arg0, Dova.JDK.java.util.Spliterator arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/WhileOps$TakeWhileTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/stream/Node;", "")]
		public Dova.JDK.java.util.stream.Node merge()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}

		[JniSignatureAttribute("()V", "protected")]
		public void cancel()
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CountedCompleter;)V", "public final")]
		public void onCompletion(Dova.JDK.java.util.concurrent.CountedCompleter arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/stream/WhileOps$TakeWhileTask;", "protected")]
		public Dova.JDK.java.util.stream.WhileOps.TakeWhileTask makeChild_0(Dova.JDK.java.util.Spliterator arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.WhileOps.TakeWhileTask>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/stream/AbstractTask;", "protected volatile")]
		public Dova.JDK.java.util.stream.AbstractTask makeChild_1(Dova.JDK.java.util.Spliterator arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.AbstractTask>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "protected volatile")]
		public Dova.JDK.java.lang.Object doLeaf_0()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Node;", "protected final")]
		public Dova.JDK.java.util.stream.Node doLeaf_1()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Node;", "protected final")]
		public Dova.JDK.java.util.stream.Node getEmptyResult_0()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "protected volatile")]
		public Dova.JDK.java.lang.Object getEmptyResult_1()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator;", "abstract static")]
	public partial class UnorderedWhileSpliterator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.Spliterator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UnorderedWhileSpliterator()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CANCEL_CHECK_COUNT", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "s", "Ljava/util/Spliterator;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "noSplitting", "Z"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "cancel", "Ljava/util/concurrent/atomic/AtomicBoolean;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "takeOrDrop", "Z"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "count", "I"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "UnorderedWhileSpliterator", "(Ljava/util/Spliterator;Z)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "UnorderedWhileSpliterator", "(Ljava/util/Spliterator;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "characteristics", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "estimateSize", "()J"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getExactSizeIfKnown", "()J"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getComparator", "()Ljava/util/Comparator;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "makeSpliterator", "(Ljava/util/Spliterator;)Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "checkCancelOnCount", "()Z"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int CANCEL_CHECK_COUNT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("Ljava/util/Spliterator;", "final")]
		public Dova.JDK.java.lang.Object s_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "final")]
		public bool noSplitting_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicBoolean;", "final")]
		public Dova.JDK.java.util.concurrent.atomic.AtomicBoolean cancel_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicBoolean>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "")]
		public bool takeOrDrop_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("I", "")]
		public int count_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UnorderedWhileSpliterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/Spliterator;Z)V", "")]
		public UnorderedWhileSpliterator(Dova.JDK.java.lang.Object arg0, bool arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/util/Spliterator;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator;)V", "")]
		public UnorderedWhileSpliterator(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/WhileOps$UnorderedWhileSpliterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int characteristics()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public")]
		public Dova.JDK.java.lang.Object trySplit()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()J", "public")]
		public long estimateSize()
		{
			var ret = DovaJvm.Vm.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()J", "public")]
		public long getExactSizeIfKnown()
		{
			var ret = DovaJvm.Vm.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Comparator;", "public")]
		public Dova.JDK.java.util.Comparator getComparator()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/Spliterator;", "abstract")]
		public Dova.JDK.java.lang.Object makeSpliterator(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool checkCancelOnCount()
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfDouble;", "abstract static")]
		public partial class OfDouble
			: Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator
			, Dova.JDK.java.util.function.DoubleConsumer
			, Dova.JDK.java.util.Spliterator.OfDouble
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfDouble()
			{
				ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfDouble;");
				ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "p", "Ljava/util/function/DoublePredicate;"));
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "t", "D"));
				ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "OfDouble", "(Ljava/util/Spliterator$OfDouble;ZLjava/util/function/DoublePredicate;)V"));
				ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "OfDouble", "(Ljava/util/Spliterator$OfDouble;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfDouble;)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(D)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_0", "()Ljava/util/Spliterator$OfDouble;"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_1", "()Ljava/util/Spliterator$OfPrimitive;"));
			}

			[JniSignatureAttribute("Ljava/util/function/DoublePredicate;", "final")]
			public Dova.JDK.java.util.function.DoublePredicate p_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.DoublePredicate>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("D", "")]
			public double t_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set => DovaJvm.Vm.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[1], value);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfDouble(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/Spliterator$OfDouble;ZLjava/util/function/DoublePredicate;)V", "")]
			public OfDouble(Dova.JDK.java.util.Spliterator.OfDouble arg0, bool arg1, Dova.JDK.java.util.function.DoublePredicate arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			[JniSignatureAttribute("(Ljava/util/Spliterator$OfDouble;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfDouble;)V", "")]
			public OfDouble(Dova.JDK.java.util.Spliterator.OfDouble arg0, Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator.OfDouble arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfDouble;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(D)V", "public")]
			public void accept(double arg0)
			{
				DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfDouble;", "public volatile")]
			public Dova.JDK.java.util.Spliterator.OfDouble trySplit_0()
			{
				var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfDouble>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
			public Dova.JDK.java.util.Spliterator.OfPrimitive trySplit_1()
			{
				var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
			}

			[JniSignatureAttribute("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfDouble$Dropping;", "static final")]
			public partial class Dropping
				: Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator.OfDouble
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Dropping()
				{
					ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfDouble$Dropping;");
					ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
					ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Dropping", "(Ljava/util/Spliterator$OfDouble;ZLjava/util/function/DoublePredicate;)V"));
					ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Dropping", "(Ljava/util/Spliterator$OfDouble;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfDouble;)V"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "tryAdvance", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "tryAdvance", "(Ljava/util/function/DoubleConsumer;)Z"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_0", "()Ljava/util/Spliterator$OfPrimitive;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_1", "()Ljava/util/Spliterator$OfDouble;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "makeSpliterator", "(Ljava/util/Spliterator$OfDouble;)Ljava/util/Spliterator$OfDouble;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "makeSpliterator", "(Ljava/util/Spliterator;)Ljava/util/Spliterator;"));
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Dropping(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator$OfDouble;ZLjava/util/function/DoublePredicate;)V", "")]
				public Dropping(Dova.JDK.java.util.Spliterator.OfDouble arg0, bool arg1, Dova.JDK.java.util.function.DoublePredicate arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator$OfDouble;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfDouble;)V", "")]
				public Dropping(Dova.JDK.java.util.Spliterator.OfDouble arg0, Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator.OfDouble arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfDouble$Dropping;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
				public bool tryAdvance(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return ret;
				}

				[JniSignatureAttribute("(Ljava/util/function/DoubleConsumer;)Z", "public")]
				public bool tryAdvance(Dova.JDK.java.util.function.DoubleConsumer arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return ret;
				}

				[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
				public Dova.JDK.java.util.Spliterator.OfPrimitive trySplit_0()
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
				}

				[JniSignatureAttribute("()Ljava/util/Spliterator$OfDouble;", "public volatile")]
				public Dova.JDK.java.util.Spliterator.OfDouble trySplit_1()
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfDouble>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator$OfDouble;)Ljava/util/Spliterator$OfDouble;", "")]
				public Dova.JDK.java.util.Spliterator.OfDouble makeSpliterator(Dova.JDK.java.util.Spliterator.OfDouble arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfDouble>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/Spliterator;", "volatile")]
				public Dova.JDK.java.util.Spliterator makeSpliterator(Dova.JDK.java.util.Spliterator arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
				}
			}

			[JniSignatureAttribute("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfDouble$Taking;", "static final")]
			public partial class Taking
				: Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator.OfDouble
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Taking()
				{
					ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfDouble$Taking;");
					ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
					ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Taking", "(Ljava/util/Spliterator$OfDouble;ZLjava/util/function/DoublePredicate;)V"));
					ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Taking", "(Ljava/util/Spliterator$OfDouble;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfDouble;)V"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "tryAdvance", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "tryAdvance", "(Ljava/util/function/DoubleConsumer;)Z"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_0", "()Ljava/util/Spliterator$OfPrimitive;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_1", "()Ljava/util/Spliterator;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_2", "()Ljava/util/Spliterator$OfDouble;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "makeSpliterator", "(Ljava/util/Spliterator;)Ljava/util/Spliterator;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "makeSpliterator", "(Ljava/util/Spliterator$OfDouble;)Ljava/util/Spliterator$OfDouble;"));
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Taking(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator$OfDouble;ZLjava/util/function/DoublePredicate;)V", "")]
				public Taking(Dova.JDK.java.util.Spliterator.OfDouble arg0, bool arg1, Dova.JDK.java.util.function.DoublePredicate arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator$OfDouble;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfDouble;)V", "")]
				public Taking(Dova.JDK.java.util.Spliterator.OfDouble arg0, Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator.OfDouble arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfDouble$Taking;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
				public bool tryAdvance(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return ret;
				}

				[JniSignatureAttribute("(Ljava/util/function/DoubleConsumer;)Z", "public")]
				public bool tryAdvance(Dova.JDK.java.util.function.DoubleConsumer arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return ret;
				}

				[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
				public Dova.JDK.java.util.Spliterator.OfPrimitive trySplit_0()
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
				}

				[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
				public Dova.JDK.java.util.Spliterator trySplit_1()
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
				}

				[JniSignatureAttribute("()Ljava/util/Spliterator$OfDouble;", "public")]
				public Dova.JDK.java.util.Spliterator.OfDouble trySplit_2()
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfDouble>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/Spliterator;", "volatile")]
				public Dova.JDK.java.util.Spliterator makeSpliterator(Dova.JDK.java.util.Spliterator arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator$OfDouble;)Ljava/util/Spliterator$OfDouble;", "")]
				public Dova.JDK.java.util.Spliterator.OfDouble makeSpliterator(Dova.JDK.java.util.Spliterator.OfDouble arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfDouble>(ret);
				}
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfLong;", "abstract static")]
		public partial class OfLong
			: Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator
			, Dova.JDK.java.util.function.LongConsumer
			, Dova.JDK.java.util.Spliterator.OfLong
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfLong()
			{
				ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfLong;");
				ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "p", "Ljava/util/function/LongPredicate;"));
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "t", "J"));
				ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "OfLong", "(Ljava/util/Spliterator$OfLong;ZLjava/util/function/LongPredicate;)V"));
				ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "OfLong", "(Ljava/util/Spliterator$OfLong;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfLong;)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(J)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_0", "()Ljava/util/Spliterator$OfLong;"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_1", "()Ljava/util/Spliterator$OfPrimitive;"));
			}

			[JniSignatureAttribute("Ljava/util/function/LongPredicate;", "final")]
			public Dova.JDK.java.util.function.LongPredicate p_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.LongPredicate>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("J", "")]
			public long t_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfLong(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/Spliterator$OfLong;ZLjava/util/function/LongPredicate;)V", "")]
			public OfLong(Dova.JDK.java.util.Spliterator.OfLong arg0, bool arg1, Dova.JDK.java.util.function.LongPredicate arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			[JniSignatureAttribute("(Ljava/util/Spliterator$OfLong;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfLong;)V", "")]
			public OfLong(Dova.JDK.java.util.Spliterator.OfLong arg0, Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator.OfLong arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfLong;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(J)V", "public")]
			public void accept(long arg0)
			{
				DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfLong;", "public volatile")]
			public Dova.JDK.java.util.Spliterator.OfLong trySplit_0()
			{
				var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfLong>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
			public Dova.JDK.java.util.Spliterator.OfPrimitive trySplit_1()
			{
				var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
			}

			[JniSignatureAttribute("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfLong$Dropping;", "static final")]
			public partial class Dropping
				: Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator.OfLong
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Dropping()
				{
					ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfLong$Dropping;");
					ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
					ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Dropping", "(Ljava/util/Spliterator$OfLong;ZLjava/util/function/LongPredicate;)V"));
					ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Dropping", "(Ljava/util/Spliterator$OfLong;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfLong;)V"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "tryAdvance", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "tryAdvance", "(Ljava/util/function/LongConsumer;)Z"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_0", "()Ljava/util/Spliterator$OfPrimitive;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_1", "()Ljava/util/Spliterator$OfLong;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "makeSpliterator", "(Ljava/util/Spliterator$OfLong;)Ljava/util/Spliterator$OfLong;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "makeSpliterator", "(Ljava/util/Spliterator;)Ljava/util/Spliterator;"));
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Dropping(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator$OfLong;ZLjava/util/function/LongPredicate;)V", "")]
				public Dropping(Dova.JDK.java.util.Spliterator.OfLong arg0, bool arg1, Dova.JDK.java.util.function.LongPredicate arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator$OfLong;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfLong;)V", "")]
				public Dropping(Dova.JDK.java.util.Spliterator.OfLong arg0, Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator.OfLong arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfLong$Dropping;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
				public bool tryAdvance(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return ret;
				}

				[JniSignatureAttribute("(Ljava/util/function/LongConsumer;)Z", "public")]
				public bool tryAdvance(Dova.JDK.java.util.function.LongConsumer arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return ret;
				}

				[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
				public Dova.JDK.java.util.Spliterator.OfPrimitive trySplit_0()
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
				}

				[JniSignatureAttribute("()Ljava/util/Spliterator$OfLong;", "public volatile")]
				public Dova.JDK.java.util.Spliterator.OfLong trySplit_1()
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfLong>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator$OfLong;)Ljava/util/Spliterator$OfLong;", "")]
				public Dova.JDK.java.util.Spliterator.OfLong makeSpliterator(Dova.JDK.java.util.Spliterator.OfLong arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfLong>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/Spliterator;", "volatile")]
				public Dova.JDK.java.util.Spliterator makeSpliterator(Dova.JDK.java.util.Spliterator arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
				}
			}

			[JniSignatureAttribute("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfLong$Taking;", "static final")]
			public partial class Taking
				: Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator.OfLong
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Taking()
				{
					ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfLong$Taking;");
					ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
					ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Taking", "(Ljava/util/Spliterator$OfLong;ZLjava/util/function/LongPredicate;)V"));
					ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Taking", "(Ljava/util/Spliterator$OfLong;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfLong;)V"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "tryAdvance", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "tryAdvance", "(Ljava/util/function/LongConsumer;)Z"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_0", "()Ljava/util/Spliterator$OfPrimitive;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_1", "()Ljava/util/Spliterator;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_2", "()Ljava/util/Spliterator$OfLong;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "makeSpliterator", "(Ljava/util/Spliterator;)Ljava/util/Spliterator;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "makeSpliterator", "(Ljava/util/Spliterator$OfLong;)Ljava/util/Spliterator$OfLong;"));
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Taking(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator$OfLong;ZLjava/util/function/LongPredicate;)V", "")]
				public Taking(Dova.JDK.java.util.Spliterator.OfLong arg0, bool arg1, Dova.JDK.java.util.function.LongPredicate arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator$OfLong;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfLong;)V", "")]
				public Taking(Dova.JDK.java.util.Spliterator.OfLong arg0, Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator.OfLong arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfLong$Taking;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
				public bool tryAdvance(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return ret;
				}

				[JniSignatureAttribute("(Ljava/util/function/LongConsumer;)Z", "public")]
				public bool tryAdvance(Dova.JDK.java.util.function.LongConsumer arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return ret;
				}

				[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
				public Dova.JDK.java.util.Spliterator.OfPrimitive trySplit_0()
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
				}

				[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
				public Dova.JDK.java.util.Spliterator trySplit_1()
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
				}

				[JniSignatureAttribute("()Ljava/util/Spliterator$OfLong;", "public")]
				public Dova.JDK.java.util.Spliterator.OfLong trySplit_2()
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfLong>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/Spliterator;", "volatile")]
				public Dova.JDK.java.util.Spliterator makeSpliterator(Dova.JDK.java.util.Spliterator arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator$OfLong;)Ljava/util/Spliterator$OfLong;", "")]
				public Dova.JDK.java.util.Spliterator.OfLong makeSpliterator(Dova.JDK.java.util.Spliterator.OfLong arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfLong>(ret);
				}
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfInt;", "abstract static")]
		public partial class OfInt
			: Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator
			, Dova.JDK.java.util.function.IntConsumer
			, Dova.JDK.java.util.Spliterator.OfInt
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfInt()
			{
				ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfInt;");
				ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "p", "Ljava/util/function/IntPredicate;"));
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "t", "I"));
				ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "OfInt", "(Ljava/util/Spliterator$OfInt;ZLjava/util/function/IntPredicate;)V"));
				ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "OfInt", "(Ljava/util/Spliterator$OfInt;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfInt;)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(I)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_0", "()Ljava/util/Spliterator$OfInt;"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_1", "()Ljava/util/Spliterator$OfPrimitive;"));
			}

			[JniSignatureAttribute("Ljava/util/function/IntPredicate;", "final")]
			public Dova.JDK.java.util.function.IntPredicate p_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.IntPredicate>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("I", "")]
			public int t_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfInt(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/Spliterator$OfInt;ZLjava/util/function/IntPredicate;)V", "")]
			public OfInt(Dova.JDK.java.util.Spliterator.OfInt arg0, bool arg1, Dova.JDK.java.util.function.IntPredicate arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			[JniSignatureAttribute("(Ljava/util/Spliterator$OfInt;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfInt;)V", "")]
			public OfInt(Dova.JDK.java.util.Spliterator.OfInt arg0, Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator.OfInt arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfInt;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(I)V", "public")]
			public void accept(int arg0)
			{
				DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfInt;", "public volatile")]
			public Dova.JDK.java.util.Spliterator.OfInt trySplit_0()
			{
				var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfInt>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
			public Dova.JDK.java.util.Spliterator.OfPrimitive trySplit_1()
			{
				var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
			}

			[JniSignatureAttribute("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfInt$Dropping;", "static final")]
			public partial class Dropping
				: Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator.OfInt
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Dropping()
				{
					ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfInt$Dropping;");
					ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
					ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Dropping", "(Ljava/util/Spliterator$OfInt;ZLjava/util/function/IntPredicate;)V"));
					ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Dropping", "(Ljava/util/Spliterator$OfInt;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfInt;)V"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "tryAdvance", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "tryAdvance", "(Ljava/util/function/IntConsumer;)Z"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_0", "()Ljava/util/Spliterator$OfPrimitive;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_1", "()Ljava/util/Spliterator$OfInt;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "makeSpliterator", "(Ljava/util/Spliterator$OfInt;)Ljava/util/Spliterator$OfInt;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "makeSpliterator", "(Ljava/util/Spliterator;)Ljava/util/Spliterator;"));
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Dropping(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator$OfInt;ZLjava/util/function/IntPredicate;)V", "")]
				public Dropping(Dova.JDK.java.util.Spliterator.OfInt arg0, bool arg1, Dova.JDK.java.util.function.IntPredicate arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator$OfInt;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfInt;)V", "")]
				public Dropping(Dova.JDK.java.util.Spliterator.OfInt arg0, Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator.OfInt arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfInt$Dropping;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
				public bool tryAdvance(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return ret;
				}

				[JniSignatureAttribute("(Ljava/util/function/IntConsumer;)Z", "public")]
				public bool tryAdvance(Dova.JDK.java.util.function.IntConsumer arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return ret;
				}

				[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
				public Dova.JDK.java.util.Spliterator.OfPrimitive trySplit_0()
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
				}

				[JniSignatureAttribute("()Ljava/util/Spliterator$OfInt;", "public volatile")]
				public Dova.JDK.java.util.Spliterator.OfInt trySplit_1()
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfInt>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator$OfInt;)Ljava/util/Spliterator$OfInt;", "")]
				public Dova.JDK.java.util.Spliterator.OfInt makeSpliterator(Dova.JDK.java.util.Spliterator.OfInt arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfInt>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/Spliterator;", "volatile")]
				public Dova.JDK.java.util.Spliterator makeSpliterator(Dova.JDK.java.util.Spliterator arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
				}
			}

			[JniSignatureAttribute("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfInt$Taking;", "static final")]
			public partial class Taking
				: Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator.OfInt
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Taking()
				{
					ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfInt$Taking;");
					ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
					ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Taking", "(Ljava/util/Spliterator$OfInt;ZLjava/util/function/IntPredicate;)V"));
					ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Taking", "(Ljava/util/Spliterator$OfInt;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfInt;)V"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "tryAdvance", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "tryAdvance", "(Ljava/util/function/IntConsumer;)Z"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_0", "()Ljava/util/Spliterator$OfPrimitive;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_1", "()Ljava/util/Spliterator;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_2", "()Ljava/util/Spliterator$OfInt;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "makeSpliterator", "(Ljava/util/Spliterator;)Ljava/util/Spliterator;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "makeSpliterator", "(Ljava/util/Spliterator$OfInt;)Ljava/util/Spliterator$OfInt;"));
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Taking(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator$OfInt;ZLjava/util/function/IntPredicate;)V", "")]
				public Taking(Dova.JDK.java.util.Spliterator.OfInt arg0, bool arg1, Dova.JDK.java.util.function.IntPredicate arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator$OfInt;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfInt;)V", "")]
				public Taking(Dova.JDK.java.util.Spliterator.OfInt arg0, Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator.OfInt arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfInt$Taking;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
				public bool tryAdvance(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return ret;
				}

				[JniSignatureAttribute("(Ljava/util/function/IntConsumer;)Z", "public")]
				public bool tryAdvance(Dova.JDK.java.util.function.IntConsumer arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return ret;
				}

				[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
				public Dova.JDK.java.util.Spliterator.OfPrimitive trySplit_0()
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
				}

				[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
				public Dova.JDK.java.util.Spliterator trySplit_1()
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
				}

				[JniSignatureAttribute("()Ljava/util/Spliterator$OfInt;", "public")]
				public Dova.JDK.java.util.Spliterator.OfInt trySplit_2()
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfInt>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/Spliterator;", "volatile")]
				public Dova.JDK.java.util.Spliterator makeSpliterator(Dova.JDK.java.util.Spliterator arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator$OfInt;)Ljava/util/Spliterator$OfInt;", "")]
				public Dova.JDK.java.util.Spliterator.OfInt makeSpliterator(Dova.JDK.java.util.Spliterator.OfInt arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfInt>(ret);
				}
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfRef;", "abstract static")]
		public partial class OfRef
			: Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator
			, Dova.JDK.java.util.function.Consumer
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfRef()
			{
				ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfRef;");
				ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "p", "Ljava/util/function/Predicate;"));
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "t", "Ljava/lang/Object;"));
				ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "OfRef", "(Ljava/util/Spliterator;ZLjava/util/function/Predicate;)V"));
				ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "OfRef", "(Ljava/util/Spliterator;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfRef;)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Ljava/lang/Object;)V"));
			}

			[JniSignatureAttribute("Ljava/util/function/Predicate;", "final")]
			public Dova.JDK.java.util.function.Predicate p_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljava/lang/Object;", "")]
			public Dova.JDK.java.lang.Object t_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfRef(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/Spliterator;ZLjava/util/function/Predicate;)V", "")]
			public OfRef(Dova.JDK.java.util.Spliterator arg0, bool arg1, Dova.JDK.java.util.function.Predicate arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			[JniSignatureAttribute("(Ljava/util/Spliterator;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfRef;)V", "")]
			public OfRef(Dova.JDK.java.util.Spliterator arg0, Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator.OfRef arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfRef;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
			public void accept(Dova.JDK.java.lang.Object arg0)
			{
				DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfRef$Dropping;", "static final")]
			public partial class Dropping
				: Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator.OfRef
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Dropping()
				{
					ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfRef$Dropping;");
					ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
					ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Dropping", "(Ljava/util/Spliterator;ZLjava/util/function/Predicate;)V"));
					ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Dropping", "(Ljava/util/Spliterator;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfRef$Dropping;)V"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "tryAdvance", "(Ljava/util/function/Consumer;)Z"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "makeSpliterator", "(Ljava/util/Spliterator;)Ljava/util/Spliterator;"));
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Dropping(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator;ZLjava/util/function/Predicate;)V", "")]
				public Dropping(Dova.JDK.java.util.Spliterator arg0, bool arg1, Dova.JDK.java.util.function.Predicate arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfRef$Dropping;)V", "")]
				public Dropping(Dova.JDK.java.util.Spliterator arg0, Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator.OfRef.Dropping arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfRef$Dropping;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/util/function/Consumer;)Z", "public")]
				public bool tryAdvance(Dova.JDK.java.util.function.Consumer arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return ret;
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/Spliterator;", "")]
				public Dova.JDK.java.util.Spliterator makeSpliterator(Dova.JDK.java.util.Spliterator arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
				}
			}

			[JniSignatureAttribute("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfRef$Taking;", "static final")]
			public partial class Taking
				: Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator.OfRef
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Taking()
				{
					ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfRef$Taking;");
					ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
					ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Taking", "(Ljava/util/Spliterator;ZLjava/util/function/Predicate;)V"));
					ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Taking", "(Ljava/util/Spliterator;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfRef$Taking;)V"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "tryAdvance", "(Ljava/util/function/Consumer;)Z"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit", "()Ljava/util/Spliterator;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "makeSpliterator", "(Ljava/util/Spliterator;)Ljava/util/Spliterator;"));
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Taking(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator;ZLjava/util/function/Predicate;)V", "")]
				public Taking(Dova.JDK.java.util.Spliterator arg0, bool arg1, Dova.JDK.java.util.function.Predicate arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator;Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfRef$Taking;)V", "")]
				public Taking(Dova.JDK.java.util.Spliterator arg0, Dova.JDK.java.util.stream.WhileOps.UnorderedWhileSpliterator.OfRef.Taking arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Ljava/util/stream/WhileOps$UnorderedWhileSpliterator$OfRef$Taking;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/util/function/Consumer;)Z", "public")]
				public bool tryAdvance(Dova.JDK.java.util.function.Consumer arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return ret;
				}

				[JniSignatureAttribute("()Ljava/util/Spliterator;", "public")]
				public Dova.JDK.java.util.Spliterator trySplit()
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/Spliterator;", "")]
				public Dova.JDK.java.util.Spliterator makeSpliterator(Dova.JDK.java.util.Spliterator arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
				}
			}
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/WhileOps$DropWhileSink;", "abstract static interface")]
	public partial interface DropWhileSink
		: IJavaObject
		, Dova.JDK.java.util.stream.Sink
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DropWhileSink()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/stream/WhileOps$DropWhileSink;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDropCount", "()J"));
		}

		[JniSignatureAttribute("()J", "public abstract")]
		long getDropCount()
		{
			var ret = DovaJvm.Vm.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/WhileOps$DropWhileOp;", "abstract static interface")]
	public partial interface DropWhileOp
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DropWhileOp()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/stream/WhileOps$DropWhileOp;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "opWrapSink", "(Ljava/util/stream/Sink;Z)Ljava/util/stream/WhileOps$DropWhileSink;"));
		}

		[JniSignatureAttribute("(Ljava/util/stream/Sink;Z)Ljava/util/stream/WhileOps$DropWhileSink;", "public abstract")]
		Dova.JDK.java.util.stream.WhileOps.DropWhileSink opWrapSink(Dova.JDK.java.util.stream.Sink arg0, bool arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.WhileOps.DropWhileSink>(ret);
		}
	}
}
