using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.DropDownButton 
{

	[NVP_Manifest(
		Id = "FB3A1D7E-D73B-42A3-9CA5-B96AADB9270F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DropDownButton.DropDownButton_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DropDownButton", 
		NodeName = "_DropDownButton_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class DropDownButton_Constructor : INode 
	{
		public Renga.IDropDownButton _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IDropDownButton;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "3C30F8BA-5702-4AE9-93FD-06D49224D47F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DropDownButton.DropDownButton_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DropDownButton", 
		NodeName = "_DropDownButton_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class DropDownButton_ConstructorCast : INode 
	{
		public Renga.IDropDownButton _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IDropDownButton;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "3627D23C-696D-40BB-86DC-A486365081DE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DropDownButton.AddAction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DropDownButton", 
		NodeName = "AddAction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("DropDownButton", typeof(object))]
	[NodeInput("pAction", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AddAction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddAction(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "288296E7-CD30-4122-B16E-5A0B533CA2F5", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DropDownButton.AddSeparator", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DropDownButton", 
		NodeName = "AddSeparator", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("DropDownButton", typeof(object))]

	///<summary>
	///
	///</summary>
	public class AddSeparator : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddSeparator();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D8C3AE9B-C84F-4709-8203-C540E2879BF4", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DropDownButton.Set_Icon", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DropDownButton", 
		NodeName = "Set_Icon", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("DropDownButton", typeof(object))]
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
		Id = "B2AFA0AA-E21D-467E-8A6A-0C600C8BF598", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DropDownButton.Set_ToolTip", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DropDownButton", 
		NodeName = "Set_ToolTip", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("DropDownButton", typeof(object))]
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
		Id = "F88FD59F-5511-454E-8D47-F624E8F429EB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DropDownButton.ToolTip", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DropDownButton", 
		NodeName = "ToolTip", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("DropDownButton", typeof(object))]

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
		Id = "4C1B235C-EC22-4038-B69F-F2E8F3059F27", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DropDownButton.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DropDownButton", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("DropDownButton", typeof(object))]

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
		Id = "48CEF2CB-0C8A-4071-9C4A-A2E4A700D1FE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DropDownButton.IdS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DropDownButton", 
		NodeName = "IdS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("DropDownButton", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IdS);

		}
	}
}
