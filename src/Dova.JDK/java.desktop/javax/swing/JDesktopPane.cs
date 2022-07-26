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

[JniSignatureAttribute("Ljavax/swing/JDesktopPane;", "public")]
public partial class JDesktopPane
	: Dova.JDK.javax.swing.JLayeredPane
	, Dova.JDK.javax.accessibility.Accessible
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JDesktopPane()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JDesktopPane;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "uiClassID", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "desktopManager", "Ljavax/swing/DesktopManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selectedFrame", "Ljavax/swing/JInternalFrame;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LIVE_DRAG_MODE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OUTLINE_DRAG_MODE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dragMode", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dragModeSet", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "framesCache", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "componentOrderCheckingEnabled", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "componentOrderChanged", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paramString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeAll", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFrames", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedFrame", "()Ljavax/swing/JInternalFrame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAllFrames", "()[Ljavax/swing/JInternalFrame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAllFrames", "(Ljava/awt/Container;)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verifyFramesCache", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTopInternalFrame", "()Ljavax/swing/JInternalFrame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextFrame", "(Ljavax/swing/JInternalFrame;)Ljavax/swing/JInternalFrame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextFrame", "(Ljavax/swing/JInternalFrame;Z)Ljavax/swing/JInternalFrame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateFramesCache", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setComponentOrderCheckingEnabled", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkComponentAttributes", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDragMode", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDragMode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDesktopManager", "()Ljavax/swing/DesktopManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDesktopManager", "(Ljavax/swing/DesktopManager;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSelectedFrame", "(Ljavax/swing/JInternalFrame;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAllFramesInLayer", "(I)[Ljavax/swing/JInternalFrame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "selectFrame", "(Z)Ljavax/swing/JInternalFrame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateUI", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setUI", "(Ljavax/swing/plaf/DesktopPaneUI;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUI_0", "()Ljavax/swing/plaf/DesktopPaneUI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUI_1", "()Ljavax/swing/plaf/ComponentUI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addImpl", "(Ljava/awt/Component;Ljava/lang/Object;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUIClassID", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setUIProperty", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setComponentZOrder", "(Ljava/awt/Component;I)V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String uiClassID_Property
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

	[JniSignatureAttribute("Ljavax/swing/DesktopManager;", "transient")]
	public Dova.JDK.javax.swing.DesktopManager desktopManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.DesktopManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JInternalFrame;", "private transient")]
	public Dova.JDK.javax.swing.JInternalFrame selectedFrame_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JInternalFrame>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int LIVE_DRAG_MODE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int OUTLINE_DRAG_MODE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int dragMode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool dragModeSet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private transient")]
	public Dova.JDK.java.util.List framesCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool componentOrderCheckingEnabled_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool componentOrderChanged_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JDesktopPane(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public JDesktopPane() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/JDesktopPane;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "public")]
	public void remove(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void remove(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private")]
	public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String paramString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void removeAll()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List getFrames()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/JInternalFrame;", "public")]
	public Dova.JDK.javax.swing.JInternalFrame getSelectedFrame()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JInternalFrame>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/swing/JInternalFrame;", "public")]
	public JavaArray<Dova.JDK.javax.swing.JInternalFrame> getAllFrames()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.JInternalFrame>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Container;)Ljava/util/Collection;", "private static")]
	public static Dova.JDK.java.util.Collection getAllFrames(Dova.JDK.java.awt.Container arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void verifyFramesCache()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("()Ljavax/swing/JInternalFrame;", "private")]
	public Dova.JDK.javax.swing.JInternalFrame getTopInternalFrame()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JInternalFrame>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JInternalFrame;)Ljavax/swing/JInternalFrame;", "")]
	public Dova.JDK.javax.swing.JInternalFrame getNextFrame(Dova.JDK.javax.swing.JInternalFrame arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JInternalFrame>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JInternalFrame;Z)Ljavax/swing/JInternalFrame;", "private")]
	public Dova.JDK.javax.swing.JInternalFrame getNextFrame(Dova.JDK.javax.swing.JInternalFrame arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JInternalFrame>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void updateFramesCache()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("(Z)V", "")]
	public void setComponentOrderCheckingEnabled(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "private")]
	public void checkComponentAttributes(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setDragMode(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getDragMode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/DesktopManager;", "public")]
	public Dova.JDK.javax.swing.DesktopManager getDesktopManager()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.DesktopManager>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/DesktopManager;)V", "public")]
	public void setDesktopManager(Dova.JDK.javax.swing.DesktopManager arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JInternalFrame;)V", "public")]
	public void setSelectedFrame(Dova.JDK.javax.swing.JInternalFrame arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(I)[Ljavax/swing/JInternalFrame;", "public")]
	public JavaArray<Dova.JDK.javax.swing.JInternalFrame> getAllFramesInLayer(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.JInternalFrame>>(ret);
	}

	[JniSignatureAttribute("(Z)Ljavax/swing/JInternalFrame;", "public")]
	public Dova.JDK.javax.swing.JInternalFrame selectFrame(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JInternalFrame>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void updateUI()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23]);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/DesktopPaneUI;)V", "public")]
	public void setUI(Dova.JDK.javax.swing.plaf.DesktopPaneUI arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/DesktopPaneUI;", "public")]
	public Dova.JDK.javax.swing.plaf.DesktopPaneUI getUI_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.DesktopPaneUI>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ComponentUI;", "public volatile")]
	public Dova.JDK.javax.swing.plaf.ComponentUI getUI_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ComponentUI>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/lang/Object;I)V", "protected")]
	public void addImpl(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.lang.Object arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getUIClassID()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "public")]
	public Dova.JDK.javax.accessibility.AccessibleContext getAccessibleContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "")]
	public void setUIProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;I)V", "public")]
	public void setComponentZOrder(Dova.JDK.java.awt.Component arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
	}

	[JniSignatureAttribute("Ljavax/swing/JDesktopPane$ComponentPosition;", "private static")]
	public partial class ComponentPosition
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Comparable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ComponentPosition()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JDesktopPane$ComponentPosition;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "component", "Ljavax/swing/JInternalFrame;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "layer", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "zOrder", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JInternalFrame;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Ljavax/swing/JDesktopPane$ComponentPosition;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Ljava/lang/Object;)I"));
		}

		[JniSignatureAttribute("Ljavax/swing/JInternalFrame;", "private final")]
		public Dova.JDK.javax.swing.JInternalFrame component_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JInternalFrame>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int layer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int zOrder_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ComponentPosition(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JInternalFrame;II)V", "")]
		public ComponentPosition(Dova.JDK.javax.swing.JInternalFrame arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JDesktopPane$ComponentPosition;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/JDesktopPane$ComponentPosition;)I", "public")]
		public int compareTo(Dova.JDK.javax.swing.JDesktopPane.ComponentPosition arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)I", "public volatile")]
		public int compareTo(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JDesktopPane$AccessibleJDesktopPane;", "protected")]
	public partial class AccessibleJDesktopPane
		: Dova.JDK.javax.swing.JComponent.AccessibleJComponent
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AccessibleJDesktopPane()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JDesktopPane$AccessibleJDesktopPane;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/JDesktopPane;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JDesktopPane;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRole", "()Ljavax/accessibility/AccessibleRole;"));
		}

		[JniSignatureAttribute("Ljavax/swing/JDesktopPane;", "final")]
		public Dova.JDK.javax.swing.JDesktopPane this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JDesktopPane>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AccessibleJDesktopPane(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JDesktopPane;)V", "protected")]
		public AccessibleJDesktopPane(Dova.JDK.javax.swing.JDesktopPane arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JDesktopPane$AccessibleJDesktopPane;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleRole;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleRole getAccessibleRole()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleRole>(ret);
		}
	}
}
