using NVP.API.Nodes;

namespace nanoCAD.nanoCADToolbar 
{
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


	///<summary>
	///Gets the member object at a given index in a collection, group, or selection set
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1]));

		}
	}


	///<summary>
	///Gets the number of items in the collection, dictionary, group, or selection set
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	///<summary>
	///Gets the Application object
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	///<summary>
	///Gets the parent of the object
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	public class Parent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Parent);

		}
	}


	///<summary>
	///Specifies the name of the object
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	///<summary>
	///Specifies the name of the object
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the visibility of an object or the application
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	public class Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Visible);

		}
	}


	///<summary>
	///Specifies the visibility of an object or the application
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("bFlag", typeof(System.Object))]
	public class Set_Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Visible = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies if the toolbar is docked or floating
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	public class DockStatus : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DockStatus);

		}
	}


	///<summary>
	///Specifies if the toolbar button is large or small
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	public class LargeButtons : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LargeButtons);

		}
	}


	///<summary>
	///Specifies the left edge of a toolbar
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	public class left : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.left);

		}
	}


	///<summary>
	///Specifies the left edge of a toolbar
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("nLeft", typeof(System.Int32))]
	public class Set_left : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.left = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the top edge of a toolbar
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	public class top : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.top);

		}
	}


	///<summary>
	///Specifies the top edge of a toolbar
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("nTop", typeof(System.Int32))]
	public class Set_top : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.top = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the width of the text boundary, view, image, toolbar, or main application window
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	///<summary>
	///Height of the attribute, shape, text, or view toolbar or the main application window
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	///<summary>
	///Specifies the number of rows for a floating toolbar
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	public class FloatingRows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FloatingRows);

		}
	}


	///<summary>
	///Specifies the number of rows for a floating toolbar
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("nRows", typeof(System.Int32))]
	public class Set_FloatingRows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FloatingRows = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the help string for the toolbar, toolbar item, or menu item
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	public class HelpString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HelpString);

		}
	}


	///<summary>
	///Specifies the help string for the toolbar, toolbar item, or menu item
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("bstrHelp", typeof(System.String))]
	public class Set_HelpString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HelpString = inputs[1];
			return null;
		}
	}


	///<summary>
	///Adds a toolbar item to a toolbar at a specified position
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("HelpString", typeof(System.String))]
	[NodeInput("Macro", typeof(System.String))]
	[NodeInput("FlyoutButton", typeof(System.Object))]
	public class AddToolbarButton : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddToolbarButton(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5]));

		}
	}


	///<summary>
	///Adds a separator to an existing menu or toolbar
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	public class AddSeparator : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddSeparator(inputs[1]));

		}
	}


	///<summary>
	///Docks the toolbar to the owning frame window
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("Side", typeof(System.Object))]
	public class Dock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Dock(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Floats the toolbar
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("top", typeof(System.Int32))]
	[NodeInput("left", typeof(System.Int32))]
	[NodeInput("NumberFloatRows", typeof(System.Int32))]
	public class Float : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Float(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Deletes a specified object
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	public class Delete : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Delete();
			return null;
		}
	}


	///<summary>
	///Specifies the tag string of the object
	///</summary>
	[NodeInput("nanoCADToolbar", typeof(object))]
	public class TagString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TagString);

		}
	}
}
