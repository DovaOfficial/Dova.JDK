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

namespace Dova.JDK.javax.xml.stream;

[JniSignatureAttribute("Ljavax/xml/stream/XMLInputFactory;", "public abstract")]
public partial class XMLInputFactory
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMLInputFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/xml/stream/XMLInputFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IS_NAMESPACE_AWARE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IS_VALIDATING", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IS_COALESCING", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IS_REPLACING_ENTITY_REFERENCES", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IS_SUPPORTING_EXTERNAL_ENTITIES", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUPPORT_DTD", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REPORTER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RESOLVER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALLOCATOR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULIMPL", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/stream/XMLInputFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newInstance", "()Ljavax/xml/stream/XMLInputFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newFactory", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/stream/XMLInputFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newFactory", "()Ljavax/xml/stream/XMLInputFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newDefaultFactory", "()Ljavax/xml/stream/XMLInputFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPropertySupported", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLStreamReader", "(Ljava/lang/String;Ljava/io/Reader;)Ljavax/xml/stream/XMLStreamReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLStreamReader", "(Ljava/lang/String;Ljava/io/InputStream;)Ljavax/xml/stream/XMLStreamReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLStreamReader", "(Ljava/io/InputStream;Ljava/lang/String;)Ljavax/xml/stream/XMLStreamReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLStreamReader", "(Ljava/io/Reader;)Ljavax/xml/stream/XMLStreamReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLStreamReader", "(Ljavax/xml/transform/Source;)Ljavax/xml/stream/XMLStreamReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLStreamReader", "(Ljava/io/InputStream;)Ljavax/xml/stream/XMLStreamReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLEventReader", "(Ljava/io/InputStream;Ljava/lang/String;)Ljavax/xml/stream/XMLEventReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLEventReader", "(Ljava/lang/String;Ljava/io/InputStream;)Ljavax/xml/stream/XMLEventReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLEventReader", "(Ljava/lang/String;Ljava/io/Reader;)Ljavax/xml/stream/XMLEventReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLEventReader", "(Ljava/io/Reader;)Ljavax/xml/stream/XMLEventReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLEventReader", "(Ljavax/xml/stream/XMLStreamReader;)Ljavax/xml/stream/XMLEventReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLEventReader", "(Ljavax/xml/transform/Source;)Ljavax/xml/stream/XMLEventReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createXMLEventReader", "(Ljava/io/InputStream;)Ljavax/xml/stream/XMLEventReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createFilteredReader", "(Ljavax/xml/stream/XMLEventReader;Ljavax/xml/stream/EventFilter;)Ljavax/xml/stream/XMLEventReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createFilteredReader", "(Ljavax/xml/stream/XMLStreamReader;Ljavax/xml/stream/StreamFilter;)Ljavax/xml/stream/XMLStreamReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getXMLResolver", "()Ljavax/xml/stream/XMLResolver;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setXMLResolver", "(Ljavax/xml/stream/XMLResolver;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getXMLReporter", "()Ljavax/xml/stream/XMLReporter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setXMLReporter", "(Ljavax/xml/stream/XMLReporter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEventAllocator", "(Ljavax/xml/stream/util/XMLEventAllocator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEventAllocator", "()Ljavax/xml/stream/util/XMLEventAllocator;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String IS_NAMESPACE_AWARE_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String IS_VALIDATING_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String IS_COALESCING_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String IS_REPLACING_ENTITY_REFERENCES_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String IS_SUPPORTING_EXTERNAL_ENTITIES_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String SUPPORT_DTD_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String REPORTER_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String RESOLVER_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String ALLOCATOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String DEFAULIMPL_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XMLInputFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public XMLInputFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/xml/stream/XMLInputFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public abstract")]
	public Dova.JDK.java.lang.Object getProperty(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/stream/XMLInputFactory;", "public static")]
	public static Dova.JDK.javax.xml.stream.XMLInputFactory newInstance(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.ClassLoader arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLInputFactory>(ret);
	}

	[JniSignatureAttribute("()Ljavax/xml/stream/XMLInputFactory;", "public static")]
	public static Dova.JDK.javax.xml.stream.XMLInputFactory newInstance()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLInputFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public abstract")]
	public void setProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/stream/XMLInputFactory;", "public static")]
	public static Dova.JDK.javax.xml.stream.XMLInputFactory newFactory(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.ClassLoader arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLInputFactory>(ret);
	}

	[JniSignatureAttribute("()Ljavax/xml/stream/XMLInputFactory;", "public static")]
	public static Dova.JDK.javax.xml.stream.XMLInputFactory newFactory()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLInputFactory>(ret);
	}

	[JniSignatureAttribute("()Ljavax/xml/stream/XMLInputFactory;", "public static")]
	public static Dova.JDK.javax.xml.stream.XMLInputFactory newDefaultFactory()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLInputFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public abstract")]
	public bool isPropertySupported(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;)Ljavax/xml/stream/XMLStreamReader;", "public abstract")]
	public Dova.JDK.javax.xml.stream.XMLStreamReader createXMLStreamReader(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLStreamReader>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;)Ljavax/xml/stream/XMLStreamReader;", "public abstract")]
	public Dova.JDK.javax.xml.stream.XMLStreamReader createXMLStreamReader(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLStreamReader>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/lang/String;)Ljavax/xml/stream/XMLStreamReader;", "public abstract")]
	public Dova.JDK.javax.xml.stream.XMLStreamReader createXMLStreamReader(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLStreamReader>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/Reader;)Ljavax/xml/stream/XMLStreamReader;", "public abstract")]
	public Dova.JDK.javax.xml.stream.XMLStreamReader createXMLStreamReader(Dova.JDK.java.io.Reader arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLStreamReader>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/transform/Source;)Ljavax/xml/stream/XMLStreamReader;", "public abstract")]
	public Dova.JDK.javax.xml.stream.XMLStreamReader createXMLStreamReader(Dova.JDK.javax.xml.transform.Source arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLStreamReader>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljavax/xml/stream/XMLStreamReader;", "public abstract")]
	public Dova.JDK.javax.xml.stream.XMLStreamReader createXMLStreamReader(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLStreamReader>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/lang/String;)Ljavax/xml/stream/XMLEventReader;", "public abstract")]
	public Dova.JDK.javax.xml.stream.XMLEventReader createXMLEventReader(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLEventReader>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;)Ljavax/xml/stream/XMLEventReader;", "public abstract")]
	public Dova.JDK.javax.xml.stream.XMLEventReader createXMLEventReader(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLEventReader>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;)Ljavax/xml/stream/XMLEventReader;", "public abstract")]
	public Dova.JDK.javax.xml.stream.XMLEventReader createXMLEventReader(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLEventReader>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/Reader;)Ljavax/xml/stream/XMLEventReader;", "public abstract")]
	public Dova.JDK.javax.xml.stream.XMLEventReader createXMLEventReader(Dova.JDK.java.io.Reader arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLEventReader>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/XMLStreamReader;)Ljavax/xml/stream/XMLEventReader;", "public abstract")]
	public Dova.JDK.javax.xml.stream.XMLEventReader createXMLEventReader(Dova.JDK.javax.xml.stream.XMLStreamReader arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLEventReader>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/transform/Source;)Ljavax/xml/stream/XMLEventReader;", "public abstract")]
	public Dova.JDK.javax.xml.stream.XMLEventReader createXMLEventReader(Dova.JDK.javax.xml.transform.Source arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLEventReader>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljavax/xml/stream/XMLEventReader;", "public abstract")]
	public Dova.JDK.javax.xml.stream.XMLEventReader createXMLEventReader(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLEventReader>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/XMLEventReader;Ljavax/xml/stream/EventFilter;)Ljavax/xml/stream/XMLEventReader;", "public abstract")]
	public Dova.JDK.javax.xml.stream.XMLEventReader createFilteredReader(Dova.JDK.javax.xml.stream.XMLEventReader arg0, Dova.JDK.javax.xml.stream.EventFilter arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLEventReader>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/XMLStreamReader;Ljavax/xml/stream/StreamFilter;)Ljavax/xml/stream/XMLStreamReader;", "public abstract")]
	public Dova.JDK.javax.xml.stream.XMLStreamReader createFilteredReader(Dova.JDK.javax.xml.stream.XMLStreamReader arg0, Dova.JDK.javax.xml.stream.StreamFilter arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLStreamReader>(ret);
	}

	[JniSignatureAttribute("()Ljavax/xml/stream/XMLResolver;", "public abstract")]
	public Dova.JDK.javax.xml.stream.XMLResolver getXMLResolver()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLResolver>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/XMLResolver;)V", "public abstract")]
	public void setXMLResolver(Dova.JDK.javax.xml.stream.XMLResolver arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("()Ljavax/xml/stream/XMLReporter;", "public abstract")]
	public Dova.JDK.javax.xml.stream.XMLReporter getXMLReporter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLReporter>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/XMLReporter;)V", "public abstract")]
	public void setXMLReporter(Dova.JDK.javax.xml.stream.XMLReporter arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/util/XMLEventAllocator;)V", "public abstract")]
	public void setEventAllocator(Dova.JDK.javax.xml.stream.util.XMLEventAllocator arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("()Ljavax/xml/stream/util/XMLEventAllocator;", "public abstract")]
	public Dova.JDK.javax.xml.stream.util.XMLEventAllocator getEventAllocator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.util.XMLEventAllocator>(ret);
	}
}
