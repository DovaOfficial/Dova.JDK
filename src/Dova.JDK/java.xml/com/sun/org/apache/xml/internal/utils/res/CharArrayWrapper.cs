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

namespace Dova.JDK.com.sun.org.apache.xml.@internal.utils.res;

[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/utils/res/CharArrayWrapper;", "public")]
public partial class CharArrayWrapper
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CharArrayWrapper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/utils/res/CharArrayWrapper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "m_char", "[C"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CharArrayWrapper", "([C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLength", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getChar", "(I)C"));
	}

	[JniSignatureAttribute("[C", "private")]
	public JavaArray<char> m_char_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CharArrayWrapper(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([C)V", "public")]
	public CharArrayWrapper(JavaArray<char> arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xml/internal/utils/res/CharArrayWrapper;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()I", "public")]
	public int getLength()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(I)C", "public")]
	public char getChar(int arg0)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}
}
