using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of an instance of an external reference inserted into a drawing
///</summary>
namespace OdaX.AcadExternalReference 
{

	[NVP_Manifest(
		Id = "15748F51-CC51-4E76-AE69-8354BEB8486C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadExternalReference.AcadExternalReference_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadExternalReference", 
		NodeName = "_AcadExternalReference_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadExternalReference_Constructor : INode 
	{
		public OdaX.IAcadExternalReference _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadExternalReference;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "BCACCE63-B680-48A5-9EDC-C7074861D0BD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadExternalReference.AcadExternalReference_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadExternalReference", 
		NodeName = "_AcadExternalReference_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadExternalReference_ConstructorCast : INode 
	{
		public OdaX.IAcadExternalReference _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadExternalReference;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "8176FE82-A1E8-49A6-8105-554B1E3C8BAF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadExternalReference.Path", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadExternalReference", 
		NodeName = "Path", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the source path of an external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadExternalReference", typeof(object))]

	///<summary>
	///Specifies or returns the source path of an external reference.
	///</summary>
	public class Path : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Path);

		}
	}


	[NVP_Manifest(
		Id = "898032B5-A03A-44E6-B189-09E5BD3AAD58", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadExternalReference.Set_Path", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadExternalReference", 
		NodeName = "Set_Path", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the source path of an external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadExternalReference", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the source path of an external reference.
	///</summary>
	public class Set_Path : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Path = inputs[1].Value;
			return null;
		}
	}
}
