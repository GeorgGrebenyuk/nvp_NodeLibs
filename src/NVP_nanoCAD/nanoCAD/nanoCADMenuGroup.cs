using NVP.API.Nodes;

namespace nanoCAD.nanoCADMenuGroup 
{
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


	///<summary>
	///Gets the Application object
	///</summary>
	[NodeInput("nanoCADMenuGroup", typeof(object))]
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
	[NodeInput("nanoCADMenuGroup", typeof(object))]
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
	[NodeInput("nanoCADMenuGroup", typeof(object))]
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	///<summary>
	///Specifies type of a Leader, MenuGroup, PopupMenuItem, ToolbarItem, Polyline, or PolygonMesh object
	///</summary>
	[NodeInput("nanoCADMenuGroup", typeof(object))]
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	///<summary>
	///Gets the menu file name where the menu group is located
	///</summary>
	[NodeInput("nanoCADMenuGroup", typeof(object))]
	public class MenuFileName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MenuFileName);

		}
	}


	///<summary>
	///Gets the PopupMenus collection
	///</summary>
	[NodeInput("nanoCADMenuGroup", typeof(object))]
	public class Menus : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Menus);

		}
	}


	///<summary>
	///Gets the Toolbars collection
	///</summary>
	[NodeInput("nanoCADMenuGroup", typeof(object))]
	public class Toolbars : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Toolbars);

		}
	}


	///<summary>
	///Unloads the menu group or external reference
	///</summary>
	[NodeInput("nanoCADMenuGroup", typeof(object))]
	public class Unload : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Unload();
			return null;
		}
	}


	///<summary>
	///Saves the document or menu group
	///</summary>
	[NodeInput("nanoCADMenuGroup", typeof(object))]
	[NodeInput("MenuFileType", typeof(System.Object))]
	public class Save : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Save(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Saves the document or menu group to a specified file
	///</summary>
	[NodeInput("nanoCADMenuGroup", typeof(object))]
	[NodeInput("MenuFileName", typeof(System.String))]
	[NodeInput("MenuFileType", typeof(System.Object))]
	public class SaveAs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SaveAs(inputs[1],inputs[2]);
			return null;
		}
	}
}
