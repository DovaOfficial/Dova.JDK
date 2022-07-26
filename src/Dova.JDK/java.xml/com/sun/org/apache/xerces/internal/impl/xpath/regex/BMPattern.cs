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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.regex;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/BMPattern;", "public")]
public partial class BMPattern
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BMPattern()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/BMPattern;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pattern", "[C"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shiftTable", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ignoreCase", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Ljava/lang/String;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "([CII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Ljava/text/CharacterIterator;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matchesIgnoreCase", "([CII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matchesIgnoreCase", "(Ljava/lang/String;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matchesIgnoreCase", "(Ljava/text/CharacterIterator;II)I"));
	}

	[JniSignatureAttribute("[C", "final")]
	public JavaArray<char> pattern_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "final")]
	public JavaArray<int> shiftTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "final")]
	public bool ignoreCase_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BMPattern(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)V", "public")]
	public BMPattern(Dova.JDK.java.lang.String arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;IZ)V", "public")]
	public BMPattern(Dova.JDK.java.lang.String arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xpath/regex/BMPattern;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;II)I", "public")]
	public int matches(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([CII)I", "public")]
	public int matches(JavaArray<char> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/text/CharacterIterator;II)I", "public")]
	public int matches(Dova.JDK.java.text.CharacterIterator arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([CII)I", "")]
	public int matchesIgnoreCase(JavaArray<char> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;II)I", "")]
	public int matchesIgnoreCase(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/text/CharacterIterator;II)I", "")]
	public int matchesIgnoreCase(Dova.JDK.java.text.CharacterIterator arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return ret;
	}
}
