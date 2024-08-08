using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Cascading menu
///</summary>
namespace nanoCAD.nanoCADPopupMenu 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPopupMenu_Constructor : INode 
	{
		public nanoCAD.InanoCADPopupMenu _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPopupMenu;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPopupMenu_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPopupMenu _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPopupMenu;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Gets the member object at a given index in a collection, group, or selection set", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenu", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Gets the member object at a given index in a collection, group, or selection set
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Gets the number of items in the collection, dictionary, group, or selection set", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenu", typeof(object))]

	///<summary>
	///Gets the number of items in the collection, dictionary, group, or selection set
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Text = "Gets the Application object", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenu", typeof(object))]

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
	[NodeInput("nanoCADPopupMenu", typeof(object))]

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
	[NodeInput("nanoCADPopupMenu", typeof(object))]

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
	[NodeInput("nanoCADPopupMenu", typeof(object))]
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
		Text = "Specifies the name of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenu", typeof(object))]

	///<summary>
	///Specifies the name of the object
	///</summary>
	public class NameNoMnemonic : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NameNoMnemonic);

		}
	}


	[NVP_Manifest(
		Text = "Determines if the specified popup menu is the shortcut menu", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenu", typeof(object))]

	///<summary>
	///Determines if the specified popup menu is the shortcut menu
	///</summary>
	public class ShortcutMenu : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShortcutMenu);

		}
	}


	[NVP_Manifest(
		Text = "Determines if the specified popup menu is on the menu bar", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenu", typeof(object))]

	///<summary>
	///Determines if the specified popup menu is on the menu bar
	///</summary>
	public class OnMenuBar : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OnMenuBar);

		}
	}


	[NVP_Manifest(
		Text = "Adds a popup menu item to a popup menu", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenu", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("Label", typeof(System.String))]
	[NodeInput("Macro", typeof(System.String))]

	///<summary>
	///Adds a popup menu item to a popup menu
	///</summary>
	public class AddMenuItem : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddMenuItem(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Text = "Adds a submenu to an existing menu", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenu", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("Label", typeof(System.String))]

	///<summary>
	///Adds a submenu to an existing menu
	///</summary>
	public class AddSubMenu : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddSubMenu(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Adds a separator to an existing menu or toolbar", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenu", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Adds a separator to an existing menu or toolbar
	///</summary>
	public class AddSeparator : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddSeparator(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Inserts the popup menu into the menu bar at a specified location", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPopupMenu", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Inserts the popup menu into the menu bar at a specified location
	///</summary>
	public class InsertInMenuBar : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertInMenuBar(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Removes the popup menu from the menu bar", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPopupMenu", typeof(object))]

	///<summary>
	///Removes the popup menu from the menu bar
	///</summary>
	public class RemoveFromMenuBar : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveFromMenuBar();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the tag string of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADPopupMenu", typeof(object))]

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
}
