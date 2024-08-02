using NVP.API.Nodes;

namespace Renga.LayeredMaterial 
{
	[NodeInput("dynamic", typeof(object))]
	public class LayeredMaterial_Constructor : INode 
	{
		public Renga.ILayeredMaterial _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ILayeredMaterial;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class LayeredMaterial_ConstructorCast : INode 
	{
		public Renga.ILayeredMaterial _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ILayeredMaterial;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("LayeredMaterial", typeof(object))]
	public class GetIdGroupPair : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetIdGroupPair);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("LayeredMaterial", typeof(object))]
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("LayeredMaterial", typeof(object))]
	public class Layers : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Layers);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("LayeredMaterial", typeof(object))]
	public class GetBaseLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBaseLayer);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("LayeredMaterial", typeof(object))]
	public class BaseLayerIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BaseLayerIndex);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("LayeredMaterial", typeof(object))]
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}
}
