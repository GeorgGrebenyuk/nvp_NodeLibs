using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.PropertyDescription 
{

	[NVP_Manifest(
		Id = "79BF7F51-A8D0-47BB-8791-D38FF31A6572", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyDescription.PropertyDescription_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyDescription", 
		NodeName = "_PropertyDescription_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PropertyDescription_Constructor : INode 
	{
		public Renga.IPropertyDescription _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IPropertyDescription;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "29755DCF-DEF1-487F-8D4F-146C362B04F6", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyDescription.PropertyDescription_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyDescription", 
		NodeName = "_PropertyDescription_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PropertyDescription_ConstructorCast : INode 
	{
		public Renga.IPropertyDescription _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IPropertyDescription;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "B2592353-EAD0-436B-B124-536A63523587", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyDescription.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyDescription", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("PropertyDescription", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Id = "084185C0-4696-468E-BD82-CB3ED969D728", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyDescription.Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyDescription", 
		NodeName = "Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("PropertyDescription", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	[NVP_Manifest(
		Id = "A4015717-0E8C-417C-B1C9-C4936A9D193F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyDescription.SetEnumerationItems", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyDescription", 
		NodeName = "SetEnumerationItems", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("PropertyDescription", typeof(object))]

	///<summary>
	///
	///</summary>
	public class SetEnumerationItems : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetEnumerationItems();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9552BC12-5AFA-407D-9BFC-907CAD230E07", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyDescription.GetEnumerationItems", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyDescription", 
		NodeName = "GetEnumerationItems", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("PropertyDescription", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetEnumerationItems : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetEnumerationItems();
			return null;
		}
	}
}
