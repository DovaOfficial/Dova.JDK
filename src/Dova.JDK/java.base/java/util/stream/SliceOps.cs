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

namespace Dova.JDK.java.util.stream;

[JniSignatureAttribute("Ljava/util/stream/SliceOps;", "final")]
public partial class SliceOps
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SliceOps()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/SliceOps;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "flags", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeLong", "(Ljava/util/stream/AbstractPipeline;JJ)Ljava/util/stream/LongStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeInt", "(Ljava/util/stream/AbstractPipeline;JJ)Ljava/util/stream/IntStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeRef", "(Ljava/util/stream/AbstractPipeline;JJ)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeDouble", "(Ljava/util/stream/AbstractPipeline;JJ)Ljava/util/stream/DoubleStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "calcSliceFence", "(JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "calcSize", "(JJJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sliceSpliterator", "(Ljava/util/stream/StreamShape;Ljava/util/Spliterator;JJ)Ljava/util/Spliterator;"));
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SliceOps(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public SliceOps() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/stream/SliceOps;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(J)I", "private static")]
	public static int flags(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/stream/AbstractPipeline;JJ)Ljava/util/stream/LongStream;", "public static")]
	public static Dova.JDK.java.util.stream.LongStream makeLong(Dova.JDK.java.util.stream.AbstractPipeline arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.LongStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/AbstractPipeline;JJ)Ljava/util/stream/IntStream;", "public static")]
	public static Dova.JDK.java.util.stream.IntStream makeInt(Dova.JDK.java.util.stream.AbstractPipeline arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.IntStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/AbstractPipeline;JJ)Ljava/util/stream/Stream;", "public static")]
	public static Dova.JDK.java.util.stream.Stream makeRef(Dova.JDK.java.util.stream.AbstractPipeline arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/AbstractPipeline;JJ)Ljava/util/stream/DoubleStream;", "public static")]
	public static Dova.JDK.java.util.stream.DoubleStream makeDouble(Dova.JDK.java.util.stream.AbstractPipeline arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.DoubleStream>(ret);
	}

	[JniSignatureAttribute("(JJ)J", "private static")]
	public static long calcSliceFence(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JJJ)J", "private static")]
	public static long calcSize(long arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/stream/StreamShape;Ljava/util/Spliterator;JJ)Ljava/util/Spliterator;", "private static")]
	public static Dova.JDK.java.util.Spliterator sliceSpliterator(Dova.JDK.java.util.stream.StreamShape arg0, Dova.JDK.java.util.Spliterator arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
	}

	[JniSignatureAttribute("Ljava/util/stream/SliceOps$SliceTask;", "private static final")]
	public partial class SliceTask
		: Dova.JDK.java.util.stream.AbstractShortCircuitTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SliceTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/SliceOps$SliceTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "op", "Ljava/util/stream/AbstractPipeline;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "generator", "Ljava/util/function/IntFunction;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetOffset", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetSize", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thisNodeSize", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "completed", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/AbstractPipeline;Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;Ljava/util/function/IntFunction;JJ)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/SliceOps$SliceTask;Ljava/util/Spliterator;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cancel", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onCompletion", "(Ljava/util/concurrent/CountedCompleter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChild_0", "(Ljava/util/Spliterator;)Ljava/util/stream/SliceOps$SliceTask;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChild_1", "(Ljava/util/Spliterator;)Ljava/util/stream/AbstractTask;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doLeaf_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doLeaf_1", "()Ljava/util/stream/Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEmptyResult_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEmptyResult_1", "()Ljava/util/stream/Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doTruncate", "(Ljava/util/stream/Node;)Ljava/util/stream/Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLeftCompleted", "(J)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "completedSize", "(J)J"));
		}

		[JniSignatureAttribute("Ljava/util/stream/AbstractPipeline;", "private final")]
		public Dova.JDK.java.util.stream.AbstractPipeline op_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.AbstractPipeline>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/IntFunction;", "private final")]
		public Dova.JDK.java.util.function.IntFunction generator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.IntFunction>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("J", "private final")]
		public long targetOffset_Property
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

		[JniSignatureAttribute("J", "private final")]
		public long targetSize_Property
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
		public long thisNodeSize_Property
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

		[JniSignatureAttribute("Z", "private volatile")]
		public bool completed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SliceTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/stream/AbstractPipeline;Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;Ljava/util/function/IntFunction;JJ)V", "")]
		public SliceTask(Dova.JDK.java.util.stream.AbstractPipeline arg0, Dova.JDK.java.util.stream.PipelineHelper arg1, Dova.JDK.java.util.Spliterator arg2, Dova.JDK.java.util.function.IntFunction arg3, long arg4, long arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		[JniSignatureAttribute("(Ljava/util/stream/SliceOps$SliceTask;Ljava/util/Spliterator;)V", "")]
		public SliceTask(Dova.JDK.java.util.stream.SliceOps.SliceTask arg0, Dova.JDK.java.util.Spliterator arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/SliceOps$SliceTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "protected")]
		public void cancel()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/CountedCompleter;)V", "public final")]
		public void onCompletion(Dova.JDK.java.util.concurrent.CountedCompleter arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/stream/SliceOps$SliceTask;", "protected")]
		public Dova.JDK.java.util.stream.SliceOps.SliceTask makeChild_0(Dova.JDK.java.util.Spliterator arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.SliceOps.SliceTask>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/stream/AbstractTask;", "protected volatile")]
		public Dova.JDK.java.util.stream.AbstractTask makeChild_1(Dova.JDK.java.util.Spliterator arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.AbstractTask>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "protected volatile")]
		public Dova.JDK.java.lang.Object doLeaf_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Node;", "protected final")]
		public Dova.JDK.java.util.stream.Node doLeaf_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "protected volatile")]
		public Dova.JDK.java.lang.Object getEmptyResult_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Node;", "protected final")]
		public Dova.JDK.java.util.stream.Node getEmptyResult_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/stream/Node;)Ljava/util/stream/Node;", "private")]
		public Dova.JDK.java.util.stream.Node doTruncate(Dova.JDK.java.util.stream.Node arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}

		[JniSignatureAttribute("(J)Z", "private")]
		public bool isLeftCompleted(long arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return ret;
		}

		[JniSignatureAttribute("(J)J", "private")]
		public long completedSize(long arg0)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return ret;
		}
	}
}
