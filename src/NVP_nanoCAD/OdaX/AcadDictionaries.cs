using NVP.API.Nodes;

namespace OdaX.AcadDictionaries 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadDictionaries_Constructor : INode 
		{
		public OdaX.IAcadDictionaries _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadDictionaries;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadDictionaries_ConstructorCast : INode 
		{
		public OdaX.IAcadDictionaries _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadDictionaries;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Returns an object in a dictionary using the index associated with the object.
		///</summary>
		[NodeInput("AcadDictionaries", typeof(object))]
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
		///Returns the number of objects in a dictionary.
		///</summary>
		[NodeInput("AcadDictionaries", typeof(object))]
		public class Count : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Count);

			}
		}


		///<summary>
		///Creates an object and adds it to the appropriate collection, block, dictionary, group, or selection set.
		///</summary>
		[NodeInput("AcadDictionaries", typeof(object))]
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
