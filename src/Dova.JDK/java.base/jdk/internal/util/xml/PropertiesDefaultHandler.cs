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

namespace Dova.JDK.jdk.@internal.util.xml;

[JniSignatureAttribute("Ljdk/internal/util/xml/PropertiesDefaultHandler;", "public")]
public partial class PropertiesDefaultHandler
	: Dova.JDK.jdk.@internal.org.xml.sax.helpers.DefaultHandler
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PropertiesDefaultHandler()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/util/xml/PropertiesDefaultHandler;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ELEMENT_ROOT", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ELEMENT_COMMENT", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ELEMENT_ENTRY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_KEY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROPS_DTD_DECL", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROPS_DTD_URI", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROPS_DTD", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXTERNAL_XML_VERSION", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "properties", "Ljava/util/Properties;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALLOWED_ELEMENTS", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALLOWED_COMMENT", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "buf", "Ljava/lang/StringBuilder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sawRoot", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sawComment", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "validEntry", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rootElm", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(Ljava/util/Properties;Ljava/io/InputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "store", "(Ljava/util/Properties;Ljava/io/OutputStream;Ljava/lang/String;Ljava/nio/charset/Charset;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error", "(Ljdk/internal/org/xml/sax/SAXParseException;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warning", "(Ljdk/internal/org/xml/sax/SAXParseException;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startInternalSub", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveEntity", "(Ljava/lang/String;Ljava/lang/String;)Ljdk/internal/org/xml/sax/InputSource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljdk/internal/org/xml/sax/Attributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "characters", "([CII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fatalError", "(Ljdk/internal/org/xml/sax/SAXParseException;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startDTD", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String ELEMENT_ROOT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String ELEMENT_COMMENT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String ELEMENT_ENTRY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String ATTR_KEY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String PROPS_DTD_DECL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String PROPS_DTD_URI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String PROPS_DTD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String EXTERNAL_XML_VERSION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Properties;", "private")]
	public Dova.JDK.java.util.Properties properties_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Properties>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String ALLOWED_ELEMENTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String ALLOWED_COMMENT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/StringBuilder;", "")]
	public Dova.JDK.java.lang.StringBuilder buf_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool sawRoot_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool sawComment_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool validEntry_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String key_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String rootElm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PropertiesDefaultHandler(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public PropertiesDefaultHandler() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/util/xml/PropertiesDefaultHandler;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/Properties;Ljava/io/InputStream;)V", "public")]
	public void load(Dova.JDK.java.util.Properties arg0, Dova.JDK.java.io.InputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/Properties;Ljava/io/OutputStream;Ljava/lang/String;Ljava/nio/charset/Charset;)V", "public")]
	public void store(Dova.JDK.java.util.Properties arg0, Dova.JDK.java.io.OutputStream arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.nio.charset.Charset arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/xml/sax/SAXParseException;)V", "public")]
	public void error(Dova.JDK.jdk.@internal.org.xml.sax.SAXParseException arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/xml/sax/SAXParseException;)V", "public")]
	public void warning(Dova.JDK.jdk.@internal.org.xml.sax.SAXParseException arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void startInternalSub()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljdk/internal/org/xml/sax/InputSource;", "public")]
	public Dova.JDK.jdk.@internal.org.xml.sax.InputSource resolveEntity(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.xml.sax.InputSource>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljdk/internal/org/xml/sax/Attributes;)V", "public")]
	public void startElement(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.jdk.@internal.org.xml.sax.Attributes arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void endElement(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([CII)V", "public")]
	public void characters(JavaArray<char> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/xml/sax/SAXParseException;)V", "public")]
	public void fatalError(Dova.JDK.jdk.@internal.org.xml.sax.SAXParseException arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void startDTD(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
	}
}
