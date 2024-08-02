using NVP.API.Nodes;

namespace nanoCAD.nanoCADPopupMenuItem 
{
		[NodeInput("dynamic", typeof(object))]
		public class nanoCADPopupMenuItem_Constructor : INode 
		{
		public nanoCAD.InanoCADPopupMenuItem _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as nanoCAD.InanoCADPopupMenuItem;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class nanoCADPopupMenuItem_ConstructorCast : INode 
		{
		public nanoCAD.InanoCADPopupMenuItem _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as nanoCAD.InanoCADPopupMenuItem;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Gets the Application object
		///</summary>
		[NodeInput("nanoCADPopupMenuItem", typeof(object))]
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
		[NodeInput("nanoCADPopupMenuItem", typeof(object))]
		public class Parent : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Parent);

			}
		}


		///<summary>
		///Specifies the content and formatting of menu items as they appear to the user
		///</summary>
		[NodeInput("nanoCADPopupMenuItem", typeof(object))]
		public class Label : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Label);

			}
		}


		///<summary>
		///Specifies the content and formatting of menu items as they appear to the user
		///</summary>
		[NodeInput("nanoCADPopupMenuItem", typeof(object))]
		[NodeInput("bstrLabel", typeof(System.String))]
		public class Set_Label : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Label = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the tag string of the object
		///</summary>
		[NodeInput("nanoCADPopupMenuItem", typeof(object))]
		public class TagString : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TagString);

			}
		}


		///<summary>
		///Specifies the tag string of the object
		///</summary>
		[NodeInput("nanoCADPopupMenuItem", typeof(object))]
		[NodeInput("bstrTag", typeof(System.String))]
		public class Set_TagString : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TagString = inputs[1];
				return null;
			}
		}


		///<summary>
		///Enables the popup menu or toolbar item
		///</summary>
		[NodeInput("nanoCADPopupMenuItem", typeof(object))]
		public class Enable : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Enable);

			}
		}


		///<summary>
		///Enables the popup menu or toolbar item
		///</summary>
		[NodeInput("nanoCADPopupMenuItem", typeof(object))]
		[NodeInput("bFlag", typeof(System.Object))]
		public class Set_Enable : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Enable = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the check status for the popup menu item
		///</summary>
		[NodeInput("nanoCADPopupMenuItem", typeof(object))]
		public class Check : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Check);

			}
		}


		///<summary>
		///Specifies the check status for the popup menu item
		///</summary>
		[NodeInput("nanoCADPopupMenuItem", typeof(object))]
		[NodeInput("bFlag", typeof(System.Object))]
		public class Set_Check : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Check = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies type of a Leader, MenuGroup, PopupMenuItem, ToolbarItem, Polyline, or PolygonMesh object
		///</summary>
		[NodeInput("nanoCADPopupMenuItem", typeof(object))]
		public class Type : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Type);

			}
		}


		///<summary>
		///Gets the popup menu associated with a sub menu
		///</summary>
		[NodeInput("nanoCADPopupMenuItem", typeof(object))]
		public class SubMenu : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SubMenu);

			}
		}


		///<summary>
		///Specifies the macro for the menu or toolbar item
		///</summary>
		[NodeInput("nanoCADPopupMenuItem", typeof(object))]
		public class Macro : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Macro);

			}
		}


		///<summary>
		///Specifies the macro for the menu or toolbar item
		///</summary>
		[NodeInput("nanoCADPopupMenuItem", typeof(object))]
		[NodeInput("bstrMacro", typeof(System.String))]
		public class Set_Macro : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Macro = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the index of the menu or toolbar item
		///</summary>
		[NodeInput("nanoCADPopupMenuItem", typeof(object))]
		public class Index : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Index);

			}
		}


		///<summary>
		///Gets the text that the user sees displayed for the application or a menu item
		///</summary>
		[NodeInput("nanoCADPopupMenuItem", typeof(object))]
		public class Caption : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Caption);

			}
		}


		///<summary>
		///Specifies the help string for the toolbar, toolbar item, or menu item
		///</summary>
		[NodeInput("nanoCADPopupMenuItem", typeof(object))]
		public class HelpString : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.HelpString);

			}
		}


		///<summary>
		///Specifies the help string for the toolbar, toolbar item, or menu item
		///</summary>
		[NodeInput("nanoCADPopupMenuItem", typeof(object))]
		[NodeInput("bstrHelp", typeof(System.String))]
		public class Set_HelpString : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.HelpString = inputs[1];
				return null;
			}
		}


		///<summary>
		///Deletes a specified object
		///</summary>
		[NodeInput("nanoCADPopupMenuItem", typeof(object))]
		public class Delete : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Delete();
				return null;
			}
		}


		///<summary>
		///Specifies the submenu level for the menu item
		///</summary>
		[NodeInput("nanoCADPopupMenuItem", typeof(object))]
		public class EndSubMenuLevel : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.EndSubMenuLevel);

			}
		}


		///<summary>
		///Specifies the submenu level for the menu item
		///</summary>
		[NodeInput("nanoCADPopupMenuItem", typeof(object))]
		[NodeInput("level", typeof(System.Int32))]
		public class Set_EndSubMenuLevel : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.EndSubMenuLevel = inputs[1];
				return null;
			}
		}
}
