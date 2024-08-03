using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a container for section geometry settings
///</summary>
namespace OdaX.AcadSectionSettings 
{

	[NVP_Manifest(
		Id = "086D0BDF-E9C1-4842-ABE9-06B41A131BFB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionSettings.AcadSectionSettings_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionSettings", 
		NodeName = "_AcadSectionSettings_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSectionSettings_Constructor : INode 
	{
		public OdaX.IAcadSectionSettings _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSectionSettings;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "5C97015B-C7E6-403C-8785-2DB3F6B24AAC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionSettings.AcadSectionSettings_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionSettings", 
		NodeName = "_AcadSectionSettings_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSectionSettings_ConstructorCast : INode 
	{
		public OdaX.IAcadSectionSettings _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSectionSettings;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "76CDD628-D20D-49C1-B36A-D6D396DEC1CD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionSettings.CurrentSectionType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionSettings", 
		NodeName = "CurrentSectionType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the type for a section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionSettings", typeof(object))]

	///<summary>
	///Specifies or returns the type for a section.
	///</summary>
	public class CurrentSectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurrentSectionType);

		}
	}


	[NVP_Manifest(
		Id = "46937CEA-B9B2-45C0-9AB3-A81DBB3D279E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionSettings.Set_CurrentSectionType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionSettings", 
		NodeName = "Set_CurrentSectionType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the type for a section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionSettings", typeof(object))]
	[NodeInput("OdaX.AcSectionType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the type for a section.
	///</summary>
	public class Set_CurrentSectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurrentSectionType = ((OdaX.AcSectionType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8C2D6EE7-BD8A-4DEE-9684-C2C2C3A836AC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionSettings.GetSectionTypeSettings", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionSettings", 
		NodeName = "GetSectionTypeSettings", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the type for a Section Settings object.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionSettings", typeof(object))]
	[NodeInput("OdaX.AcSectionType", typeof(System.Object))]

	///<summary>
	///Returns the type for a Section Settings object.
	///</summary>
	public class GetSectionTypeSettings : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetSectionTypeSettings(((OdaX.AcSectionType)inputs[1].Value)));

		}
	}
}
