using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///A single button item on an toolbar
///</summary>
namespace nanoCAD.nanoCADToolbarItem 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADToolbarItem_Constructor : INode 
	{
		public nanoCAD.InanoCADToolbarItem _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADToolbarItem;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADToolbarItem_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADToolbarItem _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADToolbarItem;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Gets the Application object", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]

	///<summary>
	///Gets the Application object
	///</summary>
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	[NVP_Manifest(
		Text = "Gets the parent of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]

	///<summary>
	///Gets the parent of the object
	///</summary>
	public class Parent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Parent);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the name of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]

	///<summary>
	///Specifies the name of the object
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the name of the object", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies the name of the object
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the tag string of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]

	///<summary>
	///Specifies the tag string of the object
	///</summary>
	public class TagString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TagString);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the tag string of the object", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	[NodeInput("bstrTag", typeof(System.String))]

	///<summary>
	///Specifies the tag string of the object
	///</summary>
	public class Set_TagString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TagString = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies type of a Leader, MenuGroup, PopupMenuItem, ToolbarItem, Polyline, or PolygonMesh object", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]

	///<summary>
	///Specifies type of a Leader, MenuGroup, PopupMenuItem, ToolbarItem, Polyline, or PolygonMesh object
	///</summary>
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	[NVP_Manifest(
		Text = "Gets the toolbar associated with a flyout toolbar item", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]

	///<summary>
	///Gets the toolbar associated with a flyout toolbar item
	///</summary>
	public class Flyout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Flyout);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the macro for the menu or toolbar item", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]

	///<summary>
	///Specifies the macro for the menu or toolbar item
	///</summary>
	public class Macro : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Macro);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the macro for the menu or toolbar item", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	[NodeInput("bstrMacro", typeof(System.String))]

	///<summary>
	///Specifies the macro for the menu or toolbar item
	///</summary>
	public class Set_Macro : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Macro = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the index of the menu or toolbar item", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]

	///<summary>
	///Specifies the index of the menu or toolbar item
	///</summary>
	public class Index : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Index);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the help string for the toolbar, toolbar item, or menu item", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]

	///<summary>
	///Specifies the help string for the toolbar, toolbar item, or menu item
	///</summary>
	public class HelpString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HelpString);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the help string for the toolbar, toolbar item, or menu item", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	[NodeInput("bstrHelp", typeof(System.String))]

	///<summary>
	///Specifies the help string for the toolbar, toolbar item, or menu item
	///</summary>
	public class Set_HelpString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HelpString = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the large and small bitmaps used as icons for the toolbar item", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	[NodeInput("SmallIconName", typeof(System.String))]
	[NodeInput("LargeIconName", typeof(System.String))]

	///<summary>
	///Gets the large and small bitmaps used as icons for the toolbar item
	///</summary>
	public class GetBitmaps : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetBitmaps(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Sets the large and small bitmaps used as icons for the toolbar item", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	[NodeInput("SmallIconName", typeof(System.String))]
	[NodeInput("LargeIconName", typeof(System.String))]

	///<summary>
	///Sets the large and small bitmaps used as icons for the toolbar item
	///</summary>
	public class SetBitmaps : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBitmaps(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Attaches a toolbar to a toolbar button defined as a flyout", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	[NodeInput("MenuGroupName", typeof(System.String))]
	[NodeInput("ToolbarName", typeof(System.String))]

	///<summary>
	///Attaches a toolbar to a toolbar button defined as a flyout
	///</summary>
	public class AttachToolbarToFlyout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AttachToolbarToFlyout(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Deletes a specified object", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]

	///<summary>
	///Deletes a specified object
	///</summary>
	public class Delete : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Delete();
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]

	///<summary>
	///
	///</summary>
	public class CommandDisplayName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CommandDisplayName);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_CommandDisplayName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CommandDisplayName = inputs[1].Value;
			return null;
		}
	}
}
