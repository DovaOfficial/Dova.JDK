/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
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

[JniSignatureAttribute("Ljdk/jshell/ErroneousSnippet;", "public")]
public partial class ErroneousSnippet
	: Dova.JDK.jdk.jshell.Snippet
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ErroneousSnippet()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jshell/ErroneousSnippet;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "probableKind", "Ljdk/jshell/Snippet$Kind;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ErroneousSnippet", "(Ljdk/jshell/Key$ErroneousKey;Ljava/lang/String;Ljdk/jshell/Wrap;Ljdk/jshell/Snippet$Kind;Ljdk/jshell/Snippet$SubKind;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "probableKind", "()Ljdk/jshell/Snippet$Kind;"));
	}

	[JniSignatureAttribute("Ljdk/jshell/Snippet$Kind;", "private final")]
	public Dova.JDK.jdk.jshell.Snippet.Kind probableKind_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.Snippet.Kind>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ErroneousSnippet(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/jshell/Key$ErroneousKey;Ljava/lang/String;Ljdk/jshell/Wrap;Ljdk/jshell/Snippet$Kind;Ljdk/jshell/Snippet$SubKind;)V", "")]
	public ErroneousSnippet(Dova.JDK.jdk.jshell.Key.ErroneousKey arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.jshell.Wrap arg2, Dova.JDK.jdk.jshell.Snippet.Kind arg3, Dova.JDK.jdk.jshell.Snippet.SubKind arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jshell/ErroneousSnippet;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljdk/jshell/Snippet$Kind;", "public")]
	public Dova.JDK.jdk.jshell.Snippet.Kind probableKind()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.Snippet.Kind>(ret);
	}
}
