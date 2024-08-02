using NVP.API.Nodes;

namespace nanoCAD.nanoCADServices 
{
		[NodeInput("dynamic", typeof(object))]
		public class nanoCADServices_Constructor : INode 
		{
		public nanoCAD.InanoCADServices _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as nanoCAD.InanoCADServices;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class nanoCADServices_ConstructorCast : INode 
		{
		public nanoCAD.InanoCADServices _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as nanoCAD.InanoCADServices;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Gets the member object at a given index in a collection, group, or selection set
		///</summary>
		[NodeInput("nanoCADServices", typeof(object))]
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
		[NodeInput("nanoCADServices", typeof(object))]
		public class Count : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Count);

			}
		}


		///<summary>
		///Adds new service to the appropriate collection
		///</summary>
		[NodeInput("nanoCADServices", typeof(object))]
		[NodeInput("Name", typeof(System.String))]
		[NodeInput("service", typeof(System.Object))]
		public class Add : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Add(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Removes services from collection
		///</summary>
		[NodeInput("nanoCADServices", typeof(object))]
		[NodeInput("Name", typeof(System.String))]
		public class Remove : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Remove(inputs[1]);
				return null;
			}
		}


		///<summary>
		///Removes all services from collection
		///</summary>
		[NodeInput("nanoCADServices", typeof(object))]
		public class RemoveAll : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.RemoveAll();
				return null;
			}
		}


		///<summary>
		///Gets the Application object
		///</summary>
		[NodeInput("nanoCADServices", typeof(object))]
		public class Application : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Application);

			}
		}
}
