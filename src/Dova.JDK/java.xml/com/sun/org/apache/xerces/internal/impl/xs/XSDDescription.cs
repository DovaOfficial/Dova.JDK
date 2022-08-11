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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;", "public")]
public partial class XSDDescription
	: Dova.JDK.com.sun.org.apache.xerces.@internal.util.XMLResourceIdentifierImpl
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.grammars.XMLSchemaDescription
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XSDDescription()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONTEXT_INITIALIZE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONTEXT_INCLUDE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONTEXT_REDEFINE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONTEXT_IMPORT", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONTEXT_PREPARSE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONTEXT_INSTANCE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONTEXT_ELEMENT", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONTEXT_ATTRIBUTE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONTEXT_XSITYPE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fContextType", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fLocationHints", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fTriggeringComponent", "Lcom/sun/org/apache/xerces/internal/xni/QName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fEnclosedElementName", "Lcom/sun/org/apache/xerces/internal/xni/QName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fAttributes", "Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "()Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExternal", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGrammarType", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContextType", "()S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetNamespace", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationHints", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTriggeringComponent", "()Lcom/sun/org/apache/xerces/internal/xni/QName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingElementName", "()Lcom/sun/org/apache/xerces/internal/xni/QName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fromInstance", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setContextType", "(S)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTargetNamespace", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTriggeringComponent", "(Lcom/sun/org/apache/xerces/internal/xni/QName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEnclosingElementName", "(Lcom/sun/org/apache/xerces/internal/xni/QName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocationHints", "([Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAttributes", "(Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeClone", "()Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;"));
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short CONTEXT_INITIALIZE_Property
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
	public static short CONTEXT_INCLUDE_Property
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

	[JniSignatureAttribute("S", "public static final")]
	public static short CONTEXT_REDEFINE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short CONTEXT_IMPORT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short CONTEXT_PREPARSE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short CONTEXT_INSTANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short CONTEXT_ELEMENT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short CONTEXT_ATTRIBUTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short CONTEXT_XSITYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short fContextType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "protected")]
	public JavaArray<Dova.JDK.java.lang.String> fLocationHints_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/QName;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName fTriggeringComponent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/QName;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName fEnclosedElementName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes fAttributes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XSDDescription(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XSDDescription() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void reset()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes getAttributes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isExternal()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getGrammarType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()S", "public")]
	public short getContextType()
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getTargetNamespace()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getLocationHints()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xni/QName;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName getTriggeringComponent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xni/QName;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName getEnclosingElementName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool fromInstance()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("(S)V", "public")]
	public void setContextType(short arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setTargetNamespace(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;)V", "public")]
	public void setTriggeringComponent(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;)V", "public")]
	public void setEnclosingElementName(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)V", "public")]
	public void setLocationHints(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;)V", "public")]
	public void setAttributes(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xs/XSDDescription;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDDescription makeClone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSDDescription>(ret);
	}
}
