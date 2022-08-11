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

namespace Dova.JDK.javax.script;

[JniSignatureAttribute("Ljavax/script/ScriptContext;", "public abstract interface")]
public partial interface ScriptContext
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ScriptContext()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/script/ScriptContext;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENGINE_SCOPE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GLOBAL_SCOPE", "I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttribute", "(Ljava/lang/String;I)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBindings", "(Ljavax/script/Bindings;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBindings", "(I)Ljavax/script/Bindings;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReader", "()Ljava/io/Reader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWriter", "()Ljava/io/Writer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getErrorWriter", "()Ljava/io/Writer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeAttribute", "(Ljava/lang/String;I)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributesScope", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setWriter", "(Ljava/io/Writer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setErrorWriter", "(Ljava/io/Writer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setReader", "(Ljava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScopes", "()Ljava/util/List;"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ENGINE_SCOPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int GLOBAL_SCOPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;I)V", "public abstract")]
	void setAttribute(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object getAttribute(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object getAttribute(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/script/Bindings;I)V", "public abstract")]
	void setBindings(Dova.JDK.javax.script.Bindings arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Ljavax/script/Bindings;", "public abstract")]
	Dova.JDK.javax.script.Bindings getBindings(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.script.Bindings>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/Reader;", "public abstract")]
	Dova.JDK.java.io.Reader getReader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.Reader>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/Writer;", "public abstract")]
	Dova.JDK.java.io.Writer getWriter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.Writer>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/Writer;", "public abstract")]
	Dova.JDK.java.io.Writer getErrorWriter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.Writer>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object removeAttribute(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public abstract")]
	int getAttributesScope(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/Writer;)V", "public abstract")]
	void setWriter(Dova.JDK.java.io.Writer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/Writer;)V", "public abstract")]
	void setErrorWriter(Dova.JDK.java.io.Writer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/Reader;)V", "public abstract")]
	void setReader(Dova.JDK.java.io.Reader arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List getScopes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}
}
