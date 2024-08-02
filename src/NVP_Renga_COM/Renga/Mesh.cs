using NVP.API.Nodes;

namespace Renga.Mesh 
{
	[NodeInput("dynamic", typeof(object))]
	public class Mesh_Constructor : INode 
	{
		public Renga.IMesh _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IMesh;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class Mesh_ConstructorCast : INode 
	{
		public Renga.IMesh _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IMesh;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Mesh", typeof(object))]
	public class GridCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GridCount);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Mesh", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]
	public class GetGrid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGrid(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Mesh", typeof(object))]
	public class MeshType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MeshType);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Mesh", typeof(object))]
	public class MeshTypeS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MeshTypeS);

		}
	}
}
