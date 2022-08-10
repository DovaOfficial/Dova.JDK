/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath;", "public")]
public partial class XPath
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XPath()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DEBUG_ALL", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DEBUG_XPATH_PARSE", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fExpression", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fSymbolTable", "Lcom/sun/org/apache/xerces/internal/util/SymbolTable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fLocationPaths", "[Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$LocationPath;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "XPath", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/util/SymbolTable;Lcom/sun/org/apache/xerces/internal/xni/NamespaceContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "main", "([Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "check", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseExpression", "(Lcom/sun/org/apache/xerces/internal/xni/NamespaceContext;)[Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$LocationPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLocationPaths", "()[Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$LocationPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "buildLocationPath", "(Ljava/util/ArrayList;)Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$LocationPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseNodeTest", "(ILcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Tokens;Lcom/sun/org/apache/xerces/internal/xni/NamespaceContext;)Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$NodeTest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLocationPath", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$LocationPath;"));
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_ALL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_XPATH_PARSE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected final")]
	public Dova.JDK.java.lang.String fExpression_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolTable;", "protected final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable fSymbolTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$LocationPath;", "protected final")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.LocationPath> fLocationPaths_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.LocationPath>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XPath(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/util/SymbolTable;Lcom/sun/org/apache/xerces/internal/xni/NamespaceContext;)V", "public")]
	public XPath(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.NamespaceContext arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Ljava/lang/String;)V", "public static")]
	public static void main(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Z)V", "private static")]
	public static void check(bool arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/NamespaceContext;)[Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$LocationPath;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.LocationPath> parseExpression(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.NamespaceContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.LocationPath>>(ret);
	}

	[JniSignatureAttribute("()[Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$LocationPath;", "public")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.LocationPath> getLocationPaths()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.LocationPath>>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/ArrayList;)Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$LocationPath;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.LocationPath buildLocationPath(Dova.JDK.java.util.ArrayList arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.LocationPath>(ret);
	}

	[JniSignatureAttribute("(ILcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Tokens;Lcom/sun/org/apache/xerces/internal/xni/NamespaceContext;)Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$NodeTest;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.NodeTest parseNodeTest(int arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.Tokens arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.NamespaceContext arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.NodeTest>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$LocationPath;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.LocationPath getLocationPath()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.LocationPath>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$LocationPath;", "public static")]
	public partial class LocationPath
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Cloneable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LocationPath()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$LocationPath;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "steps", "[Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Step;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LocationPath", "([Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Step;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LocationPath", "(Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$LocationPath;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "clone", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Step;", "public final")]
		public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.Step> steps_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.Step>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LocationPath(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Step;)V", "public")]
		public LocationPath(JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.Step> arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$LocationPath;)V", "protected")]
		public LocationPath(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.LocationPath arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$LocationPath;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object clone()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Step;", "public static")]
	public partial class Step
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Cloneable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Step()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Step;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "axis", "Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Axis;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "nodeTest", "Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$NodeTest;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Step", "(Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Axis;Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$NodeTest;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Step", "(Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Step;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "clone", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Axis;", "public final")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.Axis axis_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.Axis>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$NodeTest;", "public final")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.NodeTest nodeTest_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.NodeTest>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Step(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Axis;Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$NodeTest;)V", "public")]
		public Step(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.Axis arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.NodeTest arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Step;)V", "protected")]
		public Step(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.Step arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Step;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object clone()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Tokens;", "private static final")]
	public partial class Tokens
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Tokens()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Tokens;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DUMP_TOKENS", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_OPEN_PAREN", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_CLOSE_PAREN", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_OPEN_BRACKET", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_CLOSE_BRACKET", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_PERIOD", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_DOUBLE_PERIOD", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_ATSIGN", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_COMMA", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_DOUBLE_COLON", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_NAMETEST_ANY", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_NAMETEST_NAMESPACE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_NAMETEST_QNAME", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_NODETYPE_COMMENT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_NODETYPE_TEXT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_NODETYPE_PI", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_NODETYPE_NODE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_OPERATOR_AND", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_OPERATOR_OR", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_OPERATOR_MOD", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_OPERATOR_DIV", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_OPERATOR_MULT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_OPERATOR_SLASH", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_OPERATOR_DOUBLE_SLASH", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_OPERATOR_UNION", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_OPERATOR_PLUS", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_OPERATOR_MINUS", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_OPERATOR_EQUAL", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_OPERATOR_NOT_EQUAL", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_OPERATOR_LESS", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_OPERATOR_LESS_EQUAL", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_OPERATOR_GREATER", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_OPERATOR_GREATER_EQUAL", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_FUNCTION_NAME", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_AXISNAME_ANCESTOR", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_AXISNAME_ANCESTOR_OR_SELF", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_AXISNAME_ATTRIBUTE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_AXISNAME_CHILD", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_AXISNAME_DESCENDANT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_AXISNAME_DESCENDANT_OR_SELF", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_AXISNAME_FOLLOWING", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_AXISNAME_FOLLOWING_SIBLING", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_AXISNAME_NAMESPACE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_AXISNAME_PARENT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_AXISNAME_PRECEDING", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_AXISNAME_PRECEDING_SIBLING", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_AXISNAME_SELF", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_LITERAL", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_NUMBER", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRTOKEN_VARIABLE_REFERENCE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fgTokenNames", "[Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INITIAL_TOKEN_COUNT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fTokens", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fTokenCount", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fSymbolTable", "Lcom/sun/org/apache/xerces/internal/util/SymbolTable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fSymbolMapping", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fTokenNames", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fCurrentTokenIndex", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Tokens", "(Lcom/sun/org/apache/xerces/internal/util/SymbolTable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextToken", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "rewind", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTokenString", "(I)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "peekToken", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addToken", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addToken", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextTokenAsString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hasMore", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dumpTokens", "()V"));
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool DUMP_TOKENS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_OPEN_PAREN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_CLOSE_PAREN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_OPEN_BRACKET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_CLOSE_BRACKET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_PERIOD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_DOUBLE_PERIOD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_ATSIGN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_COMMA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_DOUBLE_COLON_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_NAMETEST_ANY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[10]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[10], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_NAMETEST_NAMESPACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[11]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[11], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_NAMETEST_QNAME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_NODETYPE_COMMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_NODETYPE_TEXT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[14]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[14], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_NODETYPE_PI_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[15]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[15], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_NODETYPE_NODE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[16]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[16], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_OPERATOR_AND_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[17]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[17], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_OPERATOR_OR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[18]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[18], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_OPERATOR_MOD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[19]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[19], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_OPERATOR_DIV_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[20]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[20], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_OPERATOR_MULT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[21]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[21], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_OPERATOR_SLASH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[22]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[22], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_OPERATOR_DOUBLE_SLASH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[23]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[23], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_OPERATOR_UNION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[24]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[24], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_OPERATOR_PLUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[25]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[25], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_OPERATOR_MINUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[26]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[26], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_OPERATOR_EQUAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[27]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[27], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_OPERATOR_NOT_EQUAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[28]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[28], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_OPERATOR_LESS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[29]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[29], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_OPERATOR_LESS_EQUAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[30]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[30], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_OPERATOR_GREATER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[31]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[31], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_OPERATOR_GREATER_EQUAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[32]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[32], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_FUNCTION_NAME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[33]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[33], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_AXISNAME_ANCESTOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[34]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[34], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_AXISNAME_ANCESTOR_OR_SELF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[35]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[35], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_AXISNAME_ATTRIBUTE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[36]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[36], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_AXISNAME_CHILD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[37]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[37], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_AXISNAME_DESCENDANT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[38]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[38], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_AXISNAME_DESCENDANT_OR_SELF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[39]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[39], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_AXISNAME_FOLLOWING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[40]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[40], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_AXISNAME_FOLLOWING_SIBLING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[41]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[41], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_AXISNAME_NAMESPACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[42]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[42], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_AXISNAME_PARENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[43]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[43], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_AXISNAME_PRECEDING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[44]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[44], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_AXISNAME_PRECEDING_SIBLING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[45]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[45], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_AXISNAME_SELF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[46]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[46], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_LITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[47]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[47], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_NUMBER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[48]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[48], value);
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int EXPRTOKEN_VARIABLE_REFERENCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[49]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[49], value);
		}

		[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.String> fgTokenNames_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int INITIAL_TOKEN_COUNT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[51]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[51], value);
		}

		[JniSignatureAttribute("[I", "private")]
		public JavaArray<int> fTokens_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[52]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[52], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "private")]
		public int fTokenCount_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[53]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[53], value);
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolTable;", "private final")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable fSymbolTable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[54]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[54], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map fSymbolMapping_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[55]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[55], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map fTokenNames_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[56]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[56], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "private")]
		public int fCurrentTokenIndex_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[57]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[57], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Tokens(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/util/SymbolTable;)V", "public")]
		public Tokens(Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Tokens;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int nextToken()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()V", "public")]
		public void rewind()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getTokenString(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int peekToken()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void addToken(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void addToken(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String nextTokenAsString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasMore()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("()V", "public")]
		public void dumpTokens()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Scanner;", "private static")]
	public partial class Scanner
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Scanner()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Scanner;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_INVALID", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_OTHER", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_WHITESPACE", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_EXCLAMATION", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_QUOTE", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_DOLLAR", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_OPEN_PAREN", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_CLOSE_PAREN", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_STAR", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_PLUS", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_COMMA", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_MINUS", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_PERIOD", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_SLASH", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_DIGIT", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_COLON", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_LESS", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_EQUAL", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_GREATER", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_ATSIGN", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_LETTER", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_OPEN_BRACKET", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_CLOSE_BRACKET", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_UNDERSCORE", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_UNION", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHARTYPE_NONASCII", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fASCIICharMap", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fSymbolTable", "Lcom/sun/org/apache/xerces/internal/util/SymbolTable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fAndSymbol", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fOrSymbol", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fModSymbol", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fDivSymbol", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fCommentSymbol", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fTextSymbol", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fPISymbol", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fNodeSymbol", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fAncestorSymbol", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fAncestorOrSelfSymbol", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fAttributeSymbol", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fChildSymbol", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fDescendantSymbol", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fDescendantOrSelfSymbol", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fFollowingSymbol", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fFollowingSiblingSymbol", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fNamespaceSymbol", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fParentSymbol", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fPrecedingSymbol", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fPrecedingSiblingSymbol", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "fSelfSymbol", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Scanner", "(Lcom/sun/org/apache/xerces/internal/util/SymbolTable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addToken", "(Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Tokens;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "scanNCName", "(Ljava/lang/String;II)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "scanExpr", "(Lcom/sun/org/apache/xerces/internal/util/SymbolTable;Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Tokens;Ljava/lang/String;II)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "scanNumber", "(Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Tokens;Ljava/lang/String;II)I"));
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_INVALID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_OTHER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_WHITESPACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_EXCLAMATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_QUOTE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_DOLLAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_OPEN_PAREN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[6]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[6], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_CLOSE_PAREN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[7]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[7], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_STAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[8]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[8], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_PLUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[9]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[9], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_COMMA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[10]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[10], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_MINUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[11]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[11], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_PERIOD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[12]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[12], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_SLASH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[13]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[13], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_DIGIT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[14]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[14], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_COLON_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[15]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[15], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_LESS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[16]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[16], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_EQUAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[17]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[17], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_GREATER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[18]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[18], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_ATSIGN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[19]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[19], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_LETTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[20]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[20], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_OPEN_BRACKET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[21]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[21], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_CLOSE_BRACKET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[22]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[22], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_UNDERSCORE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[23]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[23], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_UNION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[24]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[24], value);
		}

		[JniSignatureAttribute("B", "private static final")]
		public static byte CHARTYPE_NONASCII_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[25]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[25], value);
		}

		[JniSignatureAttribute("[B", "private static final")]
		public static JavaArray<byte> fASCIICharMap_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolTable;", "private")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable fSymbolTable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String fAndSymbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String fOrSymbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String fModSymbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String fDivSymbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String fCommentSymbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String fTextSymbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String fPISymbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String fNodeSymbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String fAncestorSymbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String fAncestorOrSelfSymbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String fAttributeSymbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String fChildSymbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String fDescendantSymbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String fDescendantOrSelfSymbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String fFollowingSymbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String fFollowingSiblingSymbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String fNamespaceSymbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String fParentSymbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String fPrecedingSymbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String fPrecedingSiblingSymbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String fSelfSymbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Scanner(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/util/SymbolTable;)V", "public")]
		public Scanner(Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Scanner;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Tokens;I)V", "protected")]
		public void addToken(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.Tokens arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;II)I", "")]
		public int scanNCName(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/util/SymbolTable;Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Tokens;Ljava/lang/String;II)Z", "public")]
		public bool scanExpr(Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.Tokens arg1, Dova.JDK.java.lang.String arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Tokens;Ljava/lang/String;II)I", "private")]
		public int scanNumber(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.Tokens arg0, Dova.JDK.java.lang.String arg1, int arg2, int arg3)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Axis;", "public static")]
	public partial class Axis
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Cloneable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Axis()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Axis;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHILD", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ATTRIBUTE", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SELF", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DESCENDANT", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "type", "S"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Axis", "(S)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Axis", "(Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Axis;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "clone", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("S", "public static final")]
		public static short CHILD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("S", "public static final")]
		public static short ATTRIBUTE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("S", "public static final")]
		public static short SELF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("S", "public static final")]
		public static short DESCENDANT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("S", "public final")]
		public short type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Axis(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(S)V", "public")]
		public Axis(short arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Axis;)V", "protected")]
		public Axis(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.Axis arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$Axis;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object clone()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$NodeTest;", "public static")]
	public partial class NodeTest
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Cloneable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NodeTest()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$NodeTest;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "QNAME", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "WILDCARD", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NODE", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NAMESPACE", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "type", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "name", "Lcom/sun/org/apache/xerces/internal/xni/QName;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "NodeTest", "(Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$NodeTest;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "NodeTest", "(Ljava/lang/String;Ljava/lang/String;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "NodeTest", "(Lcom/sun/org/apache/xerces/internal/xni/QName;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "NodeTest", "(S)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "clone", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("S", "public static final")]
		public static short QNAME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("S", "public static final")]
		public static short WILDCARD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("S", "public static final")]
		public static short NODE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("S", "public static final")]
		public static short NAMESPACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("S", "public final")]
		public short type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/QName;", "public final")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NodeTest(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$NodeTest;)V", "public")]
		public NodeTest(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath.NodeTest arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public")]
		public NodeTest(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;)V", "public")]
		public NodeTest(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0))
		{
		}

		[JniSignatureAttribute("(S)V", "public")]
		public NodeTest(short arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[3], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath$NodeTest;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object clone()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
