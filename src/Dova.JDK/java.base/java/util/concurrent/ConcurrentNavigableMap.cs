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

namespace Dova.JDK.java.util.concurrent;

[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentNavigableMap;", "public abstract interface")]
public partial interface ConcurrentNavigableMap
	: IJavaObject
	, Dova.JDK.java.util.concurrent.ConcurrentMap
	, Dova.JDK.java.util.NavigableMap
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ConcurrentNavigableMap()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ConcurrentNavigableMap;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "keySet_0", "()Ljava/util/NavigableSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "keySet_1", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "descendingMap_0", "()Ljava/util/NavigableMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "descendingMap_1", "()Ljava/util/concurrent/ConcurrentNavigableMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "navigableKeySet", "()Ljava/util/NavigableSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "descendingKeySet", "()Ljava/util/NavigableSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "subMap_0", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "subMap_1", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "subMap_0", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "subMap_1", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "headMap_0", "(Ljava/lang/Object;)Ljava/util/SortedMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "headMap_1", "(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "headMap_0", "(Ljava/lang/Object;Z)Ljava/util/NavigableMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "headMap_1", "(Ljava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "tailMap_0", "(Ljava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "tailMap_1", "(Ljava/lang/Object;Z)Ljava/util/NavigableMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "tailMap_0", "(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "tailMap_1", "(Ljava/lang/Object;)Ljava/util/SortedMap;"));
	}

	[JniSignatureAttribute("()Ljava/util/NavigableSet;", "public abstract")]
	Dova.JDK.java.util.NavigableSet keySet_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.NavigableSet>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public volatile")]
	Dova.JDK.java.util.Set keySet_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/NavigableMap;", "public volatile")]
	Dova.JDK.java.util.NavigableMap descendingMap_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.NavigableMap>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/ConcurrentNavigableMap;", "public abstract")]
	Dova.JDK.java.util.concurrent.ConcurrentNavigableMap descendingMap_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentNavigableMap>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/NavigableSet;", "public abstract")]
	Dova.JDK.java.util.NavigableSet navigableKeySet()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.NavigableSet>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/NavigableSet;", "public abstract")]
	Dova.JDK.java.util.NavigableSet descendingKeySet()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.NavigableSet>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;", "public volatile")]
	Dova.JDK.java.util.SortedMap subMap_0(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedMap>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;", "public abstract")]
	Dova.JDK.java.util.concurrent.ConcurrentNavigableMap subMap_1(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentNavigableMap>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableMap;", "public volatile")]
	Dova.JDK.java.util.NavigableMap subMap_0(Dova.JDK.java.lang.Object arg0, bool arg1, Dova.JDK.java.lang.Object arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.NavigableMap>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;", "public abstract")]
	Dova.JDK.java.util.concurrent.ConcurrentNavigableMap subMap_1(Dova.JDK.java.lang.Object arg0, bool arg1, Dova.JDK.java.lang.Object arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentNavigableMap>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/util/SortedMap;", "public volatile")]
	Dova.JDK.java.util.SortedMap headMap_0(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedMap>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;", "public abstract")]
	Dova.JDK.java.util.concurrent.ConcurrentNavigableMap headMap_1(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentNavigableMap>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Z)Ljava/util/NavigableMap;", "public volatile")]
	Dova.JDK.java.util.NavigableMap headMap_0(Dova.JDK.java.lang.Object arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.NavigableMap>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;", "public abstract")]
	Dova.JDK.java.util.concurrent.ConcurrentNavigableMap headMap_1(Dova.JDK.java.lang.Object arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentNavigableMap>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;", "public abstract")]
	Dova.JDK.java.util.concurrent.ConcurrentNavigableMap tailMap_0(Dova.JDK.java.lang.Object arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentNavigableMap>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Z)Ljava/util/NavigableMap;", "public volatile")]
	Dova.JDK.java.util.NavigableMap tailMap_1(Dova.JDK.java.lang.Object arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.NavigableMap>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;", "public abstract")]
	Dova.JDK.java.util.concurrent.ConcurrentNavigableMap tailMap_0(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentNavigableMap>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/util/SortedMap;", "public volatile")]
	Dova.JDK.java.util.SortedMap tailMap_1(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedMap>(ret);
	}
}
