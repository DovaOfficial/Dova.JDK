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

namespace Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlDocument;", "public")]
public partial class HtmlDocument
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HtmlDocument()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlDocument;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "docType", "Ljdk/javadoc/internal/doclets/formats/html/markup/DocType;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "docContent", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "HtmlDocument", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "write", "(Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "write", "(Ljava/io/Writer;)V"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/DocType;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.DocType docType_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.DocType>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content docContent_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HtmlDocument(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public")]
	public HtmlDocument(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlDocument;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;)V", "public")]
	public void write(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFile arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/Writer;)V", "private")]
	public void write(Dova.JDK.java.io.Writer arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}
}