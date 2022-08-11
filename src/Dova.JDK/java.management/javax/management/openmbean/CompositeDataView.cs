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

namespace Dova.JDK.javax.management.openmbean;

[JniSignatureAttribute("Ljavax/management/openmbean/CompositeDataView;", "public abstract interface")]
public partial interface CompositeDataView
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CompositeDataView()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/openmbean/CompositeDataView;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toCompositeData", "(Ljavax/management/openmbean/CompositeType;)Ljavax/management/openmbean/CompositeData;"));
	}

	[JniSignatureAttribute("(Ljavax/management/openmbean/CompositeType;)Ljavax/management/openmbean/CompositeData;", "public abstract")]
	Dova.JDK.javax.management.openmbean.CompositeData toCompositeData(Dova.JDK.javax.management.openmbean.CompositeType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.openmbean.CompositeData>(ret);
	}
}
