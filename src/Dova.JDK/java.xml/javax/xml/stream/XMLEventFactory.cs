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

[JniSignatureAttribute("Ljavax/xml/stream/XMLEventFactory;", "public abstract")]
public partial class XMLEventFactory
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMLEventFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/xml/stream/XMLEventFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JAXPFACTORYID", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULIMPL", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/stream/XMLEventFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newInstance", "()Ljavax/xml/stream/XMLEventFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newFactory", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/stream/XMLEventFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newFactory", "()Ljavax/xml/stream/XMLEventFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createComment", "(Ljava/lang/String;)Ljavax/xml/stream/events/Comment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createProcessingInstruction", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/stream/events/ProcessingInstruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createAttribute", "(Ljavax/xml/namespace/QName;Ljava/lang/String;)Ljavax/xml/stream/events/Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createAttribute", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/stream/events/Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/stream/events/Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createEntityReference", "(Ljava/lang/String;Ljavax/xml/stream/events/EntityDeclaration;)Ljavax/xml/stream/events/EntityReference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocation", "(Ljavax/xml/stream/Location;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newDefaultFactory", "()Ljavax/xml/stream/XMLEventFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createNamespace", "(Ljava/lang/String;)Ljavax/xml/stream/events/Namespace;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createNamespace", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/stream/events/Namespace;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createStartElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Iterator;Ljava/util/Iterator;)Ljavax/xml/stream/events/StartElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createStartElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Iterator;Ljava/util/Iterator;Ljavax/xml/namespace/NamespaceContext;)Ljavax/xml/stream/events/StartElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createStartElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/stream/events/StartElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createStartElement", "(Ljavax/xml/namespace/QName;Ljava/util/Iterator;Ljava/util/Iterator;)Ljavax/xml/stream/events/StartElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createEndElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/stream/events/EndElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createEndElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Iterator;)Ljavax/xml/stream/events/EndElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createEndElement", "(Ljavax/xml/namespace/QName;Ljava/util/Iterator;)Ljavax/xml/stream/events/EndElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCharacters", "(Ljava/lang/String;)Ljavax/xml/stream/events/Characters;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCData", "(Ljava/lang/String;)Ljavax/xml/stream/events/Characters;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSpace", "(Ljava/lang/String;)Ljavax/xml/stream/events/Characters;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createIgnorableSpace", "(Ljava/lang/String;)Ljavax/xml/stream/events/Characters;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createStartDocument", "(Ljava/lang/String;)Ljavax/xml/stream/events/StartDocument;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createStartDocument", "(Ljava/lang/String;Ljava/lang/String;Z)Ljavax/xml/stream/events/StartDocument;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createStartDocument", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/stream/events/StartDocument;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createStartDocument", "()Ljavax/xml/stream/events/StartDocument;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createEndDocument", "()Ljavax/xml/stream/events/EndDocument;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDTD", "(Ljava/lang/String;)Ljavax/xml/stream/events/DTD;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String JAXPFACTORYID_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String DEFAULIMPL_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XMLEventFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public XMLEventFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/xml/stream/XMLEventFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/stream/XMLEventFactory;", "public static")]
	public static Dova.JDK.javax.xml.stream.XMLEventFactory newInstance(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.ClassLoader arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLEventFactory>(ret);
	}

	[JniSignatureAttribute("()Ljavax/xml/stream/XMLEventFactory;", "public static")]
	public static Dova.JDK.javax.xml.stream.XMLEventFactory newInstance()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLEventFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/stream/XMLEventFactory;", "public static")]
	public static Dova.JDK.javax.xml.stream.XMLEventFactory newFactory(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.ClassLoader arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLEventFactory>(ret);
	}

	[JniSignatureAttribute("()Ljavax/xml/stream/XMLEventFactory;", "public static")]
	public static Dova.JDK.javax.xml.stream.XMLEventFactory newFactory()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLEventFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/xml/stream/events/Comment;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.Comment createComment(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.Comment>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/stream/events/ProcessingInstruction;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.ProcessingInstruction createProcessingInstruction(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.ProcessingInstruction>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/namespace/QName;Ljava/lang/String;)Ljavax/xml/stream/events/Attribute;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.Attribute createAttribute(Dova.JDK.javax.xml.@namespace.QName arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.Attribute>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/stream/events/Attribute;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.Attribute createAttribute(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.Attribute>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/stream/events/Attribute;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.Attribute createAttribute(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.Attribute>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/xml/stream/events/EntityDeclaration;)Ljavax/xml/stream/events/EntityReference;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.EntityReference createEntityReference(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.xml.stream.events.EntityDeclaration arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.EntityReference>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/stream/Location;)V", "public abstract")]
	public void setLocation(Dova.JDK.javax.xml.stream.Location arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()Ljavax/xml/stream/XMLEventFactory;", "public static")]
	public static Dova.JDK.javax.xml.stream.XMLEventFactory newDefaultFactory()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLEventFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/xml/stream/events/Namespace;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.Namespace createNamespace(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.Namespace>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/stream/events/Namespace;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.Namespace createNamespace(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.Namespace>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Iterator;Ljava/util/Iterator;)Ljavax/xml/stream/events/StartElement;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.StartElement createStartElement(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Iterator arg3, Dova.JDK.java.util.Iterator arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.StartElement>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Iterator;Ljava/util/Iterator;Ljavax/xml/namespace/NamespaceContext;)Ljavax/xml/stream/events/StartElement;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.StartElement createStartElement(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Iterator arg3, Dova.JDK.java.util.Iterator arg4, Dova.JDK.javax.xml.@namespace.NamespaceContext arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.StartElement>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/stream/events/StartElement;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.StartElement createStartElement(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.StartElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/namespace/QName;Ljava/util/Iterator;Ljava/util/Iterator;)Ljavax/xml/stream/events/StartElement;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.StartElement createStartElement(Dova.JDK.javax.xml.@namespace.QName arg0, Dova.JDK.java.util.Iterator arg1, Dova.JDK.java.util.Iterator arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.StartElement>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/stream/events/EndElement;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.EndElement createEndElement(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.EndElement>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Iterator;)Ljavax/xml/stream/events/EndElement;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.EndElement createEndElement(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Iterator arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.EndElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/namespace/QName;Ljava/util/Iterator;)Ljavax/xml/stream/events/EndElement;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.EndElement createEndElement(Dova.JDK.javax.xml.@namespace.QName arg0, Dova.JDK.java.util.Iterator arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.EndElement>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/xml/stream/events/Characters;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.Characters createCharacters(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.Characters>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/xml/stream/events/Characters;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.Characters createCData(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.Characters>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/xml/stream/events/Characters;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.Characters createSpace(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.Characters>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/xml/stream/events/Characters;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.Characters createIgnorableSpace(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.Characters>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/xml/stream/events/StartDocument;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.StartDocument createStartDocument(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.StartDocument>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Z)Ljavax/xml/stream/events/StartDocument;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.StartDocument createStartDocument(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.StartDocument>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/stream/events/StartDocument;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.StartDocument createStartDocument(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.StartDocument>(ret);
	}

	[JniSignatureAttribute("()Ljavax/xml/stream/events/StartDocument;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.StartDocument createStartDocument()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.StartDocument>(ret);
	}

	[JniSignatureAttribute("()Ljavax/xml/stream/events/EndDocument;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.EndDocument createEndDocument()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.EndDocument>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/xml/stream/events/DTD;", "public abstract")]
	public Dova.JDK.javax.xml.stream.events.DTD createDTD(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.DTD>(ret);
	}
}
