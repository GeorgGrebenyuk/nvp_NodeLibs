using NVP.API.Nodes;

namespace Renga.OpeningParams 
{
	[NodeInput("dynamic", typeof(object))]
	public class OpeningParams_Constructor : INode 
	{
		public Renga.IOpeningParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IOpeningParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class OpeningParams_ConstructorCast : INode 
	{
		public Renga.IOpeningParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IOpeningParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("OpeningParams", typeof(object))]
	public class GetContour : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetContour);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("OpeningParams", typeof(object))]
	public class Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Thickness);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("OpeningParams", typeof(object))]
	public class VerticalOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VerticalOffset);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("OpeningParams", typeof(object))]
	public class GetAffectedObjectIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetAffectedObjectIds();
			return null;
		}
	}
}
