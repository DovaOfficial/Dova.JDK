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

namespace Dova.JDK.javax.xml.crypto.dsig.spec;

[JniSignatureAttribute("Ljavax/xml/crypto/dsig/spec/XPathType;", "public")]
public partial class XPathType
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XPathType()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/xml/crypto/dsig/spec/XPathType;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "expression", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "filter", "Ljavax/xml/crypto/dsig/spec/XPathType$Filter;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "nsMap", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "XPathType", "(Ljava/lang/String;Ljavax/xml/crypto/dsig/spec/XPathType$Filter;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "XPathType", "(Ljava/lang/String;Ljavax/xml/crypto/dsig/spec/XPathType$Filter;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getFilter", "()Ljavax/xml/crypto/dsig/spec/XPathType$Filter;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNamespaceMap", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getExpression", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String expression_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/xml/crypto/dsig/spec/XPathType$Filter;", "private final")]
	public Dova.JDK.javax.xml.crypto.dsig.spec.XPathType.Filter filter_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.spec.XPathType.Filter>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map nsMap_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XPathType(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/xml/crypto/dsig/spec/XPathType$Filter;)V", "public")]
	public XPathType(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.xml.crypto.dsig.spec.XPathType.Filter arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/xml/crypto/dsig/spec/XPathType$Filter;Ljava/util/Map;)V", "public")]
	public XPathType(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.xml.crypto.dsig.spec.XPathType.Filter arg1, Dova.JDK.java.util.Map arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/xml/crypto/dsig/spec/XPathType;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/xml/crypto/dsig/spec/XPathType$Filter;", "public")]
	public Dova.JDK.javax.xml.crypto.dsig.spec.XPathType.Filter getFilter()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.spec.XPathType.Filter>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public")]
	public Dova.JDK.java.util.Map getNamespaceMap()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getExpression()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("Ljavax/xml/crypto/dsig/spec/XPathType$Filter;", "public static")]
	public partial class Filter
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Filter()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/xml/crypto/dsig/spec/XPathType$Filter;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "operation", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "INTERSECT", "Ljavax/xml/crypto/dsig/spec/XPathType$Filter;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SUBTRACT", "Ljavax/xml/crypto/dsig/spec/XPathType$Filter;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "UNION", "Ljavax/xml/crypto/dsig/spec/XPathType$Filter;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Filter", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String operation_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/xml/crypto/dsig/spec/XPathType$Filter;", "public static final")]
		public static Dova.JDK.javax.xml.crypto.dsig.spec.XPathType.Filter INTERSECT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.spec.XPathType.Filter>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/xml/crypto/dsig/spec/XPathType$Filter;", "public static final")]
		public static Dova.JDK.javax.xml.crypto.dsig.spec.XPathType.Filter SUBTRACT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.spec.XPathType.Filter>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/xml/crypto/dsig/spec/XPathType$Filter;", "public static final")]
		public static Dova.JDK.javax.xml.crypto.dsig.spec.XPathType.Filter UNION_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.spec.XPathType.Filter>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Filter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
		public Filter(Dova.JDK.java.lang.String arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/xml/crypto/dsig/spec/XPathType$Filter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}
}