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

namespace Dova.JDK.com.sun.org.apache.xpath.@internal.objects;

[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/objects/LessThanOrEqualComparator;", "")]
public partial class LessThanOrEqualComparator
	: Dova.JDK.com.sun.org.apache.xpath.@internal.objects.Comparator
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LessThanOrEqualComparator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xpath/internal/objects/LessThanOrEqualComparator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareStrings", "(Lcom/sun/org/apache/xml/internal/utils/XMLString;Lcom/sun/org/apache/xml/internal/utils/XMLString;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareNumbers", "(DD)Z"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LessThanOrEqualComparator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public LessThanOrEqualComparator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xpath/internal/objects/LessThanOrEqualComparator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/utils/XMLString;Lcom/sun/org/apache/xml/internal/utils/XMLString;)Z", "")]
	public bool compareStrings(Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString arg0, Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(DD)Z", "")]
	public bool compareNumbers(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}
}
