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

namespace Dova.JDK.java.lang;

[JniSignatureAttribute("Ljava/lang/ProcessBuilder;", "public final")]
public partial class ProcessBuilder
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ProcessBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/ProcessBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "command", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "directory", "Ljava/io/File;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "environment", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "redirectErrorStream", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "redirects", "[Ljava/lang/ProcessBuilder$Redirect;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "start", "([Ljava/lang/ProcessBuilder$Redirect;)Ljava/lang/Process;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "start", "()Ljava/lang/Process;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "directory", "(Ljava/io/File;)Ljava/lang/ProcessBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "directory", "()Ljava/io/File;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "environment", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "environment", "([Ljava/lang/String;)Ljava/lang/ProcessBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "command", "(Ljava/util/List;)Ljava/lang/ProcessBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "command", "([Ljava/lang/String;)Ljava/lang/ProcessBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "command", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redirectError", "()Ljava/lang/ProcessBuilder$Redirect;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redirectError", "(Ljava/io/File;)Ljava/lang/ProcessBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redirectError", "(Ljava/lang/ProcessBuilder$Redirect;)Ljava/lang/ProcessBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redirectErrorStream", "(Z)Ljava/lang/ProcessBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redirectErrorStream", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redirectOutput", "(Ljava/io/File;)Ljava/lang/ProcessBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redirectOutput", "(Ljava/lang/ProcessBuilder$Redirect;)Ljava/lang/ProcessBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redirectOutput", "()Ljava/lang/ProcessBuilder$Redirect;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redirects", "()[Ljava/lang/ProcessBuilder$Redirect;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redirectInput", "(Ljava/lang/ProcessBuilder$Redirect;)Ljava/lang/ProcessBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redirectInput", "(Ljava/io/File;)Ljava/lang/ProcessBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redirectInput", "()Ljava/lang/ProcessBuilder$Redirect;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inheritIO", "()Ljava/lang/ProcessBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "startPipeline", "(Ljava/util/List;)Ljava/util/List;"));
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List command_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/File;", "private")]
	public Dova.JDK.java.io.File directory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map environment_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool redirectErrorStream_Property
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

	[JniSignatureAttribute("[Ljava/lang/ProcessBuilder$Redirect;", "private")]
	public JavaArray<Dova.JDK.java.lang.ProcessBuilder.Redirect> redirects_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.ProcessBuilder.Redirect>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
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
	public ProcessBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
	public ProcessBuilder(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("([Ljava/lang/String;)V", "public transient")]
	public ProcessBuilder(JavaArray<Dova.JDK.java.lang.String> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/ProcessBuilder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Ljava/lang/ProcessBuilder$Redirect;)Ljava/lang/Process;", "private")]
	public Dova.JDK.java.lang.Process start(JavaArray<Dova.JDK.java.lang.ProcessBuilder.Redirect> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Process>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Process;", "public")]
	public Dova.JDK.java.lang.Process start()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Process>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljava/lang/ProcessBuilder;", "public")]
	public Dova.JDK.java.lang.ProcessBuilder directory(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/File;", "public")]
	public Dova.JDK.java.io.File directory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public")]
	public Dova.JDK.java.util.Map environment()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)Ljava/lang/ProcessBuilder;", "")]
	public Dova.JDK.java.lang.ProcessBuilder environment(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/lang/ProcessBuilder;", "public")]
	public Dova.JDK.java.lang.ProcessBuilder command(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)Ljava/lang/ProcessBuilder;", "public transient")]
	public Dova.JDK.java.lang.ProcessBuilder command(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List command()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/ProcessBuilder$Redirect;", "public")]
	public Dova.JDK.java.lang.ProcessBuilder.Redirect redirectError()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder.Redirect>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljava/lang/ProcessBuilder;", "public")]
	public Dova.JDK.java.lang.ProcessBuilder redirectError(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/ProcessBuilder$Redirect;)Ljava/lang/ProcessBuilder;", "public")]
	public Dova.JDK.java.lang.ProcessBuilder redirectError(Dova.JDK.java.lang.ProcessBuilder.Redirect arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder>(ret);
	}

	[JniSignatureAttribute("(Z)Ljava/lang/ProcessBuilder;", "public")]
	public Dova.JDK.java.lang.ProcessBuilder redirectErrorStream(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool redirectErrorStream()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljava/lang/ProcessBuilder;", "public")]
	public Dova.JDK.java.lang.ProcessBuilder redirectOutput(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/ProcessBuilder$Redirect;)Ljava/lang/ProcessBuilder;", "public")]
	public Dova.JDK.java.lang.ProcessBuilder redirectOutput(Dova.JDK.java.lang.ProcessBuilder.Redirect arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/ProcessBuilder$Redirect;", "public")]
	public Dova.JDK.java.lang.ProcessBuilder.Redirect redirectOutput()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder.Redirect>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/ProcessBuilder$Redirect;", "private")]
	public JavaArray<Dova.JDK.java.lang.ProcessBuilder.Redirect> redirects()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.ProcessBuilder.Redirect>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/ProcessBuilder$Redirect;)Ljava/lang/ProcessBuilder;", "public")]
	public Dova.JDK.java.lang.ProcessBuilder redirectInput(Dova.JDK.java.lang.ProcessBuilder.Redirect arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljava/lang/ProcessBuilder;", "public")]
	public Dova.JDK.java.lang.ProcessBuilder redirectInput(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/ProcessBuilder$Redirect;", "public")]
	public Dova.JDK.java.lang.ProcessBuilder.Redirect redirectInput()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder.Redirect>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/ProcessBuilder;", "public")]
	public Dova.JDK.java.lang.ProcessBuilder inheritIO()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/util/List;", "public static")]
	public static Dova.JDK.java.util.List startPipeline(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("Ljava/lang/ProcessBuilder$Redirect;", "public abstract static")]
	public partial class Redirect
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Redirect()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/ProcessBuilder$Redirect;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NULL_FILE", "Ljava/io/File;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PIPE", "Ljava/lang/ProcessBuilder$Redirect;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INHERIT", "Ljava/lang/ProcessBuilder$Redirect;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DISCARD", "Ljava/lang/ProcessBuilder$Redirect;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "type", "()Ljava/lang/ProcessBuilder$Redirect$Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "to", "(Ljava/io/File;)Ljava/lang/ProcessBuilder$Redirect;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "from", "(Ljava/io/File;)Ljava/lang/ProcessBuilder$Redirect;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "file", "()Ljava/io/File;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "appendTo", "(Ljava/io/File;)Ljava/lang/ProcessBuilder$Redirect;"));
		}

		[JniSignatureAttribute("Ljava/io/File;", "private static final")]
		public static Dova.JDK.java.io.File NULL_FILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/ProcessBuilder$Redirect;", "public static final")]
		public static Dova.JDK.java.lang.ProcessBuilder.Redirect PIPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder.Redirect>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/ProcessBuilder$Redirect;", "public static final")]
		public static Dova.JDK.java.lang.ProcessBuilder.Redirect INHERIT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder.Redirect>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/ProcessBuilder$Redirect;", "public static final")]
		public static Dova.JDK.java.lang.ProcessBuilder.Redirect DISCARD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder.Redirect>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Redirect(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Redirect() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/ProcessBuilder$Redirect;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/ProcessBuilder$Redirect$Type;", "public abstract")]
		public Dova.JDK.java.lang.ProcessBuilder.Redirect.Type type()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder.Redirect.Type>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool append()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/io/File;)Ljava/lang/ProcessBuilder$Redirect;", "public static")]
		public static Dova.JDK.java.lang.ProcessBuilder.Redirect to(Dova.JDK.java.io.File arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder.Redirect>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;)Ljava/lang/ProcessBuilder$Redirect;", "public static")]
		public static Dova.JDK.java.lang.ProcessBuilder.Redirect from(Dova.JDK.java.io.File arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder.Redirect>(ret);
		}

		[JniSignatureAttribute("()Ljava/io/File;", "public")]
		public Dova.JDK.java.io.File file()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;)Ljava/lang/ProcessBuilder$Redirect;", "public static")]
		public static Dova.JDK.java.lang.ProcessBuilder.Redirect appendTo(Dova.JDK.java.io.File arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder.Redirect>(ret);
		}

		[JniSignatureAttribute("Ljava/lang/ProcessBuilder$Redirect$Type;", "public static final")]
		public partial class Type
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Type()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/ProcessBuilder$Redirect$Type;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PIPE", "Ljava/lang/ProcessBuilder$Redirect$Type;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INHERIT", "Ljava/lang/ProcessBuilder$Redirect$Type;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "READ", "Ljava/lang/ProcessBuilder$Redirect$Type;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WRITE", "Ljava/lang/ProcessBuilder$Redirect$Type;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "APPEND", "Ljava/lang/ProcessBuilder$Redirect$Type;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljava/lang/ProcessBuilder$Redirect$Type;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljava/lang/ProcessBuilder$Redirect$Type;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljava/lang/ProcessBuilder$Redirect$Type;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljava/lang/ProcessBuilder$Redirect$Type;"));
			}

			[JniSignatureAttribute("Ljava/lang/ProcessBuilder$Redirect$Type;", "public static final")]
			public static Dova.JDK.java.lang.ProcessBuilder.Redirect.Type PIPE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder.Redirect.Type>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/ProcessBuilder$Redirect$Type;", "public static final")]
			public static Dova.JDK.java.lang.ProcessBuilder.Redirect.Type INHERIT_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder.Redirect.Type>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/ProcessBuilder$Redirect$Type;", "public static final")]
			public static Dova.JDK.java.lang.ProcessBuilder.Redirect.Type READ_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder.Redirect.Type>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/ProcessBuilder$Redirect$Type;", "public static final")]
			public static Dova.JDK.java.lang.ProcessBuilder.Redirect.Type WRITE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder.Redirect.Type>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/ProcessBuilder$Redirect$Type;", "public static final")]
			public static Dova.JDK.java.lang.ProcessBuilder.Redirect.Type APPEND_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder.Redirect.Type>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Ljava/lang/ProcessBuilder$Redirect$Type;", "private static final")]
			public static JavaArray<Dova.JDK.java.lang.ProcessBuilder.Redirect.Type> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.ProcessBuilder.Redirect.Type>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Type(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public Type(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/lang/ProcessBuilder$Redirect$Type;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Ljava/lang/ProcessBuilder$Redirect$Type;", "public static")]
			public static JavaArray<Dova.JDK.java.lang.ProcessBuilder.Redirect.Type> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.ProcessBuilder.Redirect.Type>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/ProcessBuilder$Redirect$Type;", "public static")]
			public static Dova.JDK.java.lang.ProcessBuilder.Redirect.Type valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder.Redirect.Type>(ret);
			}

			[JniSignatureAttribute("()[Ljava/lang/ProcessBuilder$Redirect$Type;", "private static")]
			public static JavaArray<Dova.JDK.java.lang.ProcessBuilder.Redirect.Type> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.ProcessBuilder.Redirect.Type>>(ret);
			}
		}
	}

	[JniSignatureAttribute("Ljava/lang/ProcessBuilder$RedirectPipeImpl;", "static")]
	public partial class RedirectPipeImpl
		: Dova.JDK.java.lang.ProcessBuilder.Redirect
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RedirectPipeImpl()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/ProcessBuilder$RedirectPipeImpl;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fd", "Ljava/io/FileDescriptor;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "type", "()Ljava/lang/ProcessBuilder$Redirect$Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFd", "()Ljava/io/FileDescriptor;"));
		}

		[JniSignatureAttribute("Ljava/io/FileDescriptor;", "final")]
		public Dova.JDK.java.io.FileDescriptor fd_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.FileDescriptor>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RedirectPipeImpl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public RedirectPipeImpl() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/ProcessBuilder$RedirectPipeImpl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/ProcessBuilder$Redirect$Type;", "public")]
		public Dova.JDK.java.lang.ProcessBuilder.Redirect.Type type()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder.Redirect.Type>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/io/FileDescriptor;", "")]
		public Dova.JDK.java.io.FileDescriptor getFd()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.FileDescriptor>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ProcessBuilder$NullOutputStream;", "static")]
	public partial class NullOutputStream
		: Dova.JDK.java.io.OutputStream
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NullOutputStream()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/ProcessBuilder$NullOutputStream;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Ljava/lang/ProcessBuilder$NullOutputStream;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(I)V"));
		}

		[JniSignatureAttribute("Ljava/lang/ProcessBuilder$NullOutputStream;", "static final")]
		public static Dova.JDK.java.lang.ProcessBuilder.NullOutputStream INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder.NullOutputStream>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NullOutputStream(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public NullOutputStream() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/ProcessBuilder$NullOutputStream;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)V", "public")]
		public void write(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ProcessBuilder$NullInputStream;", "static")]
	public partial class NullInputStream
		: Dova.JDK.java.io.InputStream
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NullInputStream()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/ProcessBuilder$NullInputStream;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Ljava/lang/ProcessBuilder$NullInputStream;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "available", "()I"));
		}

		[JniSignatureAttribute("Ljava/lang/ProcessBuilder$NullInputStream;", "static final")]
		public static Dova.JDK.java.lang.ProcessBuilder.NullInputStream INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ProcessBuilder.NullInputStream>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NullInputStream(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public NullInputStream() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/ProcessBuilder$NullInputStream;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int read()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int available()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}
}
