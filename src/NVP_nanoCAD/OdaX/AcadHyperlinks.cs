using NVP.API.Nodes;

namespace OdaX.AcadHyperlinks 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadHyperlinks_Constructor : INode 
	{
		public OdaX.IAcadHyperlinks _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadHyperlinks;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadHyperlinks_ConstructorCast : INode 
	{
		public OdaX.IAcadHyperlinks _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadHyperlinks;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Returns an object at a given index in a collection.
	///</summary>
	[NodeInput("AcadHyperlinks", typeof(object))]
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
	[NodeInput("AcadHyperlinks", typeof(object))]
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	///<summary>
	///Returns the Application object.
	///</summary>
	[NodeInput("AcadHyperlinks", typeof(object))]
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	///<summary>
	///Creates an object and adds it to the collection.
	///</summary>
	[NodeInput("AcadHyperlinks", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("Description", typeof(System.Object))]
	[NodeInput("NamedLocation", typeof(System.Object))]
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Add(inputs[1],inputs[2],inputs[3]));

		}
	}
}
