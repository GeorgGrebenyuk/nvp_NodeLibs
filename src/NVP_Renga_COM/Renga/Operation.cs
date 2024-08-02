using NVP.API.Nodes;

namespace Renga.Operation 
{
	[NodeInput("dynamic", typeof(object))]
	public class Operation_Constructor : INode 
	{
		public Renga.IOperation _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IOperation;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class Operation_ConstructorCast : INode 
	{
		public Renga.IOperation _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IOperation;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Operation", typeof(object))]
	public class Start : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Start();
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Operation", typeof(object))]
	public class Apply : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Apply();
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Operation", typeof(object))]
	public class Rollback : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rollback();
			return null;
		}
	}
}
