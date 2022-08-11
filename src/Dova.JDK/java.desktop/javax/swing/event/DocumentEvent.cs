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

namespace Dova.JDK.javax.swing.@event;

[JniSignatureAttribute("Ljavax/swing/event/DocumentEvent;", "public abstract interface")]
public partial interface DocumentEvent
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DocumentEvent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/event/DocumentEvent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLength", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Ljavax/swing/event/DocumentEvent$EventType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOffset", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChange", "(Ljavax/swing/text/Element;)Ljavax/swing/event/DocumentEvent$ElementChange;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocument", "()Ljavax/swing/text/Document;"));
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getLength()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/event/DocumentEvent$EventType;", "public abstract")]
	Dova.JDK.javax.swing.@event.DocumentEvent.EventType getType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.DocumentEvent.EventType>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getOffset()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;)Ljavax/swing/event/DocumentEvent$ElementChange;", "public abstract")]
	Dova.JDK.javax.swing.@event.DocumentEvent.ElementChange getChange(Dova.JDK.javax.swing.text.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.DocumentEvent.ElementChange>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/Document;", "public abstract")]
	Dova.JDK.javax.swing.text.Document getDocument()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Document>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/event/DocumentEvent$ElementChange;", "public abstract static interface")]
	public partial interface ElementChange
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ElementChange()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/event/DocumentEvent$ElementChange;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndex", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElement", "()Ljavax/swing/text/Element;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChildrenRemoved", "()[Ljavax/swing/text/Element;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChildrenAdded", "()[Ljavax/swing/text/Element;"));
		}

		[JniSignatureAttribute("()I", "public abstract")]
		int getIndex()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/swing/text/Element;", "public abstract")]
		Dova.JDK.javax.swing.text.Element getElement()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
		}

		[JniSignatureAttribute("()[Ljavax/swing/text/Element;", "public abstract")]
		JavaArray<Dova.JDK.javax.swing.text.Element> getChildrenRemoved()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.text.Element>>(ret);
		}

		[JniSignatureAttribute("()[Ljavax/swing/text/Element;", "public abstract")]
		JavaArray<Dova.JDK.javax.swing.text.Element> getChildrenAdded()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.text.Element>>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/event/DocumentEvent$EventType;", "public static final")]
	public partial class EventType
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EventType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/event/DocumentEvent$EventType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSERT", "Ljavax/swing/event/DocumentEvent$EventType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REMOVE", "Ljavax/swing/event/DocumentEvent$EventType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHANGE", "Ljavax/swing/event/DocumentEvent$EventType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeString", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljavax/swing/event/DocumentEvent$EventType;", "public static final")]
		public static Dova.JDK.javax.swing.@event.DocumentEvent.EventType INSERT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.DocumentEvent.EventType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/event/DocumentEvent$EventType;", "public static final")]
		public static Dova.JDK.javax.swing.@event.DocumentEvent.EventType REMOVE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.DocumentEvent.EventType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/event/DocumentEvent$EventType;", "public static final")]
		public static Dova.JDK.javax.swing.@event.DocumentEvent.EventType CHANGE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.DocumentEvent.EventType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String typeString_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EventType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
		public EventType(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/event/DocumentEvent$EventType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}
}
