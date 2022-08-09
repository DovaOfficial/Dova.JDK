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

namespace Dova.JDK.jdk.@internal.org.jline.reader.impl;

[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/DefaultHighlighter;", "public")]
public partial class DefaultHighlighter
	: Dova.JDK.java.lang.Object
	, Dova.JDK.jdk.@internal.org.jline.reader.Highlighter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DefaultHighlighter()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/org/jline/reader/impl/DefaultHighlighter;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "errorPattern", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "errorIndex", "I"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DefaultHighlighter", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setErrorIndex", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "highlight", "(Ljdk/internal/org/jline/reader/LineReader;Ljava/lang/String;)Ljdk/internal/org/jline/utils/AttributedString;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setErrorPattern", "(Ljava/util/regex/Pattern;)V"));
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "protected")]
	public Dova.JDK.java.util.regex.Pattern errorPattern_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "protected")]
	public int errorIndex_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DefaultHighlighter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DefaultHighlighter() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/reader/impl/DefaultHighlighter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)V", "public")]
	public void setErrorIndex(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/LineReader;Ljava/lang/String;)Ljdk/internal/org/jline/utils/AttributedString;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedString highlight(Dova.JDK.jdk.@internal.org.jline.reader.LineReader arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/regex/Pattern;)V", "public")]
	public void setErrorPattern(Dova.JDK.java.util.regex.Pattern arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}
}