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

namespace Dova.JDK.javax.swing.text.html;

[JniSignatureAttribute("Ljavax/swing/text/html/HTML;", "public")]
public partial class HTML
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HTML()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTML;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "tagHashtable", "Ljava/util/Hashtable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "scMapping", "Ljava/util/Hashtable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NULL_ATTRIBUTE_VALUE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "attHashtable", "Ljava/util/Hashtable;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HTML", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getTag", "(Ljava/lang/String;)Ljavax/swing/text/html/HTML$Tag;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAllTags", "()[Ljavax/swing/text/html/HTML$Tag;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getTagForStyleConstantsKey", "(Ljavax/swing/text/StyleConstants;)Ljavax/swing/text/html/HTML$Tag;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAttributeKey", "(Ljava/lang/String;)Ljavax/swing/text/html/HTML$Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getIntegerAttributeValue", "(Ljavax/swing/text/AttributeSet;Ljavax/swing/text/html/HTML$Attribute;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAllAttributeKeys", "()[Ljavax/swing/text/html/HTML$Attribute;"));
	}

	[JniSignatureAttribute("Ljava/util/Hashtable;", "private static final")]
	public static Dova.JDK.java.util.Hashtable tagHashtable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Hashtable;", "private static final")]
	public static Dova.JDK.java.util.Hashtable scMapping_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String NULL_ATTRIBUTE_VALUE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Hashtable;", "private static final")]
	public static Dova.JDK.java.util.Hashtable attHashtable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HTML(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public HTML() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTML;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/swing/text/html/HTML$Tag;", "public static")]
	public static Dova.JDK.javax.swing.text.html.HTML.Tag getTag(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/swing/text/html/HTML$Tag;", "public static")]
	public static JavaArray<Dova.JDK.javax.swing.text.html.HTML.Tag> getAllTags()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.text.html.HTML.Tag>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/StyleConstants;)Ljavax/swing/text/html/HTML$Tag;", "static")]
	public static Dova.JDK.javax.swing.text.html.HTML.Tag getTagForStyleConstantsKey(Dova.JDK.javax.swing.text.StyleConstants arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/swing/text/html/HTML$Attribute;", "public static")]
	public static Dova.JDK.javax.swing.text.html.HTML.Attribute getAttributeKey(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/AttributeSet;Ljavax/swing/text/html/HTML$Attribute;I)I", "public static")]
	public static int getIntegerAttributeValue(Dova.JDK.javax.swing.text.AttributeSet arg0, Dova.JDK.javax.swing.text.html.HTML.Attribute arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()[Ljavax/swing/text/html/HTML$Attribute;", "public static")]
	public static JavaArray<Dova.JDK.javax.swing.text.html.HTML.Attribute> getAllAttributeKeys()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.text.html.HTML.Attribute>>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static")]
	public partial class Tag
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Tag()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTML$Tag;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "blockTag", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "breakTag", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "unknown", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "A", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ADDRESS", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "APPLET", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "AREA", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "B", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BASE", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BASEFONT", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BIG", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BLOCKQUOTE", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BODY", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BR", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CAPTION", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CENTER", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CITE", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CODE", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DD", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DFN", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DIR", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DIV", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DL", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DT", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EM", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FONT", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FORM", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FRAME", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FRAMESET", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "H1", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "H2", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "H3", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "H4", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "H5", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "H6", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HEAD", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HR", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HTML", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "IMG", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INPUT", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISINDEX", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "KBD", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LI", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LINK", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MAP", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MENU", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "META", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NOBR", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NOFRAMES", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OBJECT", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OL", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OPTION", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "P", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PARAM", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PRE", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SAMP", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SCRIPT", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SELECT", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SMALL", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SPAN", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "STRIKE", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "S", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "STRONG", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "STYLE", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SUB", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SUP", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TABLE", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TD", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TEXTAREA", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TH", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TITLE", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TR", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TT", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "U", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "UL", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "VAR", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "IMPLIED", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CONTENT", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "COMMENT", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "allTags", "[Ljavax/swing/text/html/HTML$Tag;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Tag", "(Ljava/lang/String;ZZ)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Tag", "(Ljava/lang/String;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Tag", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isBlock", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "breaksFlow", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isPreformatted", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isParagraph", "()Z"));
		}

		[JniSignatureAttribute("Z", "")]
		public bool blockTag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("Z", "")]
		public bool breakTag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "")]
		public bool unknown_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag A_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag ADDRESS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag APPLET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag AREA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag B_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag BASE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag BASEFONT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag BIG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag BLOCKQUOTE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag BODY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag BR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag CAPTION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag CENTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag CITE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag CODE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag DD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag DFN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag DIR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag DIV_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag DL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag DT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag EM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag FONT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag FORM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag FRAME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag FRAMESET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag H1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag H2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag H3_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag H4_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag H5_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag H6_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag HEAD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag HR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag HTML_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag I_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag IMG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag INPUT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag ISINDEX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag KBD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag LI_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag LINK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag MAP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag MENU_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag META_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag NOBR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag NOFRAMES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag OBJECT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag OL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag OPTION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag P_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[54]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[54], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag PARAM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[55]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[55], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag PRE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[56]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[56], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag SAMP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag SCRIPT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[58]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[58], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag SELECT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[59]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[59], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag SMALL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[60]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[60], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag SPAN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[61]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[61], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag STRIKE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[62]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[62], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag S_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[63]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[63], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag STRONG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[64]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[64], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag STYLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag SUB_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[66]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[66], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag SUP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[67]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[67], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag TABLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[68]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[68], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag TD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[69]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[69], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag TEXTAREA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[70]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[70], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag TH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[71]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[71], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag TITLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[72]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[72], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag TR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[73]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[73], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag TT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[74]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[74], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag U_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[75]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[75], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag UL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[76]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[76], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag VAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[77]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[77], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag IMPLIED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[78]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[78], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag CONTENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[79]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[79], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Tag COMMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[80]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[80], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljavax/swing/text/html/HTML$Tag;", "static final")]
		public static JavaArray<Dova.JDK.javax.swing.text.html.HTML.Tag> allTags_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[81]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.text.html.HTML.Tag>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[81], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Tag(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ZZ)V", "protected")]
		public Tag(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
		public Tag(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Tag() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTML$Tag;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isBlock()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool breaksFlow()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPreformatted()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isParagraph()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
	public partial class Attribute
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Attribute()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTML$Attribute;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SIZE", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "COLOR", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CLEAR", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BACKGROUND", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BGCOLOR", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TEXT", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LINK", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "VLINK", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ALINK", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "WIDTH", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HEIGHT", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ALIGN", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NAME", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HREF", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "REL", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "REV", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TITLE", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TARGET", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SHAPE", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "COORDS", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISMAP", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NOHREF", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ALT", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ID", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SRC", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HSPACE", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "VSPACE", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "USEMAP", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LOWSRC", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CODEBASE", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CODE", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ARCHIVE", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "VALUE", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "VALUETYPE", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TYPE", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CLASS", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "STYLE", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LANG", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FACE", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DIR", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DECLARE", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CLASSID", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DATA", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CODETYPE", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "STANDBY", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BORDER", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SHAPES", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NOSHADE", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "COMPACT", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ACTION", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "METHOD", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENCTYPE", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHECKED", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MAXLENGTH", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MULTIPLE", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SELECTED", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ROWS", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "COLS", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DUMMY", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CELLSPACING", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CELLPADDING", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "VALIGN", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HALIGN", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NOWRAP", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ROWSPAN", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "COLSPAN", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PROMPT", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HTTPEQUIV", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CONTENT", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LANGUAGE", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "VERSION", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "N", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FRAMEBORDER", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MARGINWIDTH", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MARGINHEIGHT", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SCROLLING", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NORESIZE", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENDTAG", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "COMMENT", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MEDIA", "Ljavax/swing/text/html/HTML$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "allAttributes", "[Ljavax/swing/text/html/HTML$Attribute;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Attribute", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute SIZE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute COLOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute CLEAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute BACKGROUND_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute BGCOLOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute TEXT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute LINK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute VLINK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute ALINK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute WIDTH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute HEIGHT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute ALIGN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute NAME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute HREF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute REL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute REV_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute TITLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute TARGET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute SHAPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute COORDS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute ISMAP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute NOHREF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute ALT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute ID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute SRC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute HSPACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute VSPACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute USEMAP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute LOWSRC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute CODEBASE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute CODE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute ARCHIVE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute VALUE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute VALUETYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute CLASS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute STYLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute LANG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute FACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute DIR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute DECLARE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute CLASSID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute DATA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute CODETYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute STANDBY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute BORDER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute SHAPES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute NOSHADE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute COMPACT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute START_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute ACTION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute METHOD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute ENCTYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute CHECKED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[54]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[54], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute MAXLENGTH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[55]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[55], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute MULTIPLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[56]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[56], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute SELECTED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute ROWS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[58]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[58], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute COLS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[59]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[59], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute DUMMY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[60]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[60], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute CELLSPACING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[61]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[61], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute CELLPADDING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[62]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[62], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute VALIGN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[63]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[63], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute HALIGN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[64]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[64], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute NOWRAP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute ROWSPAN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[66]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[66], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute COLSPAN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[67]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[67], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute PROMPT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[68]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[68], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute HTTPEQUIV_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[69]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[69], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute CONTENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[70]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[70], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute LANGUAGE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[71]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[71], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute VERSION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[72]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[72], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute N_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[73]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[73], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute FRAMEBORDER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[74]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[74], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute MARGINWIDTH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[75]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[75], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute MARGINHEIGHT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[76]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[76], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute SCROLLING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[77]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[77], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute NORESIZE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[78]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[78], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute ENDTAG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[79]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[79], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "public static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute COMMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[80]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[80], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Attribute;", "static final")]
		public static Dova.JDK.javax.swing.text.html.HTML.Attribute MEDIA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[81]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Attribute>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[81], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljavax/swing/text/html/HTML$Attribute;", "static final")]
		public static JavaArray<Dova.JDK.javax.swing.text.html.HTML.Attribute> allAttributes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[82]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.text.html.HTML.Attribute>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[82], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Attribute(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
		public Attribute(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTML$Attribute;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTML$UnknownTag;", "public static")]
	public partial class UnknownTag
		: Dova.JDK.javax.swing.text.html.HTML.Tag
		, Dova.JDK.java.io.Serializable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UnknownTag()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTML$UnknownTag;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "UnknownTag", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UnknownTag(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public UnknownTag(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTML$UnknownTag;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
		public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private")]
		public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}
	}
}
