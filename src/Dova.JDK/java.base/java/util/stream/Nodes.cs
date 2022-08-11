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

[JniSignatureAttribute("Ljava/util/stream/Nodes;", "final")]
public partial class Nodes
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Nodes()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_ARRAY_SIZE", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BAD_SIZE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_NODE", "Ljava/util/stream/Node;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_INT_NODE", "Ljava/util/stream/Node$OfInt;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_LONG_NODE", "Ljava/util/stream/Node$OfLong;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_DOUBLE_NODE", "Ljava/util/stream/Node$OfDouble;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_INT_ARRAY", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_LONG_ARRAY", "[J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_DOUBLE_ARRAY", "[D"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "collect", "(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;ZLjava/util/function/IntFunction;)Ljava/util/stream/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "builder", "(JLjava/util/function/IntFunction;)Ljava/util/stream/Node$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "builder", "()Ljava/util/stream/Node$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "node", "([J)Ljava/util/stream/Node$OfLong;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "node", "([D)Ljava/util/stream/Node$OfDouble;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "node", "([I)Ljava/util/stream/Node$OfInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "node", "([Ljava/lang/Object;)Ljava/util/stream/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "node", "(Ljava/util/Collection;)Ljava/util/stream/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "flatten", "(Ljava/util/stream/Node;Ljava/util/function/IntFunction;)Ljava/util/stream/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "collectInt", "(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;Z)Ljava/util/stream/Node$OfInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "intBuilder", "(J)Ljava/util/stream/Node$Builder$OfInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "intBuilder", "()Ljava/util/stream/Node$Builder$OfInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "flattenInt", "(Ljava/util/stream/Node$OfInt;)Ljava/util/stream/Node$OfInt;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "longBuilder", "(J)Ljava/util/stream/Node$Builder$OfLong;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "longBuilder", "()Ljava/util/stream/Node$Builder$OfLong;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doubleBuilder", "(J)Ljava/util/stream/Node$Builder$OfDouble;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doubleBuilder", "()Ljava/util/stream/Node$Builder$OfDouble;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "flattenLong", "(Ljava/util/stream/Node$OfLong;)Ljava/util/stream/Node$OfLong;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "flattenDouble", "(Ljava/util/stream/Node$OfDouble;)Ljava/util/stream/Node$OfDouble;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "castingArray", "()Ljava/util/function/IntFunction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "emptyNode", "(Ljava/util/stream/StreamShape;)Ljava/util/stream/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "conc", "(Ljava/util/stream/StreamShape;Ljava/util/stream/Node;Ljava/util/stream/Node;)Ljava/util/stream/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "collectLong", "(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;Z)Ljava/util/stream/Node$OfLong;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "collectDouble", "(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;Z)Ljava/util/stream/Node$OfDouble;"));
	}

	[JniSignatureAttribute("J", "static final")]
	public static long MAX_ARRAY_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String BAD_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Node;", "private static final")]
	public static Dova.JDK.java.util.stream.Node EMPTY_NODE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Node$OfInt;", "private static final")]
	public static Dova.JDK.java.util.stream.Node.OfInt EMPTY_INT_NODE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfInt>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Node$OfLong;", "private static final")]
	public static Dova.JDK.java.util.stream.Node.OfLong EMPTY_LONG_NODE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfLong>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Node$OfDouble;", "private static final")]
	public static Dova.JDK.java.util.stream.Node.OfDouble EMPTY_DOUBLE_NODE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfDouble>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private static final")]
	public static JavaArray<int> EMPTY_INT_ARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[J", "private static final")]
	public static JavaArray<long> EMPTY_LONG_ARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[D", "private static final")]
	public static JavaArray<double> EMPTY_DOUBLE_ARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Nodes(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public Nodes() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;ZLjava/util/function/IntFunction;)Ljava/util/stream/Node;", "public static")]
	public static Dova.JDK.java.util.stream.Node collect(Dova.JDK.java.util.stream.PipelineHelper arg0, Dova.JDK.java.util.Spliterator arg1, bool arg2, Dova.JDK.java.util.function.IntFunction arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
	}

	[JniSignatureAttribute("(JLjava/util/function/IntFunction;)Ljava/util/stream/Node$Builder;", "static")]
	public static Dova.JDK.java.util.stream.Node.Builder builder(long arg0, Dova.JDK.java.util.function.IntFunction arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.Builder>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Node$Builder;", "static")]
	public static Dova.JDK.java.util.stream.Node.Builder builder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.Builder>(ret);
	}

	[JniSignatureAttribute("([J)Ljava/util/stream/Node$OfLong;", "static")]
	public static Dova.JDK.java.util.stream.Node.OfLong node(JavaArray<long> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfLong>(ret);
	}

	[JniSignatureAttribute("([D)Ljava/util/stream/Node$OfDouble;", "static")]
	public static Dova.JDK.java.util.stream.Node.OfDouble node(JavaArray<double> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfDouble>(ret);
	}

	[JniSignatureAttribute("([I)Ljava/util/stream/Node$OfInt;", "static")]
	public static Dova.JDK.java.util.stream.Node.OfInt node(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfInt>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/util/stream/Node;", "static")]
	public static Dova.JDK.java.util.stream.Node node(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)Ljava/util/stream/Node;", "static")]
	public static Dova.JDK.java.util.stream.Node node(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/Node;Ljava/util/function/IntFunction;)Ljava/util/stream/Node;", "public static")]
	public static Dova.JDK.java.util.stream.Node flatten(Dova.JDK.java.util.stream.Node arg0, Dova.JDK.java.util.function.IntFunction arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;Z)Ljava/util/stream/Node$OfInt;", "public static")]
	public static Dova.JDK.java.util.stream.Node.OfInt collectInt(Dova.JDK.java.util.stream.PipelineHelper arg0, Dova.JDK.java.util.Spliterator arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfInt>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/util/stream/Node$Builder$OfInt;", "static")]
	public static Dova.JDK.java.util.stream.Node.Builder.OfInt intBuilder(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.Builder.OfInt>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Node$Builder$OfInt;", "static")]
	public static Dova.JDK.java.util.stream.Node.Builder.OfInt intBuilder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.Builder.OfInt>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/Node$OfInt;)Ljava/util/stream/Node$OfInt;", "public static")]
	public static Dova.JDK.java.util.stream.Node.OfInt flattenInt(Dova.JDK.java.util.stream.Node.OfInt arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfInt>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/util/stream/Node$Builder$OfLong;", "static")]
	public static Dova.JDK.java.util.stream.Node.Builder.OfLong longBuilder(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.Builder.OfLong>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Node$Builder$OfLong;", "static")]
	public static Dova.JDK.java.util.stream.Node.Builder.OfLong longBuilder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.Builder.OfLong>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/util/stream/Node$Builder$OfDouble;", "static")]
	public static Dova.JDK.java.util.stream.Node.Builder.OfDouble doubleBuilder(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.Builder.OfDouble>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Node$Builder$OfDouble;", "static")]
	public static Dova.JDK.java.util.stream.Node.Builder.OfDouble doubleBuilder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.Builder.OfDouble>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/Node$OfLong;)Ljava/util/stream/Node$OfLong;", "public static")]
	public static Dova.JDK.java.util.stream.Node.OfLong flattenLong(Dova.JDK.java.util.stream.Node.OfLong arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfLong>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/Node$OfDouble;)Ljava/util/stream/Node$OfDouble;", "public static")]
	public static Dova.JDK.java.util.stream.Node.OfDouble flattenDouble(Dova.JDK.java.util.stream.Node.OfDouble arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfDouble>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/function/IntFunction;", "static")]
	public static Dova.JDK.java.util.function.IntFunction castingArray()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.IntFunction>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/StreamShape;)Ljava/util/stream/Node;", "static")]
	public static Dova.JDK.java.util.stream.Node emptyNode(Dova.JDK.java.util.stream.StreamShape arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/StreamShape;Ljava/util/stream/Node;Ljava/util/stream/Node;)Ljava/util/stream/Node;", "static")]
	public static Dova.JDK.java.util.stream.Node conc(Dova.JDK.java.util.stream.StreamShape arg0, Dova.JDK.java.util.stream.Node arg1, Dova.JDK.java.util.stream.Node arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;Z)Ljava/util/stream/Node$OfLong;", "public static")]
	public static Dova.JDK.java.util.stream.Node.OfLong collectLong(Dova.JDK.java.util.stream.PipelineHelper arg0, Dova.JDK.java.util.Spliterator arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfLong>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;Z)Ljava/util/stream/Node$OfDouble;", "public static")]
	public static Dova.JDK.java.util.stream.Node.OfDouble collectDouble(Dova.JDK.java.util.stream.PipelineHelper arg0, Dova.JDK.java.util.Spliterator arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfDouble>(ret);
	}

	[JniSignatureAttribute("Ljava/util/stream/Nodes$ConcNode;", "static final")]
	public partial class ConcNode
		: Dova.JDK.java.util.stream.Nodes.AbstractConcNode
		, Dova.JDK.java.util.stream.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ConcNode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$ConcNode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Node;Ljava/util/stream/Node;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "([Ljava/lang/Object;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asArray", "(Ljava/util/function/IntFunction;)[Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "truncate", "(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ConcNode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/stream/Node;Ljava/util/stream/Node;)V", "")]
		public ConcNode(Dova.JDK.java.util.stream.Node arg0, Dova.JDK.java.util.stream.Node arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$ConcNode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public")]
		public Dova.JDK.java.util.Spliterator spliterator()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
		public void forEach(Dova.JDK.java.util.function.Consumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("([Ljava/lang/Object;I)V", "public")]
		public void copyInto(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/util/function/IntFunction;)[Ljava/lang/Object;", "public")]
		public JavaArray<Dova.JDK.java.lang.Object> asArray(Dova.JDK.java.util.function.IntFunction arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}

		[JniSignatureAttribute("(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node;", "public")]
		public Dova.JDK.java.util.stream.Node truncate(long arg0, long arg1, Dova.JDK.java.util.function.IntFunction arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$ConcNode$OfDouble;", "static final")]
		public partial class OfDouble
			: Dova.JDK.java.util.stream.Nodes.ConcNode.OfPrimitive
			, Dova.JDK.java.util.stream.Node.OfDouble
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfDouble()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$ConcNode$OfDouble;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Node$OfDouble;Ljava/util/stream/Node$OfDouble;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_0", "()Ljava/util/Spliterator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_1", "()Ljava/util/Spliterator$OfPrimitive;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_2", "()Ljava/util/Spliterator$OfDouble;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfDouble(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/Node$OfDouble;Ljava/util/stream/Node$OfDouble;)V", "")]
			public OfDouble(Dova.JDK.java.util.stream.Node.OfDouble arg0, Dova.JDK.java.util.stream.Node.OfDouble arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$ConcNode$OfDouble;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
			public Dova.JDK.java.util.Spliterator spliterator_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
			public Dova.JDK.java.util.Spliterator.OfPrimitive spliterator_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfDouble;", "public")]
			public Dova.JDK.java.util.Spliterator.OfDouble spliterator_2()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfDouble>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$ConcNode$OfLong;", "static final")]
		public partial class OfLong
			: Dova.JDK.java.util.stream.Nodes.ConcNode.OfPrimitive
			, Dova.JDK.java.util.stream.Node.OfLong
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfLong()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$ConcNode$OfLong;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Node$OfLong;Ljava/util/stream/Node$OfLong;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_0", "()Ljava/util/Spliterator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_1", "()Ljava/util/Spliterator$OfPrimitive;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_2", "()Ljava/util/Spliterator$OfLong;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfLong(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/Node$OfLong;Ljava/util/stream/Node$OfLong;)V", "")]
			public OfLong(Dova.JDK.java.util.stream.Node.OfLong arg0, Dova.JDK.java.util.stream.Node.OfLong arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$ConcNode$OfLong;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
			public Dova.JDK.java.util.Spliterator spliterator_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
			public Dova.JDK.java.util.Spliterator.OfPrimitive spliterator_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfLong;", "public")]
			public Dova.JDK.java.util.Spliterator.OfLong spliterator_2()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfLong>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$ConcNode$OfInt;", "static final")]
		public partial class OfInt
			: Dova.JDK.java.util.stream.Nodes.ConcNode.OfPrimitive
			, Dova.JDK.java.util.stream.Node.OfInt
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfInt()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$ConcNode$OfInt;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Node$OfInt;Ljava/util/stream/Node$OfInt;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_0", "()Ljava/util/Spliterator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_1", "()Ljava/util/Spliterator$OfPrimitive;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_2", "()Ljava/util/Spliterator$OfInt;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfInt(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/Node$OfInt;Ljava/util/stream/Node$OfInt;)V", "")]
			public OfInt(Dova.JDK.java.util.stream.Node.OfInt arg0, Dova.JDK.java.util.stream.Node.OfInt arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$ConcNode$OfInt;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
			public Dova.JDK.java.util.Spliterator spliterator_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
			public Dova.JDK.java.util.Spliterator.OfPrimitive spliterator_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfInt;", "public")]
			public Dova.JDK.java.util.Spliterator.OfInt spliterator_2()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfInt>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$ConcNode$OfPrimitive;", "private abstract static")]
		public partial class OfPrimitive
			: Dova.JDK.java.util.stream.Nodes.AbstractConcNode
			, Dova.JDK.java.util.stream.Node.OfPrimitive
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfPrimitive()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$ConcNode$OfPrimitive;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Node$OfPrimitive;Ljava/util/stream/Node$OfPrimitive;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "(Ljava/lang/Object;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPrimitiveArray", "()Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChild", "(I)Ljava/util/stream/Node$OfPrimitive;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfPrimitive(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/Node$OfPrimitive;Ljava/util/stream/Node$OfPrimitive;)V", "")]
			public OfPrimitive(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$ConcNode$OfPrimitive;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String toString()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
			public void forEach(Dova.JDK.java.lang.Object arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;I)V", "public")]
			public void copyInto(Dova.JDK.java.lang.Object arg0, int arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			}

			[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object asPrimitiveArray()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(I)Ljava/util/stream/Node$OfPrimitive;", "public volatile")]
			public Dova.JDK.java.util.stream.Node.OfPrimitive getChild(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfPrimitive>(ret);
			}
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Nodes$ArrayNode;", "private static")]
	public partial class ArrayNode
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.stream.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ArrayNode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$ArrayNode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "array", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "curSize", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(JLjava/util/function/IntFunction;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "count", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "([Ljava/lang/Object;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asArray", "(Ljava/util/function/IntFunction;)[Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "final")]
		public JavaArray<Dova.JDK.java.lang.Object> array_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int curSize_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ArrayNode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(JLjava/util/function/IntFunction;)V", "")]
		public ArrayNode(long arg0, Dova.JDK.java.util.function.IntFunction arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)V", "")]
		public ArrayNode(JavaArray<Dova.JDK.java.lang.Object> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$ArrayNode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()J", "public")]
		public long count()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public")]
		public Dova.JDK.java.util.Spliterator spliterator()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
		public void forEach(Dova.JDK.java.util.function.Consumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("([Ljava/lang/Object;I)V", "public")]
		public void copyInto(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/util/function/IntFunction;)[Ljava/lang/Object;", "public")]
		public JavaArray<Dova.JDK.java.lang.Object> asArray(Dova.JDK.java.util.function.IntFunction arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Nodes$CollectionNode;", "private static final")]
	public partial class CollectionNode
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.stream.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CollectionNode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$CollectionNode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "c", "Ljava/util/Collection;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Collection;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "count", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "([Ljava/lang/Object;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asArray", "(Ljava/util/function/IntFunction;)[Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Ljava/util/Collection;", "private final")]
		public Dova.JDK.java.util.Collection c_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CollectionNode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)V", "")]
		public CollectionNode(Dova.JDK.java.util.Collection arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$CollectionNode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()J", "public")]
		public long count()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public")]
		public Dova.JDK.java.util.Spliterator spliterator()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
		public void forEach(Dova.JDK.java.util.function.Consumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("([Ljava/lang/Object;I)V", "public")]
		public void copyInto(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/util/function/IntFunction;)[Ljava/lang/Object;", "public")]
		public JavaArray<Dova.JDK.java.lang.Object> asArray(Dova.JDK.java.util.function.IntFunction arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Nodes$FixedNodeBuilder;", "private static final")]
	public partial class FixedNodeBuilder
		: Dova.JDK.java.util.stream.Nodes.ArrayNode
		, Dova.JDK.java.util.stream.Node.Builder
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FixedNodeBuilder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$FixedNodeBuilder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(JLjava/util/function/IntFunction;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "end", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "begin", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "()Ljava/util/stream/Node;"));
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
		public FixedNodeBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(JLjava/util/function/IntFunction;)V", "")]
		public FixedNodeBuilder(long arg0, Dova.JDK.java.util.function.IntFunction arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$FixedNodeBuilder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void end()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(J)V", "public")]
		public void begin(long arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
		public void accept(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Node;", "public")]
		public Dova.JDK.java.util.stream.Node build()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Nodes$SpinedNodeBuilder;", "private static final")]
	public partial class SpinedNodeBuilder
		: Dova.JDK.java.util.stream.SpinedBuffer
		, Dova.JDK.java.util.stream.Node
		, Dova.JDK.java.util.stream.Node.Builder
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SpinedNodeBuilder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$SpinedNodeBuilder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "building", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "end", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "begin", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "()Ljava/util/stream/Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "([Ljava/lang/Object;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asArray", "(Ljava/util/function/IntFunction;)[Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Z", "private")]
		public bool building_Property
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

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SpinedNodeBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public SpinedNodeBuilder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$SpinedNodeBuilder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void end()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(J)V", "public")]
		public void begin(long arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public")]
		public Dova.JDK.java.util.Spliterator spliterator()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
		public void accept(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
		public void forEach(Dova.JDK.java.util.function.Consumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Node;", "public")]
		public Dova.JDK.java.util.stream.Node build()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Object;I)V", "public")]
		public void copyInto(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/util/function/IntFunction;)[Ljava/lang/Object;", "public")]
		public JavaArray<Dova.JDK.java.lang.Object> asArray(Dova.JDK.java.util.function.IntFunction arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Nodes$IntArrayNode;", "private static")]
	public partial class IntArrayNode
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.stream.Node.OfInt
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IntArrayNode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$IntArrayNode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "array", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "curSize", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "count", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_0", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_1", "()Ljava/util/Spliterator$OfPrimitive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_2", "()Ljava/util/Spliterator$OfInt;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/IntConsumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "([II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "(Ljava/lang/Object;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPrimitiveArray_0", "()[I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPrimitiveArray_1", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("[I", "final")]
		public JavaArray<int> array_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int curSize_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IntArrayNode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(J)V", "")]
		public IntArrayNode(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("([I)V", "")]
		public IntArrayNode(JavaArray<int> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$IntArrayNode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()J", "public")]
		public long count()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
		public Dova.JDK.java.util.Spliterator spliterator_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
		public Dova.JDK.java.util.Spliterator.OfPrimitive spliterator_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfInt;", "public")]
		public Dova.JDK.java.util.Spliterator.OfInt spliterator_2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfInt>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void forEach(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/function/IntConsumer;)V", "public")]
		public void forEach(Dova.JDK.java.util.function.IntConsumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("([II)V", "public")]
		public void copyInto(JavaArray<int> arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;I)V", "public volatile")]
		public void copyInto(Dova.JDK.java.lang.Object arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		}

		[JniSignatureAttribute("()[I", "public")]
		public JavaArray<int> asPrimitiveArray_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object asPrimitiveArray_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Nodes$IntFixedNodeBuilder;", "private static final")]
	public partial class IntFixedNodeBuilder
		: Dova.JDK.java.util.stream.Nodes.IntArrayNode
		, Dova.JDK.java.util.stream.Node.Builder.OfInt
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IntFixedNodeBuilder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$IntFixedNodeBuilder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "end", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "begin", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build_0", "()Ljava/util/stream/Node$OfInt;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build_1", "()Ljava/util/stream/Node;"));
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
		public IntFixedNodeBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(J)V", "")]
		public IntFixedNodeBuilder(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$IntFixedNodeBuilder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void end()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(J)V", "public")]
		public void begin(long arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void accept(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Node$OfInt;", "public")]
		public Dova.JDK.java.util.stream.Node.OfInt build_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfInt>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Node;", "public volatile")]
		public Dova.JDK.java.util.stream.Node build_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Nodes$IntSpinedNodeBuilder;", "private static final")]
	public partial class IntSpinedNodeBuilder
		: Dova.JDK.java.util.stream.SpinedBuffer.OfInt
		, Dova.JDK.java.util.stream.Node.OfInt
		, Dova.JDK.java.util.stream.Node.Builder.OfInt
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IntSpinedNodeBuilder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$IntSpinedNodeBuilder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "building", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "end", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "begin", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_0", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_1", "()Ljava/util/Spliterator$OfInt;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_2", "()Ljava/util/Spliterator$OfPrimitive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/IntConsumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build_0", "()Ljava/util/stream/Node$OfInt;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build_1", "()Ljava/util/stream/Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "([II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "(Ljava/lang/Object;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPrimitiveArray_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPrimitiveArray_1", "()[I"));
		}

		[JniSignatureAttribute("Z", "private")]
		public bool building_Property
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

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IntSpinedNodeBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public IntSpinedNodeBuilder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$IntSpinedNodeBuilder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void end()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(J)V", "public")]
		public void begin(long arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
		public Dova.JDK.java.util.Spliterator spliterator_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfInt;", "public")]
		public Dova.JDK.java.util.Spliterator.OfInt spliterator_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfInt>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
		public Dova.JDK.java.util.Spliterator.OfPrimitive spliterator_2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void accept(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void forEach(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/function/IntConsumer;)V", "public")]
		public void forEach(Dova.JDK.java.util.function.IntConsumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Node$OfInt;", "public")]
		public Dova.JDK.java.util.stream.Node.OfInt build_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfInt>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Node;", "public volatile")]
		public Dova.JDK.java.util.stream.Node build_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}

		[JniSignatureAttribute("([II)V", "public")]
		public void copyInto(JavaArray<int> arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;I)V", "public volatile")]
		public void copyInto(Dova.JDK.java.lang.Object arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object asPrimitiveArray_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()[I", "public")]
		public JavaArray<int> asPrimitiveArray_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Nodes$LongArrayNode;", "private static")]
	public partial class LongArrayNode
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.stream.Node.OfLong
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LongArrayNode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$LongArrayNode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "array", "[J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "curSize", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "count", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_0", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_1", "()Ljava/util/Spliterator$OfPrimitive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_2", "()Ljava/util/Spliterator$OfLong;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/LongConsumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "([JI)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "(Ljava/lang/Object;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPrimitiveArray_0", "()[J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPrimitiveArray_1", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("[J", "final")]
		public JavaArray<long> array_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int curSize_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LongArrayNode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(J)V", "")]
		public LongArrayNode(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("([J)V", "")]
		public LongArrayNode(JavaArray<long> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$LongArrayNode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()J", "public")]
		public long count()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
		public Dova.JDK.java.util.Spliterator spliterator_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
		public Dova.JDK.java.util.Spliterator.OfPrimitive spliterator_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfLong;", "public")]
		public Dova.JDK.java.util.Spliterator.OfLong spliterator_2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfLong>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void forEach(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/function/LongConsumer;)V", "public")]
		public void forEach(Dova.JDK.java.util.function.LongConsumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("([JI)V", "public")]
		public void copyInto(JavaArray<long> arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;I)V", "public volatile")]
		public void copyInto(Dova.JDK.java.lang.Object arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		}

		[JniSignatureAttribute("()[J", "public")]
		public JavaArray<long> asPrimitiveArray_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object asPrimitiveArray_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Nodes$LongFixedNodeBuilder;", "private static final")]
	public partial class LongFixedNodeBuilder
		: Dova.JDK.java.util.stream.Nodes.LongArrayNode
		, Dova.JDK.java.util.stream.Node.Builder.OfLong
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LongFixedNodeBuilder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$LongFixedNodeBuilder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "end", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "begin", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build_0", "()Ljava/util/stream/Node$OfLong;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build_1", "()Ljava/util/stream/Node;"));
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
		public LongFixedNodeBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(J)V", "")]
		public LongFixedNodeBuilder(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$LongFixedNodeBuilder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void end()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(J)V", "public")]
		public void begin(long arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(J)V", "public")]
		public void accept(long arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Node$OfLong;", "public")]
		public Dova.JDK.java.util.stream.Node.OfLong build_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfLong>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Node;", "public volatile")]
		public Dova.JDK.java.util.stream.Node build_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Nodes$LongSpinedNodeBuilder;", "private static final")]
	public partial class LongSpinedNodeBuilder
		: Dova.JDK.java.util.stream.SpinedBuffer.OfLong
		, Dova.JDK.java.util.stream.Node.OfLong
		, Dova.JDK.java.util.stream.Node.Builder.OfLong
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LongSpinedNodeBuilder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$LongSpinedNodeBuilder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "building", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "end", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "begin", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_0", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_1", "()Ljava/util/Spliterator$OfLong;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_2", "()Ljava/util/Spliterator$OfPrimitive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/LongConsumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build_0", "()Ljava/util/stream/Node$OfLong;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build_1", "()Ljava/util/stream/Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "([JI)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "(Ljava/lang/Object;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPrimitiveArray_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPrimitiveArray_1", "()[J"));
		}

		[JniSignatureAttribute("Z", "private")]
		public bool building_Property
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

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LongSpinedNodeBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public LongSpinedNodeBuilder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$LongSpinedNodeBuilder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void end()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(J)V", "public")]
		public void begin(long arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
		public Dova.JDK.java.util.Spliterator spliterator_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfLong;", "public")]
		public Dova.JDK.java.util.Spliterator.OfLong spliterator_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfLong>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
		public Dova.JDK.java.util.Spliterator.OfPrimitive spliterator_2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
		}

		[JniSignatureAttribute("(J)V", "public")]
		public void accept(long arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void forEach(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/function/LongConsumer;)V", "public")]
		public void forEach(Dova.JDK.java.util.function.LongConsumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Node$OfLong;", "public")]
		public Dova.JDK.java.util.stream.Node.OfLong build_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfLong>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Node;", "public volatile")]
		public Dova.JDK.java.util.stream.Node build_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}

		[JniSignatureAttribute("([JI)V", "public")]
		public void copyInto(JavaArray<long> arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;I)V", "public volatile")]
		public void copyInto(Dova.JDK.java.lang.Object arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object asPrimitiveArray_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()[J", "public")]
		public JavaArray<long> asPrimitiveArray_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Nodes$DoubleArrayNode;", "private static")]
	public partial class DoubleArrayNode
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.stream.Node.OfDouble
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DoubleArrayNode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$DoubleArrayNode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "array", "[D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "curSize", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([D)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "count", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_0", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_1", "()Ljava/util/Spliterator$OfPrimitive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_2", "()Ljava/util/Spliterator$OfDouble;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/DoubleConsumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "([DI)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "(Ljava/lang/Object;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPrimitiveArray_0", "()[D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPrimitiveArray_1", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("[D", "final")]
		public JavaArray<double> array_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int curSize_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DoubleArrayNode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(J)V", "")]
		public DoubleArrayNode(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("([D)V", "")]
		public DoubleArrayNode(JavaArray<double> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$DoubleArrayNode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()J", "public")]
		public long count()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
		public Dova.JDK.java.util.Spliterator spliterator_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
		public Dova.JDK.java.util.Spliterator.OfPrimitive spliterator_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfDouble;", "public")]
		public Dova.JDK.java.util.Spliterator.OfDouble spliterator_2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfDouble>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void forEach(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/function/DoubleConsumer;)V", "public")]
		public void forEach(Dova.JDK.java.util.function.DoubleConsumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("([DI)V", "public")]
		public void copyInto(JavaArray<double> arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;I)V", "public volatile")]
		public void copyInto(Dova.JDK.java.lang.Object arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		}

		[JniSignatureAttribute("()[D", "public")]
		public JavaArray<double> asPrimitiveArray_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object asPrimitiveArray_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Nodes$DoubleFixedNodeBuilder;", "private static final")]
	public partial class DoubleFixedNodeBuilder
		: Dova.JDK.java.util.stream.Nodes.DoubleArrayNode
		, Dova.JDK.java.util.stream.Node.Builder.OfDouble
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DoubleFixedNodeBuilder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$DoubleFixedNodeBuilder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "end", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "begin", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(D)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build_0", "()Ljava/util/stream/Node$OfDouble;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build_1", "()Ljava/util/stream/Node;"));
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
		public DoubleFixedNodeBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(J)V", "")]
		public DoubleFixedNodeBuilder(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$DoubleFixedNodeBuilder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void end()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(J)V", "public")]
		public void begin(long arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(D)V", "public")]
		public void accept(double arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Node$OfDouble;", "public")]
		public Dova.JDK.java.util.stream.Node.OfDouble build_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfDouble>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Node;", "public volatile")]
		public Dova.JDK.java.util.stream.Node build_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Nodes$DoubleSpinedNodeBuilder;", "private static final")]
	public partial class DoubleSpinedNodeBuilder
		: Dova.JDK.java.util.stream.SpinedBuffer.OfDouble
		, Dova.JDK.java.util.stream.Node.OfDouble
		, Dova.JDK.java.util.stream.Node.Builder.OfDouble
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DoubleSpinedNodeBuilder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$DoubleSpinedNodeBuilder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "building", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "end", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "begin", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_0", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_1", "()Ljava/util/Spliterator$OfDouble;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_2", "()Ljava/util/Spliterator$OfPrimitive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(D)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/DoubleConsumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build_0", "()Ljava/util/stream/Node$OfDouble;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build_1", "()Ljava/util/stream/Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "([DI)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "(Ljava/lang/Object;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPrimitiveArray_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPrimitiveArray_1", "()[D"));
		}

		[JniSignatureAttribute("Z", "private")]
		public bool building_Property
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

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DoubleSpinedNodeBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public DoubleSpinedNodeBuilder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$DoubleSpinedNodeBuilder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void end()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(J)V", "public")]
		public void begin(long arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
		public Dova.JDK.java.util.Spliterator spliterator_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfDouble;", "public")]
		public Dova.JDK.java.util.Spliterator.OfDouble spliterator_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfDouble>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
		public Dova.JDK.java.util.Spliterator.OfPrimitive spliterator_2()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
		}

		[JniSignatureAttribute("(D)V", "public")]
		public void accept(double arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void forEach(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/function/DoubleConsumer;)V", "public")]
		public void forEach(Dova.JDK.java.util.function.DoubleConsumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Node$OfDouble;", "public")]
		public Dova.JDK.java.util.stream.Node.OfDouble build_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfDouble>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Node;", "public volatile")]
		public Dova.JDK.java.util.stream.Node build_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}

		[JniSignatureAttribute("([DI)V", "public")]
		public void copyInto(JavaArray<double> arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;I)V", "public volatile")]
		public void copyInto(Dova.JDK.java.lang.Object arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object asPrimitiveArray_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()[D", "public")]
		public JavaArray<double> asPrimitiveArray_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Nodes$SizedCollectorTask;", "private abstract static")]
	public partial class SizedCollectorTask
		: Dova.JDK.java.util.concurrent.CountedCompleter
		, Dova.JDK.java.util.stream.Sink
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SizedCollectorTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$SizedCollectorTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "spliterator", "Ljava/util/Spliterator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "helper", "Ljava/util/stream/PipelineHelper;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetSize", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offset", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "length", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fence", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Spliterator;Ljava/util/stream/PipelineHelper;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Nodes$SizedCollectorTask;Ljava/util/Spliterator;JJI)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "begin", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compute", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChild", "(Ljava/util/Spliterator;JJ)Ljava/util/stream/Nodes$SizedCollectorTask;"));
		}

		[JniSignatureAttribute("Ljava/util/Spliterator;", "protected final")]
		public Dova.JDK.java.util.Spliterator spliterator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/PipelineHelper;", "protected final")]
		public Dova.JDK.java.util.stream.PipelineHelper helper_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.PipelineHelper>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("J", "protected final")]
		public long targetSize_Property
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

		[JniSignatureAttribute("J", "protected")]
		public long offset_Property
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

		[JniSignatureAttribute("J", "protected")]
		public long length_Property
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

		[JniSignatureAttribute("I", "protected")]
		public int index_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("I", "protected")]
		public int fence_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SizedCollectorTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/Spliterator;Ljava/util/stream/PipelineHelper;I)V", "")]
		public SizedCollectorTask(Dova.JDK.java.util.Spliterator arg0, Dova.JDK.java.util.stream.PipelineHelper arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljava/util/stream/Nodes$SizedCollectorTask;Ljava/util/Spliterator;JJI)V", "")]
		public SizedCollectorTask(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Spliterator arg1, long arg2, long arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$SizedCollectorTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(J)V", "public")]
		public void begin(long arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void compute()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(Ljava/util/Spliterator;JJ)Ljava/util/stream/Nodes$SizedCollectorTask;", "abstract")]
		public Dova.JDK.java.lang.Object makeChild(Dova.JDK.java.util.Spliterator arg0, long arg1, long arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$SizedCollectorTask$OfDouble;", "static final")]
		public partial class OfDouble
			: Dova.JDK.java.util.stream.Nodes.SizedCollectorTask
			, Dova.JDK.java.util.stream.Sink.OfDouble
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfDouble()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$SizedCollectorTask$OfDouble;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "array", "[D"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Spliterator;Ljava/util/stream/PipelineHelper;[D)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Nodes$SizedCollectorTask$OfDouble;Ljava/util/Spliterator;JJ)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(D)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChild_0", "(Ljava/util/Spliterator;JJ)Ljava/util/stream/Nodes$SizedCollectorTask;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChild_1", "(Ljava/util/Spliterator;JJ)Ljava/util/stream/Nodes$SizedCollectorTask$OfDouble;"));
			}

			[JniSignatureAttribute("[D", "private final")]
			public JavaArray<double> array_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfDouble(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/Spliterator;Ljava/util/stream/PipelineHelper;[D)V", "")]
			public OfDouble(Dova.JDK.java.util.Spliterator arg0, Dova.JDK.java.util.stream.PipelineHelper arg1, JavaArray<double> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/Nodes$SizedCollectorTask$OfDouble;Ljava/util/Spliterator;JJ)V", "")]
			public OfDouble(Dova.JDK.java.util.stream.Nodes.SizedCollectorTask.OfDouble arg0, Dova.JDK.java.util.Spliterator arg1, long arg2, long arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$SizedCollectorTask$OfDouble;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(D)V", "public")]
			public void accept(double arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/Spliterator;JJ)Ljava/util/stream/Nodes$SizedCollectorTask;", "volatile")]
			public Dova.JDK.java.util.stream.Nodes.SizedCollectorTask makeChild_0(Dova.JDK.java.util.Spliterator arg0, long arg1, long arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Nodes.SizedCollectorTask>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/Spliterator;JJ)Ljava/util/stream/Nodes$SizedCollectorTask$OfDouble;", "")]
			public Dova.JDK.java.util.stream.Nodes.SizedCollectorTask.OfDouble makeChild_1(Dova.JDK.java.util.Spliterator arg0, long arg1, long arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Nodes.SizedCollectorTask.OfDouble>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$SizedCollectorTask$OfLong;", "static final")]
		public partial class OfLong
			: Dova.JDK.java.util.stream.Nodes.SizedCollectorTask
			, Dova.JDK.java.util.stream.Sink.OfLong
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfLong()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$SizedCollectorTask$OfLong;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "array", "[J"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Spliterator;Ljava/util/stream/PipelineHelper;[J)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Nodes$SizedCollectorTask$OfLong;Ljava/util/Spliterator;JJ)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(J)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChild_0", "(Ljava/util/Spliterator;JJ)Ljava/util/stream/Nodes$SizedCollectorTask;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChild_1", "(Ljava/util/Spliterator;JJ)Ljava/util/stream/Nodes$SizedCollectorTask$OfLong;"));
			}

			[JniSignatureAttribute("[J", "private final")]
			public JavaArray<long> array_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfLong(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/Spliterator;Ljava/util/stream/PipelineHelper;[J)V", "")]
			public OfLong(Dova.JDK.java.util.Spliterator arg0, Dova.JDK.java.util.stream.PipelineHelper arg1, JavaArray<long> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/Nodes$SizedCollectorTask$OfLong;Ljava/util/Spliterator;JJ)V", "")]
			public OfLong(Dova.JDK.java.util.stream.Nodes.SizedCollectorTask.OfLong arg0, Dova.JDK.java.util.Spliterator arg1, long arg2, long arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$SizedCollectorTask$OfLong;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(J)V", "public")]
			public void accept(long arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/Spliterator;JJ)Ljava/util/stream/Nodes$SizedCollectorTask;", "volatile")]
			public Dova.JDK.java.util.stream.Nodes.SizedCollectorTask makeChild_0(Dova.JDK.java.util.Spliterator arg0, long arg1, long arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Nodes.SizedCollectorTask>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/Spliterator;JJ)Ljava/util/stream/Nodes$SizedCollectorTask$OfLong;", "")]
			public Dova.JDK.java.util.stream.Nodes.SizedCollectorTask.OfLong makeChild_1(Dova.JDK.java.util.Spliterator arg0, long arg1, long arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Nodes.SizedCollectorTask.OfLong>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$SizedCollectorTask$OfInt;", "static final")]
		public partial class OfInt
			: Dova.JDK.java.util.stream.Nodes.SizedCollectorTask
			, Dova.JDK.java.util.stream.Sink.OfInt
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfInt()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$SizedCollectorTask$OfInt;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "array", "[I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Spliterator;Ljava/util/stream/PipelineHelper;[I)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Nodes$SizedCollectorTask$OfInt;Ljava/util/Spliterator;JJ)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChild_0", "(Ljava/util/Spliterator;JJ)Ljava/util/stream/Nodes$SizedCollectorTask;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChild_1", "(Ljava/util/Spliterator;JJ)Ljava/util/stream/Nodes$SizedCollectorTask$OfInt;"));
			}

			[JniSignatureAttribute("[I", "private final")]
			public JavaArray<int> array_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfInt(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/Spliterator;Ljava/util/stream/PipelineHelper;[I)V", "")]
			public OfInt(Dova.JDK.java.util.Spliterator arg0, Dova.JDK.java.util.stream.PipelineHelper arg1, JavaArray<int> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/Nodes$SizedCollectorTask$OfInt;Ljava/util/Spliterator;JJ)V", "")]
			public OfInt(Dova.JDK.java.util.stream.Nodes.SizedCollectorTask.OfInt arg0, Dova.JDK.java.util.Spliterator arg1, long arg2, long arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$SizedCollectorTask$OfInt;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(I)V", "public")]
			public void accept(int arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/Spliterator;JJ)Ljava/util/stream/Nodes$SizedCollectorTask;", "volatile")]
			public Dova.JDK.java.util.stream.Nodes.SizedCollectorTask makeChild_0(Dova.JDK.java.util.Spliterator arg0, long arg1, long arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Nodes.SizedCollectorTask>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/Spliterator;JJ)Ljava/util/stream/Nodes$SizedCollectorTask$OfInt;", "")]
			public Dova.JDK.java.util.stream.Nodes.SizedCollectorTask.OfInt makeChild_1(Dova.JDK.java.util.Spliterator arg0, long arg1, long arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Nodes.SizedCollectorTask.OfInt>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$SizedCollectorTask$OfRef;", "static final")]
		public partial class OfRef
			: Dova.JDK.java.util.stream.Nodes.SizedCollectorTask
			, Dova.JDK.java.util.stream.Sink
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfRef()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$SizedCollectorTask$OfRef;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "array", "[Ljava/lang/Object;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Spliterator;Ljava/util/stream/PipelineHelper;[Ljava/lang/Object;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Nodes$SizedCollectorTask$OfRef;Ljava/util/Spliterator;JJ)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChild_0", "(Ljava/util/Spliterator;JJ)Ljava/util/stream/Nodes$SizedCollectorTask;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChild_1", "(Ljava/util/Spliterator;JJ)Ljava/util/stream/Nodes$SizedCollectorTask$OfRef;"));
			}

			[JniSignatureAttribute("[Ljava/lang/Object;", "private final")]
			public JavaArray<Dova.JDK.java.lang.Object> array_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfRef(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/Spliterator;Ljava/util/stream/PipelineHelper;[Ljava/lang/Object;)V", "")]
			public OfRef(Dova.JDK.java.util.Spliterator arg0, Dova.JDK.java.util.stream.PipelineHelper arg1, JavaArray<Dova.JDK.java.lang.Object> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/Nodes$SizedCollectorTask$OfRef;Ljava/util/Spliterator;JJ)V", "")]
			public OfRef(Dova.JDK.java.util.stream.Nodes.SizedCollectorTask.OfRef arg0, Dova.JDK.java.util.Spliterator arg1, long arg2, long arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$SizedCollectorTask$OfRef;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
			public void accept(Dova.JDK.java.lang.Object arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/Spliterator;JJ)Ljava/util/stream/Nodes$SizedCollectorTask;", "volatile")]
			public Dova.JDK.java.util.stream.Nodes.SizedCollectorTask makeChild_0(Dova.JDK.java.util.Spliterator arg0, long arg1, long arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Nodes.SizedCollectorTask>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/Spliterator;JJ)Ljava/util/stream/Nodes$SizedCollectorTask$OfRef;", "")]
			public Dova.JDK.java.util.stream.Nodes.SizedCollectorTask.OfRef makeChild_1(Dova.JDK.java.util.Spliterator arg0, long arg1, long arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Nodes.SizedCollectorTask.OfRef>(ret);
			}
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Nodes$CollectorTask;", "private static")]
	public partial class CollectorTask
		: Dova.JDK.java.util.stream.AbstractTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CollectorTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$CollectorTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "helper", "Ljava/util/stream/PipelineHelper;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "builderFactory", "Ljava/util/function/LongFunction;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "concFactory", "Ljava/util/function/BinaryOperator;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;Ljava/util/function/LongFunction;Ljava/util/function/BinaryOperator;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Nodes$CollectorTask;Ljava/util/Spliterator;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onCompletion", "(Ljava/util/concurrent/CountedCompleter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChild_0", "(Ljava/util/Spliterator;)Ljava/util/stream/AbstractTask;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChild_1", "(Ljava/util/Spliterator;)Ljava/util/stream/Nodes$CollectorTask;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doLeaf_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doLeaf_1", "()Ljava/util/stream/Node;"));
		}

		[JniSignatureAttribute("Ljava/util/stream/PipelineHelper;", "protected final")]
		public Dova.JDK.java.util.stream.PipelineHelper helper_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.PipelineHelper>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/LongFunction;", "protected final")]
		public Dova.JDK.java.util.function.LongFunction builderFactory_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.LongFunction>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/BinaryOperator;", "protected final")]
		public Dova.JDK.java.util.function.BinaryOperator concFactory_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BinaryOperator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CollectorTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;Ljava/util/function/LongFunction;Ljava/util/function/BinaryOperator;)V", "")]
		public CollectorTask(Dova.JDK.java.util.stream.PipelineHelper arg0, Dova.JDK.java.util.Spliterator arg1, Dova.JDK.java.util.function.LongFunction arg2, Dova.JDK.java.util.function.BinaryOperator arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Ljava/util/stream/Nodes$CollectorTask;Ljava/util/Spliterator;)V", "")]
		public CollectorTask(Dova.JDK.java.util.stream.Nodes.CollectorTask arg0, Dova.JDK.java.util.Spliterator arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$CollectorTask;";
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

		[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/stream/Nodes$CollectorTask;", "protected")]
		public Dova.JDK.java.util.stream.Nodes.CollectorTask makeChild_1(Dova.JDK.java.util.Spliterator arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Nodes.CollectorTask>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "protected volatile")]
		public Dova.JDK.java.lang.Object doLeaf_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Node;", "protected")]
		public Dova.JDK.java.lang.Object doLeaf_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$CollectorTask$OfDouble;", "private static final")]
		public partial class OfDouble
			: Dova.JDK.java.util.stream.Nodes.CollectorTask
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfDouble()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$CollectorTask$OfDouble;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChild", "(Ljava/util/Spliterator;)Ljava/util/stream/AbstractTask;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doLeaf", "()Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfDouble(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;)V", "")]
			public OfDouble(Dova.JDK.java.util.stream.PipelineHelper arg0, Dova.JDK.java.util.Spliterator arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$CollectorTask$OfDouble;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/stream/AbstractTask;", "protected volatile")]
			public Dova.JDK.java.util.stream.AbstractTask makeChild(Dova.JDK.java.util.Spliterator arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.AbstractTask>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/Object;", "protected volatile")]
			public Dova.JDK.java.lang.Object doLeaf()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$CollectorTask$OfLong;", "private static final")]
		public partial class OfLong
			: Dova.JDK.java.util.stream.Nodes.CollectorTask
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfLong()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$CollectorTask$OfLong;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChild", "(Ljava/util/Spliterator;)Ljava/util/stream/AbstractTask;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doLeaf", "()Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfLong(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;)V", "")]
			public OfLong(Dova.JDK.java.util.stream.PipelineHelper arg0, Dova.JDK.java.util.Spliterator arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$CollectorTask$OfLong;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/stream/AbstractTask;", "protected volatile")]
			public Dova.JDK.java.util.stream.AbstractTask makeChild(Dova.JDK.java.util.Spliterator arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.AbstractTask>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/Object;", "protected volatile")]
			public Dova.JDK.java.lang.Object doLeaf()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$CollectorTask$OfInt;", "private static final")]
		public partial class OfInt
			: Dova.JDK.java.util.stream.Nodes.CollectorTask
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfInt()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$CollectorTask$OfInt;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChild", "(Ljava/util/Spliterator;)Ljava/util/stream/AbstractTask;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doLeaf", "()Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfInt(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/PipelineHelper;Ljava/util/Spliterator;)V", "")]
			public OfInt(Dova.JDK.java.util.stream.PipelineHelper arg0, Dova.JDK.java.util.Spliterator arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$CollectorTask$OfInt;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/stream/AbstractTask;", "protected volatile")]
			public Dova.JDK.java.util.stream.AbstractTask makeChild(Dova.JDK.java.util.Spliterator arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.AbstractTask>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/Object;", "protected volatile")]
			public Dova.JDK.java.lang.Object doLeaf()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$CollectorTask$OfRef;", "private static final")]
		public partial class OfRef
			: Dova.JDK.java.util.stream.Nodes.CollectorTask
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfRef()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$CollectorTask$OfRef;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/PipelineHelper;Ljava/util/function/IntFunction;Ljava/util/Spliterator;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChild", "(Ljava/util/Spliterator;)Ljava/util/stream/AbstractTask;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doLeaf", "()Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfRef(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/PipelineHelper;Ljava/util/function/IntFunction;Ljava/util/Spliterator;)V", "")]
			public OfRef(Dova.JDK.java.util.stream.PipelineHelper arg0, Dova.JDK.java.util.function.IntFunction arg1, Dova.JDK.java.util.Spliterator arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$CollectorTask$OfRef;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/util/Spliterator;)Ljava/util/stream/AbstractTask;", "protected volatile")]
			public Dova.JDK.java.util.stream.AbstractTask makeChild(Dova.JDK.java.util.Spliterator arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.AbstractTask>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/Object;", "protected volatile")]
			public Dova.JDK.java.lang.Object doLeaf()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Nodes$ToArrayTask;", "private abstract static")]
	public partial class ToArrayTask
		: Dova.JDK.java.util.concurrent.CountedCompleter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ToArrayTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$ToArrayTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "node", "Ljava/util/stream/Node;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offset", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Node;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Nodes$ToArrayTask;Ljava/util/stream/Node;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compute", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChild", "(II)Ljava/util/stream/Nodes$ToArrayTask;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyNodeToArray", "()V"));
		}

		[JniSignatureAttribute("Ljava/util/stream/Node;", "protected final")]
		public Dova.JDK.java.lang.Object node_Property
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

		[JniSignatureAttribute("I", "protected final")]
		public int offset_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ToArrayTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/stream/Node;I)V", "")]
		public ToArrayTask(Dova.JDK.java.lang.Object arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/util/stream/Nodes$ToArrayTask;Ljava/util/stream/Node;I)V", "")]
		public ToArrayTask(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$ToArrayTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void compute()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(II)Ljava/util/stream/Nodes$ToArrayTask;", "abstract")]
		public Dova.JDK.java.lang.Object makeChild(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()V", "abstract")]
		public void copyNodeToArray()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$ToArrayTask$OfDouble;", "private static final")]
		public partial class OfDouble
			: Dova.JDK.java.util.stream.Nodes.ToArrayTask.OfPrimitive
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfDouble()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$ToArrayTask$OfDouble;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Node$OfDouble;[DI)V"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfDouble(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/Node$OfDouble;[DI)V", "private")]
			public OfDouble(Dova.JDK.java.util.stream.Node.OfDouble arg0, JavaArray<double> arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$ToArrayTask$OfDouble;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$ToArrayTask$OfLong;", "private static final")]
		public partial class OfLong
			: Dova.JDK.java.util.stream.Nodes.ToArrayTask.OfPrimitive
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfLong()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$ToArrayTask$OfLong;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Node$OfLong;[JI)V"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfLong(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/Node$OfLong;[JI)V", "private")]
			public OfLong(Dova.JDK.java.util.stream.Node.OfLong arg0, JavaArray<long> arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$ToArrayTask$OfLong;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$ToArrayTask$OfInt;", "private static final")]
		public partial class OfInt
			: Dova.JDK.java.util.stream.Nodes.ToArrayTask.OfPrimitive
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfInt()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$ToArrayTask$OfInt;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Node$OfInt;[II)V"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfInt(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/Node$OfInt;[II)V", "private")]
			public OfInt(Dova.JDK.java.util.stream.Node.OfInt arg0, JavaArray<int> arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$ToArrayTask$OfInt;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$ToArrayTask$OfPrimitive;", "private static")]
		public partial class OfPrimitive
			: Dova.JDK.java.util.stream.Nodes.ToArrayTask
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfPrimitive()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$ToArrayTask$OfPrimitive;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "array", "Ljava/lang/Object;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Node$OfPrimitive;Ljava/lang/Object;I)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Nodes$ToArrayTask$OfPrimitive;Ljava/util/stream/Node$OfPrimitive;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChild_0", "(II)Ljava/util/stream/Nodes$ToArrayTask;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChild_1", "(II)Ljava/util/stream/Nodes$ToArrayTask$OfPrimitive;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyNodeToArray", "()V"));
			}

			[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
			public Dova.JDK.java.lang.Object array_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfPrimitive(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/Node$OfPrimitive;Ljava/lang/Object;I)V", "private")]
			public OfPrimitive(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/Nodes$ToArrayTask$OfPrimitive;Ljava/util/stream/Node$OfPrimitive;I)V", "private")]
			public OfPrimitive(Dova.JDK.java.util.stream.Nodes.ToArrayTask.OfPrimitive arg0, Dova.JDK.java.lang.Object arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$ToArrayTask$OfPrimitive;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(II)Ljava/util/stream/Nodes$ToArrayTask;", "volatile")]
			public Dova.JDK.java.util.stream.Nodes.ToArrayTask makeChild_0(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Nodes.ToArrayTask>(ret);
			}

			[JniSignatureAttribute("(II)Ljava/util/stream/Nodes$ToArrayTask$OfPrimitive;", "")]
			public Dova.JDK.java.util.stream.Nodes.ToArrayTask.OfPrimitive makeChild_1(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Nodes.ToArrayTask.OfPrimitive>(ret);
			}

			[JniSignatureAttribute("()V", "")]
			public void copyNodeToArray()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$ToArrayTask$OfRef;", "private static final")]
		public partial class OfRef
			: Dova.JDK.java.util.stream.Nodes.ToArrayTask
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfRef()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$ToArrayTask$OfRef;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "array", "[Ljava/lang/Object;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Node;[Ljava/lang/Object;I)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Nodes$ToArrayTask$OfRef;Ljava/util/stream/Node;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChild_0", "(II)Ljava/util/stream/Nodes$ToArrayTask;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeChild_1", "(II)Ljava/util/stream/Nodes$ToArrayTask$OfRef;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyNodeToArray", "()V"));
			}

			[JniSignatureAttribute("[Ljava/lang/Object;", "private final")]
			public JavaArray<Dova.JDK.java.lang.Object> array_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfRef(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/Node;[Ljava/lang/Object;I)V", "private")]
			public OfRef(Dova.JDK.java.util.stream.Node arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/Nodes$ToArrayTask$OfRef;Ljava/util/stream/Node;I)V", "private")]
			public OfRef(Dova.JDK.java.util.stream.Nodes.ToArrayTask.OfRef arg0, Dova.JDK.java.util.stream.Node arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$ToArrayTask$OfRef;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(II)Ljava/util/stream/Nodes$ToArrayTask;", "volatile")]
			public Dova.JDK.java.util.stream.Nodes.ToArrayTask makeChild_0(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Nodes.ToArrayTask>(ret);
			}

			[JniSignatureAttribute("(II)Ljava/util/stream/Nodes$ToArrayTask$OfRef;", "")]
			public Dova.JDK.java.util.stream.Nodes.ToArrayTask.OfRef makeChild_1(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Nodes.ToArrayTask.OfRef>(ret);
			}

			[JniSignatureAttribute("()V", "")]
			public void copyNodeToArray()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
			}
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Nodes$EmptyNode;", "private abstract static")]
	public partial class EmptyNode
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.stream.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EmptyNode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$EmptyNode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "count", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "(Ljava/lang/Object;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asArray", "(Ljava/util/function/IntFunction;)[Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EmptyNode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public EmptyNode() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$EmptyNode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()J", "public")]
		public long count()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
		public void forEach(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;I)V", "public")]
		public void copyInto(Dova.JDK.java.lang.Object arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/util/function/IntFunction;)[Ljava/lang/Object;", "public")]
		public JavaArray<Dova.JDK.java.lang.Object> asArray(Dova.JDK.java.util.function.IntFunction arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$EmptyNode$OfDouble;", "private static final")]
		public partial class OfDouble
			: Dova.JDK.java.util.stream.Nodes.EmptyNode
			, Dova.JDK.java.util.stream.Node.OfDouble
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfDouble()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$EmptyNode$OfDouble;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_0", "()Ljava/util/Spliterator$OfPrimitive;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_1", "()Ljava/util/Spliterator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_2", "()Ljava/util/Spliterator$OfDouble;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPrimitiveArray_0", "()Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPrimitiveArray_1", "()[D"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfDouble(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public OfDouble() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$EmptyNode$OfDouble;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
			public Dova.JDK.java.util.Spliterator.OfPrimitive spliterator_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
			public Dova.JDK.java.util.Spliterator spliterator_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfDouble;", "public")]
			public Dova.JDK.java.util.Spliterator.OfDouble spliterator_2()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfDouble>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object asPrimitiveArray_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()[D", "public")]
			public JavaArray<double> asPrimitiveArray_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$EmptyNode$OfLong;", "private static final")]
		public partial class OfLong
			: Dova.JDK.java.util.stream.Nodes.EmptyNode
			, Dova.JDK.java.util.stream.Node.OfLong
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfLong()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$EmptyNode$OfLong;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_0", "()Ljava/util/Spliterator$OfPrimitive;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_1", "()Ljava/util/Spliterator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_2", "()Ljava/util/Spliterator$OfLong;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPrimitiveArray_0", "()Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPrimitiveArray_1", "()[J"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfLong(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public OfLong() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$EmptyNode$OfLong;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
			public Dova.JDK.java.util.Spliterator.OfPrimitive spliterator_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
			public Dova.JDK.java.util.Spliterator spliterator_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfLong;", "public")]
			public Dova.JDK.java.util.Spliterator.OfLong spliterator_2()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfLong>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object asPrimitiveArray_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()[J", "public")]
			public JavaArray<long> asPrimitiveArray_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$EmptyNode$OfInt;", "private static final")]
		public partial class OfInt
			: Dova.JDK.java.util.stream.Nodes.EmptyNode
			, Dova.JDK.java.util.stream.Node.OfInt
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfInt()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$EmptyNode$OfInt;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_0", "()Ljava/util/Spliterator$OfPrimitive;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_1", "()Ljava/util/Spliterator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_2", "()Ljava/util/Spliterator$OfInt;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPrimitiveArray_0", "()Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPrimitiveArray_1", "()[I"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfInt(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public OfInt() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$EmptyNode$OfInt;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
			public Dova.JDK.java.util.Spliterator.OfPrimitive spliterator_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
			public Dova.JDK.java.util.Spliterator spliterator_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfInt;", "public")]
			public Dova.JDK.java.util.Spliterator.OfInt spliterator_2()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfInt>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object asPrimitiveArray_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()[I", "public")]
			public JavaArray<int> asPrimitiveArray_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$EmptyNode$OfRef;", "private static")]
		public partial class OfRef
			: Dova.JDK.java.util.stream.Nodes.EmptyNode
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfRef()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$EmptyNode$OfRef;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator", "()Ljava/util/Spliterator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/Consumer;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "([Ljava/lang/Object;I)V"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfRef(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "private")]
			public OfRef() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$EmptyNode$OfRef;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/util/Spliterator;", "public")]
			public Dova.JDK.java.util.Spliterator spliterator()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public volatile")]
			public void forEach(Dova.JDK.java.util.function.Consumer arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("([Ljava/lang/Object;I)V", "public volatile")]
			public void copyInto(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			}
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Nodes$InternalNodeSpliterator;", "private abstract static")]
	public partial class InternalNodeSpliterator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.Spliterator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InternalNodeSpliterator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$InternalNodeSpliterator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "curNode", "Ljava/util/stream/Node;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "curChildIndex", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastNodeSpliterator", "Ljava/util/Spliterator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tryAdvanceSpliterator", "Ljava/util/Spliterator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tryAdvanceStack", "Ljava/util/Deque;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Node;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "characteristics", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "estimateSize", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initStack", "()Ljava/util/Deque;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findNextLeafNode", "(Ljava/util/Deque;)Ljava/util/stream/Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initTryAdvance", "()Z"));
		}

		[JniSignatureAttribute("Ljava/util/stream/Node;", "")]
		public Dova.JDK.java.lang.Object curNode_Property
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

		[JniSignatureAttribute("I", "")]
		public int curChildIndex_Property
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

		[JniSignatureAttribute("Ljava/util/Spliterator;", "")]
		public Dova.JDK.java.lang.Object lastNodeSpliterator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Spliterator;", "")]
		public Dova.JDK.java.lang.Object tryAdvanceSpliterator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Deque;", "")]
		public Dova.JDK.java.util.Deque tryAdvanceStack_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Deque>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InternalNodeSpliterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/stream/Node;)V", "")]
		public InternalNodeSpliterator(Dova.JDK.java.lang.Object arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$InternalNodeSpliterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public final")]
		public int characteristics()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public final")]
		public Dova.JDK.java.lang.Object trySplit()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()J", "public final")]
		public long estimateSize()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Deque;", "protected final")]
		public Dova.JDK.java.util.Deque initStack()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Deque>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Deque;)Ljava/util/stream/Node;", "protected final")]
		public Dova.JDK.java.lang.Object findNextLeafNode(Dova.JDK.java.util.Deque arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Z", "protected final")]
		public bool initTryAdvance()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$InternalNodeSpliterator$OfDouble;", "private static final")]
		public partial class OfDouble
			: Dova.JDK.java.util.stream.Nodes.InternalNodeSpliterator.OfPrimitive
			, Dova.JDK.java.util.Spliterator.OfDouble
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfDouble()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$InternalNodeSpliterator$OfDouble;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Node$OfDouble;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/DoubleConsumer;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/DoubleConsumer;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit", "()Ljava/util/Spliterator$OfDouble;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfDouble(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/Node$OfDouble;)V", "")]
			public OfDouble(Dova.JDK.java.util.stream.Node.OfDouble arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$InternalNodeSpliterator$OfDouble;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/util/function/DoubleConsumer;)V", "public volatile")]
			public void forEachRemaining(Dova.JDK.java.util.function.DoubleConsumer arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/function/DoubleConsumer;)Z", "public volatile")]
			public bool tryAdvance(Dova.JDK.java.util.function.DoubleConsumer arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfDouble;", "public volatile")]
			public Dova.JDK.java.util.Spliterator.OfDouble trySplit()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfDouble>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$InternalNodeSpliterator$OfLong;", "private static final")]
		public partial class OfLong
			: Dova.JDK.java.util.stream.Nodes.InternalNodeSpliterator.OfPrimitive
			, Dova.JDK.java.util.Spliterator.OfLong
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfLong()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$InternalNodeSpliterator$OfLong;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Node$OfLong;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/LongConsumer;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/LongConsumer;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit", "()Ljava/util/Spliterator$OfLong;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfLong(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/Node$OfLong;)V", "")]
			public OfLong(Dova.JDK.java.util.stream.Node.OfLong arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$InternalNodeSpliterator$OfLong;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/util/function/LongConsumer;)V", "public volatile")]
			public void forEachRemaining(Dova.JDK.java.util.function.LongConsumer arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/function/LongConsumer;)Z", "public volatile")]
			public bool tryAdvance(Dova.JDK.java.util.function.LongConsumer arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfLong;", "public volatile")]
			public Dova.JDK.java.util.Spliterator.OfLong trySplit()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfLong>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$InternalNodeSpliterator$OfInt;", "private static final")]
		public partial class OfInt
			: Dova.JDK.java.util.stream.Nodes.InternalNodeSpliterator.OfPrimitive
			, Dova.JDK.java.util.Spliterator.OfInt
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfInt()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$InternalNodeSpliterator$OfInt;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Node$OfInt;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/IntConsumer;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/IntConsumer;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit", "()Ljava/util/Spliterator$OfInt;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfInt(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/Node$OfInt;)V", "")]
			public OfInt(Dova.JDK.java.util.stream.Node.OfInt arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$InternalNodeSpliterator$OfInt;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/util/function/IntConsumer;)V", "public volatile")]
			public void forEachRemaining(Dova.JDK.java.util.function.IntConsumer arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/function/IntConsumer;)Z", "public volatile")]
			public bool tryAdvance(Dova.JDK.java.util.function.IntConsumer arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfInt;", "public volatile")]
			public Dova.JDK.java.util.Spliterator.OfInt trySplit()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfInt>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$InternalNodeSpliterator$OfPrimitive;", "private abstract static")]
		public partial class OfPrimitive
			: Dova.JDK.java.util.stream.Nodes.InternalNodeSpliterator
			, Dova.JDK.java.util.Spliterator.OfPrimitive
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfPrimitive()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$InternalNodeSpliterator$OfPrimitive;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Node$OfPrimitive;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit", "()Ljava/util/Spliterator$OfPrimitive;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfPrimitive(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/Node$OfPrimitive;)V", "")]
			public OfPrimitive(Dova.JDK.java.lang.Object arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$InternalNodeSpliterator$OfPrimitive;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
			public void forEachRemaining(Dova.JDK.java.lang.Object arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
			public bool tryAdvance(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public volatile")]
			public Dova.JDK.java.util.Spliterator.OfPrimitive trySplit()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator.OfPrimitive>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/Nodes$InternalNodeSpliterator$OfRef;", "private static final")]
		public partial class OfRef
			: Dova.JDK.java.util.stream.Nodes.InternalNodeSpliterator
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfRef()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$InternalNodeSpliterator$OfRef;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Node;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/Consumer;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/Consumer;)Z"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfRef(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/stream/Node;)V", "")]
			public OfRef(Dova.JDK.java.util.stream.Node arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$InternalNodeSpliterator$OfRef;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
			public void forEachRemaining(Dova.JDK.java.util.function.Consumer arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/function/Consumer;)Z", "public")]
			public bool tryAdvance(Dova.JDK.java.util.function.Consumer arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Nodes$AbstractConcNode;", "private abstract static")]
	public partial class AbstractConcNode
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.stream.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractConcNode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Nodes$AbstractConcNode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "left", "Ljava/util/stream/Node;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "right", "Ljava/util/stream/Node;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "size", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/stream/Node;Ljava/util/stream/Node;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "count", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChildCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChild", "(I)Ljava/util/stream/Node;"));
		}

		[JniSignatureAttribute("Ljava/util/stream/Node;", "protected final")]
		public Dova.JDK.java.lang.Object left_Property
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

		[JniSignatureAttribute("Ljava/util/stream/Node;", "protected final")]
		public Dova.JDK.java.lang.Object right_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("J", "private final")]
		public long size_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AbstractConcNode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/stream/Node;Ljava/util/stream/Node;)V", "")]
		public AbstractConcNode(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Nodes$AbstractConcNode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()J", "public")]
		public long count()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getChildCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljava/util/stream/Node;", "public")]
		public Dova.JDK.java.lang.Object getChild(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
