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

namespace Dova.JDK.javax.swing.text.html;

[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML;", "")]
public partial class AccessibleHTML
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.accessibility.Accessible
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AccessibleHTML()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/AccessibleHTML;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "editor", "Ljavax/swing/JEditorPane;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "model", "Ljavax/swing/text/Document;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "docListener", "Ljavax/swing/event/DocumentListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "propChangeListener", "Ljava/beans/PropertyChangeListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rootElementInfo", "Ljavax/swing/text/html/AccessibleHTML$ElementInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rootHTMLAccessibleContext", "Ljavax/swing/text/html/AccessibleHTML$RootHTMLAccessibleContext;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JEditorPane;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lock", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unlock", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRootView", "()Ljavax/swing/text/View;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRootEditorRect", "()Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDocument", "(Ljavax/swing/text/Document;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocument", "()Ljavax/swing/text/Document;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildInfo", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRootInfo", "()Ljavax/swing/text/html/AccessibleHTML$ElementInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createElementInfo", "(Ljavax/swing/text/Element;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)Ljavax/swing/text/html/AccessibleHTML$ElementInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTextComponent", "()Ljavax/swing/JEditorPane;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
	}

	[JniSignatureAttribute("Ljavax/swing/JEditorPane;", "private")]
	public Dova.JDK.javax.swing.JEditorPane editor_Property
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

	[JniSignatureAttribute("Ljavax/swing/text/Document;", "private")]
	public Dova.JDK.javax.swing.text.Document model_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Document>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/event/DocumentListener;", "private")]
	public Dova.JDK.javax.swing.@event.DocumentListener docListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.DocumentListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/beans/PropertyChangeListener;", "private")]
	public Dova.JDK.java.beans.PropertyChangeListener propChangeListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PropertyChangeListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$ElementInfo;", "private")]
	public Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo rootElementInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$RootHTMLAccessibleContext;", "private")]
	public Dova.JDK.javax.swing.text.html.AccessibleHTML.RootHTMLAccessibleContext rootHTMLAccessibleContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML.RootHTMLAccessibleContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AccessibleHTML(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/JEditorPane;)V", "public")]
	public AccessibleHTML(Dova.JDK.javax.swing.JEditorPane arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/text/html/AccessibleHTML;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object @lock()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "private")]
	public void unlock(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/View;", "private")]
	public Dova.JDK.javax.swing.text.View getRootView()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Rectangle;", "private")]
	public Dova.JDK.java.awt.Rectangle getRootEditorRect()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Document;)V", "private")]
	public void setDocument(Dova.JDK.javax.swing.text.Document arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/Document;", "private")]
	public Dova.JDK.javax.swing.text.Document getDocument()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Document>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void buildInfo()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/html/AccessibleHTML$ElementInfo;", "private")]
	public Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo getRootInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)Ljavax/swing/text/html/AccessibleHTML$ElementInfo;", "")]
	public Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo createElementInfo(Dova.JDK.javax.swing.text.Element arg0, Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/JEditorPane;", "private")]
	public Dova.JDK.javax.swing.JEditorPane getTextComponent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JEditorPane>(ret);
	}

	[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "public")]
	public Dova.JDK.javax.accessibility.AccessibleContext getAccessibleContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$PropertyChangeHandler;", "private")]
	public partial class PropertyChangeHandler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.beans.PropertyChangeListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PropertyChangeHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/AccessibleHTML$PropertyChangeHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/text/html/AccessibleHTML;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/html/AccessibleHTML;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML;", "final")]
		public Dova.JDK.javax.swing.text.html.AccessibleHTML this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PropertyChangeHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML;)V", "private")]
		public PropertyChangeHandler(Dova.JDK.javax.swing.text.html.AccessibleHTML arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/AccessibleHTML$PropertyChangeHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "public")]
		public void propertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$DocumentHandler;", "private")]
	public partial class DocumentHandler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.@event.DocumentListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DocumentHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/AccessibleHTML$DocumentHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/text/html/AccessibleHTML;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/html/AccessibleHTML;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertUpdate", "(Ljavax/swing/event/DocumentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeUpdate", "(Ljavax/swing/event/DocumentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changedUpdate", "(Ljavax/swing/event/DocumentEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML;", "final")]
		public Dova.JDK.javax.swing.text.html.AccessibleHTML this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DocumentHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML;)V", "private")]
		public DocumentHandler(Dova.JDK.javax.swing.text.html.AccessibleHTML arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/AccessibleHTML$DocumentHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;)V", "public")]
		public void insertUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;)V", "public")]
		public void removeUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;)V", "public")]
		public void changedUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$ElementInfo;", "private")]
	public partial class ElementInfo
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ElementInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/AccessibleHTML$ElementInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "children", "Ljava/util/ArrayList;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "element", "Ljavax/swing/text/Element;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parent", "Ljavax/swing/text/html/AccessibleHTML$ElementInfo;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isValid", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canBeValid", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/text/html/AccessibleHTML;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/html/AccessibleHTML;Ljavax/swing/text/Element;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/html/AccessibleHTML;Ljavax/swing/text/Element;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indexOf", "(Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "(Ljavax/swing/event/DocumentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "()Ljava/awt/Rectangle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validate", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParent", "()Ljavax/swing/text/html/AccessibleHTML$ElementInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "()Ljavax/swing/text/AttributeSet;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValid", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElement", "()Ljavax/swing/text/Element;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIntAttr", "(Ljavax/swing/text/AttributeSet;Ljava/lang/Object;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClosestInfoIndex", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndexInParent", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateIfNecessary", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getViewAttributes", "()Ljavax/swing/text/AttributeSet;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadChildren", "(Ljavax/swing/text/Element;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getView", "(Ljavax/swing/text/View;Ljavax/swing/text/Element;I)Ljavax/swing/text/View;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getView", "()Ljavax/swing/text/View;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChildCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChild", "(I)Ljavax/swing/text/html/AccessibleHTML$ElementInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addChild", "(Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invalidate", "(Z)V"));
		}

		[JniSignatureAttribute("Ljava/util/ArrayList;", "private")]
		public Dova.JDK.java.util.ArrayList children_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/Element;", "private")]
		public Dova.JDK.javax.swing.text.Element element_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$ElementInfo;", "private")]
		public Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo parent_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool isValid_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool canBeValid_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML;", "final")]
		public Dova.JDK.javax.swing.text.html.AccessibleHTML this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ElementInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML;Ljavax/swing/text/Element;)V", "")]
		public ElementInfo(Dova.JDK.javax.swing.text.html.AccessibleHTML arg0, Dova.JDK.javax.swing.text.Element arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML;Ljavax/swing/text/Element;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V", "")]
		public ElementInfo(Dova.JDK.javax.swing.text.html.AccessibleHTML arg0, Dova.JDK.javax.swing.text.Element arg1, Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/AccessibleHTML$ElementInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)I", "public")]
		public int indexOf(Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;)V", "private")]
		public void update(Dova.JDK.javax.swing.@event.DocumentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Ljava/awt/Rectangle;", "public")]
		public Dova.JDK.java.awt.Rectangle getBounds()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}

		[JniSignatureAttribute("()V", "protected")]
		public void validate()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("()Ljavax/swing/text/html/AccessibleHTML$ElementInfo;", "public")]
		public Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo getParent()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo>(ret);
		}

		[JniSignatureAttribute("()Ljavax/swing/text/AttributeSet;", "protected")]
		public Dova.JDK.javax.swing.text.AttributeSet getAttributes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
		}

		[JniSignatureAttribute("()Z", "protected")]
		public bool isValid()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/swing/text/Element;", "public")]
		public Dova.JDK.javax.swing.text.Element getElement()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/AttributeSet;Ljava/lang/Object;I)I", "protected")]
		public int getIntAttr(Dova.JDK.javax.swing.text.AttributeSet arg0, Dova.JDK.java.lang.Object arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(I)I", "private")]
		public int getClosestInfoIndex(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getIndexInParent()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "protected")]
		public bool validateIfNecessary()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/swing/text/AttributeSet;", "protected")]
		public Dova.JDK.javax.swing.text.AttributeSet getViewAttributes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/Element;)V", "protected")]
		public void loadChildren(Dova.JDK.javax.swing.text.Element arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/View;Ljavax/swing/text/Element;I)Ljavax/swing/text/View;", "private")]
		public Dova.JDK.javax.swing.text.View getView(Dova.JDK.javax.swing.text.View arg0, Dova.JDK.javax.swing.text.Element arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
		}

		[JniSignatureAttribute("()Ljavax/swing/text/View;", "protected")]
		public Dova.JDK.javax.swing.text.View getView()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getChildCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16]);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljavax/swing/text/html/AccessibleHTML$ElementInfo;", "public")]
		public Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo getChild(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V", "protected")]
		public void addChild(Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		}

		[JniSignatureAttribute("(Z)V", "protected")]
		public void invalidate(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$IconElementInfo;", "private")]
	public partial class IconElementInfo
		: Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo
		, Dova.JDK.javax.accessibility.Accessible
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IconElementInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/AccessibleHTML$IconElementInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "width", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "height", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "accessibleContext", "Ljavax/accessibility/AccessibleContext;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/text/html/AccessibleHTML;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/html/AccessibleHTML;Ljavax/swing/text/Element;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImageSize", "(Ljava/lang/Object;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invalidate", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
		}

		[JniSignatureAttribute("I", "private")]
		public int width_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int height_Property
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

		[JniSignatureAttribute("Ljavax/accessibility/AccessibleContext;", "private")]
		public Dova.JDK.javax.accessibility.AccessibleContext accessibleContext_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML;", "final")]
		public Dova.JDK.javax.swing.text.html.AccessibleHTML this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IconElementInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML;Ljavax/swing/text/Element;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V", "")]
		public IconElementInfo(Dova.JDK.javax.swing.text.html.AccessibleHTML arg0, Dova.JDK.javax.swing.text.Element arg1, Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/AccessibleHTML$IconElementInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)I", "private")]
		public int getImageSize(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Z)V", "protected")]
		public void invalidate(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleContext getAccessibleContext()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$IconElementInfo$IconAccessibleContext;", "protected")]
		public partial class IconAccessibleContext
			: Dova.JDK.javax.swing.text.html.AccessibleHTML.HTMLAccessibleContext
			, Dova.JDK.javax.accessibility.AccessibleIcon
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static IconAccessibleContext()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/AccessibleHTML$IconElementInfo$IconAccessibleContext;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Ljavax/swing/text/html/AccessibleHTML$IconElementInfo;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/html/AccessibleHTML$IconElementInfo;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleDescription", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRole", "()Ljavax/accessibility/AccessibleRole;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleIcon", "()[Ljavax/accessibility/AccessibleIcon;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleIconDescription", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleIconDescription", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleIconWidth", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleIconHeight", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleName", "()Ljava/lang/String;"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$IconElementInfo;", "final")]
			public Dova.JDK.javax.swing.text.html.AccessibleHTML.IconElementInfo this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML.IconElementInfo>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public IconAccessibleContext(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML$IconElementInfo;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V", "public")]
			public IconAccessibleContext(Dova.JDK.javax.swing.text.html.AccessibleHTML.IconElementInfo arg0, Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/AccessibleHTML$IconElementInfo$IconAccessibleContext;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getAccessibleDescription()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleRole;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleRole getAccessibleRole()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleRole>(ret);
			}

			[JniSignatureAttribute("()[Ljavax/accessibility/AccessibleIcon;", "public")]
			public JavaArray<Dova.JDK.javax.accessibility.AccessibleIcon> getAccessibleIcon()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.accessibility.AccessibleIcon>>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getAccessibleIconDescription()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
			public void setAccessibleIconDescription(Dova.JDK.java.lang.String arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			}

			[JniSignatureAttribute("()I", "public")]
			public int getAccessibleIconWidth()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
				return ret;
			}

			[JniSignatureAttribute("()I", "public")]
			public int getAccessibleIconHeight()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getAccessibleName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$TextElementInfo;", "")]
	public partial class TextElementInfo
		: Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo
		, Dova.JDK.javax.accessibility.Accessible
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TextElementInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/AccessibleHTML$TextElementInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "accessibleContext", "Ljavax/accessibility/AccessibleContext;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/text/html/AccessibleHTML;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/html/AccessibleHTML;Ljavax/swing/text/Element;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
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

		[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML;", "final")]
		public Dova.JDK.javax.swing.text.html.AccessibleHTML this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TextElementInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML;Ljavax/swing/text/Element;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V", "")]
		public TextElementInfo(Dova.JDK.javax.swing.text.html.AccessibleHTML arg0, Dova.JDK.javax.swing.text.Element arg1, Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/AccessibleHTML$TextElementInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleContext getAccessibleContext()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$TextElementInfo$TextAccessibleContext;", "public")]
		public partial class TextAccessibleContext
			: Dova.JDK.javax.swing.text.html.AccessibleHTML.HTMLAccessibleContext
			, Dova.JDK.javax.accessibility.AccessibleText
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TextAccessibleContext()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/AccessibleHTML$TextElementInfo$TextAccessibleContext;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Ljavax/swing/text/html/AccessibleHTML$TextElementInfo;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/html/AccessibleHTML$TextElementInfo;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/awt/Point;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "()Ljava/awt/Rectangle;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocation", "()Ljava/awt/Point;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSize", "()Ljava/awt/Dimension;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocale", "()Ljava/util/Locale;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getText", "(II)Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSize", "(Ljava/awt/Dimension;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnabled", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharCount", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSegmentAt", "(II)Ljavax/swing/text/html/AccessibleHTML$TextElementInfo$TextAccessibleContext$IndexedSegment;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParagraphElementText", "(I)Ljavax/swing/text/html/AccessibleHTML$TextElementInfo$TextAccessibleContext$IndexedSegment;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleDescription", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRole", "()Ljavax/accessibility/AccessibleRole;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleText", "()Ljavax/accessibility/AccessibleText;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectionEnd", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectionStart", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCaretPosition", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedText", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocation", "(Ljava/awt/Point;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setForeground", "(Ljava/awt/Color;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFont", "(Ljava/awt/Font;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEnabled", "(Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setVisible", "(Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addFocusListener", "(Ljava/awt/event/FocusListener;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFont", "()Ljava/awt/Font;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestFocus", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndexAtPoint", "(Ljava/awt/Point;)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharacterBounds", "(I)Ljava/awt/Rectangle;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAtIndex", "(II)Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAtIndex", "(III)Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAfterIndex", "(II)Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBeforeIndex", "(II)Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharacterAttribute", "(I)Ljavax/swing/text/AttributeSet;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParagraphElement", "(I)Ljavax/swing/text/Element;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVisible", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isShowing", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCursor", "(Ljava/awt/Cursor;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getForeground", "()Ljava/awt/Color;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFontMetrics", "(Ljava/awt/Font;)Ljava/awt/FontMetrics;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBackground", "()Ljava/awt/Color;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBackground", "(Ljava/awt/Color;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBounds", "(Ljava/awt/Rectangle;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleChildrenCount", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleChild", "(I)Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleComponent", "()Ljavax/accessibility/AccessibleComponent;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleAt", "(Ljava/awt/Point;)Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationOnScreen", "()Ljava/awt/Point;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFocusTraversable", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleIndexInParent", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCursor", "()Ljava/awt/Cursor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeFocusListener", "(Ljava/awt/event/FocusListener;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleStateSet", "()Ljavax/accessibility/AccessibleStateSet;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleName", "()Ljava/lang/String;"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$TextElementInfo;", "final")]
			public Dova.JDK.javax.swing.text.html.AccessibleHTML.TextElementInfo this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML.TextElementInfo>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public TextAccessibleContext(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML$TextElementInfo;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V", "public")]
			public TextAccessibleContext(Dova.JDK.javax.swing.text.html.AccessibleHTML.TextElementInfo arg0, Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/AccessibleHTML$TextElementInfo$TextAccessibleContext;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/awt/Point;)Z", "public volatile")]
			public bool contains(Dova.JDK.java.awt.Point arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/awt/Rectangle;", "public volatile")]
			public Dova.JDK.java.awt.Rectangle getBounds()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Point;", "public volatile")]
			public Dova.JDK.java.awt.Point getLocation()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Dimension;", "public volatile")]
			public Dova.JDK.java.awt.Dimension getSize()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Locale;", "public volatile")]
			public Dova.JDK.java.util.Locale getLocale()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
			}

			[JniSignatureAttribute("(II)Ljava/lang/String;", "private")]
			public Dova.JDK.java.lang.String getText(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Dimension;)V", "public volatile")]
			public void setSize(Dova.JDK.java.awt.Dimension arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			}

			[JniSignatureAttribute("()Z", "public volatile")]
			public bool isEnabled()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
				return ret;
			}

			[JniSignatureAttribute("()I", "public")]
			public int getCharCount()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
				return ret;
			}

			[JniSignatureAttribute("(II)Ljavax/swing/text/html/AccessibleHTML$TextElementInfo$TextAccessibleContext$IndexedSegment;", "private")]
			public Dova.JDK.javax.swing.text.html.AccessibleHTML.TextElementInfo.TextAccessibleContext.IndexedSegment getSegmentAt(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML.TextElementInfo.TextAccessibleContext.IndexedSegment>(ret);
			}

			[JniSignatureAttribute("(I)Ljavax/swing/text/html/AccessibleHTML$TextElementInfo$TextAccessibleContext$IndexedSegment;", "private")]
			public Dova.JDK.javax.swing.text.html.AccessibleHTML.TextElementInfo.TextAccessibleContext.IndexedSegment getParagraphElementText(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML.TextElementInfo.TextAccessibleContext.IndexedSegment>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getAccessibleDescription()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleRole;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleRole getAccessibleRole()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleRole>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleText;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleText getAccessibleText()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleText>(ret);
			}

			[JniSignatureAttribute("()I", "public")]
			public int getSelectionEnd()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14]);
				return ret;
			}

			[JniSignatureAttribute("()I", "public")]
			public int getSelectionStart()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15]);
				return ret;
			}

			[JniSignatureAttribute("()I", "public")]
			public int getCaretPosition()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getSelectedText()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Point;)V", "public volatile")]
			public void setLocation(Dova.JDK.java.awt.Point arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/Color;)V", "public volatile")]
			public void setForeground(Dova.JDK.java.awt.Color arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/Font;)V", "public volatile")]
			public void setFont(Dova.JDK.java.awt.Font arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
			}

			[JniSignatureAttribute("(Z)V", "public volatile")]
			public void setEnabled(bool arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
			}

			[JniSignatureAttribute("(Z)V", "public volatile")]
			public void setVisible(bool arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/event/FocusListener;)V", "public volatile")]
			public void addFocusListener(Dova.JDK.java.awt.@event.FocusListener arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
			}

			[JniSignatureAttribute("()Ljava/awt/Font;", "public volatile")]
			public Dova.JDK.java.awt.Font getFont()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
			}

			[JniSignatureAttribute("()V", "public volatile")]
			public void requestFocus()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25]);
			}

			[JniSignatureAttribute("(Ljava/awt/Point;)I", "public")]
			public int getIndexAtPoint(Dova.JDK.java.awt.Point arg0)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
				return ret;
			}

			[JniSignatureAttribute("(I)Ljava/awt/Rectangle;", "public")]
			public Dova.JDK.java.awt.Rectangle getCharacterBounds(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
			}

			[JniSignatureAttribute("(II)Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getAtIndex(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(III)Ljava/lang/String;", "private")]
			public Dova.JDK.java.lang.String getAtIndex(int arg0, int arg1, int arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(II)Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getAfterIndex(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(II)Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getBeforeIndex(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(I)Ljavax/swing/text/AttributeSet;", "public")]
			public Dova.JDK.javax.swing.text.AttributeSet getCharacterAttribute(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
			}

			[JniSignatureAttribute("(I)Ljavax/swing/text/Element;", "private")]
			public Dova.JDK.javax.swing.text.Element getParagraphElement(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
			}

			[JniSignatureAttribute("()Z", "public volatile")]
			public bool isVisible()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[34]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "public volatile")]
			public bool isShowing()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[35]);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/awt/Cursor;)V", "public volatile")]
			public void setCursor(Dova.JDK.java.awt.Cursor arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "public volatile")]
			public Dova.JDK.javax.accessibility.AccessibleContext getAccessibleContext()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Color;", "public volatile")]
			public Dova.JDK.java.awt.Color getForeground()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Font;)Ljava/awt/FontMetrics;", "public volatile")]
			public Dova.JDK.java.awt.FontMetrics getFontMetrics(Dova.JDK.java.awt.Font arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.FontMetrics>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Color;", "public volatile")]
			public Dova.JDK.java.awt.Color getBackground()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Color;)V", "public volatile")]
			public void setBackground(Dova.JDK.java.awt.Color arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/Rectangle;)V", "public volatile")]
			public void setBounds(Dova.JDK.java.awt.Rectangle arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
			}

			[JniSignatureAttribute("()I", "public volatile")]
			public int getAccessibleChildrenCount()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[43]);
				return ret;
			}

			[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public volatile")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleChild(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleComponent;", "public volatile")]
			public Dova.JDK.javax.accessibility.AccessibleComponent getAccessibleComponent()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleComponent>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Point;)Ljavax/accessibility/Accessible;", "public volatile")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleAt(Dova.JDK.java.awt.Point arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Point;", "public volatile")]
			public Dova.JDK.java.awt.Point getLocationOnScreen()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
			}

			[JniSignatureAttribute("()Z", "public volatile")]
			public bool isFocusTraversable()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[48]);
				return ret;
			}

			[JniSignatureAttribute("()I", "public volatile")]
			public int getAccessibleIndexInParent()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[49]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/awt/Cursor;", "public volatile")]
			public Dova.JDK.java.awt.Cursor getCursor()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/event/FocusListener;)V", "public volatile")]
			public void removeFocusListener(Dova.JDK.java.awt.@event.FocusListener arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleStateSet;", "public volatile")]
			public Dova.JDK.javax.accessibility.AccessibleStateSet getAccessibleStateSet()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleStateSet>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getAccessibleName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$TextElementInfo$TextAccessibleContext$IndexedSegment;", "private")]
			public partial class IndexedSegment
				: Dova.JDK.javax.swing.text.Segment
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static IndexedSegment()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/AccessibleHTML$TextElementInfo$TextAccessibleContext$IndexedSegment;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modelOffset", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/html/AccessibleHTML$TextElementInfo$TextAccessibleContext;)V"));
				}

				[JniSignatureAttribute("I", "public")]
				public int modelOffset_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public IndexedSegment(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML$TextElementInfo$TextAccessibleContext;)V", "private")]
				public IndexedSegment(Dova.JDK.javax.swing.text.html.AccessibleHTML.TextElementInfo.TextAccessibleContext arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Ljavax/swing/text/html/AccessibleHTML$TextElementInfo$TextAccessibleContext$IndexedSegment;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
			}
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$TableElementInfo;", "private")]
	public partial class TableElementInfo
		: Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo
		, Dova.JDK.javax.accessibility.Accessible
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TableElementInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/AccessibleHTML$TableElementInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "caption", "Ljavax/swing/text/html/AccessibleHTML$ElementInfo;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "grid", "[[Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableCellElementInfo;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "accessibleContext", "Ljavax/accessibility/AccessibleContext;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/text/html/AccessibleHTML;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/html/AccessibleHTML;Ljavax/swing/text/Element;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validate", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCaptionInfo", "()Ljavax/swing/text/html/AccessibleHTML$ElementInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCell", "(II)Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableCellElementInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowExtentAt", "(II)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColumnExtentAt", "(II)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadChildren", "(Ljavax/swing/text/Element;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateGrid", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColumnCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRow", "(I)Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableRowElementInfo;"));
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$ElementInfo;", "protected")]
		public Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo caption_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[[Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableCellElementInfo;", "private")]
		public JavaArray<JavaArray<Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo.TableCellElementInfo>> grid_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo.TableCellElementInfo>>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/accessibility/AccessibleContext;", "private")]
		public Dova.JDK.javax.accessibility.AccessibleContext accessibleContext_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML;", "final")]
		public Dova.JDK.javax.swing.text.html.AccessibleHTML this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TableElementInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML;Ljavax/swing/text/Element;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V", "")]
		public TableElementInfo(Dova.JDK.javax.swing.text.html.AccessibleHTML arg0, Dova.JDK.javax.swing.text.Element arg1, Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/AccessibleHTML$TableElementInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "protected")]
		public void validate()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getRowCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/swing/text/html/AccessibleHTML$ElementInfo;", "public")]
		public Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo getCaptionInfo()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo>(ret);
		}

		[JniSignatureAttribute("(II)Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableCellElementInfo;", "public")]
		public Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo.TableCellElementInfo getCell(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo.TableCellElementInfo>(ret);
		}

		[JniSignatureAttribute("(II)I", "public")]
		public int getRowExtentAt(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(II)I", "public")]
		public int getColumnExtentAt(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/Element;)V", "protected")]
		public void loadChildren(Dova.JDK.javax.swing.text.Element arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("()V", "private")]
		public void updateGrid()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
		}

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleContext getAccessibleContext()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getColumnCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableRowElementInfo;", "public")]
		public Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo.TableRowElementInfo getRow(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo.TableRowElementInfo>(ret);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableRowElementInfo;", "private")]
		public partial class TableRowElementInfo
			: Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TableRowElementInfo()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableRowElementInfo;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parent", "Ljavax/swing/text/html/AccessibleHTML$TableElementInfo;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rowNumber", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Ljavax/swing/text/html/AccessibleHTML$TableElementInfo;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/html/AccessibleHTML$TableElementInfo;Ljavax/swing/text/Element;Ljavax/swing/text/html/AccessibleHTML$TableElementInfo;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowCount", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadChildren", "(Ljavax/swing/text/Element;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateGrid", "(I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invalidate", "(Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColumnCount", "(I)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColumnCount", "()I"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$TableElementInfo;", "private")]
			public Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo parent_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private")]
			public int rowNumber_Property
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

			[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$TableElementInfo;", "final")]
			public Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public TableRowElementInfo(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML$TableElementInfo;Ljavax/swing/text/Element;Ljavax/swing/text/html/AccessibleHTML$TableElementInfo;I)V", "")]
			public TableRowElementInfo(Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo arg0, Dova.JDK.javax.swing.text.Element arg1, Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableRowElementInfo;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()I", "public")]
			public int getRowCount()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
				return ret;
			}

			[JniSignatureAttribute("(Ljavax/swing/text/Element;)V", "protected")]
			public void loadChildren(Dova.JDK.javax.swing.text.Element arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("(I)V", "private")]
			public void updateGrid(int arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			}

			[JniSignatureAttribute("(Z)V", "protected")]
			public void invalidate(bool arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			}

			[JniSignatureAttribute("(I)I", "private")]
			public int getColumnCount(int arg0)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return ret;
			}

			[JniSignatureAttribute("()I", "public")]
			public int getColumnCount()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
				return ret;
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableCellElementInfo;", "private")]
		public partial class TableCellElementInfo
			: Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TableCellElementInfo()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableCellElementInfo;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "accessible", "Ljavax/accessibility/Accessible;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isHeaderCell", "Z"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/html/AccessibleHTML$TableElementInfo;Ljavax/swing/text/Element;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/html/AccessibleHTML$TableElementInfo;Ljavax/swing/text/Element;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowCount", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isHeaderCell", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessible", "(Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessible", "()Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invalidate", "(Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColumnCount", "()I"));
			}

			[JniSignatureAttribute("Ljavax/accessibility/Accessible;", "private")]
			public Dova.JDK.javax.accessibility.Accessible accessible_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Z", "private")]
			public bool isHeaderCell_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public TableCellElementInfo(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML$TableElementInfo;Ljavax/swing/text/Element;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V", "")]
			public TableCellElementInfo(Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo arg0, Dova.JDK.javax.swing.text.Element arg1, Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML$TableElementInfo;Ljavax/swing/text/Element;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;Z)V", "")]
			public TableCellElementInfo(Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo arg0, Dova.JDK.javax.swing.text.Element arg1, Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableCellElementInfo;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()I", "public")]
			public int getRowCount()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isHeaderCell()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V", "private")]
			public void getAccessible(Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessible()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("(Z)V", "protected")]
			public void invalidate(bool arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			}

			[JniSignatureAttribute("()I", "public")]
			public int getColumnCount()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
				return ret;
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableAccessibleContext;", "public")]
		public partial class TableAccessibleContext
			: Dova.JDK.javax.swing.text.html.AccessibleHTML.HTMLAccessibleContext
			, Dova.JDK.javax.accessibility.AccessibleTable
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TableAccessibleContext()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableAccessibleContext;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rowHeadersTable", "Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableAccessibleContext$AccessibleHeadersTable;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Ljavax/swing/text/html/AccessibleHTML$TableElementInfo;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/html/AccessibleHTML$TableElementInfo;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/awt/Point;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "()Ljava/awt/Rectangle;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocation", "()Ljava/awt/Point;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSize", "()Ljava/awt/Dimension;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocale", "()Ljava/util/Locale;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSize", "(Ljava/awt/Dimension;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnabled", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleDescription", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRole", "()Ljavax/accessibility/AccessibleRole;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleTable", "()Ljavax/accessibility/AccessibleTable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRow", "(I)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleColumn", "(I)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleIndex", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocation", "(Ljava/awt/Point;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setForeground", "(Ljava/awt/Color;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFont", "(Ljava/awt/Font;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEnabled", "(Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setVisible", "(Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addFocusListener", "(Ljava/awt/event/FocusListener;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFont", "()Ljava/awt/Font;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestFocus", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleCaption", "()Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleCaption", "(Ljavax/accessibility/Accessible;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleSummary", "()Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleSummary", "(Ljavax/accessibility/Accessible;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRowCount", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleColumnCount", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRowExtentAt", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleColumnExtentAt", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRowHeader", "(I)Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRowHeader", "()Ljavax/accessibility/AccessibleTable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleRowHeader", "(Ljavax/accessibility/AccessibleTable;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleColumnHeader", "(I)Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleColumnHeader", "()Ljavax/accessibility/AccessibleTable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleColumnHeader", "(Ljavax/accessibility/AccessibleTable;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRowDescription", "(I)Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleRowDescription", "(ILjavax/accessibility/Accessible;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleColumnDescription", "(I)Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleColumnDescription", "(ILjavax/accessibility/Accessible;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccessibleSelected", "(II)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccessibleRowSelected", "(I)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccessibleColumnSelected", "(I)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedAccessibleRows", "()[I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedAccessibleColumns", "()[I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addRowHeader", "(Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableCellElementInfo;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVisible", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isShowing", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCursor", "(Ljava/awt/Cursor;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getForeground", "()Ljava/awt/Color;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFontMetrics", "(Ljava/awt/Font;)Ljava/awt/FontMetrics;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBackground", "()Ljava/awt/Color;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBackground", "(Ljava/awt/Color;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBounds", "(Ljava/awt/Rectangle;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleChildrenCount", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleChild", "(I)Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleComponent", "()Ljavax/accessibility/AccessibleComponent;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleAt", "(II)Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleAt", "(Ljava/awt/Point;)Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationOnScreen", "()Ljava/awt/Point;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFocusTraversable", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleIndexInParent", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCursor", "()Ljava/awt/Cursor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeFocusListener", "(Ljava/awt/event/FocusListener;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleStateSet", "()Ljavax/accessibility/AccessibleStateSet;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleName", "()Ljava/lang/String;"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableAccessibleContext$AccessibleHeadersTable;", "private")]
			public Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo.TableAccessibleContext.AccessibleHeadersTable rowHeadersTable_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo.TableAccessibleContext.AccessibleHeadersTable>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$TableElementInfo;", "final")]
			public Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public TableAccessibleContext(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML$TableElementInfo;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V", "public")]
			public TableAccessibleContext(Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo arg0, Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableAccessibleContext;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/awt/Point;)Z", "public volatile")]
			public bool contains(Dova.JDK.java.awt.Point arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/awt/Rectangle;", "public volatile")]
			public Dova.JDK.java.awt.Rectangle getBounds()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Point;", "public volatile")]
			public Dova.JDK.java.awt.Point getLocation()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Dimension;", "public volatile")]
			public Dova.JDK.java.awt.Dimension getSize()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Locale;", "public volatile")]
			public Dova.JDK.java.util.Locale getLocale()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Dimension;)V", "public volatile")]
			public void setSize(Dova.JDK.java.awt.Dimension arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			}

			[JniSignatureAttribute("()Z", "public volatile")]
			public bool isEnabled()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getAccessibleDescription()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleRole;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleRole getAccessibleRole()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleRole>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleTable;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleTable getAccessibleTable()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleTable>(ret);
			}

			[JniSignatureAttribute("(I)I", "public")]
			public int getAccessibleRow(int arg0)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
				return ret;
			}

			[JniSignatureAttribute("(I)I", "public")]
			public int getAccessibleColumn(int arg0)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
				return ret;
			}

			[JniSignatureAttribute("(II)I", "public")]
			public int getAccessibleIndex(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/awt/Point;)V", "public volatile")]
			public void setLocation(Dova.JDK.java.awt.Point arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/Color;)V", "public volatile")]
			public void setForeground(Dova.JDK.java.awt.Color arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/Font;)V", "public volatile")]
			public void setFont(Dova.JDK.java.awt.Font arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			}

			[JniSignatureAttribute("(Z)V", "public volatile")]
			public void setEnabled(bool arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			}

			[JniSignatureAttribute("(Z)V", "public volatile")]
			public void setVisible(bool arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/event/FocusListener;)V", "public volatile")]
			public void addFocusListener(Dova.JDK.java.awt.@event.FocusListener arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			}

			[JniSignatureAttribute("()Ljava/awt/Font;", "public volatile")]
			public Dova.JDK.java.awt.Font getFont()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
			}

			[JniSignatureAttribute("()V", "public volatile")]
			public void requestFocus()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20]);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleCaption()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("(Ljavax/accessibility/Accessible;)V", "public")]
			public void setAccessibleCaption(Dova.JDK.javax.accessibility.Accessible arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleSummary()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("(Ljavax/accessibility/Accessible;)V", "public")]
			public void setAccessibleSummary(Dova.JDK.javax.accessibility.Accessible arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
			}

			[JniSignatureAttribute("()I", "public")]
			public int getAccessibleRowCount()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25]);
				return ret;
			}

			[JniSignatureAttribute("()I", "public")]
			public int getAccessibleColumnCount()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[26]);
				return ret;
			}

			[JniSignatureAttribute("(II)I", "public")]
			public int getAccessibleRowExtentAt(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("(II)I", "public")]
			public int getAccessibleColumnExtentAt(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getAccessibleRowHeader(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleTable;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleTable getAccessibleRowHeader()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleTable>(ret);
			}

			[JniSignatureAttribute("(Ljavax/accessibility/AccessibleTable;)V", "public")]
			public void setAccessibleRowHeader(Dova.JDK.javax.accessibility.AccessibleTable arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
			}

			[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getAccessibleColumnHeader(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleTable;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleTable getAccessibleColumnHeader()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleTable>(ret);
			}

			[JniSignatureAttribute("(Ljavax/accessibility/AccessibleTable;)V", "public")]
			public void setAccessibleColumnHeader(Dova.JDK.javax.accessibility.AccessibleTable arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
			}

			[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleRowDescription(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("(ILjavax/accessibility/Accessible;)V", "public")]
			public void setAccessibleRowDescription(int arg0, Dova.JDK.javax.accessibility.Accessible arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
			}

			[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleColumnDescription(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("(ILjavax/accessibility/Accessible;)V", "public")]
			public void setAccessibleColumnDescription(int arg0, Dova.JDK.javax.accessibility.Accessible arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
			}

			[JniSignatureAttribute("(II)Z", "public")]
			public bool isAccessibleSelected(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("(I)Z", "public")]
			public bool isAccessibleRowSelected(int arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
				return ret;
			}

			[JniSignatureAttribute("(I)Z", "public")]
			public bool isAccessibleColumnSelected(int arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
				return ret;
			}

			[JniSignatureAttribute("()[I", "public")]
			public JavaArray<int> getSelectedAccessibleRows()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}

			[JniSignatureAttribute("()[I", "public")]
			public JavaArray<int> getSelectedAccessibleColumns()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableCellElementInfo;I)V", "public")]
			public void addRowHeader(Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo.TableCellElementInfo arg0, int arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
			}

			[JniSignatureAttribute("()Z", "public volatile")]
			public bool isVisible()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[45]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "public volatile")]
			public bool isShowing()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[46]);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/awt/Cursor;)V", "public volatile")]
			public void setCursor(Dova.JDK.java.awt.Cursor arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "public volatile")]
			public Dova.JDK.javax.accessibility.AccessibleContext getAccessibleContext()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Color;", "public volatile")]
			public Dova.JDK.java.awt.Color getForeground()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Font;)Ljava/awt/FontMetrics;", "public volatile")]
			public Dova.JDK.java.awt.FontMetrics getFontMetrics(Dova.JDK.java.awt.Font arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.FontMetrics>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Color;", "public volatile")]
			public Dova.JDK.java.awt.Color getBackground()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Color;)V", "public volatile")]
			public void setBackground(Dova.JDK.java.awt.Color arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/Rectangle;)V", "public volatile")]
			public void setBounds(Dova.JDK.java.awt.Rectangle arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
			}

			[JniSignatureAttribute("()I", "public")]
			public int getAccessibleChildrenCount()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[54]);
				return ret;
			}

			[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleChild(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleComponent;", "public volatile")]
			public Dova.JDK.javax.accessibility.AccessibleComponent getAccessibleComponent()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleComponent>(ret);
			}

			[JniSignatureAttribute("(II)Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleAt(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Point;)Ljavax/accessibility/Accessible;", "public volatile")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleAt(Dova.JDK.java.awt.Point arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Point;", "public volatile")]
			public Dova.JDK.java.awt.Point getLocationOnScreen()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
			}

			[JniSignatureAttribute("()Z", "public volatile")]
			public bool isFocusTraversable()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[60]);
				return ret;
			}

			[JniSignatureAttribute("()I", "public")]
			public int getAccessibleIndexInParent()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[61]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/awt/Cursor;", "public volatile")]
			public Dova.JDK.java.awt.Cursor getCursor()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/event/FocusListener;)V", "public volatile")]
			public void removeFocusListener(Dova.JDK.java.awt.@event.FocusListener arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleStateSet;", "public volatile")]
			public Dova.JDK.javax.accessibility.AccessibleStateSet getAccessibleStateSet()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleStateSet>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getAccessibleName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableAccessibleContext$AccessibleHeadersTable;", "protected")]
			public partial class AccessibleHeadersTable
				: Dova.JDK.java.lang.Object
				, Dova.JDK.javax.accessibility.AccessibleTable
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static AccessibleHeadersTable()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableAccessibleContext$AccessibleHeadersTable;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "headers", "Ljava/util/Hashtable;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rowCount", "I"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "columnCount", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableAccessibleContext;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addHeader", "(Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableCellElementInfo;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleCaption", "()Ljavax/accessibility/Accessible;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleCaption", "(Ljavax/accessibility/Accessible;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleSummary", "()Ljavax/accessibility/Accessible;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleSummary", "(Ljavax/accessibility/Accessible;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRowCount", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleColumnCount", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRowExtentAt", "(II)I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleColumnExtentAt", "(II)I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRowHeader", "()Ljavax/accessibility/AccessibleTable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleRowHeader", "(Ljavax/accessibility/AccessibleTable;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleColumnHeader", "()Ljavax/accessibility/AccessibleTable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleColumnHeader", "(Ljavax/accessibility/AccessibleTable;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRowDescription", "(I)Ljavax/accessibility/Accessible;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleRowDescription", "(ILjavax/accessibility/Accessible;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleColumnDescription", "(I)Ljavax/accessibility/Accessible;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleColumnDescription", "(ILjavax/accessibility/Accessible;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccessibleSelected", "(II)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccessibleRowSelected", "(I)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccessibleColumnSelected", "(I)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedAccessibleRows", "()[I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedAccessibleColumns", "()[I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementInfoAt", "(II)Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableCellElementInfo;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleAt", "(II)Ljavax/accessibility/Accessible;"));
				}

				[JniSignatureAttribute("Ljava/util/Hashtable;", "private")]
				public Dova.JDK.java.util.Hashtable headers_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("I", "private")]
				public int rowCount_Property
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

				[JniSignatureAttribute("I", "private")]
				public int columnCount_Property
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
				public AccessibleHeadersTable(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableAccessibleContext;)V", "protected")]
				public AccessibleHeadersTable(Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo.TableAccessibleContext arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableAccessibleContext$AccessibleHeadersTable;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableCellElementInfo;I)V", "public")]
				public void addHeader(Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo.TableCellElementInfo arg0, int arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				}

				[JniSignatureAttribute("()Ljavax/accessibility/Accessible;", "public")]
				public Dova.JDK.javax.accessibility.Accessible getAccessibleCaption()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
				}

				[JniSignatureAttribute("(Ljavax/accessibility/Accessible;)V", "public")]
				public void setAccessibleCaption(Dova.JDK.javax.accessibility.Accessible arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				}

				[JniSignatureAttribute("()Ljavax/accessibility/Accessible;", "public")]
				public Dova.JDK.javax.accessibility.Accessible getAccessibleSummary()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
				}

				[JniSignatureAttribute("(Ljavax/accessibility/Accessible;)V", "public")]
				public void setAccessibleSummary(Dova.JDK.javax.accessibility.Accessible arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				}

				[JniSignatureAttribute("()I", "public")]
				public int getAccessibleRowCount()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
					return ret;
				}

				[JniSignatureAttribute("()I", "public")]
				public int getAccessibleColumnCount()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
					return ret;
				}

				[JniSignatureAttribute("(II)I", "public")]
				public int getAccessibleRowExtentAt(int arg0, int arg1)
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
					return ret;
				}

				[JniSignatureAttribute("(II)I", "public")]
				public int getAccessibleColumnExtentAt(int arg0, int arg1)
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
					return ret;
				}

				[JniSignatureAttribute("()Ljavax/accessibility/AccessibleTable;", "public")]
				public Dova.JDK.javax.accessibility.AccessibleTable getAccessibleRowHeader()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleTable>(ret);
				}

				[JniSignatureAttribute("(Ljavax/accessibility/AccessibleTable;)V", "public")]
				public void setAccessibleRowHeader(Dova.JDK.javax.accessibility.AccessibleTable arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
				}

				[JniSignatureAttribute("()Ljavax/accessibility/AccessibleTable;", "public")]
				public Dova.JDK.javax.accessibility.AccessibleTable getAccessibleColumnHeader()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleTable>(ret);
				}

				[JniSignatureAttribute("(Ljavax/accessibility/AccessibleTable;)V", "public")]
				public void setAccessibleColumnHeader(Dova.JDK.javax.accessibility.AccessibleTable arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
				}

				[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public")]
				public Dova.JDK.javax.accessibility.Accessible getAccessibleRowDescription(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
				}

				[JniSignatureAttribute("(ILjavax/accessibility/Accessible;)V", "public")]
				public void setAccessibleRowDescription(int arg0, Dova.JDK.javax.accessibility.Accessible arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
				}

				[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public")]
				public Dova.JDK.javax.accessibility.Accessible getAccessibleColumnDescription(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
				}

				[JniSignatureAttribute("(ILjavax/accessibility/Accessible;)V", "public")]
				public void setAccessibleColumnDescription(int arg0, Dova.JDK.javax.accessibility.Accessible arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
				}

				[JniSignatureAttribute("(II)Z", "public")]
				public bool isAccessibleSelected(int arg0, int arg1)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
					return ret;
				}

				[JniSignatureAttribute("(I)Z", "public")]
				public bool isAccessibleRowSelected(int arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
					return ret;
				}

				[JniSignatureAttribute("(I)Z", "public")]
				public bool isAccessibleColumnSelected(int arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
					return ret;
				}

				[JniSignatureAttribute("()[I", "public")]
				public JavaArray<int> getSelectedAccessibleRows()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
					return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
				}

				[JniSignatureAttribute("()[I", "public")]
				public JavaArray<int> getSelectedAccessibleColumns()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
					return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
				}

				[JniSignatureAttribute("(II)Ljavax/swing/text/html/AccessibleHTML$TableElementInfo$TableCellElementInfo;", "private")]
				public Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo.TableCellElementInfo getElementInfoAt(int arg0, int arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML.TableElementInfo.TableCellElementInfo>(ret);
				}

				[JniSignatureAttribute("(II)Ljavax/accessibility/Accessible;", "public")]
				public Dova.JDK.javax.accessibility.Accessible getAccessibleAt(int arg0, int arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
				}
			}
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$RootHTMLAccessibleContext;", "private")]
	public partial class RootHTMLAccessibleContext
		: Dova.JDK.javax.swing.text.html.AccessibleHTML.HTMLAccessibleContext
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RootHTMLAccessibleContext()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/AccessibleHTML$RootHTMLAccessibleContext;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/text/html/AccessibleHTML;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/html/AccessibleHTML;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleDescription", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRole", "()Ljavax/accessibility/AccessibleRole;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleName", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML;", "final")]
		public Dova.JDK.javax.swing.text.html.AccessibleHTML this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RootHTMLAccessibleContext(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V", "public")]
		public RootHTMLAccessibleContext(Dova.JDK.javax.swing.text.html.AccessibleHTML arg0, Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/AccessibleHTML$RootHTMLAccessibleContext;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getAccessibleDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleRole;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleRole getAccessibleRole()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleRole>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getAccessibleName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$HTMLAccessibleContext;", "protected abstract")]
	public partial class HTMLAccessibleContext
		: Dova.JDK.javax.accessibility.AccessibleContext
		, Dova.JDK.javax.accessibility.Accessible
		, Dova.JDK.javax.accessibility.AccessibleComponent
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HTMLAccessibleContext()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/AccessibleHTML$HTMLAccessibleContext;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "elementInfo", "Ljavax/swing/text/html/AccessibleHTML$ElementInfo;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/text/html/AccessibleHTML;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/html/AccessibleHTML;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/awt/Point;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "()Ljava/awt/Rectangle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocation", "()Ljava/awt/Point;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSize", "()Ljava/awt/Dimension;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocale", "()Ljava/util/Locale;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSize", "(Ljava/awt/Dimension;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnabled", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocation", "(Ljava/awt/Point;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setForeground", "(Ljava/awt/Color;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFont", "(Ljava/awt/Font;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEnabled", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setVisible", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addFocusListener", "(Ljava/awt/event/FocusListener;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFont", "()Ljava/awt/Font;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestFocus", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementInfoAt", "(Ljavax/swing/text/html/AccessibleHTML$ElementInfo;Ljava/awt/Point;)Ljavax/swing/text/html/AccessibleHTML$ElementInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVisible", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isShowing", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCursor", "(Ljava/awt/Cursor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getForeground", "()Ljava/awt/Color;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFontMetrics", "(Ljava/awt/Font;)Ljava/awt/FontMetrics;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBackground", "()Ljava/awt/Color;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBackground", "(Ljava/awt/Color;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBounds", "(Ljava/awt/Rectangle;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleChildrenCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleChild", "(I)Ljavax/accessibility/Accessible;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleComponent", "()Ljavax/accessibility/AccessibleComponent;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleAt", "(Ljava/awt/Point;)Ljavax/accessibility/Accessible;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationOnScreen", "()Ljava/awt/Point;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFocusTraversable", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleIndexInParent", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCursor", "()Ljava/awt/Cursor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeFocusListener", "(Ljava/awt/event/FocusListener;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleStateSet", "()Ljavax/accessibility/AccessibleStateSet;"));
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML$ElementInfo;", "protected")]
		public Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo elementInfo_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/AccessibleHTML;", "final")]
		public Dova.JDK.javax.swing.text.html.AccessibleHTML this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public HTMLAccessibleContext(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML;Ljavax/swing/text/html/AccessibleHTML$ElementInfo;)V", "public")]
		public HTMLAccessibleContext(Dova.JDK.javax.swing.text.html.AccessibleHTML arg0, Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/AccessibleHTML$HTMLAccessibleContext;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Point;)Z", "public")]
		public bool contains(Dova.JDK.java.awt.Point arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/awt/Rectangle;", "public")]
		public Dova.JDK.java.awt.Rectangle getBounds()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}

		[JniSignatureAttribute("()Ljava/awt/Point;", "public")]
		public Dova.JDK.java.awt.Point getLocation()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
		}

		[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension getSize()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Locale;", "public")]
		public Dova.JDK.java.util.Locale getLocale()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Dimension;)V", "public")]
		public void setSize(Dova.JDK.java.awt.Dimension arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isEnabled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Point;)V", "public")]
		public void setLocation(Dova.JDK.java.awt.Point arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Color;)V", "public")]
		public void setForeground(Dova.JDK.java.awt.Color arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Font;)V", "public")]
		public void setFont(Dova.JDK.java.awt.Font arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("(Z)V", "public")]
		public void setEnabled(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}

		[JniSignatureAttribute("(Z)V", "public")]
		public void setVisible(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/FocusListener;)V", "public")]
		public void addFocusListener(Dova.JDK.java.awt.@event.FocusListener arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		}

		[JniSignatureAttribute("()Ljava/awt/Font;", "public")]
		public Dova.JDK.java.awt.Font getFont()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void requestFocus()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/AccessibleHTML$ElementInfo;Ljava/awt/Point;)Ljavax/swing/text/html/AccessibleHTML$ElementInfo;", "private")]
		public Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo getElementInfoAt(Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo arg0, Dova.JDK.java.awt.Point arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.AccessibleHTML.ElementInfo>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isVisible()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isShowing()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Cursor;)V", "public")]
		public void setCursor(Dova.JDK.java.awt.Cursor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		}

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleContext getAccessibleContext()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
		}

		[JniSignatureAttribute("()Ljava/awt/Color;", "public")]
		public Dova.JDK.java.awt.Color getForeground()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Font;)Ljava/awt/FontMetrics;", "public")]
		public Dova.JDK.java.awt.FontMetrics getFontMetrics(Dova.JDK.java.awt.Font arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.FontMetrics>(ret);
		}

		[JniSignatureAttribute("()Ljava/awt/Color;", "public")]
		public Dova.JDK.java.awt.Color getBackground()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Color;)V", "public")]
		public void setBackground(Dova.JDK.java.awt.Color arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Rectangle;)V", "public")]
		public void setBounds(Dova.JDK.java.awt.Rectangle arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getAccessibleChildrenCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25]);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public")]
		public Dova.JDK.javax.accessibility.Accessible getAccessibleChild(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
		}

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleComponent;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleComponent getAccessibleComponent()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleComponent>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Point;)Ljavax/accessibility/Accessible;", "public")]
		public Dova.JDK.javax.accessibility.Accessible getAccessibleAt(Dova.JDK.java.awt.Point arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
		}

		[JniSignatureAttribute("()Ljava/awt/Point;", "public")]
		public Dova.JDK.java.awt.Point getLocationOnScreen()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isFocusTraversable()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[30]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getAccessibleIndexInParent()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[31]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/awt/Cursor;", "public")]
		public Dova.JDK.java.awt.Cursor getCursor()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/event/FocusListener;)V", "public")]
		public void removeFocusListener(Dova.JDK.java.awt.@event.FocusListener arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		}

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleStateSet;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleStateSet getAccessibleStateSet()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleStateSet>(ret);
		}
	}
}
