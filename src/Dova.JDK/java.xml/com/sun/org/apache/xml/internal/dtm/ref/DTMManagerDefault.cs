/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.org.apache.xml.@internal.dtm.@ref;

[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/dtm/ref/DTMManagerDefault;", "public")]
public partial class DTMManagerDefault
	: Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMManager
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DTMManagerDefault()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/dtm/ref/DTMManagerDefault;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DUMPTREE", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DEBUG", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "m_dtms", "[Lcom/sun/org/apache/xml/internal/dtm/DTM;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "m_dtm_offsets", "[I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "m_readerManager", "Lcom/sun/org/apache/xml/internal/utils/XMLReaderManager;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "m_defaultHandler", "Lorg/xml/sax/helpers/DefaultHandler;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "m_expandedNameTable", "Lcom/sun/org/apache/xml/internal/dtm/ref/ExpandedNameTable;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DTMManagerDefault", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "release", "(Lcom/sun/org/apache/xml/internal/dtm/DTM;Z)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getExpandedNameTable", "(Lcom/sun/org/apache/xml/internal/dtm/DTM;)Lcom/sun/org/apache/xml/internal/dtm/ref/ExpandedNameTable;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addDTM", "(Lcom/sun/org/apache/xml/internal/dtm/DTM;I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addDTM", "(Lcom/sun/org/apache/xml/internal/dtm/DTM;II)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getFirstFreeDTMID", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "releaseXMLReader", "(Lorg/xml/sax/XMLReader;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getXMLReader", "(Ljavax/xml/transform/Source;)Lorg/xml/sax/XMLReader;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createDocumentFragment", "()Lcom/sun/org/apache/xml/internal/dtm/DTM;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDTMIdentity", "(Lcom/sun/org/apache/xml/internal/dtm/DTM;)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createDTMIterator", "(I)Lcom/sun/org/apache/xml/internal/dtm/DTMIterator;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createDTMIterator", "(Ljava/lang/String;Lcom/sun/org/apache/xml/internal/utils/PrefixResolver;)Lcom/sun/org/apache/xml/internal/dtm/DTMIterator;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createDTMIterator", "(Ljava/lang/Object;I)Lcom/sun/org/apache/xml/internal/dtm/DTMIterator;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createDTMIterator", "(ILcom/sun/org/apache/xml/internal/dtm/DTMFilter;Z)Lcom/sun/org/apache/xml/internal/dtm/DTMIterator;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDTM", "(I)Lcom/sun/org/apache/xml/internal/dtm/DTM;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDTM", "(Ljavax/xml/transform/Source;ZLcom/sun/org/apache/xml/internal/dtm/DTMWSFilter;ZZ)Lcom/sun/org/apache/xml/internal/dtm/DTM;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDTMHandleFromNode", "(Lorg/w3c/dom/Node;)I"));
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DUMPTREE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xml/internal/dtm/DTM;", "protected")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTM> m_dtms_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTM>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[I", "")]
	public JavaArray<int> m_dtm_offsets_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/utils/XMLReaderManager;", "protected")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLReaderManager m_readerManager_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.utils.XMLReaderManager>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lorg/xml/sax/helpers/DefaultHandler;", "protected")]
	public Dova.JDK.org.xml.sax.helpers.DefaultHandler m_defaultHandler_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.xml.sax.helpers.DefaultHandler>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/dtm/ref/ExpandedNameTable;", "private")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.@ref.ExpandedNameTable m_expandedNameTable_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.@ref.ExpandedNameTable>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DTMManagerDefault(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DTMManagerDefault() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xml/internal/dtm/ref/DTMManagerDefault;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/DTM;Z)Z", "public synchronized")]
	public bool release(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTM arg0, bool arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/DTM;)Lcom/sun/org/apache/xml/internal/dtm/ref/ExpandedNameTable;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.@ref.ExpandedNameTable getExpandedNameTable(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTM arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.@ref.ExpandedNameTable>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/DTM;I)V", "public synchronized")]
	public void addDTM(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTM arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/DTM;II)V", "public synchronized")]
	public void addDTM(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTM arg0, int arg1, int arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()I", "public synchronized")]
	public int getFirstFreeDTMID()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("(Lorg/xml/sax/XMLReader;)V", "public synchronized")]
	public void releaseXMLReader(Dova.JDK.org.xml.sax.XMLReader arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljavax/xml/transform/Source;)Lorg/xml/sax/XMLReader;", "public synchronized")]
	public Dova.JDK.org.xml.sax.XMLReader getXMLReader(Dova.JDK.javax.xml.transform.Source arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.xml.sax.XMLReader>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xml/internal/dtm/DTM;", "public synchronized")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTM createDocumentFragment()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTM>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/DTM;)I", "public synchronized")]
	public int getDTMIdentity(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTM arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xml/internal/dtm/DTMIterator;", "public synchronized")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMIterator createDTMIterator(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMIterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xml/internal/utils/PrefixResolver;)Lcom/sun/org/apache/xml/internal/dtm/DTMIterator;", "public synchronized")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMIterator createDTMIterator(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xml.@internal.utils.PrefixResolver arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMIterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)Lcom/sun/org/apache/xml/internal/dtm/DTMIterator;", "public synchronized")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMIterator createDTMIterator(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMIterator>(ret);
	}

	[JniSignatureAttribute("(ILcom/sun/org/apache/xml/internal/dtm/DTMFilter;Z)Lcom/sun/org/apache/xml/internal/dtm/DTMIterator;", "public synchronized")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMIterator createDTMIterator(int arg0, Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMFilter arg1, bool arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMIterator>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xml/internal/dtm/DTM;", "public synchronized")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTM getDTM(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTM>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/transform/Source;ZLcom/sun/org/apache/xml/internal/dtm/DTMWSFilter;ZZ)Lcom/sun/org/apache/xml/internal/dtm/DTM;", "public synchronized")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTM getDTM(Dova.JDK.javax.xml.transform.Source arg0, bool arg1, Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMWSFilter arg2, bool arg3, bool arg4)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTM>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)I", "public synchronized")]
	public int getDTMHandleFromNode(Dova.JDK.org.w3c.dom.Node arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}
}
