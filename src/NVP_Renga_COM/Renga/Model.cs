using NVP.API.Nodes;

namespace Renga.Model 
{
	[NodeInput("dynamic", typeof(object))]
	public class Model_Constructor : INode 
	{
		public Renga.IModel _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IModel;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class Model_ConstructorCast : INode 
	{
		public Renga.IModel _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IModel;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Model", typeof(object))]
	public class GetObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetObjects);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Model", typeof(object))]
	public class CreateOperation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateOperation);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Model", typeof(object))]
	[NodeInput("uniqueId_", typeof(System.Object))]
	public class GetIdFromUniqueId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetIdFromUniqueId(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Model", typeof(object))]
	[NodeInput("uniqueId_", typeof(System.String))]
	public class GetIdFromUniqueIdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetIdFromUniqueIdS(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Model", typeof(object))]
	[NodeInput("id_", typeof(System.Int32))]
	public class GetUniqueIdFromId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetUniqueIdFromId(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Model", typeof(object))]
	[NodeInput("id_", typeof(System.Int32))]
	public class GetUniqueIdFromIdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetUniqueIdFromIdS(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Model", typeof(object))]
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}
}
