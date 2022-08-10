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

namespace Dova.JDK.javax.script;

[JniSignatureAttribute("Ljavax/script/Compilable;", "public abstract interface")]
public partial interface Compilable
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Compilable()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/script/Compilable;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compile", "(Ljava/lang/String;)Ljavax/script/CompiledScript;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compile", "(Ljava/io/Reader;)Ljavax/script/CompiledScript;"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/script/CompiledScript;", "public abstract")]
	Dova.JDK.javax.script.CompiledScript compile(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.script.CompiledScript>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/Reader;)Ljavax/script/CompiledScript;", "public abstract")]
	Dova.JDK.javax.script.CompiledScript compile(Dova.JDK.java.io.Reader arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.script.CompiledScript>(ret);
	}
}
