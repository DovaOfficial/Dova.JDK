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

namespace Dova.JDK.sun.awt.image;

[JniSignatureAttribute("Lsun/awt/image/ImageWatched;", "public abstract")]
public partial class ImageWatched
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ImageWatched()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/ImageWatched;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "endlink", "Lsun/awt/image/ImageWatched$Link;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "watcherList", "Lsun/awt/image/ImageWatched$Link;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isWatcherListEmpty", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "notifyWatcherListEmpty", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isWatcher", "(Ljava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeWatcher", "(Ljava/awt/image/ImageObserver;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newInfo", "(Ljava/awt/Image;IIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addWatcher", "(Ljava/awt/image/ImageObserver;)V"));
	}

	[JniSignatureAttribute("Lsun/awt/image/ImageWatched$Link;", "public static")]
	public static Dova.JDK.sun.awt.image.ImageWatched.Link endlink_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.ImageWatched.Link>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/image/ImageWatched$Link;", "public")]
	public Dova.JDK.sun.awt.image.ImageWatched.Link watcherList_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.ImageWatched.Link>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ImageWatched(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ImageWatched() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/image/ImageWatched;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Z", "public")]
	public bool isWatcherListEmpty()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()V", "protected abstract")]
	public void notifyWatcherListEmpty()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Ljava/awt/image/ImageObserver;)Z", "public synchronized")]
	public bool isWatcher(Dova.JDK.java.awt.image.ImageObserver arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/ImageObserver;)V", "public")]
	public void removeWatcher(Dova.JDK.java.awt.image.ImageObserver arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Image;IIIII)V", "public")]
	public void newInfo(Dova.JDK.java.awt.Image arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljava/awt/image/ImageObserver;)V", "public synchronized")]
	public void addWatcher(Dova.JDK.java.awt.image.ImageObserver arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("Lsun/awt/image/ImageWatched$Link;", "public static")]
	public partial class Link
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Link()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/ImageWatched$Link;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isWatcher", "(Ljava/awt/image/ImageObserver;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeWatcher", "(Ljava/awt/image/ImageObserver;)Lsun/awt/image/ImageWatched$Link;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newInfo", "(Ljava/awt/Image;IIIII)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Link(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Link() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/image/ImageWatched$Link;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/image/ImageObserver;)Z", "public")]
		public bool isWatcher(Dova.JDK.java.awt.image.ImageObserver arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/image/ImageObserver;)Lsun/awt/image/ImageWatched$Link;", "public")]
		public Dova.JDK.sun.awt.image.ImageWatched.Link removeWatcher(Dova.JDK.java.awt.image.ImageObserver arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.ImageWatched.Link>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Image;IIIII)Z", "public")]
		public bool newInfo(Dova.JDK.java.awt.Image arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/image/ImageWatched$WeakLink;", "public static")]
	public partial class WeakLink
		: Dova.JDK.sun.awt.image.ImageWatched.Link
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WeakLink()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/ImageWatched$WeakLink;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "myref", "Lsun/awt/image/ImageWatched$AccWeakReference;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "next", "Lsun/awt/image/ImageWatched$Link;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/image/ImageObserver;Lsun/awt/image/ImageWatched$Link;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "update", "(Ljava/awt/image/ImageObserver;Ljava/security/AccessControlContext;Ljava/awt/Image;IIIII)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isWatcher", "(Ljava/awt/image/ImageObserver;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeWatcher", "(Ljava/awt/image/ImageObserver;)Lsun/awt/image/ImageWatched$Link;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newInfo", "(Ljava/awt/Image;IIIII)Z"));
		}

		[JniSignatureAttribute("Lsun/awt/image/ImageWatched$AccWeakReference;", "private final")]
		public Dova.JDK.sun.awt.image.ImageWatched.AccWeakReference myref_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.ImageWatched.AccWeakReference>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/awt/image/ImageWatched$Link;", "private")]
		public Dova.JDK.sun.awt.image.ImageWatched.Link next_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.ImageWatched.Link>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WeakLink(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/awt/image/ImageObserver;Lsun/awt/image/ImageWatched$Link;)V", "public")]
		public WeakLink(Dova.JDK.java.awt.image.ImageObserver arg0, Dova.JDK.sun.awt.image.ImageWatched.Link arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/image/ImageWatched$WeakLink;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/image/ImageObserver;Ljava/security/AccessControlContext;Ljava/awt/Image;IIIII)Z", "private static")]
		public static bool update(Dova.JDK.java.awt.image.ImageObserver arg0, Dova.JDK.java.security.AccessControlContext arg1, Dova.JDK.java.awt.Image arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/image/ImageObserver;)Z", "public")]
		public bool isWatcher(Dova.JDK.java.awt.image.ImageObserver arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/image/ImageObserver;)Lsun/awt/image/ImageWatched$Link;", "public")]
		public Dova.JDK.sun.awt.image.ImageWatched.Link removeWatcher(Dova.JDK.java.awt.image.ImageObserver arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.ImageWatched.Link>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Image;IIIII)Z", "public")]
		public bool newInfo(Dova.JDK.java.awt.Image arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/image/ImageWatched$AccWeakReference;", "static")]
	public partial class AccWeakReference
		: Dova.JDK.java.lang.@ref.WeakReference
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AccWeakReference()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/ImageWatched$AccWeakReference;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "acc", "Ljava/security/AccessControlContext;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;)V"));
		}

		[JniSignatureAttribute("Ljava/security/AccessControlContext;", "private final")]
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AccWeakReference(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "")]
		public AccWeakReference(Dova.JDK.java.lang.Object arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/image/ImageWatched$AccWeakReference;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
