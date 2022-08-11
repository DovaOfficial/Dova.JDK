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

namespace Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocLink;", "public")]
public partial class DocLink
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DocLink()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/DocLink;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "path", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fragment", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isEmpty", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fragment", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/DocLink;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "relativizeAgainst", "(Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)Ljdk/javadoc/internal/doclets/toolkit/util/DocLink;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAbsoluteURL", "(Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withFragment", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/DocLink;"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath path_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String fragment_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DocLink(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;Ljava/lang/String;)V", "public")]
	public DocLink(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)V", "public")]
	public DocLink(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public DocLink(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/DocLink;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private static")]
	public static bool isEmpty(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/DocLink;", "public static")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocLink fragment(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocLink>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)Ljdk/javadoc/internal/doclets/toolkit/util/DocLink;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocLink relativizeAgainst(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocLink>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)Z", "private")]
	public bool isAbsoluteURL(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/DocLink;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocLink withFragment(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocLink>(ret);
	}
}
