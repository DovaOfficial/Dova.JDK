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

namespace Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.trax;

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/trax/TransformerImpl;", "public final")]
public partial class TransformerImpl
	: Dova.JDK.javax.xml.transform.Transformer
	, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOMCache
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TransformerImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/trax/TransformerImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEXICAL_HANDLER_PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAMESPACE_PREFIXES_FEATURE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_translet", "Lcom/sun/org/apache/xalan/internal/xsltc/runtime/AbstractTranslet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_method", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_encoding", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_sourceSystemId", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_defaultListener", "Ljavax/xml/transform/ErrorListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_errorListener", "Ljavax/xml/transform/ErrorListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_uriResolver", "Ljavax/xml/transform/URIResolver;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_properties", "Ljava/util/Properties;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_propertiesClone", "Ljava/util/Properties;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_tohFactory", "Lcom/sun/org/apache/xalan/internal/xsltc/runtime/output/TransletOutputHandlerFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_dom", "Lcom/sun/org/apache/xalan/internal/xsltc/DOM;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_indentNumber", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_tfactory", "Lcom/sun/org/apache/xalan/internal/xsltc/trax/TransformerFactoryImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_ostream", "Ljava/io/OutputStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_dtmManager", "Lcom/sun/org/apache/xalan/internal/xsltc/dom/XSLTCDTMManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_readerManager", "Lcom/sun/org/apache/xml/internal/utils/XMLReaderManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_isIdentity", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_isSecureProcessing", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_overrideDefaultParser", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_accessExternalDTD", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_securityManager", "Ljdk/xml/internal/XMLSecurityManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_parameters", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_catalogFeatures", "Ljavax/xml/catalog/CatalogFeatures;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_catalogUriResolver", "Ljavax/xml/catalog/CatalogResolver;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_useCatalog", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_cdataChunkSize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_xsltcIsStandalone", "Ljdk/xml/internal/JdkProperty;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Properties;ILcom/sun/org/apache/xalan/internal/xsltc/trax/TransformerFactoryImpl;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xalan/internal/xsltc/Translet;Ljava/util/Properties;ILcom/sun/org/apache/xalan/internal/xsltc/trax/TransformerFactoryImpl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljavax/xml/transform/Source;Lcom/sun/org/apache/xml/internal/serializer/SerializationHandler;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljavax/xml/transform/Source;Ljavax/xml/transform/Result;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isIdentity", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDOM", "(Ljavax/xml/transform/Source;)Lcom/sun/org/apache/xalan/internal/xsltc/DOM;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createOutputProperties", "(Ljava/util/Properties;)Ljava/util/Properties;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transferOutputProperties", "(Lcom/sun/org/apache/xalan/internal/xsltc/runtime/AbstractTranslet;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transferOutputProperties", "(Lcom/sun/org/apache/xml/internal/serializer/SerializationHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutputHandler", "(Ljavax/xml/transform/Result;)Lcom/sun/org/apache/xml/internal/serializer/SerializationHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postErrorToListener", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transformIdentity", "(Ljavax/xml/transform/Source;Lcom/sun/org/apache/xml/internal/serializer/SerializationHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validOutputProperty", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDefaultProperty", "(Ljava/lang/String;Ljava/util/Properties;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDefaults", "(Ljava/util/Properties;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTranslet", "()Lcom/sun/org/apache/xalan/internal/xsltc/runtime/AbstractTranslet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDOM", "(Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransformerFactory", "()Lcom/sun/org/apache/xalan/internal/xsltc/trax/TransformerFactoryImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransletOutputHandlerFactory", "()Lcom/sun/org/apache/xalan/internal/xsltc/runtime/output/TransletOutputHandlerFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postWarningToListener", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "retrieveDocument", "(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xalan/internal/xsltc/Translet;)Lcom/sun/org/apache/xalan/internal/xsltc/DOM;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "overrideDefaultParser", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOverrideDefaultParser", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearParameters", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setURIResolver", "(Ljavax/xml/transform/URIResolver;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getURIResolver", "()Ljavax/xml/transform/URIResolver;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOutputProperties", "(Ljava/util/Properties;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutputProperties", "()Ljava/util/Properties;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOutputProperty", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutputProperty", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getErrorListener", "()Ljavax/xml/transform/ErrorListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSecureProcessing", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSecureProcessing", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String LEXICAL_HANDLER_PROPERTY_Property
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
	public static Dova.JDK.java.lang.String NAMESPACE_PREFIXES_FEATURE_Property
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

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/runtime/AbstractTranslet;", "private")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.runtime.AbstractTranslet _translet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.runtime.AbstractTranslet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String _method_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String _encoding_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String _sourceSystemId_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/xml/transform/ErrorListener;", "private final")]
	public Dova.JDK.javax.xml.transform.ErrorListener _defaultListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.transform.ErrorListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/xml/transform/ErrorListener;", "private")]
	public Dova.JDK.javax.xml.transform.ErrorListener _errorListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.transform.ErrorListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/xml/transform/URIResolver;", "private")]
	public Dova.JDK.javax.xml.transform.URIResolver _uriResolver_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.transform.URIResolver>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Properties;", "private")]
	public Dova.JDK.java.util.Properties _properties_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Properties>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Properties;", "private")]
	public Dova.JDK.java.util.Properties _propertiesClone_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Properties>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/runtime/output/TransletOutputHandlerFactory;", "private")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.runtime.output.TransletOutputHandlerFactory _tohFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.runtime.output.TransletOutputHandlerFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/DOM;", "private")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM _dom_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int _indentNumber_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/trax/TransformerFactoryImpl;", "private")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.trax.TransformerFactoryImpl _tfactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.trax.TransformerFactoryImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/OutputStream;", "private")]
	public Dova.JDK.java.io.OutputStream _ostream_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.OutputStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/dom/XSLTCDTMManager;", "private")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.XSLTCDTMManager _dtmManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.XSLTCDTMManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/utils/XMLReaderManager;", "private")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLReaderManager _readerManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLReaderManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool _isIdentity_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool _isSecureProcessing_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool _overrideDefaultParser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String _accessExternalDTD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/xml/internal/XMLSecurityManager;", "private")]
	public Dova.JDK.jdk.xml.@internal.XMLSecurityManager _securityManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.xml.@internal.XMLSecurityManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map _parameters_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/xml/catalog/CatalogFeatures;", "")]
	public Dova.JDK.javax.xml.catalog.CatalogFeatures _catalogFeatures_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.catalog.CatalogFeatures>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/xml/catalog/CatalogResolver;", "")]
	public Dova.JDK.javax.xml.catalog.CatalogResolver _catalogUriResolver_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.catalog.CatalogResolver>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool _useCatalog_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int _cdataChunkSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[27]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[27], value);
		}
	}

	[JniSignatureAttribute("Ljdk/xml/internal/JdkProperty;", "")]
	public Dova.JDK.jdk.xml.@internal.JdkProperty _xsltcIsStandalone_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.xml.@internal.JdkProperty>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TransformerImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/Properties;ILcom/sun/org/apache/xalan/internal/xsltc/trax/TransformerFactoryImpl;)V", "protected")]
	public TransformerImpl(Dova.JDK.java.util.Properties arg0, int arg1, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.trax.TransformerFactoryImpl arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/Translet;Ljava/util/Properties;ILcom/sun/org/apache/xalan/internal/xsltc/trax/TransformerFactoryImpl;)V", "protected")]
	public TransformerImpl(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.Translet arg0, Dova.JDK.java.util.Properties arg1, int arg2, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.trax.TransformerFactoryImpl arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/trax/TransformerImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/xml/transform/Source;Lcom/sun/org/apache/xml/internal/serializer/SerializationHandler;Ljava/lang/String;)V", "private")]
	public void transform(Dova.JDK.javax.xml.transform.Source arg0, Dova.JDK.com.sun.org.apache.xml.@internal.serializer.SerializationHandler arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/xml/transform/Source;Ljavax/xml/transform/Result;)V", "public")]
	public void transform(Dova.JDK.javax.xml.transform.Source arg0, Dova.JDK.javax.xml.transform.Result arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isIdentity()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void reset()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Ljavax/xml/transform/Source;)Lcom/sun/org/apache/xalan/internal/xsltc/DOM;", "private")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM getDOM(Dova.JDK.javax.xml.transform.Source arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object getParameter(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Properties;)Ljava/util/Properties;", "private")]
	public Dova.JDK.java.util.Properties createOutputProperties(Dova.JDK.java.util.Properties arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Properties>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/runtime/AbstractTranslet;)V", "private")]
	public void transferOutputProperties(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.runtime.AbstractTranslet arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/serializer/SerializationHandler;)V", "public")]
	public void transferOutputProperties(Dova.JDK.com.sun.org.apache.xml.@internal.serializer.SerializationHandler arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljavax/xml/transform/Result;)Lcom/sun/org/apache/xml/internal/serializer/SerializationHandler;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.serializer.SerializationHandler getOutputHandler(Dova.JDK.javax.xml.transform.Result arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.serializer.SerializationHandler>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
	public void postErrorToListener(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljavax/xml/transform/Source;Lcom/sun/org/apache/xml/internal/serializer/SerializationHandler;)V", "private")]
	public void transformIdentity(Dova.JDK.javax.xml.transform.Source arg0, Dova.JDK.com.sun.org.apache.xml.@internal.serializer.SerializationHandler arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool validOutputProperty(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Properties;)Z", "private")]
	public bool isDefaultProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Properties arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Properties;Ljava/lang/String;)V", "private")]
	public void setDefaults(Dova.JDK.java.util.Properties arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xalan/internal/xsltc/runtime/AbstractTranslet;", "protected")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.runtime.AbstractTranslet getTranslet()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.runtime.AbstractTranslet>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)V", "protected")]
	public void setDOM(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xalan/internal/xsltc/trax/TransformerFactoryImpl;", "protected")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.trax.TransformerFactoryImpl getTransformerFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.trax.TransformerFactoryImpl>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xalan/internal/xsltc/runtime/output/TransletOutputHandlerFactory;", "protected")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.runtime.output.TransletOutputHandlerFactory getTransletOutputHandlerFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.runtime.output.TransletOutputHandlerFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
	public void postWarningToListener(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xalan/internal/xsltc/Translet;)Lcom/sun/org/apache/xalan/internal/xsltc/DOM;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM retrieveDocument(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.Translet arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool overrideDefaultParser()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setOverrideDefaultParser(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void clearParameters()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23]);
	}

	[JniSignatureAttribute("(Ljavax/xml/transform/URIResolver;)V", "public")]
	public void setURIResolver(Dova.JDK.javax.xml.transform.URIResolver arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("()Ljavax/xml/transform/URIResolver;", "public")]
	public Dova.JDK.javax.xml.transform.URIResolver getURIResolver()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.transform.URIResolver>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Properties;)V", "public")]
	public void setOutputProperties(Dova.JDK.java.util.Properties arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/Properties;", "public")]
	public Dova.JDK.java.util.Properties getOutputProperties()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Properties>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void setOutputProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getOutputProperty(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/transform/ErrorListener;)V", "public")]
	public void setErrorListener(Dova.JDK.javax.xml.transform.ErrorListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("()Ljavax/xml/transform/ErrorListener;", "public")]
	public Dova.JDK.javax.xml.transform.ErrorListener getErrorListener()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.transform.ErrorListener>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setSecureProcessing(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isSecureProcessing()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[33]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void setParameter(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/trax/TransformerImpl$MessageHandler;", "static")]
	public partial class MessageHandler
		: Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.runtime.MessageHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MessageHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/trax/TransformerImpl$MessageHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_errorListener", "Ljavax/xml/transform/ErrorListener;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/xml/transform/ErrorListener;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "displayMessage", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getErrorListener", "()Ljavax/xml/transform/ErrorListener;"));
		}

		[JniSignatureAttribute("Ljavax/xml/transform/ErrorListener;", "private")]
		public Dova.JDK.javax.xml.transform.ErrorListener _errorListener_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.transform.ErrorListener>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MessageHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/xml/transform/ErrorListener;)V", "public")]
		public MessageHandler(Dova.JDK.javax.xml.transform.ErrorListener arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/trax/TransformerImpl$MessageHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void displayMessage(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()Ljavax/xml/transform/ErrorListener;", "public")]
		public Dova.JDK.javax.xml.transform.ErrorListener getErrorListener()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.transform.ErrorListener>(ret);
		}
	}
}
