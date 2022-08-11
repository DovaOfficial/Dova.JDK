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

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/trax/TemplatesImpl;", "public final")]
public partial class TemplatesImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.xml.transform.Templates
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TemplatesImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/trax/TemplatesImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESERIALIZE_TRANSLET", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABSTRACT_TRANSLET", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_bytecodes", "[[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_class", "[Ljava/lang/Class;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_transletIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_auxClasses", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_outputProperties", "Ljava/util/Properties;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_indentNumber", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_uriResolver", "Ljavax/xml/transform/URIResolver;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_sdom", "Ljava/lang/ThreadLocal;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_tfactory", "Lcom/sun/org/apache/xalan/internal/xsltc/trax/TransformerFactoryImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_overrideDefaultParser", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_accessExternalStylesheet", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialPersistentFields", "[Ljava/io/ObjectStreamField;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/lang/Class;Ljava/lang/String;Ljava/util/Properties;ILcom/sun/org/apache/xalan/internal/xsltc/trax/TransformerFactoryImpl;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([[BLjava/lang/String;Ljava/util/Properties;ILcom/sun/org/apache/xalan/internal/xsltc/trax/TransformerFactoryImpl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "(Ljava/lang/String;Ljava/util/Properties;ILcom/sun/org/apache/xalan/internal/xsltc/trax/TransformerFactoryImpl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineTransletClasses", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createModule", "(Ljava/lang/module/ModuleDescriptor;Ljava/lang/ClassLoader;)Ljava/lang/Module;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransletInstance", "()Lcom/sun/org/apache/xalan/internal/xsltc/Translet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTransletBytecodes", "([[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransletBytecodes", "()[[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransletClasses", "()[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransletIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTransletName", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransletName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStylesheetDOM", "()Lcom/sun/org/apache/xalan/internal/xsltc/DOM;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStylesheetDOM", "(Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "overrideDefaultParser", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newTransformer", "()Ljavax/xml/transform/Transformer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setURIResolver", "(Ljavax/xml/transform/URIResolver;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutputProperties", "()Ljava/util/Properties;"));
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

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DESERIALIZE_TRANSLET_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String ABSTRACT_TRANSLET_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String _name_Property
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

	[JniSignatureAttribute("[[B", "private")]
	public JavaArray<JavaArray<byte>> _bytecodes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<byte>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/Class;", "private")]
	public JavaArray<Dova.JDK.java.lang.Class> _class_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int _transletIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private transient")]
	public Dova.JDK.java.util.Map _auxClasses_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Properties;", "private")]
	public Dova.JDK.java.util.Properties _outputProperties_Property
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

	[JniSignatureAttribute("I", "private")]
	public int _indentNumber_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("Ljavax/xml/transform/URIResolver;", "private transient")]
	public Dova.JDK.javax.xml.transform.URIResolver _uriResolver_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.transform.URIResolver>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ThreadLocal;", "private transient")]
	public Dova.JDK.java.lang.ThreadLocal _sdom_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ThreadLocal>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/trax/TransformerFactoryImpl;", "private transient")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.trax.TransformerFactoryImpl _tfactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.trax.TransformerFactoryImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private transient")]
	public bool _overrideDefaultParser_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private transient")]
	public Dova.JDK.java.lang.String _accessExternalStylesheet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/io/ObjectStreamField;", "private static final")]
	public static JavaArray<Dova.JDK.java.io.ObjectStreamField> serialPersistentFields_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.io.ObjectStreamField>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TemplatesImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public TemplatesImpl() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("([Ljava/lang/Class;Ljava/lang/String;Ljava/util/Properties;ILcom/sun/org/apache/xalan/internal/xsltc/trax/TransformerFactoryImpl;)V", "protected")]
	public TemplatesImpl(JavaArray<Dova.JDK.java.lang.Class> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Properties arg2, int arg3, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.trax.TransformerFactoryImpl arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("([[BLjava/lang/String;Ljava/util/Properties;ILcom/sun/org/apache/xalan/internal/xsltc/trax/TransformerFactoryImpl;)V", "protected")]
	public TemplatesImpl(JavaArray<JavaArray<byte>> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Properties arg2, int arg3, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.trax.TransformerFactoryImpl arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/trax/TemplatesImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Properties;ILcom/sun/org/apache/xalan/internal/xsltc/trax/TransformerFactoryImpl;)V", "private")]
	public void init(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Properties arg1, int arg2, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.trax.TransformerFactoryImpl arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private")]
	public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void defineTransletClasses()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Ljava/lang/module/ModuleDescriptor;Ljava/lang/ClassLoader;)Ljava/lang/Module;", "private")]
	public Dova.JDK.java.lang.Module createModule(Dova.JDK.java.lang.module.ModuleDescriptor arg0, Dova.JDK.java.lang.ClassLoader arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Module>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xalan/internal/xsltc/Translet;", "private")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.Translet getTransletInstance()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.Translet>(ret);
	}

	[JniSignatureAttribute("([[B)V", "private synchronized")]
	public void setTransletBytecodes(JavaArray<JavaArray<byte>> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()[[B", "private synchronized")]
	public JavaArray<JavaArray<byte>> getTransletBytecodes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<JavaArray<JavaArray<byte>>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/Class;", "private synchronized")]
	public JavaArray<Dova.JDK.java.lang.Class> getTransletClasses()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("()I", "public synchronized")]
	public int getTransletIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "protected synchronized")]
	public void setTransletName(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "protected synchronized")]
	public Dova.JDK.java.lang.String getTransletName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xalan/internal/xsltc/DOM;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM getStylesheetDOM()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)V", "public")]
	public void setStylesheetDOM(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool overrideDefaultParser()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/xml/transform/Transformer;", "public synchronized")]
	public Dova.JDK.javax.xml.transform.Transformer newTransformer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.transform.Transformer>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/transform/URIResolver;)V", "public synchronized")]
	public void setURIResolver(Dova.JDK.javax.xml.transform.URIResolver arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/Properties;", "public synchronized")]
	public Dova.JDK.java.util.Properties getOutputProperties()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Properties>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/trax/TemplatesImpl$TransletClassLoader;", "static final")]
	public partial class TransletClassLoader
		: Dova.JDK.java.lang.ClassLoader
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TransletClassLoader()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/trax/TemplatesImpl$TransletClassLoader;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_loadedExternalExtensionFunctions", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;Ljava/util/Map;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadClass", "(Ljava/lang/String;)Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineClass", "([B)Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineClass", "([BLjava/security/ProtectionDomain;)Ljava/lang/Class;"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map _loadedExternalExtensionFunctions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TransletClassLoader(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;)V", "")]
		public TransletClassLoader(Dova.JDK.java.lang.ClassLoader arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/util/Map;)V", "")]
		public TransletClassLoader(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.util.Map arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/trax/TemplatesImpl$TransletClassLoader;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Class;", "public")]
		public Dova.JDK.java.lang.Class loadClass(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("([B)Ljava/lang/Class;", "")]
		public Dova.JDK.java.lang.Class defineClass(JavaArray<byte> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("([BLjava/security/ProtectionDomain;)Ljava/lang/Class;", "")]
		public Dova.JDK.java.lang.Class defineClass(JavaArray<byte> arg0, Dova.JDK.java.security.ProtectionDomain arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}
	}
}
