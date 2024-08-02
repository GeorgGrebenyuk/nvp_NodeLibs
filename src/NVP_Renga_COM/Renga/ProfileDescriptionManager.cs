using NVP.API.Nodes;

namespace Renga.ProfileDescriptionManager 
{
	[NodeInput("dynamic", typeof(object))]
	public class ProfileDescriptionManager_Constructor : INode 
	{
		public Renga.IProfileDescriptionManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IProfileDescriptionManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class ProfileDescriptionManager_ConstructorCast : INode 
	{
		public Renga.IProfileDescriptionManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IProfileDescriptionManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ProfileDescriptionManager", typeof(object))]
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
	[NodeInput("ProfileDescriptionManager", typeof(object))]
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
	[NodeInput("ProfileDescriptionManager", typeof(object))]
	[NodeInput("Id", typeof(System.Int32))]
	public class GetProfileDescription : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetProfileDescription(inputs[1]));

		}
	}
}
