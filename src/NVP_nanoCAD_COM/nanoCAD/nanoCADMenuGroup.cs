using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Menu group
///</summary>
namespace nanoCAD.nanoCADMenuGroup 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADMenuGroup_Constructor : INode 
	{
		public nanoCAD.InanoCADMenuGroup _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADMenuGroup;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADMenuGroup_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADMenuGroup _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADMenuGroup;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Gets the Application object", 
		ViewType = "Data")]
	[NodeInput("nanoCADMenuGroup", typeof(object))]

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
	[NodeInput("nanoCADMenuGroup", typeof(object))]

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
	[NodeInput("nanoCADMenuGroup", typeof(object))]

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
		Text = "Specifies type of a Leader, MenuGroup, PopupMenuItem, ToolbarItem, Polyline, or PolygonMesh object", 
		ViewType = "Data")]
	[NodeInput("nanoCADMenuGroup", typeof(object))]

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
		Text = "Gets the menu file name where the menu group is located", 
		ViewType = "Data")]
	[NodeInput("nanoCADMenuGroup", typeof(object))]

	///<summary>
	///Gets the menu file name where the menu group is located
	///</summary>
	public class MenuFileName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MenuFileName);

		}
	}


	[NVP_Manifest(
		Text = "Gets the PopupMenus collection", 
		ViewType = "Data")]
	[NodeInput("nanoCADMenuGroup", typeof(object))]

	///<summary>
	///Gets the PopupMenus collection
	///</summary>
	public class Menus : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Menus);

		}
	}


	[NVP_Manifest(
		Text = "Gets the Toolbars collection", 
		ViewType = "Data")]
	[NodeInput("nanoCADMenuGroup", typeof(object))]

	///<summary>
	///Gets the Toolbars collection
	///</summary>
	public class Toolbars : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Toolbars);

		}
	}


	[NVP_Manifest(
		Text = "Unloads the menu group or external reference", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADMenuGroup", typeof(object))]

	///<summary>
	///Unloads the menu group or external reference
	///</summary>
	public class Unload : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Unload();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Saves the document or menu group", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADMenuGroup", typeof(object))]
	[NodeInput("nanoCAD.AcMenuFileType", typeof(System.Object))]

	///<summary>
	///Saves the document or menu group
	///</summary>
	public class Save : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Save(((nanoCAD.AcMenuFileType)inputs[1].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Saves the document or menu group to a specified file", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADMenuGroup", typeof(object))]
	[NodeInput("MenuFileName", typeof(System.String))]
	[NodeInput("nanoCAD.AcMenuFileType", typeof(System.Object))]

	///<summary>
	///Saves the document or menu group to a specified file
	///</summary>
	public class SaveAs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SaveAs(inputs[1].Value,((nanoCAD.AcMenuFileType)inputs[2].Value));
			return null;
		}
	}
}
