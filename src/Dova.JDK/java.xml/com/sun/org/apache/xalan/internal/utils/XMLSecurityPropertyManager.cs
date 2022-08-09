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

namespace Dova.JDK.com.sun.org.apache.xalan.@internal.utils;

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/utils/XMLSecurityPropertyManager;", "public final")]
public partial class XMLSecurityPropertyManager
	: Dova.JDK.com.sun.org.apache.xalan.@internal.utils.FeaturePropertyBase
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMLSecurityPropertyManager()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/utils/XMLSecurityPropertyManager;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "XMLSecurityPropertyManager", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getIndex", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "readSystemProperties", "()V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XMLSecurityPropertyManager(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XMLSecurityPropertyManager() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/utils/XMLSecurityPropertyManager;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int getIndex(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void readSystemProperties()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/utils/XMLSecurityPropertyManager$Property;", "public static final")]
	public partial class Property
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Property()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/utils/XMLSecurityPropertyManager$Property;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ACCESS_EXTERNAL_DTD", "Lcom/sun/org/apache/xalan/internal/utils/XMLSecurityPropertyManager$Property;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ACCESS_EXTERNAL_STYLESHEET", "Lcom/sun/org/apache/xalan/internal/utils/XMLSecurityPropertyManager$Property;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "defaultValue", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/org/apache/xalan/internal/utils/XMLSecurityPropertyManager$Property;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Property", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/org/apache/xalan/internal/utils/XMLSecurityPropertyManager$Property;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/org/apache/xalan/internal/utils/XMLSecurityPropertyManager$Property;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "defaultValue", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/org/apache/xalan/internal/utils/XMLSecurityPropertyManager$Property;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "equalsName", "(Ljava/lang/String;)Z"));
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/utils/XMLSecurityPropertyManager$Property;", "public static final")]
		public static Dova.JDK.com.sun.org.apache.xalan.@internal.utils.XMLSecurityPropertyManager.Property ACCESS_EXTERNAL_DTD_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.utils.XMLSecurityPropertyManager.Property>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/utils/XMLSecurityPropertyManager$Property;", "public static final")]
		public static Dova.JDK.com.sun.org.apache.xalan.@internal.utils.XMLSecurityPropertyManager.Property ACCESS_EXTERNAL_STYLESHEET_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.utils.XMLSecurityPropertyManager.Property>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String defaultValue_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Lcom/sun/org/apache/xalan/internal/utils/XMLSecurityPropertyManager$Property;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.org.apache.xalan.@internal.utils.XMLSecurityPropertyManager.Property> VALUES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xalan.@internal.utils.XMLSecurityPropertyManager.Property>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Property(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V", "private")]
		public Property(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/utils/XMLSecurityPropertyManager$Property;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/org/apache/xalan/internal/utils/XMLSecurityPropertyManager$Property;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.org.apache.xalan.@internal.utils.XMLSecurityPropertyManager.Property> values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xalan.@internal.utils.XMLSecurityPropertyManager.Property>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xalan/internal/utils/XMLSecurityPropertyManager$Property;", "public static")]
		public static Dova.JDK.com.sun.org.apache.xalan.@internal.utils.XMLSecurityPropertyManager.Property valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.utils.XMLSecurityPropertyManager.Property>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String defaultValue()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/org/apache/xalan/internal/utils/XMLSecurityPropertyManager$Property;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.org.apache.xalan.@internal.utils.XMLSecurityPropertyManager.Property> _values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xalan.@internal.utils.XMLSecurityPropertyManager.Property>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
		public bool equalsName(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}
	}
}