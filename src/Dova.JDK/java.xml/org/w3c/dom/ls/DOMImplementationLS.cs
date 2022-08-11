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

namespace Dova.JDK.org.w3c.dom.ls;

[JniSignatureAttribute("Lorg/w3c/dom/ls/DOMImplementationLS;", "public abstract interface")]
public partial interface DOMImplementationLS
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DOMImplementationLS()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/w3c/dom/ls/DOMImplementationLS;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODE_SYNCHRONOUS", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODE_ASYNCHRONOUS", "S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createLSParser", "(SLjava/lang/String;)Lorg/w3c/dom/ls/LSParser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createLSSerializer", "()Lorg/w3c/dom/ls/LSSerializer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createLSInput", "()Lorg/w3c/dom/ls/LSInput;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createLSOutput", "()Lorg/w3c/dom/ls/LSOutput;"));
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MODE_SYNCHRONOUS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MODE_ASYNCHRONOUS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("(SLjava/lang/String;)Lorg/w3c/dom/ls/LSParser;", "public abstract")]
	Dova.JDK.org.w3c.dom.ls.LSParser createLSParser(short arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.ls.LSParser>(ret);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/ls/LSSerializer;", "public abstract")]
	Dova.JDK.org.w3c.dom.ls.LSSerializer createLSSerializer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.ls.LSSerializer>(ret);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/ls/LSInput;", "public abstract")]
	Dova.JDK.org.w3c.dom.ls.LSInput createLSInput()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.ls.LSInput>(ret);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/ls/LSOutput;", "public abstract")]
	Dova.JDK.org.w3c.dom.ls.LSOutput createLSOutput()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.ls.LSOutput>(ret);
	}
}
