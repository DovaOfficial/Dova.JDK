/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.tools.sjavac;

[JniSignatureAttribute("Lcom/sun/tools/sjavac/CopyFile;", "public")]
public partial class CopyFile
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.tools.sjavac.Transformer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CopyFile()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/sjavac/CopyFile;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lcom/sun/tools/sjavac/comp/CompilationService;Ljava/util/Map;Ljava/util/Set;Ljava/util/Map;Ljava/net/URI;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;IZI)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setExtra", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setExtra", "(Lcom/sun/tools/sjavac/options/Options;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CopyFile(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public CopyFile() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/sjavac/CopyFile;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/sjavac/comp/CompilationService;Ljava/util/Map;Ljava/util/Set;Ljava/util/Map;Ljava/net/URI;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;IZI)Z", "public")]
	public bool transform(Dova.JDK.com.sun.tools.sjavac.comp.CompilationService arg0, Dova.JDK.java.util.Map arg1, Dova.JDK.java.util.Set arg2, Dova.JDK.java.util.Map arg3, Dova.JDK.java.net.URI arg4, Dova.JDK.java.util.Map arg5, Dova.JDK.java.util.Map arg6, Dova.JDK.java.util.Map arg7, Dova.JDK.java.util.Map arg8, Dova.JDK.java.util.Map arg9, int arg10, bool arg11, int arg12)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setExtra(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/sjavac/options/Options;)V", "public")]
	public void setExtra(Dova.JDK.com.sun.tools.sjavac.options.Options arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}
}
