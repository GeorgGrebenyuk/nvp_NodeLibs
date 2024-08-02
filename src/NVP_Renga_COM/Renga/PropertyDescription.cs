using NVP.API.Nodes;

namespace Renga.PropertyDescription 
{
	[NodeInput("dynamic", typeof(object))]
	public class PropertyDescription_Constructor : INode 
	{
		public Renga.IPropertyDescription _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IPropertyDescription;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class PropertyDescription_ConstructorCast : INode 
	{
		public Renga.IPropertyDescription _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IPropertyDescription;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyDescription", typeof(object))]
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
	[NodeInput("PropertyDescription", typeof(object))]
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
	[NodeInput("PropertyDescription", typeof(object))]
	public class SetEnumerationItems : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetEnumerationItems();
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyDescription", typeof(object))]
	public class GetEnumerationItems : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetEnumerationItems();
			return null;
		}
	}
}
