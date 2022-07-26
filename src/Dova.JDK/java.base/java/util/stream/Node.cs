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

[JniSignatureAttribute("Ljava/util/stream/Node;", "abstract interface")]
public partial interface Node
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Node()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Node;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "count", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator", "()Ljava/util/Spliterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/Consumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "([Ljava/lang/Object;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asArray", "(Ljava/util/function/IntFunction;)[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChildCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChild", "(I)Ljava/util/stream/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "truncate", "(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShape", "()Ljava/util/stream/StreamShape;"));
	}

	[JniSignatureAttribute("()J", "public abstract")]
	long count()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Spliterator;", "public abstract")]
	Dova.JDK.java.util.Spliterator spliterator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public abstract")]
	void forEach(Dova.JDK.java.util.function.Consumer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;I)V", "public abstract")]
	void copyInto(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/function/IntFunction;)[Ljava/lang/Object;", "public abstract")]
	JavaArray<Dova.JDK.java.lang.Object> asArray(Dova.JDK.java.util.function.IntFunction arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	int getChildCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/util/stream/Node;", "public")]
	Dova.JDK.java.util.stream.Node getChild(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
	}

	[JniSignatureAttribute("(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node;", "public")]
	Dova.JDK.java.util.stream.Node truncate(long arg0, long arg1, Dova.JDK.java.util.function.IntFunction arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/StreamShape;", "public")]
	Dova.JDK.java.util.stream.StreamShape getShape()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.StreamShape>(ret);
	}

	[JniSignatureAttribute("Ljava/util/stream/Node$Builder;", "public abstract static interface")]
	public partial interface Builder
		: IJavaObject
		, Dova.JDK.java.util.stream.Sink
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Builder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Node$Builder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "()Ljava/util/stream/Node;"));
		}

		[JniSignatureAttribute("()Ljava/util/stream/Node;", "public abstract")]
		Dova.JDK.java.util.stream.Node build()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}

		[JniSignatureAttribute("Ljava/util/stream/Node$Builder$OfDouble;", "public abstract static interface")]
		public partial interface OfDouble
			: IJavaObject
			, Dova.JDK.java.util.stream.Node.Builder
			, Dova.JDK.java.util.stream.Sink.OfDouble
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfDouble()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Node$Builder$OfDouble;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build_0", "()Ljava/util/stream/Node$OfDouble;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build_1", "()Ljava/util/stream/Node;"));
			}

			[JniSignatureAttribute("()Ljava/util/stream/Node$OfDouble;", "public abstract")]
			Dova.JDK.java.util.stream.Node.OfDouble build_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfDouble>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/stream/Node;", "public volatile")]
			Dova.JDK.java.util.stream.Node build_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/Node$Builder$OfLong;", "public abstract static interface")]
		public partial interface OfLong
			: IJavaObject
			, Dova.JDK.java.util.stream.Node.Builder
			, Dova.JDK.java.util.stream.Sink.OfLong
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfLong()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Node$Builder$OfLong;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build_0", "()Ljava/util/stream/Node$OfLong;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build_1", "()Ljava/util/stream/Node;"));
			}

			[JniSignatureAttribute("()Ljava/util/stream/Node$OfLong;", "public abstract")]
			Dova.JDK.java.util.stream.Node.OfLong build_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfLong>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/stream/Node;", "public volatile")]
			Dova.JDK.java.util.stream.Node build_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/Node$Builder$OfInt;", "public abstract static interface")]
		public partial interface OfInt
			: IJavaObject
			, Dova.JDK.java.util.stream.Node.Builder
			, Dova.JDK.java.util.stream.Sink.OfInt
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfInt()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Node$Builder$OfInt;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build_0", "()Ljava/util/stream/Node$OfInt;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build_1", "()Ljava/util/stream/Node;"));
			}

			[JniSignatureAttribute("()Ljava/util/stream/Node$OfInt;", "public abstract")]
			Dova.JDK.java.util.stream.Node.OfInt build_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfInt>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/stream/Node;", "public volatile")]
			Dova.JDK.java.util.stream.Node build_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
			}
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Node$OfDouble;", "public abstract static interface")]
	public partial interface OfDouble
		: IJavaObject
		, Dova.JDK.java.util.stream.Node.OfPrimitive
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OfDouble()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Node$OfDouble;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newArray_0", "(I)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newArray_1", "(I)[D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "([Ljava/lang/Double;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "([Ljava/lang/Object;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "truncate_0", "(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node$OfPrimitive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "truncate_1", "(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "truncate_2", "(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node$OfDouble;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShape", "()Ljava/util/stream/StreamShape;"));
		}

		[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
		Dova.JDK.java.lang.Object newArray_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)[D", "public")]
		JavaArray<double> newArray_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
		void forEach(Dova.JDK.java.util.function.Consumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("([Ljava/lang/Double;I)V", "public")]
		void copyInto(JavaArray<Dova.JDK.java.lang.Double> arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("([Ljava/lang/Object;I)V", "public volatile")]
		void copyInto(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node$OfPrimitive;", "public volatile")]
		Dova.JDK.java.util.stream.Node.OfPrimitive truncate_0(long arg0, long arg1, Dova.JDK.java.util.function.IntFunction arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfPrimitive>(ret);
		}

		[JniSignatureAttribute("(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node;", "public volatile")]
		Dova.JDK.java.util.stream.Node truncate_1(long arg0, long arg1, Dova.JDK.java.util.function.IntFunction arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}

		[JniSignatureAttribute("(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node$OfDouble;", "public")]
		Dova.JDK.java.util.stream.Node.OfDouble truncate_2(long arg0, long arg1, Dova.JDK.java.util.function.IntFunction arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfDouble>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/StreamShape;", "public")]
		Dova.JDK.java.util.stream.StreamShape getShape()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.StreamShape>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Node$OfLong;", "public abstract static interface")]
	public partial interface OfLong
		: IJavaObject
		, Dova.JDK.java.util.stream.Node.OfPrimitive
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OfLong()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Node$OfLong;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newArray_0", "(I)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newArray_1", "(I)[J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "([Ljava/lang/Long;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "([Ljava/lang/Object;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "truncate_0", "(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node$OfPrimitive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "truncate_1", "(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "truncate_2", "(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node$OfLong;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShape", "()Ljava/util/stream/StreamShape;"));
		}

		[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
		Dova.JDK.java.lang.Object newArray_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)[J", "public")]
		JavaArray<long> newArray_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
		void forEach(Dova.JDK.java.util.function.Consumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("([Ljava/lang/Long;I)V", "public")]
		void copyInto(JavaArray<Dova.JDK.java.lang.Long> arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("([Ljava/lang/Object;I)V", "public volatile")]
		void copyInto(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node$OfPrimitive;", "public volatile")]
		Dova.JDK.java.util.stream.Node.OfPrimitive truncate_0(long arg0, long arg1, Dova.JDK.java.util.function.IntFunction arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfPrimitive>(ret);
		}

		[JniSignatureAttribute("(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node;", "public volatile")]
		Dova.JDK.java.util.stream.Node truncate_1(long arg0, long arg1, Dova.JDK.java.util.function.IntFunction arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}

		[JniSignatureAttribute("(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node$OfLong;", "public")]
		Dova.JDK.java.util.stream.Node.OfLong truncate_2(long arg0, long arg1, Dova.JDK.java.util.function.IntFunction arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfLong>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/StreamShape;", "public")]
		Dova.JDK.java.util.stream.StreamShape getShape()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.StreamShape>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Node$OfInt;", "public abstract static interface")]
	public partial interface OfInt
		: IJavaObject
		, Dova.JDK.java.util.stream.Node.OfPrimitive
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OfInt()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Node$OfInt;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newArray_0", "(I)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newArray_1", "(I)[I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "([Ljava/lang/Integer;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "([Ljava/lang/Object;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "truncate_0", "(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node$OfPrimitive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "truncate_1", "(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "truncate_2", "(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node$OfInt;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShape", "()Ljava/util/stream/StreamShape;"));
		}

		[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
		Dova.JDK.java.lang.Object newArray_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)[I", "public")]
		JavaArray<int> newArray_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
		void forEach(Dova.JDK.java.util.function.Consumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("([Ljava/lang/Integer;I)V", "public")]
		void copyInto(JavaArray<Dova.JDK.java.lang.Integer> arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("([Ljava/lang/Object;I)V", "public volatile")]
		void copyInto(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node$OfPrimitive;", "public volatile")]
		Dova.JDK.java.util.stream.Node.OfPrimitive truncate_0(long arg0, long arg1, Dova.JDK.java.util.function.IntFunction arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfPrimitive>(ret);
		}

		[JniSignatureAttribute("(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node;", "public volatile")]
		Dova.JDK.java.util.stream.Node truncate_1(long arg0, long arg1, Dova.JDK.java.util.function.IntFunction arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}

		[JniSignatureAttribute("(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node$OfInt;", "public")]
		Dova.JDK.java.util.stream.Node.OfInt truncate_2(long arg0, long arg1, Dova.JDK.java.util.function.IntFunction arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node.OfInt>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/StreamShape;", "public")]
		Dova.JDK.java.util.stream.StreamShape getShape()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.StreamShape>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/stream/Node$OfPrimitive;", "public abstract static interface")]
	public partial interface OfPrimitive
		: IJavaObject
		, Dova.JDK.java.util.stream.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OfPrimitive()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Node$OfPrimitive;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newArray", "(I)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_0", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator_1", "()Ljava/util/Spliterator$OfPrimitive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyInto", "(Ljava/lang/Object;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asArray", "(Ljava/util/function/IntFunction;)[Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPrimitiveArray", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChild_0", "(I)Ljava/util/stream/Node$OfPrimitive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChild_1", "(I)Ljava/util/stream/Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "truncate_0", "(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "truncate_1", "(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node$OfPrimitive;"));
		}

		[JniSignatureAttribute("(I)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object newArray(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
		Dova.JDK.java.util.Spliterator spliterator_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator$OfPrimitive;", "public abstract")]
		Dova.JDK.java.lang.Object spliterator_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public abstract")]
		void forEach(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;I)V", "public abstract")]
		void copyInto(Dova.JDK.java.lang.Object arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/util/function/IntFunction;)[Ljava/lang/Object;", "public")]
		JavaArray<Dova.JDK.java.lang.Object> asArray(Dova.JDK.java.util.function.IntFunction arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object asPrimitiveArray()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)Ljava/util/stream/Node$OfPrimitive;", "public")]
		Dova.JDK.java.lang.Object getChild_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)Ljava/util/stream/Node;", "public volatile")]
		Dova.JDK.java.util.stream.Node getChild_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}

		[JniSignatureAttribute("(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node;", "public volatile")]
		Dova.JDK.java.util.stream.Node truncate_0(long arg0, long arg1, Dova.JDK.java.util.function.IntFunction arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Node>(ret);
		}

		[JniSignatureAttribute("(JJLjava/util/function/IntFunction;)Ljava/util/stream/Node$OfPrimitive;", "public abstract")]
		Dova.JDK.java.lang.Object truncate_1(long arg0, long arg1, Dova.JDK.java.util.function.IntFunction arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
