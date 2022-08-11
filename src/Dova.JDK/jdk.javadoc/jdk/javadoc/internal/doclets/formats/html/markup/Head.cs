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

namespace Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Head;", "public")]
public partial class Head
	: Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Head()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/formats/html/markup/Head;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "docletVersion", "Ljava/lang/Runtime$Version;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "generatedDate", "Ljava/util/Date;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pathToRoot", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "title", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "charset", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keywords", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "description", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "generator", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "showTimestamp", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mainStylesheet", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "additionalStylesheets", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mainBodyScript", "Ljdk/javadoc/internal/doclets/formats/html/markup/Script;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "scripts", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "additionalScripts", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "extraContent", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "addDefaultScript", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canonicalLink", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;Ljava/lang/Runtime$Version;Ljava/util/Date;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljava/io/Writer;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setIndex", "(ZLjdk/javadoc/internal/doclets/formats/html/markup/Script;)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCharset", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addStylesheets", "(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGeneratedBy", "(ZLjava/util/Date;)Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addScriptElement", "(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addScript", "(Ljdk/javadoc/internal/doclets/formats/html/markup/Script;)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addScripts", "(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDefaultScript", "(Z)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCanonicalLink", "(Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addStylesheet", "(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTimestamp", "(Z)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDescription", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addContent", "([Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTitle", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStylesheets", "(Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;Ljava/util/List;)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAdditionalScripts", "(Ljava/util/List;)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGenerator", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addKeywords", "(Ljava/util/List;)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toContent", "()Ljdk/javadoc/internal/doclets/toolkit/Content;"));
	}

	[JniSignatureAttribute("Ljava/lang/Runtime$Version;", "private final")]
	public Dova.JDK.java.lang.Runtime.Version docletVersion_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runtime.Version>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Date;", "private final")]
	public Dova.JDK.java.util.Date generatedDate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Date>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath pathToRoot_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String title_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String charset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List keywords_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String description_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String generator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool showTimestamp_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath mainStylesheet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List additionalStylesheets_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool index_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Script;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Script mainBodyScript_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Script>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List scripts_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List additionalScripts_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List extraContent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool addDefaultScript_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath canonicalLink_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Head(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;Ljava/lang/Runtime$Version;Ljava/util/Date;)V", "public")]
	public Head(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg0, Dova.JDK.java.lang.Runtime.Version arg1, Dova.JDK.java.util.Date arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/formats/html/markup/Head;";
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

	[JniSignatureAttribute("(ZLjdk/javadoc/internal/doclets/formats/html/markup/Script;)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head setIndex(bool arg0, Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Script arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head setCharset(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;)V", "private")]
	public void addStylesheets(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(ZLjava/util/Date;)Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment getGeneratedBy(bool arg0, Dova.JDK.java.util.Date arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)V", "private")]
	public void addScriptElement(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/markup/Script;)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head addScript(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Script arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;)V", "private")]
	public void addScripts(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Z)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head addDefaultScript(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)V", "public")]
	public void setCanonicalLink(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlTree;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)V", "private")]
	public void addStylesheet(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlTree arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Z)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head setTimestamp(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head setDescription(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head>(ret);
	}

	[JniSignatureAttribute("([Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;", "public transient")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head addContent(JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head setTitle(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;Ljava/util/List;)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head setStylesheets(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head setAdditionalScripts(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head setGenerator(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljdk/javadoc/internal/doclets/formats/html/markup/Head;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head addKeywords(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Head>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/Content;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content toContent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}
}
