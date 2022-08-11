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

namespace Dova.JDK.com.sun.org.apache.xpath.@internal.objects;

[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/objects/XObject;", "public")]
public partial class XObject
	: Dova.JDK.com.sun.org.apache.xpath.@internal.Expression
	, Dova.JDK.java.io.Serializable
	, Dova.JDK.java.lang.Cloneable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XObject()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xpath/internal/objects/XObject;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_obj", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_NULL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_UNKNOWN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_BOOLEAN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_NUMBER", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_STRING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_NODESET", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_RTREEFRAG", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_UNRESOLVEDVARIABLE", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Lcom/sun/org/apache/xpath/internal/objects/XObject;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "str", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "execute", "(Lcom/sun/org/apache/xpath/internal/XPathContext;)Lcom/sun/org/apache/xpath/internal/objects/XObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "num", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/lang/Object;Lcom/sun/org/apache/xpath/internal/XPathContext;)Lcom/sun/org/apache/xpath/internal/objects/XObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/lang/Object;)Lcom/sun/org/apache/xpath/internal/objects/XObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deepEquals", "(Lcom/sun/org/apache/xpath/internal/Expression;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "object", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iter", "()Lcom/sun/org/apache/xml/internal/dtm/DTMIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "detach", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "greaterThan", "(Lcom/sun/org/apache/xpath/internal/objects/XObject;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rtree", "()Lorg/w3c/dom/DocumentFragment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rtree", "(Lcom/sun/org/apache/xpath/internal/XPathContext;)Lorg/w3c/dom/DocumentFragment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "destruct", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allowDetachToRelease", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "greaterThanOrEqual", "(Lcom/sun/org/apache/xpath/internal/objects/XObject;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lessThan", "(Lcom/sun/org/apache/xpath/internal/objects/XObject;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lessThanOrEqual", "(Lcom/sun/org/apache/xpath/internal/objects/XObject;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "notEquals", "(Lcom/sun/org/apache/xpath/internal/objects/XObject;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "numWithSideEffects", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "boolWithSideEffects", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFresh", "()Lcom/sun/org/apache/xpath/internal/objects/XObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "castToType", "(ILcom/sun/org/apache/xpath/internal/XPathContext;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendToFsb", "(Lcom/sun/org/apache/xml/internal/utils/FastStringBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fixupVariables", "(Ljava/util/List;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "callVisitors", "(Lcom/sun/org/apache/xpath/internal/ExpressionOwner;Lcom/sun/org/apache/xpath/internal/XPathVisitor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "xstr", "()Lcom/sun/org/apache/xml/internal/utils/XMLString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispatchCharactersEvents", "(Lorg/xml/sax/ContentHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nodeset", "()Lorg/w3c/dom/traversal/NodeIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mutableNodeset", "()Lcom/sun/org/apache/xpath/internal/NodeSetDTM;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rtf", "(Lcom/sun/org/apache/xpath/internal/XPathContext;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rtf", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nodelist", "()Lorg/w3c/dom/NodeList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bool", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setObject", "(Ljava/lang/Object;)V"));
	}

	[JniSignatureAttribute("J", "static final")]
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

	[JniSignatureAttribute("Ljava/lang/Object;", "protected")]
	public Dova.JDK.java.lang.Object m_obj_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CLASS_NULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CLASS_UNKNOWN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CLASS_BOOLEAN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CLASS_NUMBER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CLASS_STRING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CLASS_NODESET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CLASS_RTREEFRAG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CLASS_UNRESOLVEDVARIABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XObject(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XObject() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
	public XObject(Dova.JDK.java.lang.Object arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xpath/internal/objects/XObject;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/objects/XObject;)Z", "public")]
	public bool equals(Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String str()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/XPathContext;)Lcom/sun/org/apache/xpath/internal/objects/XObject;", "public")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject execute(Dova.JDK.com.sun.org.apache.xpath.@internal.XPathContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getType()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double num()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void reset()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Lcom/sun/org/apache/xpath/internal/XPathContext;)Lcom/sun/org/apache/xpath/internal/objects/XObject;", "public static")]
	public static Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject create(Dova.JDK.java.lang.Object arg0, Dova.JDK.com.sun.org.apache.xpath.@internal.XPathContext arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Lcom/sun/org/apache/xpath/internal/objects/XObject;", "public static")]
	public static Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject create(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
	public void error(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "protected")]
	public void error(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getTypeString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/Expression;)Z", "public")]
	public bool deepEquals(Dova.JDK.com.sun.org.apache.xpath.@internal.Expression arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object @object()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xml/internal/dtm/DTMIterator;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMIterator iter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMIterator>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void detach()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15]);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/objects/XObject;)Z", "public")]
	public bool greaterThan(Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/DocumentFragment;", "public")]
	public Dova.JDK.org.w3c.dom.DocumentFragment rtree()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.DocumentFragment>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/XPathContext;)Lorg/w3c/dom/DocumentFragment;", "public")]
	public Dova.JDK.org.w3c.dom.DocumentFragment rtree(Dova.JDK.com.sun.org.apache.xpath.@internal.XPathContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.DocumentFragment>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void destruct()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19]);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void allowDetachToRelease(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/objects/XObject;)Z", "public")]
	public bool greaterThanOrEqual(Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/objects/XObject;)Z", "public")]
	public bool lessThan(Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/objects/XObject;)Z", "public")]
	public bool lessThanOrEqual(Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/objects/XObject;)Z", "public")]
	public bool notEquals(Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double numWithSideEffects()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool boolWithSideEffects()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xpath/internal/objects/XObject;", "public")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject getFresh()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject>(ret);
	}

	[JniSignatureAttribute("(ILcom/sun/org/apache/xpath/internal/XPathContext;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object castToType(int arg0, Dova.JDK.com.sun.org.apache.xpath.@internal.XPathContext arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/utils/FastStringBuffer;)V", "public")]
	public void appendToFsb(Dova.JDK.com.sun.org.apache.xml.@internal.utils.FastStringBuffer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/List;I)V", "public")]
	public void fixupVariables(Dova.JDK.java.util.List arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/ExpressionOwner;Lcom/sun/org/apache/xpath/internal/XPathVisitor;)V", "public")]
	public void callVisitors(Dova.JDK.com.sun.org.apache.xpath.@internal.ExpressionOwner arg0, Dova.JDK.com.sun.org.apache.xpath.@internal.XPathVisitor arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xml/internal/utils/XMLString;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString xstr()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLString>(ret);
	}

	[JniSignatureAttribute("(Lorg/xml/sax/ContentHandler;)V", "public")]
	public void dispatchCharactersEvents(Dova.JDK.org.xml.sax.ContentHandler arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/traversal/NodeIterator;", "public")]
	public Dova.JDK.org.w3c.dom.traversal.NodeIterator nodeset()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.traversal.NodeIterator>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xpath/internal/NodeSetDTM;", "public")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.NodeSetDTM mutableNodeset()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.NodeSetDTM>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/XPathContext;)I", "public")]
	public int rtf(Dova.JDK.com.sun.org.apache.xpath.@internal.XPathContext arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int rtf()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[37]);
		return ret;
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/NodeList;", "public")]
	public Dova.JDK.org.w3c.dom.NodeList nodelist()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.NodeList>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool @bool()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[39]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "protected")]
	public void setObject(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
	}
}
