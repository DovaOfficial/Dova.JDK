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

namespace Dova.JDK.com.sun.tools.javac.parser;

[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Lexer;", "public abstract interface")]
public partial interface Lexer
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Lexer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/Lexer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "split", "()Lcom/sun/tools/javac/parser/Tokens$Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextToken", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "token", "()Lcom/sun/tools/javac/parser/Tokens$Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "token", "(I)Lcom/sun/tools/javac/parser/Tokens$Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "prevToken", "()Lcom/sun/tools/javac/parser/Tokens$Token;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLineMap", "()Lcom/sun/tools/javac/util/Position$LineMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "errPos", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "errPos", "()I"));
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/parser/Tokens$Token;", "public abstract")]
	Dova.JDK.com.sun.tools.javac.parser.Tokens.Token split()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Token>(ret);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void nextToken()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/parser/Tokens$Token;", "public abstract")]
	Dova.JDK.com.sun.tools.javac.parser.Tokens.Token token()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Token>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/tools/javac/parser/Tokens$Token;", "public abstract")]
	Dova.JDK.com.sun.tools.javac.parser.Tokens.Token token(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/parser/Tokens$Token;", "public abstract")]
	Dova.JDK.com.sun.tools.javac.parser.Tokens.Token prevToken()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Token>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Position$LineMap;", "public abstract")]
	Dova.JDK.com.sun.tools.javac.util.Position.LineMap getLineMap()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Position.LineMap>(ret);
	}

	[JniSignatureAttribute("(I)V", "public abstract")]
	void errPos(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int errPos()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}
}
