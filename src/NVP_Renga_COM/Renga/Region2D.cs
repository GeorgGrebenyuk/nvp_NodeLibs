using NVP.API.Nodes;

namespace Renga.Region2D 
{
	[NodeInput("dynamic", typeof(object))]
	public class Region2D_Constructor : INode 
	{
		public Renga.IRegion2D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IRegion2D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class Region2D_ConstructorCast : INode 
	{
		public Renga.IRegion2D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IRegion2D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Region2D", typeof(object))]
	public class GetContourCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetContourCount);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Region2D", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]
	public class GetContour : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetContour(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Region2D", typeof(object))]
	public class GetOuterContour : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetOuterContour);

		}
	}
}
