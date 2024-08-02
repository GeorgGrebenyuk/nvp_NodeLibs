using NVP.API.Nodes;

namespace Renga.GridWithMaterial 
{
	[NodeInput("dynamic", typeof(object))]
	public class GridWithMaterial_Constructor : INode 
	{
		public Renga.IGridWithMaterial _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IGridWithMaterial;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class GridWithMaterial_ConstructorCast : INode 
	{
		public Renga.IGridWithMaterial _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IGridWithMaterial;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("GridWithMaterial", typeof(object))]
	public class Grid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Grid);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("GridWithMaterial", typeof(object))]
	public class Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Material);

		}
	}
}
