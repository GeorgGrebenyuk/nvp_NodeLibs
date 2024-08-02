using NVP.API.Nodes;

namespace Renga.Quantity 
{
	[NodeInput("dynamic", typeof(object))]
	public class Quantity_Constructor : INode 
	{
		public Renga.IQuantity _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IQuantity;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class Quantity_ConstructorCast : INode 
	{
		public Renga.IQuantity _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IQuantity;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Quantity", typeof(object))]
	public class HasValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasValue);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Quantity", typeof(object))]
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Quantity", typeof(object))]
	public class AsCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AsCount);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Quantity", typeof(object))]
	[NodeInput("unit", typeof(System.Object))]
	public class AsLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AsLength(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Quantity", typeof(object))]
	[NodeInput("unit", typeof(System.Object))]
	public class AsArea : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AsArea(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Quantity", typeof(object))]
	[NodeInput("unit", typeof(System.Object))]
	public class AsVolume : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AsVolume(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Quantity", typeof(object))]
	[NodeInput("unit", typeof(System.Object))]
	public class AsMass : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AsMass(inputs[1]));

		}
	}
}
