using NVP.API.Nodes;

namespace nanoCAD.nanoCADMenuGroups 
{
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADMenuGroups_Constructor : INode 
	{
		public nanoCAD.InanoCADMenuGroups _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADMenuGroups;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADMenuGroups_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADMenuGroups _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADMenuGroups;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Gets the member object at a given index in a collection, group, or selection set
	///</summary>
	[NodeInput("nanoCADMenuGroups", typeof(object))]
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
	[NodeInput("nanoCADMenuGroups", typeof(object))]
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
	[NodeInput("nanoCADMenuGroups", typeof(object))]
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
	[NodeInput("nanoCADMenuGroups", typeof(object))]
	public class Parent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Parent);

		}
	}


	///<summary>
	///Loads a menu group from a menu file
	///</summary>
	[NodeInput("nanoCADMenuGroups", typeof(object))]
	[NodeInput("MenuFileName", typeof(System.String))]
	[NodeInput("BaseMenu", typeof(System.Object))]
	public class Load : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Load(inputs[1],inputs[2]));

		}
	}
}
