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

namespace Dova.JDK.jdk.javadoc.@internal.doclets.formats.html;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/AbstractOverviewIndexWriter;", "public abstract")]
public partial class AbstractOverviewIndexWriter
	: Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlDocletWriter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AbstractOverviewIndexWriter()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/javadoc/internal/doclets/formats/html/AbstractOverviewIndexWriter;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "AbstractOverviewIndexWriter", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addConfigurationTitle", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "buildOverviewIndexFile", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addOverviewHeader", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addOverviewComment", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addOverviewTags", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addIndex", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AbstractOverviewIndexWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)V", "public")]
	public AbstractOverviewIndexWriter(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/formats/html/AbstractOverviewIndexWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addConfigurationTitle(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "protected")]
	public void buildOverviewIndexFile(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addOverviewHeader(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addOverviewComment(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected")]
	public void addOverviewTags(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "protected abstract")]
	public void addIndex(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}
}