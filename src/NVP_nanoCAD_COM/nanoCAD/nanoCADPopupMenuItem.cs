using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///A single menu item on an pull-down menu
///</summary>
namespace nanoCAD.nanoCADPopupMenuItem 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPopupMenuItem_Constructor : INode 
	{
		public nanoCAD.InanoCADPopupMenuItem _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPopupMenuItem;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPopupMenuItem_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPopupMenuItem _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPopupMenuItem;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Gets the Application object", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

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
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

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
		Text = "Specifies the content and formatting of menu items as they appear to the user", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

	///<summary>
	///Specifies the content and formatting of menu items as they appear to the user
	///</summary>
	public class Label : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Label);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the content and formatting of menu items as they appear to the user", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]
	[NodeInput("bstrLabel", typeof(System.String))]

	///<summary>
	///Specifies the content and formatting of menu items as they appear to the user
	///</summary>
	public class Set_Label : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Label = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the tag string of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

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
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]
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
		Text = "Enables the popup menu or toolbar item", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

	///<summary>
	///Enables the popup menu or toolbar item
	///</summary>
	public class Enable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Enable);

		}
	}


	[NVP_Manifest(
		Text = "Enables the popup menu or toolbar item", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]
	[NodeInput("bFlag", typeof(System.Object))]

	///<summary>
	///Enables the popup menu or toolbar item
	///</summary>
	public class Set_Enable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Enable = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the check status for the popup menu item", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

	///<summary>
	///Specifies the check status for the popup menu item
	///</summary>
	public class Check : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Check);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the check status for the popup menu item", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]
	[NodeInput("bFlag", typeof(System.Object))]

	///<summary>
	///Specifies the check status for the popup menu item
	///</summary>
	public class Set_Check : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Check = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies type of a Leader, MenuGroup, PopupMenuItem, ToolbarItem, Polyline, or PolygonMesh object", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

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
		Text = "Gets the popup menu associated with a sub menu", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

	///<summary>
	///Gets the popup menu associated with a sub menu
	///</summary>
	public class SubMenu : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SubMenu);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the macro for the menu or toolbar item", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

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
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]
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
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

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
		Text = "Gets the text that the user sees displayed for the application or a menu item", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

	///<summary>
	///Gets the text that the user sees displayed for the application or a menu item
	///</summary>
	public class Caption : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Caption);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the help string for the toolbar, toolbar item, or menu item", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

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
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]
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
		Text = "Deletes a specified object", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

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
		Text = "Specifies the submenu level for the menu item", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]

	///<summary>
	///Specifies the submenu level for the menu item
	///</summary>
	public class EndSubMenuLevel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndSubMenuLevel);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the submenu level for the menu item", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPopupMenuItem", typeof(object))]
	[NodeInput("level", typeof(System.Int32))]

	///<summary>
	///Specifies the submenu level for the menu item
	///</summary>
	public class Set_EndSubMenuLevel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndSubMenuLevel = inputs[1].Value;
			return null;
		}
	}
}
