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

namespace Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.snippet;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/taglets/snippet/AddStyle;", "public final")]
public partial class AddStyle
	: Dova.JDK.java.lang.Object
	, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.snippet.Action
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AddStyle()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/taglets/snippet/AddStyle;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "style", "Ljdk/javadoc/internal/doclets/toolkit/taglets/snippet/Style;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "pattern", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "text", "Ljdk/javadoc/internal/doclets/toolkit/taglets/snippet/StyledText;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "AddStyle", "(Ljdk/javadoc/internal/doclets/toolkit/taglets/snippet/Style;Ljava/util/regex/Pattern;Ljdk/javadoc/internal/doclets/toolkit/taglets/snippet/StyledText;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "perform", "()V"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/taglets/snippet/Style;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.snippet.Style style_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.snippet.Style>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private final")]
	public Dova.JDK.java.util.regex.Pattern pattern_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/taglets/snippet/StyledText;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.snippet.StyledText text_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.snippet.StyledText>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AddStyle(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/taglets/snippet/Style;Ljava/util/regex/Pattern;Ljdk/javadoc/internal/doclets/toolkit/taglets/snippet/StyledText;)V", "public")]
	public AddStyle(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.snippet.Style arg0, Dova.JDK.java.util.regex.Pattern arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.snippet.StyledText arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/taglets/snippet/AddStyle;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void perform()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}
}
