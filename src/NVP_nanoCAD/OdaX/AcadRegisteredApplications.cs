using NVP.API.Nodes;

namespace OdaX.AcadRegisteredApplications 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadRegisteredApplications_Constructor : INode 
		{
		public OdaX.IAcadRegisteredApplications _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadRegisteredApplications;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadRegisteredApplications_ConstructorCast : INode 
		{
		public OdaX.IAcadRegisteredApplications _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadRegisteredApplications;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Returns an object at a given index in the collection.
		///</summary>
		[NodeInput("AcadRegisteredApplications", typeof(object))]
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
		///Returns the number of objects in the collection.
		///</summary>
		[NodeInput("AcadRegisteredApplications", typeof(object))]
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
		[NodeInput("AcadRegisteredApplications", typeof(object))]
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
