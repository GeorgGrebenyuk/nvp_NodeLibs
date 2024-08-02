using NVP.API.Nodes;

namespace Renga.ModelObjectCollection 
{
	[NodeInput("dynamic", typeof(object))]
	public class ModelObjectCollection_Constructor : INode 
	{
		public Renga.IModelObjectCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IModelObjectCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class ModelObjectCollection_ConstructorCast : INode 
	{
		public Renga.IModelObjectCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IModelObjectCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ModelObjectCollection", typeof(object))]
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
	[NodeInput("ModelObjectCollection", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]
	public class GetByIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetByIndex(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ModelObjectCollection", typeof(object))]
	[NodeInput("Id", typeof(System.Int32))]
	public class GetById : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetById(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ModelObjectCollection", typeof(object))]
	public class GetIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetIds();
			return null;
		}
	}
}
