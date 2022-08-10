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

namespace Dova.JDK.javax.naming;

[JniSignatureAttribute("Ljavax/naming/CommunicationException;", "public")]
public partial class CommunicationException
	: Dova.JDK.javax.naming.NamingException
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CommunicationException()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/naming/CommunicationException;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CommunicationException", "(Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CommunicationException", "()V"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CommunicationException(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public CommunicationException(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public CommunicationException() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/naming/CommunicationException;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
}
