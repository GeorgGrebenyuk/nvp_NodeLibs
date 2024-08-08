using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///An toolbar
///</summary>
namespace nanoCAD.nanoCADToolbar 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADToolbar_Constructor : INode 
	{
		public nanoCAD.InanoCADToolbar _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADToolbar;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADToolbar_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADToolbar _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADToolbar;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Gets the member object at a given index in a collection, group, or selection set", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]
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
	[NodeInput("nanoCADToolbar", typeof(object))]

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
	[NodeInput("nanoCADToolbar", typeof(object))]

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
	[NodeInput("nanoCADToolbar", typeof(object))]

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
	[NodeInput("nanoCADToolbar", typeof(object))]

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
	[NodeInput("nanoCADToolbar", typeof(object))]
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
		Text = "Specifies the visibility of an object or the application", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

	///<summary>
	///Specifies the visibility of an object or the application
	///</summary>
	public class Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Visible);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the visibility of an object or the application", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("bFlag", typeof(System.Object))]

	///<summary>
	///Specifies the visibility of an object or the application
	///</summary>
	public class Set_Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Visible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies if the toolbar is docked or floating", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

	///<summary>
	///Specifies if the toolbar is docked or floating
	///</summary>
	public class DockStatus : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DockStatus);

		}
	}


	[NVP_Manifest(
		Text = "Specifies if the toolbar button is large or small", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

	///<summary>
	///Specifies if the toolbar button is large or small
	///</summary>
	public class LargeButtons : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LargeButtons);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the left edge of a toolbar", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

	///<summary>
	///Specifies the left edge of a toolbar
	///</summary>
	public class left : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.left);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the left edge of a toolbar", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("nLeft", typeof(System.Int32))]

	///<summary>
	///Specifies the left edge of a toolbar
	///</summary>
	public class Set_left : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.left = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the top edge of a toolbar", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

	///<summary>
	///Specifies the top edge of a toolbar
	///</summary>
	public class top : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.top);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the top edge of a toolbar", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("nTop", typeof(System.Int32))]

	///<summary>
	///Specifies the top edge of a toolbar
	///</summary>
	public class Set_top : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.top = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the width of the text boundary, view, image, toolbar, or main application window", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

	///<summary>
	///Specifies the width of the text boundary, view, image, toolbar, or main application window
	///</summary>
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	[NVP_Manifest(
		Text = "Height of the attribute, shape, text, or view toolbar or the main application window", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

	///<summary>
	///Height of the attribute, shape, text, or view toolbar or the main application window
	///</summary>
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the number of rows for a floating toolbar", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

	///<summary>
	///Specifies the number of rows for a floating toolbar
	///</summary>
	public class FloatingRows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FloatingRows);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the number of rows for a floating toolbar", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("nRows", typeof(System.Int32))]

	///<summary>
	///Specifies the number of rows for a floating toolbar
	///</summary>
	public class Set_FloatingRows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FloatingRows = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the help string for the toolbar, toolbar item, or menu item", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

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
	[NodeInput("nanoCADToolbar", typeof(object))]
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
		Text = "Adds a toolbar item to a toolbar at a specified position", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("HelpString", typeof(System.String))]
	[NodeInput("Macro", typeof(System.String))]
	[NodeInput("FlyoutButton", typeof(System.Object))]

	///<summary>
	///Adds a toolbar item to a toolbar at a specified position
	///</summary>
	public class AddToolbarButton : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddToolbarButton(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value));

		}
	}


	[NVP_Manifest(
		Text = "Adds a separator to an existing menu or toolbar", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]
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
		Text = "Docks the toolbar to the owning frame window", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("nanoCAD.AcToolbarDockStatus", typeof(System.Object))]

	///<summary>
	///Docks the toolbar to the owning frame window
	///</summary>
	public class Dock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Dock(((nanoCAD.AcToolbarDockStatus)inputs[1].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Floats the toolbar", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("top", typeof(System.Int32))]
	[NodeInput("left", typeof(System.Int32))]
	[NodeInput("NumberFloatRows", typeof(System.Int32))]

	///<summary>
	///Floats the toolbar
	///</summary>
	public class Float : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Float(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Deletes a specified object", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbar", typeof(object))]

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
		Text = "Specifies the tag string of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

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
