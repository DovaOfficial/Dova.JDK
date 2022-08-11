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

namespace Dova.JDK.java.util.concurrent;

[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentLinkedQueue;", "public")]
public partial class ConcurrentLinkedQueue
	: Dova.JDK.java.util.AbstractQueue
	, Dova.JDK.java.util.Queue
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ConcurrentLinkedQueue()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ConcurrentLinkedQueue;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "head", "Ljava/util/concurrent/ConcurrentLinkedQueue$Node;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tail", "Ljava/util/concurrent/ConcurrentLinkedQueue$Node;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_HOPS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HEAD", "Ljava/lang/invoke/VarHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TAIL", "Ljava/lang/invoke/VarHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM", "Ljava/lang/invoke/VarHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEXT", "Ljava/lang/invoke/VarHandle;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Collection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toArray", "()[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "spliterator", "()Ljava/util/Spliterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAll", "(Ljava/util/Collection;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "first", "()Ljava/util/concurrent/ConcurrentLinkedQueue$Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEach", "(Ljava/util/function/Consumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "poll", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "peek", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeIf", "(Ljava/util/function/Predicate;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeAll", "(Ljava/util/Collection;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "retainAll", "(Ljava/util/Collection;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "succ", "(Ljava/util/concurrent/ConcurrentLinkedQueue$Node;)Ljava/util/concurrent/ConcurrentLinkedQueue$Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bulkRemove", "(Ljava/util/function/Predicate;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "offer", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryCasSuccessor", "(Ljava/util/concurrent/ConcurrentLinkedQueue$Node;Ljava/util/concurrent/ConcurrentLinkedQueue$Node;Ljava/util/concurrent/ConcurrentLinkedQueue$Node;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateHead", "(Ljava/util/concurrent/ConcurrentLinkedQueue$Node;Ljava/util/concurrent/ConcurrentLinkedQueue$Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skipDeadNodes", "(Ljava/util/concurrent/ConcurrentLinkedQueue$Node;Ljava/util/concurrent/ConcurrentLinkedQueue$Node;Ljava/util/concurrent/ConcurrentLinkedQueue$Node;Ljava/util/concurrent/ConcurrentLinkedQueue$Node;)Ljava/util/concurrent/ConcurrentLinkedQueue$Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toArrayInternal", "([Ljava/lang/Object;)[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachFrom", "(Ljava/util/function/Consumer;Ljava/util/concurrent/ConcurrentLinkedQueue$Node;)V"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
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

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentLinkedQueue$Node;", "transient volatile")]
	public Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node head_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentLinkedQueue$Node;", "private transient volatile")]
	public Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node tail_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MAX_HOPS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.VarHandle HEAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.VarHandle TAIL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandle;", "static final")]
	public static Dova.JDK.java.lang.invoke.VarHandle ITEM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandle;", "static final")]
	public static Dova.JDK.java.lang.invoke.VarHandle NEXT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ConcurrentLinkedQueue(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ConcurrentLinkedQueue() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)V", "public")]
	public ConcurrentLinkedQueue(Dova.JDK.java.util.Collection arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/concurrent/ConcurrentLinkedQueue;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool add(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool remove(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void clear()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isEmpty()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int size()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/lang/Object;", "public")]
	public JavaArray<Dova.JDK.java.lang.Object> toArray()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)[Ljava/lang/Object;", "public")]
	public JavaArray<Dova.JDK.java.lang.Object> toArray(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
	public Dova.JDK.java.util.Iterator iterator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool contains(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Spliterator;", "public")]
	public Dova.JDK.java.util.Spliterator spliterator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)Z", "public")]
	public bool addAll(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/ConcurrentLinkedQueue$Node;", "")]
	public Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node first()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private")]
	public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
	public void forEach(Dova.JDK.java.util.function.Consumer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object poll()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object peek()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;)Z", "public")]
	public bool removeIf(Dova.JDK.java.util.function.Predicate arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)Z", "public")]
	public bool removeAll(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)Z", "public")]
	public bool retainAll(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ConcurrentLinkedQueue$Node;)Ljava/util/concurrent/ConcurrentLinkedQueue$Node;", "final")]
	public Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node succ(Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;)Z", "private")]
	public bool bulkRemove(Dova.JDK.java.util.function.Predicate arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool offer(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ConcurrentLinkedQueue$Node;Ljava/util/concurrent/ConcurrentLinkedQueue$Node;Ljava/util/concurrent/ConcurrentLinkedQueue$Node;)Z", "private")]
	public bool tryCasSuccessor(Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node arg0, Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node arg1, Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ConcurrentLinkedQueue$Node;Ljava/util/concurrent/ConcurrentLinkedQueue$Node;)V", "final")]
	public void updateHead(Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node arg0, Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ConcurrentLinkedQueue$Node;Ljava/util/concurrent/ConcurrentLinkedQueue$Node;Ljava/util/concurrent/ConcurrentLinkedQueue$Node;Ljava/util/concurrent/ConcurrentLinkedQueue$Node;)Ljava/util/concurrent/ConcurrentLinkedQueue$Node;", "private")]
	public Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node skipDeadNodes(Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node arg0, Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node arg1, Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node arg2, Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)[Ljava/lang/Object;", "private")]
	public JavaArray<Dova.JDK.java.lang.Object> toArrayInternal(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Consumer;Ljava/util/concurrent/ConcurrentLinkedQueue$Node;)V", "")]
	public void forEachFrom(Dova.JDK.java.util.function.Consumer arg0, Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentLinkedQueue$Node;", "static final")]
	public partial class Node
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Node()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ConcurrentLinkedQueue$Node;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "item", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "next", "Ljava/util/concurrent/ConcurrentLinkedQueue$Node;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendRelaxed", "(Ljava/util/concurrent/ConcurrentLinkedQueue$Node;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "casItem", "(Ljava/lang/Object;Ljava/lang/Object;)Z"));
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "volatile")]
		public Dova.JDK.java.lang.Object item_Property
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

		[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentLinkedQueue$Node;", "volatile")]
		public Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node next_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Node(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "")]
		public Node(Dova.JDK.java.lang.Object arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Node() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/ConcurrentLinkedQueue$Node;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/concurrent/ConcurrentLinkedQueue$Node;)V", "")]
		public void appendRelaxed(Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public bool casItem(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentLinkedQueue$Itr;", "private")]
	public partial class Itr
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.Iterator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Itr()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ConcurrentLinkedQueue$Itr;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextNode", "Ljava/util/concurrent/ConcurrentLinkedQueue$Node;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextItem", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastRet", "Ljava/util/concurrent/ConcurrentLinkedQueue$Node;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljava/util/concurrent/ConcurrentLinkedQueue;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/ConcurrentLinkedQueue;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasNext", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentLinkedQueue$Node;", "private")]
		public Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node nextNode_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "private")]
		public Dova.JDK.java.lang.Object nextItem_Property
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

		[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentLinkedQueue$Node;", "private")]
		public Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node lastRet_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentLinkedQueue;", "final")]
		public Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Itr(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/ConcurrentLinkedQueue;)V", "")]
		public Itr(Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/ConcurrentLinkedQueue$Itr;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void remove()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasNext()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object next()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentLinkedQueue$CLQSpliterator;", "final")]
	public partial class CLQSpliterator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.Spliterator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CLQSpliterator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ConcurrentLinkedQueue$CLQSpliterator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_BATCH", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "current", "Ljava/util/concurrent/ConcurrentLinkedQueue$Node;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "batch", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exhausted", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljava/util/concurrent/ConcurrentLinkedQueue;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/ConcurrentLinkedQueue;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forEachRemaining", "(Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "characteristics", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "current", "()Ljava/util/concurrent/ConcurrentLinkedQueue$Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAdvance", "(Ljava/util/function/Consumer;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trySplit", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "estimateSize", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCurrent", "(Ljava/util/concurrent/ConcurrentLinkedQueue$Node;)V"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int MAX_BATCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentLinkedQueue$Node;", "")]
		public Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node current_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int batch_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool exhausted_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentLinkedQueue;", "final")]
		public Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CLQSpliterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/ConcurrentLinkedQueue;)V", "")]
		public CLQSpliterator(Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/ConcurrentLinkedQueue$CLQSpliterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
		public void forEachRemaining(Dova.JDK.java.util.function.Consumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()I", "public")]
		public int characteristics()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/ConcurrentLinkedQueue$Node;", "private")]
		public Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node current()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)Z", "public")]
		public bool tryAdvance(Dova.JDK.java.util.function.Consumer arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public")]
		public Dova.JDK.java.util.Spliterator trySplit()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("()J", "public")]
		public long estimateSize()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/ConcurrentLinkedQueue$Node;)V", "private")]
		public void setCurrent(Dova.JDK.java.util.concurrent.ConcurrentLinkedQueue.Node arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}
	}
}
