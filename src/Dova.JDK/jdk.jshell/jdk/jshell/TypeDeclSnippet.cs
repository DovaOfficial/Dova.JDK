/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.jshell;

[JniSignatureAttribute("Ljdk/jshell/TypeDeclSnippet;", "public")]
public partial class TypeDeclSnippet
	: Dova.JDK.jdk.jshell.DeclarationSnippet
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TypeDeclSnippet()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/jshell/TypeDeclSnippet;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "TypeDeclSnippet", "(Ljdk/jshell/Key$TypeDeclKey;Ljava/lang/String;Ljdk/jshell/Wrap;Ljava/lang/String;Ljdk/jshell/Snippet$SubKind;Ljdk/jshell/Wrap;Ljava/util/Collection;Ljava/util/Collection;Ljdk/jshell/DiagList;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "key_0", "()Ljdk/jshell/Key$TypeDeclKey;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "key_1", "()Ljdk/jshell/Key;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TypeDeclSnippet(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/jshell/Key$TypeDeclKey;Ljava/lang/String;Ljdk/jshell/Wrap;Ljava/lang/String;Ljdk/jshell/Snippet$SubKind;Ljdk/jshell/Wrap;Ljava/util/Collection;Ljava/util/Collection;Ljdk/jshell/DiagList;)V", "")]
	public TypeDeclSnippet(Dova.JDK.jdk.jshell.Key.TypeDeclKey arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.jshell.Wrap arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.jdk.jshell.Snippet.SubKind arg4, Dova.JDK.jdk.jshell.Wrap arg5, Dova.JDK.java.util.Collection arg6, Dova.JDK.java.util.Collection arg7, Dova.JDK.jdk.jshell.DiagList arg8) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jshell/TypeDeclSnippet;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljdk/jshell/Key$TypeDeclKey;", "")]
	public Dova.JDK.jdk.jshell.Key.TypeDeclKey key_0()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.Key.TypeDeclKey>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jshell/Key;", "volatile")]
	public Dova.JDK.jdk.jshell.Key key_1()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.Key>(ret);
	}
}
