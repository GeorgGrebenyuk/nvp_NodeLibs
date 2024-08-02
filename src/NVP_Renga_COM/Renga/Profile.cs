using NVP.API.Nodes;

namespace Renga.Profile 
{
	[NodeInput("dynamic", typeof(object))]
	public class Profile_Constructor : INode 
	{
		public Renga.IProfile _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IProfile;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class Profile_ConstructorCast : INode 
	{
		public Renga.IProfile _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IProfile;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Profile", typeof(object))]
	public class DescriptionId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DescriptionId);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Profile", typeof(object))]
	public class Regions : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Regions);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Profile", typeof(object))]
	public class GetCenterOfMass : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCenterOfMass);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Profile", typeof(object))]
	public class Parameters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Parameters);

		}
	}
}
