using NVP.API.Nodes;

namespace OdaX.AcadBlocks 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadBlocks_Constructor : INode 
	{
		public OdaX.IAcadBlocks _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadBlocks;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadBlocks_ConstructorCast : INode 
	{
		public OdaX.IAcadBlocks _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadBlocks;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Returns an object at a given index in a collection, block, group, or selection set.
	///</summary>
	[NodeInput("AcadBlocks", typeof(object))]
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
	///Returns the number of items in the collection, block, dictionary, group, or selection set.
	///</summary>
	[NodeInput("AcadBlocks", typeof(object))]
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	///<summary>
	///Creates an object and adds it to the collection, block, dictionary, group, or selection set.
	///</summary>
	[NodeInput("AcadBlocks", typeof(object))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("Name", typeof(System.String))]
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Add(inputs[1],inputs[2]));

		}
	}
}
