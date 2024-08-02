using NVP.API.Nodes;

namespace nanoCAD.nanoCADPopupMenu 
{
		[NodeInput("dynamic", typeof(object))]
		public class nanoCADPopupMenu_Constructor : INode 
		{
		public nanoCAD.InanoCADPopupMenu _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as nanoCAD.InanoCADPopupMenu;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class nanoCADPopupMenu_ConstructorCast : INode 
		{
		public nanoCAD.InanoCADPopupMenu _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as nanoCAD.InanoCADPopupMenu;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Gets the member object at a given index in a collection, group, or selection set
		///</summary>
		[NodeInput("nanoCADPopupMenu", typeof(object))]
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
		[NodeInput("nanoCADPopupMenu", typeof(object))]
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
		[NodeInput("nanoCADPopupMenu", typeof(object))]
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
		[NodeInput("nanoCADPopupMenu", typeof(object))]
		public class Parent : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Parent);

			}
		}


		///<summary>
		///Specifies the name of the object
		///</summary>
		[NodeInput("nanoCADPopupMenu", typeof(object))]
		public class Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Name);

			}
		}


		///<summary>
		///Specifies the name of the object
		///</summary>
		[NodeInput("nanoCADPopupMenu", typeof(object))]
		[NodeInput("bstrName", typeof(System.String))]
		public class Set_Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Name = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the name of the object
		///</summary>
		[NodeInput("nanoCADPopupMenu", typeof(object))]
		public class NameNoMnemonic : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.NameNoMnemonic);

			}
		}


		///<summary>
		///Determines if the specified popup menu is the shortcut menu
		///</summary>
		[NodeInput("nanoCADPopupMenu", typeof(object))]
		public class ShortcutMenu : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ShortcutMenu);

			}
		}


		///<summary>
		///Determines if the specified popup menu is on the menu bar
		///</summary>
		[NodeInput("nanoCADPopupMenu", typeof(object))]
		public class OnMenuBar : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.OnMenuBar);

			}
		}


		///<summary>
		///Adds a popup menu item to a popup menu
		///</summary>
		[NodeInput("nanoCADPopupMenu", typeof(object))]
		[NodeInput("Index", typeof(System.Object))]
		[NodeInput("Label", typeof(System.String))]
		[NodeInput("Macro", typeof(System.String))]
		public class AddMenuItem : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AddMenuItem(inputs[1],inputs[2],inputs[3]));

			}
		}


		///<summary>
		///Adds a submenu to an existing menu
		///</summary>
		[NodeInput("nanoCADPopupMenu", typeof(object))]
		[NodeInput("Index", typeof(System.Object))]
		[NodeInput("Label", typeof(System.String))]
		public class AddSubMenu : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AddSubMenu(inputs[1],inputs[2]));

			}
		}


		///<summary>
		///Adds a separator to an existing menu or toolbar
		///</summary>
		[NodeInput("nanoCADPopupMenu", typeof(object))]
		[NodeInput("Index", typeof(System.Object))]
		public class AddSeparator : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AddSeparator(inputs[1]));

			}
		}


		///<summary>
		///Inserts the popup menu into the menu bar at a specified location
		///</summary>
		[NodeInput("nanoCADPopupMenu", typeof(object))]
		[NodeInput("Index", typeof(System.Object))]
		public class InsertInMenuBar : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.InsertInMenuBar(inputs[1]);
				return null;
			}
		}


		///<summary>
		///Removes the popup menu from the menu bar
		///</summary>
		[NodeInput("nanoCADPopupMenu", typeof(object))]
		public class RemoveFromMenuBar : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.RemoveFromMenuBar();
				return null;
			}
		}


		///<summary>
		///Specifies the tag string of the object
		///</summary>
		[NodeInput("nanoCADPopupMenu", typeof(object))]
		public class TagString : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TagString);

			}
		}
}
