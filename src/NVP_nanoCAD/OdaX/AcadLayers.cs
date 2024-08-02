using NVP.API.Nodes;

namespace OdaX.AcadLayers 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadLayers_Constructor : INode 
	{
		public OdaX.IAcadLayers _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadLayers;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadLayers_ConstructorCast : INode 
	{
		public OdaX.IAcadLayers _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadLayers;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Returns an object at a given index in a collection.
	///</summary>
	[NodeInput("AcadLayers", typeof(object))]
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
	///Returns the number of items in the collection.
	///</summary>
	[NodeInput("AcadLayers", typeof(object))]
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	///<summary>
	///Creates an object and adds it to the collection.
	///</summary>
	[NodeInput("AcadLayers", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Add(inputs[1]));

		}
	}


	///<summary>
	///Generates data about whether a layer is in use.
	///</summary>
	[NodeInput("AcadLayers", typeof(object))]
	public class GenerateUsageData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GenerateUsageData();
			return null;
		}
	}
}
