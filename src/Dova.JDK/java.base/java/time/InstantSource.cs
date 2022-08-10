/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.java.time;

[JniSignatureAttribute("Ljava/time/InstantSource;", "public abstract interface")]
public partial interface InstantSource
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InstantSource()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/InstantSource;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "offset", "(Ljava/time/InstantSource;Ljava/time/Duration;)Ljava/time/InstantSource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "millis", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "system", "()Ljava/time/InstantSource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "fixed", "(Ljava/time/Instant;)Ljava/time/InstantSource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "instant", "()Ljava/time/Instant;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "tick", "(Ljava/time/InstantSource;Ljava/time/Duration;)Ljava/time/InstantSource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withZone", "(Ljava/time/ZoneId;)Ljava/time/Clock;"));
	}

	[JniSignatureAttribute("(Ljava/time/InstantSource;Ljava/time/Duration;)Ljava/time/InstantSource;", "public static")]
	static Dova.JDK.java.time.InstantSource offset(Dova.JDK.java.time.InstantSource arg0, Dova.JDK.java.time.Duration arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.InstantSource>(ret);
	}

	[JniSignatureAttribute("()J", "public")]
	long millis()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/time/InstantSource;", "public static")]
	static Dova.JDK.java.time.InstantSource system()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.InstantSource>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Instant;)Ljava/time/InstantSource;", "public static")]
	static Dova.JDK.java.time.InstantSource @fixed(Dova.JDK.java.time.Instant arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.InstantSource>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/Instant;", "public abstract")]
	Dova.JDK.java.time.Instant instant()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Instant>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/InstantSource;Ljava/time/Duration;)Ljava/time/InstantSource;", "public static")]
	static Dova.JDK.java.time.InstantSource tick(Dova.JDK.java.time.InstantSource arg0, Dova.JDK.java.time.Duration arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.InstantSource>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/ZoneId;)Ljava/time/Clock;", "public")]
	Dova.JDK.java.time.Clock withZone(Dova.JDK.java.time.ZoneId arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Clock>(ret);
	}
}
