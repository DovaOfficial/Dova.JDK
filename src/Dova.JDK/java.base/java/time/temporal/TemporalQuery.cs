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

namespace Dova.JDK.java.time.temporal;

[JniSignatureAttribute("Ljava/time/temporal/TemporalQuery;", "public abstract interface")]
public partial interface TemporalQuery
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TemporalQuery()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/temporal/TemporalQuery;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "queryFrom", "(Ljava/time/temporal/TemporalAccessor;)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object queryFrom(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}
