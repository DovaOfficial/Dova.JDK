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

namespace Dova.JDK.javax.swing.tree;

[JniSignatureAttribute("Ljavax/swing/tree/AbstractLayoutCache;", "public abstract")]
public partial class AbstractLayoutCache
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.swing.tree.RowMapper
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AbstractLayoutCache()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/swing/tree/AbstractLayoutCache;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "nodeDimensions", "Ljavax/swing/tree/AbstractLayoutCache$NodeDimensions;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "treeModel", "Ljavax/swing/tree/TreeModel;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "treeSelectionModel", "Ljavax/swing/tree/TreeSelectionModel;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "rootVisible", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "rowHeight", "I"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "AbstractLayoutCache", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getBounds", "(Ljavax/swing/tree/TreePath;Ljava/awt/Rectangle;)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getRowCount", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getRowHeight", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setRowHeight", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getRowForPath", "(Ljavax/swing/tree/TreePath;)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPathForRow", "(I)Ljavax/swing/tree/TreePath;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPathClosestTo", "(II)Ljavax/swing/tree/TreePath;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getVisiblePathsFrom", "(Ljavax/swing/tree/TreePath;)Ljava/util/Enumeration;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNodeDimensions", "(Ljava/lang/Object;IIZLjava/awt/Rectangle;)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNodeDimensions", "()Ljavax/swing/tree/AbstractLayoutCache$NodeDimensions;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setNodeDimensions", "(Ljavax/swing/tree/AbstractLayoutCache$NodeDimensions;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setRootVisible", "(Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isRootVisible", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPreferredHeight", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPreferredWidth", "(Ljava/awt/Rectangle;)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isExpanded", "(Ljavax/swing/tree/TreePath;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getVisibleChildCount", "(Ljavax/swing/tree/TreePath;)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setExpandedState", "(Ljavax/swing/tree/TreePath;Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getExpandedState", "(Ljavax/swing/tree/TreePath;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "invalidateSizes", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "invalidatePathBounds", "(Ljavax/swing/tree/TreePath;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "treeNodesChanged", "(Ljavax/swing/event/TreeModelEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "treeNodesInserted", "(Ljavax/swing/event/TreeModelEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "treeNodesRemoved", "(Ljavax/swing/event/TreeModelEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "treeStructureChanged", "(Ljavax/swing/event/TreeModelEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getRowsForPaths", "([Ljavax/swing/tree/TreePath;)[I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isFixedRowHeight", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setSelectionModel", "(Ljavax/swing/tree/TreeSelectionModel;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getSelectionModel", "()Ljavax/swing/tree/TreeSelectionModel;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getModel", "()Ljavax/swing/tree/TreeModel;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setModel", "(Ljavax/swing/tree/TreeModel;)V"));
	}

	[JniSignatureAttribute("Ljavax/swing/tree/AbstractLayoutCache$NodeDimensions;", "protected")]
	public Dova.JDK.javax.swing.tree.AbstractLayoutCache.NodeDimensions nodeDimensions_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.AbstractLayoutCache.NodeDimensions>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/tree/TreeModel;", "protected")]
	public Dova.JDK.javax.swing.tree.TreeModel treeModel_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreeModel>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/tree/TreeSelectionModel;", "protected")]
	public Dova.JDK.javax.swing.tree.TreeSelectionModel treeSelectionModel_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreeSelectionModel>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool rootVisible_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("I", "protected")]
	public int rowHeight_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AbstractLayoutCache(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public AbstractLayoutCache() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/tree/AbstractLayoutCache;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;Ljava/awt/Rectangle;)Ljava/awt/Rectangle;", "public abstract")]
	public Dova.JDK.java.awt.Rectangle getBounds(Dova.JDK.javax.swing.tree.TreePath arg0, Dova.JDK.java.awt.Rectangle arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	public int getRowCount()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getRowHeight()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setRowHeight(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)I", "public abstract")]
	public int getRowForPath(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljavax/swing/tree/TreePath;", "public abstract")]
	public Dova.JDK.javax.swing.tree.TreePath getPathForRow(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreePath>(ret);
	}

	[JniSignatureAttribute("(II)Ljavax/swing/tree/TreePath;", "public abstract")]
	public Dova.JDK.javax.swing.tree.TreePath getPathClosestTo(int arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreePath>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)Ljava/util/Enumeration;", "public abstract")]
	public Dova.JDK.java.util.Enumeration getVisiblePathsFrom(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;IIZLjava/awt/Rectangle;)Ljava/awt/Rectangle;", "protected")]
	public Dova.JDK.java.awt.Rectangle getNodeDimensions(Dova.JDK.java.lang.Object arg0, int arg1, int arg2, bool arg3, Dova.JDK.java.awt.Rectangle arg4)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/tree/AbstractLayoutCache$NodeDimensions;", "public")]
	public Dova.JDK.javax.swing.tree.AbstractLayoutCache.NodeDimensions getNodeDimensions()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.AbstractLayoutCache.NodeDimensions>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/AbstractLayoutCache$NodeDimensions;)V", "public")]
	public void setNodeDimensions(Dova.JDK.javax.swing.tree.AbstractLayoutCache.NodeDimensions arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setRootVisible(bool arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isRootVisible()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getPreferredHeight()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;)I", "public")]
	public int getPreferredWidth(Dova.JDK.java.awt.Rectangle arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)Z", "public abstract")]
	public bool isExpanded(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)I", "public abstract")]
	public int getVisibleChildCount(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;Z)V", "public abstract")]
	public void setExpandedState(Dova.JDK.javax.swing.tree.TreePath arg0, bool arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)Z", "public abstract")]
	public bool getExpandedState(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "public abstract")]
	public void invalidateSizes()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19]);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)V", "public abstract")]
	public void invalidatePathBounds(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeModelEvent;)V", "public abstract")]
	public void treeNodesChanged(Dova.JDK.javax.swing.@event.TreeModelEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeModelEvent;)V", "public abstract")]
	public void treeNodesInserted(Dova.JDK.javax.swing.@event.TreeModelEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeModelEvent;)V", "public abstract")]
	public void treeNodesRemoved(Dova.JDK.javax.swing.@event.TreeModelEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeModelEvent;)V", "public abstract")]
	public void treeStructureChanged(Dova.JDK.javax.swing.@event.TreeModelEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("([Ljavax/swing/tree/TreePath;)[I", "public")]
	public JavaArray<int> getRowsForPaths(JavaArray<Dova.JDK.javax.swing.tree.TreePath> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool isFixedRowHeight()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreeSelectionModel;)V", "public")]
	public void setSelectionModel(Dova.JDK.javax.swing.tree.TreeSelectionModel arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/tree/TreeSelectionModel;", "public")]
	public Dova.JDK.javax.swing.tree.TreeSelectionModel getSelectionModel()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreeSelectionModel>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/tree/TreeModel;", "public")]
	public Dova.JDK.javax.swing.tree.TreeModel getModel()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreeModel>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreeModel;)V", "public")]
	public void setModel(Dova.JDK.javax.swing.tree.TreeModel arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("Ljavax/swing/tree/AbstractLayoutCache$NodeDimensions;", "public abstract static")]
	public partial class NodeDimensions
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NodeDimensions()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/swing/tree/AbstractLayoutCache$NodeDimensions;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "NodeDimensions", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNodeDimensions", "(Ljava/lang/Object;IIZLjava/awt/Rectangle;)Ljava/awt/Rectangle;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NodeDimensions(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public NodeDimensions() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/tree/AbstractLayoutCache$NodeDimensions;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;IIZLjava/awt/Rectangle;)Ljava/awt/Rectangle;", "public abstract")]
		public Dova.JDK.java.awt.Rectangle getNodeDimensions(Dova.JDK.java.lang.Object arg0, int arg1, int arg2, bool arg3, Dova.JDK.java.awt.Rectangle arg4)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}
	}
}