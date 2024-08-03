using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.UI 
{

	[NVP_Manifest(
		Id = "CEF0B172-5D04-43C8-99F4-012A6FEDEFF9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.UI_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "_UI_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		Id = "10F0A44D-591A-4B18-8ED8-AA98F49478E4", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.UI_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "_UI_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Id = "24D9E8AB-AF2A-4EC9-87ED-5ED3D842925B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.CreateAction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "CreateAction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("UI", typeof(object))]

	///<summary>
	///
	///</summary>
	public class CreateAction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateAction);

		}
	}


	[NVP_Manifest(
		Id = "2658C282-ACD3-4F98-A669-191309060B6D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.CreateActionWithId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "CreateActionWithId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("UI", typeof(object))]
	[NodeInput("Id", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class CreateActionWithId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateActionWithId(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "38AE6C58-135B-48E2-9D19-D82149F31E9C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.GetAction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "GetAction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("UI", typeof(object))]
	[NodeInput("Id", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetAction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAction(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "7B43AE96-E6C2-4C85-BB62-32AE97416F6B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.AddExtensionToPrimaryPanel", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "AddExtensionToPrimaryPanel", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("UI", typeof(object))]
	[NodeInput("pUIPanelExtension", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AddExtensionToPrimaryPanel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddExtensionToPrimaryPanel(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4C11D85D-FDC8-4386-A85C-6C823977278B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.AddExtensionToActionsPanel", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "AddExtensionToActionsPanel", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("UI", typeof(object))]
	[NodeInput("pUIPanelExtension", typeof(System.Object))]
	[NodeInput("Renga.ViewType", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AddExtensionToActionsPanel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddExtensionToActionsPanel(inputs[1].Value,((Renga.ViewType)inputs[2].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4260B715-9B15-4878-88C2-A3C622808A3A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.AddToolButtonToActionsPanel", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "AddToolButtonToActionsPanel", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("UI", typeof(object))]
	[NodeInput("pAction", typeof(System.Object))]
	[NodeInput("Renga.ViewType", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AddToolButtonToActionsPanel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddToolButtonToActionsPanel(inputs[1].Value,((Renga.ViewType)inputs[2].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BD180D7A-ED5B-4A39-B86D-B9808FF84669", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.CreateUIPanelExtension", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "CreateUIPanelExtension", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("UI", typeof(object))]

	///<summary>
	///
	///</summary>
	public class CreateUIPanelExtension : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateUIPanelExtension);

		}
	}


	[NVP_Manifest(
		Id = "9A2973B4-9370-4E02-99A3-1356D2365E0D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.CreateSplitButton", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "CreateSplitButton", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("UI", typeof(object))]
	[NodeInput("pDefaultAction", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class CreateSplitButton : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateSplitButton(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "03F25B5B-1E65-40E4-AF8B-CD77DFC136DF", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.CreateDropDownButton", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "CreateDropDownButton", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("UI", typeof(object))]

	///<summary>
	///
	///</summary>
	public class CreateDropDownButton : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateDropDownButton);

		}
	}


	[NVP_Manifest(
		Id = "1CE60817-2E7C-438D-84B6-189391684E77", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.AddContextMenu", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "AddContextMenu", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("UI", typeof(object))]
	[NodeInput("pId", typeof(System.Object))]
	[NodeInput("pMmenu", typeof(System.Object))]
	[NodeInput("Renga.ViewType", typeof(System.Object))]
	[NodeInput("Renga.ContextMenuShowCase", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AddContextMenu : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddContextMenu(inputs[1].Value,inputs[2].Value,((Renga.ViewType)inputs[3].Value),((Renga.ContextMenuShowCase)inputs[4].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "57EF394B-0550-482D-8CFF-59EEC336FB02", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.ShowMessageBox", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "ShowMessageBox", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("UI", typeof(object))]
	[NodeInput("Renga.MessageIcon", typeof(System.Object))]
	[NodeInput("title_", typeof(System.String))]
	[NodeInput("text_", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class ShowMessageBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShowMessageBox(((Renga.MessageIcon)inputs[1].Value),inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "02E67468-E5C4-439C-BAA9-041215F95084", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.ShowSaveFileDialog", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "ShowSaveFileDialog", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("UI", typeof(object))]
	[NodeInput("title", typeof(System.String))]
	[NodeInput("defaultPath", typeof(System.String))]
	[NodeInput("filter", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class ShowSaveFileDialog : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowSaveFileDialog(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "80ED65CD-681D-48E8-B964-EDD2329E6368", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.ShowOpenFileDialog", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "ShowOpenFileDialog", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("UI", typeof(object))]
	[NodeInput("title_", typeof(System.String))]
	[NodeInput("defaultPath", typeof(System.String))]
	[NodeInput("filter", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class ShowOpenFileDialog : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowOpenFileDialog(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "F80F8CA6-5801-4A1A-916B-98462E1DECBA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.CreateImage", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "CreateImage", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("UI", typeof(object))]

	///<summary>
	///
	///</summary>
	public class CreateImage : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateImage);

		}
	}


	[NVP_Manifest(
		Id = "1C3544C7-57F7-427B-BB4D-9F6D104EB92E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.CreateContextMenu", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "CreateContextMenu", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("UI", typeof(object))]

	///<summary>
	///
	///</summary>
	public class CreateContextMenu : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateContextMenu);

		}
	}


	[NVP_Manifest(
		Id = "626B6353-6262-4AC2-847F-B8F29E8EB49F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.AddExportAction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "AddExportAction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("UI", typeof(object))]
	[NodeInput("pAction", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AddExportAction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddExportAction(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6482E376-2DC3-4880-B5A4-1BF32AC11DED", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.AddContextMenuS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "AddContextMenuS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("UI", typeof(object))]
	[NodeInput("uniqueId_", typeof(System.String))]
	[NodeInput("pMmenu", typeof(System.Object))]
	[NodeInput("Renga.ViewType", typeof(System.Object))]
	[NodeInput("Renga.ContextMenuShowCase", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AddContextMenuS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddContextMenuS(inputs[1].Value,inputs[2].Value,((Renga.ViewType)inputs[3].Value),((Renga.ContextMenuShowCase)inputs[4].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1BCB6148-4EE7-4F01-B19A-46D6B2725858", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.GetControlVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "GetControlVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("UI", typeof(object))]
	[NodeInput("Id", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetControlVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetControlVisibility(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "F9FF7A31-5946-44B5-9DD6-7FC46DE42A26", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.SetControlVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "SetControlVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("UI", typeof(object))]
	[NodeInput("Id", typeof(System.Object))]
	[NodeInput("isVisible", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SetControlVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetControlVisibility(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "346BF72A-F4AA-41BC-AC99-BD5CF44B408D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.GetControlVisibilityS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "GetControlVisibilityS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("UI", typeof(object))]
	[NodeInput("Id", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class GetControlVisibilityS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetControlVisibilityS(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "7F2B0F57-C2E9-44F5-A5A6-E1498FD73D6D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.SetControlVisibilityS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "SetControlVisibilityS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("UI", typeof(object))]
	[NodeInput("Id", typeof(System.String))]
	[NodeInput("isVisible", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SetControlVisibilityS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetControlVisibilityS(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8DC67229-4B93-4A0F-91A1-9EFCB79506EB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.CreateToolButton", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "CreateToolButton", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("UI", typeof(object))]

	///<summary>
	///
	///</summary>
	public class CreateToolButton : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateToolButton);

		}
	}


	[NVP_Manifest(
		Id = "56F68154-FC42-4952-8731-D953EEB46B45", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.CreateToolButtonWithId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "CreateToolButtonWithId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("UI", typeof(object))]
	[NodeInput("Id", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class CreateToolButtonWithId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateToolButtonWithId(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "018E86F8-25ED-44DD-B1F1-2F17E2AFA42D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.CreateSplitButtonWithId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "CreateSplitButtonWithId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("UI", typeof(object))]
	[NodeInput("Id", typeof(System.Object))]
	[NodeInput("pDefaultAction", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class CreateSplitButtonWithId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateSplitButtonWithId(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "3B8BA1A9-65D6-483D-9C82-33AE99245711", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.CreateDropDownButtonWithId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "CreateDropDownButtonWithId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("UI", typeof(object))]
	[NodeInput("Id", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class CreateDropDownButtonWithId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateDropDownButtonWithId(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "815489B6-0DE2-4424-809A-842B5BC0D712", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.CreateToolButtonWithIdS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "CreateToolButtonWithIdS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("UI", typeof(object))]
	[NodeInput("Id", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class CreateToolButtonWithIdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateToolButtonWithIdS(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "9309AE22-8D03-481B-96C1-19E78EFC68C3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.CreateSplitButtonWithIdS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "CreateSplitButtonWithIdS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("UI", typeof(object))]
	[NodeInput("Id", typeof(System.String))]
	[NodeInput("pDefaultAction", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class CreateSplitButtonWithIdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateSplitButtonWithIdS(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "B2B8D382-3B14-4284-93DB-9EB7D2E5E885", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UI.CreateDropDownButtonWithIdS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UI", 
		NodeName = "CreateDropDownButtonWithIdS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("UI", typeof(object))]
	[NodeInput("Id", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class CreateDropDownButtonWithIdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateDropDownButtonWithIdS(inputs[1].Value));

		}
	}
}
