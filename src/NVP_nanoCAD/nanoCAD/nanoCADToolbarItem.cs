using NVP.API.Nodes;

namespace nanoCAD.nanoCADToolbarItem 
{
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


	///<summary>
	///Gets the Application object
	///</summary>
	[NodeInput("nanoCADToolbarItem", typeof(object))]
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
	[NodeInput("nanoCADToolbarItem", typeof(object))]
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
	[NodeInput("nanoCADToolbarItem", typeof(object))]
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
	[NodeInput("nanoCADToolbarItem", typeof(object))]
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
	///Specifies the tag string of the object
	///</summary>
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	public class TagString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TagString);

		}
	}


	///<summary>
	///Specifies the tag string of the object
	///</summary>
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	[NodeInput("bstrTag", typeof(System.String))]
	public class Set_TagString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TagString = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies type of a Leader, MenuGroup, PopupMenuItem, ToolbarItem, Polyline, or PolygonMesh object
	///</summary>
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	///<summary>
	///Gets the toolbar associated with a flyout toolbar item
	///</summary>
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	public class Flyout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Flyout);

		}
	}


	///<summary>
	///Specifies the macro for the menu or toolbar item
	///</summary>
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	public class Macro : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Macro);

		}
	}


	///<summary>
	///Specifies the macro for the menu or toolbar item
	///</summary>
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	[NodeInput("bstrMacro", typeof(System.String))]
	public class Set_Macro : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Macro = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the index of the menu or toolbar item
	///</summary>
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	public class Index : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Index);

		}
	}


	///<summary>
	///Specifies the help string for the toolbar, toolbar item, or menu item
	///</summary>
	[NodeInput("nanoCADToolbarItem", typeof(object))]
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
	[NodeInput("nanoCADToolbarItem", typeof(object))]
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
	///Gets the large and small bitmaps used as icons for the toolbar item
	///</summary>
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	[NodeInput("SmallIconName", typeof(System.String))]
	[NodeInput("LargeIconName", typeof(System.String))]
	public class GetBitmaps : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetBitmaps(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Sets the large and small bitmaps used as icons for the toolbar item
	///</summary>
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	[NodeInput("SmallIconName", typeof(System.String))]
	[NodeInput("LargeIconName", typeof(System.String))]
	public class SetBitmaps : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBitmaps(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Attaches a toolbar to a toolbar button defined as a flyout
	///</summary>
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	[NodeInput("MenuGroupName", typeof(System.String))]
	[NodeInput("ToolbarName", typeof(System.String))]
	public class AttachToolbarToFlyout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AttachToolbarToFlyout(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Deletes a specified object
	///</summary>
	[NodeInput("nanoCADToolbarItem", typeof(object))]
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
	///
	///</summary>
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	public class CommandDisplayName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CommandDisplayName);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("nanoCADToolbarItem", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	public class Set_CommandDisplayName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CommandDisplayName = inputs[1];
			return null;
		}
	}
}
