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

[JniSignatureAttribute("Ljavax/swing/UIDefaults;", "public")]
public partial class UIDefaults
	: Dova.JDK.java.util.Hashtable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static UIDefaults()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/UIDefaults;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PENDING", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "changeSupport", "Ljavax/swing/event/SwingPropertyChangeSupport;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resourceBundles", "Ljava/util/Vector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultLocale", "Ljava/util/Locale;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resourceCache", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/lang/Object;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IF)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(Ljava/lang/Object;Ljava/util/Locale;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBoolean", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBoolean", "(Ljava/lang/Object;Ljava/util/Locale;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInt", "(Ljava/lang/Object;Ljava/util/Locale;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInt", "(Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getString", "(Ljava/lang/Object;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getString", "(Ljava/lang/Object;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultLocale", "()Ljava/util/Locale;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBorder", "(Ljava/lang/Object;Ljava/util/Locale;)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBorder", "(Ljava/lang/Object;)Ljavax/swing/border/Border;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDefaultLocale", "(Ljava/util/Locale;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUI", "(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFromHashtable", "(Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFromResourceBundle", "(Ljava/lang/Object;Ljava/util/Locale;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResourceCache", "(Ljava/util/Locale;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDesktopResourceBundle", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUIClass", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUIClass", "(Ljava/lang/String;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUIError", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addInternalBundle", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putDefaults", "([Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDimension", "(Ljava/lang/Object;Ljava/util/Locale;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDimension", "(Ljava/lang/Object;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addResourceBundle", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeResourceBundle", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIcon", "(Ljava/lang/Object;)Ljavax/swing/Icon;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIcon", "(Ljava/lang/Object;Ljava/util/Locale;)Ljavax/swing/Icon;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFont", "(Ljava/lang/Object;Ljava/util/Locale;)Ljava/awt/Font;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFont", "(Ljava/lang/Object;)Ljava/awt/Font;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "firePropertyChange", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInsets", "(Ljava/lang/Object;Ljava/util/Locale;)Ljava/awt/Insets;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInsets", "(Ljava/lang/Object;)Ljava/awt/Insets;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPropertyChangeListeners", "()[Ljava/beans/PropertyChangeListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColor", "(Ljava/lang/Object;)Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColor", "(Ljava/lang/Object;Ljava/util/Locale;)Ljava/awt/Color;"));
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private static final")]
	public static Dova.JDK.java.lang.Object PENDING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/event/SwingPropertyChangeSupport;", "private")]
	public Dova.JDK.javax.swing.@event.SwingPropertyChangeSupport changeSupport_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.SwingPropertyChangeSupport>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Vector;", "private")]
	public Dova.JDK.java.util.Vector resourceBundles_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Locale;", "private")]
	public Dova.JDK.java.util.Locale defaultLocale_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map resourceCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public UIDefaults(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)V", "public")]
	public UIDefaults(JavaArray<Dova.JDK.java.lang.Object> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(IF)V", "public")]
	public UIDefaults(int arg0, float arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public UIDefaults() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/UIDefaults;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object get(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Locale;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object get(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object put(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool getBoolean(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Locale;)Z", "public")]
	public bool getBoolean(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Locale;)I", "public")]
	public int getInt(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)I", "public")]
	public int getInt(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Locale;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getString(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getString(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Locale;", "public")]
	public Dova.JDK.java.util.Locale getDefaultLocale()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Locale;)Ljavax/swing/border/Border;", "public")]
	public Dova.JDK.javax.swing.border.Border getBorder(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljavax/swing/border/Border;", "public")]
	public Dova.JDK.javax.swing.border.Border getBorder(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)V", "public")]
	public void setDefaultLocale(Dova.JDK.java.util.Locale arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;", "public")]
	public Dova.JDK.javax.swing.plaf.ComponentUI getUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ComponentUI>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object getFromHashtable(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Locale;)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object getFromResourceBundle(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map getResourceCache(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private static")]
	public static bool isDesktopResourceBundle(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class getUIClass(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.ClassLoader arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class getUIClass(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
	public void getUIError(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private synchronized")]
	public void addInternalBundle(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)V", "public")]
	public void putDefaults(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Locale;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getDimension(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getDimension(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public synchronized")]
	public void addResourceBundle(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public synchronized")]
	public void removeResourceBundle(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljavax/swing/Icon;", "public")]
	public Dova.JDK.javax.swing.Icon getIcon(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Locale;)Ljavax/swing/Icon;", "public")]
	public Dova.JDK.javax.swing.Icon getIcon(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Locale;)Ljava/awt/Font;", "public")]
	public Dova.JDK.java.awt.Font getFont(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/awt/Font;", "public")]
	public Dova.JDK.java.awt.Font getFont(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "protected")]
	public void firePropertyChange(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Locale;)Ljava/awt/Insets;", "public")]
	public Dova.JDK.java.awt.Insets getInsets(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/awt/Insets;", "public")]
	public Dova.JDK.java.awt.Insets getInsets(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
	}

	[JniSignatureAttribute("()[Ljava/beans/PropertyChangeListener;", "public synchronized")]
	public JavaArray<Dova.JDK.java.beans.PropertyChangeListener> getPropertyChangeListeners()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.beans.PropertyChangeListener>>(ret);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeListener;)V", "public synchronized")]
	public void addPropertyChangeListener(Dova.JDK.java.beans.PropertyChangeListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeListener;)V", "public synchronized")]
	public void removePropertyChangeListener(Dova.JDK.java.beans.PropertyChangeListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/awt/Color;", "public")]
	public Dova.JDK.java.awt.Color getColor(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Locale;)Ljava/awt/Color;", "public")]
	public Dova.JDK.java.awt.Color getColor(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/UIDefaults$ActiveValue;", "public abstract static interface")]
	public partial interface ActiveValue
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ActiveValue()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/UIDefaults$ActiveValue;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createValue", "(Ljavax/swing/UIDefaults;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(Ljavax/swing/UIDefaults;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object createValue(Dova.JDK.javax.swing.UIDefaults arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/UIDefaults$LazyValue;", "public abstract static interface")]
	public partial interface LazyValue
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LazyValue()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/UIDefaults$LazyValue;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createValue", "(Ljavax/swing/UIDefaults;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(Ljavax/swing/UIDefaults;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object createValue(Dova.JDK.javax.swing.UIDefaults arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/UIDefaults$TextAndMnemonicHashMap;", "private static")]
	public partial class TextAndMnemonicHashMap
		: Dova.JDK.java.util.HashMap
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TextAndMnemonicHashMap()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/UIDefaults$TextAndMnemonicHashMap;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AND_MNEMONIC", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TITLE_SUFFIX", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TEXT_SUFFIX", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "composeKey", "(Ljava/lang/String;ILjava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMnemonicFromProperty", "(Ljava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTextFromProperty", "(Ljava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndexFromProperty", "(Ljava/lang/String;)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "static final")]
		public static Dova.JDK.java.lang.String AND_MNEMONIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "static final")]
		public static Dova.JDK.java.lang.String TITLE_SUFFIX_Property
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
		public static Dova.JDK.java.lang.String TEXT_SUFFIX_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TextAndMnemonicHashMap(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public TextAndMnemonicHashMap() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/UIDefaults$TextAndMnemonicHashMap;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object get(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String composeKey(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String getMnemonicFromProperty(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String getTextFromProperty(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String getIndexFromProperty(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/UIDefaults$LazyInputMap;", "public static")]
	public partial class LazyInputMap
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.UIDefaults.LazyValue
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LazyInputMap()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/UIDefaults$LazyInputMap;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bindings", "[Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createValue", "(Ljavax/swing/UIDefaults;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
		public JavaArray<Dova.JDK.java.lang.Object> bindings_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LazyInputMap(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)V", "public")]
		public LazyInputMap(JavaArray<Dova.JDK.java.lang.Object> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/UIDefaults$LazyInputMap;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/UIDefaults;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object createValue(Dova.JDK.javax.swing.UIDefaults arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/UIDefaults$ProxyLazyValue;", "public static")]
	public partial class ProxyLazyValue
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.UIDefaults.LazyValue
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ProxyLazyValue()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/UIDefaults$ProxyLazyValue;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "acc", "Ljava/security/AccessControlContext;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "className", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodName", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "args", "[Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassArray", "([Ljava/lang/Object;)[Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printArgs", "([Ljava/lang/Object;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createValue", "(Ljavax/swing/UIDefaults;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Ljava/security/AccessControlContext;", "private")]
		public Dova.JDK.java.security.AccessControlContext acc_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String className_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String methodName_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
		public JavaArray<Dova.JDK.java.lang.Object> args_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ProxyLazyValue(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "public")]
		public ProxyLazyValue(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "public")]
		public ProxyLazyValue(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public")]
		public ProxyLazyValue(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public ProxyLazyValue(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/UIDefaults$ProxyLazyValue;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([Ljava/lang/Object;)[Ljava/lang/Class;", "private")]
		public JavaArray<Dova.JDK.java.lang.Class> getClassArray(JavaArray<Dova.JDK.java.lang.Object> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String printArgs(JavaArray<Dova.JDK.java.lang.Object> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/UIDefaults;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object createValue(Dova.JDK.javax.swing.UIDefaults arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
