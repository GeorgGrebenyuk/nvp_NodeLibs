using NVP.API.Nodes;

namespace OdaX.AcadPlotConfigurations 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadPlotConfigurations_Constructor : INode 
		{
		public OdaX.IAcadPlotConfigurations _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadPlotConfigurations;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadPlotConfigurations_ConstructorCast : INode 
		{
		public OdaX.IAcadPlotConfigurations _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadPlotConfigurations;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Returns an object at a given index in the collection.
		///</summary>
		[NodeInput("AcadPlotConfigurations", typeof(object))]
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
		[NodeInput("AcadPlotConfigurations", typeof(object))]
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
		[NodeInput("AcadPlotConfigurations", typeof(object))]
		[NodeInput("Name", typeof(System.String))]
		[NodeInput("ModelType", typeof(System.Object))]
		public class Add : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Add(inputs[1],inputs[2]));

			}
		}
}
