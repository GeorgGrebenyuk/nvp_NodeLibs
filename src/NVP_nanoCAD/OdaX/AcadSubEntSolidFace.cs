using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///Interface for a face on an AcDb3dSolid
///</summary>
namespace OdaX.AcadSubEntSolidFace 
{

	[NVP_Manifest(
		Id = "A841D99F-46E5-4BDD-91F0-AEE180613271", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSubEntSolidFace.AcadSubEntSolidFace_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSubEntSolidFace", 
		NodeName = "_AcadSubEntSolidFace_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSubEntSolidFace_Constructor : INode 
	{
		public OdaX.IAcadSubEntSolidFace _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSubEntSolidFace;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "CFB088E0-40DE-4FD5-947B-C7FE1268A55E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSubEntSolidFace.AcadSubEntSolidFace_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSubEntSolidFace", 
		NodeName = "_AcadSubEntSolidFace_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSubEntSolidFace_ConstructorCast : INode 
	{
		public OdaX.IAcadSubEntSolidFace _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSubEntSolidFace;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "29074424-CB41-47B3-82FC-5A4C191B8FD7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSubEntSolidFace.Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSubEntSolidFace", 
		NodeName = "Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the material", 
		ViewType = "Data")]
	[NodeInput("AcadSubEntSolidFace", typeof(object))]

	///<summary>
	///Specifies the material
	///</summary>
	public class Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Material);

		}
	}


	[NVP_Manifest(
		Id = "A3F844FC-7F7A-477C-9709-DED765D9C3D7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSubEntSolidFace.Set_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSubEntSolidFace", 
		NodeName = "Set_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the material", 
		ViewType = "Modifier")]
	[NodeInput("AcadSubEntSolidFace", typeof(object))]
	[NodeInput("Material", typeof(System.String))]

	///<summary>
	///Specifies the material
	///</summary>
	public class Set_Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Material = inputs[1].Value;
			return null;
		}
	}
}
