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

namespace Dova.JDK.java.awt;

[JniSignatureAttribute("Ljava/awt/ModalEventFilter;", "abstract")]
public partial class ModalEventFilter
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.awt.EventFilter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ModalEventFilter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/ModalEventFilter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modalDialog", "Ljava/awt/Dialog;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "disabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Dialog;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Ljava/awt/ModalEventFilter;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createFilterForDialog", "(Ljava/awt/Dialog;)Ljava/awt/ModalEventFilter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "disable", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptWindow", "(Ljava/awt/Window;)Ljava/awt/EventFilter$FilterAction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModalDialog", "()Ljava/awt/Dialog;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptEvent", "(Ljava/awt/AWTEvent;)Ljava/awt/EventFilter$FilterAction;"));
	}

	[JniSignatureAttribute("Ljava/awt/Dialog;", "protected")]
	public Dova.JDK.java.awt.Dialog modalDialog_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dialog>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool disabled_Property
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
	public ModalEventFilter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Dialog;)V", "protected")]
	public ModalEventFilter(Dova.JDK.java.awt.Dialog arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/ModalEventFilter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/ModalEventFilter;)I", "")]
	public int compareTo(Dova.JDK.java.awt.ModalEventFilter arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Dialog;)Ljava/awt/ModalEventFilter;", "static")]
	public static Dova.JDK.java.awt.ModalEventFilter createFilterForDialog(Dova.JDK.java.awt.Dialog arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.ModalEventFilter>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void disable()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(Ljava/awt/Window;)Ljava/awt/EventFilter$FilterAction;", "protected abstract")]
	public Dova.JDK.java.awt.EventFilter.FilterAction acceptWindow(Dova.JDK.java.awt.Window arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.EventFilter.FilterAction>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Dialog;", "")]
	public Dova.JDK.java.awt.Dialog getModalDialog()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dialog>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;)Ljava/awt/EventFilter$FilterAction;", "public")]
	public Dova.JDK.java.awt.EventFilter.FilterAction acceptEvent(Dova.JDK.java.awt.AWTEvent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.EventFilter.FilterAction>(ret);
	}

	[JniSignatureAttribute("Ljava/awt/ModalEventFilter$DocumentModalEventFilter;", "private static")]
	public partial class DocumentModalEventFilter
		: Dova.JDK.java.awt.ModalEventFilter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DocumentModalEventFilter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/ModalEventFilter$DocumentModalEventFilter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "documentRoot", "Ljava/awt/Window;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Dialog;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptWindow", "(Ljava/awt/Window;)Ljava/awt/EventFilter$FilterAction;"));
		}

		[JniSignatureAttribute("Ljava/awt/Window;", "private")]
		public Dova.JDK.java.awt.Window documentRoot_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Window>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DocumentModalEventFilter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/awt/Dialog;)V", "")]
		public DocumentModalEventFilter(Dova.JDK.java.awt.Dialog arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/ModalEventFilter$DocumentModalEventFilter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Window;)Ljava/awt/EventFilter$FilterAction;", "protected")]
		public Dova.JDK.java.awt.EventFilter.FilterAction acceptWindow(Dova.JDK.java.awt.Window arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.EventFilter.FilterAction>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/awt/ModalEventFilter$ApplicationModalEventFilter;", "private static")]
	public partial class ApplicationModalEventFilter
		: Dova.JDK.java.awt.ModalEventFilter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ApplicationModalEventFilter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/ModalEventFilter$ApplicationModalEventFilter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "appContext", "Lsun/awt/AppContext;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Dialog;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptWindow", "(Ljava/awt/Window;)Ljava/awt/EventFilter$FilterAction;"));
		}

		[JniSignatureAttribute("Lsun/awt/AppContext;", "private")]
		public Dova.JDK.sun.awt.AppContext appContext_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AppContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ApplicationModalEventFilter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/awt/Dialog;)V", "")]
		public ApplicationModalEventFilter(Dova.JDK.java.awt.Dialog arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/ModalEventFilter$ApplicationModalEventFilter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Window;)Ljava/awt/EventFilter$FilterAction;", "protected")]
		public Dova.JDK.java.awt.EventFilter.FilterAction acceptWindow(Dova.JDK.java.awt.Window arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.EventFilter.FilterAction>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/awt/ModalEventFilter$ToolkitModalEventFilter;", "private static")]
	public partial class ToolkitModalEventFilter
		: Dova.JDK.java.awt.ModalEventFilter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ToolkitModalEventFilter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/ModalEventFilter$ToolkitModalEventFilter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "appContext", "Lsun/awt/AppContext;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Dialog;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptWindow", "(Ljava/awt/Window;)Ljava/awt/EventFilter$FilterAction;"));
		}

		[JniSignatureAttribute("Lsun/awt/AppContext;", "private")]
		public Dova.JDK.sun.awt.AppContext appContext_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AppContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ToolkitModalEventFilter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/awt/Dialog;)V", "")]
		public ToolkitModalEventFilter(Dova.JDK.java.awt.Dialog arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/ModalEventFilter$ToolkitModalEventFilter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Window;)Ljava/awt/EventFilter$FilterAction;", "protected")]
		public Dova.JDK.java.awt.EventFilter.FilterAction acceptWindow(Dova.JDK.java.awt.Window arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.EventFilter.FilterAction>(ret);
		}
	}
}
