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

namespace Dova.JDK.java.awt.datatransfer;

[JniSignatureAttribute("Ljava/awt/datatransfer/FlavorMap;", "public abstract interface")]
public partial interface FlavorMap
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FlavorMap()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/datatransfer/FlavorMap;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativesForFlavors", "([Ljava/awt/datatransfer/DataFlavor;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFlavorsForNatives", "([Ljava/lang/String;)Ljava/util/Map;"));
	}

	[JniSignatureAttribute("([Ljava/awt/datatransfer/DataFlavor;)Ljava/util/Map;", "public abstract")]
	Dova.JDK.java.util.Map getNativesForFlavors(JavaArray<Dova.JDK.java.awt.datatransfer.DataFlavor> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)Ljava/util/Map;", "public abstract")]
	Dova.JDK.java.util.Map getFlavorsForNatives(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}
}
