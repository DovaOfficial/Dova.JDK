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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/parser/XMLDTDScanner;", "public abstract interface")]
public partial interface XMLDTDScanner
	: IJavaObject
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLDTDSource
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLDTDContentModelSource
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMLDTDScanner()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/xni/parser/XMLDTDScanner;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInputSource", "(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLInputSource;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scanDTDInternalSubset", "(ZZZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scanDTDExternalSubset", "(Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skipDTD", "(Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLimitAnalyzer", "(Lcom/sun/org/apache/xerces/internal/utils/XMLLimitAnalyzer;)V"));
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLInputSource;)V", "public abstract")]
	void setInputSource(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLInputSource arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(ZZZ)Z", "public abstract")]
	bool scanDTDInternalSubset(bool arg0, bool arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Z)Z", "public abstract")]
	bool scanDTDExternalSubset(bool arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Z)Z", "public abstract")]
	bool skipDTD(bool arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/utils/XMLLimitAnalyzer;)V", "public abstract")]
	void setLimitAnalyzer(Dova.JDK.com.sun.org.apache.xerces.@internal.utils.XMLLimitAnalyzer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}
}
