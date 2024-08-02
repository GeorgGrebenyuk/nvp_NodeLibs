using NVP.API.Nodes;

namespace OdaX.AcadViews 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadViews_Constructor : INode 
	{
		public OdaX.IAcadViews _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadViews;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadViews_ConstructorCast : INode 
	{
		public OdaX.IAcadViews _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadViews;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Gets the member object at a given index in a collection, group, or selection set
	///</summary>
	[NodeInput("AcadViews", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1]));

		}
	}


	///<summary>
	///Gets the number of items in the collection, dictionary, group, or selection set
	///</summary>
	[NodeInput("AcadViews", typeof(object))]
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	///<summary>
	///Creates a member object and adds it to the appropriate collection
	///</summary>
	[NodeInput("AcadViews", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Add(inputs[1]));

		}
	}
}
