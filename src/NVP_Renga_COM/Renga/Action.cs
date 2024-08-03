using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Action 
{

	[NVP_Manifest(
		Id = "72163192-4DCE-4E4D-819C-5BC527215FC3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Action.Action_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Action", 
		NodeName = "_Action_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Action_Constructor : INode 
	{
		public Renga.IAction _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IAction;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "FC9C22B3-1EE2-4B7F-B6F4-D3FE374E69AE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Action.Action_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Action", 
		NodeName = "_Action_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Action_ConstructorCast : INode 
	{
		public Renga.IAction _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IAction;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "BBE3CF73-4E7B-4CC6-9755-22DACFEDC0B8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Action.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Action", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Action", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}


	[NVP_Manifest(
		Id = "A61F910F-8AB1-4D48-BE37-6B770DF164FF", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Action.DisplayName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Action", 
		NodeName = "DisplayName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Action", typeof(object))]

	///<summary>
	///
	///</summary>
	public class DisplayName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplayName);

		}
	}


	[NVP_Manifest(
		Id = "D1C77670-6304-43A7-B00B-431907B8940C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Action.Set_DisplayName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Action", 
		NodeName = "Set_DisplayName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Action", typeof(object))]
	[NodeInput("pName", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_DisplayName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DisplayName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "08E9652F-2F7D-40B0-A5CB-4A0CF307BC13", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Action.ToolTip", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Action", 
		NodeName = "ToolTip", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Action", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ToolTip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToolTip);

		}
	}


	[NVP_Manifest(
		Id = "9781A466-30F4-44C8-92C7-126ED2E77857", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Action.Set_ToolTip", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Action", 
		NodeName = "Set_ToolTip", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Action", typeof(object))]
	[NodeInput("pToolTip", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_ToolTip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToolTip = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "22CA6828-9E2A-4B66-9B60-BACA212681D0", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Action.Enabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Action", 
		NodeName = "Enabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Action", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Enabled);

		}
	}


	[NVP_Manifest(
		Id = "5B9E941F-01A2-44A4-828F-838784D67A43", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Action.Set_Enabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Action", 
		NodeName = "Set_Enabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Action", typeof(object))]
	[NodeInput("Enabled", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Enabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5D19B7A1-4D07-4327-B668-D2A173CB0313", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Action.Checkable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Action", 
		NodeName = "Checkable", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Action", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Checkable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Checkable);

		}
	}


	[NVP_Manifest(
		Id = "60F4CEAE-23F4-4B5F-82E6-D83D7F082D0E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Action.Set_Checkable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Action", 
		NodeName = "Set_Checkable", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Action", typeof(object))]
	[NodeInput("pCheckable", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Checkable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Checkable = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "78F36BB7-5F40-42D4-AE89-F33D7DEFD605", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Action.Checked", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Action", 
		NodeName = "Checked", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Action", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Checked : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Checked);

		}
	}


	[NVP_Manifest(
		Id = "E9E5CC7F-FBFA-4310-A91C-0680BAADFA88", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Action.Set_Checked", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Action", 
		NodeName = "Set_Checked", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Action", typeof(object))]
	[NodeInput("pChecked", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Checked : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Checked = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5B7C23C9-5417-4F99-A7D0-147D0EE8A0DA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Action.Set_Icon", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Action", 
		NodeName = "Set_Icon", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Action", typeof(object))]
	[NodeInput("rhs", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Icon : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Icon = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C0B89E7A-C1A4-485E-AFD9-D79E8C97DAEF", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Action.Visible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Action", 
		NodeName = "Visible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Action", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Visible);

		}
	}


	[NVP_Manifest(
		Id = "E606AE43-4F81-4B7F-BCC8-C81F9290DF59", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Action.Set_Visible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Action", 
		NodeName = "Set_Visible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Action", typeof(object))]
	[NodeInput("pVisible", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Visible = inputs[1].Value;
			return null;
		}
	}
}
