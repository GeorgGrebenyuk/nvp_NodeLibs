using NVP.API.Nodes;

namespace Renga.MaterialManager 
{
	[NodeInput("dynamic", typeof(object))]
	public class MaterialManager_Constructor : INode 
	{
		public Renga.IMaterialManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IMaterialManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class MaterialManager_ConstructorCast : INode 
	{
		public Renga.IMaterialManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IMaterialManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("MaterialManager", typeof(object))]
	[NodeInput("MaterialId", typeof(System.Int32))]
	public class GetMaterial : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetMaterial(inputs[1]));

		}
	}
}
