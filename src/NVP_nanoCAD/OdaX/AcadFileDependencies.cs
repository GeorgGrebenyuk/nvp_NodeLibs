using NVP.API.Nodes;

namespace OdaX.AcadFileDependencies 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadFileDependencies_Constructor : INode 
		{
		public OdaX.IAcadFileDependencies _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadFileDependencies;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadFileDependencies_ConstructorCast : INode 
		{
		public OdaX.IAcadFileDependencies _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadFileDependencies;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Returns an object at a given index in the collection.
		///</summary>
		[NodeInput("AcadFileDependencies", typeof(object))]
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
		///Returns the Application object.
		///</summary>
		[NodeInput("AcadFileDependencies", typeof(object))]
		public class Application : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Application);

			}
		}


		///<summary>
		///Returns the number of items in the collection.
		///</summary>
		[NodeInput("AcadFileDependencies", typeof(object))]
		public class Count : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Count);

			}
		}


		///<summary>
		///Creates an entry in the File Dependencis list.
		///</summary>
		[NodeInput("AcadFileDependencies", typeof(object))]
		[NodeInput("Feature", typeof(System.String))]
		[NodeInput("FullFileName", typeof(System.String))]
		[NodeInput("AffectsGraphics", typeof(System.Object))]
		[NodeInput("noIncrement", typeof(System.Object))]
		public class CreateEntry : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CreateEntry(inputs[1],inputs[2],inputs[3],inputs[4]));

			}
		}


		///<summary>
		///Returns the index in the collection of a specified entry.
		///</summary>
		[NodeInput("AcadFileDependencies", typeof(object))]
		[NodeInput("Feature", typeof(System.String))]
		[NodeInput("FullFileName", typeof(System.String))]
		public class IndexOf : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IndexOf(inputs[1],inputs[2]));

			}
		}


		///<summary>
		///Removes an entry from the File Dependencies list.
		///</summary>
		[NodeInput("AcadFileDependencies", typeof(object))]
		[NodeInput("Index", typeof(System.Object))]
		[NodeInput("forceRemove", typeof(System.Object))]
		public class RemoveEntry : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.RemoveEntry(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Updates an entry in the File Dependencies list.
		///</summary>
		[NodeInput("AcadFileDependencies", typeof(object))]
		[NodeInput("Index", typeof(System.Object))]
		public class UpdateEntry : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.UpdateEntry(inputs[1]);
				return null;
			}
		}
}
