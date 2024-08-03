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
		Id = "05306B28-5857-415C-94B4-E2F8E78F4513", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenu.nanoCADPopupMenu_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenu", 
		NodeName = "_nanoCADPopupMenu_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "25F0967D-17F1-47FF-A73F-0314EFA6F445", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenu.nanoCADPopupMenu_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenu", 
		NodeName = "_nanoCADPopupMenu_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "07ECB7AB-0E16-4390-9C2F-0FF5663F5D48", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenu.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenu", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "992A624E-6AAC-4026-BDF6-99808E907805", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenu.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenu", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "90E20C42-0E59-4DA3-8198-5C0769BB9D1B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenu.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenu", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "2131446D-7BC6-4E10-81F1-C539F2FD229E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenu.Parent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenu", 
		NodeName = "Parent", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "97302CD5-2A66-45DD-8B2B-DAAE93C84385", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenu.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenu", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "EDEC48DA-98F5-421A-BACD-425BA46A0181", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenu.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenu", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "C05BA078-5FAF-4A04-8470-C5438A15798C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenu.NameNoMnemonic", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenu", 
		NodeName = "NameNoMnemonic", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "261B3193-5900-4AEA-975F-B3113C29C78D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenu.ShortcutMenu", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenu", 
		NodeName = "ShortcutMenu", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "17AE0D76-BF77-407E-93F5-0D54081F6A15", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenu.OnMenuBar", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenu", 
		NodeName = "OnMenuBar", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "119FF7E1-B315-4A66-BFB2-E895840FF552", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenu.AddMenuItem", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenu", 
		NodeName = "AddMenuItem", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "2A1A1428-EB07-4241-A08A-9253583C9AF6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenu.AddSubMenu", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenu", 
		NodeName = "AddSubMenu", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "99A4C586-4B98-4B2B-AFAF-A6D5E7B993C5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenu.AddSeparator", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenu", 
		NodeName = "AddSeparator", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "7391782F-46FA-4DE4-A76E-702DA63B9A38", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenu.InsertInMenuBar", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenu", 
		NodeName = "InsertInMenuBar", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "128549DE-9C74-4E1F-8498-45F074DA8118", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenu.RemoveFromMenuBar", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenu", 
		NodeName = "RemoveFromMenuBar", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "8BEEE12F-F124-410C-B4DD-76FC8DE1177F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPopupMenu.TagString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPopupMenu", 
		NodeName = "TagString", 
		NodeType = "Loaded", 
		CADType = "None", 
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
