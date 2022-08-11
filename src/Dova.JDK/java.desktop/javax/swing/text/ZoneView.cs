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

namespace Dova.JDK.javax.swing.text;

[JniSignatureAttribute("Ljavax/swing/text/ZoneView;", "public")]
public partial class ZoneView
	: Dova.JDK.javax.swing.text.BoxView
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ZoneView()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/ZoneView;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxZoneSize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxZonesLoaded", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "loadedZones", "Ljava/util/Vector;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/Element;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertUpdate", "(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeUpdate", "(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unloadOldZones", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaxZonesLoaded", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unloadZone", "(Ljavax/swing/text/View;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createZone", "(II)Ljavax/swing/text/View;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleInsert", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "splitZone", "(III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDesiredZoneEnd", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaximumZoneSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMaximumZoneSize", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMaxZonesLoaded", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "zoneWasLoaded", "(Ljavax/swing/text/View;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isZoneLoaded", "(Ljavax/swing/text/View;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getViewIndexAtPosition", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadChildren", "(Ljavax/swing/text/ViewFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleRemove", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateChildren", "(Ljavax/swing/event/DocumentEvent$ElementChange;Ljavax/swing/event/DocumentEvent;Ljavax/swing/text/ViewFactory;)Z"));
	}

	[JniSignatureAttribute("I", "")]
	public int maxZoneSize_Property
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

	[JniSignatureAttribute("I", "")]
	public int maxZonesLoaded_Property
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

	[JniSignatureAttribute("Ljava/util/Vector;", "")]
	public Dova.JDK.java.util.Vector loadedZones_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ZoneView(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;I)V", "public")]
	public ZoneView(Dova.JDK.javax.swing.text.Element arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/text/ZoneView;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V", "public")]
	public void insertUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.javax.swing.text.ViewFactory arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V", "public")]
	public void removeUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.javax.swing.text.ViewFactory arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()V", "")]
	public void unloadOldZones()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMaxZonesLoaded()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;)V", "protected")]
	public void unloadZone(Dova.JDK.javax.swing.text.View arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(II)Ljavax/swing/text/View;", "protected")]
	public Dova.JDK.javax.swing.text.View createZone(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
	}

	[JniSignatureAttribute("(II)V", "")]
	public void handleInsert(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(III)V", "")]
	public void splitZone(int arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(I)I", "")]
	public int getDesiredZoneEnd(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMaximumZoneSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setMaximumZoneSize(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setMaxZonesLoaded(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;)V", "protected")]
	public void zoneWasLoaded(Dova.JDK.javax.swing.text.View arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;)Z", "protected")]
	public bool isZoneLoaded(Dova.JDK.javax.swing.text.View arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "protected")]
	public int getViewIndexAtPosition(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/ViewFactory;)V", "protected")]
	public void loadChildren(Dova.JDK.javax.swing.text.ViewFactory arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(II)V", "")]
	public void handleRemove(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent$ElementChange;Ljavax/swing/event/DocumentEvent;Ljavax/swing/text/ViewFactory;)Z", "protected")]
	public bool updateChildren(Dova.JDK.javax.swing.@event.DocumentEvent.ElementChange arg0, Dova.JDK.javax.swing.@event.DocumentEvent arg1, Dova.JDK.javax.swing.text.ViewFactory arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("Ljavax/swing/text/ZoneView$Zone;", "")]
	public partial class Zone
		: Dova.JDK.javax.swing.text.AsyncBoxView
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Zone()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/ZoneView$Zone;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "start", "Ljavax/swing/text/Position;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "end", "Ljavax/swing/text/Position;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/text/ZoneView;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/ZoneView;Ljavax/swing/text/Element;Ljavax/swing/text/Position;Ljavax/swing/text/Position;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "()Ljavax/swing/text/AttributeSet;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLoaded", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unload", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flushRequirementChanges", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartOffset", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viewToModel", "(FFLjava/awt/Shape;[Ljavax/swing/text/Position$Bias;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modelToView", "(ILjava/awt/Shape;Ljavax/swing/text/Position$Bias;)Ljava/awt/Shape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertUpdate", "(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeUpdate", "(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changedUpdate", "(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadChildren", "(Ljavax/swing/text/ViewFactory;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndOffset", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getViewIndex", "(ILjavax/swing/text/Position$Bias;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateChildren", "(Ljavax/swing/event/DocumentEvent$ElementChange;Ljavax/swing/event/DocumentEvent;Ljavax/swing/text/ViewFactory;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;Ljava/awt/Shape;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/text/Position;", "private")]
		public Dova.JDK.javax.swing.text.Position start_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Position>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/Position;", "private")]
		public Dova.JDK.javax.swing.text.Position end_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Position>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/ZoneView;", "final")]
		public Dova.JDK.javax.swing.text.ZoneView this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.ZoneView>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Zone(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/ZoneView;Ljavax/swing/text/Element;Ljavax/swing/text/Position;Ljavax/swing/text/Position;)V", "public")]
		public Zone(Dova.JDK.javax.swing.text.ZoneView arg0, Dova.JDK.javax.swing.text.Element arg1, Dova.JDK.javax.swing.text.Position arg2, Dova.JDK.javax.swing.text.Position arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/ZoneView$Zone;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void load()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Ljavax/swing/text/AttributeSet;", "public")]
		public Dova.JDK.javax.swing.text.AttributeSet getAttributes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isLoaded()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()V", "public")]
		public void unload()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("()V", "protected")]
		public void flushRequirementChanges()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getStartOffset()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("(FFLjava/awt/Shape;[Ljavax/swing/text/Position$Bias;)I", "public")]
		public int viewToModel(float arg0, float arg1, Dova.JDK.java.awt.Shape arg2, JavaArray<Dova.JDK.javax.swing.text.Position.Bias> arg3)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(ILjava/awt/Shape;Ljavax/swing/text/Position$Bias;)Ljava/awt/Shape;", "public")]
		public Dova.JDK.java.awt.Shape modelToView(int arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.javax.swing.text.Position.Bias arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V", "public")]
		public void insertUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.javax.swing.text.ViewFactory arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V", "public")]
		public void removeUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.javax.swing.text.ViewFactory arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V", "public")]
		public void changedUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.javax.swing.text.ViewFactory arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/ViewFactory;)V", "protected")]
		public void loadChildren(Dova.JDK.javax.swing.text.ViewFactory arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getEndOffset()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12]);
			return ret;
		}

		[JniSignatureAttribute("(ILjavax/swing/text/Position$Bias;)I", "public")]
		public int getViewIndex(int arg0, Dova.JDK.javax.swing.text.Position.Bias arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent$ElementChange;Ljavax/swing/event/DocumentEvent;Ljavax/swing/text/ViewFactory;)Z", "protected")]
		public bool updateChildren(Dova.JDK.javax.swing.@event.DocumentEvent.ElementChange arg0, Dova.JDK.javax.swing.@event.DocumentEvent arg1, Dova.JDK.javax.swing.text.ViewFactory arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/awt/Shape;)V", "public")]
		public void paint(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.awt.Shape arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		}
	}
}
