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

[JniSignatureAttribute("Ljava/util/PriorityQueue;", "public")]
public partial class PriorityQueue
	: Dova.JDK.java.util.AbstractQueue
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PriorityQueue()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/PriorityQueue;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DEFAULT_INITIAL_CAPACITY", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "queue", "[Ljava/lang/Object;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "size", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "comparator", "Ljava/util/Comparator;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "modCount", "I"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "PriorityQueue", "(ILjava/util/Comparator;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "PriorityQueue", "(Ljava/util/Collection;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "PriorityQueue", "(Ljava/util/PriorityQueue;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "PriorityQueue", "(Ljava/util/SortedSet;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "PriorityQueue", "()V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "PriorityQueue", "(I)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "PriorityQueue", "(Ljava/util/Comparator;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "add", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "remove", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "indexOf", "(Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "clear", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "size", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toArray", "()[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "iterator", "()Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "contains", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "spliterator", "()Ljava/util/Spliterator;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "forEach", "(Ljava/util/function/Consumer;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "poll", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "peek", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "grow", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removeIf", "(Ljava/util/function/Predicate;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "nBits", "(I)[J"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setBit", "([JI)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isClear", "([JI)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removeAll", "(Ljava/util/Collection;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "retainAll", "(Ljava/util/Collection;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "comparator", "()Ljava/util/Comparator;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "bulkRemove", "(Ljava/util/function/Predicate;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "offer", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "heapify", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "initElementsFromCollection", "(Ljava/util/Collection;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "initFromPriorityQueue", "(Ljava/util/PriorityQueue;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "initFromCollection", "(Ljava/util/Collection;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "ensureNonEmpty", "([Ljava/lang/Object;)[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "siftUp", "(ILjava/lang/Object;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removeAt", "(I)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "siftDownComparable", "(ILjava/lang/Object;[Ljava/lang/Object;I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "siftDownUsingComparator", "(ILjava/lang/Object;[Ljava/lang/Object;ILjava/util/Comparator;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "siftDown", "(ILjava/lang/Object;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "siftUpUsingComparator", "(ILjava/lang/Object;[Ljava/lang/Object;Ljava/util/Comparator;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "siftUpComparable", "(ILjava/lang/Object;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removeEq", "(Ljava/lang/Object;)V"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DEFAULT_INITIAL_CAPACITY_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("[Ljava/lang/Object;", "transient")]
	public JavaArray<Dova.JDK.java.lang.Object> queue_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "")]
	public int size_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("Ljava/util/Comparator;", "private final")]
	public Dova.JDK.java.util.Comparator comparator_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "transient")]
	public int modCount_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PriorityQueue(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ILjava/util/Comparator;)V", "public")]
	public PriorityQueue(int arg0, Dova.JDK.java.util.Comparator arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)V", "public")]
	public PriorityQueue(Dova.JDK.java.util.Collection arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/util/PriorityQueue;)V", "public")]
	public PriorityQueue(Dova.JDK.java.util.PriorityQueue arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/util/SortedSet;)V", "public")]
	public PriorityQueue(Dova.JDK.java.util.SortedSet arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[3], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public PriorityQueue() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[4]))
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public PriorityQueue(int arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[5], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/util/Comparator;)V", "public")]
	public PriorityQueue(Dova.JDK.java.util.Comparator arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[6], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/PriorityQueue;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool add(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool remove(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)I", "private")]
	public int indexOf(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void clear()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()I", "public")]
	public int size()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)[Ljava/lang/Object;", "public")]
	public JavaArray<Dova.JDK.java.lang.Object> toArray(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/Object;", "public")]
	public JavaArray<Dova.JDK.java.lang.Object> toArray()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
	public Dova.JDK.java.util.Iterator iterator()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool contains(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Spliterator;", "public final")]
	public Dova.JDK.java.util.Spliterator spliterator()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private")]
	public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
	public void forEach(Dova.JDK.java.util.function.Consumer arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object poll()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object peek()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void grow(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;)Z", "public")]
	public bool removeIf(Dova.JDK.java.util.function.Predicate arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)[J", "private static")]
	public static JavaArray<long> nBits(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("([JI)V", "private static")]
	public static void setBit(JavaArray<long> arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
	}

	[JniSignatureAttribute("([JI)Z", "private static")]
	public static bool isClear(JavaArray<long> arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)Z", "public")]
	public bool removeAll(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)Z", "public")]
	public bool retainAll(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Comparator;", "public")]
	public Dova.JDK.java.util.Comparator comparator()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;)Z", "private")]
	public bool bulkRemove(Dova.JDK.java.util.function.Predicate arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool offer(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void heapify()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25]);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)V", "private")]
	public void initElementsFromCollection(Dova.JDK.java.util.Collection arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/PriorityQueue;)V", "private")]
	public void initFromPriorityQueue(Dova.JDK.java.util.PriorityQueue arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)V", "private")]
	public void initFromCollection(Dova.JDK.java.util.Collection arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)[Ljava/lang/Object;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.Object> ensureNonEmpty(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/Object;)V", "private")]
	public void siftUp(int arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object removeAt(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/Object;[Ljava/lang/Object;I)V", "private static")]
	public static void siftDownComparable(int arg0, Dova.JDK.java.lang.Object arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, int arg3)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILjava/lang/Object;[Ljava/lang/Object;ILjava/util/Comparator;)V", "private static")]
	public static void siftDownUsingComparator(int arg0, Dova.JDK.java.lang.Object arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, int arg3, Dova.JDK.java.util.Comparator arg4)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[33], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(ILjava/lang/Object;)V", "private")]
	public void siftDown(int arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/lang/Object;[Ljava/lang/Object;Ljava/util/Comparator;)V", "private static")]
	public static void siftUpUsingComparator(int arg0, Dova.JDK.java.lang.Object arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, Dova.JDK.java.util.Comparator arg3)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILjava/lang/Object;[Ljava/lang/Object;)V", "private static")]
	public static void siftUpComparable(int arg0, Dova.JDK.java.lang.Object arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[36], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "")]
	public void removeEq(Dova.JDK.java.lang.Object arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("Ljava/util/PriorityQueue$Itr;", "private final")]
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/PriorityQueue$Itr;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "cursor", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "lastRet", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "forgetMeNot", "Ljava/util/ArrayDeque;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "lastRetElt", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "expectedModCount", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "this$0", "Ljava/util/PriorityQueue;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Itr", "(Ljava/util/PriorityQueue;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "remove", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "hasNext", "()Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "next", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("I", "private")]
		public int cursor_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("I", "private")]
		public int lastRet_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("Ljava/util/ArrayDeque;", "private")]
		public Dova.JDK.java.util.ArrayDeque forgetMeNot_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayDeque>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "private")]
		public Dova.JDK.java.lang.Object lastRetElt_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "private")]
		public int expectedModCount_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("Ljava/util/PriorityQueue;", "final")]
		public Dova.JDK.java.util.PriorityQueue this0_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.PriorityQueue>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Itr(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/PriorityQueue;)V", "")]
		public Itr(Dova.JDK.java.util.PriorityQueue arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/PriorityQueue$Itr;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void remove()
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasNext()
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object next()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/PriorityQueue$PriorityQueueSpliterator;", "final")]
	public partial class PriorityQueueSpliterator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.Spliterator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PriorityQueueSpliterator()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/PriorityQueue$PriorityQueueSpliterator;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "index", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fence", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "expectedModCount", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "this$0", "Ljava/util/PriorityQueue;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "PriorityQueueSpliterator", "(Ljava/util/PriorityQueue;III)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "forEachRemaining", "(Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "characteristics", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "tryAdvance", "(Ljava/util/function/Consumer;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_0", "()Ljava/util/Spliterator;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trySplit_1", "()Ljava/util/PriorityQueue$PriorityQueueSpliterator;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "estimateSize", "()J"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getFence", "()I"));
		}

		[JniSignatureAttribute("I", "private")]
		public int index_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("I", "private")]
		public int fence_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("I", "private")]
		public int expectedModCount_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("Ljava/util/PriorityQueue;", "final")]
		public Dova.JDK.java.util.PriorityQueue this0_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.PriorityQueue>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PriorityQueueSpliterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/PriorityQueue;III)V", "")]
		public PriorityQueueSpliterator(Dova.JDK.java.util.PriorityQueue arg0, int arg1, int arg2, int arg3) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/PriorityQueue$PriorityQueueSpliterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
		public void forEachRemaining(Dova.JDK.java.util.function.Consumer arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()I", "public")]
		public int characteristics()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)Z", "public")]
		public bool tryAdvance(Dova.JDK.java.util.function.Consumer arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Spliterator;", "public volatile")]
		public Dova.JDK.java.util.Spliterator trySplit_0()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Spliterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/PriorityQueue$PriorityQueueSpliterator;", "public")]
		public Dova.JDK.java.util.PriorityQueue.PriorityQueueSpliterator trySplit_1()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.PriorityQueue.PriorityQueueSpliterator>(ret);
		}

		[JniSignatureAttribute("()J", "public")]
		public long estimateSize()
		{
			var ret = DovaJvm.Vm.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()I", "private")]
		public int getFence()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}
	}
}