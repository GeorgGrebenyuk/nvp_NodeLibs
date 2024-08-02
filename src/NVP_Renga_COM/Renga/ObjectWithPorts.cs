using NVP.API.Nodes;

namespace Renga.ObjectWithPorts 
{
	[NodeInput("dynamic", typeof(object))]
	public class ObjectWithPorts_Constructor : INode 
	{
		public Renga.IObjectWithPorts _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IObjectWithPorts;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class ObjectWithPorts_ConstructorCast : INode 
	{
		public Renga.IObjectWithPorts _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IObjectWithPorts;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ObjectWithPorts", typeof(object))]
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ObjectWithPorts", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]
	public class GetByIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetByIndex(inputs[1]));

		}
	}
}
