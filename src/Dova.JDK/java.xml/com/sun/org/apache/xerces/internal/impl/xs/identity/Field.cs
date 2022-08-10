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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field;", "public")]
public partial class Field
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Field()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fXPath", "Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field$XPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fIdentityConstraint", "Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Field", "(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field$XPath;Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getIdentityConstraint", "()Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createMatcher", "(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/ValueStore;)Lcom/sun/org/apache/xerces/internal/impl/xs/identity/XPathMatcher;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getXPath", "()Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath;"));
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field$XPath;", "protected final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.Field.XPath fXPath_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.Field.XPath>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;", "protected final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint fIdentityConstraint_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Field(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field$XPath;Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;)V", "public")]
	public Field(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.Field.XPath arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint getIdentityConstraint()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/ValueStore;)Lcom/sun/org/apache/xerces/internal/impl/xs/identity/XPathMatcher;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.XPathMatcher createMatcher(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.ValueStore arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.XPathMatcher>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xpath/XPath;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath getXPath()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field$XPath;", "public static")]
	public partial class XPath
		: Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xpath.XPath
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XPath()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field$XPath;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "XPath", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/util/SymbolTable;Lcom/sun/org/apache/xerces/internal/xni/NamespaceContext;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "fixupXPath", "(Ljava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "fixupXPath2", "(Ljava/lang/String;II)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XPath(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/util/SymbolTable;Lcom/sun/org/apache/xerces/internal/xni/NamespaceContext;)V", "public")]
		public XPath(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolTable arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.NamespaceContext arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field$XPath;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private static")]
		public static Dova.JDK.java.lang.String fixupXPath(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;II)Ljava/lang/String;", "private static")]
		public static Dova.JDK.java.lang.String fixupXPath2(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field$Matcher;", "protected")]
	public partial class Matcher
		: Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.XPathMatcher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Matcher()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field$Matcher;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fStore", "Lcom/sun/org/apache/xerces/internal/impl/xs/identity/ValueStore;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fMayMatch", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Matcher", "(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field;Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field$XPath;Lcom/sun/org/apache/xerces/internal/impl/xs/identity/ValueStore;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "matched", "(Ljava/lang/Object;SLcom/sun/org/apache/xerces/internal/xs/ShortList;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "convertToPrimitiveKind", "(Lcom/sun/org/apache/xerces/internal/xs/ShortList;)Lcom/sun/org/apache/xerces/internal/xs/ShortList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "convertToPrimitiveKind", "(S)S"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleContent", "(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;ZLjava/lang/Object;SLcom/sun/org/apache/xerces/internal/xs/ShortList;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/identity/ValueStore;", "protected final")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.ValueStore fStore_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.ValueStore>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "protected")]
		public bool fMayMatch_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field;", "final")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.Field this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.Field>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Matcher(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field;Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field$XPath;Lcom/sun/org/apache/xerces/internal/impl/xs/identity/ValueStore;)V", "public")]
		public Matcher(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.Field arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.Field.XPath arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.ValueStore arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field$Matcher;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;SLcom/sun/org/apache/xerces/internal/xs/ShortList;Z)V", "protected")]
		public void matched(Dova.JDK.java.lang.Object arg0, short arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.ShortList arg2, bool arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/ShortList;)Lcom/sun/org/apache/xerces/internal/xs/ShortList;", "private")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.ShortList convertToPrimitiveKind(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.ShortList arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.ShortList>(ret);
		}

		[JniSignatureAttribute("(S)S", "private")]
		public short convertToPrimitiveKind(short arg0)
		{
			var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;ZLjava/lang/Object;SLcom/sun/org/apache/xerces/internal/xs/ShortList;)V", "protected")]
		public void handleContent(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition arg0, bool arg1, Dova.JDK.java.lang.Object arg2, short arg3, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.ShortList arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
		}
	}
}
