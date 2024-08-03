using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface for controls which property is constrained when editing other property values
///</summary>
namespace OdaX.AcadSectionManager 
{

	[NVP_Manifest(
		Id = "EC7D5296-D925-4148-BD41-488F5C090613", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionManager.AcadSectionManager_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionManager", 
		NodeName = "_AcadSectionManager_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSectionManager_Constructor : INode 
	{
		public OdaX.IAcadSectionManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSectionManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "4AA6F603-A25F-4CA7-9C05-5FBAC0BADBD5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionManager.AcadSectionManager_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionManager", 
		NodeName = "_AcadSectionManager_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSectionManager_ConstructorCast : INode 
	{
		public OdaX.IAcadSectionManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSectionManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "31EBB901-D6F0-4B1B-A642-B08317DB6AC3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionManager.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionManager", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns an object at a given index in the collection of sections.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionManager", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Returns an object at a given index in the collection of sections.
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "5846FF8C-3D5E-40F0-860F-51DC793D8D7C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionManager.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionManager", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the number of items in the collection of sections.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionManager", typeof(object))]

	///<summary>
	///Returns the number of items in the collection of sections.
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Id = "D9FEFBF0-0257-4CBA-8E1E-80708E1BEB6B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionManager.GetLiveSection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionManager", 
		NodeName = "GetLiveSection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the current live section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionManager", typeof(object))]

	///<summary>
	///Returns the current live section.
	///</summary>
	public class GetLiveSection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLiveSection);

		}
	}


	[NVP_Manifest(
		Id = "B607FC39-E78D-4C6F-95FE-4B64A506B0BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionManager.GetUniqueSectionName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionManager", 
		NodeName = "GetUniqueSectionName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns a unique section name.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionManager", typeof(object))]
	[NodeInput("pBaseName", typeof(System.String))]

	///<summary>
	///Returns a unique section name.
	///</summary>
	public class GetUniqueSectionName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetUniqueSectionName(inputs[1].Value));

		}
	}
}
