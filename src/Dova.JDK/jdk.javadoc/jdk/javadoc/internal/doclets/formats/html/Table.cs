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

namespace Dova.JDK.jdk.javadoc.@internal.doclets.formats.html;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/Table;", "public")]
public partial class Table
	: Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Table()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/formats/html/Table;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tableStyle", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "caption", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tabMap", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultTab", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tabs", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tabListStyle", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "activeTabStyle", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tabStyle", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "header", "Ljdk/javadoc/internal/doclets/formats/html/TableHeader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "columnStyles", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stripedStyles", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bodyRows", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "id", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "alwaysShowDefaultTab", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljava/io/Writer;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScript", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "needsScript", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCaption", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/formats/html/Table;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setColumnStyles", "(Ljava/util/List;)Ljdk/javadoc/internal/doclets/formats/html/Table;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setColumnStyles", "([Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;)Ljdk/javadoc/internal/doclets/formats/html/Table;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCaption", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toContent", "()Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTableBody", "()Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createTab", "(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;ZLjdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendStyleInfo", "(Ljava/lang/StringBuilder;[Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDefaultTab", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/formats/html/Table;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAlwaysShowDefaultTab", "(Z)Ljdk/javadoc/internal/doclets/formats/html/Table;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTabStyles", "(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;)Ljdk/javadoc/internal/doclets/formats/html/Table;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStripedStyles", "(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;)Ljdk/javadoc/internal/doclets/formats/html/Table;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTab", "(Ljdk/javadoc/internal/doclets/toolkit/Content;Ljava/util/function/Predicate;)Ljdk/javadoc/internal/doclets/formats/html/Table;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setHeader", "(Ljdk/javadoc/internal/doclets/formats/html/TableHeader;)Ljdk/javadoc/internal/doclets/formats/html/Table;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setId", "(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;)Ljdk/javadoc/internal/doclets/formats/html/Table;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addRow", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addRow", "([Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addRow", "(Ljavax/lang/model/element/Element;[Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addRow", "(Ljavax/lang/model/element/Element;Ljava/util/List;)V"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle tableStyle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content caption_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map tabMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content defaultTab_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set tabs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle tabListStyle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle activeTabStyle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle tabStyle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/TableHeader;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.TableHeader header_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.TableHeader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List columnStyles_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List stripedStyles_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List bodyRows_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId id_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool alwaysShowDefaultTab_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Table(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;)V", "public")]
	public Table(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/formats/html/Table;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Z", "public")]
	public bool isEmpty()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/Writer;Z)Z", "public")]
	public bool write(Dova.JDK.java.io.Writer arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getScript()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool needsScript()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/formats/html/Table;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table setCaption(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljdk/javadoc/internal/doclets/formats/html/Table;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table setColumnStyles(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table>(ret);
	}

	[JniSignatureAttribute("([Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;)Ljdk/javadoc/internal/doclets/formats/html/Table;", "public transient")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table setColumnStyles(JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree getCaption(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/Content;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content toContent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/Content;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getTableBody()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;ZLjdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree createTab(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId arg0, Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle arg1, bool arg2, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuilder;[Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;)V", "private transient")]
	public void appendStyleInfo(Dova.JDK.java.lang.StringBuilder arg0, JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/formats/html/Table;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table setDefaultTab(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table>(ret);
	}

	[JniSignatureAttribute("(Z)Ljdk/javadoc/internal/doclets/formats/html/Table;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table setAlwaysShowDefaultTab(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;)Ljdk/javadoc/internal/doclets/formats/html/Table;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table setTabStyles(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle arg0, Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle arg1, Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;)Ljdk/javadoc/internal/doclets/formats/html/Table;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table setStripedStyles(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle arg0, Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;Ljava/util/function/Predicate;)Ljdk/javadoc/internal/doclets/formats/html/Table;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table addTab(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0, Dova.JDK.java.util.function.Predicate arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/TableHeader;)Ljdk/javadoc/internal/doclets/formats/html/Table;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table setHeader(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.TableHeader arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;)Ljdk/javadoc/internal/doclets/formats/html/Table;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table setId(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Table>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
	public void addRow(Dova.JDK.java.util.List arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("([Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public transient")]
	public void addRow(JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;[Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public transient")]
	public void addRow(Dova.JDK.javax.lang.model.element.Element arg0, JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljava/util/List;)V", "public")]
	public void addRow(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.java.util.List arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
	}
}
