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

namespace Dova.JDK.com.sun.org.apache.xml.@internal.utils;

[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/utils/XMLStringDefault;", "public")]
public partial class XMLStringDefault
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMLStringDefault()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/utils/XMLStringDefault;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_str", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Lcom/sun/org/apache/xml/internal/utils/XMLString;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "length", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChars", "(II[CI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Lcom/sun/org/apache/xml/internal/utils/XMLString;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indexOf", "(Ljava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indexOf", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indexOf", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indexOf", "(Lcom/sun/org/apache/xml/internal/utils/XMLString;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indexOf", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "charAt", "(I)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startsWith", "(Ljava/lang/String;I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startsWith", "(Lcom/sun/org/apache/xml/internal/utils/XMLString;I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startsWith", "(Lcom/sun/org/apache/xml/internal/utils/XMLString;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startsWith", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lastIndexOf", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lastIndexOf", "(Ljava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lastIndexOf", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lastIndexOf", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "substring", "(I)Lcom/sun/org/apache/xml/internal/utils/XMLString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "substring", "(II)Lcom/sun/org/apache/xml/internal/utils/XMLString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toLowerCase", "(Ljava/util/Locale;)Lcom/sun/org/apache/xml/internal/utils/XMLString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toLowerCase", "()Lcom/sun/org/apache/xml/internal/utils/XMLString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toUpperCase", "(Ljava/util/Locale;)Lcom/sun/org/apache/xml/internal/utils/XMLString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toUpperCase", "()Lcom/sun/org/apache/xml/internal/utils/XMLString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trim", "()Lcom/sun/org/apache/xml/internal/utils/XMLString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equalsIgnoreCase", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareToIgnoreCase", "(Lcom/sun/org/apache/xml/internal/utils/XMLString;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endsWith", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "concat", "(Ljava/lang/String;)Lcom/sun/org/apache/xml/internal/utils/XMLString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispatchAsComment", "(Lorg/xml/sax/ext/LexicalHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fixWhiteSpace", "(ZZZ)Lcom/sun/org/apache/xml/internal/utils/XMLString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasString", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toDouble", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispatchCharactersEvents", "(Lorg/xml/sax/ContentHandler;)V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String m_str_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XMLStringDefault(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public XMLStringDefault(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xml/internal/utils/XMLStringDefault;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/utils/XMLString;)Z", "public")]
	public bool equals(Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int length()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(II[CI)V", "public")]
	public void getChars(int arg0, int arg1, JavaArray<char> arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/utils/XMLString;)I", "public")]
	public int compareTo(Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)I", "public")]
	public int indexOf(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "public")]
	public int indexOf(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int indexOf(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/utils/XMLString;)I", "public")]
	public int indexOf(Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int indexOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)C", "public")]
	public char charAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Z", "public")]
	public bool startsWith(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/utils/XMLString;I)Z", "public")]
	public bool startsWith(Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/utils/XMLString;)Z", "public")]
	public bool startsWith(Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool startsWith(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "public")]
	public int lastIndexOf(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)I", "public")]
	public int lastIndexOf(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int lastIndexOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int lastIndexOf(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xml/internal/utils/XMLString;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString substring(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString>(ret);
	}

	[JniSignatureAttribute("(II)Lcom/sun/org/apache/xml/internal/utils/XMLString;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString substring(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)Lcom/sun/org/apache/xml/internal/utils/XMLString;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString toLowerCase(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xml/internal/utils/XMLString;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString toLowerCase()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)Lcom/sun/org/apache/xml/internal/utils/XMLString;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString toUpperCase(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xml/internal/utils/XMLString;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString toUpperCase()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xml/internal/utils/XMLString;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString trim()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool equalsIgnoreCase(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/utils/XMLString;)I", "public")]
	public int compareToIgnoreCase(Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool endsWith(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xml/internal/utils/XMLString;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString concat(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString>(ret);
	}

	[JniSignatureAttribute("(Lorg/xml/sax/ext/LexicalHandler;)V", "public")]
	public void dispatchAsComment(Dova.JDK.org.xml.sax.ext.LexicalHandler arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("(ZZZ)Lcom/sun/org/apache/xml/internal/utils/XMLString;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString fixWhiteSpace(bool arg0, bool arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasString()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[35]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double toDouble()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[36]);
		return ret;
	}

	[JniSignatureAttribute("(Lorg/xml/sax/ContentHandler;)V", "public")]
	public void dispatchCharactersEvents(Dova.JDK.org.xml.sax.ContentHandler arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}
}
