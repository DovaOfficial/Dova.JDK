/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.awt.X11;

[JniSignatureAttribute("Lsun/awt/X11/WindowPropertyGetter;", "public")]
public partial class WindowPropertyGetter
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static WindowPropertyGetter()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/X11/WindowPropertyGetter;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "unsafe", "Ljdk/internal/misc/Unsafe;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "actual_type", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "actual_format", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "nitems_ptr", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "bytes_after", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "data", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "window", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "property", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "offset", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "length", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "auto_delete", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "type", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "executed", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "disposer", "Lsun/awt/X11/UnsafeXDisposerRecord;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "cacheableProperties", "Ljava/util/Set;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "WindowPropertyGetter", "(JLsun/awt/X11/XAtom;JJZJ)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "WindowPropertyGetter", "(JLsun/awt/X11/XAtom;JJZLsun/awt/X11/XAtom;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "execute", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "execute", "(Lsun/awt/X11/XErrorHandler;)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isCached", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getData", "()J"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isCachingSupported", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isCacheableProperty", "(Lsun/awt/X11/XAtom;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getActualType", "()J"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getActualFormat", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNumberOfItems", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getBytesAfter", "()J"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "readFromCache", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "cacheProperty", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDataLength", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isExecuted", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isDisposed", "()Z"));
	}

	[JniSignatureAttribute("Ljdk/internal/misc/Unsafe;", "private static")]
	public static Dova.JDK.jdk.@internal.misc.Unsafe @unsafe_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.misc.Unsafe>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("J", "private final")]
	public long actual_type_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("J", "private final")]
	public long actual_format_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("J", "private final")]
	public long nitems_ptr_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("J", "private final")]
	public long bytes_after_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("J", "private final")]
	public long data_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("J", "private final")]
	public long window_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[6], value);
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "private final")]
	public Dova.JDK.sun.awt.X11.XAtom property_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("J", "private final")]
	public long offset_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[8], value);
	}

	[JniSignatureAttribute("J", "private final")]
	public long length_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[9], value);
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool auto_delete_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[10], value);
	}

	[JniSignatureAttribute("J", "private final")]
	public long type_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[11], value);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool executed_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[12], value);
	}

	[JniSignatureAttribute("Lsun/awt/X11/UnsafeXDisposerRecord;", "")]
	public Dova.JDK.sun.awt.X11.UnsafeXDisposerRecord disposer_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.UnsafeXDisposerRecord>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Set;", "static")]
	public static Dova.JDK.java.util.Set cacheableProperties_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public WindowPropertyGetter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(JLsun/awt/X11/XAtom;JJZJ)V", "public")]
	public WindowPropertyGetter(long arg0, Dova.JDK.sun.awt.X11.XAtom arg1, long arg2, long arg3, bool arg4, long arg5) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(JLsun/awt/X11/XAtom;JJZLsun/awt/X11/XAtom;)V", "public")]
	public WindowPropertyGetter(long arg0, Dova.JDK.sun.awt.X11.XAtom arg1, long arg2, long arg3, bool arg4, Dova.JDK.sun.awt.X11.XAtom arg5) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/X11/WindowPropertyGetter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()I", "public")]
	public int execute()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XErrorHandler;)I", "public")]
	public int execute(Dova.JDK.sun.awt.X11.XErrorHandler arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isCached()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void dispose()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()J", "public")]
	public long getData()
	{
		var ret = DovaJvm.Vm.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "static")]
	public static bool isCachingSupported()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XAtom;)Z", "static")]
	public static bool isCacheableProperty(Dova.JDK.sun.awt.X11.XAtom arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getActualType()
	{
		var ret = DovaJvm.Vm.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getActualFormat()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getNumberOfItems()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getBytesAfter()
	{
		var ret = DovaJvm.Vm.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()V", "")]
	public void readFromCache()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("()V", "")]
	public void cacheProperty()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}

	[JniSignatureAttribute("()I", "")]
	public int getDataLength()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isExecuted()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isDisposed()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}
}