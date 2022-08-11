/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.security.pkcs11;

[JniSignatureAttribute("Lsun/security/pkcs11/TemplateManager;", "final")]
public partial class TemplateManager
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TemplateManager()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/pkcs11/TemplateManager;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "O_ANY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "O_IMPORT", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "O_GENERATE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "primitiveTemplates", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "compositeTemplates", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "(Ljava/lang/String;JJ[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTemplate", "(Ljava/lang/String;JJ[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildCompositeTemplate", "(Lsun/security/pkcs11/TemplateManager$TemplateKey;)Lsun/security/pkcs11/TemplateManager$Template;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTemplate", "(Lsun/security/pkcs11/TemplateManager$TemplateKey;)Lsun/security/pkcs11/TemplateManager$Template;"));
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String O_ANY_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String O_IMPORT_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String O_GENERATE_Property
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

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List primitiveTemplates_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map compositeTemplates_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TemplateManager(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public TemplateManager() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/pkcs11/TemplateManager;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;JJ[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "")]
	public JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> getAttributes(Dova.JDK.java.lang.String arg0, long arg1, long arg2, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;JJ[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)V", "")]
	public void addTemplate(Dova.JDK.java.lang.String arg0, long arg1, long arg2, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/TemplateManager$TemplateKey;)Lsun/security/pkcs11/TemplateManager$Template;", "private")]
	public Dova.JDK.sun.security.pkcs11.TemplateManager.Template buildCompositeTemplate(Dova.JDK.sun.security.pkcs11.TemplateManager.TemplateKey arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.TemplateManager.Template>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/TemplateManager$TemplateKey;)Lsun/security/pkcs11/TemplateManager$Template;", "private")]
	public Dova.JDK.sun.security.pkcs11.TemplateManager.Template getTemplate(Dova.JDK.sun.security.pkcs11.TemplateManager.TemplateKey arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.TemplateManager.Template>(ret);
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/TemplateManager$TemplateKey;", "private static final")]
	public partial class TemplateKey
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TemplateKey()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/pkcs11/TemplateManager$TemplateKey;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "operation", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyType", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyAlgorithm", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;JJ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appliesTo", "(Lsun/security/pkcs11/TemplateManager$TemplateKey;)Z"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String operation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("J", "final")]
		public long keyType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("J", "final")]
		public long keyAlgorithm_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TemplateKey(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;JJ)V", "")]
		public TemplateKey(Dova.JDK.java.lang.String arg0, long arg1, long arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/pkcs11/TemplateManager$TemplateKey;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
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

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("(Lsun/security/pkcs11/TemplateManager$TemplateKey;)Z", "")]
		public bool appliesTo(Dova.JDK.sun.security.pkcs11.TemplateManager.TemplateKey arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/TemplateManager$Template;", "private static final")]
	public partial class Template
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Template()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/pkcs11/TemplateManager$Template;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "A0", "[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attributes", "[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Lsun/security/pkcs11/TemplateManager$Template;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "combine", "([Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "([Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;"));
		}

		[JniSignatureAttribute("[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "private static final")]
		public static JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> A0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "private")]
		public JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> attributes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Template(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Template() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("([Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)V", "")]
		public Template(JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/pkcs11/TemplateManager$Template;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/pkcs11/TemplateManager$Template;)V", "")]
		public void add(Dova.JDK.sun.security.pkcs11.TemplateManager.Template arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("([Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "private static")]
		public static JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> combine(JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg0, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE>>(ret);
		}

		[JniSignatureAttribute("([Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "")]
		public JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> getAttributes(JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE>>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/TemplateManager$KeyAndTemplate;", "private static")]
	public partial class KeyAndTemplate
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static KeyAndTemplate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/pkcs11/TemplateManager$KeyAndTemplate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Lsun/security/pkcs11/TemplateManager$TemplateKey;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "template", "Lsun/security/pkcs11/TemplateManager$Template;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/pkcs11/TemplateManager$TemplateKey;Lsun/security/pkcs11/TemplateManager$Template;)V"));
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/TemplateManager$TemplateKey;", "final")]
		public Dova.JDK.sun.security.pkcs11.TemplateManager.TemplateKey key_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.TemplateManager.TemplateKey>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/TemplateManager$Template;", "final")]
		public Dova.JDK.sun.security.pkcs11.TemplateManager.Template template_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.TemplateManager.Template>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public KeyAndTemplate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/pkcs11/TemplateManager$TemplateKey;Lsun/security/pkcs11/TemplateManager$Template;)V", "")]
		public KeyAndTemplate(Dova.JDK.sun.security.pkcs11.TemplateManager.TemplateKey arg0, Dova.JDK.sun.security.pkcs11.TemplateManager.Template arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/pkcs11/TemplateManager$KeyAndTemplate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
