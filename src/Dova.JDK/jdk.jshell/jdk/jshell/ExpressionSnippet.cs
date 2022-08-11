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

namespace Dova.JDK.jdk.jshell;

[JniSignatureAttribute("Ljdk/jshell/ExpressionSnippet;", "public")]
public partial class ExpressionSnippet
	: Dova.JDK.jdk.jshell.Snippet
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ExpressionSnippet()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jshell/ExpressionSnippet;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/jshell/Key$ExpressionKey;Ljava/lang/String;Ljdk/jshell/Wrap;Ljava/lang/String;Ljdk/jshell/Snippet$SubKind;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "name", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "key_0", "()Ljdk/jshell/Key$ExpressionKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "key_1", "()Ljdk/jshell/Key;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeName", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ExpressionSnippet(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/jshell/Key$ExpressionKey;Ljava/lang/String;Ljdk/jshell/Wrap;Ljava/lang/String;Ljdk/jshell/Snippet$SubKind;)V", "")]
	public ExpressionSnippet(Dova.JDK.jdk.jshell.Key.ExpressionKey arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.jshell.Wrap arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.jdk.jshell.Snippet.SubKind arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jshell/ExpressionSnippet;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String name()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jshell/Key$ExpressionKey;", "")]
	public Dova.JDK.jdk.jshell.Key.ExpressionKey key_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.Key.ExpressionKey>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jshell/Key;", "volatile")]
	public Dova.JDK.jdk.jshell.Key key_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.Key>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String typeName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
