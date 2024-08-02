using NVP.API.Nodes;

namespace Renga.UI 
{
		[NodeInput("dynamic", typeof(object))]
		public class UI_Constructor : INode 
		{
		public Renga.IUI _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IUI;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class UI_ConstructorCast : INode 
		{
		public Renga.IUI _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IUI;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		public class CreateAction : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CreateAction);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		[NodeInput("Id", typeof(System.Object))]
		public class CreateActionWithId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CreateActionWithId(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		[NodeInput("Id", typeof(System.Object))]
		public class GetAction : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetAction(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		[NodeInput("pUIPanelExtension", typeof(System.Object))]
		public class AddExtensionToPrimaryPanel : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AddExtensionToPrimaryPanel(inputs[1]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		[NodeInput("pUIPanelExtension", typeof(System.Object))]
		[NodeInput("viewType_", typeof(System.Object))]
		public class AddExtensionToActionsPanel : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AddExtensionToActionsPanel(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		[NodeInput("pAction", typeof(System.Object))]
		[NodeInput("viewType_", typeof(System.Object))]
		public class AddToolButtonToActionsPanel : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AddToolButtonToActionsPanel(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		public class CreateUIPanelExtension : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CreateUIPanelExtension);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		[NodeInput("pDefaultAction", typeof(System.Object))]
		public class CreateSplitButton : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CreateSplitButton(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		public class CreateDropDownButton : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CreateDropDownButton);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		[NodeInput("pId", typeof(System.Object))]
		[NodeInput("pMmenu", typeof(System.Object))]
		[NodeInput("viewType_", typeof(System.Object))]
		[NodeInput("showCase_", typeof(System.Object))]
		public class AddContextMenu : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AddContextMenu(inputs[1],inputs[2],inputs[3],inputs[4]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		[NodeInput("icon_", typeof(System.Object))]
		[NodeInput("title_", typeof(System.String))]
		[NodeInput("text_", typeof(System.String))]
		public class ShowMessageBox : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ShowMessageBox(inputs[1],inputs[2],inputs[3]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		[NodeInput("title", typeof(System.String))]
		[NodeInput("defaultPath", typeof(System.String))]
		[NodeInput("filter", typeof(System.String))]
		public class ShowSaveFileDialog : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ShowSaveFileDialog(inputs[1],inputs[2],inputs[3]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		[NodeInput("title_", typeof(System.String))]
		[NodeInput("defaultPath", typeof(System.String))]
		[NodeInput("filter", typeof(System.String))]
		public class ShowOpenFileDialog : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ShowOpenFileDialog(inputs[1],inputs[2],inputs[3]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		public class CreateImage : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CreateImage);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		public class CreateContextMenu : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CreateContextMenu);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		[NodeInput("pAction", typeof(System.Object))]
		public class AddExportAction : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AddExportAction(inputs[1]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		[NodeInput("uniqueId_", typeof(System.String))]
		[NodeInput("pMmenu", typeof(System.Object))]
		[NodeInput("viewType_", typeof(System.Object))]
		[NodeInput("showCase_", typeof(System.Object))]
		public class AddContextMenuS : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AddContextMenuS(inputs[1],inputs[2],inputs[3],inputs[4]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		[NodeInput("Id", typeof(System.Object))]
		public class GetControlVisibility : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetControlVisibility(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		[NodeInput("Id", typeof(System.Object))]
		[NodeInput("isVisible", typeof(System.Object))]
		public class SetControlVisibility : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetControlVisibility(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		[NodeInput("Id", typeof(System.String))]
		public class GetControlVisibilityS : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetControlVisibilityS(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		[NodeInput("Id", typeof(System.String))]
		[NodeInput("isVisible", typeof(System.Object))]
		public class SetControlVisibilityS : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetControlVisibilityS(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		public class CreateToolButton : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CreateToolButton);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		[NodeInput("Id", typeof(System.Object))]
		public class CreateToolButtonWithId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CreateToolButtonWithId(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		[NodeInput("Id", typeof(System.Object))]
		[NodeInput("pDefaultAction", typeof(System.Object))]
		public class CreateSplitButtonWithId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CreateSplitButtonWithId(inputs[1],inputs[2]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		[NodeInput("Id", typeof(System.Object))]
		public class CreateDropDownButtonWithId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CreateDropDownButtonWithId(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		[NodeInput("Id", typeof(System.String))]
		public class CreateToolButtonWithIdS : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CreateToolButtonWithIdS(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		[NodeInput("Id", typeof(System.String))]
		[NodeInput("pDefaultAction", typeof(System.Object))]
		public class CreateSplitButtonWithIdS : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CreateSplitButtonWithIdS(inputs[1],inputs[2]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UI", typeof(object))]
		[NodeInput("Id", typeof(System.String))]
		public class CreateDropDownButtonWithIdS : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CreateDropDownButtonWithIdS(inputs[1]));

			}
		}
}
