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

namespace Dova.JDK.sun.management.counter;

[JniSignatureAttribute("Lsun/management/counter/LongArrayCounter;", "public abstract interface")]
public partial interface LongArrayCounter
	: IJavaObject
	, Dova.JDK.sun.management.counter.Counter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LongArrayCounter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/management/counter/LongArrayCounter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "longArrayValue", "()[J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "longAt", "(I)J"));
	}

	[JniSignatureAttribute("()[J", "public abstract")]
	JavaArray<long> longArrayValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("(I)J", "public abstract")]
	long longAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}
}
