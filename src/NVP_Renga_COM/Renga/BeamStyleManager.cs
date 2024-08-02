using NVP.API.Nodes;

namespace Renga.BeamStyleManager 
{
	[NodeInput("dynamic", typeof(object))]
	public class BeamStyleManager_Constructor : INode 
	{
		public Renga.IBeamStyleManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IBeamStyleManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class BeamStyleManager_ConstructorCast : INode 
	{
		public Renga.IBeamStyleManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IBeamStyleManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("BeamStyleManager", typeof(object))]
	public class GetIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetIds();
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("BeamStyleManager", typeof(object))]
	[NodeInput("Id", typeof(System.Int32))]
	public class Contains : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Contains(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("BeamStyleManager", typeof(object))]
	[NodeInput("Id", typeof(System.Int32))]
	public class GetBeamStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBeamStyle(inputs[1]));

		}
	}
}
