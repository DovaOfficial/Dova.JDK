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

namespace Dova.JDK.com.sun.xml.@internal.stream;

[JniSignatureAttribute("Lcom/sun/xml/internal/stream/XMLInputFactoryImpl;", "public")]
public partial class XMLInputFactoryImpl
	: Dova.JDK.javax.xml.stream.XMLInputFactory
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMLInputFactoryImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/xml/internal/stream/XMLInputFactoryImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fPropertyManager", "Lcom/sun/org/apache/xerces/internal/impl/PropertyManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fTempReader", "Lcom/sun/org/apache/xerces/internal/impl/XMLStreamReaderImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fPropertyChanged", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fReuseInstance", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPropertySupported", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLStreamReader", "(Ljava/io/Reader;)Ljavax/xml/stream/XMLStreamReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLStreamReader", "(Ljava/io/InputStream;)Ljavax/xml/stream/XMLStreamReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLStreamReader", "(Ljavax/xml/transform/Source;)Ljavax/xml/stream/XMLStreamReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLStreamReader", "(Ljava/lang/String;Ljava/io/Reader;)Ljavax/xml/stream/XMLStreamReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLStreamReader", "(Ljava/lang/String;Ljava/io/InputStream;)Ljavax/xml/stream/XMLStreamReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLStreamReader", "(Ljava/io/InputStream;Ljava/lang/String;)Ljavax/xml/stream/XMLStreamReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLEventReader", "(Ljava/lang/String;Ljava/io/InputStream;)Ljavax/xml/stream/XMLEventReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLEventReader", "(Ljava/lang/String;Ljava/io/Reader;)Ljavax/xml/stream/XMLEventReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLEventReader", "(Ljava/io/InputStream;Ljava/lang/String;)Ljavax/xml/stream/XMLEventReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLEventReader", "(Ljavax/xml/transform/Source;)Ljavax/xml/stream/XMLEventReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLEventReader", "(Ljava/io/InputStream;)Ljavax/xml/stream/XMLEventReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLEventReader", "(Ljava/io/Reader;)Ljavax/xml/stream/XMLEventReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLEventReader", "(Ljavax/xml/stream/XMLStreamReader;)Ljavax/xml/stream/XMLEventReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createFilteredReader", "(Ljavax/xml/stream/XMLStreamReader;Ljavax/xml/stream/StreamFilter;)Ljavax/xml/stream/XMLStreamReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createFilteredReader", "(Ljavax/xml/stream/XMLEventReader;Ljavax/xml/stream/EventFilter;)Ljavax/xml/stream/XMLEventReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getXMLResolver", "()Ljavax/xml/stream/XMLResolver;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setXMLResolver", "(Ljavax/xml/stream/XMLResolver;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getXMLReporter", "()Ljavax/xml/stream/XMLReporter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setXMLReporter", "(Ljavax/xml/stream/XMLReporter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEventAllocator", "(Ljavax/xml/stream/util/XMLEventAllocator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEventAllocator", "()Ljavax/xml/stream/util/XMLEventAllocator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initEventReader", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getXMLStreamReaderImpl", "(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLInputSource;)Ljavax/xml/stream/XMLStreamReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "jaxpSourcetoXMLInputSource", "(Ljavax/xml/transform/Source;)Lcom/sun/org/apache/xerces/internal/xni/parser/XMLInputSource;"));
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/PropertyManager;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.PropertyManager fPropertyManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.PropertyManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/XMLStreamReaderImpl;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLStreamReaderImpl fTempReader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLStreamReaderImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool fPropertyChanged_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool fReuseInstance_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XMLInputFactoryImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XMLInputFactoryImpl() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/xml/internal/stream/XMLInputFactoryImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getProperty(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void setProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool isPropertySupported(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/Reader;)Ljavax/xml/stream/XMLStreamReader;", "public")]
	public Dova.JDK.javax.xml.stream.XMLStreamReader createXMLStreamReader(Dova.JDK.java.io.Reader arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLStreamReader>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljavax/xml/stream/XMLStreamReader;", "public")]
	public Dova.JDK.javax.xml.stream.XMLStreamReader createXMLStreamReader(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLStreamReader>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/transform/Source;)Ljavax/xml/stream/XMLStreamReader;", "public")]
	public Dova.JDK.javax.xml.stream.XMLStreamReader createXMLStreamReader(Dova.JDK.javax.xml.transform.Source arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLStreamReader>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;)Ljavax/xml/stream/XMLStreamReader;", "public")]
	public Dova.JDK.javax.xml.stream.XMLStreamReader createXMLStreamReader(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLStreamReader>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;)Ljavax/xml/stream/XMLStreamReader;", "public")]
	public Dova.JDK.javax.xml.stream.XMLStreamReader createXMLStreamReader(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLStreamReader>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/lang/String;)Ljavax/xml/stream/XMLStreamReader;", "public")]
	public Dova.JDK.javax.xml.stream.XMLStreamReader createXMLStreamReader(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLStreamReader>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;)Ljavax/xml/stream/XMLEventReader;", "public")]
	public Dova.JDK.javax.xml.stream.XMLEventReader createXMLEventReader(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLEventReader>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;)Ljavax/xml/stream/XMLEventReader;", "public")]
	public Dova.JDK.javax.xml.stream.XMLEventReader createXMLEventReader(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLEventReader>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/lang/String;)Ljavax/xml/stream/XMLEventReader;", "public")]
	public Dova.JDK.javax.xml.stream.XMLEventReader createXMLEventReader(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLEventReader>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/transform/Source;)Ljavax/xml/stream/XMLEventReader;", "public")]
	public Dova.JDK.javax.xml.stream.XMLEventReader createXMLEventReader(Dova.JDK.javax.xml.transform.Source arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLEventReader>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljavax/xml/stream/XMLEventReader;", "public")]
	public Dova.JDK.javax.xml.stream.XMLEventReader createXMLEventReader(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLEventReader>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/Reader;)Ljavax/xml/stream/XMLEventReader;", "public")]
	public Dova.JDK.javax.xml.stream.XMLEventReader createXMLEventReader(Dova.JDK.java.io.Reader arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLEventReader>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/XMLStreamReader;)Ljavax/xml/stream/XMLEventReader;", "public")]
	public Dova.JDK.javax.xml.stream.XMLEventReader createXMLEventReader(Dova.JDK.javax.xml.stream.XMLStreamReader arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLEventReader>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/XMLStreamReader;Ljavax/xml/stream/StreamFilter;)Ljavax/xml/stream/XMLStreamReader;", "public")]
	public Dova.JDK.javax.xml.stream.XMLStreamReader createFilteredReader(Dova.JDK.javax.xml.stream.XMLStreamReader arg0, Dova.JDK.javax.xml.stream.StreamFilter arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLStreamReader>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/XMLEventReader;Ljavax/xml/stream/EventFilter;)Ljavax/xml/stream/XMLEventReader;", "public")]
	public Dova.JDK.javax.xml.stream.XMLEventReader createFilteredReader(Dova.JDK.javax.xml.stream.XMLEventReader arg0, Dova.JDK.javax.xml.stream.EventFilter arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLEventReader>(ret);
	}

	[JniSignatureAttribute("()Ljavax/xml/stream/XMLResolver;", "public")]
	public Dova.JDK.javax.xml.stream.XMLResolver getXMLResolver()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLResolver>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/XMLResolver;)V", "public")]
	public void setXMLResolver(Dova.JDK.javax.xml.stream.XMLResolver arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("()Ljavax/xml/stream/XMLReporter;", "public")]
	public Dova.JDK.javax.xml.stream.XMLReporter getXMLReporter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLReporter>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/XMLReporter;)V", "public")]
	public void setXMLReporter(Dova.JDK.javax.xml.stream.XMLReporter arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/util/XMLEventAllocator;)V", "public")]
	public void setEventAllocator(Dova.JDK.javax.xml.stream.util.XMLEventAllocator arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("()Ljavax/xml/stream/util/XMLEventAllocator;", "public")]
	public Dova.JDK.javax.xml.stream.util.XMLEventAllocator getEventAllocator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.util.XMLEventAllocator>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void initEventReader()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24]);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/parser/XMLInputSource;)Ljavax/xml/stream/XMLStreamReader;", "")]
	public Dova.JDK.javax.xml.stream.XMLStreamReader getXMLStreamReaderImpl(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLInputSource arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLStreamReader>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/transform/Source;)Lcom/sun/org/apache/xerces/internal/xni/parser/XMLInputSource;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLInputSource jaxpSourcetoXMLInputSource(Dova.JDK.javax.xml.transform.Source arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLInputSource>(ret);
	}
}
