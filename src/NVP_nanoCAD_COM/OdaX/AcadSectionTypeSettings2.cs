using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IAcadSectionTypeSettings2 Interface
///</summary>
namespace OdaX.AcadSectionTypeSettings2 
{

	[NVP_Manifest(
		Id = "716B1CE3-79FF-4B2B-A18D-F253286C3490", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings2.AcadSectionTypeSettings2_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings2", 
		NodeName = "_AcadSectionTypeSettings2_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSectionTypeSettings2_Constructor : INode 
	{
		public OdaX.IAcadSectionTypeSettings2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSectionTypeSettings2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "938EB564-E7E4-41F5-979F-B19830446AE3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings2.AcadSectionTypeSettings2_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings2", 
		NodeName = "_AcadSectionTypeSettings2_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSectionTypeSettings2_ConstructorCast : INode 
	{
		public OdaX.IAcadSectionTypeSettings2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSectionTypeSettings2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "34E027D5-8F53-4965-9FBA-F7E32D1453CB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings2.IntersectionBoundaryVisible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings2", 
		NodeName = "IntersectionBoundaryVisible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the visibility of intersection boundary", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings2", typeof(object))]

	///<summary>
	///Specifies the visibility of intersection boundary
	///</summary>
	public class IntersectionBoundaryVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryVisible);

		}
	}


	[NVP_Manifest(
		Id = "F435AF3C-1548-4B9F-9166-CB4251C2C4E4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings2.Set_IntersectionBoundaryVisible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings2", 
		NodeName = "Set_IntersectionBoundaryVisible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the visibility of intersection boundary", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings2", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies the visibility of intersection boundary
	///</summary>
	public class Set_IntersectionBoundaryVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryVisible = inputs[1].Value;
			return null;
		}
	}
}
