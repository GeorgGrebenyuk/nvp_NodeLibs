using NVP.API.Nodes;

namespace Renga.PropertyContainer 
{
	[NodeInput("dynamic", typeof(object))]
	public class PropertyContainer_Constructor : INode 
	{
		public Renga.IPropertyContainer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IPropertyContainer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class PropertyContainer_ConstructorCast : INode 
	{
		public Renga.IPropertyContainer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IPropertyContainer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyContainer", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]
	public class Get : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Get(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyContainer", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]
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
	[NodeInput("PropertyContainer", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]
	public class GetS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetS(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyContainer", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]
	public class ContainsS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ContainsS(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyContainer", typeof(object))]
	public class GetIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetIds);

		}
	}
}
