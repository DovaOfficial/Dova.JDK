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

namespace Dova.JDK.java.nio.file;

[JniSignatureAttribute("Ljava/nio/file/FileTreeWalker;", "")]
public partial class FileTreeWalker
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Closeable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FileTreeWalker()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/file/FileTreeWalker;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "followLinks", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "linkOptions", "[Ljava/nio/file/LinkOption;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxDepth", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stack", "Ljava/util/ArrayDeque;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closed", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Collection;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next", "()Ljava/nio/file/FileTreeWalker$Event;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isOpen", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "(Ljava/nio/file/Path;Z)Ljava/nio/file/attribute/BasicFileAttributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "walk", "(Ljava/nio/file/Path;)Ljava/nio/file/FileTreeWalker$Event;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pop", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Ljava/nio/file/Path;ZZ)Ljava/nio/file/FileTreeWalker$Event;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skipRemainingSiblings", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wouldLoop", "(Ljava/nio/file/Path;Ljava/lang/Object;)Z"));
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool followLinks_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("[Ljava/nio/file/LinkOption;", "private final")]
	public JavaArray<Dova.JDK.java.nio.file.LinkOption> linkOptions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.nio.file.LinkOption>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int maxDepth_Property
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

	[JniSignatureAttribute("Ljava/util/ArrayDeque;", "private final")]
	public Dova.JDK.java.util.ArrayDeque stack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayDeque>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool closed_Property
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

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FileTreeWalker(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/Collection;I)V", "")]
	public FileTreeWalker(Dova.JDK.java.util.Collection arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/nio/file/FileTreeWalker;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/nio/file/FileTreeWalker$Event;", "")]
	public Dova.JDK.java.nio.file.FileTreeWalker.Event next()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileTreeWalker.Event>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isOpen()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Z)Ljava/nio/file/attribute/BasicFileAttributes;", "private")]
	public Dova.JDK.java.nio.file.attribute.BasicFileAttributes getAttributes(Dova.JDK.java.nio.file.Path arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.BasicFileAttributes>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/nio/file/FileTreeWalker$Event;", "")]
	public Dova.JDK.java.nio.file.FileTreeWalker.Event walk(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileTreeWalker.Event>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void pop()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;ZZ)Ljava/nio/file/FileTreeWalker$Event;", "private")]
	public Dova.JDK.java.nio.file.FileTreeWalker.Event visit(Dova.JDK.java.nio.file.Path arg0, bool arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileTreeWalker.Event>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void skipRemainingSiblings()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/Object;)Z", "private")]
	public bool wouldLoop(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("Ljava/nio/file/FileTreeWalker$DirectoryNode;", "private static")]
	public partial class DirectoryNode
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DirectoryNode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/file/FileTreeWalker$DirectoryNode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dir", "Ljava/nio/file/Path;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stream", "Ljava/nio/file/DirectoryStream;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "iterator", "Ljava/util/Iterator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "skipped", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/file/Path;Ljava/lang/Object;Ljava/nio/file/DirectoryStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stream", "()Ljava/nio/file/DirectoryStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "directory", "()Ljava/nio/file/Path;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "key", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skip", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skipped", "()Z"));
		}

		[JniSignatureAttribute("Ljava/nio/file/Path;", "private final")]
		public Dova.JDK.java.nio.file.Path dir_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
		public Dova.JDK.java.lang.Object key_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/file/DirectoryStream;", "private final")]
		public Dova.JDK.java.nio.file.DirectoryStream stream_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.DirectoryStream>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Iterator;", "private final")]
		public Dova.JDK.java.util.Iterator iterator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool skipped_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DirectoryNode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/Object;Ljava/nio/file/DirectoryStream;)V", "")]
		public DirectoryNode(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.nio.file.DirectoryStream arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/nio/file/FileTreeWalker$DirectoryNode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/Iterator;", "")]
		public Dova.JDK.java.util.Iterator iterator()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
		}

		[JniSignatureAttribute("()Ljava/nio/file/DirectoryStream;", "")]
		public Dova.JDK.java.nio.file.DirectoryStream stream()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.DirectoryStream>(ret);
		}

		[JniSignatureAttribute("()Ljava/nio/file/Path;", "")]
		public Dova.JDK.java.nio.file.Path directory()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "")]
		public Dova.JDK.java.lang.Object key()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()V", "")]
		public void skip()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool skipped()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/nio/file/FileTreeWalker$Event;", "static")]
	public partial class Event
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Event()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/file/FileTreeWalker$Event;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Ljava/nio/file/FileTreeWalker$EventType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "file", "Ljava/nio/file/Path;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attrs", "Ljava/nio/file/attribute/BasicFileAttributes;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ioe", "Ljava/io/IOException;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/file/FileTreeWalker$EventType;Ljava/nio/file/Path;Ljava/io/IOException;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/file/FileTreeWalker$EventType;Ljava/nio/file/Path;Ljava/nio/file/attribute/BasicFileAttributes;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/file/FileTreeWalker$EventType;Ljava/nio/file/Path;Ljava/nio/file/attribute/BasicFileAttributes;Ljava/io/IOException;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "type", "()Ljava/nio/file/FileTreeWalker$EventType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "file", "()Ljava/nio/file/Path;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attributes", "()Ljava/nio/file/attribute/BasicFileAttributes;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ioeException", "()Ljava/io/IOException;"));
		}

		[JniSignatureAttribute("Ljava/nio/file/FileTreeWalker$EventType;", "private final")]
		public Dova.JDK.java.nio.file.FileTreeWalker.EventType type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileTreeWalker.EventType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/file/Path;", "private final")]
		public Dova.JDK.java.nio.file.Path file_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/file/attribute/BasicFileAttributes;", "private final")]
		public Dova.JDK.java.nio.file.attribute.BasicFileAttributes attrs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.BasicFileAttributes>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/io/IOException;", "private final")]
		public Dova.JDK.java.io.IOException ioe_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.IOException>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Event(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/nio/file/FileTreeWalker$EventType;Ljava/nio/file/Path;Ljava/io/IOException;)V", "")]
		public Event(Dova.JDK.java.nio.file.FileTreeWalker.EventType arg0, Dova.JDK.java.nio.file.Path arg1, Dova.JDK.java.io.IOException arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljava/nio/file/FileTreeWalker$EventType;Ljava/nio/file/Path;Ljava/nio/file/attribute/BasicFileAttributes;)V", "")]
		public Event(Dova.JDK.java.nio.file.FileTreeWalker.EventType arg0, Dova.JDK.java.nio.file.Path arg1, Dova.JDK.java.nio.file.attribute.BasicFileAttributes arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljava/nio/file/FileTreeWalker$EventType;Ljava/nio/file/Path;Ljava/nio/file/attribute/BasicFileAttributes;Ljava/io/IOException;)V", "private")]
		public Event(Dova.JDK.java.nio.file.FileTreeWalker.EventType arg0, Dova.JDK.java.nio.file.Path arg1, Dova.JDK.java.nio.file.attribute.BasicFileAttributes arg2, Dova.JDK.java.io.IOException arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/nio/file/FileTreeWalker$Event;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/nio/file/FileTreeWalker$EventType;", "")]
		public Dova.JDK.java.nio.file.FileTreeWalker.EventType type()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileTreeWalker.EventType>(ret);
		}

		[JniSignatureAttribute("()Ljava/nio/file/Path;", "")]
		public Dova.JDK.java.nio.file.Path file()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
		}

		[JniSignatureAttribute("()Ljava/nio/file/attribute/BasicFileAttributes;", "")]
		public Dova.JDK.java.nio.file.attribute.BasicFileAttributes attributes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.BasicFileAttributes>(ret);
		}

		[JniSignatureAttribute("()Ljava/io/IOException;", "")]
		public Dova.JDK.java.io.IOException ioeException()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.IOException>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/nio/file/FileTreeWalker$EventType;", "static final")]
	public partial class EventType
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EventType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/file/FileTreeWalker$EventType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "START_DIRECTORY", "Ljava/nio/file/FileTreeWalker$EventType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "END_DIRECTORY", "Ljava/nio/file/FileTreeWalker$EventType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENTRY", "Ljava/nio/file/FileTreeWalker$EventType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljava/nio/file/FileTreeWalker$EventType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljava/nio/file/FileTreeWalker$EventType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljava/nio/file/FileTreeWalker$EventType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljava/nio/file/FileTreeWalker$EventType;"));
		}

		[JniSignatureAttribute("Ljava/nio/file/FileTreeWalker$EventType;", "public static final")]
		public static Dova.JDK.java.nio.file.FileTreeWalker.EventType START_DIRECTORY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileTreeWalker.EventType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/file/FileTreeWalker$EventType;", "public static final")]
		public static Dova.JDK.java.nio.file.FileTreeWalker.EventType END_DIRECTORY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileTreeWalker.EventType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/file/FileTreeWalker$EventType;", "public static final")]
		public static Dova.JDK.java.nio.file.FileTreeWalker.EventType ENTRY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileTreeWalker.EventType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/nio/file/FileTreeWalker$EventType;", "private static final")]
		public static JavaArray<Dova.JDK.java.nio.file.FileTreeWalker.EventType> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.nio.file.FileTreeWalker.EventType>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EventType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public EventType(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/nio/file/FileTreeWalker$EventType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljava/nio/file/FileTreeWalker$EventType;", "public static")]
		public static JavaArray<Dova.JDK.java.nio.file.FileTreeWalker.EventType> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.nio.file.FileTreeWalker.EventType>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/nio/file/FileTreeWalker$EventType;", "public static")]
		public static Dova.JDK.java.nio.file.FileTreeWalker.EventType valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileTreeWalker.EventType>(ret);
		}

		[JniSignatureAttribute("()[Ljava/nio/file/FileTreeWalker$EventType;", "private static")]
		public static JavaArray<Dova.JDK.java.nio.file.FileTreeWalker.EventType> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.nio.file.FileTreeWalker.EventType>>(ret);
		}
	}
}
