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

namespace Dova.JDK.com.sun.org.apache.xml.@internal.security.transforms.implementations;

[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/security/transforms/implementations/TransformXPath;", "public")]
public partial class TransformXPath
	: Dova.JDK.com.sun.org.apache.xml.@internal.security.transforms.TransformSpi
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TransformXPath()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/security/transforms/implementations/TransformXPath;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOG", "Lcom/sun/org/slf4j/internal/Logger;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "enginePerformTransform", "(Lcom/sun/org/apache/xml/internal/security/signature/XMLSignatureInput;Ljava/io/OutputStream;Lorg/w3c/dom/Element;Ljava/lang/String;Z)Lcom/sun/org/apache/xml/internal/security/signature/XMLSignatureInput;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetURI", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "needsCircumvent", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getXPathFactory", "()Lcom/sun/org/apache/xml/internal/security/utils/XPathFactory;"));
	}

	[JniSignatureAttribute("Lcom/sun/org/slf4j/internal/Logger;", "private static final")]
	public static Dova.JDK.com.sun.org.slf4j.@internal.Logger LOG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.slf4j.@internal.Logger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TransformXPath(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public TransformXPath() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xml/internal/security/transforms/implementations/TransformXPath;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/security/signature/XMLSignatureInput;Ljava/io/OutputStream;Lorg/w3c/dom/Element;Ljava/lang/String;Z)Lcom/sun/org/apache/xml/internal/security/signature/XMLSignatureInput;", "protected")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.XMLSignatureInput enginePerformTransform(Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.XMLSignatureInput arg0, Dova.JDK.java.io.OutputStream arg1, Dova.JDK.org.w3c.dom.Element arg2, Dova.JDK.java.lang.String arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.XMLSignatureInput>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String engineGetURI()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool needsCircumvent(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xml/internal/security/utils/XPathFactory;", "protected")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.security.utils.XPathFactory getXPathFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.security.utils.XPathFactory>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/security/transforms/implementations/TransformXPath$XPathNodeFilter;", "private static")]
	public partial class XPathNodeFilter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.NodeFilter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XPathNodeFilter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/security/transforms/implementations/TransformXPath$XPathNodeFilter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xPathAPI", "Lcom/sun/org/apache/xml/internal/security/utils/XPathAPI;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xpathnode", "Lorg/w3c/dom/Node;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xpathElement", "Lorg/w3c/dom/Element;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "str", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Element;Lorg/w3c/dom/Node;Ljava/lang/String;Lcom/sun/org/apache/xml/internal/security/utils/XPathAPI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNodeIncludeDO", "(Lorg/w3c/dom/Node;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNodeInclude", "(Lorg/w3c/dom/Node;)I"));
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/security/utils/XPathAPI;", "private final")]
		public Dova.JDK.com.sun.org.apache.xml.@internal.security.utils.XPathAPI xPathAPI_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.security.utils.XPathAPI>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lorg/w3c/dom/Node;", "private final")]
		public Dova.JDK.org.w3c.dom.Node xpathnode_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lorg/w3c/dom/Element;", "private final")]
		public Dova.JDK.org.w3c.dom.Element xpathElement_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Element>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String str_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XPathNodeFilter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lorg/w3c/dom/Element;Lorg/w3c/dom/Node;Ljava/lang/String;Lcom/sun/org/apache/xml/internal/security/utils/XPathAPI;)V", "")]
		public XPathNodeFilter(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.org.w3c.dom.Node arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.com.sun.org.apache.xml.@internal.security.utils.XPathAPI arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xml/internal/security/transforms/implementations/TransformXPath$XPathNodeFilter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lorg/w3c/dom/Node;I)I", "public")]
		public int isNodeIncludeDO(Dova.JDK.org.w3c.dom.Node arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Lorg/w3c/dom/Node;)I", "public")]
		public int isNodeInclude(Dova.JDK.org.w3c.dom.Node arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}
}
