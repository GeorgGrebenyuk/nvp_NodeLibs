using NVP.API.Nodes;

namespace nanoCAD.nanoCADPopupMenus 
{
		[NodeInput("dynamic", typeof(object))]
		public class nanoCADPopupMenus_Constructor : INode 
		{
		public nanoCAD.InanoCADPopupMenus _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as nanoCAD.InanoCADPopupMenus;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class nanoCADPopupMenus_ConstructorCast : INode 
		{
		public nanoCAD.InanoCADPopupMenus _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as nanoCAD.InanoCADPopupMenus;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Gets the member object at a given index in a collection, group, or selection set
		///</summary>
		[NodeInput("nanoCADPopupMenus", typeof(object))]
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
		[NodeInput("nanoCADPopupMenus", typeof(object))]
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
		[NodeInput("nanoCADPopupMenus", typeof(object))]
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
		[NodeInput("nanoCADPopupMenus", typeof(object))]
		public class Parent : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Parent);

			}
		}


		///<summary>
		///Creates a member object and adds it to the appropriate collection
		///</summary>
		[NodeInput("nanoCADPopupMenus", typeof(object))]
		[NodeInput("MenuName", typeof(System.String))]
		public class Add : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Add(inputs[1]));

			}
		}


		///<summary>
		///Inserts a menu into the menu bar
		///</summary>
		[NodeInput("nanoCADPopupMenus", typeof(object))]
		[NodeInput("MenuName", typeof(System.String))]
		[NodeInput("Index", typeof(System.Object))]
		public class InsertMenuInMenuBar : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.InsertMenuInMenuBar(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Removes the popup menu, as specified from the collection, from the menu bar
		///</summary>
		[NodeInput("nanoCADPopupMenus", typeof(object))]
		[NodeInput("Index", typeof(System.Object))]
		public class RemoveMenuFromMenuBar : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.RemoveMenuFromMenuBar(inputs[1]);
				return null;
			}
		}
}
