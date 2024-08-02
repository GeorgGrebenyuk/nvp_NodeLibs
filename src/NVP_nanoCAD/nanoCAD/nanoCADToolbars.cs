using NVP.API.Nodes;

namespace nanoCAD.nanoCADToolbars 
{
		[NodeInput("dynamic", typeof(object))]
		public class nanoCADToolbars_Constructor : INode 
		{
		public nanoCAD.InanoCADToolbars _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as nanoCAD.InanoCADToolbars;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class nanoCADToolbars_ConstructorCast : INode 
		{
		public nanoCAD.InanoCADToolbars _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as nanoCAD.InanoCADToolbars;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Gets the member object at a given index in a collection, group, or selection set
		///</summary>
		[NodeInput("nanoCADToolbars", typeof(object))]
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
		[NodeInput("nanoCADToolbars", typeof(object))]
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
		[NodeInput("nanoCADToolbars", typeof(object))]
		public class Application : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Application);

			}
		}


		///<summary>
		///Gets the parent of the object
		///</summary>
		[NodeInput("nanoCADToolbars", typeof(object))]
		public class Parent : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Parent);

			}
		}


		///<summary>
		///Specifies if the toolbar button is large or small
		///</summary>
		[NodeInput("nanoCADToolbars", typeof(object))]
		public class LargeButtons : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LargeButtons);

			}
		}


		///<summary>
		///Specifies if the toolbar button is large or small
		///</summary>
		[NodeInput("nanoCADToolbars", typeof(object))]
		[NodeInput("bFlag", typeof(System.Object))]
		public class Set_LargeButtons : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LargeButtons = inputs[1];
				return null;
			}
		}


		///<summary>
		///Creates a member object and adds it to the appropriate collection
		///</summary>
		[NodeInput("nanoCADToolbars", typeof(object))]
		[NodeInput("ToolbarName", typeof(System.String))]
		public class Add : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Add(inputs[1]));

			}
		}
}
