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

namespace Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/ElementListWriter;", "public")]
public partial class ElementListWriter
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ElementListWriter()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/ElementListWriter;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "configuration", "Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "options", "Ljdk/javadoc/internal/doclets/toolkit/BaseOptions;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "utils", "Ljdk/javadoc/internal/doclets/toolkit/util/Utils;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "file", "Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ElementListWriter", "(Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "generate", "(Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "generateElementListFile", "(Ljdk/javadoc/doclet/DocletEnvironment;)V"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseConfiguration configuration_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseConfiguration>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/BaseOptions;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseOptions options_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseOptions>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils utils_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFile file_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFile>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ElementListWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;)V", "public")]
	public ElementListWriter(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseConfiguration arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/ElementListWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;)V", "public static")]
	public static void generate(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseConfiguration arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/doclet/DocletEnvironment;)V", "protected")]
	public void generateElementListFile(Dova.JDK.jdk.javadoc.doclet.DocletEnvironment arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}