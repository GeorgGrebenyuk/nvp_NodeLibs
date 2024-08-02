using NVP.API.Nodes;

namespace nanoCAD.nanoCADDocuments 
{
		[NodeInput("dynamic", typeof(object))]
		public class nanoCADDocuments_Constructor : INode 
		{
		public nanoCAD.InanoCADDocuments _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as nanoCAD.InanoCADDocuments;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class nanoCADDocuments_ConstructorCast : INode 
		{
		public nanoCAD.InanoCADDocuments _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as nanoCAD.InanoCADDocuments;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Gets the member object at a given index in a collection, group, or selection set
		///</summary>
		[NodeInput("nanoCADDocuments", typeof(object))]
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
		[NodeInput("nanoCADDocuments", typeof(object))]
		public class Count : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Count);

			}
		}


		///<summary>
		///Gets the Application object
		///</summary>
		[NodeInput("nanoCADDocuments", typeof(object))]
		public class Application : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Application);

			}
		}


		///<summary>
		///Creates a member object and adds it to the appropriate collection
		///</summary>
		[NodeInput("nanoCADDocuments", typeof(object))]
		[NodeInput("TemplateName", typeof(System.Object))]
		public class Add : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Add(inputs[1]));

			}
		}


		///<summary>
		///DWG) and makes it the active document
		///</summary>
		[NodeInput("nanoCADDocuments", typeof(object))]
		[NodeInput("Name", typeof(System.String))]
		[NodeInput("ReadOnly", typeof(System.Object))]
		[NodeInput("Password", typeof(System.Object))]
		public class Open : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Open(inputs[1],inputs[2],inputs[3]));

			}
		}


		///<summary>
		///Closes all open documents and empties the documents collection.
		///</summary>
		[NodeInput("nanoCADDocuments", typeof(object))]
		public class Close : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Close();
				return null;
			}
		}
}
