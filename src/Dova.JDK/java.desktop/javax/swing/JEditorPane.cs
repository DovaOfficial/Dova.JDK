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

namespace Dova.JDK.javax.swing;

[JniSignatureAttribute("Ljavax/swing/JEditorPane;", "public")]
public partial class JEditorPane
	: Dova.JDK.javax.swing.text.JTextComponent
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JEditorPane()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JEditorPane;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pageLoader", "Ljavax/swing/SwingWorker;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kit", "Ljavax/swing/text/EditorKit;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isUserSetEditorKit", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pageProperties", "Ljava/util/Hashtable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PostDataProperty", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeHandlers", "Ljava/util/Hashtable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "kitRegistryKey", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "kitTypeRegistryKey", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "kitLoaderRegistryKey", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "uiClassID", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "W3C_LENGTH_UNITS", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HONOR_DISPLAY_PROPERTIES", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultEditorKitMap", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/net/URL;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(Ljava/io/InputStream;Ljavax/swing/text/Document;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(Ljava/io/InputStream;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paramString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getText", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setText", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPage", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPage", "(Ljava/net/URL;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPage", "()Ljava/net/URL;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPostData", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAsynchronousLoadPriority", "(Ljavax/swing/text/Document;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initializeModel", "(Ljavax/swing/text/EditorKit;Ljava/net/URL;)Ljavax/swing/text/Document;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scrollToReference", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCharsetFromContentTypeParameters", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handlePostData", "(Ljava/net/HttpURLConnection;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleConnectionProperties", "(Ljava/net/URLConnection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDefaultEditorKit", "()Ljavax/swing/text/EditorKit;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEditorKitForContentType", "(Ljava/lang/String;)Ljavax/swing/text/EditorKit;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEditorKit", "(Ljavax/swing/text/EditorKit;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createEditorKitForContentType", "(Ljava/lang/String;)Ljavax/swing/text/EditorKit;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEditorKitForContentType", "(Ljava/lang/String;Ljavax/swing/text/EditorKit;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getKitRegisty", "()Ljava/util/Hashtable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getKitTypeRegistry", "()Ljava/util/Hashtable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getKitLoaderRegistry", "()Ljava/util/Hashtable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "registerEditorKitForContentType", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "registerEditorKitForContentType", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadDefaultKitsIfNecessary", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEditorKit", "()Ljavax/swing/text/EditorKit;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceSelection", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStream", "(Ljava/net/URL;)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setContentType", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Ljavax/swing/JEditorPane;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContentType", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredSize", "()Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addHyperlinkListener", "(Ljavax/swing/event/HyperlinkListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeHyperlinkListener", "(Ljavax/swing/event/HyperlinkListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHyperlinkListeners", "()[Ljavax/swing/event/HyperlinkListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireHyperlinkUpdate", "(Ljavax/swing/event/HyperlinkEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getEditorKitClassNameForContentType", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScrollableTracksViewportWidth", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScrollableTracksViewportHeight", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUIClassID", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
	}

	[JniSignatureAttribute("Ljavax/swing/SwingWorker;", "private")]
	public Dova.JDK.javax.swing.SwingWorker pageLoader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SwingWorker>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/EditorKit;", "private")]
	public Dova.JDK.javax.swing.text.EditorKit kit_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.EditorKit>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool isUserSetEditorKit_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Hashtable;", "private")]
	public Dova.JDK.java.util.Hashtable pageProperties_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String PostDataProperty_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Hashtable;", "private")]
	public Dova.JDK.java.util.Hashtable typeHandlers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private static final")]
	public static Dova.JDK.java.lang.Object kitRegistryKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private static final")]
	public static Dova.JDK.java.lang.Object kitTypeRegistryKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private static final")]
	public static Dova.JDK.java.lang.Object kitLoaderRegistryKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String uiClassID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String W3C_LENGTH_UNITS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String HONOR_DISPLAY_PROPERTIES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "static final")]
	public static Dova.JDK.java.util.Map defaultEditorKitMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JEditorPane(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public JEditorPane(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public JEditorPane(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/net/URL;)V", "public")]
	public JEditorPane(Dova.JDK.java.net.URL arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public JEditorPane() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/JEditorPane;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private")]
	public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljavax/swing/text/Document;)V", "")]
	public void read(Dova.JDK.java.io.InputStream arg0, Dova.JDK.javax.swing.text.Document arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/lang/Object;)V", "public")]
	public void read(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String paramString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getText()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setText(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setPage(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)V", "public")]
	public void setPage(Dova.JDK.java.net.URL arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()Ljava/net/URL;", "public")]
	public Dova.JDK.java.net.URL getPage()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object getPostData()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Document;)I", "private")]
	public int getAsynchronousLoadPriority(Dova.JDK.javax.swing.text.Document arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/EditorKit;Ljava/net/URL;)Ljavax/swing/text/Document;", "private")]
	public Dova.JDK.javax.swing.text.Document initializeModel(Dova.JDK.javax.swing.text.EditorKit arg0, Dova.JDK.java.net.URL arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Document>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void scrollToReference(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
	public void setCharsetFromContentTypeParameters(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Ljava/net/HttpURLConnection;Ljava/lang/Object;)V", "private")]
	public void handlePostData(Dova.JDK.java.net.HttpURLConnection arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/net/URLConnection;)V", "private")]
	public void handleConnectionProperties(Dova.JDK.java.net.URLConnection arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/EditorKit;", "protected")]
	public Dova.JDK.javax.swing.text.EditorKit createDefaultEditorKit()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.EditorKit>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/swing/text/EditorKit;", "public")]
	public Dova.JDK.javax.swing.text.EditorKit getEditorKitForContentType(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.EditorKit>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/EditorKit;)V", "public")]
	public void setEditorKit(Dova.JDK.javax.swing.text.EditorKit arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/swing/text/EditorKit;", "public static")]
	public static Dova.JDK.javax.swing.text.EditorKit createEditorKitForContentType(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.EditorKit>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/swing/text/EditorKit;)V", "public")]
	public void setEditorKitForContentType(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.swing.text.EditorKit arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/util/Hashtable;", "private static")]
	public static Dova.JDK.java.util.Hashtable getKitRegisty()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Hashtable;", "private static")]
	public static Dova.JDK.java.util.Hashtable getKitTypeRegistry()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Hashtable;", "private static")]
	public static Dova.JDK.java.util.Hashtable getKitLoaderRegistry()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public static")]
	public static void registerEditorKitForContentType(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)V", "public static")]
	public static void registerEditorKitForContentType(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.ClassLoader arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void loadDefaultKitsIfNecessary()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[26]);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/EditorKit;", "public")]
	public Dova.JDK.javax.swing.text.EditorKit getEditorKit()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.EditorKit>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void replaceSelection(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljava/io/InputStream;", "protected")]
	public Dova.JDK.java.io.InputStream getStream(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public final")]
	public void setContentType(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JEditorPane;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "static")]
	public static void access_000(Dova.JDK.javax.swing.JEditorPane arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String getContentType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getPreferredSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/HyperlinkListener;)V", "public synchronized")]
	public void addHyperlinkListener(Dova.JDK.javax.swing.@event.HyperlinkListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/HyperlinkListener;)V", "public synchronized")]
	public void removeHyperlinkListener(Dova.JDK.javax.swing.@event.HyperlinkListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("()[Ljavax/swing/event/HyperlinkListener;", "public synchronized")]
	public JavaArray<Dova.JDK.javax.swing.@event.HyperlinkListener> getHyperlinkListeners()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.@event.HyperlinkListener>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/HyperlinkEvent;)V", "public")]
	public void fireHyperlinkUpdate(Dova.JDK.javax.swing.@event.HyperlinkEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getEditorKitClassNameForContentType(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getScrollableTracksViewportWidth()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[39]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getScrollableTracksViewportHeight()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[40]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getUIClassID()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "public")]
	public Dova.JDK.javax.accessibility.AccessibleContext getAccessibleContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/JEditorPane$PageLoader;", "")]
	public partial class PageLoader
		: Dova.JDK.javax.swing.SwingWorker
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PageLoader()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JEditorPane$PageLoader;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "in", "Ljava/io/InputStream;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "old", "Ljava/net/URL;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "page", "Ljava/net/URL;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "doc", "Ljavax/swing/text/Document;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/JEditorPane;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JEditorPane;Ljavax/swing/text/Document;Ljava/io/InputStream;Ljava/net/URL;Ljava/net/URL;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doInBackground_0", "()Ljava/net/URL;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doInBackground_1", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Ljava/io/InputStream;", "")]
		public Dova.JDK.java.io.InputStream @in_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/net/URL;", "")]
		public Dova.JDK.java.net.URL old_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/net/URL;", "")]
		public Dova.JDK.java.net.URL page_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/Document;", "")]
		public Dova.JDK.javax.swing.text.Document doc_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Document>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JEditorPane;", "final")]
		public Dova.JDK.javax.swing.JEditorPane this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JEditorPane>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PageLoader(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JEditorPane;Ljavax/swing/text/Document;Ljava/io/InputStream;Ljava/net/URL;Ljava/net/URL;)V", "")]
		public PageLoader(Dova.JDK.javax.swing.JEditorPane arg0, Dova.JDK.javax.swing.text.Document arg1, Dova.JDK.java.io.InputStream arg2, Dova.JDK.java.net.URL arg3, Dova.JDK.java.net.URL arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JEditorPane$PageLoader;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/net/URL;", "protected")]
		public Dova.JDK.java.net.URL doInBackground_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "protected volatile")]
		public Dova.JDK.java.lang.Object doInBackground_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JEditorPane$PlainEditorKit;", "static")]
	public partial class PlainEditorKit
		: Dova.JDK.javax.swing.text.DefaultEditorKit
		, Dova.JDK.javax.swing.text.ViewFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PlainEditorKit()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JEditorPane$PlainEditorKit;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "create", "(Ljavax/swing/text/Element;)Ljavax/swing/text/View;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getViewFactory", "()Ljavax/swing/text/ViewFactory;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createI18N", "(Ljavax/swing/text/Element;)Ljavax/swing/text/View;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PlainEditorKit(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public PlainEditorKit() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JEditorPane$PlainEditorKit;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/text/Element;)Ljavax/swing/text/View;", "public")]
		public Dova.JDK.javax.swing.text.View create(Dova.JDK.javax.swing.text.Element arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
		}

		[JniSignatureAttribute("()Ljavax/swing/text/ViewFactory;", "public")]
		public Dova.JDK.javax.swing.text.ViewFactory getViewFactory()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.ViewFactory>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/Element;)Ljavax/swing/text/View;", "")]
		public Dova.JDK.javax.swing.text.View createI18N(Dova.JDK.javax.swing.text.Element arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
		}

		[JniSignatureAttribute("Ljavax/swing/JEditorPane$PlainEditorKit$PlainParagraph;", "static")]
		public partial class PlainParagraph
			: Dova.JDK.javax.swing.text.ParagraphView
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static PlainParagraph()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JEditorPane$PlainEditorKit$PlainParagraph;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/Element;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFlowSpan", "(I)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateMinorAxisRequirements", "(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPropertiesFromAttributes", "()V"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public PlainParagraph(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/Element;)V", "")]
			public PlainParagraph(Dova.JDK.javax.swing.text.Element arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/JEditorPane$PlainEditorKit$PlainParagraph;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(I)I", "public")]
			public int getFlowSpan(int arg0)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;", "protected")]
			public Dova.JDK.javax.swing.SizeRequirements calculateMinorAxisRequirements(int arg0, Dova.JDK.javax.swing.SizeRequirements arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SizeRequirements>(ret);
			}

			[JniSignatureAttribute("()V", "protected")]
			public void setPropertiesFromAttributes()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
			}

			[JniSignatureAttribute("Ljavax/swing/JEditorPane$PlainEditorKit$PlainParagraph$LogicalView;", "static")]
			public partial class LogicalView
				: Dova.JDK.javax.swing.text.CompositeView
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static LogicalView()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JEditorPane$PlainEditorKit$PlainParagraph$LogicalView;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/Element;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAfter", "(IILjava/awt/Rectangle;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBefore", "(IILjava/awt/Rectangle;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getViewIndexAtPosition", "(I)I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadChildren", "(Ljavax/swing/text/ViewFactory;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getViewAtPoint", "(IILjava/awt/Rectangle;)Ljavax/swing/text/View;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredSpan", "(I)F"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateChildren", "(Ljavax/swing/event/DocumentEvent$ElementChange;Ljavax/swing/event/DocumentEvent;Ljavax/swing/text/ViewFactory;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forwardUpdateToView", "(Ljavax/swing/text/View;Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "childAllocation", "(ILjava/awt/Rectangle;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;Ljava/awt/Shape;)V"));
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public LogicalView(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljavax/swing/text/Element;)V", "")]
				public LogicalView(Dova.JDK.javax.swing.text.Element arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Ljavax/swing/JEditorPane$PlainEditorKit$PlainParagraph$LogicalView;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(IILjava/awt/Rectangle;)Z", "protected")]
				public bool isAfter(int arg0, int arg1, Dova.JDK.java.awt.Rectangle arg2)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
					return ret;
				}

				[JniSignatureAttribute("(IILjava/awt/Rectangle;)Z", "protected")]
				public bool isBefore(int arg0, int arg1, Dova.JDK.java.awt.Rectangle arg2)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
					return ret;
				}

				[JniSignatureAttribute("(I)I", "protected")]
				public int getViewIndexAtPosition(int arg0)
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return ret;
				}

				[JniSignatureAttribute("(Ljavax/swing/text/ViewFactory;)V", "protected")]
				public void loadChildren(Dova.JDK.javax.swing.text.ViewFactory arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				}

				[JniSignatureAttribute("(IILjava/awt/Rectangle;)Ljavax/swing/text/View;", "protected")]
				public Dova.JDK.javax.swing.text.View getViewAtPoint(int arg0, int arg1, Dova.JDK.java.awt.Rectangle arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
				}

				[JniSignatureAttribute("(I)F", "public")]
				public float getPreferredSpan(int arg0)
				{
					var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return ret;
				}

				[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent$ElementChange;Ljavax/swing/event/DocumentEvent;Ljavax/swing/text/ViewFactory;)Z", "protected")]
				public bool updateChildren(Dova.JDK.javax.swing.@event.DocumentEvent.ElementChange arg0, Dova.JDK.javax.swing.@event.DocumentEvent arg1, Dova.JDK.javax.swing.text.ViewFactory arg2)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
					return ret;
				}

				[JniSignatureAttribute("(Ljavax/swing/text/View;Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V", "protected")]
				public void forwardUpdateToView(Dova.JDK.javax.swing.text.View arg0, Dova.JDK.javax.swing.@event.DocumentEvent arg1, Dova.JDK.java.awt.Shape arg2, Dova.JDK.javax.swing.text.ViewFactory arg3)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
				}

				[JniSignatureAttribute("(ILjava/awt/Rectangle;)V", "protected")]
				public void childAllocation(int arg0, Dova.JDK.java.awt.Rectangle arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
				}

				[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/awt/Shape;)V", "public")]
				public void paint(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.awt.Shape arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
				}
			}
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JEditorPane$HeaderParser;", "static")]
	public partial class HeaderParser
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HeaderParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JEditorPane$HeaderParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "raw", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tab", "[[Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findValue", "(Ljava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findValue", "(I)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findInt", "(Ljava/lang/String;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findKey", "(I)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String raw_Property
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

		[JniSignatureAttribute("[[Ljava/lang/String;", "")]
		public JavaArray<JavaArray<Dova.JDK.java.lang.String>> tab_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.java.lang.String>>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public HeaderParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public HeaderParser(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JEditorPane$HeaderParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "private")]
		public void parse()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String findValue(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String findValue(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String findValue(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)I", "public")]
		public int findInt(Dova.JDK.java.lang.String arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String findKey(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JEditorPane$AccessibleJEditorPaneHTML;", "protected")]
	public partial class AccessibleJEditorPaneHTML
		: Dova.JDK.javax.swing.JEditorPane.AccessibleJEditorPane
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AccessibleJEditorPaneHTML()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JEditorPane$AccessibleJEditorPaneHTML;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "accessibleContext", "Ljavax/accessibility/AccessibleContext;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/JEditorPane;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JEditorPane;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleText", "()Ljavax/accessibility/AccessibleText;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleChildrenCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleChild", "(I)Ljavax/accessibility/Accessible;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleAt", "(Ljava/awt/Point;)Ljavax/accessibility/Accessible;"));
		}

		[JniSignatureAttribute("Ljavax/accessibility/AccessibleContext;", "private")]
		public Dova.JDK.javax.accessibility.AccessibleContext accessibleContext_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JEditorPane;", "final")]
		public Dova.JDK.javax.swing.JEditorPane this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JEditorPane>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AccessibleJEditorPaneHTML(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JEditorPane;)V", "protected")]
		public AccessibleJEditorPaneHTML(Dova.JDK.javax.swing.JEditorPane arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JEditorPane$AccessibleJEditorPaneHTML;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleText;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleText getAccessibleText()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleText>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getAccessibleChildrenCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public")]
		public Dova.JDK.javax.accessibility.Accessible getAccessibleChild(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Point;)Ljavax/accessibility/Accessible;", "public")]
		public Dova.JDK.javax.accessibility.Accessible getAccessibleAt(Dova.JDK.java.awt.Point arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JEditorPane$AccessibleJEditorPane;", "protected")]
	public partial class AccessibleJEditorPane
		: Dova.JDK.javax.swing.text.JTextComponent.AccessibleJTextComponent
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AccessibleJEditorPane()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JEditorPane$AccessibleJEditorPane;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/JEditorPane;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JEditorPane;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleDescription", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleStateSet", "()Ljavax/accessibility/AccessibleStateSet;"));
		}

		[JniSignatureAttribute("Ljavax/swing/JEditorPane;", "final")]
		public Dova.JDK.javax.swing.JEditorPane this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JEditorPane>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AccessibleJEditorPane(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JEditorPane;)V", "protected")]
		public AccessibleJEditorPane(Dova.JDK.javax.swing.JEditorPane arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JEditorPane$AccessibleJEditorPane;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getAccessibleDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleStateSet;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleStateSet getAccessibleStateSet()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleStateSet>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JEditorPane$JEditorPaneAccessibleHypertextSupport;", "protected")]
	public partial class JEditorPaneAccessibleHypertextSupport
		: Dova.JDK.javax.swing.JEditorPane.AccessibleJEditorPane
		, Dova.JDK.javax.accessibility.AccessibleHypertext
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JEditorPaneAccessibleHypertextSupport()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JEditorPane$JEditorPaneAccessibleHypertextSupport;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hyperlinks", "Ljavax/swing/JEditorPane$JEditorPaneAccessibleHypertextSupport$LinkVector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "linksValid", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/JEditorPane;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JEditorPane;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLink", "(I)Ljavax/accessibility/AccessibleHyperlink;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildLinkTable", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLinkCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLinkIndex", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLinkText", "(I)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljavax/swing/JEditorPane$JEditorPaneAccessibleHypertextSupport$LinkVector;", "")]
		public Dova.JDK.javax.swing.JEditorPane.JEditorPaneAccessibleHypertextSupport.LinkVector hyperlinks_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JEditorPane.JEditorPaneAccessibleHypertextSupport.LinkVector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool linksValid_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JEditorPane;", "final")]
		public Dova.JDK.javax.swing.JEditorPane this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JEditorPane>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JEditorPaneAccessibleHypertextSupport(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JEditorPane;)V", "public")]
		public JEditorPaneAccessibleHypertextSupport(Dova.JDK.javax.swing.JEditorPane arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JEditorPane$JEditorPaneAccessibleHypertextSupport;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljavax/accessibility/AccessibleHyperlink;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleHyperlink getLink(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleHyperlink>(ret);
		}

		[JniSignatureAttribute("()V", "private")]
		public void buildLinkTable()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getLinkCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("(I)I", "public")]
		public int getLinkIndex(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getLinkText(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("Ljavax/swing/JEditorPane$JEditorPaneAccessibleHypertextSupport$LinkVector;", "private")]
		public partial class LinkVector
			: Dova.JDK.java.util.Vector
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static LinkVector()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JEditorPane$JEditorPaneAccessibleHypertextSupport$LinkVector;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Ljavax/swing/JEditorPane$JEditorPaneAccessibleHypertextSupport;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JEditorPane$JEditorPaneAccessibleHypertextSupport;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "baseElementIndex", "(Ljavax/swing/text/Element;)I"));
			}

			[JniSignatureAttribute("Ljavax/swing/JEditorPane$JEditorPaneAccessibleHypertextSupport;", "final")]
			public Dova.JDK.javax.swing.JEditorPane.JEditorPaneAccessibleHypertextSupport this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JEditorPane.JEditorPaneAccessibleHypertextSupport>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public LinkVector(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/JEditorPane$JEditorPaneAccessibleHypertextSupport;)V", "private")]
			public LinkVector(Dova.JDK.javax.swing.JEditorPane.JEditorPaneAccessibleHypertextSupport arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/JEditorPane$JEditorPaneAccessibleHypertextSupport$LinkVector;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/Element;)I", "public")]
			public int baseElementIndex(Dova.JDK.javax.swing.text.Element arg0)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JEditorPane$JEditorPaneAccessibleHypertextSupport$HTMLLink;", "public")]
		public partial class HTMLLink
			: Dova.JDK.javax.accessibility.AccessibleHyperlink
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static HTMLLink()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JEditorPane$JEditorPaneAccessibleHypertextSupport$HTMLLink;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "element", "Ljavax/swing/text/Element;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Ljavax/swing/JEditorPane$JEditorPaneAccessibleHypertextSupport;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JEditorPane$JEditorPaneAccessibleHypertextSupport;Ljavax/swing/text/Element;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndIndex", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValid", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleActionObject", "(I)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleActionAnchor", "(I)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartIndex", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleActionCount", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleActionDescription", "(I)Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doAccessibleAction", "(I)Z"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/Element;", "")]
			public Dova.JDK.javax.swing.text.Element element_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljavax/swing/JEditorPane$JEditorPaneAccessibleHypertextSupport;", "final")]
			public Dova.JDK.javax.swing.JEditorPane.JEditorPaneAccessibleHypertextSupport this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JEditorPane.JEditorPaneAccessibleHypertextSupport>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public HTMLLink(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/JEditorPane$JEditorPaneAccessibleHypertextSupport;Ljavax/swing/text/Element;)V", "public")]
			public HTMLLink(Dova.JDK.javax.swing.JEditorPane.JEditorPaneAccessibleHypertextSupport arg0, Dova.JDK.javax.swing.text.Element arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/JEditorPane$JEditorPaneAccessibleHypertextSupport$HTMLLink;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()I", "public")]
			public int getEndIndex()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isValid()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}

			[JniSignatureAttribute("(I)Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object getAccessibleActionObject(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(I)Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object getAccessibleActionAnchor(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()I", "public")]
			public int getStartIndex()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}

			[JniSignatureAttribute("()I", "public")]
			public int getAccessibleActionCount()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
				return ret;
			}

			[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getAccessibleActionDescription(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(I)Z", "public")]
			public bool doAccessibleAction(int arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				return ret;
			}
		}
	}
}
