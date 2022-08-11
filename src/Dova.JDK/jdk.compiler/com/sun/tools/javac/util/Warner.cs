/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.tools.javac.util;

[JniSignatureAttribute("Lcom/sun/tools/javac/util/Warner;", "public")]
public partial class Warner
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Warner()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/util/Warner;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pos", "Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "warned", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nonSilentLintSet", "Ljava/util/EnumSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "silentLintSet", "Ljava/util/EnumSet;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pos", "()Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warn", "(Lcom/sun/tools/javac/code/Lint$LintCategory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasSilentLint", "(Lcom/sun/tools/javac/code/Lint$LintCategory;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "silentWarn", "(Lcom/sun/tools/javac/code/Lint$LintCategory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasLint", "(Lcom/sun/tools/javac/code/Lint$LintCategory;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasNonSilentLint", "(Lcom/sun/tools/javac/code/Lint$LintCategory;)Z"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition pos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool warned_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/EnumSet;", "private")]
	public Dova.JDK.java.util.EnumSet nonSilentLintSet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/EnumSet;", "private")]
	public Dova.JDK.java.util.EnumSet silentLintSet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Warner(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;)V", "public")]
	public Warner(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Warner() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/Warner;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void clear()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition pos()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Lint$LintCategory;)V", "public")]
	public void warn(Dova.JDK.com.sun.tools.javac.code.Lint.LintCategory arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Lint$LintCategory;)Z", "public")]
	public bool hasSilentLint(Dova.JDK.com.sun.tools.javac.code.Lint.LintCategory arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Lint$LintCategory;)V", "public")]
	public void silentWarn(Dova.JDK.com.sun.tools.javac.code.Lint.LintCategory arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Lint$LintCategory;)Z", "public")]
	public bool hasLint(Dova.JDK.com.sun.tools.javac.code.Lint.LintCategory arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Lint$LintCategory;)Z", "public")]
	public bool hasNonSilentLint(Dova.JDK.com.sun.tools.javac.code.Lint.LintCategory arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}
}
